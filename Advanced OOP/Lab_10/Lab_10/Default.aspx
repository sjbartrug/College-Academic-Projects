<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-size: x-large;
            height: 31px;
        }
        .auto-style3 {
            text-align: right;
            width: 195px;
        }
        .auto-style4 {
            width: 195px;
        }
        .auto-style5 {
            width: 160px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="3" style="text-align: center">R&#39;n&#39;R Book Sales</td>
                </tr>
                <tr>
                    <td class="auto-style3">Quantity</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="QuantityTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="QuantityRequiredFieldValidator" runat="server" ControlToValidate="QuantityTextBox" ErrorMessage="You must enter a quantity." ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="QuantityRangeValidator" runat="server" ControlToValidate="QuantityTextBox" ErrorMessage="Must be a number between 1 - 100" ForeColor="Red" MaximumValue="100" MinimumValue="1" Type="Integer">1 - 100 Only</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Title</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TitleTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="TitleRequiredFieldValidator" runat="server" ControlToValidate="TitleTextBox" ErrorMessage="You must enter a title." ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Price</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="PriceTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="PriceRequiredFieldValidator" runat="server" ControlToValidate="PriceTextBox" ErrorMessage="You must enter a price." ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="PriceRangeValidator" runat="server" ControlToValidate="PriceTextBox" ErrorMessage="Your price must be numeric." ForeColor="Red" MaximumValue="999999" MinimumValue="0" Type="Currency">Must be a number</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Extended Price</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="ExtendedPriceTextBox" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">15% Discount</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="DiscountTextBox" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="ErrorMessageLabel" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Discounted Price</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="DiscountedPriceTextBox" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="SubmitButton" runat="server" Text="Submit" />
                    </td>
                    <td>
                        <asp:Label ID="DiscountTotalLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="ClearButton" runat="server" CausesValidation="False" Text="Clear" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:HyperLink ID="ContactFormHyperLink" runat="server" NavigateUrl="~/Contact.aspx">Contact Us</asp:HyperLink>
                    </td>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:HiddenField ID="DiscountHiddenField" runat="server" Value="0" />
    </form>
</body>
</html>
