<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeliveryMethod.aspx.cs" Inherits="OSEN.DELIVERYMETHOD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DELIVERY METHOD</title>
    <link rel="stylesheet" href="SIGNFORMS.css"/>

</head>
<body>
    

    <div class="Login_Container">
        <div class="Cover"></div>
        <form id="SignIn" runat="server">

            <div class="Contents">
                <div class="LoginForm">

                    <div class="title2">
                        <img src="https://img.icons8.com/material/25/000000/delivery--v1.png"/> Delivery-Method
                    </div>

                    <br />

                    <div class="Input_Boxes">

                         <!---Delivery--->
                        <div class="SubmitD Box">
                            <asp:Button ID="BtnDel" runat="server" Height="50px" Text="Delivery" Width="100%" CssClass="Buttun" OnClick="BtnDel_Click"/>
                        </div>

                        <br>
                        <div class="Divide">
                            <p class="Collect">OR</p>
                        </div>
                        
                        <br>

                        <!---Collection--->
                        <div class="SubmitD Box">
                            <asp:Button ID="btnCollect" runat="server" Height="50px" Text="Collect" Width="100%" CssClass="Buttun" OnClick="btnCollect_Click"/>
                        </div>

                        
                            <asp:Label ID="LabelError" runat="server" Text="Label" ForeColor="Red" Visible="False"></asp:Label>

                        
                            <asp:Label ID="LabelCust" runat="server" Text="Label" Visible="False"></asp:Label>
                            <asp:Label ID="LabelServ" runat="server" Text="Label" Visible="False"></asp:Label>

                        
                            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>

                        
                            <br><br>
                            
                        
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


</body>
</html>
