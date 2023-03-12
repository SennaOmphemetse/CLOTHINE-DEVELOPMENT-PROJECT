<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Deliv_Address.aspx.cs" Inherits="OSEN.DELIVERYADDRESS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DELIVERY ADDRESS</title>
    <link rel="stylesheet" href="BOOKINGSTYLE.css"/>

</head>
<body>
    

    <div class="Container">
       
        
       <div class="Intro">
            <h3>Location to Deliver Items:</h3>

            <br/>
            <br/>
        </div>

       <form id="Form11" runat="server">
           <div class="User-details">
               
               
               <div class="input-box">
                   <div class="Address1 Box">
                            <img src="https://img.icons8.com/material/17/000000/address.png"/>
                            
                            <asp:TextBox ID="TextAdd1" placeholder="Address1" runat="server" CssClass="MyTextbox" autocomplete="off" required></asp:TextBox>
                        </div>
               </div>

               <br/>
               <br/>

               <div class="input-box">
                   <div class="Address1 Box">
                            <img src="https://img.icons8.com/material/17/000000/address.png"/>
                            
                            <asp:TextBox ID="TextAdd2" placeholder="Address2" runat="server" CssClass="MyTextbox" autocomplete="off" required></asp:TextBox>
                        </div>
               </div>


               <div class="input-box">
                   <div class="Address2 Box">
                            <img src="https://img.icons8.com/material/17/000000/address.png"/>
                            
                            <asp:TextBox ID="TextAdd3" placeholder="Address3 Optional" runat="server" CssClass="MyTextbox" autocomplete="off"></asp:TextBox>
                        </div>
               </div>

               <div class="input-box">
                   <div class="City Box">
                            <img src="https://img.icons8.com/material/24/000000/world.png"/>
                            <asp:TextBox ID="TextCity" placeholder="City" runat="server" CssClass="MyTextbox" autocomplete="off" required></asp:TextBox>
                        </div>
               </div>


               <div class="input-box">
                   <div class="Zip Box">
                            <img src="https://img.icons8.com/material/17/000000/zip-code.png"/>
                            <asp:TextBox ID="TextPost" placeholder="Postal/ZipCode" runat="server" CssClass="MyTextbox" autocomplete="off" required></asp:TextBox>
                        </div>
                   <br/><br/>
               </div>

           <!---Line--->
                <hr />
               <br />
               
               <div class="input-box">
                        <div class="Myname Box">
                           <img src="https://img.icons8.com/material/17/000000/name--v1.png"/>
                           <asp:TextBox ID="TextFname" placeholder="Collectors Name" runat="server" CssClass="MyTextbox" autocomplete="off" required></asp:TextBox>
                        </div>
                   </div>


                   <div class="input-box">
                       <div class="Mysurname Box">
                           <img src="https://img.icons8.com/material/17/000000/name--v1.png"/>
                           <asp:TextBox ID="TextSname" placeholder="Collectors surname" runat="server" CssClass="MyTextbox" autocomplete="off" required></asp:TextBox>
                        </div>
                   </div>

                <div class="input-box">
                    <div class="Cellphone Box">
                        <img src="https://img.icons8.com/material/24/000000/phone-message.png"/>
                        <asp:TextBox ID="TextCellp" placeholder="Collectors Cellphone number" runat="server" CssClass="MyTextbox" autocomplete="off" required></asp:TextBox>
                    </div>
            </div>


           </div>

          
           <br />
           <br />
           <br />
           <!---Line--->
           <hr />
           <asp:Label ID="LabelErr" runat="server" Text="Label" ForeColor="Red" Visible="False"></asp:Label>
           <asp:Label ID="LabelDeliv" runat="server" Text="0" Visible="False"></asp:Label>
           <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
           <asp:Label ID="Labelserv" runat="server" Text="0" Visible="False"></asp:Label>
           <br />
           <br />
           <!---submitbutton--->
                        
           <div class="Buttons">
                <div class="SubmitD">
                    <asp:Button ID="btnSend" runat="server" Height="50px" Text="Submit" Width="100%" CssClass="Buttons" OnClick="btnSend_Click" />
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
                    <asp:Button ID="Button1" runat="server" Height="35px" Text="Clear" Width="50px" CssClass="Buttons1" OnClick="Button1_Click"  />
                </div>
           </div>
                        

       </form>

   </div>



</body>
</html>
