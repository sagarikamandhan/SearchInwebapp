using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin_Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=CJ\\SQLSAGARIKA;Initial Catalog=project;Integrated Security=True");
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter ad = new SqlDataAdapter();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fill();
            filldd();
        }
    }
    private void fill()
    {
        try
        {
            DataSet ds = new DataSet();
            string sa = "select * from city";
            cmd = new SqlCommand(sa, con);
            con.Open();
            ad = new SqlDataAdapter(cmd);
            ad.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
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
    private void filldd()
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
                DropDownList1.Items.Insert(0, new ListItem("--select state---"));
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        try
        {
            if (ViewState["aa"] == null)
            {

                string sa = "insert into city (cname,sid) values ('" + name + "','"+DropDownList1.SelectedValue+"')";
                cmd = new SqlCommand(sa, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                fill();
            }
            else
            {
                string sa = "update city set cname='" + name + "' where cid='" + ViewState["aa"] + "' ";
                cmd = new SqlCommand(sa, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                fill();
                Button1.Text = "Submit";
                ViewState["aa"] = null;
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.ToString());
        }
        finally
        {
            con.Close();
            TextBox1.Text = "";
            DropDownList1.ClearSelection();
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "delete")
            {
                string sa = " delete from city where cid='" + e.CommandArgument + "' ";
                cmd = new SqlCommand(sa, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                fill();
            }
            else if (e.CommandName == "edit")
            {
                DataSet ds = new DataSet();
                string sa = "select * from city where cid ='" + e.CommandArgument + "'  ";
                cmd = new SqlCommand(sa, con);
                con.Open();
                ad = new SqlDataAdapter(cmd);
                ad.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    TextBox1.Text = ds.Tables[0].Rows[0][1].ToString();
                    ViewState["aa"] = ds.Tables[0].Rows[0][0].ToString();
                }
                Button1.Text = "Update";
                con.Close();
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

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
}