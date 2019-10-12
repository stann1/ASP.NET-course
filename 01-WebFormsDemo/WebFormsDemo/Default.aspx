<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsDemo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <h2>ASP.NET</h2>
    </div>

    <div class="row">
        Input 1: <asp:TextBox ID="InputOne" runat="server" BorderStyle="Dotted" BackColor="Yellow"></asp:TextBox>
        Input 2: <asp:TextBox ID="InputTwo" runat="server"></asp:TextBox>
        <asp:Button ID="BtnSum" Text="Sum" runat="server" OnClick="OnBtnSumClick" CssClass="btn btn-primary" />
        <p>
            <asp:Label Text="Result" ID="LblResult" runat="server" CssClass="h2" />
        </p>

    </div>

</asp:Content>
