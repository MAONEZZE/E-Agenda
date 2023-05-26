namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class ListagemCompromissoControl
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
            listB_compromisso = new ListBox();
            SuspendLayout();
            // 
            // listB_compromisso
            // 
            listB_compromisso.Dock = DockStyle.Fill;
            listB_compromisso.FormattingEnabled = true;
            listB_compromisso.ItemHeight = 15;
            listB_compromisso.Location = new Point(0, 0);
            listB_compromisso.Name = "listB_compromisso";
            listB_compromisso.Size = new Size(424, 303);
            listB_compromisso.TabIndex = 0;
            // 
            // ListagemCompromissoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listB_compromisso);
            Name = "ListagemCompromissoControl";
            Size = new Size(424, 303);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listB_compromisso;
    }
}
