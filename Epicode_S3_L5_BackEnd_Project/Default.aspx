<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Epicode_S3_L5_BackEnd_Project._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <div class="row">
            <asp:Repeater ID="productRepeater" runat="server">
                <ItemTemplate>
                    <div class="col-md-4 mb-4">
                        <div class="card" style="max-height: 32em">
                            <div class="card-img-top d-flex justify-content-center" style="height: 300px; overflow: hidden;">
                                <img src='<%# Eval("ImgUrl") %>' class="img-fluid" style="height: inherit" alt='<%# Eval("Nome") %>' />
                            </div>
                            <div class="card-body">
                                <h5 class="card-title"><%# Eval("Nome") %></h5>
                                <p class="card-text"><%# Eval("Descrizione") %></p>
                                <p class="card-text">$<%# Eval("Prezzo") %></p>
                                <a href='<%# "Dettaglio.aspx?id=" + Eval("IdProdotto") %>' class="btn btn-primary">Dettagli</a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
