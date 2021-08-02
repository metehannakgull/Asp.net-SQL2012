using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCv4
{
    public partial class UpdateAbility : System.Web.UI.Page
    {
        DbMyCVEntities db = new DbMyCVEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            int x = int.Parse(Request.QueryString["Id"]);
            if (Page.IsPostBack == false)  //yetenek güncelledikten sonra ability.aspx sayfasına yönlenicem
            {                               //bu koşulu yapma sebebim ability.aspx sayfanın güncellenmiş veri ile gelmesini sağlamak.
                var ytnk = db.Table_Yetenekler.Find(x);
                TextBox1.Text = ytnk.Yetenek;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["Id"]);
            var ytnk = db.Table_Yetenekler.Find(x);
            ytnk.Yetenek = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Ability.aspx");
        }
    }
}