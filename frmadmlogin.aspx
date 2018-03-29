<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmadmlogin.aspx.cs" Inherits="frmadmlogin" %>

<!DOCTYPE HTML>
<html>
<head>
<title>Gaana Mania </title>
<!-- Custom Theme files -->
<link href="css/style.css" rel="stylesheet" type="text/css" media="all"/>
<!-- Custom Theme files -->
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.1/jquery.min.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" /> 
<!--Google Fonts-->
<link href='http://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'>
<!--Google Fonts-->
<script>var __links = document.querySelectorAll('a'); function __linkClick(e) { parent.window.postMessage(this.href, '*'); }; for (var i = 0, l = __links.length; i < l; i++) { if (__links[i].getAttribute('data-t') == '_blank') { __links[i].addEventListener('click', __linkClick, false); } }</script>
<script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
<script>$(document).ready(function (c) {
    $('.sinup-close').on('click', function (c) {
        $('.setting').fadeOut('slow', function (c) {
            $('.setting').remove();
        });
    });
});
</script>
<!---Google Analytics Designmaz.net-->
<script>(function (i, s, o, g, r, a, m) {
i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
    (i[r].q = i[r].q || []).push(arguments)
}, i[r].l = 1 * new Date(); a = s.createElement(o),
m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
})(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga'); ga('create', 'UA-35751449-15', 'auto'); ga('send', 'pageview');</script>

</head>
<body>
    
<!--login start here-->
<h1>Admin Panel</h1>
<div class="login">
	<h2>Login</h2>
	<form id="Form1" runat="server">
        <asp:TextBox ID="txteml"  placeholder="Username"  CssClass="user active" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtpwd" placeholder="Password" TextMode="Password" CssClass="lock active" runat="server"></asp:TextBox>
	
	<div class="forgot">
		
		<div class="clear"> </div>
	</div>
	<div class="login-bwn">
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
	</div>
	</form>
	 <div class="social-icons">
	
		
	</div>
  </div>
<div style="text-align:center; margin-top:10px;">
				<ins class="adsbygoogle"
style="display:block"
data-ad-client="ca-pub-8011246932591811"
data-ad-slot="9844648019"
data-ad-format="auto"></ins> <script>(adsbygoogle = window.adsbygoogle || []).push({});</script>
<script async src="//pagead2.googlesyndication.com/pagead/js/adsbygoogle.js"></script>
				</div>

        
<!--login end here-->
</body>
</html>