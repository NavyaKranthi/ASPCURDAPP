<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="AspTask1_a_.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 38px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="ContactID"></asp:Label>
                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="txtID" runat="server" Width="246px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="txtName" runat="server" Width="244px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Mobile"></asp:Label>
                    </td>
                    <td colspan ="2">
                        <asp:TextBox ID="txtMobile" runat="server" Width="237px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td colspan ="2" class="auto-style1">
                        <asp:TextBox ID="txtAddress" runat="server" TextMode ="MultiLine" Width="240px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        
                    </td>
                    <td colspan ="2">
                        <asp:Button ID="btnUpdate" runat="server" Text="update" OnClick="btnUpdate_Click" style="height: 26px" />
                        <asp:Button ID="btnDelete" runat="server" Text="delete" OnClick="btnDelete_Click" />
                        <asp:Button ID="btnClear" runat="server" Text="clear" OnClick="btnClear_Click" />
                        <asp:Button ID="btninsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
                        <asp:Button ID="btnview" runat="server" Text="View" OnClick="btnview_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="Contact" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="ContactID" HeaderText="ContactID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Mobile" HeaderText="Mobile" />
                    <asp:BoundField DataField="Address" HeaderText="Address" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkview" runat="server" CommandArgument='<%# Eval("ContactID") %>' OnClick="lnk_OnClick">view</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
        </div>
        
    </form>
</body>
</html>
