<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditorialListar.aspx.cs" Inherits="UI.EditorialListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div  style="text-align: center; background-color: #333; color: #fff; padding: 10px 0px; border-radius: 10px;">
        <h3>¡Editoriales - Listar!</h3>
    </div>

    <div style="text-align: center; padding-bottom: 5px;">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default">Home</asp:HyperLink> |
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/EditorialRegistrar">Registrar</asp:HyperLink>
    </div>

    <div align="center">
        <asp:GridView ID="gvEditoriales" AutoGenerateColumns="false" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" AllowPaging="True" OnPageIndexChanging="gvEditoriales_PageIndexChanging" PageSize="5">

            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" SortExpression="Descripcion" />

                <asp:TemplateField HeaderText="Acción">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl='<%# Eval("ID","~/EditorialEditar?paramID={0}") %>'>Editar</asp:LinkButton> |
                        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl='<%# Eval("ID","~/EditorialBorrar?paramID={0}") %>'>Borrar</asp:LinkButton>
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
