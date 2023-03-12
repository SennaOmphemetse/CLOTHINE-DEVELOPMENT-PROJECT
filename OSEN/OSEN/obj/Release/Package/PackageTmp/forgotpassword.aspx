<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgotpassword.aspx.cs" Inherits="OSEN.FORGOTPFORM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>REQUEST PASSWORD</title>
    <link rel="stylesheet" href="SIGNFORMS.css"/>

</head>
<body>
    

    <div class="Login_Container">
        <form id="SignIn" runat="server">

            <div class="Contents">
                <div class="LoginForm">
                    <div class="title2">
                        <img src="https://img.icons8.com/ios-filled/20/undefined/fingerprint.png"/> Recover password

                    </div>

                    <br />
                    <div class="Input_Boxes">

                        <div class="Email Box">
                            <img src="https://img.icons8.com/external-becris-lineal-becris/17/000000/external-email-mintab-for-ios-becris-lineal-becris.png" />
                            <asp:TextBox ID="TextEmail" placeholder="Enter your Email" runat="server" CssClass="MyTextbox" autocomplete="off" required></asp:TextBox>
                        </div>

                        <div class="Email Box">
                            <img src="https://img.icons8.com/external-becris-lineal-becris/17/000000/external-email-mintab-for-ios-becris-lineal-becris.png" />
                            <asp:TextBox ID="TextEmail2" placeholder="Confirm your Email" runat="server" CssClass="MyTextbox" autocomplete="off" required></asp:TextBox>
                        </div>

                        <p>Your password will be sent to your Email</p>
                        <asp:Label ID="erroLab" runat="server" Text="Label" Visible="False"></asp:Label>
                        
                        <br/>
                        <div class="SubmitD Box">
                            <asp:Button ID="btnPass" runat="server" Height="50px" Text="Sign In" Width="100%" CssClass="Buttun" OnClick="btnPass_Click"/>
                        </div>

                        <div class="CreateAcc">
                            Cancel and return to
                            <a href="SignIn.aspx">login page</a> or to <a href="signup.aspx">signup page</a>
                        </div>

                        <br/>
                        <br/>

                        <!---Social media--->
                        <div class="social">
                        <a href="#"><img src="https://img.icons8.com/small/30/000000/facebook-new.png" /></a>
                        <a href="#"><img src="https://img.icons8.com/small/30/000000/instagram-new.png" /></a>
                        <a href="#"><img src="https://img.icons8.com/small/30/000000/twitter-circled.png" /></a>
                        <a href="#"><img src="https://img.icons8.com/small/30/000000/youtube--v1.png" /></a>
                        <a href="#"><img src="https://img.icons8.com/small/30/000000/github.png" /></a>

                    </div>

                    </div>
                </div>

            </div>
        </form>

    </div>


</body>
</html>
