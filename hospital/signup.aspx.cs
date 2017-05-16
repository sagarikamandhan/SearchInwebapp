using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=CJ\\SQLSAGARIKA;Initial Catalog=project;Integrated Security=True");
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter ad = new SqlDataAdapter();
    string dp, map;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillregister();
            fillstate();
            fillspecialist();
            
        }
    }
    private void fillspecialist()
    {
        try
        {
            DataSet ds = new DataSet();
            string sa = "select * from specialist ";
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
                DropDownList2.Items.Insert(0, new ListItem("--select Specialist--", ""));
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
    private void fillregister()
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
            if(ds.Tables[0].Rows.Count > 0)
            {
                DropDownList1.DataTextField = ds.Tables[0].Columns[1].ToString();
                DropDownList1.DataValueField = ds.Tables[0].Columns[0].ToString();
                DropDownList1.DataSource = ds;
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("--Select Category--",""));
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
            if(ds.Tables[0].Rows.Count > 0)
            {
                DropDownList3.DataTextField = ds.Tables[0].Columns[1].ToString();
                DropDownList3.DataValueField = ds.Tables[0].Columns[0].ToString();
                DropDownList3.DataSource = ds;
                DropDownList3.DataBind();
                DropDownList3.Items.Insert(0, new ListItem("--Select State--",""));
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
    

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        string sa = "select * from city where sid = '" + DropDownList3.SelectedValue + "'";
        cmd = new SqlCommand(sa, con);
        con.Open();
        ad = new SqlDataAdapter(cmd);
        ad.Fill(ds);
        con.Close();
        if(ds.Tables[0].Rows.Count > 0)
        {
            DropDownList4.DataTextField = ds.Tables[0].Columns[1].ToString();
            DropDownList4.DataValueField = ds.Tables[0].Columns[0].ToString();
            DropDownList4.DataSource = ds;
            DropDownList4.DataBind();
            DropDownList4.Items.Insert(0, new ListItem("--select city--", ""));
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {
                if (FileUpload1.HasFile)
                {
                    dp = FileUpload1.PostedFile.FileName;
                    dp= "~/Uploaded/dp/" + dp;
                    FileUpload1.PostedFile.SaveAs(Server.MapPath(dp));
                }
                if (FileUpload2.HasFile)
                {
                    map = FileUpload2.PostedFile.FileName;
                    map = "~/Uploaded/map/" + map;
                    FileUpload2.PostedFile.SaveAs(Server.MapPath(map));
                }
                string sa = "insert into users(catid,spid,uname,uno,uemail,username,upass,sid,cid,address,udp,umap) values('" + DropDownList1.SelectedValue + "','" + DropDownList2.SelectedValue + "','" + TextBox1.Text
                        + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + DropDownList3.SelectedValue + "','" + DropDownList4.SelectedValue + "','" + TextBox7.Text + "','" + dp + "','" + map + "')";
                cmd = new SqlCommand(sa, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>$(document).ready(function () { $('#signup').modal('show');});</script>");
                Label14.Text = "You have successfully registered";
            }
            catch(Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                con.Close();
                DropDownList1.ClearSelection();
                DropDownList2.ClearSelection();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                DropDownList3.ClearSelection();
                DropDownList4.ClearSelection();
            }
        }
    }
}