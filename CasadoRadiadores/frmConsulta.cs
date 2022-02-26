/*
 * DESENVOLVIDO POR MURILO DE CARVALHO BALEEIRO
 * CONTATO (014) 99153-6847
 * E-MAIL: MURILO.BALEEIRO@HOTMAIL.COM
 * LINKEDIN.COM/IN/MURILO-BALEEIRO
 * DESENVOLVIDO EM OUT/NOV DE 2021 - PROMISSAO - SP
 */
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;
using System.Threading;

namespace CasadoRadiadores
{
	/// <summary>
	/// Description of frmConsulta.
	/// </summary>
	public partial class frmConsulta : Form
	{
		public frmConsulta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
        private void manipulaCamposConsulta(bool status)
        {
			lvwResultados.Enabled = status;
			txtJuros.Enabled = status;
			lblValorVista.Enabled = status;
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'casadoradiadores_dbDataSet.tb_cadastro'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_cadastroTableAdapter.Fill(this.casadoradiadores_dbDataSet.tb_cadastro);

			manipulaCamposConsulta(false);
			cbQuantidadeParcelas.Enabled = false;

			lblParcela.Text = "";
			lblTotalPrazo.Text = "";
			lblValorVista.Text = "";

			lvwResultados.View = View.Details;
			lvwResultados.LabelEdit = true;
			lvwResultados.AllowColumnReorder = true;
			lvwResultados.FullRowSelect = true;
			lvwResultados.GridLines = false;
			lvwResultados.Columns.Add("Código", 100, HorizontalAlignment.Left);
			lvwResultados.Columns.Add("Item", 200, HorizontalAlignment.Left);
			lvwResultados.Columns.Add("Preço", 100, HorizontalAlignment.Left);
			lvwResultados.Columns.Add("Preço Pago", 100, HorizontalAlignment.Left);
			lvwResultados.Columns.Add("Quantidade", 100, HorizontalAlignment.Left);
			lvwResultados.Columns.Add("Recondicionado", 190, HorizontalAlignment.Left);
		}

		public string filtro = "";
		private void cbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
		{
            switch (cbFiltrar.Text)
            {
				case "Código":
					filtro = "codigo";
					break;

				case "Item":
					filtro = "item";
					break;

				default:
					MessageBox.Show("Contate o Administrador do Sistema!", "Fora de operação");
					break;
			}
        }

