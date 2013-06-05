<%@ Page Language="C#" Inherits="test1.Create" %>
<script language="C#" runat="server">
 
	void AfficherClassName() { 
		Response.Write("Classe : Personne");	
	}
	void AfficherAttributs() { 
		Response.Write("Liste des attributs :");	
		for (int i = 0; i<= 2; i=i+1)
		{
			Response.Write(string.Format ("<li> {0} : ",i)); 
			Response.Write(String.Format("<input type=\"text\" placeholder=\"Saisissez l attribut\"> </input> "));
			Response.Write(String.Format("<button> test </button> </li>"));// pour tester
		}
	}
	
</script>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
	<head>
		<title>testCreate</title>
	</head>
	<body>
		
		<li>	<% 	AfficherClassName();	%></li>
		<li>	<%	AfficherAttributs();	%></li>
		
		<form id="form10" runat="server">
		<asp:Button id="buttonTest" runat="server" Text="test" OnClick="buttonTestClicked" />
			<br/>
		<asp:Button id="buttonRetour" runat="server" Text="retour" PostBackUrl="~/Default.aspx" />
		<asp:Label id="outputlabelTest" runat="server"/>
		</form>
		

		
	</body>
</html>
