namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaAtualizarItens
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
            btn_cancel = new Button();
            btn_gravar = new Button();
            txb_titulo = new TextBox();
            label2 = new Label();
            txb_id = new TextBox();
            label1 = new Label();
            listBox_itensTarefa = new CheckedListBox();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancel.DialogResult = DialogResult.Cancel;
            btn_cancel.Location = new Point(251, 268);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 21;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_gravar
            // 
            btn_gravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_gravar.DialogResult = DialogResult.OK;
            btn_gravar.Location = new Point(170, 268);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(75, 23);
            btn_gravar.TabIndex = 20;
            btn_gravar.Text = "Gravar";
            btn_gravar.UseVisualStyleBackColor = true;
            // 
            // txb_titulo
            // 
            txb_titulo.Location = new Point(57, 57);
            txb_titulo.Name = "txb_titulo";
            txb_titulo.ReadOnly = true;
            txb_titulo.Size = new Size(269, 23);
            txb_titulo.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 60);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 18;
            label2.Text = "Titulo:";
            // 
            // txb_id
            // 
            txb_id.Enabled = false;
            txb_id.Location = new Point(57, 17);
            txb_id.Name = "txb_id";
            txb_id.ReadOnly = true;
            txb_id.Size = new Size(68, 23);
            txb_id.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 16;
            label1.Text = "ID:";
            // 
            // listBox_itensTarefa
            // 
            listBox_itensTarefa.FormattingEnabled = true;
            listBox_itensTarefa.Location = new Point(12, 100);
            listBox_itensTarefa.Name = "listBox_itensTarefa";
            listBox_itensTarefa.Size = new Size(314, 148);
            listBox_itensTarefa.TabIndex = 22;
            // 
            // TelaAtualizarItens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 303);
            Controls.Add(listBox_itensTarefa);
            Controls.Add(btn_cancel);
            Controls.Add(btn_gravar);
            Controls.Add(txb_titulo);
            Controls.Add(label2);
            Controls.Add(txb_id);
            Controls.Add(label1);
            Name = "TelaAtualizarItens";
            Text = "TelaAtualizarItens";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancel;
        private Button btn_gravar;
        private TextBox txb_titulo;
        private Label label2;
        private TextBox txb_id;
        private Label label1;
        private CheckedListBox listBox_itensTarefa;
    }
}