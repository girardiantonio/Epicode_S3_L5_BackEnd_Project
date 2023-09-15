<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="Epicode_S3_L5_BackEnd_Project.Carrello" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-3">
        <h2>Carrello</h2>
        <asp:Repeater ID="CarrelloRepeater" runat="server">
            <ItemTemplate>
                <div class="d-flex align-items-center">
                    <div class="d-flex flex-column justify-content-center mx-3">
                        <asp:Label ID="NomeProdotto" class="card-title" runat="server" Text='<%# Eval("Nome") %>'></asp:Label>
                        <asp:Label ID="Prezzo" runat="server" Text='<%# "$" + Eval("Prezzo") %>'></asp:Label>
                    </div>
                    <asp:Button ID="EliminaProdotto" runat="server" Text="Elimina" CssClass="btn btn-warning"
                        OnClick="EliminaProdotto_Click" CommandArgument='<%# Eval("IdProdotto") %>' />
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <p class="mt-5">Totale: $<asp:Label ID="TotaleLabel" runat="server" Text="0.00"></asp:Label></p>
        <asp:Button ID="SvuotaCarrello" runat="server" Text="Svuota Carrello" class="btn btn-danger" OnClick="SvuotaCarrello_Click" />
    </div>
</asp:Content>

