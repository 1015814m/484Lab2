<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Employee.aspx.cs" Inherits="EmployeeDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <section>
    <p>
    <br />
        <asp:Label ID="lblFirstName" runat="server" Text="First Name: " Width="10%" ></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" CssClass="longInputText"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblLastName" runat="server" Text="Last Name: " Width="10%"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" CssClass="longInputText"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblMiddleInitial" runat="server" Text="Middle Initial*: " Width="10%"></asp:Label>
        <asp:TextBox ID="txtMiddleInitial" runat="server" CssClass="shortInputText"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblDateOfBirth" runat="server" Text="Date of Birth: " Width="10%"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" placeholder="YYYY-MM-DD" runat="server" CssClass="mediumInputText"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblHouseNum" runat="server" Text="House Number: " Width="10%"></asp:Label>
        <asp:TextBox ID="txtHouseNum" runat="server" CssClass="mediumInputText"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblStreet" runat="server" Text="Street: " Width="10%"></asp:Label>
        <asp:TextBox ID="txtStreet" runat="server" CssClass="longInputText"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblCity" runat="server" Text="City: " Width="10%"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server" CssClass="longInputText"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblStateAbb" runat="server" Text="State Abbreviation*: " Width="10%"></asp:Label>
        <asp:TextBox ID="txtState" runat="server" CssClass="shortInputText"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblCountry" runat="server" Text="Country Abbreviation: " Width="10%"></asp:Label>
        <asp:TextBox ID="txtCountry" runat="server" CssClass="shortInputText"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblZip" runat="server" Text="Zip Code: " Width="10%"></asp:Label>
        <asp:TextBox ID="txtZip" runat="server" CssClass="mediumInputText"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblHireDate" runat="server" Text="Hire Date: " Width="10%"></asp:Label>
        <asp:TextBox placeholder="YYYY-MM-DD" ID="txtHireDate" runat="server" CssClass="mediumInputText"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblTerminationDate" runat="server" Text="Termination Date*: " Width="10%"></asp:Label>
        <asp:TextBox placeholder="YYYY-MM-DD" ID="txtTerminationDate" runat="server" CssClass="mediumInputText"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblSalary" runat="server" Text="Salary: " Width="10%"></asp:Label>
        <asp:TextBox placeholder="e.g. 45000" ID="txtSalary" runat="server" CssClass ="mediumInputText"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblManagerID" runat="server" Text="Manager ID*: " Width="10%"></asp:Label>
        <asp:TextBox ID="txtManagerID" runat="server" CssClass="shortInputText"></asp:TextBox>
    </p>
    <p>
        <asp:Button CssClass="btn" ID="btnCommitEmployee" runat="server" Text="Commit" OnClick="btnCommitEmployee_Click" />
        <asp:Button CssClass="btn" ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        <asp:Button CssClass="btn" ID="btnExit" runat="server" Text="Exit" OnClick="btnExit_Click" />
    </p>
    <p>
        <asp:Label ID="resultMessage" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Label ID="errorMessage" runat="server" Text=""></asp:Label>
        </p>
        </section>
</asp:Content>

