<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="OSEN.LOGINFORM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title>Sign In</title>
    <link rel="stylesheet" href="SIGNFORMS.css"/>

    <!---PREVENT FROM GOING BACK--->
    <script type ="text/javascript">
        window.onload = window.history.forward(0);
    </script>

</head>

<body>

    <div class="Login_Container">
        <form id="form1" runat="server">
            <div class="Contents">
                <div class="LoginForm">
                    <!---Titles--->
                    <div class="title">
                        <img src="https://img.icons8.com/external-bearicons-glyph-bearicons/20/000000/external-log-in-call-to-action-bearicons-glyph-bearicons-1.png" /> Sign In
                    </div>


                    <!---Titles--->
                    <br />
                    <asp:Label ID="Errormess" runat="server" Text="Label" Visible="False" Font-Bold="True" ForeColor="Red"></asp:Label><asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>

                    <div class="Input_Boxes">
                        <div class="Email Box">
                            <img src="https://img.icons8.com/external-becris-lineal-becris/17/000000/external-email-mintab-for-ios-becris-lineal-becris.png" />
                            <asp:TextBox ID="TextName" placeholder="Enter Email" runat="server" CssClass="MyTextbox" autocomplete="off" required TextMode="Email"></asp:TextBox>
                        </div>
                        
                        <div class="PassW Box">
                            <img src="https://img.icons8.com/ios-glyphs/17/000000/lock-landscape.png" />
                            <asp:TextBox ID="TextPass" placeholder="Password" runat="server" CssClass="MyTextbox" autocomplete="off" required TextMode="Password"></asp:TextBox>
                        </div>


                        <div class="Bord">
                            <label class="RememberCh">
                                Remember Me
                                <asp:CheckBox ID="CheckBRemem" runat="server"/>
                                <span class="Check-Cust"></span>
                            </label>
                        </div>

                        <!---Forgotpassword--->
                        <div class="Forgtext">

                            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="Forgetpass" NavigateUrl="~/forgotpassword.aspx"><p>Forgot password</p></asp:HyperLink>
                        </div>
                        
                        <br/>


                        <!---submitbutton--->
                        <div class="SubmitD Box">
                            <asp:Button ID="btnSignIn" runat="server" Height="50px" Text="Sign In" Width="100%" CssClass="Buttun" OnClick="btnSignIn_Click" />
                        </div>

                        <!---create password--->
                        <div class="CreateAcc">
                            Create an Account?
                            <a href="signup.aspx">Sign Up</a>
                            <br/>
                            Go to
                            <a href="welcome.aspx">Welcome page</a>
                            <br/>
                            
                            <asp:Label ID="LabelCust" runat="server" Text="Label" Visible="False"></asp:Label>
                            
                            <br/><br/>
                            
                        </div>
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
