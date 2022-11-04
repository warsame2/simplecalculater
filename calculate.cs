using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Test;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace simplecalculater
{
    [Activity(Label = "@string/cal" , Theme = "@style/AppTheme")]
    public class calculate : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.calculate);
            // Create your application here

            var button = FindViewById<Button>(Resource.Id.btncal);
            var txt2 = FindViewById<EditText>(Resource.Id.num1);
            var txt1= FindViewById<EditText>(Resource.Id.num2);
            var result= FindViewById<TextView>(Resource.Id.txtresult);




            //Define Spinner
            Spinner spinner = FindViewById<Spinner>(Resource.Id.spn);

            // dfeine data set
            //  List<string> scaleNames = new List<string>();
            //scaleNames.Add("+");
            /*
                        scaleNames.Add("-");
                        scaleNames.Add("x");
                        scaleNames.Add("/");
                        scaleNames.Add("%");
            */
            //asgin dataset
            //   var scaleAdapter = new ArrayAdapter<string>
            //  (this, Android.Resource.Layout.SimpleSpinnerItem, scaleNames);

            //   scaleAdapter.SetDropDownViewResource
            //   (Android.Resource.Layout.SimpleSpinnerDropDownItem);

            // spinner.Adapter = scaleAdapter;



            // button click evnet
             spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);

            string sub = spinner.SelectedItem.ToString();
            string add = spinner.SelectedItem.ToString();
            string mul = spinner.SelectedItem.ToString();
            string div = spinner.SelectedItem.ToString();
            string model = spinner.SelectedItem.ToString();
            /*
            spinner.ItemSelected += (s, e) =>
            {
                if (sub.Equals(spinner.SelectedItem.ToString()))
                {

                    txtresult.Text = (Convert.ToInt32(txt1.Text) - Convert.ToInt32(txt2.Text)).ToString();





                }



            };

            */




            button.Click += delegate {


                if (sub.Equals(sub.ToString()))

                {
                    result.Text = (Convert.ToInt32(txt1.Text) - Convert.ToInt32(txt2.Text)).ToString();

                }






                else if (add.Equals(add.ToString()))
                {

                    result.Text = (Convert.ToInt32(txt1.Text) + Convert.ToInt32(txt2.Text)).ToString();





                }


                else if (mul.Equals(spinner.SelectedItem.ToString()))
                {

                    result.Text = (Convert.ToInt32(txt1.Text) * Convert.ToInt32(txt2.Text)).ToString();





                }


                else if (div.Equals(spinner.SelectedItem.ToString()))
                {

                    result.Text = (Convert.ToInt32(txt1.Text) / Convert.ToInt32(txt2.Text)).ToString();





                }

                else if (model.Equals(spinner.SelectedItem.ToString()))
                {

                    result.Text = (Convert.ToInt32(txt1.Text) % Convert.ToInt32(txt2.Text)).ToString();


                }

                else
                {

                    Toast.MakeText(this, "You have selected: ", ToastLength.Short).Show();


                }






            };






        }


        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            string toast = string.Format("The planet is {0}", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }



    }
}