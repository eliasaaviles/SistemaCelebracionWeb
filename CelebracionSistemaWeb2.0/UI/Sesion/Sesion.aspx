<%@ Page Title="" Language="C#" CodeFile="~/UI/Sesion/Sesion.aspx.cs" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Sesion.aspx.cs" Inherits="CelebracionSistemaWeb2._0.UI.Sesion.Sesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin-left: 35%; margin-right: 35%">
        <br />
        <br />
        <div>
            <asp:Label Text="Nombre Usuario" runat="server" />
            <asp:TextBox class="form-control" ID="UsuarioInput" runat="server" />
        </div>
          <br />

        <div style="width: 100%">
            <asp:Label Text="Contraseña" runat="server" />
            <asp:TextBox class="form-control" ID="ContrasenaInput" runat="server" TextMode="Password" />
            <br />

        </div>

        <div>
           
            <asp:Button CssClass="btn btn-primary" ID="InicioSesionBtn" Text="Iniciar Sesion" runat="server" OnClick="InicioSesionBtn_Click"  />
            <a href="../Default.aspx" class="btn btn-danger" tabindex="-1" role="button" aria-disabled="true">Cancelar</a>
        </div>

        <div class="alert alert-light" role="alert">
            Si no tiene cuenta, Click aqui: <a href="Registro.aspx" class="alert-link">Registar</a>
        </div>

        <br />

    </div>
    <div>
    </div>
   

</asp:Content>