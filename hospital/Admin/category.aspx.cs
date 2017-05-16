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
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fill();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        try
        {
            if (ViewState["aa"] == null)
            {

                string sa = "insert into category (catname) values ('" + name + "')";
                cmd = new SqlCommand(sa, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                fill();
            }
            else
            {
                string sa = "update category set catname='" + name + "' where catid='" + ViewState["aa"] + "' ";
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
        }
    }
         private void fill()
         {
            try
            {
                string sa = "select * from category";
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

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "delete")
            {
                string sa = " delete from category where catid='" + e.CommandArgument + "' ";
                cmd = new SqlCommand(sa, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                fill();
            }
            else if (e.CommandName == "edit")
            {
                string sa = "select * from category where catid ='" + e.CommandArgument + "'  ";
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