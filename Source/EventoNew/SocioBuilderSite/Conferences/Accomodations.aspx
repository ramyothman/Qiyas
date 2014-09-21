<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Conference.Master" AutoEventWireup="true" CodeBehind="Accomodations.aspx.cs" Inherits="SocioBuilderSite.Conferences.Accomodations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="css/jd.gallery.css" type="text/css" media="screen" charset="utf-8" />
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

//                var myGalleryinn = new gallery($('myGalleryinn'), {
//                    timed: true,
//                    showInfopane: false,
//                    textShowCarousel: 'Gallery',
//                    embedLinks: false
//                });
            }
            jQuery(document).ready(function () {
                startGallery();
            });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br class="clear" /><br />
<h1>Four Seasons Hotel Riyadh</h1>
<div class="imgcls2" style="padding-top:5px;z-index:5">
<object data='http://www.fourseasons.com/apps/media_widget/VideoPlayerEmbed.swf?r=1233682488747' name='mediaContainerFlashPlayer' id='mediaContainerFlashPlayer' type='application/x-shockwave-flash' width='600' height='320'>
<param value='true' name='allowfullscreen'>
<param value='always' name='allowScriptAccess'>
<param value='transparent' name='wmode'>
<param value='fvShowCaptions=false&fvMode=gallery&fvVideoRSS=http://www.fourseasons.com/riyadh/photos_and_videos/index_videos.xml&fvIndex=0&fvSegment=basics&fvFullScreenOffset=166&fvLanguage=en' name='flashvars'>
</object>
</div>

<p><strong>Address: </strong>Kingdom Centre, P.O. Box 231000, Riyadh 11321, Kingdom    of Saudi Arabia</p><br />
<p><strong>Phone: </strong>00966(1)211-5000</p><br />
<p><strong>Fax: </strong>00966(1)211-5001</p>
<h3>Location Benefit</h3>
<div style="padding-left:30px;">
<ul style="list-style-type:disc;padding-right:5px;">
<li>
Central
</li>
<li>
1 KMs to City Center
</li>
<li>
45 KMs to King Khalid International Airport
</li>

</ul>
</div>
<br />
<h3>Website</h3>
<p><a href="http://www.fourseasons.com/riyadh">http://www.fourseasons.com/riyadh</a></p>
<br />
<h1>Al Faisaliah Hotel</h1>
<div class="imgcls2">
<div id="myGallery">
				<div class="imageElement">
					<h3></h3>
					<p></p>
					<a href="#" title="open image" class="open"></a>
					<img src="images/faisaleya1.jpg" class="full" />
					<img src="images/faisaleya1-mini.jpg" class="thumbnail" />
				</div>
				<div class="imageElement">
					<h3></h3>
					<p></p>
					<a href="#" title="open image" class="open"></a>
					<img src="images/faisaleya2.jpg" class="full" />
					<img src="images/faisaleya2-mini.jpg" class="thumbnail" />
				</div>
               
				<div class="imageElement">
					<h3></h3>
					<p></p>
					<a href="#" title="open image" class="open"></a>
					<img src="images/faisaleya3.jpg" class="full" />
					<img src="images/faisaleya3-mini.jpg" class="thumbnail" />
				</div>
				
			</div>
</div>

<p><strong>Address: </strong>Po Box 4148, Riyadh 11491, Olaya Street, Kingdom Of Saudi Arabia</p><br />
<p><strong>Phone: </strong>00966(1)273-2000</p><br />
<h3>Location Benefit</h3>
<div style="padding-left:30px;">
<ul style="list-style-type:disc;padding-right:5px;">
<li>
Central
</li>
<li>
1 KMs to City Center
</li>
<li>
45 KMs to King Khalid International Airport
</li>
<li>
15 KMs to Riyadh Railway Station
</li>
</ul>
</div>
<br />
<h3>Website</h3>
<p><a href="http://www.alfaisaliahhotel.com/index.cfm">http://www.alfaisaliahhotel.com/</a></p>
<br />
<h1>Holiday Inn Olaya Riyadh Hotel</h1>
<div class="imgcls2">
<div id="myGalleryinn">
				<div class="imageElement">
					<h3></h3>
					<p></p>
					<a href="#" title="open image" class="open"></a>
					<img src="images/holidayInn1.jpg" class="full" />
				</div>
				
			</div>
            <div class="clear"></div>
</div>

<p><strong>Address: </strong>Olaya Street, P.o.box 69112, Riyadh 11547, Saudi Arabia</p><br />
<p><strong>Phone: </strong>00966(1)461-2000</p><br />
<h3>Location Benefit</h3>
<div style="padding-left:30px;">
<ul style="list-style-type:disc;padding-right:5px;">
<li>
Central
</li>
<li>
45 KMs to King Khalid International Airport
</li>
</ul>
</div>
<br />
<h3>Website</h3>
<p><a href="http://www.olaya-holiday-inn-riyadh.com/">http://www.olaya-holiday-inn-riyadh.com/</a></p>
<br />

</asp:Content>
