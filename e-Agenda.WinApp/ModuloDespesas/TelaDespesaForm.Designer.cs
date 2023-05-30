namespace e_Agenda.WinApp.ModuloDespesas
{
    partial class TelaDespesaForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txb_id = new TextBox();
            label1 = new Label();
            txb_descricao = new TextBox();
            txb_valor = new TextBox();
            txb_data = new DateTimePicker();
            rdb_dinheiro = new RadioButton();
            rdb_ctCredito = new RadioButton();
            rdb_ctDebito = new RadioButton();
            rdb_pix = new RadioButton();
            groupBox1 = new GroupBox();
            checkList_categoria = new CheckedListBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 51);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 80);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 112);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Data:";
            // 
            // txb_id
            // 
            txb_id.Location = new Point(74, 19);
            txb_id.Name = "txb_id";
            txb_id.ReadOnly = true;
            txb_id.Size = new Size(40, 23);
            txb_id.TabIndex = 6;
            txb_id.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 22);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 5;
            label1.Text = "Id:";
            // 
            // txb_descricao
            // 
            txb_descricao.Location = new Point(74, 48);
            txb_descricao.Name = "txb_descricao";
            txb_descricao.Size = new Size(133, 23);
            txb_descricao.TabIndex = 7;
            // 
            // txb_valor
            // 
            txb_valor.Location = new Point(74, 77);
            txb_valor.Name = "txb_valor";
            txb_valor.Size = new Size(96, 23);
            txb_valor.TabIndex = 8;
            // 
            // txb_data
            // 
            txb_data.Format = DateTimePickerFormat.Short;
            txb_data.Location = new Point(74, 106);
            txb_data.Name = "txb_data";
            txb_data.Size = new Size(96, 23);
            txb_data.TabIndex = 9;
            // 
            // rdb_dinheiro
            // 
            rdb_dinheiro.AutoSize = true;
            rdb_dinheiro.Location = new Point(20, 29);
            rdb_dinheiro.Name = "rdb_dinheiro";
            rdb_dinheiro.Size = new Size(70, 19);
            rdb_dinheiro.TabIndex = 10;
            rdb_dinheiro.TabStop = true;
            rdb_dinheiro.Text = "Dinheiro";
            rdb_dinheiro.UseVisualStyleBackColor = true;
            // 
            // rdb_ctCredito
            // 
            rdb_ctCredito.AutoSize = true;
            rdb_ctCredito.Location = new Point(20, 54);
            rdb_ctCredito.Name = "rdb_ctCredito";
            rdb_ctCredito.Size = new Size(118, 19);
            rdb_ctCredito.TabIndex = 11;
            rdb_ctCredito.TabStop = true;
            rdb_ctCredito.Text = "Cartão de Credito";
            rdb_ctCredito.UseVisualStyleBackColor = true;
            // 
            // rdb_ctDebito
            // 
            rdb_ctDebito.AutoSize = true;
            rdb_ctDebito.Location = new Point(20, 79);
            rdb_ctDebito.Name = "rdb_ctDebito";
            rdb_ctDebito.Size = new Size(114, 19);
            rdb_ctDebito.TabIndex = 12;
            rdb_ctDebito.TabStop = true;
            rdb_ctDebito.Text = "Cartão de Débito";
            rdb_ctDebito.UseVisualStyleBackColor = true;
            // 
            // rdb_pix
            // 
            rdb_pix.AutoSize = true;
            rdb_pix.Location = new Point(20, 104);
            rdb_pix.Name = "rdb_pix";
            rdb_pix.Size = new Size(42, 19);
            rdb_pix.TabIndex = 13;
            rdb_pix.TabStop = true;
            rdb_pix.Text = "PIX";
            rdb_pix.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdb_ctCredito);
            groupBox1.Controls.Add(rdb_pix);
            groupBox1.Controls.Add(rdb_dinheiro);
            groupBox1.Controls.Add(rdb_ctDebito);
            groupBox1.Location = new Point(12, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 146);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pagamento:";
            // 
            // checkList_categoria
            // 
            checkList_categoria.FormattingEnabled = true;
            checkList_categoria.Location = new Point(243, 12);
            checkList_categoria.Name = "checkList_categoria";
            checkList_categoria.Size = new Size(269, 238);
            checkList_categoria.TabIndex = 15;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(439, 271);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 26);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(342, 271);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 26);
            btnGravar.TabIndex = 16;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaDespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 321);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(checkList_categoria);
            Controls.Add(groupBox1);
            Controls.Add(txb_data);
            Controls.Add(txb_valor);
            Controls.Add(txb_descricao);
            Controls.Add(txb_id);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "TelaDespesaForm";
            Text = "TelaDespesaForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txb_id;
        private Label label1;
        private TextBox txb_descricao;
        private TextBox txb_valor;
        private DateTimePicker txb_data;
        private RadioButton rdb_dinheiro;
        private RadioButton rdb_ctCredito;
        private RadioButton rdb_ctDebito;
        private RadioButton rdb_pix;
        private GroupBox groupBox1;
        private CheckedListBox checkList_categoria;
        private Button btnCancelar;
        private Button btnGravar;
    }
}