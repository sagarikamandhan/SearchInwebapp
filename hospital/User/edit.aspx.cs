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
    string dp, map;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillstate();
            fillspecialist();

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
                DropDownList1.Items.Insert(0, new ListItem("--select Specialist--"));
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
                DropDownList2.DataTextField = ds.Tables[0].Columns[1].ToString();
                DropDownList2.DataValueField = ds.Tables[0].Columns[0].ToString();
                DropDownList2.DataSource = ds;
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("--Select State--", ""));
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

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DataSet ds = new DataSet();
            string sa = "select * from city where sid = '" + DropDownList2.SelectedValue + "'";
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
                DropDownList3.Items.Insert(0, new ListItem("--select city--"));
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload2.HasFile)
        {
            dp = FileUpload2.PostedFile.FileName;
            dp = "~/Uploaded/dp/" + dp;
            FileUpload2.PostedFile.SaveAs(Server.MapPath(dp));
        }
        Image2.ImageUrl = dp;
    }


    protected void Button2_Click(object sender, EventArgs e)
    {

        if (FileUpload1.HasFile)
        {
            map = FileUpload1.PostedFile.FileName;
            map = "~/Uploaded/map/" + map;
            FileUpload1.PostedFile.SaveAs(Server.MapPath(map));
        }
        Image1.ImageUrl = map;
    }
    private void fillfields()
    {
        
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            fillfields();

            string sa = "update users set spid ='" + DropDownList1.SelectedValue + "',sid='" + DropDownList2.SelectedValue + "',cid='" + DropDownList3.SelectedValue + "',uno='" + TextBox3.Text + "',uemail='" + TextBox4.Text + "',address='" + TextBox5.Text + "',udp='" + dp + "',umap='" + map + "' where uid='"+Session["id"]+"'";
            cmd = new SqlCommand(sa, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
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