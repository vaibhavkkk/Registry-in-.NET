using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Win32;
namespace RegistryProject
{
    public partial class RegistryTree : System.Web.UI.Page
    {
        static String pathStr = "";
        static String AddToPath = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //            TreeNode tn = new TreeNode("ProjectLogin");
            //            TreeView1.Nodes.Add(tn);
            //            TreeNode a = new TreeNode("1");
            //            TreeNode b = new TreeNode("2");
            //            TreeNode c = new TreeNode("3");
            //            TreeNode d = new TreeNode("4");
            //            TreeNode ef = new TreeNode("5");
            //            TreeNode f = new TreeNode("5");
            //            TreeNode g = new TreeNode("6");
            //            tn.ChildNodes.Add(a);
            //            a.ChildNodes.Add(a);

//            TreeNode tn = new TreeNode("ProjectLogin");
//            TreeView1.Nodes.Add(tn);
//            Show("\\ProjectLogin", tn);
            //                       Show("\\ProjectLogin", tn);

            /*            RegistryKey rk = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\ProjectLogin\\login");
                        string[] s = rk.GetSubKeyNames();
                        for (int i = 0; i < s.Length; i++)
                        {
                            TreeNode treeNode = new TreeNode(s[i]);
                            TreeView1.Nodes.Add(treeNode);
                            RegistryKey rk1 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\ProjectLogin\\login\\" + s[i]);
                            string[] v = rk1.GetValueNames();
                            for (int j = 0; j < v.Length; j++)
                            {
                                String x = v[j];
                                TreeNode n = new TreeNode(v[j]);
                                treeNode.ChildNodes.Add(n);
                                String t = (String)rk1.GetValue(x);
                                n.ChildNodes.Add(new TreeNode(t));
                            }
                            TreeNode node2 = new TreeNode("C#");
                            TreeNode node3 = new TreeNode("VB.NET");
                            //                treeNode.ChildNodes.Add(node2);
                            //                node2.ChildNodes.Add(node3);
                            TreeNode[] array = new TreeNode[] { node2, node3 };
                            //                treeNode = new TreeNode("Dot Net Perls", array);
                            //                TreeView1.Nodes.Add(treeNode);
                        }

            */
        }
        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            getPath();
        }

        protected string getPath()
        {
            TreeNode node = this.TreeView1.SelectedNode;
            pathStr = node.Text;
            string separator = "\\";


            TreeView1.PathSeparator = Convert.ToChar(separator);


            while (node.Parent != null)
            {
                //this.TreeView1.PathSeparator
                pathStr = node.Parent.Text + separator + pathStr;
                node = node.Parent;
            }

            Path.Text = pathStr;
            return pathStr;
        }
