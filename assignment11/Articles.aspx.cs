using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment11
{
    public partial class Articles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=DESKTOP-LVRAQ1E;database=ContentDB;trusted_connection=true;");
                SqlCommand cmd = new SqlCommand("select * from Articles", con);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                LblMsg.Text = "Number of Articles are: " + ds.Tables[0].Rows.Count;
                gvArticles.DataSource = ds.Tables[0];
                gvArticles.DataBind();
                con.Close();
            }

            catch (Exception ex)
            {
                LblMsg.Text = "Error!!!!" + ex.Message;
            }
        }

        protected void gvArticles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
    