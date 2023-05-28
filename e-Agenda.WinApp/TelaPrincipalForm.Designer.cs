namespace e_Agenda.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosMenuItem = new ToolStripMenuItem();
            contatosMenuItem = new ToolStripMenuItem();
            compromissosMenuItem = new ToolStripMenuItem();
            tarefasMenuItem = new ToolStripMenuItem();
            despesasToolStripMenuItem = new ToolStripMenuItem();
            despesasMenuItem = new ToolStripMenuItem();
            categoriasMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lbl_statusRodape = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btn_inserir = new ToolStripButton();
            btn_editar = new ToolStripButton();
            btn_excluir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_addItem = new ToolStripButton();
            btn_listarItens = new ToolStripButton();
            btn_filtrar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_concluidos = new ToolStripButton();
            btn_abertos = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            labelTipoCadastro = new ToolStripLabel();
            pnl_principal = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosMenuItem, relatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(633, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosMenuItem
            // 
            cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contatosMenuItem, compromissosMenuItem, tarefasMenuItem, despesasToolStripMenuItem });
            cadastrosMenuItem.Name = "cadastrosMenuItem";
            cadastrosMenuItem.Size = new Size(71, 20);
            cadastrosMenuItem.Text = "Cadastros";
            // 
            // contatosMenuItem
            // 
            contatosMenuItem.Name = "contatosMenuItem";
            contatosMenuItem.Size = new Size(154, 22);
            contatosMenuItem.Text = "Contatos";
            contatosMenuItem.Click += contatosMenuItem_Click;
            // 
            // compromissosMenuItem
            // 
            compromissosMenuItem.Name = "compromissosMenuItem";
            compromissosMenuItem.Size = new Size(154, 22);
            compromissosMenuItem.Text = "Compromissos";
            compromissosMenuItem.Click += compromissosMenuItem_Click;
            // 
            // tarefasMenuItem
            // 
            tarefasMenuItem.Name = "tarefasMenuItem";
            tarefasMenuItem.Size = new Size(154, 22);
            tarefasMenuItem.Text = "Tarefas";
            tarefasMenuItem.Click += tarefasMenuItem_Click;
            // 
            // despesasToolStripMenuItem
            // 
            despesasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { despesasMenuItem, categoriasMenuItem });
            despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            despesasToolStripMenuItem.Size = new Size(154, 22);
            despesasToolStripMenuItem.Text = "Despesas";
            // 
            // despesasMenuItem
            // 
            despesasMenuItem.Name = "despesasMenuItem";
            despesasMenuItem.Size = new Size(130, 22);
            despesasMenuItem.Text = "Despesas";
            // 
            // categoriasMenuItem
            // 
            categoriasMenuItem.Name = "categoriasMenuItem";
            categoriasMenuItem.Size = new Size(130, 22);
            categoriasMenuItem.Text = "Categorias";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl_statusRodape });
            statusStrip1.Location = new Point(0, 359);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(633, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl_statusRodape
            // 
            lbl_statusRodape.Name = "lbl_statusRodape";
            lbl_statusRodape.Size = new Size(0, 17);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_inserir, btn_editar, btn_excluir, toolStripSeparator2, btn_addItem, btn_filtrar, btn_listarItens, toolStripSeparator1, btn_concluidos, btn_abertos, toolStripSeparator3, labelTipoCadastro });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(633, 45);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_inserir
            // 
            btn_inserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_inserir.Image = Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz24;
            btn_inserir.ImageScaling = ToolStripItemImageScaling.None;
            btn_inserir.ImageTransparentColor = Color.Magenta;
            btn_inserir.Name = "btn_inserir";
            btn_inserir.Padding = new Padding(7);
            btn_inserir.Size = new Size(42, 42);
            btn_inserir.Text = "Inserir";
            btn_inserir.Click += btnInserir_Click;
            // 
            // btn_editar
            // 
            btn_editar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_editar.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
            btn_editar.ImageScaling = ToolStripItemImageScaling.None;
            btn_editar.ImageTransparentColor = Color.Magenta;
            btn_editar.Name = "btn_editar";
            btn_editar.Padding = new Padding(7);
            btn_editar.Size = new Size(42, 42);
            btn_editar.Text = "Editar";
            btn_editar.Click += btnEditar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_excluir.Image = Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
            btn_excluir.ImageScaling = ToolStripItemImageScaling.None;
            btn_excluir.ImageTransparentColor = Color.Magenta;
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Padding = new Padding(7);
            btn_excluir.Size = new Size(42, 42);
            btn_excluir.Text = "Excluir";
            btn_excluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 45);
            // 
            // btn_addItem
            // 
            btn_addItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_addItem.Enabled = false;
            btn_addItem.Image = Properties.Resources.library_add_FILL0_wght400_GRAD0_opsz24;
            btn_addItem.ImageScaling = ToolStripItemImageScaling.None;
            btn_addItem.ImageTransparentColor = Color.Magenta;
            btn_addItem.Name = "btn_addItem";
            btn_addItem.Padding = new Padding(7);
            btn_addItem.Size = new Size(42, 42);
            btn_addItem.Text = "Adicionar Item";
            btn_addItem.ToolTipText = "Adicionar Item";
            btn_addItem.Click += btn_addItem_Click;
            // 
            // btn_listarItens
            // 
            btn_listarItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_listarItens.Enabled = false;
            btn_listarItens.Image = Properties.Resources.menu_open_FILL0_wght400_GRAD0_opsz24;
            btn_listarItens.ImageScaling = ToolStripItemImageScaling.None;
            btn_listarItens.ImageTransparentColor = Color.Magenta;
            btn_listarItens.Name = "btn_listarItens";
            btn_listarItens.Padding = new Padding(7);
            btn_listarItens.Size = new Size(42, 42);
            btn_listarItens.Text = "Visualizar Itens";
            btn_listarItens.ToolTipText = "Visualizar Itens";
            // 
            // btn_filtrar
            // 
            btn_filtrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_filtrar.Enabled = false;
            btn_filtrar.Image = Properties.Resources.filter_list_FILL0_wght400_GRAD0_opsz24;
            btn_filtrar.ImageScaling = ToolStripItemImageScaling.None;
            btn_filtrar.ImageTransparentColor = Color.Magenta;
            btn_filtrar.Name = "btn_filtrar";
            btn_filtrar.Padding = new Padding(7);
            btn_filtrar.Size = new Size(42, 42);
            btn_filtrar.Text = "Filtro";
            btn_filtrar.ToolTipText = "Filtro";
            btn_filtrar.Click += btn_filtrarTarefas_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
            // 
            // btn_concluidos
            // 
            btn_concluidos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_concluidos.Enabled = false;
            btn_concluidos.Image = Properties.Resources.done_all_FILL0_wght400_GRAD0_opsz24;
            btn_concluidos.ImageScaling = ToolStripItemImageScaling.None;
            btn_concluidos.ImageTransparentColor = Color.Magenta;
            btn_concluidos.Name = "btn_concluidos";
            btn_concluidos.Padding = new Padding(7);
            btn_concluidos.Size = new Size(42, 42);
            btn_concluidos.Text = "Visualizar itens concluidos";
            btn_concluidos.ToolTipText = "Visualizar itens concluidos";
            // 
            // btn_abertos
            // 
            btn_abertos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_abertos.Enabled = false;
            btn_abertos.Image = Properties.Resources.remove_done_FILL0_wght400_GRAD0_opsz24;
            btn_abertos.ImageScaling = ToolStripItemImageScaling.None;
            btn_abertos.ImageTransparentColor = Color.Magenta;
            btn_abertos.Name = "btn_abertos";
            btn_abertos.Padding = new Padding(7);
            btn_abertos.Size = new Size(42, 42);
            btn_abertos.Text = "Visualizar itens em abertos";
            btn_abertos.ToolTipText = "Visualizar itens em abertos";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 45);
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(75, 42);
            labelTipoCadastro.Text = "tipoCadastro";
            // 
            // pnl_principal
            // 
            pnl_principal.BackColor = Color.White;
            pnl_principal.BorderStyle = BorderStyle.FixedSingle;
            pnl_principal.Dock = DockStyle.Fill;
            pnl_principal.Location = new Point(0, 69);
            pnl_principal.Name = "pnl_principal";
            pnl_principal.Size = new Size(633, 290);
            pnl_principal.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 381);
            Controls.Add(pnl_principal);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Agenda 1.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosMenuItem;
        private ToolStripMenuItem contatosMenuItem;
        private ToolStripMenuItem compromissosMenuItem;
        private ToolStripMenuItem tarefasMenuItem;
        private ToolStripMenuItem despesasToolStripMenuItem;
        private ToolStripMenuItem despesasMenuItem;
        private ToolStripMenuItem categoriasMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl_statusRodape;
        private ToolStrip toolStrip1;
        private ToolStripButton btn_inserir;
        private ToolStripButton btn_editar;
        private ToolStripButton btn_excluir;
        private Panel pnl_principal;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel labelTipoCadastro;
        private ToolStripButton btn_listarItens;
        private ToolStripButton btn_filtrar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_addItem;
        private ToolStripButton btn_concluidos;
        private ToolStripButton btn_abertos;
        private ToolStripSeparator toolStripSeparator3;
    }
}