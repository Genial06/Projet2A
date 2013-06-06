<%@ Page Language="C#" Inherits="test1.Default" %>

<script language="C#" runat="server">



  void AfficherFirstname() 
	{
		test1.PersonneTest p = new test1.PersonneTest();
		p.Firstname = "Leonard";
	    Response.Write(p.Firstname);
  	}
	 void AfficherLastname() 
	{
		test1.PersonneTest p = new test1.PersonneTest();
		p.Lastname = " et Ryad";
	    Response.Write(p.Lastname);
  	}
	
	
	void AfficherTitre()
	{
		AfficherFirstname();
		AfficherLastname();
	}
	

	
</script>
		
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head run="server">
	<title>
		<% 	AfficherTitre(); %>	
	</title>
		<link href="style1.css" rel="stylesheet" type='text/css' media='all' />
		<link href="style.css" rel="stylesheet" type='text/css' media='all' />
		<link href="styles.css" rel="stylesheet" type='text/css' media='all' />
		
</head>
<body> 
<style type="text/css" media="screen">		
			</style>
		<div id="letter-container" class="letter-container">
    		<h2><a href="#">C#</a></h2>
    		<h2><a href="#">HTML</a></h2>
		</div>
		<h2>
		Bienvenue sur l'outil KaciVer 
		</h2>
		<p> L'outil Kaciver est un générateur de pages Web à partir de votre code c#,<br/>il vous permetteras de visualiser toute les informations contenu dans votre projet<br/> de maniére intuitive de rajouté ou modifié vos instance via une statégie qui se base sur la refléxivité
			</p>
		<p id="mono">
            <img src="mono.png" alt="Mono" />
		</p>
		<p id="ubuntu">
            <img src="ubuntu-logo.png" alt="Mono" />
		</p>
		
					
		
		
		
		
		<!--<form id="form21" runat="server">
			<% //Response.Write("Rentrer le path du projet :"); %>
				<input id="TextboxBegin" runat="server" type="file">
				</input>
			<asp:Button id="buttonBegin" Text="begin" OnClick="buttonBeginClicked" runat="server"/>
		</form>			
		
		-->
		<div class="blocprincipal">
		<form id="form30" runat="server">
			<h3><% Response.Write("Rentrer le nom du projet :"); %></h3>
			<asp:TextBox id="TextboxProjet"  runat="server"/>
			<asp:Button id="buttonProjet" Text="StartProjet" OnClick="buttonProjetClicked" runat="server"/>
			<% Response.Write("<ul>");
			 AfficherClasses(projetName); 
			 Response.Write("</ul>"); %>
		</form>
		
		<form id="form20" runat="server">
			<h3><% Response.Write("Rentrer le nom de la classe :"); %></h3>
			<asp:TextBox id="TextboxStart"  runat="server"/>
			<asp:Button id="buttonStart" Text="Start" OnClick="buttonStartClicked" runat="server"/>
			<% Response.Write("<ul>");
			 if (TextboxStart.Text != "") 
			 {	
			 	
			 	AfficherClassName();  
				AfficherAttributes();  
				AfficherMethods();	   
				AfficherChamps();      
			 	AfficherConstructor();
			 	
			 }  
			 else if (TextboxStart.Text == "")
			 	Response.Write("");
			else 
				Response.Write("tu as a mal saisi le nom"); 
			 Response.Write("</ul>"); %>
		</form>	
		
		
		
	<form id="form1" runat="server">
			<h3><% Response.Write("Veuillez créer des Instances :"); %></h3>
		<asp:Button id="button1" runat="server" Text="create" PostBackUrl="~/Create.aspx" />
			<br/>
		<asp:Button id="button2" runat="server" Text="read" PostBackUrl="~/Read.aspx" />
			<br/>
		<asp:Button id="button3" runat="server" Text="update" PostBackUrl="~/Update.aspx" />
	</form>
	
		</div>
		<ul id="navigationMenu">
			    <li>
			        <a class="home" href="page2.html">
			            <span>Home</span>
						
			        </a>
					
			    </li>
			
			    <li>
			    	<a class="about" href="page2.html">
			            <span>About</span>
			        </a>
			    </li>
			
			    <li>
			         <a class="services" href="page2.html">
			            <span>Services</span>
			         </a>
			    </li>
			
			    <li>
			    	<a class="portfolio" href="page2.html">
			            <span>Portfolio</span>
			        </a>
			    </li>
			
			    <li>
			    	<a class="contact" href="page2.html">
			            <span>Contact us</span>
			        </a>
			    </li>
			</ul>
</body>
</html>