/*
        protected void cmnuRemoveNode_Click(object sender, EventArgs e)
        {
            RegistryKey rks = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\ProjectLogin\\RegistryKeys");
            string[] s = rks.GetSubKeyNames();
            for (int i = 0; i < s.Length; i++)
            {
                TreeNode treeNode = new TreeNode(s[i]);
                TreeView1.Nodes.Add(treeNode);
                if (rks.GetType ==)
                   RegistryKey rkv = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\ProjectLogin\\login\\" + s[i]);
                string[] v = rk1.GetValueNames();
                for (int j = 0; j < v.Length; j++)
                {
                    String x = v[j];
                    TreeNode n = new TreeNode(v[j]);
                    treeNode.ChildNodes.Add(n);
                    String t = (String)rk1.GetValue(x);
                    n.ChildNodes.Add(new TreeNode(t));
                }
                TreeNode node2 = new TreeNode("C#");
                TreeNode node3 = new TreeNode("VB.NET");
                //                treeNode.ChildNodes.Add(node2);
                //                node2.ChildNodes.Add(node3);
                TreeNode[] array = new TreeNode[] { node2, node3 };
                //                treeNode = new TreeNode("Dot Net Perls", array);
                //                TreeView1.Nodes.Add(treeNode);
            }
        }
        */
        protected void ShowAll_Click(object sender, EventArgs e)
        {
            DoitBro();
        }

        protected void DoitBro()
        {
            if (TreeView1 != null)
            {
                TreeNode tn = new TreeNode("ProjectLogin");
                TreeView1.Nodes.Add(tn);
                Show("\\ProjectLogin", tn);
            }
        }

        protected void ExpandAll_Click(object sender, EventArgs e)
        {
            TreeView1.ExpandAll();
           
//            String s=Console.ReadLine();
            //TreeView1.Nodes[0].ChildNodes.Clear();
        }
        protected static void Show(String path, TreeNode x)
        {
            RegistryKey rkz = Registry.CurrentUser.OpenSubKey("Software\\Microsoft" + path);
            try {
                string[] subkeys = rkz.GetSubKeyNames();
                //TreeNode l = new TreeNode(subkeys[0]);
                // x.ChildNodes.Add(l);
                // x.ChildNodes.Add(new TreeNode { subkeys[0].ToString } );

                if (subkeys.Length == 0)
                {
                    string[] subNames = rkz.GetValueNames();
                    for (int j = 0; j < subNames.Length; j++)
                    {
                        String str = subNames[j];
                        TreeNode n = new TreeNode(subNames[j]);
                        x.ChildNodes.Add(n);
                        String t = (String)rkz.GetValue(str);
                        n.ChildNodes.Add(new TreeNode(t));
                    }
                    return;
                }
                else
                {
                    for (int i = 0; i < subkeys.Length; i++)
                    {
                        TreeNode a = new TreeNode(subkeys[i]);
                        x.ChildNodes.Add(a);
                        String pp2 = path;
                        Show(path += "\\" + subkeys[i], a);
                        path = pp2;
                    }
                }
                return;
            }
            catch(Exception e)
            {
                e.GetType();
            }
            }
        protected void Show_current()
        {
        }

        protected void Path_Load(object sender, EventArgs e)
        {
            
        }

        protected void AddKey_Click(object sender, EventArgs e)
        {
            TreeView1.Nodes.Clear();
            DoitBro();
        }
        

        protected void Btn_Delete_Click(object sender, EventArgs e)
        {
            RegistryKey add = Registry.CurrentUser.OpenSubKey("Software\\Microsoft" + pathStr,true);
            String[] s = pathStr.Split('\\');
            String k = "";
            for(int i = 0; i < s.Length-1; i ++)
            {
                k = k + "\\" + s[i];
            }
            Path.Text = k;
            RegistryKey add2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft" + k,true);
            try
            {
                add2.DeleteSubKeyTree(s[s.Length - 1]);
            }
            catch
            {
                
                add2.DeleteValue(s[s.Length - 1]);
            }
//            Registry.CurrentUser.DeleteSubKeyTree("Software\\Microsoft" + pathStr);
            TreeView1.Nodes.Clear();
            DoitBro();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TB_Create.Equals(null))
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Myscript1", @"alert('Text is Empty, Enter the name of subkey to be created !!');", true);

            }
            else
            {
                Path.Text = "Software\\Microsoft\\" + pathStr;
                RegistryKey add = Registry.CurrentUser.OpenSubKey("Software\\Microsoft" + pathStr);

                if (add == null)
                {
                    add = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\" + pathStr + "\\"+TB_Create.Text);
                    Path.Text = "Created";
                }
                //            Path.Text = "Software\\Microsoft\\" + pathStr;
                if(T1.Text!="" & T2.Text != "")
                {
                    add.SetValue(T1.Text, T2.Text);

                }
            }
            TreeView1.Nodes.Clear();
            DoitBro();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            RegistryKey add = Registry.CurrentUser.OpenSubKey("Software\\Microsoft" + pathStr, true);
            String[] s = pathStr.Split('\\');
            String k = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                k = k + "\\" + s[i];
            }
            Path.Text = k;
            RegistryKey add2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft" + k, true);
            try
            {
                add2.DeleteValue(s[s.Length - 1]);
                add2.SetValue(s[s.Length - 1], TB_Update_Value.Text);
            }
            catch
            {

            }

            Path.Text = "Software\\Microsoft\\" + pathStr;
//            RegistryKey add = Registry.CurrentUser.OpenSubKey("Software\\Microsoft" + pathStr);
//            add.SetValue(TB_Update_Name.Text,TB_Update_Value.Text);
            TreeView1.Nodes.Clear();
            DoitBro();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            RegistryKey add4 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft" + getPath(), true);
            
                add4.SetValue(T1.Text, T2.Text);
            
        }

        protected void GoToHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
        
        protected void ExpandAl_Click(object sender, EventArgs e)
        {
            TreeView1.CollapseAll();
        }
    }
    }
    
