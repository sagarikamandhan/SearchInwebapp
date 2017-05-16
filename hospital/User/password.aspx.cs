using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class User_Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=CJ\\SQLSAGARIKA;Initial Catalog=project;Integrated Security=True");
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter ad = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
        try
        {
            DataSet ds = new DataSet();
            string sa = "select * from users where uid ='" + Session["id"] + "'";
            cmd = new SqlCommand(sa, con);
            con.Open();
            ad = new SqlDataAdapter(cmd);
            ad.Fill(ds);
            con.Close();
            if(ds.Tables[0].Rows.Count > 0)
            {
                string pass = ds.Tables[0].Rows[0][7].ToString();
                if (TextBox1.Text == pass)
                {
                    string user ="update users set upass='"+TextBox2.Text+"' where uid='"+Session["id"]+"'";
                    cmd = new SqlCommand(user, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Label3.Text = "Your Password has been changed";
                }
                else
                {
                    Label3.Text = "Old Password doesn't match";
                }
            }
            

        }
        catch(Exception ex)
        {
            Response.Write(ex.ToString());
        }
        finally
        {
            con.Close();
        }
    }
}