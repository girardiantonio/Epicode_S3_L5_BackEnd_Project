<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="Epicode_S3_L5_BackEnd_Project.Dettaglio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card mb-3">
        <div class="row g-0 d-flex align-items-center">
            <div class="col-md-4">
                <asp:Image ID="ImgUrl" runat="server" CssClass="img-fluid" />
            </div>
            <div class="col-md-8">
                <div class="card-body">
                    <h3><asp:Label ID="NomeProdotto" class="card-title" runat="server"></asp:Label></h3>
                    <p><asp:Label ID="DescrizioneProdotto" class="card-text" runat="server"></asp:Label></p>
                    <p><asp:Label ID="DescrizioneDettagliata" class="card-text" runat="server"></asp:Label></p>
                    <p><strong><asp:Label ID="Prezzo" runat="server"></asp:Label></strong></p>
                    <asp:Button ID="AddCarrello" runat="server" Text="Aggiungi al Carrello" CssClass="btn btn-primary" OnClick="AddCarrello_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
