<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ABOUTFORM.aspx.cs" Inherits="OSEN.ABOUTFORM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ABOUT</title>
    <link rel="stylesheet" href="SIGNFORMS.css"/>
</head>
<body>

    <div class="Login_Container">
        <div class="Cover"></div>
        <form id="SignIn" runat="server">

            <div class="Contents">
                <div class="LoginForm">
                    <div class="Input_Boxes">

                        <div class="content">
                            <h3 id="top1"><asp:Label ID="LabelAbout" runat="server" Text="1.ABOUT:"></asp:Label></h3>
                            <br />
                            <p>CLOTHINE LAUNDRY SERVICES is a start-up company designed to provide services for people of mafikeng.We are still a start up company that is slowly developing.The company's focus is on the above services. For more information, contact us on icons below.</p>
                            <asp:Label ID="Label1" runat="server" Text="NOTE!!! OUR ADMIN WILL CONTACT YOU TO MAKE ARRANGEMENT OF EITHER COLLECTING ITEMS FROM YOU OR YOU DELIVERING THEM TO OUR STATION!!!!" Visible="True" Font-Bold="True" ForeColor="Red"></asp:Label>
                            <asp:Label ID="LabelAB" runat="server" Text="///////////////" Visible="False" Font-Bold="True"></asp:Label>
                        </div>

                        <div class="content">
                            <h3><asp:Label ID="Label2" runat="server" Text="2.Terms and Conditions"></asp:Label></h3>
                            <p>This System(Website) is the property of CLOTHINE LAUNDRY SERVICES community. It is for AUTHORIZED use only therefore by using this system, user acknowledges notice of , and agree to comply with the Organisation's Acceptable Use of Information Technology Resources Policy.</p>
                            
                            <h5>CLOSE THE SYSTEM:</h5><p>make sure you close the system imediately when done.....In order to avoid fine when damages occurs.</p>
                            <asp:Label ID="LabelTerm" runat="server" Text="///////////////" Visible="False" Font-Bold="True"></asp:Label>
                        </div>

                          
                        <div class="content">
                            <h3><asp:Label ID="LabelContact" runat="server" Text="3.Contact-us"></asp:Label></h3>
                        </div>
                        
                        <!---FOLLOW US--->
                        <div class="follow">
                            <a href="#"><img src="https://img.icons8.com/external-basicons-line-edtgraphics/30/undefined/external-Cellphone-device-activities-basicons-line-edtgraphics-3.png"/></a>
                            <a href="#"><img src="https://img.icons8.com/external-nawicon-glyph-nawicon/30/undefined/external-telephone-communication-nawicon-glyph-nawicon-2.png"/></a>
                            <a href="#"><img src="https://img.icons8.com/ios-glyphs/30/undefined/circled-envelope.png"/></a>
                        </div>
                            <asp:Label ID="LabelFll" runat="server" Text="///////////" Visible="False" Font-Bold="True"></asp:Label>
                        <br />
                        <br />

                        <div class="content">
                            <h3><asp:Label ID="LabelSocial" runat="server" Text="4.Follow-Us"></asp:Label></h3>
                        </div>
                        
                        <!---Social media--->
                        <div class="follow">
                            <a href="#"><img src="https://img.icons8.com/small/30/000000/facebook-new.png" /></a>
                            <a href="#"><img src="https://img.icons8.com/small/30/000000/instagram-new.png" /></a>
                            <a href="#"><img src="https://img.icons8.com/small/30/000000/twitter-circled.png" /></a>
                            <a href="#"><img src="https://img.icons8.com/small/30/000000/youtube--v1.png" /></a>
                            <a href="#"><img src="https://img.icons8.com/small/30/000000/github.png" /></a>
                        </div>

                        <br />

                        <div class="CreateAcc">
                            Go to
                            <a href="welcome.aspx">Welcome page</a> 
                        </div>
                        <br />
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
