<%@ Page Language="C#" Inherits="test1.Read" %>
<script language="C#" runat="server">

</script>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
	<title>Read</title>
	
</head>
<body>


		
		<form id="form1" action="Create.aspx" runat="server">
			<asp:Button id="button1" runat="server" Text="create" OnClick="button1Clicked" />
		</form>
		<form id="form2" action="Update.aspx" runat="server">
			<asp:Button id="button2" runat="server" Text="Update" OnClick="button2Clicked" />
		</form>
		<form id="form3" action="Default.aspx" runat="server">
			<asp:Button id="buttonRetour" runat="server" Text="retour" OnClick="buttonRetourClicked" />
		</form>
</body>
</html>
