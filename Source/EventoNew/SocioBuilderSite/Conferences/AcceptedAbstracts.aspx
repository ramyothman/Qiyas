﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Conference.Master" AutoEventWireup="true" CodeBehind="AcceptedAbstracts.aspx.cs" Inherits="SocioBuilderSite.Conferences.AcceptedAbstracts" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHiddenField" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script src="Scripts/ui.core.js" type="text/javascript"></script>
<script src="Scripts/ui.tabs.js" type="text/javascript"></script>
<script type="text/javascript">
    jQuery(document).ready(function () {
        $('#tabdivs2 > ul').tabs();
        //            $('#tabdivs3 > ul').tabs();
    });

        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br class="clear" /><br />
<h1>Online Posters</h1>
    <div id="tabdivs2">
        <ul>
            <li><a href="#abs2-1"><span>Poster Abstracts</span></a></li>
            <li><a href="#abs2-2"><span>Oral Abstracts</span></a></li>
        </ul>
        <div id="abs2-1">
            <asp:Repeater ID="PosterAbstracts" runat="server" 
                DataSourceID="PostersObjectDS">

            <ItemTemplate>
                 <div class="schedule">
      <div class="sch-img"><img runat="server" id="MainImagePoster" src='<%# GetImagePath(DataBinder.Eval(Container.DataItem, "PosterPath").ToString()) %>' width="100" height="115" /></div>
        <div class="sch-info">
        <h1><%# DataBinder.Eval(Container.DataItem, "AbstractTitle")%></h1>
        <h2><%# DataBinder.Eval(Container.DataItem, "AbstractAuthors")%></h2>
        <p>
            <%# DataBinder.Eval(Container.DataItem, "Background")%>
        </p>
        </div>
        <div class="clear"></div>
    </div>
            </ItemTemplate>
            
            </asp:Repeater>
            <asp:ObjectDataSource ID="PostersObjectDS" runat="server" 
                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllPoster" 
                TypeName="BusinessLogicLayer.Components.Conference.AbstractsLogic">
            </asp:ObjectDataSource>
        </div>
        <div id="abs2-2">
            <dx:ASPxHiddenField ID="OralAbstractHidden" runat="server">
            </dx:ASPxHiddenField>
        <asp:ListView ID="OralAbstractsList" runat="server" 
                DataSourceID="OralObjectDS">
                <LayoutTemplate>
                <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>
                </LayoutTemplate>
            <ItemTemplate>
                <div style="display:none;" visible="false"><%# OralCount = Container.DataItemIndex %></div>
                <div class="schedule">
                    <div class="sch-info">
                        <h1>
                            <%# DataBinder.Eval(Container.DataItem, "AbstractTitle")%>
                        </h1>
                        <h2>
                            <%# DataBinder.Eval(Container.DataItem, "AbstractAuthors")%>
                        </h2>
                        <p>
                            <%# DataBinder.Eval(Container.DataItem, "Background")%>                            
                        </p>
                    </div>
                    <div class="clear">
                    </div>
                    </div>
                
            </ItemTemplate>
            
            </asp:ListView>
            
            
            <asp:ObjectDataSource ID="OralObjectDS" runat="server" 
                OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllOral" 
                TypeName="BusinessLogicLayer.Components.Conference.AbstractsLogic">
            </asp:ObjectDataSource>
        </div>
    </div>
    
</asp:Content>
