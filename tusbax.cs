using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace simplecalculater
{
    [Activity(Label = "tusbax", Theme = "@style/AppTheme")]
    public class tusbax : Activity
    {

        int current;

        int[] imgall =
        {
            Resource.Drawable.img1,Resource.Drawable.img2,Resource.Drawable.img3,Resource.Drawable.img4,Resource.Drawable.img5,
            Resource.Drawable.img6,Resource.Drawable.img7,Resource.Drawable.img8,Resource.Drawable.img9,Resource.Drawable.img10,
            Resource.Drawable.img11,Resource.Drawable.img12

        };

        ImageView imgzero;
        Button btn;
        TextView txtcont;


        NumberFormat numberFormat;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.tusbax);
            // Create your application here

            intview();
            onclik();


           





        }

        private void onclik()
        {
            btn.Click += delegate {

                current++;

                txtcont.Text = current.ToString();
              


                if (current >=33)
                {

                    current = 0;
                    imgzero.SetImageResource(imgall[1]);
                    
                }

               

                else if (current >= 33)
                {

                    
                    imgzero.SetImageResource(imgall[2]);
                    
                }


                else if (current >= 33)
                {

                    current = 0;
                    imgzero.SetImageResource(imgall[3]);
                   
                }





                else if (current >= 33)
                {

                    current = 0;
                    imgzero.SetImageResource(imgall[4]);
                    
                }




                else if (current >= 33)
                {

                    current = 0;
                    imgzero.SetImageResource(imgall[5]);
                    
                }





                else if (current >= 33)
                {

                    current = 0;
                    imgzero.SetImageResource(imgall[6]);
                    
                }




                else if (current >= 33)
                {

                    current = 0;
                    imgzero.SetImageResource(imgall[7]);
                    
                }





                else if (current >= 33)
                {

                    current = 0;
                    imgzero.SetImageResource(imgall[8]);
                    
                }





                else if (current >= 33)
                {

                    current = 0;
                    imgzero.SetImageResource(imgall[9]);
                    
                }




                else if (current >= 33)
                {

                    current = 0;
                    imgzero.SetImageResource(imgall[10]);
                    
                }





                else if (current >= 33)
                {


                    imgzero.SetImageResource(imgall[11]);


                     btn.Enabled = false;
                     txtcont.Enabled = false;
                }


                // btn.Enabled = false;
                //  txtcont.Enabled = false;


                // imgzero.SetImageResource(imgall[current]);



            };

        }

        private void intview()
        {
             btn = FindViewById<Button>(Resource.Id.btnnext);
            imgzero = FindViewById<ImageView>(Resource.Id.imgv);
            txtcont = FindViewById<TextView>(Resource.Id.txtcon);
        }

       
    }
}