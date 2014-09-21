<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeaderTopMainMenu.ascx.cs" Inherits="SocioBuilderSite.Controls.LiverSite.ar.HeaderTopMainMenu" %>
<div class="header">
    <div class="block_header">
      <div style="float:;">
        <div class="menu">
          <ul>
            <li><a runat="server" id="ArDefaultIndex" href="~/Livers/ar/Default.aspx" class="active"><span>الرئيسية</span></a></li>                  
            <li><a href="http://www.saslt.org"><span>معلومات للمرضى</span></a></li>
            <li><a runat="server" id="NewsLink" href="~/Livers/ar/News.aspx"><span>أخبار المركز</span></a></li>
                <li><a runat="server" id="EnglishLink" href="~/Livers/Default.aspx"><span>English</span></a></li>
    </ul>
        </div>
      </div>
      <div class="clr"></div>
    </div>
  </div>
  