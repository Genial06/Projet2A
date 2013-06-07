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
<!DOCTYPE html>
<html>
	<head run="server">
		<title>testCreate</title>
		<link href="styles.css" rel="stylesheet" type='text/css' media='all' />
		<link href="style.css" rel="stylesheet" type='text/css' media='all' />
		<link href="style1.css" rel="stylesheet" type='text/css' media='all' />
	</head>
	<body>
		
		<li>	<% 	AfficherClassName();	%></li>
		<li>	<%	AfficherAttributs();	%></li>
		
		<form id="form10" runat="server">
		<asp:Button id="buttonCreer" runat="server" Text="creer" OnClick="buttonCreerClicked" />
			<br/>
		<asp:Button id="buttonRetour" runat="server" Text="retour" PostBackUrl="~/Default.aspx" />
		<asp:Label id="outputlabelCreer" runat="server"/>
		</form>
		

		
	</body>
</html>
