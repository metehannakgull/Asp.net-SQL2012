using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCv4
{
    public partial class NewAbility : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DbMyCVEntities db = new DbMyCVEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            Table_Yetenekler t = new Table_Yetenekler();
            t.Yetenek = TextBox1.Text;
            db.Table_Yetenekler.Add(t);
            db.SaveChanges();
            Response.Redirect("Ability.aspx"); //beni bu sayfaya yönlendir
        }
    }
}