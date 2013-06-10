using System;
using System.Web;
using System.Web.UI;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

namespace test1
{
	public partial class Create : System.Web.UI.Page
		
	{	
		public static string fichier;
		public static string projetName = "";
		public static string className = "";
		
		
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
		public virtual void AfficherClasses(string s)
		{
			if (projetName != "")
			{	
				
				Response.Write("<h4> Liste des classes du projet :</h4> ");
				List<string> l = reflexion.GetClasses(s);
				Response.Write("<ul>");
				foreach (string j in l)
					{
					    Response.Write(string.Format ("<li> {0} </li>",j));
					}	
					 Response.Write("</ul>");
			}
			else
				Response.Write("");
		}
		
		public virtual void AfficherClassName() 
		{ 	
			Response.Write("<h4> Nom de la classe :</h4> ");
			string str = reflexion.NomClasse();
			Response.Write("<ul>");		
			Response.Write(string.Format("<li> {0} </li>",str));
			Response.Write("</ul>");
	    }
		
		public virtual void AfficherAttributes() 
		{ 
			Response.Write("<h4> Liste d'attributs :</h4> ");
			List<string> l = reflexion.listAttributes();
			Response.Write("<ul>");
			foreach (string j in l)
				{
				    Response.Write(string.Format ("<li> {0} ",j));
					Response.Write(string.Format("<input type=\"text\" placeholder=\"Saisissez l attribut\"> </input> "));
					Response.Write(string.Format("<button> test </button> </li>"));
					//Response.Write(String.Format("<button> Read </button> "));
					
					//Response.Write(String.Format("<button> Update </button> "));
					//Response.Write(String.Format("<button> Delete </button> </li>"));
					 
				}	
				 Response.Write("</ul>");
		}
		
		void ClicButton(){
    	  System.Console.Write("oui");
   		}
		
		public virtual void AfficherMethods()
		{
			Response.Write("<h4> Liste de Methodes :</h4>");
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
			Response.Write("<h4> Liste de Champs : </h4>");
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
			Response.Write("<h4> Liste de Constructeur : </h4> ");
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

	



