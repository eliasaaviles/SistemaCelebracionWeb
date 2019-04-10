<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="rCelebracion.aspx.cs" Inherits="CelebracionSistemaWeb2._0.UI.Registros.rCelebracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-header text-center">
        <h2 style="color: #358CCE">Registro de Celebracion</h2>
    </div>

    <hr style="color: #358CCE" />

    <div class="panel-body">
        <div class="form-horizontal col-md-12" role="form">



            <div class="form-group row control-label" style="align-items: center;">

                <label style="font-size: medium;" for="ReciboId" class="col-md-3   input-sm">Celebracion Id:</label>
                <div class="col-md-3 col-sm-6 col-xs-6">
                    <asp:textbox id="CelebracionIdInput" runat="server" placeholder="0" class="form-control input-md" type="number" style="font-size: medium"></asp:textbox>
                </div>

                <div class="col-md-1 col-sm-1 col-xs-4">
                    <asp:button id="BuscarButton" runat="server" text="Buscar" validationgroup="ValidacionBE" class="btn btn-warning btn-md" OnClick="BuscarButton_Click" />
                </div>

                <label style="font-size: medium;" for="FechaTextbox" class="col-md-2   input-sm">Fecha</label>

                <div class="col-md-2 col-sm-6 col-xs-6">
                    <asp:textbox id="FechaTextBox" runat="server" placeholder="0" class="form-control input-md" style="font-size: medium" textmode="Date"></asp:textbox>
                </div>

            </div>

            <div class="form-group row control-label" style="align-items: center;">
                <label for="ClienteDropDownList" class="col-md-3 input-sm" style="font-size: medium">Tema a Presentar</label>
                <div class="col-md-3 col-sm-6 col-xs-6">
                    <asp:DropDownList ID="TemaDrown" style="font-size: medium" class="form-control input-sm " runat="server"></asp:DropDownList>

                </div>


              <div class="form-group row control-label" style="align-items: center;">
                <label for="ClienteDropDownList" class="col-md-3 input-sm" style="font-size: medium">Monitor Ambiental</label>
                <div class="col-md-3 col-sm-6 col-xs-6">
                    <asp:DropDownList ID="HermanoDrown" style="font-size: medium" class="form-control input-sm " runat="server"></asp:DropDownList>

                </div>

            </div>
           
           
            <div class="form-group row control-label" style="align-items: center;">
                <label for="ArticuloDropDownList" class="col-md-3 input-sm" style="font-size: medium">Canto de entrada</label>
                <div class="col-md-3 col-sm-6 col-xs-6">
                    <asp:DropDownList ID="CantoEntradaDrown" class="form-control input-sm " style="font-size: medium" runat="server"></asp:DropDownList>

                </div>

            </div>                
                  <div class="page-header text-center">
        <h2 style="color: #358CCE">Detalle de Celebracion</h2>
    </div>

             <div class="form-group row control-label" style="align-items: center;">
                <label for="ArticuloDropDownList" class="col-md-3 input-sm" style="font-size: medium">Orden</label>
                <div class="col-md-3 col-sm-6 col-xs-6">
                      <asp:DropDownList ID="OrdenDrown" CssClass="form-control" runat="server">
                            <asp:ListItem>Primera Lectura</asp:ListItem>
                            <asp:ListItem>Segunda Lectura</asp:ListItem>
                          <asp:ListItem>Tercera Lectura</asp:ListItem>
                          <asp:ListItem>Cuarta Lectura</asp:ListItem>
                       </asp:DropDownList>
  </div>
                </div>

        </div>
    <%--Descripcion--%>
            <div class="form-group row control-label" style="align-items: center;">
                <label for="Descripcion" class="col-md-3 input-sm" style="font-size: medium;">Lectura</label>
                <div class="col-md-3 col-sm-6 col-xs-6">
                    <asp:TextBox ID="LecturaDrown" runat="server" class="form-control input-md" type="tel" Style="font-size: medium"></asp:TextBox>
                </div>
                 <div class="form-group row control-label" style="align-items: center;">
                <label for="ClienteDropDownList" class="col-md-3 input-sm" style="font-size: medium">Monitor </label>
                <div class="col-md-3 col-sm-6 col-xs-6">
                    <asp:DropDownList ID="MonitorDrown" style="font-size: medium" class="form-control input-sm " runat="server"></asp:DropDownList>

                </div>

            </div>
         

         
            <div class="form-group row control-label" style="align-items: center;">
                <label for="CantoDrown" class="col-md-3 input-sm" style="font-size: medium">Canto de entrada</label>
                <div class="col-md-3 col-sm-6 col-xs-6">
                    <asp:DropDownList ID="CantoDrown" class="form-control input-sm " style="font-size: medium" runat="server"></asp:DropDownList>
                    <br />
                     <div class="col-md-2 col-sm-2 col-xs-4">
                    <asp:Button ID="AgregarButton" runat="server" Text="Añadir" ValidationGroup="ValidacionGM" class="btn btn-success btn-md" Font-Size="Medium" OnClick="AgregarButton_Click"/>
                </div>
           

      
        </div>



    </div>

            
            <div class="form-group  control-label" style="align-items: center;">
                <div class="table-responsive ">
                    <asp:GridView ID="DetalleGridView" runat="server" class="table table-condensed" CellPadding="6"  ForeColor="#333333" >
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                          
                           <asp:BoundField DataField="CelebracionDetalleId" HeaderText="Celebracion ID" />
                            <asp:BoundField DataField="Orden" HeaderText="Orden" />
                            <asp:BoundField DataField="Lectura" HeaderText="Lectura" />
                            <asp:BoundField DataField="Monitor" HeaderText="Monitor" />
                            <asp:BoundField DataField="Canto" HeaderText="Canto" />

                            



                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                       <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
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

    
    <div class="panel-body ">
        <div class="form-horizontal col-md-12" role="form">

            
         
              
            </div>
        </div>
    </div>

    <%--Botones--%>
    <div class="panel">
        <div class="text-center">
            <div class="form-group">
                <asp:Button ID="ButtonNuevo" runat="server" Text="Nuevo" class="btn btn-info" OnClick="ButtonNuevo_Click"  />

                <asp:Button ID="ButtonGuardar" runat="server"  Text="Guardar" class="btn btn-success" OnClick="ButtonGuardar_Click"  />
                
                <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" ValidationGroup="ValidacionBE" class="btn btn-danger" OnClick="ButtonEliminar_Click"  />

            </div>
        </div>
    </div>



</asp:Content>
