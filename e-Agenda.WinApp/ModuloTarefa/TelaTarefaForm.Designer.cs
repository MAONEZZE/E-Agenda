namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaForm
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
            label1 = new Label();
            txb_id = new TextBox();
            label2 = new Label();
            txb_titulo = new TextBox();
            label3 = new Label();
            btn_gravar = new Button();
            btn_cancel = new Button();
            gpBox_prioridades = new GroupBox();
            rb_baixa = new RadioButton();
            rb_media = new RadioButton();
            rb_alta = new RadioButton();
            label4 = new Label();
            txb_data = new DateTimePicker();
            label7 = new Label();
            gpBox_prioridades.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 38);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // txb_id
            // 
            txb_id.Enabled = false;
            txb_id.Location = new Point(64, 35);
            txb_id.Name = "txb_id";
            txb_id.Size = new Size(68, 23);
            txb_id.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 78);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Titulo*:";
            // 
            // txb_titulo
            // 
            txb_titulo.Location = new Point(64, 75);
            txb_titulo.Name = "txb_titulo";
            txb_titulo.Size = new Size(140, 23);
            txb_titulo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 120);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Prioridade*:";
            // 
            // btn_gravar
            // 
            btn_gravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_gravar.DialogResult = DialogResult.OK;
            btn_gravar.Location = new Point(258, 180);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(75, 23);
            btn_gravar.TabIndex = 8;
            btn_gravar.Text = "Gravar";
            btn_gravar.UseVisualStyleBackColor = true;
            btn_gravar.Click += btn_gravar_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancel.DialogResult = DialogResult.Cancel;
            btn_cancel.Location = new Point(339, 180);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 9;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // gpBox_prioridades
            // 
            gpBox_prioridades.Controls.Add(rb_baixa);
            gpBox_prioridades.Controls.Add(rb_media);
            gpBox_prioridades.Controls.Add(rb_alta);
            gpBox_prioridades.Location = new Point(88, 104);
            gpBox_prioridades.Name = "gpBox_prioridades";
            gpBox_prioridades.Size = new Size(187, 49);
            gpBox_prioridades.TabIndex = 10;
            gpBox_prioridades.TabStop = false;
            // 
            // rb_baixa
            // 
            rb_baixa.AutoSize = true;
            rb_baixa.Location = new Point(122, 16);
            rb_baixa.Name = "rb_baixa";
            rb_baixa.Size = new Size(53, 19);
            rb_baixa.TabIndex = 13;
            rb_baixa.TabStop = true;
            rb_baixa.Text = "Baixa";
            rb_baixa.UseVisualStyleBackColor = true;
            // 
            // rb_media
            // 
            rb_media.AutoSize = true;
            rb_media.Location = new Point(58, 16);
            rb_media.Name = "rb_media";
            rb_media.Size = new Size(58, 19);
            rb_media.TabIndex = 12;
            rb_media.TabStop = true;
            rb_media.Text = "Media";
            rb_media.UseVisualStyleBackColor = true;
            // 
            // rb_alta
            // 
            rb_alta.AutoSize = true;
            rb_alta.Location = new Point(6, 16);
            rb_alta.Name = "rb_alta";
            rb_alta.Size = new Size(46, 19);
            rb_alta.TabIndex = 11;
            rb_alta.TabStop = true;
            rb_alta.Text = "Alta";
            rb_alta.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 78);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 11;
            label4.Text = "Data:";
            // 
            // txb_data
            // 
            txb_data.Format = DateTimePickerFormat.Short;
            txb_data.Location = new Point(275, 75);
            txb_data.Name = "txb_data";
            txb_data.Size = new Size(95, 23);
            txb_data.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(277, 9);
            label7.Name = "label7";
            label7.Size = new Size(137, 15);
            label7.TabIndex = 21;
            label7.Text = "* = Campos obtigatórios";
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 215);
            Controls.Add(label7);
            Controls.Add(txb_data);
            Controls.Add(label4);
            Controls.Add(gpBox_prioridades);
            Controls.Add(btn_cancel);
            Controls.Add(btn_gravar);
            Controls.Add(label3);
            Controls.Add(txb_titulo);
            Controls.Add(label2);
            Controls.Add(txb_id);
            Controls.Add(label1);
            Name = "TelaTarefaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaTarefaForm";
            gpBox_prioridades.ResumeLayout(false);
            gpBox_prioridades.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txb_id;
        private Label label2;
        private TextBox txb_titulo;
        private Label label3;
        private Button btn_gravar;
        private Button btn_cancel;
        private GroupBox gpBox_prioridades;
        private RadioButton rb_baixa;
        private RadioButton rb_media;
        private RadioButton rb_alta;
        private Label label4;
        private DateTimePicker txb_data;
        private Label label7;
    }
}