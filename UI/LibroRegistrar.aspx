<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LibroRegistrar.aspx.cs" Inherits="UI.LibroRegistrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div  style="text-align: center; background-color: #333; color: #fff; padding: 10px 0px; border-radius: 10px;">
        <h3>¡Libro - Registrar!</h3>
    </div> <br />

    <div  style="text-align: center; background-color: #333; color: #fff; padding: 10px 0px; border-radius: 10px;">
        <table style="width: 100%;">
            <tr>
                <td style="text-align: right; width: 283px"><b>ISBN:</b></td>
                <td style="text-align: left; width: 220px">
                    <asp:TextBox ID="txtISBN" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvISBN" runat="server" ControlToValidate="txtISBN"
                        ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right; width: 283px"><b>Título:</b></td>
                <td style="text-align: left; width: 220px">
                    <asp:TextBox ID="txtTitulo" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvTitulo" runat="server" ControlToValidate="txtTitulo"
                        ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right; width: 283px"><b>Edición:</b></td>
                <td style="text-align: left; width: 220px">
                    <asp:TextBox ID="txtEdicion" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvEdicion" runat="server" ControlToValidate="txtEdicion"
                        ErrorMessage="¡Error, campo obligatorio!" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvEdicion" runat="server" ControlToValidate="txtEdicion"
                        ErrorMessage="¡Error, formato incorrecto!" ForeColor="Red" Operator="DataTypeCheck" Type="Integer">
                    </asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right; width: 283px"><b>Género:</b></td>
                <td style="text-align: left; width: 220px">
                    <asp:DropDownList ID="ddlGenero" runat="server" Width="200px"></asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvGenero" runat="server" ControlToValidate="ddlGenero"
                        ErrorMessage="¡Seleccione un género!" InitialValue="0" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right; width: 283px"><b>Editorial:</b></td>
                <td style="text-align: left; width: 220px">
                    <asp:DropDownList ID="ddlEditorial" runat="server" Width="200px"></asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvEditorial" runat="server" ControlToValidate="ddlEditorial"
                        ErrorMessage="¡Seleccione una editorial!" InitialValue="0" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="False" />
                </td>
                <td></td>
            </tr>
        </table>
    </div>
</asp:Content>
