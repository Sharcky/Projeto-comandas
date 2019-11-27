namespace WindowsFormsApp3.formularios
{
    partial class frmitensvenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbvenda = new System.Windows.Forms.ComboBox();
            this.cmbproduto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.txtvalorproduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtproduto2 = new System.Windows.Forms.TextBox();
            this.txtid2 = new System.Windows.Forms.TextBox();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtquantidade2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvalorproduto2 = new System.Windows.Forms.TextBox();
            this.txtdesconto2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbComandaP = new System.Windows.Forms.ComboBox();
            this.cmbIdVendaP = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnconsultaComanda = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dvglista = new System.Windows.Forms.DataGridView();
            this.btnvendanova = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.txtdesconto3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvglista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbvenda);
            this.groupBox1.Controls.Add(this.cmbproduto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInserir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdesconto);
            this.groupBox1.Controls.Add(this.txtvalorproduto);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 60);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // cmbvenda
            // 
            this.cmbvenda.FormattingEnabled = true;
            this.cmbvenda.Location = new System.Drawing.Point(6, 28);
            this.cmbvenda.Name = "cmbvenda";
            this.cmbvenda.Size = new System.Drawing.Size(57, 21);
            this.cmbvenda.TabIndex = 27;
            this.cmbvenda.SelectedIndexChanged += new System.EventHandler(this.Cmbvenda_SelectedIndexChanged);
            // 
            // cmbproduto
            // 
            this.cmbproduto.FormattingEnabled = true;
            this.cmbproduto.Location = new System.Drawing.Point(69, 28);
            this.cmbproduto.Name = "cmbproduto";
            this.cmbproduto.Size = new System.Drawing.Size(87, 21);
            this.cmbproduto.TabIndex = 26;
            this.cmbproduto.SelectedIndexChanged += new System.EventHandler(this.Cmbproduto_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "quantidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(374, 16);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(81, 28);
            this.btnInserir.TabIndex = 23;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "id_produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "valor produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "desconto";
            // 
            // txtdesconto
            // 
            this.txtdesconto.Location = new System.Drawing.Point(297, 28);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(51, 20);
            this.txtdesconto.TabIndex = 6;
            // 
            // txtvalorproduto
            // 
            this.txtvalorproduto.Location = new System.Drawing.Point(225, 28);
            this.txtvalorproduto.Name = "txtvalorproduto";
            this.txtvalorproduto.Size = new System.Drawing.Size(66, 20);
            this.txtvalorproduto.TabIndex = 7;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(162, 28);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(57, 20);
            this.txtQuantidade.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtproduto2);
            this.groupBox2.Controls.Add(this.txtid2);
            this.groupBox2.Controls.Add(this.btnalterar);
            this.groupBox2.Controls.Add(this.btnLista);
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtquantidade2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtvalorproduto2);
            this.groupBox2.Controls.Add(this.txtdesconto2);
            this.groupBox2.Location = new System.Drawing.Point(470, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 60);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // txtproduto2
            // 
            this.txtproduto2.Enabled = false;
            this.txtproduto2.Location = new System.Drawing.Point(71, 28);
            this.txtproduto2.Name = "txtproduto2";
            this.txtproduto2.Size = new System.Drawing.Size(64, 20);
            this.txtproduto2.TabIndex = 27;
            // 
            // txtid2
            // 
            this.txtid2.Location = new System.Drawing.Point(8, 28);
            this.txtid2.Name = "txtid2";
            this.txtid2.Size = new System.Drawing.Size(57, 20);
            this.txtid2.TabIndex = 26;
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(520, 9);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(81, 28);
            this.btnalterar.TabIndex = 24;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.Btnalterar_Click);
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(607, 9);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(81, 28);
            this.btnLista.TabIndex = 24;
            this.btnLista.Text = "lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.BtnLista_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(433, 9);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(81, 28);
            this.btnConsultar.TabIndex = 25;
            this.btnConsultar.Text = "consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "id_produto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "valor produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "desconto";
            // 
            // txtquantidade2
            // 
            this.txtquantidade2.Location = new System.Drawing.Point(142, 28);
            this.txtquantidade2.Name = "txtquantidade2";
            this.txtquantidade2.Size = new System.Drawing.Size(57, 20);
            this.txtquantidade2.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "quantidade";
            // 
            // txtvalorproduto2
            // 
            this.txtvalorproduto2.Location = new System.Drawing.Point(206, 28);
            this.txtvalorproduto2.Name = "txtvalorproduto2";
            this.txtvalorproduto2.Size = new System.Drawing.Size(66, 20);
            this.txtvalorproduto2.TabIndex = 17;
            // 
            // txtdesconto2
            // 
            this.txtdesconto2.Location = new System.Drawing.Point(278, 28);
            this.txtdesconto2.Name = "txtdesconto2";
            this.txtdesconto2.Size = new System.Drawing.Size(51, 20);
            this.txtdesconto2.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbComandaP);
            this.groupBox3.Controls.Add(this.cmbIdVendaP);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.btnconsultaComanda);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dvglista);
            this.groupBox3.Controls.Add(this.btnvendanova);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.cmbCliente);
            this.groupBox3.Controls.Add(this.cmbUsuario);
            this.groupBox3.Controls.Add(this.txtdesconto3);
            this.groupBox3.Location = new System.Drawing.Point(13, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1154, 300);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // cmbComandaP
            // 
            this.cmbComandaP.FormattingEnabled = true;
            this.cmbComandaP.Location = new System.Drawing.Point(977, 23);
            this.cmbComandaP.Name = "cmbComandaP";
            this.cmbComandaP.Size = new System.Drawing.Size(72, 21);
            this.cmbComandaP.TabIndex = 46;
            // 
            // cmbIdVendaP
            // 
            this.cmbIdVendaP.FormattingEnabled = true;
            this.cmbIdVendaP.Location = new System.Drawing.Point(880, 22);
            this.cmbIdVendaP.Name = "cmbIdVendaP";
            this.cmbIdVendaP.Size = new System.Drawing.Size(72, 21);
            this.cmbIdVendaP.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(877, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Id_venda";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(977, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Id_Comanda";
            // 
            // btnconsultaComanda
            // 
            this.btnconsultaComanda.Location = new System.Drawing.Point(1067, 14);
            this.btnconsultaComanda.Name = "btnconsultaComanda";
            this.btnconsultaComanda.Size = new System.Drawing.Size(81, 28);
            this.btnconsultaComanda.TabIndex = 41;
            this.btnconsultaComanda.Text = "consultar";
            this.btnconsultaComanda.UseVisualStyleBackColor = true;
            this.btnconsultaComanda.Click += new System.EventHandler(this.BtnconsultaComanda_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(368, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "data";
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(371, 22);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(120, 20);
            this.txtData.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(141, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "cliente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(219, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "usuario";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(299, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "desconto";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(756, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 28);
            this.button3.TabIndex = 37;
            this.button3.Text = "lista";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 28);
            this.button2.TabIndex = 36;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 35;
            this.button1.Text = "consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dvglista
            // 
            this.dvglista.AllowUserToAddRows = false;
            this.dvglista.AllowUserToDeleteRows = false;
            this.dvglista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvglista.Location = new System.Drawing.Point(23, 49);
            this.dvglista.Name = "dvglista";
            this.dvglista.ReadOnly = true;
            this.dvglista.Size = new System.Drawing.Size(1142, 245);
            this.dvglista.TabIndex = 0;
            // 
            // btnvendanova
            // 
            this.btnvendanova.Location = new System.Drawing.Point(3, 14);
            this.btnvendanova.Name = "btnvendanova";
            this.btnvendanova.Size = new System.Drawing.Size(81, 28);
            this.btnvendanova.TabIndex = 29;
            this.btnvendanova.Text = "nova venda";
            this.btnvendanova.UseVisualStyleBackColor = true;
            this.btnvendanova.Click += new System.EventHandler(this.Btnvendanova_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(88, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 30;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(144, 23);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(72, 21);
            this.cmbCliente.TabIndex = 31;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(12, 412);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(63, 20);
            this.txtSituacao.TabIndex = 34;
            this.txtSituacao.Text = "A";
            this.txtSituacao.Visible = false;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(222, 23);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(74, 21);
            this.cmbUsuario.TabIndex = 32;
            // 
            // txtdesconto3
            // 
            this.txtdesconto3.Location = new System.Drawing.Point(302, 23);
            this.txtdesconto3.Name = "txtdesconto3";
            this.txtdesconto3.Size = new System.Drawing.Size(63, 20);
            this.txtdesconto3.TabIndex = 33;
            // 
            // frmitensvenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 460);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSituacao);
            this.Name = "frmitensvenda";
            this.Text = "itens_venda";
            this.Load += new System.EventHandler(this.Frmitensvenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvglista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbproduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.TextBox txtvalorproduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtproduto2;
        private System.Windows.Forms.TextBox txtid2;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtquantidade2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvalorproduto2;
        private System.Windows.Forms.TextBox txtdesconto2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.DataGridView dvglista;
        private System.Windows.Forms.ComboBox cmbvenda;
        private System.Windows.Forms.Button btnvendanova;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.TextBox txtdesconto3;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnconsultaComanda;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbComandaP;
        private System.Windows.Forms.ComboBox cmbIdVendaP;
    }
}