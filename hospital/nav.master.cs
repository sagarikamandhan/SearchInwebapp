using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class nav : System.Web.UI.MasterPage
{
    SqlConnection con = new SqlConnection("Data Source=CJ\\SQLSAGARIKA;Initial Catalog=project;Integrated Security=True");
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter ad = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        string sa = "select * from users";
        cmd = new SqlCommand(sa, con);
        con.Open();
        ad = new SqlDataAdapter(cmd);
        ad.Fill(ds);
        con.Close();
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            if (TextBox1.Text == ds.Tables[0].Rows[i][6].ToString())
            {
                if (TextBox2.Text == ds.Tables[0].Rows[i][7].ToString())
                {
                    Session["id"] = ds.Tables[0].Rows[i][0].ToString();
                    Response.Redirect("User/Default.aspx");
                }
            }
        }
        Response.Write("<script>alert('invalid credentials');</script>");
    }
}
