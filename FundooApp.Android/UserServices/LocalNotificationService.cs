using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using FundooApp.Droid.UserServices;
using FundooApp.Model;
using Java.Lang;

[assembly: Xamarin.Forms.Dependency(typeof(LocalNotificationService))]
namespace FundooApp.Droid.UserServices
{
  public  class LocalNotificationService: Interfaces.ILocalNotificationService
    {
        int _notificationIconId { get; set; }
        readonly DateTime _jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        internal string _randomNumber;
        public Model.LocalNotification localNotification = new Model.LocalNotification();
        public void LocalNotification(string title, string body, int id, DateTime notifyTime)
        {

            //long repeateDay = 1000 * 60 * 60 * 24;       
           long repeateForMinute = 60000; // In milliseconds      
           long totalMilliSeconds = (long)(notifyTime.ToUniversalTime() - _jan1st1970).TotalMilliseconds;
            if (totalMilliSeconds < JavaSystem.CurrentTimeMillis())
            {
                totalMilliSeconds = totalMilliSeconds + repeateForMinute;
            }

            var intent = CreateIntent(id);

            localNotification.Title = title;
            localNotification.Body = body;
            localNotification.Id = id;
            localNotification.NotifyTime = notifyTime;
            // this._notificationIconId = 1;
            if (_notificationIconId != 0)
            {
                localNotification.IconId = _notificationIconId;
            }
            else
            {
                localNotification.IconId = Resource.Drawable.rem2;
            }

            var serializedNotification = SerializeNotification(localNotification);
            intent.PutExtra(ScheduledAlarmHandler.LocalNotificationKey, serializedNotification);

            Random generator = new Random();
            _randomNumber = generator.Next(100000, 999999).ToString("D6");

            var pendingIntent = PendingIntent.GetBroadcast(Application.Context, Convert.ToInt32(_randomNumber), intent, PendingIntentFlags.OneShot);
            var alarmManager = GetAlarmManager();
            alarmManager.SetRepeating(AlarmType.RtcWakeup, totalMilliSeconds, repeateForMinute, pendingIntent);
        }

        public static Intent GetLauncherActivity()
        {

            var packageName = Application.Context.PackageName;
            return Application.Context.PackageManager.GetLaunchIntentForPackage(packageName);
        }

        public void Cancel(int id)
        {
            
            var intent = CreateIntent(id);
            var pendingIntent = PendingIntent.GetBroadcast(Application.Context, Convert.ToInt32(_randomNumber), intent, PendingIntentFlags.OneShot);
            var alarmManager = GetAlarmManager();
            alarmManager.Cancel(pendingIntent);
            var notificationManager = NotificationManagerCompat.From(Application.Context);
            notificationManager.CancelAll();
            notificationManager.Cancel(id);
        }
        private Intent CreateIntent(int id)
        {

            return new Intent(Application.Context, typeof(ScheduledAlarmHandler))
                .SetAction("LocalNotifierIntent" + id);
        }

        private AlarmManager GetAlarmManager()
        {

            var alarmManager = Application.Context.GetSystemService(Context.AlarmService) as AlarmManager;
            return alarmManager;
        }

        private string SerializeNotification(LocalNotification notification)
        {

            var xmlSerializer = new XmlSerializer(notification.GetType());

            using (var stringWriter = new StringWriter())
            {
                xmlSerializer.Serialize(stringWriter, notification);
                return stringWriter.ToString();
            }
        }


  }

    [BroadcastReceiver(Enabled = true, Label = "Local Notifications Broadcast Receiver")]
    public class ScheduledAlarmHandler : BroadcastReceiver
    {

        public const string LocalNotificationKey = "LocalNotification";

        public override void OnReceive(Context context, Intent intent)
        {
            var intent1 = new Intent(context, typeof(MainActivity));
            intent1.AddFlags(ActivityFlags.ClearTop);
            var extra = intent.GetStringExtra(LocalNotificationKey);
            var notification = DeserializeNotification(extra);
            string CHANNEL_ID = "my_channel_id_01";
            Random random = new Random();
            int randomNumber = random.Next(9999 - 1000) + 1000;
            var pendingIntent = PendingIntent.GetActivity(Application.Context, randomNumber, intent1, PendingIntentFlags.OneShot);
            // var resultIntent = LocalNotificationService.GetLauncherActivity();

            NotificationCompat.Builder builder = new NotificationCompat.Builder(Application.Context, CHANNEL_ID)
          .SetContentTitle(notification.Title)
          .SetContentText(notification.Body)
          .SetContentIntent(pendingIntent)
          .SetSmallIcon(Resource.Drawable.rem2);

            // Build the notification:
            Notification notification1 = builder.Build();
           
            NotificationManager notificationManager = context.GetSystemService(Context.NotificationService) as NotificationManager;

            // Publish the notification:
            const int notificationId = 0;
            notificationManager.Notify(notificationId, notification1);

        }


        private LocalNotification DeserializeNotification(string notificationString)
        {

            var xmlSerializer = new XmlSerializer(typeof(LocalNotification));
            using (var stringReader = new StringReader(notificationString))
            {
                var notification = (LocalNotification)xmlSerializer.Deserialize(stringReader);
                return notification;
            }
        }
    }
}