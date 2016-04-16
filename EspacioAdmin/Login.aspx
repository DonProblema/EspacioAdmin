<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EspacioAdmin.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Login</p>
    <p>
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
        :
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
    </p>
    <p>
        Contraseña: <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
    </p>
<p>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Ingresar" />
    &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblAviso" runat="server"></asp:Label>
    </p>
</asp:Content>
