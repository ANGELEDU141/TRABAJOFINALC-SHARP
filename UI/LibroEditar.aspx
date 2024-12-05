<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LibroEditar.aspx.cs" Inherits="UI.LibroEditar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div  style="text-align: center; background-color: #333; color: #fff; padding: 10px 0px; border-radius: 10px;">
        <h3>¡Libro - Editar!</h3>
    </div> <br />

    <div  style="text-align: center; background-color: #333; color: #fff; padding: 10px 0px; border-radius: 10px;">
        <table style="width: 100%;">
            <tr>
                <td style="text-align: right; width: 283px">
                    <b><asp:Label ID="Label1" runat="server" Text="ISBN:"></asp:Label></b>&nbsp;</td>
                <td style="text-align: left; width: 220px">
                    <asp:TextBox ID="txtISBN" runat="server" Width="200px" ReadOnly="true"></asp:TextBox>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right; width: 283px">
                    <b><asp:Label ID="Label2" runat="server" Text="Título:"></asp:Label></b>&nbsp;</td>
                <td style="text-align: left; width: 220px">
                    <asp:TextBox ID="txtTitulo" runat="server" Width="200px"></asp:TextBox>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right; width: 283px">
                    <b><asp:Label ID="Label3" runat="server" Text="Edición:"></asp:Label></b>&nbsp;</td>
                <td style="text-align: left; width: 220px">
                    <asp:TextBox ID="txtEdicion" runat="server" Width="200px"></asp:TextBox>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right; width: 283px">
                    <b><asp:Label ID="Label4" runat="server" Text="Género:"></asp:Label></b>&nbsp;</td>
                <td style="text-align: left; width: 220px">
                    <asp:DropDownList ID="ddlGenero" runat="server" Height="28px" Width="200px"></asp:DropDownList>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right; width: 283px">
                    <b><asp:Label ID="Label5" runat="server" Text="Editorial:"></asp:Label></b>&nbsp;</td>
                <td style="text-align: left; width: 220px">
                    <asp:DropDownList ID="ddlEditorial" runat="server" Height="28px" Width="200px"></asp:DropDownList>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right; width: 283px">&nbsp;</td>
                <td style="text-align: left; width: 220px">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>

</asp:Content>
