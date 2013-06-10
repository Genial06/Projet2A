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
	<title><% 	AfficherTitre(); %></title>
		<link href="styles.css" rel="stylesheet" type='text/css' media='all' />
		<link href="style.css" rel="stylesheet" type='text/css' media='all' />
		<link href="style1.css" rel="stylesheet" type='text/css' media='all' />
		
</head>

<body> 
<div id ="global" style = "width : 1900px;">			

		<div id="letter-container" class="letter-container">
    		<h2><a href="#" style="left: 200px;">C#</a></h2>
		
    		<h2><a href="#" style="left: 550px;">HTML</a></h2>
		</div>
		
		<ul id="navigationMenu" style="margin: -250px 0px 0px 550px;">
			    <li>
				
			        <a class="home" href="Leonard et Ryad.html" >
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
			    	<a class="contact" href="contact.html">
			            <span>Contact us</span>
			        </a>
			    </li>
			</ul>
		<h2>
		Bienvenue sur l'outil VerKaTool 
		</h2>
		
		<h3 style="padding: 20px 50px 0px 150px; border-width: 3px; margin: 0px 510px 0px 540px; height: 96px;">
		L'outil VerKaTool est un générateur de pages Web à partir de votre code c#,<br/>il vous permettra de visualiser toute les informations contenu dans votre projet,<br/> de maniére intuitive de rajouté ou modifié vos instance via une statégie qui se base sur la refléxivité.
		</h3>
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
		
			<h3 style="margin-top: 12px;"><% Response.Write("Rentrer le nom du projet :"); %></h3>
			<asp:TextBox id="TextboxProjet"  runat="server" style="margin-top: 12px; padding-top: 0px; border-top-width: 2px;"/>
			<asp:Button id="buttonProjet" Text="StartProjet" OnClick="buttonProjetClicked" runat="server" style="margin-left: 60px;"/>
			<% Response.Write("<ul>");
			 AfficherClasses(projetName); 
			 Response.Write("</ul>"); %>
		</form>
		
		<form id="form20" runat="server">
	
			<h3 style="margin-top: 12px; margin-bottom: 12px;"><% Response.Write("Rentrer le nom de la classe :"); %></h3>
			<asp:TextBox id="TextboxStart"  runat="server"/>
			
			<asp:Button id="buttonStart" Text="Start" OnClick="buttonStartClicked" runat="server" style="margin-left: 60px;"/>
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
		<asp:Button id="button1" runat="server" Text="create" PostBackUrl="~/Create.aspx" style="margin-top: 12px; margin-bottom: 12px;" />
			<br/>
			
		<asp:Button id="button2" runat="server" Text="read" PostBackUrl="~/Read.aspx" style="margin-top: 12px; margin-bottom: 12px;"/>
			<br/>
		<asp:Button id="button3" runat="server" Text="update" PostBackUrl="~/Update.aspx" style="margin-top: 12px; margin-bottom: 12px;"/>
	</form>
	
		</div>
	</div>	
		</body>
	</html>


