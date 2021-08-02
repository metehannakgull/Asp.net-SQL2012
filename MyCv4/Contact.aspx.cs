using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyCv4
{
    public partial class Contact : System.Web.UI.Page
    {
        DbMyCVEntities db = new DbMyCVEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var messages = db.Table_Iletisim.ToList();
            Repeater1.DataSource = messages;
            Repeater1.DataBind();
        }
    }
}