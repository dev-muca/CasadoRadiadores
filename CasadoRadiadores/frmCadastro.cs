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


namespace CasadoRadiadores
{
	/// <summary>
	/// Description of frmCadastro.
	/// </summary>
	public partial class frmCadastro : Form
	{
		public frmCadastro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//CARREGAR FORMULÁRIO
		void FrmCadastroLoad(object sender, EventArgs e)
		{
			//DESABILITA OS BOTOES DE CADASTRO E SALVAR ALTERAÇÕES
			btnCadastrar.Enabled = false;
			btnSalvarAlteracoes.Enabled = false;

			//DEBUG TO DEV
			btnTestarCampos.Visible = false;
			btnTestarCampos.Enabled = false;

			//DESABILITA OS CAMPOS QUANTIDADE NO FORM DE ALTERAÇÕES
			manipulaCamposAlteracao(false);
			
			chkRecondicionadoCadastro.Checked = false;
			chkRecondicionadoAlterar.Enabled = false;
			
			txtCodigoCadastro.Clear();
			txtItemCadastro.Clear();
			txtDescricaoCadastro.Clear();
			txtPrecoCadastro.Clear();
			txtQuantidadeCadastro.Clear();
			txtPrecoPagoAlterar.Clear();
		}
		
		//CANCELAR CADASTRO E FECHAR
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//CANCELA ALTERAÇÕES E FECHA
		void BtnCancelarAlteracaoClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//CAMPO CÓDIGO ITEM CADASTRO
		void TxtCodigoCadastroTextChanged(object sender, EventArgs e)
		{
			btnCadastrar.Enabled = true;
		}
		
		//CAMPO CÓDIGO ITEM ALTERAR
		void TxtCodigoAlterarTextChanged(object sender, EventArgs e)
		{
			btnSalvarAlteracoes.Enabled = true;
		}
		
