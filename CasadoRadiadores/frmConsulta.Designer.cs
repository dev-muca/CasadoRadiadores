/*
 * Created by SharpDevelop.
 * User: Muca
 * Date: 28/10/2021
 * Time: 21:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CasadoRadiadores
{
	partial class frmConsulta
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.ComboBox cbFiltrar;
		private System.Windows.Forms.TextBox txtValorBuscaFiltrada;
		
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.txtValorBuscaFiltrada = new System.Windows.Forms.TextBox();
            this.cbFiltrar = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.casadoradiadores_dbDataSet = new CasadoRadiadores.casadoradiadores_dbDataSet();
            this.tbcadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_cadastroTableAdapter = new CasadoRadiadores.casadoradiadores_dbDataSetTableAdapters.tb_cadastroTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwResultados = new System.Windows.Forms.ListView();
            this.btnConsultaFull = new System.Windows.Forms.Button();
            this.tabCtrl1 = new System.Windows.Forms.TabControl();
            this.guiaResultados = new System.Windows.Forms.TabPage();
            this.lblParcela = new System.Windows.Forms.Label();
            this.lblTotalPrazo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValorVista = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbQuantidadeParcelas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.casadoradiadores_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcadastroBindingSource)).BeginInit();
            this.tabCtrl1.SuspendLayout();
            this.guiaResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValorBuscaFiltrada
            // 
            this.txtValorBuscaFiltrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorBuscaFiltrada.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorBuscaFiltrada.Location = new System.Drawing.Point(150, 33);
            this.txtValorBuscaFiltrada.Name = "txtValorBuscaFiltrada";
            this.txtValorBuscaFiltrada.Size = new System.Drawing.Size(474, 23);
            this.txtValorBuscaFiltrada.TabIndex = 2;
            this.txtValorBuscaFiltrada.Enter += new System.EventHandler(this.txtValorBuscaFiltrada_Enter);
            // 
            // cbFiltrar
            // 
            this.cbFiltrar.BackColor = System.Drawing.Color.White;
            this.cbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrar.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltrar.FormattingEnabled = true;
            this.cbFiltrar.Items.AddRange(new object[] {
            "Código",
            "Item"});
            this.cbFiltrar.Location = new System.Drawing.Point(15, 33);
            this.cbFiltrar.Name = "cbFiltrar";
            this.cbFiltrar.Size = new System.Drawing.Size(129, 23);
            this.cbFiltrar.TabIndex = 1;
            this.cbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cbFiltrar_SelectedIndexChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(630, 9);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(191, 86);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = " FILTRAR";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // casadoradiadores_dbDataSet
            // 
            this.casadoradiadores_dbDataSet.DataSetName = "casadoradiadores_dbDataSet";
            this.casadoradiadores_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbcadastroBindingSource
            // 
            this.tbcadastroBindingSource.DataMember = "tb_cadastro";
            this.tbcadastroBindingSource.DataSource = this.casadoradiadores_dbDataSet;
            // 
            // tb_cadastroTableAdapter
            // 
            this.tb_cadastroTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(620, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "FILTRAR POR:";
            // 
            // lvwResultados
            // 
            this.lvwResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwResultados.HideSelection = false;
            this.lvwResultados.Location = new System.Drawing.Point(6, 6);
            this.lvwResultados.Name = "lvwResultados";
            this.lvwResultados.Size = new System.Drawing.Size(795, 300);
            this.lvwResultados.TabIndex = 4;
            this.lvwResultados.UseCompatibleStateImageBehavior = false;
            this.lvwResultados.View = System.Windows.Forms.View.Details;
            this.lvwResultados.SelectedIndexChanged += new System.EventHandler(this.lvwResultados_SelectedIndexChanged);
            this.lvwResultados.DoubleClick += new System.EventHandler(this.lvwResultados_DoubleClick);
            // 
            // btnConsultaFull
            // 
            this.btnConsultaFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultaFull.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnConsultaFull.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaFull.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaFull.Image")));
            this.btnConsultaFull.Location = new System.Drawing.Point(404, 311);
            this.btnConsultaFull.Name = "btnConsultaFull";
            this.btnConsultaFull.Size = new System.Drawing.Size(397, 60);
            this.btnConsultaFull.TabIndex = 4;
            this.btnConsultaFull.Text = " CARREGAR TODOS OS REGISTROS";
            this.btnConsultaFull.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultaFull.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultaFull.UseVisualStyleBackColor = true;
            this.btnConsultaFull.Click += new System.EventHandler(this.btnConsultaFull_Click);
            // 
            // tabCtrl1
            // 
            this.tabCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrl1.Controls.Add(this.guiaResultados);
            this.tabCtrl1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrl1.Location = new System.Drawing.Point(6, 101);
            this.tabCtrl1.Name = "tabCtrl1";
            this.tabCtrl1.SelectedIndex = 0;
            this.tabCtrl1.Size = new System.Drawing.Size(815, 519);
            this.tabCtrl1.TabIndex = 5;
            // 
            // guiaResultados
            // 
            this.guiaResultados.Controls.Add(this.lblParcela);
            this.guiaResultados.Controls.Add(this.lblTotalPrazo);
            this.guiaResultados.Controls.Add(this.label3);
            this.guiaResultados.Controls.Add(this.lblValorVista);
            this.guiaResultados.Controls.Add(this.lvwResultados);
            this.guiaResultados.Controls.Add(this.btnConsultaFull);
            this.guiaResultados.Location = new System.Drawing.Point(4, 24);
            this.guiaResultados.Name = "guiaResultados";
            this.guiaResultados.Padding = new System.Windows.Forms.Padding(3);
            this.guiaResultados.Size = new System.Drawing.Size(807, 491);
            this.guiaResultados.TabIndex = 0;
            this.guiaResultados.Text = "RESULTADOS";
            this.guiaResultados.UseVisualStyleBackColor = true;
            // 
            // lblParcela
            // 
            this.lblParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblParcela.BackColor = System.Drawing.SystemColors.Control;
            this.lblParcela.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcela.Location = new System.Drawing.Point(407, 415);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(385, 60);
            this.lblParcela.TabIndex = 14;
            this.lblParcela.Text = "lblParcela";
            this.lblParcela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrazo
            // 
            this.lblTotalPrazo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPrazo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalPrazo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrazo.Location = new System.Drawing.Point(13, 415);
            this.lblTotalPrazo.Name = "lblTotalPrazo";
            this.lblTotalPrazo.Size = new System.Drawing.Size(385, 60);
            this.lblTotalPrazo.TabIndex = 13;
            this.lblTotalPrazo.Text = "lblTotalPrazo";
            this.lblTotalPrazo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 376);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(795, 108);
            this.label3.TabIndex = 12;
            this.label3.Text = "PARCELAMENTO:";
            // 
            // lblValorVista
            // 
            this.lblValorVista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorVista.BackColor = System.Drawing.Color.Gainsboro;
            this.lblValorVista.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorVista.Location = new System.Drawing.Point(6, 311);
            this.lblValorVista.Name = "lblValorVista";
            this.lblValorVista.Size = new System.Drawing.Size(392, 60);
            this.lblValorVista.TabIndex = 10;
            this.lblValorVista.Text = "lblValorVista";
            this.lblValorVista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "JUROS %:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtJuros
            // 
            this.txtJuros.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.txtJuros.Location = new System.Drawing.Point(265, 69);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(51, 23);
            this.txtJuros.TabIndex = 7;
            this.txtJuros.Text = "8";
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuros_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(620, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "PARCELAMENTO:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbQuantidadeParcelas
            // 
            this.cbQuantidadeParcelas.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuantidadeParcelas.FormattingEnabled = true;
            this.cbQuantidadeParcelas.Items.AddRange(new object[] {
            "2x",
            "3x",
            "4x",
            "5x",
            "6x",
            "7x",
            "8x",
            "9x",
            "10x",
            "11x",
            "12x"});
            this.cbQuantidadeParcelas.Location = new System.Drawing.Point(122, 69);
            this.cbQuantidadeParcelas.Name = "cbQuantidadeParcelas";
            this.cbQuantidadeParcelas.Size = new System.Drawing.Size(62, 23);
            this.cbQuantidadeParcelas.TabIndex = 17;
            this.cbQuantidadeParcelas.Text = "12x";
            this.cbQuantidadeParcelas.SelectedIndexChanged += new System.EventHandler(this.cbQuantidadeParcelas_SelectedIndexChanged_1);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 628);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbQuantidadeParcelas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorBuscaFiltrada);
            this.Controls.Add(this.tabCtrl1);
            this.Controls.Add(this.cbFiltrar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR PRODUTOS - CASADO RADIADORES";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.casadoradiadores_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcadastroBindingSource)).EndInit();
            this.tabCtrl1.ResumeLayout(false);
            this.guiaResultados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private casadoradiadores_dbDataSet casadoradiadores_dbDataSet;
        private System.Windows.Forms.BindingSource tbcadastroBindingSource;
        private casadoradiadores_dbDataSetTableAdapters.tb_cadastroTableAdapter tb_cadastroTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwResultados;
        private System.Windows.Forms.Button btnConsultaFull;
        private System.Windows.Forms.TabControl tabCtrl1;
        private System.Windows.Forms.TabPage guiaResultados;
        private System.Windows.Forms.Label lblValorVista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPrazo;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbQuantidadeParcelas;
    }
}
