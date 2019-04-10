<%@ Page Title=""  Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="cUsuario.aspx.cs" Inherits="CelebracionSistemaWeb2._0.UI.Sesion.cUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="jumbotron">
        <div class="page-header text-center">
            <h2 style="color: #358CCE">Consulta de Usuarios</h2>
        </div>

        <hr style="color: #358CCE" />

        <div>
            <div class="form-group">
                <div class="row justify-content-center">
                    <div class="col-md-2">
                        <label for="DropDownListFiltro">Filtro:</label>
                        <asp:DropDownList ID="DropDownListFiltro" CssClass="form-control" runat="server">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>Usuario Id</asp:ListItem>
                            <asp:ListItem>Nombre Personal</asp:ListItem>
                            <asp:ListItem>Nombre Usuario</asp:ListItem>
                            <asp:ListItem>Email</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-lg-1"></div>
                    <div class="col-lg-4">
                        <label for="TextBoxBuscar">Buscar:</label>
                        <asp:TextBox ID="TextBoxBuscar" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div style="margin-top: 7px;" class="col-lg-1 p-0">
                        <asp:LinkButton ID="BuscarLinkButton" CssClass="btn btn-primary mt-4" runat="server" OnClick="BuscarLinkButton_Click"> <span class="fas fa-search"></span>Buscar </asp:LinkButton>
                    </div>
                </div>

                <div class="row justify-content-center mt-3">
                    <div class="col-lg-11">
                        <asp:GridView ID="GridView" runat="server" AllowPaging="True" PageSize="50" CssClass="table table-striped table-hover table-responsive-lg" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="IdUsuario" HeaderText="Hermano ID" />
                                <asp:BoundField DataField="Nombre" HeaderText="Nombre Personal" />
                                <asp:BoundField DataField="NombreUsuario" HeaderText="Nombre del usuario" />
                                <asp:BoundField DataField="Email" HeaderText="Email" /> 
                                <asp:BoundField DataField="Clave" HeaderText="Contraseña" />  
                            </Columns>
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
            </div>
        </div>
    
</asp:Content>
