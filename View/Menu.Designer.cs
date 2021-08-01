namespace CrudBD
{
    partial class frmMenu
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.btnReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHospedes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAtividades = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuartos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefeicoes = new System.Windows.Forms.ToolStripMenuItem();
            panelForms = new System.Windows.Forms.Panel();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.PowderBlue;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharToolStripMenuItem,
            this.btnReservas,
            this.btnHospedes,
            this.btnFuncionarios,
            this.btnAtividades,
            this.btnProdutos,
            this.btnServicos,
            this.btnQuartos,
            this.btnRefeicoes});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Margin = new System.Windows.Forms.Padding(10);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5);
            this.menuStrip.Size = new System.Drawing.Size(1054, 66);
            this.menuStrip.TabIndex = 0;
            // 
            // btnReservas
            // 
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(120, 56);
            this.btnReservas.Text = "Reservas";
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnHospedes
            // 
            this.btnHospedes.Name = "btnHospedes";
            this.btnHospedes.Size = new System.Drawing.Size(134, 56);
            this.btnHospedes.Text = "Hóspedes";
            this.btnHospedes.Click += new System.EventHandler(this.btnHospedes_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(164, 56);
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnAtividades
            // 
            this.btnAtividades.Name = "btnAtividades";
            this.btnAtividades.Size = new System.Drawing.Size(139, 56);
            this.btnAtividades.Text = "Atividades";
            this.btnAtividades.Click += new System.EventHandler(this.btnAtividades_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(124, 56);
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(116, 56);
            this.btnServicos.Text = "Serviços";
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnQuartos
            // 
            this.btnQuartos.Name = "btnQuartos";
            this.btnQuartos.Size = new System.Drawing.Size(113, 56);
            this.btnQuartos.Text = "Quartos";
            this.btnQuartos.Click += new System.EventHandler(this.btnQuartos_Click);
            // 
            // btnRefeicoes
            // 
            this.btnRefeicoes.Name = "btnRefeicoes";
            this.btnRefeicoes.Size = new System.Drawing.Size(130, 56);
            this.btnRefeicoes.Text = "Refeições";
            // 
            // panelForms
            // 
            panelForms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panelForms.Location = new System.Drawing.Point(9, 98);
            panelForms.Margin = new System.Windows.Forms.Padding(0);
            panelForms.Name = "panelForms";
            panelForms.Size = new System.Drawing.Size(1033, 380);
            panelForms.TabIndex = 1;
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fecharToolStripMenuItem.Image = global::CrudBD.Properties.Resources.close;
            this.fecharToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(117, 56);
            this.fecharToolStripMenuItem.Text = " Sair";
            this.fecharToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1054, 479);
            this.Controls.Add(panelForms);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem btnHospedes;
        private System.Windows.Forms.ToolStripMenuItem btnAtividades;
        private System.Windows.Forms.ToolStripMenuItem btnProdutos;
        private System.Windows.Forms.ToolStripMenuItem btnServicos;
        private System.Windows.Forms.ToolStripMenuItem btnQuartos;
        private System.Windows.Forms.ToolStripMenuItem btnRefeicoes;
        private System.Windows.Forms.ToolStripMenuItem btnReservas;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        public static System.Windows.Forms.Panel panelForms;
    }
}