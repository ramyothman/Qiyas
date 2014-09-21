<%@ Page Theme="Builder" Language="C#" AutoEventWireup="true" CodeBehind="eBuilder.aspx.cs" Inherits="SocioBuilderSite.Administrator.Builder.eBuilder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/eBuilder/reset.css" rel="stylesheet" type="text/css" />
    <link href="Styles/eBuilder/builderStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="menu"></div>
        <iframe id="layoutContent" src="BuilderLayout.aspx">
        </iframe>
    </div>
    </form>
</body>
</html>
