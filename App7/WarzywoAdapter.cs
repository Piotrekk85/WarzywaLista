using Android.App;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace App7
{
    class WarzywoAdapter : BaseAdapter<Warzywo>
    {
        List<Warzywo> items;
        Activity context;
        public WarzywoAdapter(Activity context, List<Warzywo> items)
            : base()
        {
            this.context = context;
            this.items = items;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override Warzywo this[int position]
        {
            get { return items[position]; }
        }
        public override int Count
        {
            get { return items.Count; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];

            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.TestListItem, null);
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Nazwa;

            return view;
        }
    }
}