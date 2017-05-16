using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=CJ\\SQLSAGARIKA;Initial Catalog=project;Integrated Security=True");
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter ad = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillcategory();
            fillstate();
        }
    }
    private void fillcategory()
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
            DropDownList3.DataTextField = ds.Tables[0].Columns[1].ToString();
            DropDownList3.DataValueField = ds.Tables[0].Columns[0].ToString();
            DropDownList3.DataSource = ds;
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, new ListItem("--Select Category--","0"));
        }
    }
    private void fillstate()
    {
        try
        {
            DataSet ds = new DataSet();
            string sa = "select * from state";
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
                DropDownList1.Items.Insert(0, new ListItem("--select state--",""));
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
    private void fillcity()
    {

        DataSet ds = new DataSet();
        string sa = "select * from city where sid='" + DropDownList1.SelectedValue + "'";
        cmd = new SqlCommand(sa, con);
        con.Open();
        ad = new SqlDataAdapter(cmd);
        ad.Fill(ds);
        con.Close();
        DropDownList2.DataTextField = ds.Tables[0].Columns[1].ToString();
        DropDownList2.DataValueField = ds.Tables[0].Columns[0].ToString();
        DropDownList2.DataSource = ds;
        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, new ListItem("--select city--",""));


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            string sid = DropDownList1.SelectedValue;
            string cid = DropDownList2.SelectedValue;
            string catid = DropDownList3.SelectedValue;
            Response.Redirect("searched.aspx?sid=" + sid + "&cid=" + cid + "&catid=" + catid);
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

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        fillcity();
    }
}