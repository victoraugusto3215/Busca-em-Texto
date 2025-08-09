namespace BuscaTexto {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forçaBrutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rabinKarpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boyerMooreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.texto = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cbx_localizarSubstituir = new System.Windows.Forms.CheckBox();
            this.lbl_substituir = new System.Windows.Forms.Label();
            this.txt_substituir = new System.Windows.Forms.TextBox();
            this.cbx_caseSensitive = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.pesquisarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 60, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(803, 81);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.novoToolStripMenuItem.Text = "&Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.abrirToolStripMenuItem.Text = "A&brir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forçaBrutaToolStripMenuItem,
            this.rabinKarpToolStripMenuItem,
            this.kMPToolStripMenuItem,
            this.boyerMooreToolStripMenuItem});
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.pesquisarToolStripMenuItem.Text = "&Pesquisar";
            // 
            // forçaBrutaToolStripMenuItem
            // 
            this.forçaBrutaToolStripMenuItem.Name = "forçaBrutaToolStripMenuItem";
            this.forçaBrutaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.forçaBrutaToolStripMenuItem.Text = "Força Bruta";
            this.forçaBrutaToolStripMenuItem.Click += new System.EventHandler(this.forçaBrutaToolStripMenuItem_Click);
            // 
            // rabinKarpToolStripMenuItem
            // 
            this.rabinKarpToolStripMenuItem.Name = "rabinKarpToolStripMenuItem";
            this.rabinKarpToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.rabinKarpToolStripMenuItem.Text = "Rabin-Karp";
            this.rabinKarpToolStripMenuItem.Click += new System.EventHandler(this.rabinKarpToolStripMenuItem_Click);
            // 
            // kMPToolStripMenuItem
            // 
            this.kMPToolStripMenuItem.Name = "kMPToolStripMenuItem";
            this.kMPToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.kMPToolStripMenuItem.Text = "KMP";
            this.kMPToolStripMenuItem.Click += new System.EventHandler(this.kMPToolStripMenuItem_Click);
            // 
            // boyerMooreToolStripMenuItem
            // 
            this.boyerMooreToolStripMenuItem.Name = "boyerMooreToolStripMenuItem";
            this.boyerMooreToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.boyerMooreToolStripMenuItem.Text = "Boyer-Moore";
            this.boyerMooreToolStripMenuItem.Click += new System.EventHandler(this.boyerMooreToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.ajudaToolStripMenuItem.Text = "A&juda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.ShortcutKeyDisplayString = "F1";
            this.sobreToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.sobreToolStripMenuItem.Text = "S&obre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // texto
            // 
            this.texto.BackColor = System.Drawing.Color.Gainsboro;
            this.texto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.ForeColor = System.Drawing.Color.Black;
            this.texto.Location = new System.Drawing.Point(0, 81);
            this.texto.Name = "texto";
            this.texto.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.texto.Size = new System.Drawing.Size(803, 465);
            this.texto.TabIndex = 0;
            this.texto.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Arquivo de Texto (*.txt)|*.txt";
            // 
            // cbx_localizarSubstituir
            // 
            this.cbx_localizarSubstituir.AutoSize = true;
            this.cbx_localizarSubstituir.BackColor = System.Drawing.SystemColors.Control;
            this.cbx_localizarSubstituir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_localizarSubstituir.Location = new System.Drawing.Point(427, 59);
            this.cbx_localizarSubstituir.Name = "cbx_localizarSubstituir";
            this.cbx_localizarSubstituir.Size = new System.Drawing.Size(134, 19);
            this.cbx_localizarSubstituir.TabIndex = 3;
            this.cbx_localizarSubstituir.Text = "Localizar e Substituir";
            this.cbx_localizarSubstituir.UseVisualStyleBackColor = false;
            this.cbx_localizarSubstituir.CheckedChanged += new System.EventHandler(this.cbx_localizarSubstituir_CheckedChanged);
            // 
            // lbl_substituir
            // 
            this.lbl_substituir.AutoSize = true;
            this.lbl_substituir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_substituir.Location = new System.Drawing.Point(565, 55);
            this.lbl_substituir.Name = "lbl_substituir";
            this.lbl_substituir.Size = new System.Drawing.Size(81, 15);
            this.lbl_substituir.TabIndex = 5;
            this.lbl_substituir.Text = "Substituir por:";
            this.lbl_substituir.Visible = false;
            // 
            // txt_substituir
            // 
            this.txt_substituir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_substituir.Location = new System.Drawing.Point(646, 52);
            this.txt_substituir.Name = "txt_substituir";
            this.txt_substituir.Size = new System.Drawing.Size(138, 23);
            this.txt_substituir.TabIndex = 4;
            this.txt_substituir.Visible = false;
            // 
            // cbx_caseSensitive
            // 
            this.cbx_caseSensitive.AutoSize = true;
            this.cbx_caseSensitive.BackColor = System.Drawing.SystemColors.Control;
            this.cbx_caseSensitive.Checked = true;
            this.cbx_caseSensitive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_caseSensitive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_caseSensitive.Location = new System.Drawing.Point(181, 60);
            this.cbx_caseSensitive.Name = "cbx_caseSensitive";
            this.cbx_caseSensitive.Size = new System.Drawing.Size(224, 19);
            this.cbx_caseSensitive.TabIndex = 2;
            this.cbx_caseSensitive.Text = "Diferenciar Maiúsculas de Minúsculas";
            this.cbx_caseSensitive.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BuscaTexto.Properties.Resources.cotebas;
            this.pictureBox1.Location = new System.Drawing.Point(310, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 60);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "72300574 - VICTOR AUGUSTO DIAS MENDES DO VALLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "72301112 - GUSTAVO HENRIQUE PEREIRA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 546);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbx_caseSensitive);
            this.Controls.Add(this.txt_substituir);
            this.Controls.Add(this.lbl_substituir);
            this.Controls.Add(this.cbx_localizarSubstituir);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(819, 585);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabalho Prático - Busca em Texto 2025.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.RichTextBox texto;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem forçaBrutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rabinKarpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boyerMooreToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbx_localizarSubstituir;
        private System.Windows.Forms.Label lbl_substituir;
        private System.Windows.Forms.TextBox txt_substituir;
        private System.Windows.Forms.CheckBox cbx_caseSensitive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

