<%@ Page Theme="EventoAdmin" Title="" Language="C#" MasterPageFile="~/_MasterPages/EventoAdmin.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SocioBuilderSite._MasterPages.WebForm1" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxScheduler" TagPrefix="dxwschs" %>
<%@ Register assembly="DevExpress.XtraScheduler.v14.1.Core, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraScheduler" tagprefix="cc1" %>
<%@ Register assembly="DevExpress.XtraCharts.v14.1.Web, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts.Web" tagprefix="dxchartsui" %>
<%@ Register assembly="DevExpress.XtraCharts.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts" tagprefix="cc2" %>
<%@ Register assembly="DevExpress.Web.ASPxGauges.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGauges" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGauges.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGauges.Gauges" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGauges.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGauges.Gauges.Linear" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGauges.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGauges.Gauges.Circular" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGauges.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGauges.Gauges.State" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxGauges.v14.1, Version=14.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGauges.Gauges.Digital" tagprefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
<div class="g12 nodrop">
			<h1>Dashboard</h1>
			<p>This is a quick overview of some features</p>
		</div>	

		
		<div class="g6 widgets">
		
			<div class="widget widget-header-gray" id="calendar_widget" data-icon="calendar">
				<h3 class="handle">Calendar</h3>
				<div class="inner-content">
					<div class="calendar" data-header="small">
					</div>
					<p>
					<a class="btn" href="calendar.html">Check out the Calendar section</a>
					</p>
				</div>
			</div>
			
		
			<div class="widget number-widget" id="widget_number">
				<h3 class="handle">Number</h3>
				<div class="inner-content">
					<ul>
						<li><a href=""><span>7423</span> Total Visits</a></li>
						<li><a href=""><span>392</span> Today Visits</a></li>
						<li><a href=""><span>153</span> Unique Visits</a></li>
						<li><a href=""><span>14</span> Support Tickets</a></li>
						<li><a href=""><span>253</span> Comments</a></li>
					</ul>
				</div>
			</div>
		</div>
		
		
		<div class="g6 widgets">
			<div class="widget widget-header-blue" id="widget_charts" data-icon="graph-dark">
				<h3 class="handle">Charts</h3>
				<div class="inner-content">
					<p>

					<a class="btn" href="charts.html">Check out the Charts section</a>
					</p>
                    <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" 
                        DataSourceID="ObjectDataSource1" KeyFieldName="LanguageId">
                        <Columns>
                            <dx:GridViewCommandColumn VisibleIndex="0">
                                <EditButton Visible="True">
                                </EditButton>
                                <NewButton Visible="True">
                                </NewButton>
                                <DeleteButton Visible="True">
                                </DeleteButton>
                                <ClearFilterButton Visible="True">
                                </ClearFilterButton>
                            </dx:GridViewCommandColumn>
                            <dx:GridViewDataTextColumn FieldName="LanguageId" ReadOnly="True" 
                                VisibleIndex="1">
                                <EditFormSettings Visible="False" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="LanguageCode" VisibleIndex="2">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Name" VisibleIndex="3">
                            </dx:GridViewDataTextColumn>
                        </Columns>
                        <Settings ShowFilterRow="True" />
                    </dx:ASPxGridView>
                    <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" 
                    DataSourceID="ObjectDataSource1" TextField="Name" ValueField="LanguageId" 
                    ValueType="System.Int32">
                </dx:ASPxComboBox>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                    DeleteMethod="Delete" InsertMethod="Insert" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetAll" 
                    TypeName="BusinessLogicLayer.Components.ContentManagement.LanguageLogic" 
                    UpdateMethod="Update">
                    <DeleteParameters>
                        <asp:Parameter Name="Original_LanguageId" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="LanguageCode" Type="String" />
                        <asp:Parameter Name="Name" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="LanguageCode" Type="String" />
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="Original_LanguageId" Type="Int32" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
                <dx:ASPxTextBox ID="ASPxTextBox1" runat="server" Width="170px">
                    <ValidationSettings>
                        <RequiredField IsRequired="True" />
                    </ValidationSettings>
                </dx:ASPxTextBox>
                <dx:ASPxButton ID="ASPxButton1" runat="server" Text="ASPxButton">
                </dx:ASPxButton>
					</div>
                
				</div>
				
				<div class="widget widget-header-orange" id="widget_accordion">
					<h3 class="handle">Accordion</h3>
					<div class="inner-content">
						
						<div>
							<p>
								 Cras dictum. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean lacinia mauris vel est.
							</p>
							<p>
								 Suspendisse eu nisl. Nullam ut libero. Integer dignissim consequat lectus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.
							</p>
						</div>
					</div>
				</div>
				
				<div class="widget" id="widget_breadcrumb">
					<h3 class="handle">Breadcrumb</h3>
					<div class="inner-content">
						<ul class="breadcrumb" data-numbers="true">
							<li><a href="#">Ready</a></li>
							<li><a href="#">Set</a></li>
                            <li><a href="#">Steady</a></li>
							<li><a href="#">GO!</a></li>
						</ul>
						<p>
						<a class="btn" href="breadcrumb.html">Check out the Breadcrumb section</a>
						</p>
					</div>
				</div>
				
				
				
				
			</div>

            <div class="g12">
            	<div class="form">
					<fieldset class="fieldset">
						<label class="label">Text Fields</label>
						<section><label class="label" for="text_field">Text Field</label>
							<div><input class="input" type="text" id="text_field" name="text_field"></div>
						</section>
						<section><label class="label" for="text_tooltip">Field with Tooltip</label>
							<div><input class="input" type="text" id="text_tooltip" name="text_tooltip" title="A Tooltip">
							<span>Just specify a title attribut to get a Tooltip</span>
							</div>
						</section>
						<section><label class="label" for="text_tooltip">Placeholder Text</label>
							<div><input class="input" type="text" id="text_placeholder" name="text_placeholder" placeholder="your placeholder text">
							<span>use the placeholder attribute <code>placeholder="your placeholder text"</code></span>
							</div>
						</section>
						<section><label class="label" for="textarea">Textarea</label>
							<div><textarea class="textarea" id="textarea" name="textarea" rows="10"></textarea></div>
						</section>
						<section><label class="label" for="textarea_auto">Autogrow Textarea<br><span>Some extra information</span></label>
							<div><textarea class="textarea" id="textarea_auto" name="textarea_auto" data-autogrow="true"></textarea>
								<span>will expand after you hit the bottom edge</span>
							</div>
						</section>
						<section><label class="label" for="textarea_auto">WYSIWYG Editor<br><span>(W)hat (y)ou (s)ee (i)s (w)hat (y)ou (g)et</span></label>
							<div><textarea class="textarea" id="textarea_wysiwyg" name="textarea_wysiwyg" class="html" rows="12"></textarea>
							</div>
						</section>
					</fieldset>
					<div class="alert info">Some Fields are MouseWheel enabled!</div>
					
					
					
					
					
					
					
					
					
				</div>	
            </div>
</asp:Content>
