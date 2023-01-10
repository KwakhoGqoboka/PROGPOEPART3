<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reminder.aspx.cs" Inherits="PROGPOEPART3.Views.Reminder" %>

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
            <br />
            <asp:Label ID="Label1" runat="server" Text="MODULE"></asp:Label>
            <br />
            <asp:TextBox ID="txReminder" runat="server"></asp:TextBox>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="SELECT DATE"></asp:Label>
            <br />
        </p>
        <asp:Calendar ID="DateCal" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <br /> <br />
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ModuleCode" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ModuleCode" HeaderText="ModuleCode" ReadOnly="True" SortExpression="ModuleCode" />
                <asp:BoundField DataField="DateReminder" HeaderText="DateReminder" SortExpression="DateReminder" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Reminder]"></asp:SqlDataSource>
    </form>
</body>
</html>
