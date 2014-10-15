<%@ Page Theme="QiyasArNew" Language="C#" AutoEventWireup="true" CodeBehind="QiyasTest.aspx.cs" Inherits="SocioBuilderSite.QiyasTest" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Src="~/Conference/Controls/TopMenuControl.ascx" TagName="TopMenuControl" TagPrefix="evento" %>
<%@ Register Src="~/Conference/Controls/ConferenceDateControl.ascx" TagName="ConferenceDateControl" TagPrefix="evento" %>
<%@ Register Src="~/Conference/Controls/SponsorsControl.ascx" TagName="ConferenceSponsors" TagPrefix="evento" %>
<%@ Register Src="~/Conference/Controls/OrganizersControl.ascx" TagName="OrganizersControl" TagPrefix="evento" %>
<%@ Register Src="~/Conference/Controls/SideMenuControl.ascx" TagName="SideMenuControl" TagPrefix="evento" %>
<%@ Register Src="~/Conference/Controls/LoginFront.ascx" TagName="LoginFrontControl" TagPrefix="evento" %>
<%@ Register Src="~/Conference/Controls/TopDateControl.ascx" TagName="TopDateControl" TagPrefix="evento" %>
<%@ Register Src="~/Conference/Controls/FooterMenuControl.ascx" TagName="FooterMenuControl" TagPrefix="evento" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title runat="server" id="HeadPageTitle">Qiyas</title>
    <meta lang="ar" content="المؤتمر الدولي الأول للقياس والتقويم" />
    <meta runat="server" id="CustomContent" content="" />
    <meta lang="en" content="First International Conference for " />
     <script type="text/javascript" src="/_Scripts/Front/jquery-1.7.1.min.js"></script>
</head>
<body>
    <form id="MainForm" runat="server">
    <div class="wrapper">
    <ul id="header-language">
        <li><a runat="server" href='<%$Resources:ConferenceFront, HomePage_LanguageLink %>'><asp:Literal runat="server" Text='<%$Resources:ConferenceFront, HomePage_LanguageText %>'></asp:Literal> </a></li>
    </ul>
    
    <div class="social-top-new">
            <a href="http://www.facebook.com/ica.qiyas" target="_blank"><img runat="server" src="~/Conference/images/fb.jpg" width="20" height="19" alt="fb" /></a>
			<a href="http://twitter.com/#%21/ica_qiyas" target="_blank"><img runat="server" src="~/Conference/images/tw.jpg" width="20" height="19" alt="tw" /></a>
			<a href="http://www.youtube.com/icaqiyas" target="_blank" ><img runat="server" src="~/Conference/images/yt.jpg" width="20" height="19" alt="youtube" /></a>
            <div class="fb-like" data-href="https://www.facebook.com/ica.qiyas" data-send="false" data-layout="button_count" data-width="100" data-show-faces="false"></div>
            <%--<a id="A1" runat="server" href='<%$Resources:ConferenceFront, HomePage_LanguageLink %>'><img id="Img2" runat="server" src='<%$Resources:ConferenceFront, MasterPage_LanguageImage %>' width="20" height="19" alt="fb" /></a>--%>
		</div>
    
	<div class="header">
		<div class="logo"><a runat="server" href="~/Conference/Default.aspx"><img runat="server" id="MainConferenceLogo" src="/Conference/images/logo-new.png" width="191" height="140" alt="Qiyas" /></a></div>
		
		<div class="top-nav">
			<evento:TopMenuControl runat="server" />
		</div>
        <evento:TopDateControl runat="server" />
				
		<div class="clear"></div>
	</div>
	<!--- / header --->
	<div class="banner">
        <asp:Repeater runat="server" ID="mainBannerRepeater">
            <HeaderTemplate>
            <ul id="slider1">
            </HeaderTemplate>
            <ItemTemplate>
            <li><a href='<%# Eval("PhotoLink").ToString() %>'><img id="Img1" runat="server" src='<%# "~/ContentData/Sites/Conferences/" + Eval("PhotoPath").ToString() %>' width="993" height="196" alt="banner" /></a></li>
            </ItemTemplate>
            <FooterTemplate>
                </ul>    
            </FooterTemplate>
        </asp:Repeater>

	</div>
	<!-- / banner -->
	<div class="main-body">
		<div class="sidebar">
			<evento:ConferenceDateControl Visible="false"  runat="server"></evento:ConferenceDateControl>
            <evento:SideMenuControl ID="SideMenuControl1"  runat="server"></evento:SideMenuControl>
            <evento:LoginFrontControl runat="server" />
            <div class="clear"></div>
			<div id="twitter-ticker">
			    <div id="top-bar">
			        
			      <div id="twitIcon"><img runat="server" src="~/Conference/images/twitter_64.png" width="64" height="64" alt="Twitter icon" /></div>
			    
			        <h2 class="tut"><asp:Literal ID="Literal1" runat="server" Text='<%$Resources:ConferenceFront, TwitterBox_Title %>' ></asp:Literal></h2>
			        </div>
			        
			        <div id="tweet-container"><img id="loading" runat="server" src="~/Conference/images/loading.gif" width="16" height="11" alt="Loading.." /></div>
			        
			        <div id="scroll"></div>
			 </div>
            <evento:OrganizersControl runat="server" />
            <evento:ConferenceSponsors runat="server" />
            
            <div class="clear"></div><br /><br />
			
