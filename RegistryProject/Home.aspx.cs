using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Win32;
namespace RegistryProject
{
    public partial class Home : System.Web.UI.Page
    {
        static String pathStr = "";
        static String AddToPath = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            String s = (String)Session["FN"];
            // Data.Text = Session["FN"].ToString() + Session["LN"].ToString();
            //  HomeName.Text = Session["FN"].ToString() +" "+ Session["LN"].ToString();
            //  Email.Text = Session["LN"].ToString();
//            AAAA.Text = "<h1>Hi this is the text</h1>";
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\ProjectLogin\\login");
            string x = "";
            string[] keys = rk.GetSubKeyNames();
            for (int i = 0; i < rk.SubKeyCount; i++)
            {
                String keyName = keys[i];
//                RegistryKey rk2=Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\ProjectLogin\\login");text-shadow: 3px 2px red 
                x = x + "<p > <div style='color:red;text-transform: uppercase; font-style: italic;font-weight: bold;'>" + keyName +"</div> ";
//                                Console.WriteLine(keyName);
//                              string[] subkeys = rk.OpenSubKey(keyName).GetSubKeyNames();
                RegistryKey rka = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\ProjectLogin\\login\\"+keyName);
                string[] subkeys = rka.GetValueNames();
                for (int j = 0; j < subkeys.Length; j++)
                                {
                                    String subkeyName = subkeys[j];
                                    x = x+" " +  subkeyName+"-"+rka.GetValue(subkeyName)+";";
//                                    Console.WriteLine(rk.OpenSubKey(keyName).GetValue(subkeyName));
                                }
                        x = x  +  "   </p>";
//                                x = x + "<br />";

            }
            /*            RegistryKey rk2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\ProjectLogin\\login\\User-nishu");
                        x = x + "<p>" + rk2.GetValue("name") + " </p>";
                        RegistryKey rk3 = rk.OpenSubKey(keys[0]);
                        string[] n = rk3.GetSubKeyNames();
                        for(int l = 0; l < n.Length; l++)
                        {
                            x = x + rk3.GetValue(n[l]);
                        }
            */
            AAAA.Text = x;
        }

        protected void Show_current()
        {
        }

        protected void Path_Load(object sender, EventArgs e)
        {

        }

        

        protected void GOTO_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistryTree.aspx");
        }
    }

}
