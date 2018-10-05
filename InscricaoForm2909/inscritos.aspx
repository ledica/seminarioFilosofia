<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="inscritos.aspx.cs" Inherits="inscritos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


        <div class="mdl-cell mdl-cell--12-col mdl-card mdl-shadow--4dp">
            <div style="margin-left: auto; margin-right: auto; text-align: center;">
                                <br /><br />
            <b>Total de Inscritos:</b>
            <asp:TextBox runat="server" ID="txtInscritos"></asp:TextBox><br /><br />
                <asp:PlaceHolder ID="placeholder" runat="server" />

            </div>
        </div>

</asp:Content>

