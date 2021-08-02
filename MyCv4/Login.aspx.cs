using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCv4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DbMyCVEntities db = new DbMyCVEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.Table_Admin
                        where x.KullaniciAdi == TextBox1.Text &&  x.Sifre == TextBox2.Text
                        select x;
            if (sorgu.Any())
            {
                Response.Redirect("Contact.aspx");
            }
            else
            {
                Label1.Text = "wrong username or password";
            }
        }
    }
}