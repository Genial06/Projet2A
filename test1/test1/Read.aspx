<%@ Page Language="C#" Inherits="test1.Read" %>
<script language="C#" runat="server">

</script>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
	<title>Read</title>
		<link href="style.css" rel="stylesheet" type='text/css' media='all' />
	
</head>
<body>


		
		<form id="form1" runat="server">
			<asp:Button id="button1" runat="server" Text="create" PostBackUrl="~/Create.aspx" />
				<br/>
			<asp:Button id="button2" runat="server" Text="update" PostBackUrl="~/Update.aspx" />
				<br/>
			<asp:Button id="buttonRetour" runat="server" Text="retour" PostBackUrl="~/Default.aspx" />
		</form>
		
</body>
</html>