		//PERMITE SOMENTE NUMEROS NO CAMPO PREÇO
		void TxtPrecoCadastroKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46){
				e.Handled = true;
			}
		}
		
		//PERMITE SOMENTE NUMEROS NO CAMPO QUANTIDADE
		void TxtQuantidadeCadastroKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8){
				e.Handled = true;
			}
		}

		//PERMITE SOMENTE NUMEROS NO CAMPO PREÇO PAGO
		private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
			{
				e.Handled = true;
			}
		}

		//CADASTRAR O ITEM INFORMADO
		void BtnCadastrarClick(object sender, EventArgs e)
		{
			if (txtCodigoCadastro.Text.Length > 0 && txtPrecoCadastro.Text.Length > 0 && txtQuantidadeCadastro.Text.Length > 0)
			{
				//Declaração das Variaveis
				int codigo = Convert.ToInt32(txtCodigoCadastro.Text);
				String item = txtItemCadastro.Text;
				String descricao = txtDescricaoCadastro.Text;
				double preco = Convert.ToDouble(txtPrecoCadastro.Text) * 100;
				double precopago = Convert.ToDouble(txtPrecoPagoCadastro.Text) * 100;
				int quantidade = Convert.ToInt32(txtQuantidadeCadastro.Text);
				int recondicionado;

				//Declara se o item é recondicionado ou nao ao marcar o checkbox
				if (chkRecondicionadoCadastro.Checked == true)
				{
					recondicionado = 1;
				}
				else
				{
					recondicionado = 0;
				}

				//CONEXÃO GLOBAL AO BANCO MYSQL
				MySqlConnection conexaoMain = new MySqlConnection("server=localhost; user id=root;password=P08S11PDC#;database=casadoradiadores_db");
				MySqlCommand objCmdMain = new MySqlCommand();
				objCmdMain.Connection = conexaoMain;

				try
				{
					conexaoMain.Open();
					//VERIFIÇÃO DO CÓDIGO INFORMADO PARA NÃO HAVER ITEMS COM OS MESMOS CÓDIGOS
					MySqlCommand objComandoCodigo = new MySqlCommand("SELECT codigo FROM tb_cadastro WHERE codigo = ?");
					objComandoCodigo.Connection = conexaoMain;
					objComandoCodigo.Parameters.Clear();
					objComandoCodigo.Parameters.Add("@codigo", MySqlDbType.Int32).Value = txtCodigoCadastro.Text;
					objComandoCodigo.CommandType = System.Data.CommandType.Text;
					MySqlDataReader retornaCodigo;
					retornaCodigo = objComandoCodigo.ExecuteReader();
					retornaCodigo.Read();
					string codigoConsulta = retornaCodigo.GetString(0);
					conexaoMain.Close();	

					if (codigoConsulta == txtCodigoCadastro.Text)
					{
						MessageBox.Show("Este código já esta cadastrado!", "Divergência de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					
				}

				catch (Exception)
				{
					try
					{
						conexaoMain.Close();
						//REALIZA O CADASTRO DO ITEM  
						if (txtItemCadastro.Text.Length > 0 || txtDescricaoCadastro.Text.Length > 0)
						{
							conexaoMain.Open();

							objCmdMain.CommandType = System.Data.CommandType.Text;
							objCmdMain.CommandText = "INSERT INTO tb_cadastro (codigo, item, descricao, preco, quantidade, recondicionado, precopago) VALUES ('" + codigo + "','" + item + "','" + descricao + "','" + preco + "','" + quantidade + "','" + recondicionado + "','" + precopago + "')"; 
							objCmdMain.ExecuteNonQuery();

							DialogResult cadastroSucesso = MessageBox.Show("Item Cadastrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
							if (cadastroSucesso.ToString().ToUpper() == "OK")
							{
								limparCamposCadastro();
							}
						}
						else
						{
							DialogResult cadastroSemDesc = MessageBox.Show("Os campos Item e Descrição estão vazios, deseja mesmo cadastrar este item?", "Informações Ausentes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
							if (cadastroSemDesc.ToString().ToUpper() == "YES")
							{
								objCmdMain.CommandType = System.Data.CommandType.Text;
								objCmdMain.CommandText = "INSERT INTO tb_cadastro (codigo, item, descricao, preco, quantidade, recondicionado, precopago) VALUES ('" + codigo + "','" + item + "','" + descricao + "','" + preco + "','" + quantidade + "','" + recondicionado + "','" + precopago + "')";
								objCmdMain.ExecuteNonQuery();

								DialogResult cadastroSucesso = MessageBox.Show("Item Cadastrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
								if (cadastroSucesso.ToString().ToUpper() == "OK")
								{
									limparCamposCadastro();
								}
							}
						}
						conexaoMain.Close();
					}
					catch (Exception erro)
					{
						MessageBox.Show("Erro ao tentar realizar a operação: " + erro);
					}
				}
			}
			else
			{
				MessageBox.Show("Faltam informações importantes!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		//PROCURAR CADASTRO NO BANCO ATRAVÉS DO CÓDIGO
		void BtnProcurarCadastroClick(object sender, EventArgs e)
		{
			try {
				//CONEXÃO GLOBAL
				if(txtCodigoAlterar.Text.Length > 0){
					MySqlConnection conexaoMain = new MySqlConnection("server=localhost; user id=root;password=P08S11PDC#;database=casadoradiadores_db");
					conexaoMain.Open();
					
					MySqlCommand objCmdMain = new MySqlCommand("SELECT codigo, item, descricao, preco, quantidade, recondicionado, precopago FROM tb_cadastro WHERE codigo = ?");
					objCmdMain.Connection = conexaoMain;
					
					objCmdMain.Parameters.Clear();
					objCmdMain.Parameters.Add("@codigo", MySqlDbType.Int32).Value = txtCodigoAlterar.Text;
					
					objCmdMain.CommandType = System.Data.CommandType.Text;
					
					MySqlDataReader returnConsulta;
					returnConsulta = objCmdMain.ExecuteReader();
					returnConsulta.Read();

					txtItemAlterar.Text = returnConsulta.GetString(1);
					txtDescricaoAlterar.Text = returnConsulta.GetString(2);
					double preco = Convert.ToDouble(returnConsulta.GetString(3)) / 100;
					txtPrecoAlterar.Text = preco.ToString();
					txtQuantidadeAlterar.Text = returnConsulta.GetString(4);
					string recondicionado = returnConsulta.GetString(5);
					double precopago = Convert.ToDouble(returnConsulta.GetString(6)) / 100;
					txtPrecoPagoAlterar.Text = precopago.ToString();
					
					if(recondicionado == "True"){
						chkRecondicionadoAlterar.Enabled = true;
						chkRecondicionadoAlterar.Checked = true;
					} else {
						chkRecondicionadoAlterar.Enabled = true;
						chkRecondicionadoAlterar.Checked = false;
					}
					
					manipulaCamposAlteracao(true);
					
					conexaoMain.Close();
				} else {
					MessageBox.Show("Forneça uma código válido!", "Código Ausente");
				}
			}
			
			catch(Exception){
				MessageBox.Show("Erro ao efetuar consulta, código não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		//SALVA AS ALTERAÇÕES DE UM REGISTRO NO BANCO APOS PESQUISADO PELO CODIGO
		void BtnSalvarAlteracoesClick(object sender, EventArgs e)
		{	
			try{
				//DECLARAÇÃO DAS VÁRIAVEIS A SEREM UTILIZADAS
				int codigo = Convert.ToInt32(txtCodigoAlterar.Text);
				String item = txtItemAlterar.Text;
				String descricao = txtDescricaoAlterar.Text;
				double preco = Convert.ToDouble(txtPrecoAlterar.Text) * 100;
				double precopago = Convert.ToDouble(txtPrecoPagoAlterar.Text) * 100;
				int quantidade = Convert.ToInt32(txtQuantidadeAlterar.Text);
				int recondicionado;
				//CONVERTE O CHECKED DO CHKBOX PARA BOOL DO MYSQL (0, 1);
				if(chkRecondicionadoAlterar.Checked == true){
					recondicionado = 1;
				} else {
					recondicionado = 0;
				}
				//CONECTA AO BANCO DE DADOS
				MySqlConnection conexaoMain = new MySqlConnection("server=localhost; user id=root;password=P08S11PDC#;database=casadoradiadores_db");
				conexaoMain.Open();
				MySqlCommand objCmdMain = new MySqlCommand();
				objCmdMain.Connection = conexaoMain;
				objCmdMain.Parameters.Clear();
				objCmdMain.Parameters.Add("@codigo", MySqlDbType.String).Value = codigo;
				objCmdMain.Parameters.Add("@item", MySqlDbType.String).Value = item;
				objCmdMain.Parameters.Add("@descricao", MySqlDbType.String).Value = descricao;
				objCmdMain.Parameters.Add("@preco", MySqlDbType.String).Value = preco;
				objCmdMain.Parameters.Add("@quantidade", MySqlDbType.String).Value = quantidade;
				objCmdMain.Parameters.Add("@recondicionado", MySqlDbType.String).Value = recondicionado;
				objCmdMain.Parameters.Add("@precopago", MySqlDbType.String).Value = precopago;
				objCmdMain.CommandType = System.Data.CommandType.Text;
				objCmdMain.CommandText = "UPDATE tb_cadastro SET item = @item, descricao = @descricao, preco = @preco, quantidade = @quantidade, recondicionado = @recondicionado, precopago = @precopago WHERE codigo = @codigo";
				objCmdMain.ExecuteNonQuery();
				MessageBox.Show("Alterações salvas com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
				limparCamposAlteracao();
				conexaoMain.Close();
			}
			catch(Exception erro){
				MessageBox.Show("Erro:" + erro);
			}
		}

		//DELETAR REGISTRO SELECIONADO
		private void btnDeletar_Click(object sender, EventArgs e)
		{
			if (txtCodigoAlterar.Text.Length < 1)
			{
				MessageBox.Show("Informe um código válido!", "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				DialogResult confirmaDelete = MessageBox.Show("Deseja realmente deletar este registro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
				if (confirmaDelete.ToString().ToUpper() == "OK")
				{
					try
					{
						//DECLARAÇÃO DAS VÁRIAVEIS A SEREM UTILIZADAS
						int codigo = Convert.ToInt32(txtCodigoAlterar.Text);

						//CONECTA AO BANCO DE DADOS
						MySqlConnection conexaoMain = new MySqlConnection("server=localhost; user id=root;password=P08S11PDC#;database=casadoradiadores_db");
						conexaoMain.Open();
						MySqlCommand objCmdMain = new MySqlCommand();
						objCmdMain.Connection = conexaoMain;
						objCmdMain.Parameters.Clear();
						objCmdMain.Parameters.AddWithValue("@codigo", codigo);
						objCmdMain.CommandType = System.Data.CommandType.Text;
						objCmdMain.CommandText = "DELETE from tb_cadastro WHERE codigo = @codigo";
						objCmdMain.ExecuteNonQuery();
						MessageBox.Show("Registro deletado!", "Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information);
						limparCamposAlteracao();
						conexaoMain.Close();
					}
					catch (Exception erro)
					{
						MessageBox.Show("Erro:" + erro);
					}
				}
			}
		}

		//FUNCTION QUE MANIPULA OS CAMPOS DE ALTERACAO DO FORM DE ALTERAÇÕES
		private void manipulaCamposAlteracao(bool status){
			txtItemAlterar.Enabled = status;
			txtDescricaoAlterar.Enabled = status;
			txtPrecoAlterar.Enabled = status;
			txtPrecoPagoAlterar.Enabled = status;
			txtQuantidadeAlterar.Enabled = status;
			lblQuantidadeAlterar.Enabled = status;
			btnDeletar.Enabled = status;
		}
		
		private void limparCamposAlteracao(){
			txtCodigoAlterar.Clear();
			txtItemAlterar.Clear();
			txtDescricaoAlterar.Clear();
			txtPrecoAlterar.Clear();
			txtPrecoPagoAlterar.Clear();
			txtQuantidadeAlterar.Clear();
			chkRecondicionadoAlterar.Checked = false;
		}
		
		private void limparCamposCadastro(){
			txtCodigoCadastro.Clear();
			txtItemCadastro.Clear();
			txtDescricaoCadastro.Clear();
			txtPrecoCadastro.Clear();
			txtPrecoPagoCadastro.Clear();
			txtQuantidadeCadastro.Clear();
			chkRecondicionadoCadastro.Checked = false;
		}

        private void txtPrecoCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
