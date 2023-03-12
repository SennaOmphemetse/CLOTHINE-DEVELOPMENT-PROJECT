<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentsMethods.aspx.cs" Inherits="OSEN.PAYMENTSFORM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PAYMENT OPTION</title>
    <link rel="stylesheet" href="BOOKINGSTYLE.css"/>

</head>
<body>
    

    <div class="Container">
       
        
       <div class="Intro">
           <h3>Choose method of payment:</h3>
            <asp:Label ID="WelcomeLabel" runat="server" Text="The Distance costs at the bottom area for Delivery options."></asp:Label>
            
            <br/><br/>
            <br/><br/>
        </div>

       <form id="SignIn" runat="server">
           <div class="User-details">
               
               
               <div class="input-box hh">
                   <div class="Card Box">
                            <asp:Button ID="ButCard" runat="server" Height="50px" Text="Card on Delivery" Width="100%" CssClass="mybtn" OnClick="ButCard_Click" />
                        </div>
               </div>

               <br/><br/>

               <div class="input-box">
                   <div class="Cash Box">
                            
                           <asp:Button ID="ButCashD" runat="server" Height="50px" Text="Cash on Delivery" Width="100%" CssClass="mybtn" OnClick="ButCashD_Click" />
                        </div>
               </div>

               <br />
               

               </div>
                <br />
               <hr/>
                <div class="input-box">
                   <div class="City Box">
                       <h4 class="CalenText">Distance Costs:</h4>
                       <br />
                       <p>Delivery Price = R75.00</p>
                       <asp:Label ID="LabelCust" runat="server" Text="Label" Visible="False"></asp:Label>
                       <asp:Label ID="LabelSer" runat="server" Text="Label" Visible="False"></asp:Label>
                       <asp:Label ID="Labeldeli" runat="server" Text="Label" Visible="False"></asp:Label>
                        
                       <asp:Label ID="LabelAmou" runat="server" Text="Label" Visible="False"></asp:Label>
                        
                       <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                        
                   </div>
               </div>

       </form>

   </div>



</body>
</html>
