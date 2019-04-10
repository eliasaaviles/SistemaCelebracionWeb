<%@ Page Title="" CodeFile="~/UI/Sesion/Registro.aspx.cs"  Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="CelebracionSistemaWeb2._0.UI.Sesion.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin-left: 35%; margin-right: 35%">
        <br />
        <br />

        <div style="width: 12%"> 
             <asp:Label  Text="Id" runat="server" />            
            <input class="form-control" id="IdInput" type="number" runat="server" />
            <asp:Button Class="btn btn-warning" ID="Buscarbtn" runat="server" Text="Buscar" OnClick="Buscarbtn_Click"/>

            </div>

         <br />
        <div>
            <asp:Label  Text="Nombre Completo" runat="server" />            
            <asp:TextBox required="required" class="form-control" ID="NombreInput" runat="server"/>
        </div>
        
        <br />
        <div>
            <asp:Label Text="Email" runat="server" />
            <asp:TextBox class="form-control" ID="EmailInput" runat="server" TextMode="Email" />
        </div>
        <br />
        <div>
            <asp:Label Text="Nombre Usuario" runat="server" />
            <asp:TextBox class="form-control" ID="UsuarioInput" runat="server" />
        </div>
        <br />
        <div style="width: 100%">
            <asp:Label Text="Contraseña" runat="server" />
            <asp:TextBox class="form-control" ID="PasswordInput" runat="server" TextMode="Password" />
            <br />
         
        </div>
        <div style="width: 100%">
            <asp:Label Text="Confirmar Contraseña" runat="server" />
            <asp:TextBox class="form-control" ID="ConPasswordInput" runat="server" TextMode="Password" />
            <br />

         <div class="form-check">
  <input class="form-check-input" type="radio" name="exampleRadios" id="UserRadio" value="option1" checked>
  <label class="form-check-label" for="exampleRadios1">
   Usuario
  </label>
</div>
            <div class="form-check">
  <input class="form-check-input" type="radio" name="exampleRadios" id="AdminRadio" value="option2">
  <label class="form-check-label" for="exampleRadios2">
    Administrador
  </label>
</div>
</div>

    
    <div>
        <asp:Button CssClass="btn btn-info" ID="VaciarBtn" Text="Limpiar" runat="server" OnClick="VaciarBtn_Click" /> 
        <asp:Button CssClass="btn btn-success" ID="GuardarBtn" Text="Guardar" runat="server" OnClick="GuardarBtn_Click" />
        <asp:Button CssClass="btn btn-danger" ID="EliminarBtn" Text="Eliminar" runat="server" OnClick="EliminarBtn_Click" />

    </div>
    <br />


    </div>
    <div>
    </div>
   
</asp:Content>
