<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarVehiculos.aspx.cs" Inherits="CapaPresentacion.ListarClientes" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Demo Capas ASP.NET - SQL Server</title>    
</head>
<body>
    <form id="form1" runat="server" style="background-color: #0099CC">
        <div style="text-align: center;">
            <table border="1" style="margin: 0 auto;">
                <tr>
                    <td colspan="3">
                       
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Ingrese Algo:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtApellidosCliente" runat="server" Width="150px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
                        <asp:Button ID="btnNuevoCliente" runat="server" OnClick="btnNuevoCliente_Click" Text="Nuevo" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="GridViewDatos" runat="server" AutoGenerateColumns="true" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="GridViewDatos_RowDeleting" OnRowCommand="GridViewDatos_RowCommand" AllowPaging="True" OnPageIndexChanging="GridViewDatos_PageIndexChanging" PageSize="5">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:TemplateField HeaderText="Eliminar" ShowHeader="False">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False"
                                            CommandName="Delete" ImageUrl="~/Imagenes/delete.gif"
                                            OnClientClick="return confirm('Esta seguro que desea eliminar el registro?');"
                                            Text="Eliminar" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:ButtonField ButtonType="Image" CommandName="Actualizar"
                                    HeaderText="Editar" ImageUrl="~/Imagenes/edit.gif" Text="Botón" />
                                
                            </Columns>
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F8FAFA" />
                            <SortedAscendingHeaderStyle BackColor="#246B61" />
                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                        </asp:GridView>
                    </td>
                </tr>              
                </table>
        </div>
    </form>
</body>
</html>
