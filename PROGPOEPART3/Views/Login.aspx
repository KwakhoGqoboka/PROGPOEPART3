<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PROGPOEPART3.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #btnSubmit {
            width: 200px;
            height: 50px;
        }
        .center {
            position: absolute;
            top: 25%;
            width: 50%;
            text-align: center;
            font-size: 18px;
            left: 25%;
}
        #UserNameTb {
            margin-left: 88px;
        }
        #PASSWORDTb {
            margin-left: 92px;
        }
    </style>
</head>
<body>
    <div class="center">
    <form id="form1" runat="server">
    <section class="wrapper">
        <div class="row">
            <div class="col-lg-12">
                <section class="panel">
                    <header class="panel-heading">
                        <div class="col-md-4 col-md-offset-4">
                            <h1>LOGIN</h1>
                            <img src="../Images/user-g76aad6228_1280.png" height="150"/>
                            <asp:Label ID ="lblshow" runat="server"></asp:Label>
                        </div>
                    </header>
                    <br />

                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md-4 col-md-offset-4">
                                <div class="form-group">
                                    <asp:Label Text="USER NAME:" runat="server" ></asp:Label>
                                    <asp:TextBox ID="txtUserName" runat="server" style="margin-left: 97px" ></asp:TextBox>
                                    
                                   
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />
                        
                    <div>
                        <div class="row">
                            <div class="col-md-4 col-md-offset-4">
                                <div class="form-group">
                                    <asp:Label Text="PASSWORD:" runat="server" ></asp:Label>
                                    <asp:TextBox TextMode="Password" ID="txtPassword" runat="server" style="margin-left: 97px" ></asp:TextBox>
                                    
                            </div>
                        </div>
                    </div>
                    <br />

                    <div class="row">
                        <div class="col-md-8">
                            <div class="form-group">
                                <asp:Button type="submit" ID="LoginBtn" Text="LOGIN" runat="server" BackColor="DarkGreen" OnClick="LoginBtn_Click"/>
                                <asp:Button type="register" ID="RegisterBtn" Text="REGISTER" runat="server" BackColor="DarkRed" style="margin-left: 46px" OnClick="RegisterBtn_Click"/>
                            </div>
                            
                        </div>
                    </div>

                </section>
            </div>
        </div>
    </section>
    </form>
        </div>
  </body>
</html>
