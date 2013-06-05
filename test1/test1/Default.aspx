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
		<link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body> 
<style type="text/css" media="screen">		
			</style>
		<form id="form21" runat="server">
			<% Response.Write("Rentrer le path du projet :"); %>
				<input id="TextboxBegin" runat="server" type="file">
				</input>
			<asp:Button id="buttonBegin" Text="begin" OnClick="buttonBeginClicked" runat="server"/>
		</form>			
		
		<form id="form30" runat="server">
			<% Response.Write("Rentrer le nom du projet :"); %>
			<asp:TextBox id="TextboxProjet"  runat="server"/>
			<asp:Button id="buttonProjet" Text="StartProjet" OnClick="buttonProjetClicked" runat="server"/>
			<% Response.Write("<ul>");
			 AfficherClasses(projetName); 
			 Response.Write("</ul>"); %>
		</form>
		
		<form id="form20" runat="server">
			<% Response.Write("Rentrer le nom de la classe :"); %>
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
		
		<form id="form40" runat="server">
			
		</form>	
		
		
	<form id="form1" runat="server">
		<asp:Button id="button1" runat="server" Text="create" OnClick="button1Clicked" PostBackUrl="~/Create.aspx" />
	</form>
		
	<form id="form2" action="Read.aspx" runat="server">
		<asp:Button id="button2" runat="server" Text="read" OnClick="button2Clicked" />
		<asp:Label id="outputlabel2" runat="server" />
	</form>
		
	<form id="form3" action="Update.aspx" runat="server">
		<asp:Button id="button3" runat="server" Text="update" OnClick="button3Clicked" />
		<asp:Label id="outputlabel3" runat="server" />
	</form>
		
</body>
</html>


