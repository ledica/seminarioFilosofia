using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataSetTableAdapters;

public partial class Inscricao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (dropNacionalidade.SelectedValue == "-")
        {
            pnlPais.Enabled = false;
            pnlPais.Visible = false;
            pnlLocal.Enabled = false;
            pnlLocal.Visible = false;
        }
        else if (dropNacionalidade.SelectedValue == "01")
        {
            pnlPais.Enabled = false;
            pnlPais.Visible = false;
            pnlLocal.Enabled = true;
            pnlLocal.Visible = true;
        }
        else {
            txtPais.Enabled = true;
            txtPais.Visible = false;
            pnlPais.Enabled = true;
            pnlPais.Visible = true;
            pnlLocal.Enabled = false;
            pnlLocal.Visible = false;
        }
    }

    protected void btnEnvioClick(object sender, EventArgs e)

    {
       
        if (dropNacionalidade.SelectedValue == "02")
        {
            int idPais=1;
            if (dropPais.SelectedValue == "Outro")
            {
                paisTableAdapter paisAdapter = new paisTableAdapter();
                int query = paisAdapter.InsertTeste(txtPais.Text);
                idPais = int.Parse(paisAdapter.GetIdbyNome(txtPais.Text).ToString());
            }
            else if (dropPais.SelectedValue == "-") {
                Response.Write("Selecione um país");
            }
            else
            {
                idPais = int.Parse(dropPais.SelectedValue);
            }
            inscricaoTableAdapter inscricaoAdapter = new inscricaoTableAdapter();
            int outputInsert = inscricaoAdapter.InsertQueryExtrangeiro(
            txtNome.Text,
            txtPassaporte.Text,
            txtEmail.Text,
            txtTelefone.Text,
            txtCelular.Text,
            dropSexo.SelectedValue,
            idPais);
        }
        else
        {
            inscricaoTableAdapter inscricaoAdapter = new inscricaoTableAdapter();
            int outputInsert = inscricaoAdapter.InsertQueryBrasileiro(
            txtNome.Text,
            txtCPF.Text,
            txtEmail.Text,
            txtTelefone.Text,
            txtCelular.Text,
            dropSexo.SelectedValue, 
            int.Parse(dropEstado.SelectedValue.ToString()),
            int.Parse(dropCidade.SelectedValue.ToString()),
            txtRua.Text,
            txtNumero.Text,
            txtBairro.Text);
        }
        Response.Redirect("/inscritos.aspx");



    }

    protected void selecionaNacionalidade(object sender, EventArgs e)
    {
        if (dropNacionalidade.SelectedValue == "01")
        {
            //pnlLocal.Enabled = true;
            //pnlLocal.Visible = true;
            pnlPais.Enabled = true;
            


            estadoTableAdapter estadoAdapter = new estadoTableAdapter();
            DataSet.estadoDataTable DT = estadoAdapter.GetData();
            dropEstado.Items.Clear();
            dropEstado.Items.Add("-");
            foreach (DataSet.estadoRow estado  in DT)
            {
                dropEstado.Items.Add(new ListItem(estado.nome, estado.id.ToString()));
            }
        }
        else if(dropNacionalidade.SelectedValue=="02")
        {
            paisTableAdapter paisAdapter = new paisTableAdapter();
            DataSet.paisDataTable DT = paisAdapter.GetData();
            dropPais.Items.Clear();
            dropPais.Items.Add("-");
            foreach (DataSet.paisRow pais in DT)
            {
                dropPais.Items.Add(new ListItem(pais.nome, pais.id.ToString()));
            }
            dropPais.Items.Add("Outro");
            pnlPais.Enabled = true;
            pnlPais.Visible = true;
        }
        

    }

    protected void selecionaEstado(object sender, EventArgs e)
    {
        cidadeTableAdapter cidadeAdapter = new cidadeTableAdapter();
        DataSet.cidadeDataTable DT = cidadeAdapter.GetDataByIdEstado(int.Parse(dropEstado.SelectedValue));
        dropCidade.Items.Clear();
        dropCidade.Items.Add("-");
        foreach (DataSet.cidadeRow cidade in DT)
        {
            dropCidade.Items.Add(new ListItem(cidade.nome,  cidade.id.ToString()));
        }
    }

    protected void selecionaPais(object sender, EventArgs e)
    {
        if (dropPais.SelectedValue == "Outro") {
            txtPais.Enabled = true;
            txtPais.Visible = true;
        }
    }

}