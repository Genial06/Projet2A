using System;
using System.Web;
using System.Web.UI;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

namespace test1
{
	public partial class Default : System.Web.UI.Page
	{	
		public static string fichier;
		public virtual void buttonBeginClicked (object sender, EventArgs args)
		{
			System.Console.Write(TextboxBegin.Value);
			//string fichier = TextboxBegin.Value.ToString();
			
		}
		
		public virtual void buttonProjetClicked (object sender, EventArgs args)
		{
			System.Console.Write(TextboxProjet.Text);
			string s = TextboxProjet.Text;
			AfficherClasses(s);
			
		}
		
		public virtual void buttonStartClicked (object sender, EventArgs args)
		{
			System.Console.Write(TextboxStart.Text);
			
		}
		
		public virtual void button1Clicked (object sender, EventArgs args)
		{
//			object val = ViewState["ButtonClickCount1"];
//		    int i = (val == null)? 1 : (int)val + 1;
//		    outputlabel1.Text = string.Format ("You added {0} {1}", i, i==1?"time":"times");
//		    ViewState["ButtonClickCount1"] = i;
		
		}
		public virtual void button2Clicked (object sender, EventArgs args)
		{
			object val = ViewState["ButtonClickCount2"];
		    int i = (val == null)? 1 : (int)val + 1;
		    outputlabel2.Text = string.Format ("You red {0} {1}", i, i==1?"time":"times");
		    ViewState["ButtonClickCount2"] = i;
			
		}
		
		
		public virtual void button3Clicked (object sender, EventArgs args)
		{
			object val = ViewState["ButtonClickCount3"];
		    int i = (val == null)? 1 : (int)val + 1;
		    outputlabel3.Text = string.Format ("You updated {0} {1}", i, i==1?"time":"times");
		    ViewState["ButtonClickCount3"] = i;
			
		}
		public virtual void button4Clicked (object sender, EventArgs args)
		{
		    outputlabel4.Text = string.Format ("pas encore codé");
		}
		public virtual void button5Clicked (object sender, EventArgs args)
		{
			
			
		}
		
		public virtual void AfficherClasses(string s)
		{
			Response.Write("Liste des classes du projet :");
			List<string> l = reflexion.GetClasses(s);
			Response.Write("<ul>");
			foreach (string j in l)
				{
				    Response.Write(string.Format ("<li> {0} </li>",j));
				}	
				 Response.Write("</ul>");
		}
		
		public virtual void AfficherClassName() 
		{ 	
			Response.Write("Nom de la classe :");
			string str = reflexion.NomClasse();
			Response.Write("<ul>");		
			Response.Write(string.Format("<li> {0} </li>",str));
			Response.Write("</ul>");
	    }
		
		public virtual void AfficherAttributes() 
		{ 
			Response.Write("Liste d'attributs :");
			List<string> l = reflexion.listAttributes();
			Response.Write("<ul>");
			foreach (string j in l)
				{
				    Response.Write(string.Format ("<li> {0} ",j));
					Response.Write(String.Format("<button> Read </button> "));
					
					Response.Write(String.Format("<button> Update </button> "));
					Response.Write(String.Format("<button> Delete </button> </li>"));
					 
				}	
				 Response.Write("</ul>");
		}
		
		void ClicButton(){
    	  System.Console.Write("oui");
   		}
		
		public virtual void AfficherMethods()
		{
			Response.Write("Liste de Methodes :");
			List<string> l = reflexion.listMethods();
			Response.Write("<ul>");
			foreach (string j in l)
			{
				Response.Write(string.Format ("<li> {0} </li>",j));
			}
			Response.Write("</ul>");
		}
			public virtual void AfficherChamps()
		{
			Response.Write("Liste de Champs :");
			List<string> l = reflexion.listChamps();
			Response.Write("<ul>");
			foreach (string j in l)
			{
				Response.Write(string.Format ("<li> {0} </li>",j));
			}
			Response.Write("</ul>");
		}
		public virtual void AfficherConstructor()
		{
			Response.Write("Liste de Constructeur :");
			List<string> l = reflexion.listConstructor();
			Response.Write("<ul>");
			foreach (string j in l)
			{
				Response.Write(string.Format ("<li> {0} </li>",j));
			}
			Response.Write("</ul>");
		}
		
		
	
	}

}


//pour le textbox parcourrir (dans la classe Default.aspx):
//		<form>
//			<input type="file">
//			</input>
//		</form> 