<!-- Histats.com  START  (standard)-->
<script type="text/javascript">    document.write(unescape("%3Cscript src=%27http://s10.histats.com/js15.js%27 type=%27text/javascript%27%3E%3C/script%3E"));</script>
<a href="http://www.histats.com" target="_blank" title="counter code" ><script  type="text/javascript" >
                                                                           try {
                                                                               Histats.start(1, 1810507, 4, 107, 170, 20, "00011111");
                                                                               Histats.track_hits();
                                                                           } catch (err) { };
</script></a>
<noscript><a href="http://www.histats.com" target="_blank"><img  src="http://sstatic1.histats.com/0.gif?1810507&101" alt="counter code" border="0"></a></noscript>
<!-- Histats.com  END  -->

		</div>
		<!-- / Side Bar -->
		<div class="content">
    
			<div class="clear">
            </div>
            
		</div>
		<!-- / Content -->		
		<div class="clear"></div>
	</div>
	<!-- / Main Body -->	
</div>
<div class="footer">
	<div class="wrapper">
		<p><asp:Literal runat="server" Text='<%$Resources:ConferenceFront, Footer_CopyRights %>'></asp:Literal> </p>
        <evento:FooterMenuControl runat="server" />
		<%--<ul>
			<li><a href="#">Home</a></li>
			<li class="fix"><a href="#">Contacts</a></li>
		</ul>--%>
		<div class="clear"></div>
	</div>
</div>
    </form>
    <script type="text/javascript" src="/_Scripts/Front/captify.tiny.js"></script>
<script type="text/javascript" src="/_Scripts/Front/jcarousellite_1.0.1.pack.js"></script>
<script type="text/javascript" src="/_Scripts/Front/jquery.bxSlider.min.js"></script>
<script type="text/javascript" src="/_Scripts/Front/jquery.droppy.js"></script>
<%--<script type="text/javascript" src="/_Scripts/Front/twitter.js"></script>
<script type="text/javascript" src="/_Scripts/Front/script.js"></script>--%>
<div id="fb-root"></div>
<script type="text/javascript">    (function (d, s, id) {
        var js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) return;
        js = d.createElement(s); js.id = id;
        js.src = "//connect.facebook.net/en_US/all.js#xfbml=1";
        fjs.parentNode.insertBefore(js, fjs);
    } (document, 'script', 'facebook-jssdk'));</script>
</body>
</html>
