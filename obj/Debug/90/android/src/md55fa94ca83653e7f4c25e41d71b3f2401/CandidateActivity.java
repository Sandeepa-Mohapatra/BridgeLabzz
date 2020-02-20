package md55fa94ca83653e7f4c25e41d71b3f2401;


public class CandidateActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("FundooWalkin.CandidateActivity, FundooWalkin", CandidateActivity.class, __md_methods);
	}


	public CandidateActivity ()
	{
		super ();
		if (getClass () == CandidateActivity.class)
			mono.android.TypeManager.Activate ("FundooWalkin.CandidateActivity, FundooWalkin", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
