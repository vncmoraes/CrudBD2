
namespace CrudBD
{
    partial class frmAlterarAtividade
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
            this.txtHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAlterarAtividade = new System.Windows.Forms.Button();
            this.lblHoraFim = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtIdAtividade = new System.Windows.Forms.TextBox();
            this.lblidAtividade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHoraFim
            // 
            this.txtHoraFim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraFim.Location = new System.Drawing.Point(442, 238);
            this.txtHoraFim.Mask = "00:00:00";
            this.txtHoraFim.Name = "txtHoraFim";
            this.txtHoraFim.Size = new System.Drawing.Size(140, 30);
            this.txtHoraFim.TabIndex = 33;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraInicio.Location = new System.Drawing.Point(277, 238);
            this.txtHoraInicio.Mask = "00:00:00";
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(140, 30);
            this.txtHoraInicio.TabIndex = 32;
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = true;
            this.btnFechar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(817, 230);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(79, 38);
            this.btnFechar.TabIndex = 31;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAlterarAtividade
            // 
            this.btnAlterarAtividade.AutoSize = true;
            this.btnAlterarAtividade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAlterarAtividade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarAtividade.Location = new System.Drawing.Point(626, 229);
            this.btnAlterarAtividade.Name = "btnAlterarAtividade";
            this.btnAlterarAtividade.Size = new System.Drawing.Size(170, 38);
            this.btnAlterarAtividade.TabIndex = 30;
            this.btnAlterarAtividade.Text = "Alterar Atividade";
            this.btnAlterarAtividade.UseVisualStyleBackColor = true;
            this.btnAlterarAtividade.Click += new System.EventHandler(this.btnAlterarAtividade_Click);
            // 
            // lblHoraFim
            // 
            this.lblHoraFim.AutoSize = true;
            this.lblHoraFim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFim.Location = new System.Drawing.Point(438, 211);
            this.lblHoraFim.Name = "lblHoraFim";
            this.lblHoraFim.Size = new System.Drawing.Size(83, 23);
            this.lblHoraFim.TabIndex = 29;
            this.lblHoraFim.Text = "Hora Fim:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(273, 211);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(97, 23);
            this.lblHoraInicio.TabIndex = 28;
            this.lblHoraInicio.Text = "Hora Início:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(137, 237);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(111, 30);
            this.txtValor.TabIndex = 27;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(133, 211);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(53, 23);
            this.lblValor.TabIndex = 26;
            this.lblValor.Text = "Valor:";
            // 
            // txtLocal
            // 
            this.txtLocal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocal.Location = new System.Drawing.Point(756, 139);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(143, 30);
            this.txtLocal.TabIndex = 25;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(752, 113);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(53, 23);
            this.lblLocal.TabIndex = 24;
            this.lblLocal.Text = "Local:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(560, 139);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(170, 30);
            this.txtEmpresa.TabIndex = 23;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(556, 113);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(75, 23);
            this.lblEmpresa.TabIndex = 22;
            this.lblEmpresa.Text = "Empresa";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(277, 139);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(254, 30);
            this.txtDescricao.TabIndex = 21;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(273, 113);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(87, 23);
            this.lblDescricao.TabIndex = 20;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtIdAtividade
            // 
            this.txtIdAtividade.Enabled = false;
            this.txtIdAtividade.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAtividade.Location = new System.Drawing.Point(137, 139);
            this.txtIdAtividade.Name = "txtIdAtividade";
            this.txtIdAtividade.Size = new System.Drawing.Size(111, 30);
            this.txtIdAtividade.TabIndex = 19;
            // 
            // lblidAtividade
            // 
            this.lblidAtividade.AutoSize = true;
            this.lblidAtividade.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidAtividade.Location = new System.Drawing.Point(133, 113);
            this.lblidAtividade.Name = "lblidAtividade";
            this.lblidAtividade.Size = new System.Drawing.Size(107, 23);
            this.lblidAtividade.TabIndex = 18;
            this.lblidAtividade.Text = "ID Atividade:";
            // 
            // frmAlterarAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1033, 380);
            this.Controls.Add(this.txtHoraFim);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAlterarAtividade);
            this.Controls.Add(this.lblHoraFim);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtIdAtividade);
            this.Controls.Add(this.lblidAtividade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlterarAtividade";
            this.ShowIcon = false;
            this.Text = "AlterarAtividade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox txtHoraFim;
        public System.Windows.Forms.MaskedTextBox txtHoraInicio;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAlterarAtividade;
        private System.Windows.Forms.Label lblHoraFim;
        private System.Windows.Forms.Label lblHoraInicio;
        public System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        public System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblLocal;
        public System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        public System.Windows.Forms.TextBox txtIdAtividade;
        private System.Windows.Forms.Label lblidAtividade;
    }
}