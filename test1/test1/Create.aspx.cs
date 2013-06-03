using System;
using System.Web;
using System.Web.UI;

namespace test1
{
	public partial class Create : System.Web.UI.Page
	{	
		public virtual void buttonTestClicked (object sender, EventArgs args)
		{
			object val = ViewState["ButtonClickCountTest"];
		    int i = (val == null)? 1 : (int)val + 1;
		    outputlabelTest.Text = string.Format ("You added {0} new {1}", i, i==1?"instance":"instance");
		    ViewState["ButtonClickCountTest"] = i;
		
		}
		
		public virtual void buttonRetourClicked (object sender, EventArgs args)
		{
			
		}
	}
}


