<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="rCanto.aspx.cs" Inherits="CelebracionSistemaWeb2._0.UI.Registros.rCanto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-left: 35%; margin-right: 35%">
         <div class="page-header text-center">
            <h2 style="color: #358CCE">Registro de Cantos</h2>
        </div>

        <hr style="color: #358CCE" />
        <br />
        <br />

        <div style="width: 12%">
            <asp:Label Text="Id" runat="server" />
            <input class="form-control" id="IdInput" type="number" runat="server" />
            <asp:Button Class="btn btn-warning" ID="Buscarbtn" runat="server" Text="Buscar" OnClick="Buscarbtn_Click" />

        </div>

        <br />
        <div>
            <asp:Label Text="Nombre Del Canto" runat="server" />
            <asp:TextBox  class="form-control" ID="DescripcionInput" runat="server" />

             <asp:requiredfieldvalidator id="RequiredFieldValidator3" runat="server" errormessage="Campos Obligatorios" controltovalidate="DescripcionInput" font-bold="True" forecolor="Red" validationgroup="Guardar">*</asp:requiredfieldvalidator>
            <asp:regularexpressionvalidator id="RegularExpressionValidator2" runat="server" errormessage="Solo Letras" controltovalidate="DescripcionInput" font-bold="True" forecolor="Red" validationexpression="[A-Za-z ]*">*</asp:regularexpressionvalidator>
        </div>

         <br />
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
