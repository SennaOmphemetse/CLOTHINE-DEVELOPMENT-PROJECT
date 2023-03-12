<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Continue.aspx.cs" Inherits="OSEN.CONTINUEFORM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>BRIDGE</title>
    <link rel="stylesheet" href="SIGNFORMS.css"/>

</head>
<body>
    

    <div class="Login_Container">
        <div class="Cover"></div>
        <form id="SignIn" runat="server">

            <div class="Contents">
                <div class="LoginForm">
                    <div class="title3">
                        <img src="https://img.icons8.com/external-bearicons-glyph-bearicons/20/000000/external-log-in-call-to-action-bearicons-glyph-bearicons-1.png" />Continue services

                    </div>
                    <br/>
                    <div class="Input_Boxes">

                         <!---START--->
                        <div class="SubmitD Box">
                            <asp:Button ID="butnStart" runat="server" Height="50px" Text="Start" Width="100%" CssClass="Buttun" OnClick="butnStart_Click"/>
                        </div>

                        <br/>
                        <div class="Divide">
                            <p class="cont">OR</p>
                        </div>
                        
                        <br/>

                        <!---CONTINUE--->
                        <div class="SubmitD Box">
                            <asp:Button ID="butnConti" runat="server" Height="50px" Text="Continue" Width="100%" CssClass="Buttun" OnClick="butnConti_Click"/>
                        </div>

                        
                         <br/>
                         <asp:Label ID="erroLab" runat="server" Font-Bold="True" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                         <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                         <br/>
                            

                        <!---CopyWr--->
                        <div class="CopyR">
                            <p class="copyr1">copyright &copy; 2022. All rights reserved.</p>
                        </div>
                        
                    </div>
                </div>
                </div>
        </form>
    </div>
    


    <asp:Label ID="LabelCust_ID" runat="server" Text="Label" Visible="False"></asp:Label>
    


    <asp:Label ID="Labeldel" runat="server" Text="Label" Visible="False"></asp:Label>


</body>
</html>
