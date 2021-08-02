using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCv4
{
    public partial class Statistics : System.Web.UI.Page
    {

        DbMyCVEntities db = new DbMyCVEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.Table_Yetenekler.Count().ToString();
            Label2.Text = db.Table_Iletisim.Count().ToString();
            Label3.Text = db.Table_Yetenekler.Average(x => x.Derece).ToString();
            Label4.Text = db.Table_Yetenekler.Max(x => x.Derece).ToString();
        }
    }
}