using DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class inscritos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        inscricaoTableAdapter inscricaoAdapter = new inscricaoTableAdapter();
        txtInscritos.Text = inscricaoAdapter.Count().ToString();
        paisTableAdapter paisAdapter = new paisTableAdapter();
        estadoTableAdapter estadoAdapter = new estadoTableAdapter();
        cidadeTableAdapter cidadeAdapter = new cidadeTableAdapter();


        DataSet.inscricaoDataTable dt = inscricaoAdapter.GetData();
        //Building an HTML string.
        StringBuilder html = new StringBuilder();
        //Table start.
        html.Append("<table class='mdl-data-table mdl-js-data-table mdl-shadow--2dp'>");
        //Building the Header row.
        html.Append("<tr>"+
            "<th class='mdl-data-table__cell--non-numeric'> Nome</th>" +
            "<th class='mdl-data-table__cell--non-numeric'>cpf </th>"+
            "<th class='mdl-data-table__cell--non-numeric'>passaporte </th>"+
            "<th class='mdl-data-table__cell--non-numeric'>email </th>"+
            "<th class='mdl-data-table__cell--non-numeric'>telefone </th>"+
            "<th class='mdl-data-table__cell--non-numeric'>celular </th>"+
            "<th class='mdl-data-table__cell--non-numeric'>sexo </th>" +
            "<th class='mdl-data-table__cell--non-numeric'>rua </th>"+
             "<th class='mdl-data-table__cell--non-numeric'>numero </th>"+
             "<th class='mdl-data-table__cell--non-numeric'>bairro </th>"+
             "<th class='mdl-data-table__cell--non-numeric'>cidade </th>"+
             "<th class='mdl-data-table__cell--non-numeric'>estado </th>"+
             "<th class='mdl-data-table__cell--non-numeric'>pais </th>"+
            "</tr>");

        //Building the Data rows.
        foreach (DataSet.inscricaoRow inscricao in dt)
        {
            if (inscricao.pais == 1)
            {

                html.Append("<tr>");
                html.Append("<td class='mdl-data-table__cell--non-numeric'>" + inscricao.nome + " </td>");
                html.Append("<td >" + inscricao.cpf + "</td>");
                html.Append("<td> </td>");
                html.Append("<td class='mdl-data-table__cell--non-numeric'>" + inscricao.email + "</td>");
                html.Append("<td >" + inscricao.telefone + " </td>");
                html.Append("<td >" + inscricao.celular + " </td>");
                html.Append("<td class='mdl-data-table__cell--non-numeric'>" + inscricao.sexo + "</td>");
                html.Append("<td class='mdl-data-table__cell--non-numeric'>" + inscricao.rua + "</td>");
                html.Append("<td >" + inscricao.numero + "</td>");
                html.Append("<td class='mdl-data-table__cell--non-numeric'>" + inscricao.bairro + "</td>");
                html.Append("<td class='mdl-data-table__cell--non-numeric'>" + cidadeAdapter.GetNomeById(inscricao.cidade).ToString() + "</td>");
                html.Append("<td class='mdl-data-table__cell--non-numeric'>" + estadoAdapter.GetNomeById(inscricao.estado).ToString() + "</td>");
                html.Append("<td class='mdl-data-table__cell--non-numeric'>" + paisAdapter.GetNomeById(inscricao.pais).ToString() + "</td>");
                html.Append("</tr>");
            }
            else
            {
                html.Append("<tr>");
                html.Append("<td class='mdl-data-table__cell--non-numeric'>" + inscricao.nome + " </td>");
                html.Append("<td> </td>");
                html.Append("<td class='mdl-data-table__cell--non-numeric'>" + inscricao.passaporte + "</td>");
                html.Append("<td class='mdl-data-table__cell--non-numeric'>" + inscricao.email + "</td>");
                html.Append("<td class='mdl-data-table__cell--non-numeric'>" + inscricao.telefone + " </td>");
                html.Append("<td class='mdl-data-table__cell--non-numeric'>" + inscricao.celular + " </td>");
                html.Append("<td class='mdl-data-table__cell--non-numeric'>" + inscricao.sexo + "</td>");
                html.Append("<td> </td>");
                html.Append("<td> </td>");
                html.Append("<td> </td>");
                html.Append("<td> </td>");
                html.Append("<td> </td>");
                html.Append("<td class='mdl-data-table__cell--non-numeric'>" + paisAdapter.GetNomeById(inscricao.pais).ToString() + "</td>");

                html.Append("</tr>");
            }
        }
        //Table end.
        html.Append("</table>");
        string strText = html.ToString();
        ////Append the HTML string to Placeholder.
        placeholder.Controls.Add(new Literal { Text = html.ToString() });
    }
}
