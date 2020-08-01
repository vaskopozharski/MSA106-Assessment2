using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myApplicationCAllingMicroService
{
    public partial class _Default : Page
    {

        protected void Button1_Click(object sender, EventArgs e)
        {
            var url="";
            var client = new WebClient();
            var x = (Button)sender;
           if( x.ID.Equals("Button1"))
            {
                url = "https://localhost:44341/price?me=1";
                
            }if (x.ID.Equals("Button2"))
            {
                url = "https://localhost:44341/price?me=2";
             
            }
            if (x.ID.Equals("Button3"))
            {
                url = "https://localhost:44341/price?me=3";
                
            }
            string temp = "";
            string response = client.DownloadString(url);
            if (!string.IsNullOrEmpty(response))
            {
               
                temp = response.ToString();

            }

            if (x.ID.Equals("Button1"))
            {
                Label1.Text = temp;

            }
            if (x.ID.Equals("Button2"))
            {
                Label2.Text = temp;

            }
            if (x.ID.Equals("Button3"))
            {
                Label3.Text = temp;

            }


           
        }
    }
}

namespace myApplicationCAllingMicroService
{
    public partial class _Default : Page
    {

        protected void Button2_Click(object sender, EventArgs e)
        {
            var url = "";
            var client = new WebClient();
            var x = (Button)sender;
            if (x.ID.Equals("Button4"))
            {
                url = "https://localhost:44341/qty?me=1";

            }
            if (x.ID.Equals("Button5"))
            {
                url = "https://localhost:44341/qty?me=2";

            }
            if (x.ID.Equals("Button6"))
            {
                url = "https://localhost:44341/qty?me=3";

            }
            string temp = "";
            string response = client.DownloadString(url);
            if (!string.IsNullOrEmpty(response))
            {

                temp = response.ToString();

            }

            if (x.ID.Equals("Button4"))
            {
                Label4.Text = temp;

            }
            if (x.ID.Equals("Button5"))
            {
                Label5.Text = temp;

            }
            if (x.ID.Equals("Button6"))
            {
                Label6.Text = temp;

            }



        }
    }
}