namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class ListagemTarefaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox_tarefas = new ListBox();
            SuspendLayout();
            // 
            // listBox_tarefas
            // 
            listBox_tarefas.Dock = DockStyle.Fill;
            listBox_tarefas.FormattingEnabled = true;
            listBox_tarefas.ItemHeight = 15;
            listBox_tarefas.Location = new Point(0, 0);
            listBox_tarefas.Name = "listBox_tarefas";
            listBox_tarefas.Size = new Size(522, 383);
            listBox_tarefas.TabIndex = 0;
            // 
            // ListagemTarefaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox_tarefas);
            Name = "ListagemTarefaControl";
            Size = new Size(522, 383);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox_tarefas;
    }
}
