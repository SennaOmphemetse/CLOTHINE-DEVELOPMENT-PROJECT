<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutputForm.aspx.cs" Inherits="OSEN.OutputForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>YOUR SERVICES</title>
    <link rel="stylesheet" href="BOOKINGSTYLE.css"/>
    <script type ="text/javascript">
        window.onload = window.history.forward(0);
    </script>

</head>
<body>
    


    <div class="Container">
        

        <form id="form1" runat="server">
        
        <div class="Intro">
           <h3>THANK YOU FOR CHOOSING OUR ORGANISATION..</h3>
            <br />
            <asp:Label ID="WelcomeLabel" runat="server" Text="label"></asp:Label>
        </div>


            <br />
            <h4>Services:</h4>
            <p>&nbsp;</p>
            <asp:Label ID="LabelProduct" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:GridView ID="GVServices" runat="server" Width="600px">
            </asp:GridView>
            <br />
            <br />
            <h4>Payments:</h4>
            <br />
            <asp:Label ID="LabeService" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="LabeDelivery" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <br />
            <h4>Booking Address:</h4>
            <br />
            <asp:GridView ID="GridAddress" runat="server" Width="600px">
            </asp:GridView>
            <asp:Label ID="LabelNobook" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <br />
            <h4>Delivery Method:</h4>
            <br />
            <asp:Label ID="LabelDelivaddress" runat="server" Text="Label" Visible="False"></asp:Label>
            <asp:Label ID="LabelCollect" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:GridView ID="GridDeliv" runat="server" Width="600px">
            </asp:GridView>

            <asp:Label ID="LabelDellive" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />

            <br />
            //Your records will be saved after confirming!!!!.......................<br />
            <asp:Label ID="Label3" runat="server" Text="Thank you!!!!!"></asp:Label>
            <br />
            <asp:Button ID="btnConfirmOrder" runat="server" Text="Confirm" CssClass="mybtn" OnClick="btnConfirmOrder_Click" />
            <asp:Label ID="LabelCust" runat="server" Text="0" Visible="False"></asp:Label>
            <asp:Label ID="LabelDelivv" runat="server" Text="0" Visible="False"></asp:Label>
            <asp:Label ID="custome" runat="server" Text="Label" Visible="False"></asp:Label>
            <asp:Label ID="Labemail" runat="server" Text="Label" Visible="False"></asp:Label>
            <asp:Label ID="Labelerr" runat="server" Text="Label" Visible="False"></asp:Label>
        </form>

    </div>



</body>
</html>
