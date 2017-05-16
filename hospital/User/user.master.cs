using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class User_user : System.Web.UI.MasterPage
{
    SqlConnection con = new SqlConnection("Data Source=CJ\\SQLSAGARIKA;Initial Catalog=project;Integrated Security=True");
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter ad = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            DataSet ds3 = new DataSet();
            string sa = "select * from users where uid ='" + Session["id"].ToString() + "'";
            cmd = new SqlCommand(sa, con);
            con.Open();
            ad = new SqlDataAdapter(cmd);
            ad.Fill(ds1);
            con.Close();
            if (ds1.Tables[0].Rows.Count > 0)
            {
                Label1.Text = ds1.Tables[0].Rows[0][6].ToString();
                profileimg.ImageUrl = ds1.Tables[0].Rows[0][11].ToString();
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
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["id"] = null;
        Session["name"] = null;
        Response.Redirect("../Default.aspx");
    }
}
