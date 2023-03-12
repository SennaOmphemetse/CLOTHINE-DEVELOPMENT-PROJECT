<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="OSEN.REGISTERFORM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>REGISTER FORM</title>
    <link rel="stylesheet" href="SIGNFORMS.css"/>

</head>
<body>
    

    <div class="Login_Container">
        <form id="SignUp" runat="server">

            <div class="Contents">
                <div class="SignUpForm">
                    <div class="title">
                        <img src="https://img.icons8.com/external-vitaliy-gorbachev-fill-vitaly-gorbachev/20/000000/external-user-internet-security-vitaliy-gorbachev-fill-vitaly-gorbachev.png" /> Sign-Up
                    </div>
                    <asp:Label ID="erroLab" runat="server" Text="Label" Visible="False"></asp:Label>
                    <di class="Input_Boxes">

                        <div class="Input Box" aria-selected="undefined">
                            <img src="https://img.icons8.com/ios-filled/17/000000/checked-user-male.png" />
                            <asp:TextBox ID="TexName" placeholder="Username" runat="server" CssClass="MyTextbox" autocomplete="off" required></asp:TextBox>
                        </div>

                        <div class="Email Box">
                            <img src="https://img.icons8.com/external-becris-lineal-becris/17/000000/external-email-mintab-for-ios-becris-lineal-becris.png" />
                            <asp:TextBox ID="TextEmail" placeholder="Enter your Email" runat="server" CssClass="MyTextbox" autocomplete="off" required TextMode="Email"></asp:TextBox>
                        </div>

                        <div class="CellPhone Box">
                            <img src="https://img.icons8.com/ios-filled/17/000000/hand-with-smartphone.png" />
                            <asp:TextBox ID="TextPhone" placeholder="Enter your Cell-Phone" runat="server" CssClass="MyTextbox" autocomplete="off" required TextMode="Phone"></asp:TextBox>
                        </div>

                        <div class="PassW Box">
                            <img src="https://img.icons8.com/ios-glyphs/17/000000/lock-landscape.png" />
                            <asp:TextBox ID="TextPass" placeholder="Password" runat="server" CssClass="MyTextbox" autocomplete="off" required></asp:TextBox>

                            
                        </div>


                        <div class="Forgtext">
                            <asp:CheckBox ID="CheckBAgree" runat="server" text="I agree to this site's"/>
                            <label for="flip">User Agreement</label> and <label for="flip">Privacy Policy</label>
                        </div>
                        
                        <br />
                        <div class="SubmitD Box">
                            <asp:Button ID="btnSignup" runat="server" Height="50px" Text="Sign Up" Width="100%" CssClass="Buttun" OnClick="btnSignup_Click"/>
                        </div>

                        <div class="CreateAcc">
                            Already have an Account?
                            <a href="SignIn.aspx">Login page</a>
                            <br />
                            Go to
                            <a href="welcome.aspx">Welcome page</a> 
                        </div>
                        
                        <br />
                        <br />

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
            </form>
        </div>
        


</body>
</html>
