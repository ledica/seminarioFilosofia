<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="mdl-grid portfolio-max-width">

        <div class="mdl-cell mdl-cell--12-col mdl-card mdl-shadow--4dp">
            <div class="mdl-card__title">
                <h2 class="mdl-card__title-text">Apresentação</h2>
            </div>
            <div class="mdl-card__media">
                <img class="article-image" src=" images/about-header.jpg" border="0" alt="" />
            </div>
            <div class="mdl-grid portfolio-copy">
                <h3 class="mdl-cell mdl-cell--12-col mdl-typography--headline">Seminário</h3>
                <div class="mdl-cell mdl-cell--8-col mdl-card__supporting-text no-padding ">
                    <p>
                        O Seminário Internacional de Filosofia para Leigos é realizado todos os anos pelo Instituto Santa Teresa com a intenção de promover e provocar o pensamento filosófico.
                    </p>
                </div>
                <h3 class="mdl-cell mdl-cell--12-col mdl-typography--headline">busca e o amor à sabedoria</h3>

                <div class="mdl-cell mdl-cell--8-col mdl-card__supporting-text no-padding ">
                    <p>
                        Acreditamos que a busca e o amor à sabedoria e à verdade são atributos que todo ser humano carrega, como dizia Aristóteles: “Todo ser humano busca naturalmente o conhecimento”.
    
                    </p>
                </div>
                <div class="mdl-cell mdl-cell--8-col mdl-card__supporting-text no-padding ">
                    Público Alvo:
    <ul>

        <li>Alunos do ensino Médio.</li>
        <li>Alunos do ensino Superior.</li>
        <li>Participantes externos.</li>
    </ul>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

