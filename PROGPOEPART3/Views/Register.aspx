<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PROGPOEPART3.Views.Register" %>

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
                            <h1>REGISTER</h1>
                            <img src="../Images/cyber-security-g46264cc3e_1280.png" height="150"/>
                            <asp:Label ID="lblShow" runat="server"></asp:Label>
                        </div>
                    </header>
                    <br />

                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md-4 col-md-offset-4">
                                <div class="form-group">
                                    <asp:Label Text="USER NAME:" runat="server" ></asp:Label>
                                    <asp:TextBox Id="txtUserName" runat="server" style="margin-left: 97px" ></asp:TextBox>                
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
                                    <asp:TextBox TextMode="Password"  ID="txtPassword" runat="server" style="margin-left: 97px" ></asp:TextBox>                
                            </div>
                        </div>
                    </div>
                    <br />

                    <div class="row">
                        <div class="col-md-8">
                            <div class="form-group">
                                <asp:Button type="Register" ID="RegisterBtn" Text="REGISTER" runat="server" BackColor="DarkGreen" OnClick="RegisterBtn_Click" />
                                <asp:Button type="Cancel" ID="CancelBtn" Text="CANCEL" runat="server" BackColor="DarkRed" style="margin-left: 46px"/>
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
