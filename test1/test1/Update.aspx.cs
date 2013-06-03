using System;
using System.Web;
using System.Web.UI;

namespace test1
{
	public partial class Update : System.Web.UI.Page
	{
		public virtual void button1Clicked (object sender, EventArgs args)
		{
			
		}
		public virtual void button2Clicked (object sender, EventArgs args)
		{
		    outputlabel2.Text = string.Format ("l'instance a été ajouté");
		}
		public virtual void buttonRetourClicked (object sender, EventArgs args)
		{
			
		}
	}
}

