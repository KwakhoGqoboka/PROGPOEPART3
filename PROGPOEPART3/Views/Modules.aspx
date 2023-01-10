<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="Modules.aspx.cs" Inherits="PROGPOEPART3.Views.Home.Modules" EnableEventValidation="false" %>

<!DOCTYPE html>
    <head>
        <title></title>
    <style>
        .center {
            position: absolute;
            top: 25%;
            width: 50%;
            text-align: center;
            font-size: 18px;
            left: 25%;
}
       
        
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
        <ul>
                    <li><a href="Home.aspx">Home</a></li>
                    <li><a href="Modules.aspx">MODULES</a></li>
                     <li><a href="ManageModules.aspx">MANAGE</a></li>
                     <li><a href="Reminder.aspx">REMINDER</a></li>
                     <li style="float:right"><a class="active" href="Login.aspx">LOGOUT</a></li>
</ul>
        <br /><br /><br />  
    <form runat="server">
       
        <br /><br />  
       
        <p>
            <Label  id="MCODE">Module CODE:</Label>
            <asp:TextBox  ID="ModuleCode" runat="server" style="margin-left: 124px" Width="190px" ></asp:TextBox>
        </p>
        <p>
             <Label id="MNAME">MODULE NAME:</Label>
            <asp:TextBox  ID="ModuleName" runat="server" style="margin-left: 97px" Width="195px" ></asp:TextBox>
        </p>
        <p>
            <Label id="MCREDITS">MODULE CREDITS:</Label>
            <asp:TextBox  ID="ModuleCredits" runat="server" style="margin-left: 75px" Width="196px" ></asp:TextBox>
        </p>
        <p>
            <Label  id="MHOURS">MODULE HOURS:</Label>
           <asp:TextBox  ID="ModuleHours" runat="server" style="margin-left: 92px" Width="197px" ></asp:TextBox>
        </p>
        
        <div>
        <p>          
            <Label id="MDATE">START DATE:</Label>
            <asp:TextBox ID="MStartDate" runat="server" style="margin-left: 121px" Width="198px" TextMode="Date" ></asp:TextBox>

        </p>
        </div>
        <p>
        <Label  id="MWEEKS">MODULE WEEKS:</Label>
            <asp:TextBox  ID="ModuleWeeks" runat="server" style="margin-left: 85px" Width="196px" ></asp:TextBox>
         </p>
        <div>
        <p>
            <asp:Button ID="btnSubmit" runat="server" BackColor="#33CC33" ForeColor="White" Text="SUBMIT" OnClick="btnSubmit_Click" style="margin-left: 165px" Width="107px" />
            <asp:Button ID="btnDisplay" runat="server" BackColor="#33CC33" ForeColor="White" Text="SUBMIT" style="margin-left: 107px" Width="101px" OnClick="btnDisplay_Click" />
            
            
        </p>
            </div> <br /><br /><br />
        
        <asp:ListBox ID="ProgramList" Width="1200" Height="300" runat="server"></asp:ListBox>
    
        </form>
        </body>
