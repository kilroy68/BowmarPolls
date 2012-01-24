<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewForm.aspx.cs" Inherits="BowmarPolls.NewForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label9" runat="server" Text="Select the Service to set the poll for:"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="ServiceDataSource"
            DataTextField="name" DataValueField="id">
        </asp:RadioButtonList>
        <asp:LinqDataSource ID="ServiceDataSource" runat="server" ContextTypeName="BowmarPolls.App_Data.BowmarPollsDataContext"
            EntityTypeName="" Select="new (id, name)" TableName="Services">
        </asp:LinqDataSource>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Poll Title"></asp:Label>
        <asp:TextBox ID="poll_title" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Choice 1"></asp:Label>
        <asp:TextBox ID="Choice1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Choice 2"></asp:Label>
        <asp:TextBox ID="Choice2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Choice 3"></asp:Label>
        <asp:TextBox ID="Choice3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Choice 4"></asp:Label>
        <asp:TextBox ID="Choice4" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Choice 5"></asp:Label>
        <asp:TextBox ID="Choice5" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Choice 6"></asp:Label>
        <asp:TextBox ID="Choice6" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Choice 7"></asp:Label>
        <asp:TextBox ID="Choice7" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="CreatePollButton" runat="server" Text="Create Poll" OnClick="CreateNewPoll_Click" />
    </div>
    </form>
</body>
</html>
