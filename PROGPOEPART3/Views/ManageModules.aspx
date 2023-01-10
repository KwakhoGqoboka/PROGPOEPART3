<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="ManageModules.aspx.cs" Inherits="PROGPOEPART3.Views.Home.ManageModules" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    ul {
                    list-style-type: none;
                    margin: 0;
                    padding: 0;
                    overflow: hidden;
                    background-color:blue;
                }

                li {
                    float: left;
                }
              li a {
                display: block;
                color: white;
                text-align: center;
                padding: 14px 16px;
                text-decoration: none;
                width: 100px;
                height: 24px;
                margin-left: 35px;
                
            }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <ul>
                    <li><a href="Home.aspx">Home</a></li>
                    <li><a href="Modules.aspx">MODULES</a></li>
                     <li><a href="ManageModules.aspx">MANAGE</a></li>
                     <li><a href="Reminder.aspx">REMINDER</a></li>
                     <li style="float:right"><a class="active" href="Login.aspx">LOGOUT</a></li>
       </ul>
        <div>
        </div>
        <br /><br /><br />
        <p>
            <asp:Label ID="Label1" runat="server" Text="MANAGE MODULES"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnSubmit" runat="server" Text="Search" OnClick="btnSubmit_Click" />
        </p>
        <asp:ListBox Width="1000" Height="300" ID="lstDisplay" runat="server"></asp:ListBox>
    </form>
</body>
</html>
    