<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmmaindwnld.aspx.cs" Inherits="frmmaindwnld" %>

<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!--> <html class="no-js"> <!--<![endif]-->
    <head>
        <meta charset="utf-8">
        <title>Gaana Mania</title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">

        <!-- Place favicon.ico and apple-touch-icon.png in the root directory -->

        <!-- Styles CSS -->
        <link rel="stylesheet" href="css/normalize.css">
        <link rel="stylesheet" href="css/main.css">
        <link rel="stylesheet" href="css/sonorama.css">
        <link rel="stylesheet" href="css/blog.css">
        <link rel="stylesheet" href="css/responsive.css">
        <link rel="stylesheet" href="css/isotope.css">
        <link rel="stylesheet" href="js/fancybox/jquery.fancybox.css">
 	  <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">

        <!--  Color Picker & Styles -->
        <link href="css/color-picker.css" rel="stylesheet">
        <link rel="stylesheet" href="css/color/light.css">
        <link rel="stylesheet" href="css/color/green.css">
        <link rel="stylesheet" href="css/color/yellow.css">
        <link rel="stylesheet" href="css/color/turquoise.css">
        <link rel="stylesheet" href="css/color/red.css">
        <link rel="stylesheet" href="css/color/orange.css">
        <link rel="stylesheet" href="css/color/purple.css">
        <link rel="stylesheet" href="css/color/blue.css">
        <link rel="stylesheet" href="css/color/black.css">  
              
	<link href='http://fonts.googleapis.com/css?family=<link href='http://fonts.googleapis.com/css?family=Titillium+Web:400,200,200italic,300,300italic,400italic,600italic,600,700,700italic,900' rel='stylesheet' type='text/css'>:400,200,200italic,300,300italic,400italic,600italic,600,700,700italic,900' rel='stylesheet' type='text/css'>

        <!-- Scripts JS -->
        <script src="js/vendor/modernizr-2.6.2.min.js"></script>
        
    </head>
    <body>
        <script type="text/javascript">
            var Tawk_API = Tawk_API || {}, Tawk_LoadStart = new Date();
            (function () {
                var s1 = document.createElement("script"), s0 = document.getElementsByTagName("script")[0];
                s1.async = true;
                s1.src = 'https://embed.tawk.to/5a6de6484b401e45400c757a/default';
                s1.charset = 'UTF-8';
                s1.setAttribute('crossorigin', '*');
                s0.parentNode.insertBefore(s1, s0);
            })();
</script>
        <form runat="server">
        <!--[if lt IE 7]>
            <p class="browsehappy">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
        <![endif]-->
        
        <div id="mask">   
            <div class="loader">
              <img src="img/icons/loading.gif" alt='loading'>
            </div>
        </div>
        
        <div class="color-picker">
        	<div class="picker-btn"></div>
        	<div class="pickerTitle">Style Switcher</div>
            <div class="pwrapper">
                <div class="pickersubTitle">Layout Selector</div>
                <div class="light-version"><img title="" alt='img' src="img/icons/light.jpg"></div>
                <div class="dark-version"><img title="" alt='img' src="img/icons/dark.jpg"></div>
                <div class="pickersubTitle"> Color scheme </div>
                <div class="picker-blue"></div>
                <div class="picker-black"></div>
                <div class="picker-green"></div>
                <div class="picker-yellow"></div>
                <div class="picker-red"></div>
                <div class="picker-purple"></div>
                <div class="picker-turquoise"></div>
                <div class="picker-orange"></div>
                <div class="clear nopick"></div>
            </div>
        </div>
        
        <div class="full-wrapper header">
        	<div class="main-logo">
            	<a class="symbol" href="#"><div class="navbar-brand"><ul><li></li><li></li><li></li></ul></div>Gaana Mania<span>.</span></a>
            </div>
            
            <nav class="main-menu">
            		<ul>
                	<li ><a href="Default.aspx">Home</a></li>
                  
                    <li><a href="Default.aspx">Latest News</a></li>
                    
                   
                   
                     <li><a href="Default.aspx">Contact</a></li>
                    
                      <li class="current"><a href="frmdisp_video.aspx">Videos</a></li>
                    <li><a href="frmdwnld.aspx">Downlods</a></li>
                </ul>
            </nav>
            
            <nav id="nav2" role="navigation">
                <a class="jump-menu" title="Show navigation">Show navigation</a>
                <ul>
                 <li ><a href="Default.aspx">Home</a></li>
                  
                    <li><a href="Default.aspx">Latest News</a></li>
                    
                   
                   
                     <li><a href="Default.aspx">Contact</a></li>
                    
                      <li class="current"><a href="frmdisp_video.aspx">Videos</a></li>
                    <li><a href="frmdwnld.aspx">Downlods</a></li>
                </ul>
            </nav>
        </div>
        
        <div id="anchor0"></div>

	<div class="page-wrap container">
			<div class="grid-9">
				<article>
					<div class="pdate"><span>Downloads</span></div>
					<div class="post-meta">
						
					</div>
                    <asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand">
                    <ItemTemplate>
					<h3><a href="./blog_single.html"><%#Eval("sgstitle") %></a></h3>
					<p><%#Eval("sgsdesc") %> </p>
					
                        <asp:LinkButton ID="LinkButton1" CssClass="s-btn" runat="server" CommandName="abck" CommandArgument='<%#Eval("sgslk") %>'>Download</asp:LinkButton>
                    </ItemTemplate>
                        </asp:DataList>
				</article>
				
			</div>
		

	</div>


        <div class="clear"></div>
        
        <section class="social-footer">
            <h1>Social Networks</h1>
            <div class="spacer"></div>
            <div class="footer-container">
                <div class="social-ico s-facebook"></div>
                <div class="social-ico s-youtube"></div>
                <div class="social-ico s-plus"></div>
                <div class="social-ico s-twitter"></div>
                <div class="social-ico s-soundcloud"></div>
            </div>
            <div class="clear"></div>
        </section>
        
		<!-- Scripts JS -->
<!--    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
        <script>window.jQuery || document.write('<script src="js/vendor/jquery-1.10.2.min.js"><\/script>')</script>-->
        <script src="js/jquery-1.11.0.min.js"></script>
        <script src="js/superslides-0.6.2/dist/jquery.superslides.js" type="text/javascript" charset="utf-8"></script>
        <script src="js/jquery.isotope.min.js"></script>
	  <script type="text/javascript" src="js/player/audio.js"></script> <!-- Audio Player -->
        <script type="text/javascript" src="js/jquery.hoverdir.js"></script>
        <script type="text/javascript" src="js/jquery.nav.js"></script>
        <script src="js/news.js"></script>
        <script src="js/discography.js"></script>
        <script src="js/tweets.js"></script>
        <script src="js/jquery.scrolly.js"></script>
        <script src="js/fancybox/jquery.fancybox.js"></script>
        <script src="js/fancybox/helpers/jquery.fancybox-media.js"></script>
        <script src="js/color-picker.js"></script>
        <script src="js/jquery.validate.js"></script>
        <script src="js/jquery.form.js"></script>   	
	  <script src="js/plugins.js"></script>
        <script src="js/sonorama.js"></script>
        </form>
</body>
</html>
