using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCv4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DbMyCVEntities db = new DbMyCVEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.Table_Hakkimda.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.Table_Hakkimda.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.Table_Hakkimda.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = db.Table_Yetenekler.ToList();
            Repeater4.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Table_Iletisim t = new Table_Iletisim();
            t.Adsoyad = TextBox1.Text;
            t.Mail = TextBox2.Text;
            t.Mesaj = TextBox3.Text;
            db.Table_Iletisim.Add(t); //adsoyad, mail ve mesajı tabloya ekledim.
            db.SaveChanges();
        }
    }
}