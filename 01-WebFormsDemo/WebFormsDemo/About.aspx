<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebFormsDemo.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <asp:ListView runat="server" ID="ListviewMembers" ItemType="WebFormsDemo.Models.TeamMember" >
    </asp:ListView>
</asp:Content>
