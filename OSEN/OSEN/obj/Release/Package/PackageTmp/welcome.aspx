<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="OSEN.WELCOMEFORM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>CLOTHINE</title>
    <link rel="stylesheet" href="WELCOMESTYLE.css"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <link rel="stylesheet" href='https://unpkg.com/boxicons@2.0.9/css/boxicons.main.css'/>
    <link rel="icon" href="https://img.icons8.com/external-tal-revivo-green-tal-revivo/25/000000/external-bubbles-from-the-washing-machine-in-laundry-services-laundry-green-tal-revivo.png/"/>
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <script type ="text/javascript">
        window.onload = window.history.forward(0);
    </script>

</head>
<body>
    

    <form id="form1" runat="server">


        <!------header----->
    <header class="flex-box">
        <!---name-logo-menu--->
        <div class="left-part flex-box">
            <i class="fab"><img src="https://img.icons8.com/external-tal-revivo-green-tal-revivo/25/000000/external-bubbles-from-the-washing-machine-in-laundry-services-laundry-green-tal-revivo.png"/><span><span class="mid">Clothine</span> Laundry</span></i>
        </div>
        <!---center-search--->
        
        <div class="right-part flex-box">
            <p class="Home"><asp:button ID="homeb" runat="server" Text="About" Width="50px" CssClass="cent1" OnClick="homeb_Click"/></p>
            <p class="About"><asp:button ID="aboutb" runat="server" Text="Terms and Conditions" Width="150px" CssClass="cent1" OnClick="aboutb_Click"/></p>
            <p class="Home"><asp:button ID="ButContac" runat="server" Text="Contact" Width="52px" CssClass="cent1" OnClick="ButContac_Click"/></p>
            <p class="About"><asp:button ID="ButSocial" runat="server" Text="Socia-media" Width="83px" CssClass="cent1" OnClick="ButSocial_Click"/></p>

        </div>
        <!---login-sign--->

            
        <div class="right-part flex-box">
            <p class="signin"><asp:button ID="signIn" runat="server" Text="Sign In" CssClass="ButtonClass" OnClick="signIn_Click" /></p>
            <p class="signup"><asp:button ID="signUp" runat="server" Text="Sign Up" CssClass="ButtonClass" OnClick="signUp_Click"/></p>

        </div>

    </header>

     <!---Inside--->
     <!---WELCOME MESSAGE--->

     <div class="heading1">

         <h1>Welcome To CLOTHINE Laundry Services:</h1>
         
     </div>

     <div class="heading2">
         <br />
         <h2>Services:</h2>
         
     </div>
     

     <!-----------------Images-------------------->

     
     <div class="container">
         

         <!---Image1--->
         <div class="card">
             <div class="imagebox">
                 <img src="hanna-zhyhar-RS9nsyy7QQM-unsplash.jpg"/>
             </div>
             <div class="content">
                <h2>Clothes</h2>
                <p>Our administration washes all categories of clothes. For instance, Tops, Trousers(Pants),Socks etc. We do exclude underwear in the category of clothes. Any underwear found on the items will be charged R 100 each.</p>
            </div>
         </div>

         <!---Image2--->
         <div class="card">
             <div class="imagebox">
                 <img src="ryan-plomp-jvoZ-Aux9aw-unsplash.jpg" width="300" height="370" />
             </div>
             <div class="content">
                <h2>Shoes</h2>
                <p>Our administration washes all launderable shoes in all classifications for example formal shoes, takkies, sandals and so on. We do exclude TORN SHOES in our administrations to abstain from annihilating or damaging them further contingent upon how torn they are.</p>
            </div>
         </div>

         <!---Image3--->
         <div class="card">
             <div class="imagebox">
                 <img src="kelly-sikkema-CNjfgzoY8JU-unsplash.jpg" width="300" height="370" />
             </div>
             <div class="content">
                <h2>Blankets</h2>
                <p>Our administration washes all blankest like light blankets, duvet, comforter etc. Note that TORN BLANKETS are not on the list.</p>
            </div>
         </div>

         <!---Image4--->
         <div class="card">
             <div class="imagebox">
                 <img src="ann-ann-4Kl5N0eXX6U-unsplash.jpg" width="300" height="370" />
             </div>
             <div class="content">
                <h2>Curtains</h2>
                <p>Our administration washes all curtains or draperies. In the event that light shades are somehow torn. Kindly do exclude them, in any case, incorporate the rest..</p>
            </div>
         </div>

     </div>

        

        <div class="heading2">
            <br />
            <h2><asp:Label ID="LabeAbout" runat="server" Text="About:" Visible="False"></asp:Label></h2>
        </div>
        <div class="heading2">
            <br />
            <asp:Label ID="LabelAbout2" runat="server" Text="value" CssClass="all" Visible="False"></asp:Label>
         
        </div>




        <div class="heading2">
             <br />
             <h2><asp:Label ID="LabelHelp" runat="server" Text="Help:" Visible="False"></asp:Label></h2>
              <h4><asp:Label ID="LabelHelp2" runat="server" Text="About:" Visible="False"></asp:Label></h4>
        </div>

        <div class="heading2">
             <br />
             <h2><asp:Label ID="LabelSocial" runat="server" Text="Follow us:" Visible="False"></asp:Label></h2>
              <h4><asp:Label ID="LabelSocial2" runat="server" Text="About:" Visible="False"></asp:Label></h4>
        </div>

 </form>


</body>
</html>
