using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCv4
{
    public partial class DeleteAbility : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbMyCVEntities db = new DbMyCVEntities();
            int x = Convert.ToInt32(Request.QueryString["Id"]);//Id isteği aldım. int dönüştürüp x'e atadım.
            var ytnk = db.Table_Yetenekler.Find(x); //Table_Yetenekler tablomda x değerimi bul. ve ytnk'e ata.
            db.Table_Yetenekler.Remove(ytnk); //eşleşme varsa değeri sil
            db.SaveChanges(); //yapılan değişiklikleri kaydet
            Response.Redirect("Ability.aspx");
        }
    }
}