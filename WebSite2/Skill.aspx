<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Skill.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <p>
        <br />
        <asp:Label ID="lblSkillName" runat="server" Text="Skill Name: " Width="10%"></asp:Label>
        <asp:TextBox ID="txtSkillName" runat="server" CssClass="inputText"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblSkillDescription" runat="server" Text="Skill Description: " Width="10%"></asp:Label>
        <asp:TextBox ID="txtSkillDescription" runat="server" CssClass="inputText"></asp:TextBox>
    </p>
    <p>
        <asp:Button CssClass="btn" ID="btnCommitSkill" runat="server" Text="Commit" />
        <asp:Button CssClass="btn" ID="btnClear" runat="server" Text="Clear" />
    </p>

</asp:Content>

