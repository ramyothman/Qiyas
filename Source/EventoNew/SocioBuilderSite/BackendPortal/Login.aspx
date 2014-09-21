<%@ Page Theme="LoginTheme" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SocioBuilderSite.BackendPortal.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <meta http-equiv="imagetoolbar" content="no" />
    <title>Administration Panel Login</title>
    <!--[if lte IE 6]><link media="screen" rel="stylesheet" type="text/css" href="~/CSS/admin-login-ie.css" /><![endif]-->

</head>
<body>

    <form id="form1" runat="server">
    <div id="wrapper">
		
		
		
		
		<!--[if !IE]>start login wrapper<![endif]-->
		<div id="login_wrapper">
			
			
			<div class="error" runat="server" id="errorMessage" visible="false" >
				<div class="error_inner">
					<strong runat="server" id="errorMessageTitle">Access Denied</strong> | <span runat="server" id="errorMessageDescription">user/password combination wrong</span>
				</div>
			</div>
			<!--[if !IE]>start login<![endif]-->
			<div class="formcontainer">
            
            <div class="formclass">
					<h1 id="logo"><a href="#">College of Medicine Administration Panel</a></h1>
					<div class="formular">
						<div class="formular_inner">
						
						<label>
							<strong>Username:</strong>
							<span class="input_wrapper">
								<input name="" type="text" runat="server" id="UserNameText" />
							</span>
						</label>
						<label>
							<strong>Password:</strong>
							<span class="input_wrapper">
								<input name="" type="password" runat="server" id="PasswordText" />
							</span>
						</label>
						<label class="inline">
							<input class="checkbox" name="" type="checkbox" value="" runat="server" id="RememberPasswordCheck" />
							Remember me on this computer
						</label>
						
						
						<ul class="form_menu">
							<li><span class="button"><span><span>Login</span></span><asp:Button runat="server" 
                                    ID="SaveButton" onclick="SaveButton_Click" /></span></li>
							<li><a href="#"><span><span>Back</span></span></a></li>
							<li><a href="#"><span><span>Forgot Pass</span></span></a></li>
						</ul>
						
						</div>
					</div>
			</div>
            </div>
			<!--[if !IE]>end login<![endif]-->
			
			
			
		</div>
		<!--[if !IE]>end login wrapper<![endif]-->
	</div>
    </form>
</body>
</html>
