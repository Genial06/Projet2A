using System;
using System.Web;
using System.Web.UI;

namespace test1
{
	public partial class Create : System.Web.UI.Page
	{	
		public virtual void buttonCreerClicked (object sender, EventArgs args)
		{
			object val = ViewState["ButtonClickCountCreer"];
		    int i = (val == null)? 1 : (int)val + 1;
		    outputlabelCreer.Text = string.Format ("You added {0} new {1}", i, i==1?"instance":"instance");
		    ViewState["ButtonClickCountCreer"] = i;
		
		}
		
		public virtual void buttonRetourClicked (object sender, EventArgs args)
		{
			
		}
	}
}


