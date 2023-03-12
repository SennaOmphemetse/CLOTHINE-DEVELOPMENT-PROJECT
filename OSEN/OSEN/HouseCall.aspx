<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HouseCall.aspx.cs" Inherits="OSEN.HOUSECALL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>House-Call</title>
    <link rel="stylesheet" href="SIGNFORMS.css"/>

</head>
<body>
    

    <div class="Login_Container">
        <div class="Cover"></div>
        <form id="SignIn" runat="server">

            <div class="Contents">
                <div class="LoginForm">
                    <div class="title">
                        <img src="https://img.icons8.com/external-bearicons-glyph-bearicons/20/000000/external-log-in-call-to-action-bearicons-glyph-bearicons-1.png" /> House-Call

                    </div>
                    <br/>
                    <div class="Input_Boxes">

                         <!---HousecallYesBut--->
                        <div class="SubmitD Box">
                            <asp:Button ID="btnYes" runat="server" Height="50px" Text="YES" Width="100%" CssClass="Buttun" OnClick="btnYes_Click"/>
                        </div>

                        <br/>
                        <div class="Divide">
                            <p class="cont">OR</p>
                        </div>
                        
                        <br/>

                        <!---BookingNoBut--->
                        <div class="SubmitD Box">
                            <asp:Button ID="btnNo" runat="server" Height="50px" Text="NO" Width="100%" CssClass="Buttun" OnClick="btnNo_Click"/>
                        </div>

                        
                         <br/>
                         <asp:Label ID="erroLab" runat="server" Font-Bold="True" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                         <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                         <br/>
                            
                        
                        <!---Social media--->
                        <div class="social">
                            <a href="#"><img src="https://img.icons8.com/small/30/000000/facebook-new.png" /></a>
                            <a href="#"><img src="https://img.icons8.com/small/30/000000/instagram-new.png" /></a>
                            <a href="#"><img src="https://img.icons8.com/small/30/000000/twitter-circled.png" /></a>
                            <a href="#"><img src="https://img.icons8.com/small/30/000000/youtube--v1.png" /></a>
                            <a href="#"><img src="https://img.icons8.com/small/30/000000/github.png" /></a>
                        </div>


                        <!---CopyWr--->
                        <div class="CopyR">
                            <p class="copyr1">copyright &copy; 2022. All rights reserved.</p>
                        </div>
                        
                    </div>
                </div>
                </div>
        </form>
    </div>
    


    <asp:Label ID="LabelCust_ID" runat="server" Text="0" Visible="False"></asp:Label>


</body>
</html>
