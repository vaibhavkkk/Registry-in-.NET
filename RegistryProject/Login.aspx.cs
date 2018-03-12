using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Win32;
namespace RegistryProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\ProjectLogin\\login\\User-" + LogUname.Text, true); ;
            if (rk == null)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Myscript1", @"alert('UserName not Found , Account doesn't exists ');", true);
            }
            else
            {
                //                Label1.Text = "Created directory Found!!";
                if (rk.GetValue("Uname").Equals(LogUname.Text))
                {
                    if (rk.GetValue("Pass").Equals(LogPass.Text))
                    {
                        Session["FN"] = rk.GetValue("FName");
                        Session["LN"] = rk.GetValue("Email");
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Myscript1", @"alert('Wrong Password , Try Again !!');", true);
                    }
                }

            }
        }
    }
}