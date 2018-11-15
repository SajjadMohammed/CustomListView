using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

using v7Toolbar = Android.Support.V7.Widget.Toolbar;

namespace CustomListView
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private v7Toolbar mainToolbar;
        private  ListView employeeList;
        private EmployeeAdapter employeeAdapter;
        string[] employeeNames;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            mainToolbar = FindViewById<v7Toolbar>(Resource.Id.main_toolbar);
            SetSupportActionBar(mainToolbar);

            employeeList = FindViewById<ListView>(Resource.Id.employee_listview);

           employeeNames  = Resources.GetStringArray(Resource.Array.employeeArray);

            employeeAdapter = new EmployeeAdapter(this, 0, employeeNames);
            employeeList.Adapter = employeeAdapter;


            employeeList.ItemClick += EmployeeList_ItemClick;
        }

        private void EmployeeList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, employeeNames[e.Position], ToastLength.Long).Show();
        }
    }
}