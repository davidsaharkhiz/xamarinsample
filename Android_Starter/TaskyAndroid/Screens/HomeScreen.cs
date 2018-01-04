using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Tasky.Core;
using TaskyAndroid;
using Android.Net;

namespace TaskyAndroid.Screens {
	/// <summary>
	/// Main ListView screen displays a list of tasks, plus an [Add] button
	/// </summary>
	[Activity (Label = "David's Test App", MainLauncher = true, Icon="@drawable/icon")]			
	public class HomeScreen : Activity {
		Adapters.TaskListAdapter taskList;
		IList<Task> tasks;
		Button addTaskButton;
		ListView taskListView;
		TextView HighFiveCount;
		int highFiveCounter = 0;
		const string highFiveLabel = "High Five Count: ";
		
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// set our layout to be the home screen
			SetContentView(Resource.Layout.HomeScreen);

			//Find our controls
			//taskListView = FindViewById<ListView> (Resource.Id.TaskList);
			addTaskButton = FindViewById<Button> (Resource.Id.AddButton);
			HighFiveCount = FindViewById<TextView>(Resource.Id.HighFiveCount);

			// wire up add task button handler
			if (addTaskButton != null) {
				addTaskButton.Click += (sender, e) => {
					HighFiveCount.Text = highFiveLabel + ++highFiveCounter;
				};
			}
			
			// wire up task click handler
			if(taskListView != null) {
				taskListView.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => {
					var taskDetails = new Intent (this, typeof (TaskDetailsScreen));
					taskDetails.PutExtra ("TaskID", tasks[e.Position].ID);
					StartActivity (taskDetails);
				};
			}

		


		}
		
		protected override void OnResume ()
		{
			base.OnResume ();

			//tasks = TaskManager.GetTasks();
			
			// create our adapter
			//taskList = new Adapters.TaskListAdapter(this, tasks);

			//Hook up our adapter to our ListView
			//taskListView.Adapter = taskList;
		}
	}
}