<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Inscricao.aspx.cs" Inherits="Inscricao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="mdl-grid portfolio-max-width portfolio-contact">

        <div class="mdl-cell mdl-cell--12-col mdl-card mdl-shadow--4dp">
            <div class="mdl-card__title">
                <h2 class="mdl-card__title-text">Inscreva-se</h2>
            </div>
            <div class="mdl-card__supporting-text">

            <asp:Label runat="server" ID="lblSeminario" Text=""></asp:Label>

            <br />
            <b>Nome:</b>
            <asp:TextBox runat="server" ID="txtNome"></asp:TextBox><br />

            <b>Telefone:</b>
            <asp:TextBox runat="server" ID="txtTelefone"></asp:TextBox><br />
            <b>Celular:</b>
            <asp:TextBox runat="server" ID="txtCelular"></asp:TextBox><br />

            <b>E-mail:</b>
            <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox><br />
            <b>Sexo:</b>
            <asp:DropDownList runat="server" ID="dropSexo">
                <asp:ListItem Value="-"></asp:ListItem>
                <asp:ListItem Value="F">Feminino</asp:ListItem>
                <asp:ListItem Value="M">Masculino</asp:ListItem>
            </asp:DropDownList><br />
            <b>Nacionalidade:</b>
            <asp:DropDownList runat="server" ID="dropNacionalidade" OnSelectedIndexChanged="selecionaNacionalidade" AutoPostBack="true">
                <asp:ListItem Value="-"></asp:ListItem>
                <asp:ListItem Value="01">Brasileiro</asp:ListItem>
                <asp:ListItem Value="02">Extrangeiro</asp:ListItem>
            </asp:DropDownList>
            <br />

            <asp:Panel ID="pnlPais" runat="server">
                <b>Pais:</b>
                <asp:DropDownList runat="server" ID="dropPais" OnSelectedIndexChanged="selecionaPais" AutoPostBack="true">
                </asp:DropDownList>
                <asp:TextBox runat="server" ID="txtPais"></asp:TextBox><br />
                <b>Passaporte:</b>
                <asp:TextBox runat="server" ID="txtPassaporte"></asp:TextBox><br />

            </asp:Panel>

            <asp:Panel ID="pnlLocal" runat="server">
                <b>CPF:</b>
                <asp:TextBox runat="server" ID="txtCPF"></asp:TextBox><br />
                <b>Estado:</b>
                <asp:DropDownList runat="server" ID="dropEstado" OnSelectedIndexChanged="selecionaEstado" AutoPostBack="true"></asp:DropDownList>

                <b>Cidade:</b>
                <asp:DropDownList runat="server" ID="dropCidade"></asp:DropDownList><br />


                <b>Rua:</b>
                <asp:TextBox runat="server" ID="txtRua"></asp:TextBox><br />
                <b>Número:</b>
                <asp:TextBox runat="server" ID="txtNumero"></asp:TextBox><br />
                <b>Bairro:</b>
                <asp:TextBox runat="server" ID="txtBairro"></asp:TextBox><br />
            </asp:Panel>

            <br />
            <asp:Button runat="server" ID="btnEnvio" CssClass="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent" Text="Enviar" OnClick="btnEnvioClick" />
            <asp:Label runat="server" ID="lblCadastro" Text=""></asp:Label>
                 </div>

        </div>
    </div>
</asp:Content>

