package md5ec328c3602e97c96588f48715b69166b;


public class TaskDetailsScreen
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
		mono.android.Runtime.register ("TaskyAndroid.Screens.TaskDetailsScreen, TaskyAndroid, Version=1.0.6576.27658, Culture=neutral, PublicKeyToken=null", TaskDetailsScreen.class, __md_methods);
	}


	public TaskDetailsScreen () throws java.lang.Throwable
	{
		super ();
		if (getClass () == TaskDetailsScreen.class)
			mono.android.TypeManager.Activate ("TaskyAndroid.Screens.TaskDetailsScreen, TaskyAndroid, Version=1.0.6576.27658, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
