<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="EspacioAdmin.CrearUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Crear Usuario</h2>
    <table>
        <tr>
            <td>
                Usuario:
            </td>
            <td>
                <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Contraseña:
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Confirma Contraseña:
            </td>
            <td>
                <asp:TextBox ID="txtConfirmaContra" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Perfil:
            </td>
            <td>
                <asp:DropDownList ID="ddlPerfil" runat="server" OnInit="ddlPerfil_Init"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                Habilitado:
            </td>
            <td>
                <asp:CheckBox ID="chkHabilitado" runat="server" Checked="true" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnCrear" runat="server" Text="Crear Usuario" OnClick="btnCrear_Click" />
            </td>
            <td>
                <asp:Label ID="lblAviso" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
