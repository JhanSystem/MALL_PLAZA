<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmListadoProyectos.aspx.cs" Inherits="WebBIMallPlaza.Mantenimiento.frmListadoProyectos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <div style="color:black;padding-top:4px;padding-left:4px;padding-right:4px">
       <h3>LISTADO GENERAL DE PROYECTOS</h3>
    </div>
    <div style="padding-top:4px;padding-left:4px;padding-right:4px">
        <%--<asp:Button ID="btnNuevoProy" runat="server" CssClass="btn btn-primary" Text="Nuevo" data-target="#myModal" data-toggle="modal" />--%>
        <button id="open" type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
                Nuevo Proyecto
        </button>
         <%--<a href="#" id="open">Abrir popup</a>--%>
    </div>
    <div style="padding-top:4px;padding-left:4px;padding-right:4px">
        <asp:GridView ID="gvProyectos" runat="server"
           Width="100%" AutoGenerateColumns="false" OnSelectedIndexChanged="gvProyectos_SelectedIndexChanged"
           ForeColor="Black" CssClass="table table-bordered table" AllowPaging="true">
            <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="#e2f3f1" />
            
            <EmptyDataTemplate>
                ¡No hay proyectos disponibles!  
            </EmptyDataTemplate>
           <Columns>
               <asp:BoundField HeaderText="Cód.Proy" DataField="IDProyecto" HeaderStyle-ForeColor="Black"/>
               <asp:BoundField HeaderText="Proyecto" DataField="ProyectoNombre" HeaderStyle-ForeColor="Black" />
               <asp:BoundField HeaderText="Cód. Mall" DataField="ProyectoMall" HeaderStyle-ForeColor="Black" />
               <asp:BoundField HeaderText="Tip. Proyecto" DataField="ProyectoTipo" HeaderStyle-ForeColor="Black" />
               <asp:BoundField HeaderText="Estado" DataField="ProyectoEstado" HeaderStyle-ForeColor="Black" />
               <asp:BoundField HeaderText="Cartera" DataField="ProyectoCartera" HeaderStyle-ForeColor="Black" />
               <asp:BoundField HeaderText="Área Terreno" DataField="ProyectoAreaTerreno" HeaderStyle-ForeColor="Black" />
               <asp:BoundField HeaderText="Mt2 Construidos" DataField="ProyectoM2Construidos" HeaderStyle-ForeColor="Black" />
               <asp:BoundField HeaderText="Mt2 Arrendables" DataField="ProyectoM2Arrendables" HeaderStyle-ForeColor="Black" />
               <asp:BoundField HeaderText="Eje. Obras" DataField="ProyectoEjecucionObras" HeaderStyle-ForeColor="Black" />
           </Columns>
       
       </asp:GridView> 
    </div>

</asp:Content>
