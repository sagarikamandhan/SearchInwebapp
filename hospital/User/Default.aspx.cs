using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class User_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=CJ\\SQLSAGARIKA;Initial Catalog=project;Integrated Security=True");
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter ad = new SqlDataAdapter();
    string photo,postfile;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            DataSet ds3 = new DataSet();
            string sa = "select * from users where uid ='" + Session["id"].ToString() + "'";
            cmd = new SqlCommand(sa,con);
            con.Open();
            ad = new SqlDataAdapter(cmd);
            ad.Fill(ds1);
            con.Close();
            if (ds1.Tables[0].Rows.Count > 0)
            {
                Label2.Text = ds1.Tables[0].Rows[0][3].ToString();
                Label9.Text = ds1.Tables[0].Rows[0][4].ToString();
                Label11.Text= ds1.Tables[0].Rows[0][5].ToString();
                Label13.Text = ds1.Tables[0].Rows[0][10].ToString();
                Image1.ImageUrl = ds1.Tables[0].Rows[0][12].ToString();
            }
            string sa1 = "select * from specialist where spid = '"+ds1.Tables[0].Rows[0][2].ToString()+"'";
            SqlCommand cmd1 = new SqlCommand(sa1, con);
            con.Open();
            SqlDataAdapter ad1 = new SqlDataAdapter(cmd1);
            ad1.Fill(ds2);
            con.Close();
            if (ds2.Tables[0].Rows.Count > 0)
            {
                Label3.Text = ds2.Tables[0].Rows[0][1].ToString();
            }
            string sa2 = "select * from state where sid = '" + ds1.Tables[0].Rows[0][8].ToString() + "'";
            SqlCommand cmd2 = new SqlCommand(sa2, con);
            con.Open();
            SqlDataAdapter ad2 = new SqlDataAdapter(cmd2);
            ad2.Fill(ds3);
            con.Close();
            if (ds3.Tables[0].Rows.Count > 0)
            {
                Label5.Text = ds3.Tables[0].Rows[0][1].ToString();
            }
            DataSet ds4 = new DataSet();
            string sa3 = "select * from city where cid = '" + ds1.Tables[0].Rows[0][9].ToString() + "'";
            SqlCommand cmd3 = new SqlCommand(sa3, con);
            con.Open();
            SqlDataAdapter ad3 = new SqlDataAdapter(cmd3);
            ad3.Fill(ds4);
            con.Close();
            if (ds4.Tables[0].Rows.Count > 0)
            {
                Label7.Text = ds4.Tables[0].Rows[0][1].ToString();
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


    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            if (FileUpload1.HasFile)
            {
                photo = FileUpload1.PostedFile.FileName;
                photo = "~/Gallery/" + photo;
                FileUpload1.PostedFile.SaveAs(Server.MapPath(photo));
            }
            string sa = "insert into gallery(uid,photo) values('" + Session["id"] + "','" + photo + "')";
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        
            if (FileUpload2.HasFile)
            {
                postfile = FileUpload2.PostedFile.FileName;
                postfile = "~/Gallery/" + postfile;
                FileUpload2.PostedFile.SaveAs(Server.MapPath(postfile));
            }
            string sa = "insert into posts(uid,heading,content,photo) values('" + Session["id"] + "','" + TextBox1.Text+ "','"+TextBox2.Text+"','"+postfile+"')";
            cmd = new SqlCommand(sa, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        
        
        
    }
}