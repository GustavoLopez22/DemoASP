<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarActualizarVehiculos.aspx.cs" Inherits="CapaPresentacion.InsertarActualizarClientes" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Demo Capas ASP.NET - SQL Server</title>
    <style type="text/css">
        .auto-style1 {
            width: 323px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #0099CC">
        <div style="text-align: center;">
            <table border="1" style="margin: 0 auto;">
                <tr>
                    <td colspan="2">
                        <h2>
                            <asp:Label ID="Label5" runat="server" Text="Registro de vehiculos"></asp:Label></h2>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label>
                    </td>
                    <td style="text-align: left" class="auto-style1">
                        <asp:TextBox ID="txtCodigo" runat="server" MaxLength="5" Width="316px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Cilindros:"></asp:Label>
                    </td>
                    <td style="text-align: left" class="auto-style1">
                        <asp:TextBox ID="txtNombres" runat="server" Width="318px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Color:"></asp:Label>
                    </td>
                    <td style="text-align: left" class="auto-style1">
                        <asp:TextBox ID="txtApellidos" runat="server" Width="318px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="NºEjes:"></asp:Label>
                    </td>
                    <td style="text-align: left" class="auto-style1">
                        <asp:TextBox ID="txtCorreo" runat="server" Width="318px"></asp:TextBox>
                    </td>
                </tr>
                
                 <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Esatus:"></asp:Label>
                    </td>
                    <td style="text-align: left" class="auto-style1">
                        <asp:TextBox ID="txtEstatus" runat="server" Width="318px"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnGrabar" runat="server" Text="Grabar" OnClick="btnGrabar_Click" Width="100px" />
                        <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" Enabled="False" Width="100px" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Enabled="False" OnClick="btnCancelar_Click" Width="100px" />
                        <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click" Width="100px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                       
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
