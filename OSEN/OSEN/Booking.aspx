<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Booking.aspx.cs" Inherits="OSEN.BOOKINGFORM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MAKE A BOOKING</title>
    <link rel="stylesheet" href="BOOKINGSTYLE.css"/>

</head>


<body>
    
    <div class="Container">
       
        
       <div class="Intro">
            <h3>Make-Booking:</h3>

            <br/>
            <br/>
        </div>

       <form id="SignIn" runat="server">
           <div class="User-details">
               
               
               <div class="input-box">
                   <div class="Address1 Box">
                            <img src="https://img.icons8.com/material/17/000000/address.png"/>
                            
                            <asp:TextBox ID="Add1Textb" placeholder="Address1" runat="server" CssClass="MyTextbox" autocomplete="off" required></asp:TextBox>
                        </div>
               </div>

               <br/>
               <br/>

               <div class="input-box">
                   <div class="Address1 Box">
                            <img src="https://img.icons8.com/material/17/000000/address.png"/>
                            
                            <asp:TextBox ID="Textadd3" placeholder="Address3 Optional" runat="server" CssClass="MyTextbox" autocomplete="off"></asp:TextBox>
                        </div>
               </div>


               <div class="input-box">
                   <div class="Address2 Box">
                            <img src="https://img.icons8.com/material/17/000000/address.png"/>
                            <asp:TextBox ID="Addr2Textb" placeholder="Address2" runat="server" CssClass="MyTextbox" autocomplete="off" required></asp:TextBox>
                    </div>
               </div>

               <div class="input-box">
                   <div class="City Box">
                            <img src="https://img.icons8.com/material/24/000000/world.png"/>
                            <asp:TextBox ID="textCity" placeholder="City" runat="server" CssClass="MyTextbox" autocomplete="off" required></asp:TextBox>
                   </div>
               </div>


               <div class="input-box">
                   <div class="Zip Box">
                            <img src="https://img.icons8.com/material/17/000000/zip-code.png"/>
                            <asp:TextBox ID="textPostalText" placeholder="Postal/ZipCode" runat="server" CssClass="MyTextbox" autocomplete="off" required></asp:TextBox>
                   </div>
               </div>



               

           </div>

           <br/>
           <br/>
           <br/>
           <hr/>
           <h4 class="CalenText">Choose House-Date And Time Below:</h4>
           <br/>
           <p>Choose Time:</p>
           <asp:TextBox ID="TextTime" runat="server" Height="24px" TextMode="Time" Width="180px" CssClass="TextB" autocomplete="off" required></asp:TextBox>
           <br />
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextTime" ErrorMessage="Choose time" ForeColor="Red" Visible="False"></asp:RequiredFieldValidator>
           
           <br />
           <asp:TextBox ID="TextCala" runat="server" Height="27px" Width="180px" autocomplete="off" CssClass="TextB" ></asp:TextBox>
&nbsp;&nbsp;
           <asp:Button ID="ButCalend" runat="server" Text="Display calander" CssClass="Buttun" OnClick="ButCalend_Click" />
           <br />
           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextCala" ErrorMessage="choose Date" ForeColor="Red" Visible="False"></asp:RequiredFieldValidator>
           <br/>
           <div class="Calenda">
               <div class="Calender">
                    <asp:Calendar ID="Calendar1" runat="server" Height="209px" Width="100%" CssClass="Calen" ForeColor="#9900CC" Visible="False" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                </div>
           </div>

           <br />
           <asp:Label ID="labelError" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
           <asp:Label ID="LabelCust" runat="server" Text="0" Visible="False"></asp:Label><asp:Label ID="LabelHou" runat="server" Text="0" Visible="False"></asp:Label>
           
           <!---submitbutton--->
                        
           <div class="Buttons">
                <div class="SubmitD">
                    <asp:Button ID="btnSubm" runat="server" Height="50px" Text="Submit" Width="100%" CssClass="Buttons" OnClick="btnSubm_Click"/>
                </div>
           </div>

           <!---Previous--->
           <div class="Previous">
                <div class="Back">
                    Go to Back
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="prev" NavigateUrl="~/HouseCall.aspx"><p>Previous Page</p></asp:HyperLink>
                </div>

               <!---clearbutton--->
               <div class="Back">
                    <asp:Button ID="Button1" runat="server" Height="35px" Text="Clear" Width="50px" CssClass="Buttons1" OnClick="Button1_Click" />
                </div>
           </div>
                        

       </form>

   </div>


</body>
</html>
