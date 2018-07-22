<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectedItemDetails.aspx.cs" Inherits="RajSoniPricingAsh.SelectedItemDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView AllowSorting="true" runat="server" ID="GvDetails" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="SelectItem">
                        <ItemTemplate>
                            <asp:CheckBox ID="ChkSelect"  runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Product" ReadOnly="true" HeaderText="Item" />
                    <asp:BoundField DataField="price" ReadOnly="true" HeaderText="Price($)"/>
                    <asp:BoundField DataField="discount" ReadOnly="true" HeaderText="Discount($)"/>
                    
                                    </Columns>

            </asp:GridView>
            <table>
                <tr>
                    <td>
            <asp:Button Text="Total Amount" runat="server" ID="btnAmt" OnClick="btnAmt_Click" />
                        </td>
                    </tr>

                <tr>
                    <td>
                        <asp:Label ID="lblselected" runat="server" text="" />
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Label ID="lblpay" runat="server" text="" />
                    </td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
