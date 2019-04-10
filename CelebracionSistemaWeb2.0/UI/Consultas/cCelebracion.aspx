<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="cCelebracion.aspx.cs" Inherits="CelebracionSistemaWeb2._0.UI.Consultas.cCelebracion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="page-header text-center">
            <h2 style="color: #358CCE">Consulta de Cantos</h2>
        </div>

        <hr style="color: #358CCE" />



    <div class="panel-body ">
        <div class="form-horizontal col-md-12" role="form">

            <%--Entradas de las consulta--%>
            <div class="form-group control-label" style="align-items: center;">

                <asp:Label ID="Labelfiltro" Style="font-size: medium;" runat="server" class="col-md-1 " Text="Filtro:"></asp:Label>

                <div class="col-md-2">
                    <asp:DropDownList ID="FiltroDropDownList" runat="server" Class="form-control input-sm" Style="font-size: medium">
                        <asp:ListItem>Recibo Id</asp:ListItem>
                        <asp:ListItem>ClienteId</asp:ListItem>
                        <asp:ListItem>Nombre de Cliente</asp:ListItem>
                        <asp:ListItem>Monto Total</asp:ListItem>                  
                        <asp:ListItem Selected="True">Todo</asp:ListItem>
                    
                    </asp:DropDownList>
                </div>
                <asp:Label ID="Label1" Style="font-size: medium;" runat="server" Text="Criterio:" class="col-md-1 input-sm"></asp:Label>


                <div class="col-md-3">
                    <asp:TextBox ID="CriterioTextBox" runat="server" class="form-control input-md" Style="font-size: medium"></asp:TextBox>

                </div>
                <div class="col-md-1">
                    <asp:Button ID="BuscarButton" runat="server" Text="Buscar" class="btn btn-info btn-md" OnClick="BuscarButton_Click"  />
                </div>
            </div>


            
            <%--fecha--%>
            <div class="form-group control-label" style="align-items: center;">

                <asp:Label ID="Label2" Style="font-size: medium;" runat="server" class="col-md-1 " Text="Desde:"></asp:Label>

                <div class="col-md-2">
                
                      <asp:TextBox ID="DesdeTextBox" runat="server" class="form-control input-md" Style="font-size: medium" TextMode="Date"></asp:TextBox>

                </div>
                <asp:Label ID="Label3" Style="font-size: medium;" runat="server" Text="Hasta:" class="col-md-1 input-md"></asp:Label>


                <div class="col-md-2">
                    <asp:TextBox ID="HastaTextBox" runat="server" class="form-control input-md" Style="font-size: medium" TextMode="Date"></asp:TextBox>

                </div>
               
            </div>






        </div>
        </div>
    
        <%--Grid--%>
  
         <div class="form-horizontal col-md-12" role="form">
            <div class="table-responsive">
                        <asp:GridView ID="GridView" runat="server" AllowPaging="True" PageSize="50" CssClass="table table-striped table-hover table-responsive-lg" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                     <Columns>
                            <asp:BoundField DataField="CelebracionId" HeaderText="Celebracion Id" />
                            <asp:BoundField DataField="Tema" HeaderText="Orden" />
                            <asp:BoundField DataField="CantoEntrada" HeaderText="Lectura" />
                            <asp:BoundField DataField="CantoFinal" HeaderText="Monitor" />
                            <asp:BoundField DataField="Tema" HeaderText="Canto" />
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

             
    
        <div class="form-group row" style="align-items: center;">

           

        </div>
             </div>
  
</asp:Content>
