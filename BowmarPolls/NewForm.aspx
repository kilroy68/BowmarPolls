<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewForm.aspx.cs" Inherits="BowmarPolls.NewForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Poll Title"></asp:Label>
            <asp:TextBox ID="poll_title" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Choice 1"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Choice 2"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Choice 3"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Choice 4"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Choice 5"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Choice 6"></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Choice 7"></asp:Label>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="CreatePollButton" runat="server" Text="Create Poll" 
                onclick="CreateNewPoll_Click" />
        </div>

    </form>

</body>
</html>
