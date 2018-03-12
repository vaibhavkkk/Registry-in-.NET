using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Win32;
namespace RegistryProject
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Reg_Click(object sender, EventArgs e)
        {
            if (RegPass2.Text.Equals(RegPass.Text))
            { 
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\ProjectLogin\\login\\User-" + RegUname.Text,true);
            if (rk == null)
            {
                rk = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\ProjectLogin\\login\\User-" + RegUname.Text);
            }
            rk.SetValue("Fname", RegName.Text);
            rk.SetValue("Email", RegEmail.Text);
            rk.SetValue("Uname", RegUname.Text);
            rk.SetValue("Pass", RegPass.Text);

                Response.Redirect("Login.aspx");
            }else
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Myscript1", @"alert('Confirm Password don't match !!');", true);
            }
        }
    }
}