<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="OnlineUtility._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Introduction</h2>
        <p class="lead">This is a general testing application which houses basic functions and tools for Captiva and other software</p>
     
        <h2>CaptivaXMLViewer</h2>
        <p class="lead">This Viewer visualises the Captiva 7 encoded xml and xpp files. Thanks for the code Scott Roth.</p>
 <p class="lead">  <asp:FileUpload ID="FileUpload" runat="server" Width="800px" /> </p>
        <p class="lead">  <asp:Button ID="BtnConvert" runat="server" Text="Convert" /></p>
       <p class="lead">  <asp:TextBox ID="txtResult" runat="server" Width="800px" Height="200px" TextMode="MultiLine"></asp:TextBox> </p>
    </div>
  
    </asp:Content>
