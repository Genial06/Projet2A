<%@ Page Language="C#" Inherits="test1.Read" %>
<script language="C#" runat="server">

</script>
<!DOCTYPE html>
<html lang="fr">
  <head runat="server">
    <meta charset="utf-8" />
    <title>Read</title>
	<link href="styles.css" rel="stylesheet" type="text/css" media="all"/>
	<link href="style.css" rel="stylesheet" type="text/css" media="all"/>
    <link href="style1.css" rel="stylesheet" type="text/css" media="all"/>
  </head>
  <body>
    <form id="form1" runat="server">
      <div>
        <asp:Button id="button1" runat="server" Text="create" PostBackUrl="~/Create.aspx" />
      </div>
		<div>
			<asp:Button id="button2" runat="server" Text="update" PostBackUrl="~/Update.aspx" />
		</div>
		<div>
			<asp:Button id="buttonRetour" runat="server" Text="retour" PostBackUrl="~/Default.aspx" />
		</div>
		</form>
		
  </body>
</html>