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
    int select;
    string sa;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillspecialist();
            filldatalist();
        }
        
    }
    private void fillspecialist()
    {
        try
        {
            DataSet ds = new DataSet();
            string sa = "select * from specialist";
            cmd = new SqlCommand(sa, con);
            con.Open();
            ad = new SqlDataAdapter(cmd);
            ad.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DropDownList1.DataTextField = ds.Tables[0].Columns[1].ToString();
                DropDownList1.DataValueField = ds.Tables[0].Columns[0].ToString();
                DropDownList1.DataSource = ds;
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("--specialist--"));
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
    private void filldatalist()
    {
        try
        {
            DataSet ds = new DataSet();
            if(Request.QueryString["cid"] == "")
            {
                sa = "select * from users where sid='" + Request.QueryString["sid"] + "' and catid='" + Request.QueryString["catid"] + "'";
            }
            else if(Request.QueryString["sid"] == "")
            {
                sa = "select * from users where cid='" + Request.QueryString["cid"] + "' and catid='" + Request.QueryString["catid"] + "'";
            }
            else
            {
               sa = "select * from users where sid ='" + Request.QueryString["sid"] + "' and cid ='" + Request.QueryString["cid"] + "'and catid='" + Request.QueryString["catid"] + "'";
            }
            
            cmd = new SqlCommand(sa, con);
            con.Open();
            ad = new SqlDataAdapter(cmd);
            ad.Fill(ds);
            con.Close();
            if(ds.Tables[0].Rows.Count > 0)
            {
                DataList1.DataSource = ds;
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