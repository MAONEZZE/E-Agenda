namespace e_Agenda.WinApp.ModuloContato
{
    partial class TelaContatoForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txb_id = new TextBox();
            label2 = new Label();
            txb_nome = new TextBox();
            txb_telefone = new TextBox();
            txb_cargo = new TextBox();
            txb_email = new TextBox();
            txb_empresa = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(288, 107);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 26);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(385, 107);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 26);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 24);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 2;
            label1.Text = "Id:";
            // 
            // txb_id
            // 
            txb_id.Location = new Point(76, 20);
            txb_id.Name = "txb_id";
            txb_id.ReadOnly = true;
            txb_id.Size = new Size(40, 23);
            txb_id.TabIndex = 3;
            txb_id.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 53);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // txb_nome
            // 
            txb_nome.Location = new Point(76, 49);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(149, 23);
            txb_nome.TabIndex = 5;
            // 
            // txb_telefone
            // 
            txb_telefone.Location = new Point(311, 50);
            txb_telefone.Name = "txb_telefone";
            txb_telefone.Size = new Size(149, 23);
            txb_telefone.TabIndex = 6;
            // 
            // txb_cargo
            // 
            txb_cargo.Location = new Point(76, 78);
            txb_cargo.Name = "txb_cargo";
            txb_cargo.Size = new Size(149, 23);
            txb_cargo.TabIndex = 7;
            // 
            // txb_email
            // 
            txb_email.Location = new Point(76, 107);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(149, 23);
            txb_email.TabIndex = 8;
            // 
            // txb_empresa
            // 
            txb_empresa.Location = new Point(311, 78);
            txb_empresa.Name = "txb_empresa";
            txb_empresa.Size = new Size(149, 23);
            txb_empresa.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 53);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 10;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 110);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 11;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 81);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 12;
            label5.Text = "Empresa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 81);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 13;
            label6.Text = "Cargo:";
            // 
            // TelaContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 150);
            Controls.Add(txb_nome);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txb_id);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txb_telefone);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(btnGravar);
            Controls.Add(txb_cargo);
            Controls.Add(txb_empresa);
            Controls.Add(label3);
            Controls.Add(txb_email);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContatoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Contatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txb_id;
        private Label label2;
        private TextBox txb_nome;
        private TextBox txb_telefone;
        private TextBox txb_cargo;
        private TextBox txb_email;
        private TextBox txb_empresa;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}