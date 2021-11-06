<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 45%;
            height: 346px;
        }
        .auto-style2 {
            width: 37px;
        }
        .auto-style3 {
            width: 37px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 218px;
        }
        .auto-style6 {
            height: 23px;
            width: 218px;
        }
        .auto-style7 {
            width: 37px;
            height: 30px;
        }
        .auto-style9 {
            height: 30px;
        }
        .auto-style11 {
            margin-left: 50px;
        }
        .auto-style12 {
            width: 37px;
            height: 22px;
        }
        .auto-style13 {
            width: 218px;
            height: 22px;
        }
        .auto-style14 {
            height: 22px;
        }
        .auto-style17 {
            height: 30px;
            width: 246px;
        }
        .auto-style18 {
            width: 246px;
        }
        .auto-style19 {
            height: 23px;
            width: 246px;
        }
        .auto-style20 {
            width: 246px;
            height: 22px;
        }
        .auto-style21 {
            height: 30px;
            width: 218px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="3">
                        <asp:Label ID="WebPageTitleLabel" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Arial" Font-Size="XX-Large" Text="Calorie Counter"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="FatLabel" runat="server" Text="Fat"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="FatTextBox" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style18">
                        <asp:RequiredFieldValidator ID="FatRequiredFieldValidator" runat="server" ControlToValidate="FatTextBox" ErrorMessage="You must enter the quantity of fats" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="FatRangeValidator" runat="server" ControlToValidate="FatTextBox" ErrorMessage="Only numbers between 1 and 1000" ForeColor="Red" MaximumValue="1000" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="CarbsLabel" runat="server" Text="Carbs"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="CarbsTextBox" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style18">
                        <asp:RequiredFieldValidator ID="CarbsRequiredFieldValidator" runat="server" ControlToValidate="CarbsTextBox" ErrorMessage="You must enter the quantity of carbs" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="CarbsValidator" runat="server" ControlToValidate="CarbsTextBox" ErrorMessage="Only numbers between 1 and 1000" ForeColor="Red" MaximumValue="1000" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="ProteinLabel" runat="server" Text="Protein"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="ProteinTextBox" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style19">
                        <asp:RequiredFieldValidator ID="ProteinRequiredFieldValidator" runat="server" ControlToValidate="ProteinTextBox" ErrorMessage="You must enter the quantity of proteins" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="ProteinRangeValidator" runat="server" ControlToValidate="ProteinTextBox" ErrorMessage="Only numbers between 1 and 1000" ForeColor="Red" MaximumValue="1000" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style19"></td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Button ID="CalculateButton" runat="server" Text="Calculate" Width="110px" />
                    </td>
                    <td class="auto-style21">
                        <asp:Button ID="ClearButton" runat="server" CausesValidation="False" CssClass="auto-style11" Text="Clear" />
                    </td>
                    <td class="auto-style17"></td>
                </tr>
                <tr>
                    <td class="auto-style12"></td>
                    <td class="auto-style13"></td>
                    <td class="auto-style20"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="CaloriesForCurrentItemLabel" runat="server" Text="Calories for Current Item: "></asp:Label>
                        <asp:Label ID="CurrentItemCaloriesLabel" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style18">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="TotalForNumberOfItemsLabel" runat="server" Text="Total # of Items: "></asp:Label>
                        <asp:Label ID="TotalNumberOfItemsLabel" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style18">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="TotalForNumberOfCaloriesLabel" runat="server" Text="Total # of Calories: "></asp:Label>
                        <asp:Label ID="TotalNumberOfCaloriesLabel" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style18">&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:HiddenField ID="TotalNumberOfItemsHiddenField" runat="server" Value="0" />
        <asp:HiddenField ID="TotalNumberOfCaloriesHiddenField" runat="server" Value="0" />
    </form>
</body>
</html>
