namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaFiltroCompromisso
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
            btn_filtrar = new Button();
            btn_cancelar = new Button();
            rb_todosComp = new RadioButton();
            rb_compPassados = new RadioButton();
            rb_compFuturos = new RadioButton();
            txb_dataInicio = new DateTimePicker();
            txb_dataFim = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_filtrar
            // 
            btn_filtrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_filtrar.DialogResult = DialogResult.OK;
            btn_filtrar.Location = new Point(276, 105);
            btn_filtrar.Name = "btn_filtrar";
            btn_filtrar.Size = new Size(75, 23);
            btn_filtrar.TabIndex = 0;
            btn_filtrar.Text = "Filtrar";
            btn_filtrar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.DialogResult = DialogResult.Cancel;
            btn_cancelar.Location = new Point(358, 105);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // rb_todosComp
            // 
            rb_todosComp.AutoSize = true;
            rb_todosComp.Location = new Point(25, 14);
            rb_todosComp.Name = "rb_todosComp";
            rb_todosComp.Size = new Size(203, 19);
            rb_todosComp.TabIndex = 2;
            rb_todosComp.TabStop = true;
            rb_todosComp.Text = "Visualizar todos os compromissos";
            rb_todosComp.UseVisualStyleBackColor = true;
            // 
            // rb_compPassados
            // 
            rb_compPassados.AutoSize = true;
            rb_compPassados.Location = new Point(25, 48);
            rb_compPassados.Name = "rb_compPassados";
            rb_compPassados.Size = new Size(206, 19);
            rb_compPassados.TabIndex = 3;
            rb_compPassados.TabStop = true;
            rb_compPassados.Text = "Visualizar compromissos passados";
            rb_compPassados.UseVisualStyleBackColor = true;
            // 
            // rb_compFuturos
            // 
            rb_compFuturos.AutoSize = true;
            rb_compFuturos.Location = new Point(25, 83);
            rb_compFuturos.Name = "rb_compFuturos";
            rb_compFuturos.Size = new Size(196, 19);
            rb_compFuturos.TabIndex = 4;
            rb_compFuturos.TabStop = true;
            rb_compFuturos.Text = "Visualizar compromissos futuros";
            rb_compFuturos.UseVisualStyleBackColor = true;
            // 
            // txb_dataInicio
            // 
            txb_dataInicio.Format = DateTimePickerFormat.Short;
            txb_dataInicio.Location = new Point(331, 12);
            txb_dataInicio.Name = "txb_dataInicio";
            txb_dataInicio.Size = new Size(88, 23);
            txb_dataInicio.TabIndex = 5;
            // 
            // txb_dataFim
            // 
            txb_dataFim.Format = DateTimePickerFormat.Short;
            txb_dataFim.Location = new Point(331, 50);
            txb_dataFim.Name = "txb_dataFim";
            txb_dataFim.Size = new Size(88, 23);
            txb_dataFim.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 18);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 7;
            label1.Text = "Data Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 56);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Data Fim:";
            // 
            // TelaFiltroCompromisso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 140);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txb_dataFim);
            Controls.Add(txb_dataInicio);
            Controls.Add(rb_compFuturos);
            Controls.Add(rb_compPassados);
            Controls.Add(rb_todosComp);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_filtrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroCompromisso";
            ShowIcon = false;
            Text = "Filtro de Compromisso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_filtrar;
        private Button btn_cancelar;
        private RadioButton rb_todosComp;
        private RadioButton rb_compPassados;
        private RadioButton rb_compFuturos;
        private DateTimePicker txb_dataInicio;
        private DateTimePicker txb_dataFim;
        private Label label1;
        private Label label2;
    }
}