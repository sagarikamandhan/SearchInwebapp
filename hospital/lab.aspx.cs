using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=CJ\\SQLSAGARIKA;Initial Catalog=project;Integrated Security=True");
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter ad = new SqlDataAdapter();
    string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            filldatalist();
        }
    }
    private void filldatalist()
    {
        try
        {
            DataSet ds = new DataSet();
            string sa = "select * from category";
            cmd = new SqlCommand(sa, con);
            con.Open();
            ad = new SqlDataAdapter(cmd);
            ad.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i][1].ToString() == "Laboratory")
                    {
                        id = ds.Tables[0].Rows[i][0].ToString();
                    }
                }
            }
            DataSet ds1 = new DataSet();
            string sa1 = "select * from users where catid ='" + id + "'";
            cmd = new SqlCommand(sa1, con);
            con.Open();
            ad = new SqlDataAdapter(cmd);
            ad.Fill(ds1);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataList1.DataSource = ds1;
                DataList1.DataBind();
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.ToString());
        }
        finally
        {
            con.Close();
        }
    }
}