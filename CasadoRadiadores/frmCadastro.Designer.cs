/*
 * Created by SharpDevelop.
 * User: Muca
 * Date: 29/10/2021
 * Time: 00:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CasadoRadiadores
{
	partial class frmCadastro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.CheckBox chkRecondicionadoCadastro;
		private System.Windows.Forms.TextBox txtDescricaoCadastro;
		private System.Windows.Forms.TextBox txtItemCadastro;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCodigoCadastro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox txtPrecoCadastro;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCodigoAlterar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtQuantidadeCadastro;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtPrecoAlterar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDescricaoAlterar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtItemAlterar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox chkRecondicionadoAlterar;
		private System.Windows.Forms.TextBox txtQuantidadeAlterar;
		private System.Windows.Forms.Label lblQuantidadeAlterar;
		private System.Windows.Forms.Button btnCancelarAlteracao;
		private System.Windows.Forms.Button btnSalvarAlteracoes;
		private System.Windows.Forms.Button btnTestarCampos;
		private System.Windows.Forms.Button btnProcurarCadastro;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPrecoPagoCadastro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTestarCampos = new System.Windows.Forms.Button();
            this.txtQuantidadeCadastro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecoCadastro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricaoCadastro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemCadastro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkRecondicionadoCadastro = new System.Windows.Forms.CheckBox();
            this.txtCodigoCadastro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPrecoPagoAlterar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuantidadeAlterar = new System.Windows.Forms.TextBox();
            this.lblQuantidadeAlterar = new System.Windows.Forms.Label();
            this.txtPrecoAlterar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricaoAlterar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemAlterar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkRecondicionadoAlterar = new System.Windows.Forms.CheckBox();
            this.txtCodigoAlterar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnProcurarCadastro = new System.Windows.Forms.Button();
            this.btnCancelarAlteracao = new System.Windows.Forms.Button();
            this.btnSalvarAlteracoes = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtPrecoPagoCadastro);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnTestarCampos);
            this.tabPage1.Controls.Add(this.txtQuantidadeCadastro);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtPrecoCadastro);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtDescricaoCadastro);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtItemCadastro);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnCadastrar);
            this.tabPage1.Controls.Add(this.chkRecondicionadoCadastro);
            this.tabPage1.Controls.Add(this.txtCodigoCadastro);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CADASTRAR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtPrecoPagoCadastro
            // 
            this.txtPrecoPagoCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecoPagoCadastro.Location = new System.Drawing.Point(100, 388);
            this.txtPrecoPagoCadastro.Name = "txtPrecoPagoCadastro";
            this.txtPrecoPagoCadastro.Size = new System.Drawing.Size(365, 23);
            this.txtPrecoPagoCadastro.TabIndex = 6;
            this.txtPrecoPagoCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(7, 383);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(463, 33);
            this.label10.TabIndex = 18;
            this.label10.Text = "VALOR PAGO:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTestarCampos
            // 
            this.btnTestarCampos.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestarCampos.Location = new System.Drawing.Point(10, 511);
            this.btnTestarCampos.Name = "btnTestarCampos";
            this.btnTestarCampos.Size = new System.Drawing.Size(37, 19);
            this.btnTestarCampos.TabIndex = 99;
            this.btnTestarCampos.Text = "test";
            this.btnTestarCampos.UseVisualStyleBackColor = true;
            // 
            // txtQuantidadeCadastro
            // 
            this.txtQuantidadeCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidadeCadastro.Location = new System.Drawing.Point(312, 348);
            this.txtQuantidadeCadastro.Name = "txtQuantidadeCadastro";
            this.txtQuantidadeCadastro.Size = new System.Drawing.Size(153, 23);
            this.txtQuantidadeCadastro.TabIndex = 5;
            this.txtQuantidadeCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantidadeCadastroKeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(213, 343);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(257, 33);
            this.label9.TabIndex = 15;
            this.label9.Text = "QUANTIDADE:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrecoCadastro
            // 
            this.txtPrecoCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPrecoCadastro.Location = new System.Drawing.Point(63, 348);
            this.txtPrecoCadastro.Name = "txtPrecoCadastro";
            this.txtPrecoCadastro.Size = new System.Drawing.Size(139, 23);
            this.txtPrecoCadastro.TabIndex = 4;
            this.txtPrecoCadastro.TextChanged += new System.EventHandler(this.txtPrecoCadastro_TextChanged);
            this.txtPrecoCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecoCadastroKeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(7, 343);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(200, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "PREÇO:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescricaoCadastro
            // 
            this.txtDescricaoCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoCadastro.Location = new System.Drawing.Point(15, 86);
            this.txtDescricaoCadastro.Multiline = true;
            this.txtDescricaoCadastro.Name = "txtDescricaoCadastro";
            this.txtDescricaoCadastro.Size = new System.Drawing.Size(735, 241);
            this.txtDescricaoCadastro.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(748, 283);
            this.label3.TabIndex = 11;
            this.label3.Text = "DESCRIÇÃO:";
            // 
            // txtItemCadastro
            // 
            this.txtItemCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemCadastro.Location = new System.Drawing.Point(261, 17);
            this.txtItemCadastro.Name = "txtItemCadastro";
            this.txtItemCadastro.Size = new System.Drawing.Size(489, 23);
            this.txtItemCadastro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(213, 12);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(542, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "ITEM:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkRecondicionadoCadastro
            // 
            this.chkRecondicionadoCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRecondicionadoCadastro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkRecondicionadoCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRecondicionadoCadastro.Location = new System.Drawing.Point(476, 343);
            this.chkRecondicionadoCadastro.Name = "chkRecondicionadoCadastro";
            this.chkRecondicionadoCadastro.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.chkRecondicionadoCadastro.Size = new System.Drawing.Size(279, 73);
            this.chkRecondicionadoCadastro.TabIndex = 7;
            this.chkRecondicionadoCadastro.Text = "RECONDICIONADO";
            this.chkRecondicionadoCadastro.UseVisualStyleBackColor = false;
            // 
            // txtCodigoCadastro
            // 
            this.txtCodigoCadastro.Location = new System.Drawing.Point(74, 17);
            this.txtCodigoCadastro.Name = "txtCodigoCadastro";
            this.txtCodigoCadastro.Size = new System.Drawing.Size(127, 23);
            this.txtCodigoCadastro.TabIndex = 1;
            this.txtCodigoCadastro.TextChanged += new System.EventHandler(this.TxtCodigoCadastroTextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(200, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeletar);
            this.tabPage2.Controls.Add(this.txtPrecoPagoAlterar);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnProcurarCadastro);
            this.tabPage2.Controls.Add(this.btnCancelarAlteracao);
            this.tabPage2.Controls.Add(this.btnSalvarAlteracoes);
            this.tabPage2.Controls.Add(this.txtQuantidadeAlterar);
            this.tabPage2.Controls.Add(this.lblQuantidadeAlterar);
            this.tabPage2.Controls.Add(this.txtPrecoAlterar);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtDescricaoAlterar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtItemAlterar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.chkRecondicionadoAlterar);
            this.tabPage2.Controls.Add(this.txtCodigoAlterar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ALTERAR";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtPrecoPagoAlterar
            // 
            this.txtPrecoPagoAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPrecoPagoAlterar.Location = new System.Drawing.Point(386, 382);
            this.txtPrecoPagoAlterar.Name = "txtPrecoPagoAlterar";
            this.txtPrecoPagoAlterar.Size = new System.Drawing.Size(365, 23);
            this.txtPrecoPagoAlterar.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(293, 377);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label12.Size = new System.Drawing.Size(463, 33);
            this.label12.TabIndex = 24;
            this.label12.Text = "VALOR PAGO:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuantidadeAlterar
            // 
            this.txtQuantidadeAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidadeAlterar.Location = new System.Drawing.Point(667, 17);
            this.txtQuantidadeAlterar.Name = "txtQuantidadeAlterar";
            this.txtQuantidadeAlterar.Size = new System.Drawing.Size(80, 23);
            this.txtQuantidadeAlterar.TabIndex = 3;
            this.txtQuantidadeAlterar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantidadeAlterar
            // 
            this.lblQuantidadeAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantidadeAlterar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblQuantidadeAlterar.Location = new System.Drawing.Point(568, 12);
            this.lblQuantidadeAlterar.Name = "lblQuantidadeAlterar";
            this.lblQuantidadeAlterar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblQuantidadeAlterar.Size = new System.Drawing.Size(184, 33);
            this.lblQuantidadeAlterar.TabIndex = 22;
            this.lblQuantidadeAlterar.Text = "QUANTIDADE:";
            this.lblQuantidadeAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrecoAlterar
            // 
            this.txtPrecoAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPrecoAlterar.Location = new System.Drawing.Point(59, 382);
            this.txtPrecoAlterar.Name = "txtPrecoAlterar";
            this.txtPrecoAlterar.Size = new System.Drawing.Size(221, 23);
            this.txtPrecoAlterar.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(8, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 33);
            this.label6.TabIndex = 20;
            this.label6.Text = "PREÇO:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescricaoAlterar
            // 
            this.txtDescricaoAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoAlterar.Location = new System.Drawing.Point(16, 126);
            this.txtDescricaoAlterar.Multiline = true;
            this.txtDescricaoAlterar.Name = "txtDescricaoAlterar";
            this.txtDescricaoAlterar.Size = new System.Drawing.Size(735, 233);
            this.txtDescricaoAlterar.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(8, 93);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3, 10, 0, 0);
            this.label7.Size = new System.Drawing.Size(748, 276);
            this.label7.TabIndex = 19;
            this.label7.Text = "DESCRIÇÃO:";
            // 
            // txtItemAlterar
            // 
            this.txtItemAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemAlterar.Location = new System.Drawing.Point(51, 56);
            this.txtItemAlterar.Name = "txtItemAlterar";
            this.txtItemAlterar.Size = new System.Drawing.Size(696, 23);
            this.txtItemAlterar.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(9, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(743, 33);
            this.label8.TabIndex = 18;
            this.label8.Text = "ITEM:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkRecondicionadoAlterar
            // 
            this.chkRecondicionadoAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkRecondicionadoAlterar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkRecondicionadoAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRecondicionadoAlterar.Location = new System.Drawing.Point(8, 417);
            this.chkRecondicionadoAlterar.Name = "chkRecondicionadoAlterar";
            this.chkRecondicionadoAlterar.Padding = new System.Windows.Forms.Padding(20, 3, 0, 0);
            this.chkRecondicionadoAlterar.Size = new System.Drawing.Size(279, 33);
            this.chkRecondicionadoAlterar.TabIndex = 8;
            this.chkRecondicionadoAlterar.Text = "ITEM RECONDICIONADO";
            this.chkRecondicionadoAlterar.UseVisualStyleBackColor = false;
            // 
            // txtCodigoAlterar
            // 
            this.txtCodigoAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoAlterar.Location = new System.Drawing.Point(174, 17);
            this.txtCodigoAlterar.Name = "txtCodigoAlterar";
            this.txtCodigoAlterar.Size = new System.Drawing.Size(232, 23);
            this.txtCodigoAlterar.TabIndex = 1;
            this.txtCodigoAlterar.TextChanged += new System.EventHandler(this.TxtCodigoAlterarTextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(8, 12);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(407, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "PESQUISAR POR CÓDIGO:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(553, 485);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 45);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = " CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.Button2Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(347, 485);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(200, 45);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = " CADASTRAR";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrarClick);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.btnDeletar.ForeColor = System.Drawing.Color.Red;
            this.btnDeletar.Image = global::CasadoRadiadores.Properties.Resources.trash;
            this.btnDeletar.Location = new System.Drawing.Point(8, 485);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(137, 45);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.Text = " DELETAR";
            this.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnProcurarCadastro
            // 
            this.btnProcurarCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcurarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurarCadastro.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurarCadastro.Image")));
            this.btnProcurarCadastro.Location = new System.Drawing.Point(421, 12);
            this.btnProcurarCadastro.Name = "btnProcurarCadastro";
            this.btnProcurarCadastro.Size = new System.Drawing.Size(141, 33);
            this.btnProcurarCadastro.TabIndex = 2;
            this.btnProcurarCadastro.Text = " PROCURAR";
            this.btnProcurarCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcurarCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcurarCadastro.UseVisualStyleBackColor = true;
            this.btnProcurarCadastro.Click += new System.EventHandler(this.BtnProcurarCadastroClick);
            // 
            // btnCancelarAlteracao
            // 
            this.btnCancelarAlteracao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarAlteracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarAlteracao.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAlteracao.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarAlteracao.Image")));
            this.btnCancelarAlteracao.Location = new System.Drawing.Point(556, 485);
            this.btnCancelarAlteracao.Name = "btnCancelarAlteracao";
            this.btnCancelarAlteracao.Size = new System.Drawing.Size(200, 45);
            this.btnCancelarAlteracao.TabIndex = 10;
            this.btnCancelarAlteracao.Text = " CANCELAR";
            this.btnCancelarAlteracao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarAlteracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarAlteracao.UseVisualStyleBackColor = true;
            this.btnCancelarAlteracao.Click += new System.EventHandler(this.BtnCancelarAlteracaoClick);
            // 
            // btnSalvarAlteracoes
            // 
            this.btnSalvarAlteracoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAlteracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarAlteracoes.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAlteracoes.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarAlteracoes.Image")));
            this.btnSalvarAlteracoes.Location = new System.Drawing.Point(289, 485);
            this.btnSalvarAlteracoes.Name = "btnSalvarAlteracoes";
            this.btnSalvarAlteracoes.Size = new System.Drawing.Size(261, 45);
            this.btnSalvarAlteracoes.TabIndex = 9;
            this.btnSalvarAlteracoes.Text = " SALVAR ALTERAÇÕES";
            this.btnSalvarAlteracoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarAlteracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarAlteracoes.UseVisualStyleBackColor = true;
            this.btnSalvarAlteracoes.Click += new System.EventHandler(this.BtnSalvarAlteracoesClick);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 586);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(805, 530);
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR & ALTERAR - CASADO RADIADORES";
            this.Load += new System.EventHandler(this.FrmCadastroLoad);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

		}
        private System.Windows.Forms.TextBox txtPrecoPagoCadastro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecoPagoAlterar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDeletar;
    }
}
