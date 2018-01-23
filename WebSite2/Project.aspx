<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Project.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <br />
        <asp:Label ID="lblProjectName" runat="server" Text="Project Name: " Width="10%"></asp:Label>
        <asp:TextBox ID="txtProjectName" runat="server" CssClass="inputText"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="lblProjectDescription" runat="server" Text="Project Description: " Width="10%" ></asp:Label>
        <asp:TextBox ID="txtProjectDescription" runat="server" CssClass="inputText"></asp:TextBox>
        <br />
        <br />
        <asp:Button CssClass="btn" ID="btnCommitProject" runat="server" Text="Commit" />

        <asp:Button CssClass="btn" ID="btnClearProject" runat="server" Text="Clear" />
        <br />
</asp:Content>

