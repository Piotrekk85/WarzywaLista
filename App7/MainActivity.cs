using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;

namespace App7
{
    [Activity(Label = "Warzywa", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        List<Warzywo> tablicaWarzywa = new List<Warzywo>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            tablicaWarzywa.Add(new Warzywo("Ogórki",2.34,Resource.Drawable.Ogorki));
            tablicaWarzywa.Add(new Warzywo("Pomidory", 0.56, Resource.Drawable.Pomidory));
            tablicaWarzywa.Add(new Warzywo("Marchew", 1.23, Resource.Drawable.Marchew));
            tablicaWarzywa.Add(new Warzywo("Cebula", 3.3, Resource.Drawable.Cebula));
            tablicaWarzywa.Add(new Warzywo("Buraki", 4.26, Resource.Drawable.Buraki));

            ListView.ChoiceMode = ChoiceMode.Multiple;
           

            ListAdapter = new WarzywoAdapter(this, tablicaWarzywa);
        }
        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            var t = tablicaWarzywa[position];
            Toast.MakeText(this, t.Nazwa, ToastLength.Short).Show();
        }
    }
}

