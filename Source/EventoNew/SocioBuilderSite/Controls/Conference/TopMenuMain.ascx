<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TopMenuMain.ascx.cs" Inherits="SocioBuilderSite.Controls.Conference.TopMenuMain" %>
 <!--Menu-->
             
     <ul class="menu" id="menu">
	<li><a href="~/Conferences/Default.aspx" runat="server" id="MainHomePage" class="active">Home</a>
		
	</li>
	<li><a href="~/Conferences/Speakers.aspx" runat="server" id="MainSpeakersPage">Speakers</a>
    </li>
	<li>
		<a href="#">Abstracts</a>
		<ul class="leftb">
            <li><a href="~/Conferences/AbstractGuidelines.aspx" runat="server" id="AbstractGuidLinesPage">Abstract Guide Lines</a></li>
			<li><a href="~/Conferences/Abstract/Submit.aspx" runat="server" id="AbstractSubmissionsPage">Abstract Submission</a></li>
			<li>
				<a href="~/Conferences/MyAbstracts.aspx" class="sub" runat="server" id="AbstractStatusPage">Abstract Status</a>
			</li>
		</ul>
	</li>
	<li>
		<a href="#">Program</a>
		<ul>
			<li><a href="~/Conferences/Schedule.aspx" runat="server" id="PreCon">Pre-Conference Course</a></li>
			<li><a href="~/Conferences/Schedule.aspx?Program=2" runat="server" id="annualconf">Annual Meeting Program</a></li>
			<li><a href="~/Conferences/Schedule.aspx?Program=3" runat="server" id="nurseconf">Nursing Program</a></li>
		</ul>
	</li>
         <li><a href="~/Conferences/Registration.aspx" runat="server" id="registrationPage">Registration</a></li>
         <li><a href="~/Conferences/Contacts.aspx" runat="server" id="MainContactLink">Contacts</a></li>
</ul>
                <!--End-Menu-->

    

<asp:XmlDataSource ID="XmlDataSource1" runat="server" XPath="/mainmenu/item" 
    DataFile="~/App_Data/MenuTabbedMenu.xml"></asp:XmlDataSource>

