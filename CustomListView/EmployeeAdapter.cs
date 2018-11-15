using Android.Content;
using Android.Views;
using Android.Widget;

namespace CustomListView
{
    internal class EmployeeAdapter : ArrayAdapter<string>
    {
        private readonly string[] employeeNames;
        private readonly Context context;

        public EmployeeAdapter(Context context, int textViewResourceId, string[] objects) : base(context, textViewResourceId, objects)
        {
            employeeNames = objects;
            this.context = context;
        }

        public override int Count => base.Count;

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = LayoutInflater.From(context).Inflate(Resource.Layout.list_item, null);

            TextView employeeName = view.FindViewById<TextView>(Resource.Id.employee_name);
            employeeName.Text = GetItem(position);

            return view;
        }
    }
}