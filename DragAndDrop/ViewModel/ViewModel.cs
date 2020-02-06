using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace DragAndDrop
{
    public class ViewModel : INotifyPropertyChanged
    {
        #region Fields

        private ObservableCollection<ToDoItem> toDoList;
        private ObservableCollection<ToDoItem> newList;
        #endregion

        #region Constructor

        public ViewModel()
        {
            this.GenerateSource();
        }

        #endregion

        #region Property

        public ObservableCollection<ToDoItem> ToDoList
        {
            get
            {
                return toDoList;
            }
            set
            {
                this.toDoList = value;
            }
        }
        public ObservableCollection<ToDoItem> NewList
        {
            get
            {
                return newList;
            }
            set
            {
                this.newList = value;
                OnPropertyChanged("NewList");
            }
        }

        #endregion

        #region Method

        public void GenerateSource()
        {
            ToDoListRepository todoRepository = new ToDoListRepository();
            toDoList = todoRepository.GetToDoList();
            NewList = new ObservableCollection<ToDoItem>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
