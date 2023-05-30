namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaFiltro
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
            groupBox1 = new GroupBox();
            rdb_todas = new RadioButton();
            rdb_pendentes = new RadioButton();
            rdb_dataCriacao = new RadioButton();
            rdb_concluidos = new RadioButton();
            txb_dataInicio = new DateTimePicker();
            txb_dataFim = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            btn_cancel = new Button();
            btn_filtrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdb_todas);
            groupBox1.Controls.Add(rdb_pendentes);
            groupBox1.Controls.Add(rdb_dataCriacao);
            groupBox1.Controls.Add(rdb_concluidos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(188, 136);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione o tipo de filtragem";
            // 
            // rdb_todas
            // 
            rdb_todas.AutoSize = true;
            rdb_todas.Location = new Point(6, 107);
            rdb_todas.Name = "rdb_todas";
            rdb_todas.Size = new Size(108, 19);
            rdb_todas.TabIndex = 4;
            rdb_todas.TabStop = true;
            rdb_todas.Text = "Todas as Tarefas";
            rdb_todas.UseVisualStyleBackColor = true;
            rdb_todas.CheckedChanged += rdb_todas_CheckedChanged;
            // 
            // rdb_pendentes
            // 
            rdb_pendentes.AutoSize = true;
            rdb_pendentes.Location = new Point(6, 82);
            rdb_pendentes.Name = "rdb_pendentes";
            rdb_pendentes.Size = new Size(80, 19);
            rdb_pendentes.TabIndex = 3;
            rdb_pendentes.TabStop = true;
            rdb_pendentes.Text = "Pendentes";
            rdb_pendentes.UseVisualStyleBackColor = true;
            rdb_pendentes.CheckedChanged += rdb_pendentes_CheckedChanged;
            // 
            // rdb_dataCriacao
            // 
            rdb_dataCriacao.AutoSize = true;
            rdb_dataCriacao.Location = new Point(6, 32);
            rdb_dataCriacao.Name = "rdb_dataCriacao";
            rdb_dataCriacao.Size = new Size(126, 19);
            rdb_dataCriacao.TabIndex = 1;
            rdb_dataCriacao.TabStop = true;
            rdb_dataCriacao.Text = "Por data de criação";
            rdb_dataCriacao.UseVisualStyleBackColor = true;
            rdb_dataCriacao.CheckedChanged += rdb_dataCriacao_CheckedChanged;
            // 
            // rdb_concluidos
            // 
            rdb_concluidos.AutoSize = true;
            rdb_concluidos.Location = new Point(6, 57);
            rdb_concluidos.Name = "rdb_concluidos";
            rdb_concluidos.Size = new Size(85, 19);
            rdb_concluidos.TabIndex = 2;
            rdb_concluidos.TabStop = true;
            rdb_concluidos.Text = "Concluidos";
            rdb_concluidos.UseVisualStyleBackColor = true;
            rdb_concluidos.CheckedChanged += rdb_concluidos_CheckedChanged;
            // 
            // txb_dataInicio
            // 
            txb_dataInicio.Format = DateTimePickerFormat.Short;
            txb_dataInicio.Location = new Point(292, 40);
            txb_dataInicio.Name = "txb_dataInicio";
            txb_dataInicio.Size = new Size(95, 23);
            txb_dataInicio.TabIndex = 1;
            // 
            // txb_dataFim
            // 
            txb_dataFim.Format = DateTimePickerFormat.Short;
            txb_dataFim.Location = new Point(292, 69);
            txb_dataFim.Name = "txb_dataFim";
            txb_dataFim.Size = new Size(95, 23);
            txb_dataFim.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 46);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Data Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 75);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Data Fim:";
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancel.DialogResult = DialogResult.Cancel;
            btn_cancel.Location = new Point(325, 125);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 11;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_filtrar
            // 
            btn_filtrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_filtrar.DialogResult = DialogResult.OK;
            btn_filtrar.Location = new Point(244, 125);
            btn_filtrar.Name = "btn_filtrar";
            btn_filtrar.Size = new Size(75, 23);
            btn_filtrar.TabIndex = 10;
            btn_filtrar.Text = "Filtrar";
            btn_filtrar.UseVisualStyleBackColor = true;
            // 
            // TelaTarefaFiltro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 157);
            Controls.Add(btn_cancel);
            Controls.Add(btn_filtrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txb_dataFim);
            Controls.Add(txb_dataInicio);
            Controls.Add(groupBox1);
            Name = "TelaTarefaFiltro";
            ShowIcon = false;
            Text = "Filtro de Tarefas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdb_pendentes;
        private RadioButton rdb_dataCriacao;
        private RadioButton rdb_concluidos;
        private DateTimePicker txb_dataInicio;
        private DateTimePicker txb_dataFim;
        private Label label1;
        private Label label2;
        private Button btn_cancel;
        private Button btn_filtrar;
        private RadioButton rdb_todas;
    }
}