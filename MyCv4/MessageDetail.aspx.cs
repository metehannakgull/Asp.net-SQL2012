using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCv4
{
    public partial class MessageDetail : System.Web.UI.Page
    {
        DbMyCVEntities db = new DbMyCVEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["Id"]);
            var message1 = db.Table_Iletisim.Find(x);
            TextBox1.Text = message1.Adsoyad;
            TextBox2.Text = message1.Mail;
            TextBox3.Text = message1.Mesaj;


        }
    }
}