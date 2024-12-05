<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GeneroRegistrar.aspx.cs" Inherits="UI.GeneroRegistrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div  style="text-align: center; background-color: #333; color: #fff; padding: 10px 0px; border-radius: 10px;">
        <h3>¡Género - Registrar!</h3>
    </div> <br />

    <div  style="text-align: center; background-color: #333; color: #fff; padding: 10px 0px; border-radius: 10px;">
        <table style="width: 100%;">
            <tr>
                <td style="text-align: right; width: 283px">
                    <b><asp:Label ID="Label1" runat="server" Text="Descripción:"></asp:Label></b>&nbsp;</td>
                <td style="text-align: left; width: 220px">
                    <asp:TextBox ID="txtDescripcion" runat="server" Width="200px"></asp:TextBox>&nbsp;</td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="¡Error, campo obligatorio!"
                        style="text-align: left" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right; width: 283px">&nbsp;</td>
                <td style="text-align: left; width: 220px">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="False" />
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>

</asp:Content>
