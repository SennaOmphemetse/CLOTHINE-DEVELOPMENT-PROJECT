<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Services.aspx.cs" Inherits="OSEN.SERVICESFORM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SELECT SERVICES</title>
    <link rel="stylesheet" href="SERVICESSTYLE.css"/>

</head>
<body>
    

    <form id="form1" runat="server">

        <div class="heading2">
             <br />
             <h1 class="headin">You can choose any the types of services below:</h1>
            <br /><br />
             <h2 class="small">Services:</h2>
            <hr class="hr"/>
         
        </div>

        <div class="container">
         

         <!---Image1--->
         <div class="card">
             <div class="imagebox">
                 <img src="keagan-henman-xPJYL0l5Ii8-unsplash%20(1).jpg" width="300" height="370" />
             </div>
             <div class="content">
                <h2>Clothes</h2>
                <p>R50.00 per ITEM</p>
                 <br />
                 <div class="Prices">
                     <asp:CheckBox ID="cbClothes" runat="server" text=" Click here" />
                     <asp:DropDownList ID="DropClothes" runat="server" CssClass="drop">
                         <asp:ListItem Selected="True" Value="0">Item number</asp:ListItem>
                         <asp:ListItem>1</asp:ListItem>
                         <asp:ListItem>2</asp:ListItem>
                         <asp:ListItem>3</asp:ListItem>
                         <asp:ListItem>4</asp:ListItem>
                         <asp:ListItem>5</asp:ListItem>
                         <asp:ListItem>6</asp:ListItem>
                         <asp:ListItem>7</asp:ListItem>
                         <asp:ListItem>8</asp:ListItem>
                         <asp:ListItem>9</asp:ListItem>
                         <asp:ListItem>10</asp:ListItem>
                     </asp:DropDownList>
                   </div>
            </div>
         </div>

         <!---Image2--->
         <div class="card">
             <div class="imagebox">
                 <img src="ryan-plomp-76w_eDO1u1E-unsplash.jpg" width="300" height="370" />
             </div>
             <div class="content">
                <h2>Takkies</h2>
                <p>R50.00 per ITEM</p>
                 <br />
                 <div class="Prices">
                     <asp:CheckBox ID="cbTakkie" runat="server" text=" Click here" Visible="True" />
                     <asp:DropDownList ID="DropTakkies" runat="server" CssClass="drop">
                         <asp:ListItem Selected="True" Value="0">Item number</asp:ListItem>
                         <asp:ListItem>1</asp:ListItem>
                         <asp:ListItem>2</asp:ListItem>
                         <asp:ListItem>3</asp:ListItem>
                         <asp:ListItem>4</asp:ListItem>
                         <asp:ListItem>5</asp:ListItem>
                         <asp:ListItem>6</asp:ListItem>
                         <asp:ListItem>7</asp:ListItem>
                         <asp:ListItem>8</asp:ListItem>
                         <asp:ListItem>9</asp:ListItem>
                         <asp:ListItem>10</asp:ListItem>
                     </asp:DropDownList>
                   </div>
            </div>
         </div>

         <!---Image3--->
         <div class="card">
             <div class="imagebox">
                 <img src="johnstons-of-elgin-Y3Gt6nefF2M-unsplash.jpg" width="300" height="370" />

             </div>
             <div class="content">
                <h2>Blankets</h2>
                <p>R75.00 per ITEM</p>
                 <br />
                 <div class="Prices">
                     <asp:CheckBox ID="cbBlanket" runat="server" text=" Click here" CssClass="CHECK"/>
                     <asp:DropDownList ID="DropBlanket" runat="server" CssClass="drop">
                         <asp:ListItem Selected="True" Value="0">Item number</asp:ListItem>
                         <asp:ListItem>1</asp:ListItem>
                         <asp:ListItem>2</asp:ListItem>
                         <asp:ListItem>3</asp:ListItem>
                         <asp:ListItem>4</asp:ListItem>
                         <asp:ListItem>5</asp:ListItem>
                         <asp:ListItem>6</asp:ListItem>
                         <asp:ListItem>7</asp:ListItem>
                         <asp:ListItem>8</asp:ListItem>
                         <asp:ListItem>9</asp:ListItem>
                         <asp:ListItem>10</asp:ListItem>
                     </asp:DropDownList>
                     </div>
            </div>
         </div>

         <!---Image4--->
         <div class="card">
             <div class="imagebox">
                 <img src="ann-ann-bnd3bkhTng4-unsplash.jpg" width="300" height="370" />
             </div>
             <div class="content">
                <h2>Curtains</h2>
                 <div></div>
                <p>R50.00 per ITEM </p>
                 <br />
                 <div class="Prices">
                     <asp:CheckBox ID="cbCurtains" runat="server" text=" Click here"/>
                 
                     <asp:DropDownList ID="DropCurtains" runat="server" CssClass="drop">
                         <asp:ListItem Selected="True" Value="0">Item number</asp:ListItem>
                         <asp:ListItem>1</asp:ListItem>
                         <asp:ListItem>2</asp:ListItem>
                         <asp:ListItem>3</asp:ListItem>
                         <asp:ListItem>4</asp:ListItem>
                         <asp:ListItem>5</asp:ListItem>
                         <asp:ListItem>6</asp:ListItem>
                         <asp:ListItem>7</asp:ListItem>
                         <asp:ListItem>8</asp:ListItem>
                         <asp:ListItem>9</asp:ListItem>
                         <asp:ListItem>10</asp:ListItem>
                     </asp:DropDownList>
                 </div>
            </div>
         </div>

            

     </div>
        <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Red" Visible="False"></asp:Label>
               <asp:Label ID="LabeCust" runat="server" Text="Label" Visible="False"></asp:Label>
               

        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
               

        <hr class="hr"/>
        <!---Previous--->
           <div class="Previous">
                <div class="Back">
                    Go to Back
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="prev" NavigateUrl="~/HouseCall.aspx"><p>Previous Page</p></asp:HyperLink>
                </div>

               <!---clearbutton--->
               <div class="Back">
                    <asp:Button ID="ButSubmit" runat="server" Text="Submit" CssClass="ButtonClass" OnClick="ButSubmit_Click" />
                </div>
               

           </div>

    </form>



</body>
</html>
