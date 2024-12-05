<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LibroListar.aspx.cs" Inherits="UI.LibroListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div  style="text-align: center; background-color: #333; color: #fff; padding: 10px 0px; border-radius: 10px;">
        <h3>¡Libros - Listar!</h3>
    </div>

    <div style="text-align: center; padding-bottom: 5px;">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default">Home</asp:HyperLink> |
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/LibroRegistrar">Registrar</asp:HyperLink>
    </div>

    <div align="center">
        <asp:GridView ID="gvLibros" AutoGenerateColumns="false" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" AllowPaging="True" OnPageIndexChanging="gvLibros_PageIndexChanging" PageSize="5">

            <Columns>
                <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                <asp:BoundField DataField="Titulo" HeaderText="Título" SortExpression="Titulo" />
                <asp:BoundField DataField="Edicion" HeaderText="Edición" SortExpression="Edicion" />
                <asp:BoundField DataField="IdGenero" HeaderText="Género" SortExpression="IdGenero" />
                <asp:BoundField DataField="IdEditorial" HeaderText="Editorial" SortExpression="IdEditorial" />

                <asp:TemplateField HeaderText="Acción">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl='<%# Eval("ISBN","~/LibroEditar?paramISBN={0}") %>'>Editar</asp:LinkButton> |
                        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl='<%# Eval("ISBN","~/LibroBorrar?paramISBN={0}") %>'>Borrar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    </div>

</asp:Content>
