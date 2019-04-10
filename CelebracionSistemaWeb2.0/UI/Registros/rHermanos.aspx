<%@ Page Title="" CodeFile="~/UI/Registros/rHermanos.aspx.cs" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="rHermanos.aspx.cs" Inherits="CelebracionSistemaWeb2._0.UI.Registros.rHermanos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-left: 35%; margin-right: 35%">
         <div class="page-header text-center">
            <h2 style="color: #358CCE">Registro de Hermanos</h2>
        </div>

        <hr style="color: #358CCE" />
        <br />
        <br />

        <div style="width: 8%">
            <asp:Label Text="Id" runat="server" />
            <input class="form-control" id="IdInput" type="number" runat="server" />
            <asp:Button Class="btn btn-warning" ID="Buscarbtn" runat="server" Text="Buscar" OnClick="Buscarbtn_Click" />
        </div>

        <br />
        <div>
            <asp:Label Text="Nombre Completo" runat="server" />
            <asp:TextBox class="form-control" ID="NombreInput" runat="server" />
        </div>
        <br />
        <div>
            <asp:Label Text="Direccion" runat="server" />
            <asp:TextBox class="form-control" ID="DireccionInput" runat="server" Height="55px" Rows="1" TextMode="MultiLine" />
        </div>
        <br />
        <div>
            <asp:Label Text="Telefono de la casa:" runat="server" />
            <asp:TextBox class="form-control" ID="TelCasaInput" runat="server" TextMode="Phone" />
        </div>
          <br />
        <div>
            <asp:Label Text="Telefono del Celular:" runat="server" />
            <asp:TextBox class="form-control" ID="TelCelularInput" runat="server" TextMode="Phone" />
        </div>
          <br />
        <div>
            <asp:Label Text="Otro Telefono:" runat="server" />
            <asp:TextBox class="form-control" ID="OtroTelInput" runat="server" TextMode="Phone" />
        </div>
        <br />

        <label>Fecha de Nacimiento:</label>
        <div>
            <asp:TextBox ID="fechaTextbox" runat="server" class="form-control input-md"  TextMode="Date"></asp:TextBox>
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
