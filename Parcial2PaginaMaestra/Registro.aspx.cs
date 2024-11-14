using System;
using System.Web;



namespace Parcial2PaginaMaestra
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e) // Cookies para contraseña y usuario
        {
            HttpCookie cookie = new HttpCookie("password", TextBox4.Text);
            Response.Cookies.Add(cookie);
            this.Session["usuario"] = TextBox1.Text;
            Response.Redirect(Request.RawUrl);

        }
    }
}