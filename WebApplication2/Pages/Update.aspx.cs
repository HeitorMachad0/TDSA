using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.Pages
{
    public partial class Update : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt;
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=ROOM_PC;Initial Catalog=WEBFORM;Persist Security Info=True;User ID=sa;Password=n1kgodscoberta";
            con.Open();
        }

        protected void BtnDel_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "DELETE FROM Clientes WHERE Cli_Nome ='" + TBNome.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Deletado com sucesso!')</script>");
            con.Close();
            Response.Redirect("~/Pages/Default.aspx");
        }

        protected void BtnList_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT * FROM Clientes";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            ViewRows.DataSource = ds;
            ViewRows.DataBind();
            con.Close();

        }
    }
}