<%@ Page  Title="" Language="C#" MasterPageFile="~/MasterPages/Conference.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SocioBuilderSite.Conferences.Default" %>
<%@ Register Src="~/Controls/Conference/SpeakersMain.ascx" TagName="SpeakersControl" TagPrefix="Rbm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
		<link rel="stylesheet" href="css/jd.gallery.css" type="text/css" media="screen" charset="utf-8" />
<script src="Scripts/jquery.jcarousel.min.js" type="text/javascript"></script>		
        <script src="scripts/mootools-1.2.1-core-yc.js" type="text/javascript"></script>
		<script src="scripts/mootools-1.2-more.js" type="text/javascript"></script>
		<script src="scripts/jd.gallery.js" type="text/javascript"></script>
        <script type="text/javascript">
            function startGallery() {
                var myGallery = new gallery($('myGallery'), {
                    timed: true,
                    showInfopane: false,
                    textShowCarousel: 'Gallery',
                    embedLinks: false
                });
            }
            jQuery(document).ready(function () {
                jQuery('#mycarousel').jcarousel({
                    start: 0
                });
                startGallery();

                if ($('#slider') != null) {
                    $("#slider").easySlider({
                        controlsBefore: '<p id="controls">',
                        controlsAfter: '</p>',
                        auto: true,
                        continuous: true
                    });
                }
            });
    </script>
    <script src="/Scripts/easySlider1.7.js" type="text/javascript"></script>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!--Body-Content-->
<div class="imgcls2" style="padding-top:15px;z-index:5">
<br class="clear" /><br />
<div id="myGallery">
				<div class="imageElement">
					<h3>Riyadh</h3>
					<p>Riyadh Top View</p>
					<a href="#" title="open image" class="open"></a>
					<img src="images/home-pic-01.jpg" class="full" />
					<img src="images/home-pic-01-mini.png" class="thumbnail" />
				</div>
				<div class="imageElement">
					<h3>Prince Salman</h3>
					<p>International Conference of Saudi Society of Nephrology</p>
					<a href="#" title="open image" class="open"></a>
					<img src="images/princesalman.jpg" class="full" />
					<img src="images/princesalman-mini.png" class="thumbnail" />
				</div>
                <div class="imageElement">
					<h3>Prince Abdulaziz</h3>
					<p>International Conference of Saudi Society of Nephrology</p>
					<a href="#" title="open image" class="open"></a>
					<img src="images/princeabdulaziz.jpg" class="full" />
					<img src="images/princeabdulaziz-mini.jpg" class="thumbnail" />
				</div>
				<div class="imageElement">
					<h3>King Fahd Cultural Center</h3>
					<p>King Fahd Cultural Center - Conference Location</p>
					<a href="#" title="open image" class="open"></a>
					<img src="images/venue2.jpg" class="full" />
					<img src="images/venue2-mini.png" class="thumbnail" />
				</div>
				
			</div>
<%--<object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=8,0,0,0" width="647" height="284" id="nss_image_fader" align="middle" style="z-index:5;">
<param name="allowScriptAccess" value="sameDomain" />
      <param name="wmode" value="transparent">
<param  name="movie" value="nss_image_fader1.swf" /><param name="quality" value="high" /><embed wmode="transparent" src="nss_image_fader1.swf" quality="high" bgcolor="#FFFFFF" width="647" height="284" name="image_loader" align="middle" allowScriptAccess="sameDomain" type="application/x-shockwave-flash" pluginspage="http://www.macromedia.com/go/getflashplayer" />
</object>--%>
</div>

               	  <%--<img src="images/home-pic-01.jpg" width="647" height="284" alt="home"  class="imgcls2"/>--%>
                  <h1>Message from the President</h1>
                  
                  <p><img src="images/v4twcbrp.jpg" width="100" style="float:left;margin: 5px 5px 5px 5px;" alt="President Picture" />Dear colleagues and friends,<br />On behalf of the Saudi Society of Nephrology, I am delighted to invite you to The Saudi International Conference of Nephrology & Transplantation to be held in Riyadh, Kingdom of Saudi Arabia, from 19-22 February, 2012.

The Scientific Committee is preparing an interesting and informative scientific program, intending to gather an international faculty of experts in the fields of Chronic Kidney Disease, Dialysis, Transplantation and Hypertension.

We are looking forward to receiving your scientific contribution and welcome you in Riyadh on February 2012. </p>
<div class="clear"></div>
<br />

	<hr class="line1" />
	<h1>Important Information</h1>
    <div class="imgcls2" style="padding-top:15px;z-index:5">
    <img src="images/Payment.jpg"alt="Payment" />
    </div>
    <br />
	<p>
        <strong>Submitted abstracts may  be withdrawn before 15 January 2012, but cannot be  changed or modified.</strong><br /><br />
        All abstracts must be submitted electronically through the conference web site All abstracts must be received by  15 January 2012.  Abstracts received after this date will not be considered by  the abstract review  committee. 
    </p>
	<br />
    <h3>
        The Fees for the Early Registration until Monday 19 December is: </h3>
        <h3>500SR For Medical Doctors</h3>   <h3>250SR For Health Professionals</h3><br />
        
        <h3>The Fees for the Registration is: </h3>
        <h3>600SR For Medical Doctors</h3>   <h3>400SR For Health Professionals</h3><br />
	<!--Slide-->
			<Rbm:SpeakersControl runat="server" ID="speakersMainControl" />
            <div id="map">
            <h1>Road Guide</h1>
            <p>
            <iframe width="640" height="314" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="http://maps.google.com/maps/ms?ie=UTF8&amp;hl=en&amp;t=h&amp;safe=on&amp;msa=0&amp;msid=114054029326748302567.00048c260b4cdfb71027d&amp;ll=24.645769,46.648754&amp;spn=0.002087,0.006856&amp;z=17&amp;output=embed"></iframe><br />
            </p>
            </div>
            <br />
            <h1>Riyadh Information</h1>
            <p> The city of Riyadh represents in the field of urban growth a unique model of the origin of a major global city at about half a century of that period is not large enough - as defined by the emergence of cities - both what has been achieved through Riyadh to accomplish urban and urban than ever before.</p>
            <p>
            During the proceeds of the last century began to urban development in the city of Riyadh, takes a new turn, the movement took off reconstruction rapidly throughout the city and its surrounding areas are amazing, effecting a large number of new neighborhoods, accompanied by the grand plans for the establishment of various municipal projects from a for roads and bridges and intersections and modern lighting, The above s auto T and pedestrians, and attitudes of multiple A to Toa BBQ, gardens and parks, and playgrounds A. To turn off's, fountains and forms a for aesthetic, and markets a to the general, commercial centers, slaughterhouses, health and other equipment and of facilities for modern, along with facilities, a Services A to educational, health and social services and a communications and transport types.
            </p>
<!--End-Slide-->
<!--End-Body-Content-->
</asp:Content>
