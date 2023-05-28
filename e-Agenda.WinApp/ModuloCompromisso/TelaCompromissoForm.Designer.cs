namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txb_id = new TextBox();
            txb_assunto = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cbox_contato = new ComboBox();
            txb_data = new DateTimePicker();
            txb_horaInicio = new DateTimePicker();
            txb_horaFinal = new DateTimePicker();
            rdb_presencial = new RadioButton();
            rdb_online = new RadioButton();
            groupBox1 = new GroupBox();
            txb_presencial = new TextBox();
            txb_online = new TextBox();
            btn_gravar = new Button();
            btn_cancelar = new Button();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 15);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 106);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Data*:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 61);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Assunto*:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 210);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Contato:";
            // 
            // txb_id
            // 
            txb_id.Enabled = false;
            txb_id.Location = new Point(65, 12);
            txb_id.Name = "txb_id";
            txb_id.ReadOnly = true;
            txb_id.Size = new Size(52, 23);
            txb_id.TabIndex = 4;
            // 
            // txb_assunto
            // 
            txb_assunto.Location = new Point(65, 58);
            txb_assunto.Name = "txb_assunto";
            txb_assunto.Size = new Size(237, 23);
            txb_assunto.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 152);
            label5.Name = "label5";
            label5.Size = new Size(47, 30);
            label5.TabIndex = 7;
            label5.Text = "Horário\r\n Início*:\r\n";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(167, 152);
            label6.Name = "label6";
            label6.Size = new Size(47, 30);
            label6.TabIndex = 8;
            label6.Text = "Horário\r\n Final*:\r\n";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbox_contato
            // 
            cbox_contato.DropDownStyle = ComboBoxStyle.DropDownList;
            cbox_contato.FormattingEnabled = true;
            cbox_contato.Location = new Point(65, 207);
            cbox_contato.Name = "cbox_contato";
            cbox_contato.Size = new Size(158, 23);
            cbox_contato.TabIndex = 11;
            // 
            // txb_data
            // 
            txb_data.CustomFormat = "dd/MM/yyyy";
            txb_data.Format = DateTimePickerFormat.Custom;
            txb_data.Location = new Point(65, 106);
            txb_data.Name = "txb_data";
            txb_data.Size = new Size(82, 23);
            txb_data.TabIndex = 12;
            txb_data.Value = new DateTime(2023, 5, 26, 0, 0, 0, 0);
            // 
            // txb_horaInicio
            // 
            txb_horaInicio.CustomFormat = "HH:mm";
            txb_horaInicio.Format = DateTimePickerFormat.Custom;
            txb_horaInicio.Location = new Point(65, 154);
            txb_horaInicio.Name = "txb_horaInicio";
            txb_horaInicio.ShowUpDown = true;
            txb_horaInicio.Size = new Size(82, 23);
            txb_horaInicio.TabIndex = 13;
            txb_horaInicio.Value = new DateTime(2023, 5, 26, 16, 43, 0, 0);
            // 
            // txb_horaFinal
            // 
            txb_horaFinal.CustomFormat = "HH:mm";
            txb_horaFinal.Format = DateTimePickerFormat.Custom;
            txb_horaFinal.Location = new Point(220, 154);
            txb_horaFinal.Name = "txb_horaFinal";
            txb_horaFinal.ShowUpDown = true;
            txb_horaFinal.Size = new Size(82, 23);
            txb_horaFinal.TabIndex = 14;
            // 
            // rdb_presencial
            // 
            rdb_presencial.AutoSize = true;
            rdb_presencial.Location = new Point(11, 51);
            rdb_presencial.Name = "rdb_presencial";
            rdb_presencial.Size = new Size(78, 19);
            rdb_presencial.TabIndex = 15;
            rdb_presencial.TabStop = true;
            rdb_presencial.Text = "Presencial";
            rdb_presencial.UseVisualStyleBackColor = true;
            rdb_presencial.CheckedChanged += rdb_presencial_CheckedChanged;
            // 
            // rdb_online
            // 
            rdb_online.AutoSize = true;
            rdb_online.Location = new Point(29, 22);
            rdb_online.Name = "rdb_online";
            rdb_online.Size = new Size(60, 19);
            rdb_online.TabIndex = 16;
            rdb_online.TabStop = true;
            rdb_online.Text = "Online";
            rdb_online.UseVisualStyleBackColor = true;
            rdb_online.CheckedChanged += rdb_online_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txb_presencial);
            groupBox1.Controls.Add(txb_online);
            groupBox1.Controls.Add(rdb_presencial);
            groupBox1.Controls.Add(rdb_online);
            groupBox1.Location = new Point(12, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 92);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lugar e Tipo*";
            // 
            // txb_presencial
            // 
            txb_presencial.Location = new Point(95, 51);
            txb_presencial.Name = "txb_presencial";
            txb_presencial.Size = new Size(195, 23);
            txb_presencial.TabIndex = 20;
            // 
            // txb_online
            // 
            txb_online.Location = new Point(95, 22);
            txb_online.Name = "txb_online";
            txb_online.Size = new Size(195, 23);
            txb_online.TabIndex = 19;
            // 
            // btn_gravar
            // 
            btn_gravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_gravar.DialogResult = DialogResult.OK;
            btn_gravar.Location = new Point(171, 361);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(75, 23);
            btn_gravar.TabIndex = 18;
            btn_gravar.Text = "Gravar";
            btn_gravar.UseVisualStyleBackColor = true;
            btn_gravar.Click += btn_gravar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.DialogResult = DialogResult.Cancel;
            btn_cancelar.Location = new Point(254, 361);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 19;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(192, 12);
            label7.Name = "label7";
            label7.Size = new Size(137, 15);
            label7.TabIndex = 20;
            label7.Text = "* = Campos obtigatórios";
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 396);
            Controls.Add(label7);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_gravar);
            Controls.Add(groupBox1);
            Controls.Add(txb_horaFinal);
            Controls.Add(txb_horaInicio);
            Controls.Add(txb_data);
            Controls.Add(cbox_contato);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txb_assunto);
            Controls.Add(txb_id);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Compromisso ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txb_id;
        private TextBox txb_assunto;
        private Label label5;
        private Label label6;
        private ComboBox cbox_contato;
        private DateTimePicker txb_data;
        private DateTimePicker txb_horaInicio;
        private DateTimePicker txb_horaFinal;
        private RadioButton rdb_presencial;
        private RadioButton rdb_online;
        private GroupBox groupBox1;
        private TextBox txb_presencial;
        private TextBox txb_online;
        private Button btn_gravar;
        private Button btn_cancelar;
        private Label label7;
    }
}