		//REALIZA BUSCA COM FILTRO AO CLICAR NO BOTAO
		private void btnConsultar_Click(object sender, EventArgs e)
        {
			MySqlConnection conexaoMain = new MySqlConnection("server=localhost;user id=root;password=P08S11PDC#;database=casadoradiadores_db");

			try
			{
				if (txtValorBuscaFiltrada.Text.Length > 0 && cbFiltrar.Text.Length > 0)
				{
					lvwResultados.Items.Clear();
					manipulaCamposConsulta(true);

					conexaoMain.Open();
					MySqlCommand cmd = conexaoMain.CreateCommand();

					cmd.CommandText = "SELECT * FROM tb_cadastro WHERE " + filtro + " LIKE @valorFiltro";
					cmd.Parameters.Clear();
					cmd.Parameters.AddWithValue("@valorFiltro", "%" + txtValorBuscaFiltrada.Text + "%");

					MySqlDataReader dataReader = cmd.ExecuteReader();

					ListViewItem item;

					while (dataReader.Read())
					{
						item = new ListViewItem();
						item.Text = dataReader.GetValue(1).ToString();
						item.SubItems.Add(dataReader.GetValue(2).ToString());
						item.SubItems.Add("R$ " + ((dataReader.GetDecimal(4) / 100).ToString()));
						item.SubItems.Add("R$ " + ((dataReader.GetDecimal(7) / 100).ToString()));
						item.SubItems.Add(dataReader.GetValue(5).ToString());
						string recondicionado = (dataReader.GetBoolean(6).ToString());

						if (recondicionado == "True")
						{
							recondicionado = "Sim";
						}
						else
						{
							recondicionado = "Não";
						}

						item.SubItems.Add(recondicionado);
						lvwResultados.Items.Add(item);
					}
					dataReader.Close();
				}
				else
				{
					if (cbFiltrar.Text.Length < 1)
					{
						MessageBox.Show("Informe um critério para consulta!", "Valor Ausente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

					}
					if (txtValorBuscaFiltrada.Text.Length < 1)
					{
						MessageBox.Show("Informe um valor-chave para consulta!", "Critério Ausente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}

			catch (Exception erro)
			{
				//MessageBox.Show("Informe um código!");
				MessageBox.Show("Erro ao consultar a base de dados: " + erro);
			}

			finally
			{
				conexaoMain.Close();
			}
		}
        private void btnConsultaFull_Click(object sender, EventArgs e)
        {
			DialogResult consultaCompleta = MessageBox.Show("Deseja mesmo consultar toda a base de dados? \nIsso pode demorar um pouco... "
				, "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if(consultaCompleta.ToString().ToUpper() == "YES")
            {
				MySqlConnection conexaoMain = new MySqlConnection("server=localhost;user id=root;password=P08S11PDC#;database=casadoradiadores_db");

				try
				{
					lvwResultados.Items.Clear();
					manipulaCamposConsulta(true);

					conexaoMain.Open();
					MySqlCommand cmd = conexaoMain.CreateCommand();
					cmd.CommandText = "SELECT * FROM tb_cadastro";

					MySqlDataReader dataReader = cmd.ExecuteReader();

					ListViewItem item;

					while (dataReader.Read())
					{
						item = new ListViewItem();
						item.Text = dataReader.GetValue(1).ToString();
						item.SubItems.Add(dataReader.GetValue(2).ToString());
						item.SubItems.Add("R$ " + ((dataReader.GetDecimal(4) / 100).ToString()));
						item.SubItems.Add("R$ " + ((dataReader.GetDecimal(7) / 100).ToString()));
						item.SubItems.Add(dataReader.GetValue(5).ToString());
						string recondicionado = (dataReader.GetBoolean(6).ToString());

						if (recondicionado == "True")
						{
							recondicionado = "Sim";
						}
						else
						{
							recondicionado = "Não";
						}

						item.SubItems.Add(recondicionado);
						lvwResultados.Items.Add(item);
					}
					dataReader.Close();
				}

				catch (Exception erro)
                {
					MessageBox.Show("Erro ao consultar a base de dados: " + erro);
                }

				finally
				{
					conexaoMain.Close();
				}
			}
        }

		private void Financeiro()
        {
			//DECLARAÇÃO DAS VARIÁVEIS;

			//armazena o item clicado 2x em uma string;
			string precoVistaMonetario = lvwResultados.SelectedItems[0].SubItems[2].Text;

			if(precoVistaMonetario != "")
            {
				cbQuantidadeParcelas.Enabled = true;
            } else
            {
				cbQuantidadeParcelas.Enabled = false;
            }

			lblValorVista.Text = "VALOR À VISTA:" + "\n" + precoVistaMonetario;
			lblValorVista.BackColor = Color.LightGreen;
			lblValorVista.Font = new Font(lblValorVista.Font, FontStyle.Bold);

			//remove o simbolo monetário (R$_) e armazena o valor em uma nova string;
			string precoVista = precoVistaMonetario.Remove(0, 3);

			//armazena o valor do ttxJuros em uma string;
			string jurosPorcentagem = txtJuros.Text;


			//armazena o valor da comboBox de parcelas em uma string;
			string quantidadeParcelas = cbQuantidadeParcelas.Text;
			string parcelas = "";

			//remove o caractere X p/ trabalhar como valor;
			if (quantidadeParcelas.Length > 2)
			{
				//Se o valor for maior que 9x (Ex.: 10x, 11x, 12x...) remove o X a partir do indice 2;
				parcelas = quantidadeParcelas.Remove(2, 1);
			}
			else
			{
				//Se o valor for menor que 10x (Ex.: 9x, 8x, 7x...) remove o X a partir do indice 1;
				parcelas = quantidadeParcelas.Remove(1, 1);
			}

			//converte as string formatadas para variaveis double para poderem ser manipuladas por calculos financeiros;
			double PrecoVista = Convert.ToDouble(precoVista);
			double Juros = Convert.ToDouble(jurosPorcentagem);
			int Parcelas = Convert.ToInt32(parcelas);

			double PrecoPrazo;
			double ParcelaPrazo;

			//Calcula o valor total a prazo e considera 2 casas decimais após a virgula (_,00);
			PrecoPrazo = PrecoVista + (PrecoVista * (Juros / 100));
			PrecoPrazo = Math.Round(PrecoPrazo, 2);

			ParcelaPrazo = PrecoPrazo / Parcelas;
			ParcelaPrazo = Math.Round(ParcelaPrazo, 2);

			//Exibe o valore formatado nas label
			var valorPrazoFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:###.###.###,##}", PrecoPrazo);
			lblTotalPrazo.Text = "VALOR A PRAZO:" + "\n" + valorPrazoFormatado;
			lblTotalPrazo.BackColor = Color.Yellow;
			lblTotalPrazo.Font = new Font(lblTotalPrazo.Font, FontStyle.Bold);

			//Exibe o valore formatado nas label
			var valorParcelaFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:###.###.###,##}", ParcelaPrazo);
			lblParcela.Text = "VALOR DA PARCELA: " + "\n" + valorParcelaFormatado;
			lblParcela.BackColor = Color.IndianRed;
			lblParcela.ForeColor = Color.White;
			lblParcela.Font = new Font(lblParcela.Font, FontStyle.Bold);
		}
        private void lvwResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
			//NULL
		}
        private void lvwResultados_DoubleClick(object sender, EventArgs e)
        {
			Financeiro();
		}

        private void cbQuantidadeParcelas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
			Financeiro();
		}
		private void txtValorBuscaFiltrada_Enter(object sender, EventArgs e)
		{
		}

        private void txtJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
			{
				e.Handled = true;
			}
		}
    }
}
