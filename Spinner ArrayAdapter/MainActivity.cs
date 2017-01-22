using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections;

namespace Spinner_ArrayAdapter
{
    [Activity(Label = "Spinner ArrayAdapter", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Spinner sp;
        ArrayAdapter adapter;
        ArrayList players;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            sp = FindViewById<Spinner>(Resource.Id.sp);

            //FILL DATA
            getData();

            adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1,players);
            sp.Adapter = adapter;

            sp.ItemSelected += sp_ItemSelected;
        }

        void sp_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Toast.MakeText(this, players[e.Position].ToString(), ToastLength.Short).Show();
        }

        private void getData()
        {
            players = new ArrayList();
            players.Add("Juan Mata");
            players.Add("Jesus Navas");
            players.Add("John Barnes");
            players.Add("John Doe");
            players.Add("Joel CampBell");
            players.Add("John Moh");
            players.Add("Jose Mou");
            players.Add("Joe Aurorah");
            players.Add("Julius Finch");
            players.Add("July Sasha");
        }

        
    }
}

