/*
 * DESENVOLVIDO POR MURILO DE CARVALHO BALEEIRO
 * CONTATO (014) 99153-6847
 * E-MAIL: MURILO.BALEEIRO@HOTMAIL.COM
 * LINKEDIN.COM/IN/MURILO-BALEEIRO
 */
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CasadoRadiadores
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//CARREGA INFO NO MAINFORM
		private void MainForm_Load(object sender, EventArgs e)
        {
			nivelMenu(3);
			btnCadastrar.Text = "CADASTRAR";
			btnConsultar.Text = "CONSULTAR";

			lblBuild.Text = "0511.2021.0712";

        }

		private void nivelMenu(int nivel)
        {
            switch (nivel) {

				case 0:
					btnCadastrar.Enabled = false;
					btnConsultar.Enabled = false;
					break;

				case 1:
					btnCadastrar.Enabled = true;
					btnConsultar.Enabled = false;
					break;

				case 2:
					btnCadastrar.Enabled = true;
					btnConsultar.Enabled = true;
					break;

				case 3:
					btnCadastrar.Enabled = true;
					btnConsultar.Enabled = true;
					break;

				default:
					MessageBox.Show("Argument Not Valid","Argument Range 0 ~ 3");
					break;
			
			}
        }

        //Abre o form de cadastros
        void BtnCadastrarClick(object sender, EventArgs e)
		{
			frmCadastro cadastro = new frmCadastro();
			cadastro.Show();
		}
		
		//Abre o form de Consulta
		void BtnConsultarClick(object sender, EventArgs e)
		{
			frmConsulta consulta = new frmConsulta();
			consulta.Show();
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{	
			
		}
        
    }
}
