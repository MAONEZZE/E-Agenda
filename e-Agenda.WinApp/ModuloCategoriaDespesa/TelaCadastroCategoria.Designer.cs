namespace e_Agenda.WinApp.ModuloCategoriaDespesa
{
    partial class TelaCadastroCategoria
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
            txb_id = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            txb_titulo = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txb_id
            // 
            txb_id.Location = new Point(64, 27);
            txb_id.Name = "txb_id";
            txb_id.ReadOnly = true;
            txb_id.Size = new Size(40, 23);
            txb_id.TabIndex = 8;
            txb_id.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 30);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 7;
            label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(159, 111);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 26);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(62, 111);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 26);
            btnGravar.TabIndex = 18;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txb_titulo
            // 
            txb_titulo.Location = new Point(64, 65);
            txb_titulo.Name = "txb_titulo";
            txb_titulo.Size = new Size(168, 23);
            txb_titulo.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 68);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 21;
            label2.Text = "Título:";
            // 
            // TelaCadastroCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 149);
            Controls.Add(label2);
            Controls.Add(txb_titulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txb_id);
            Controls.Add(label1);
            Name = "TelaCadastroCategoria";
            Text = "TelaCadastroCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_id;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txb_titulo;
        private Label label2;
    }
}