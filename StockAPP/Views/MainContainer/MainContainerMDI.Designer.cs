namespace StockAPP
{
    partial class MainContainerMDI
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
            menuStripMDI = new MenuStrip();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            menuStripMDI.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMDI
            // 
            menuStripMDI.Items.AddRange(new ToolStripItem[] { estoqueToolStripMenuItem });
            menuStripMDI.Location = new Point(0, 0);
            menuStripMDI.Name = "menuStripMDI";
            menuStripMDI.Size = new Size(800, 24);
            menuStripMDI.TabIndex = 1;
            menuStripMDI.Text = "menuStripMDI";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtosToolStripMenuItem, cadastroToolStripMenuItem });
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(61, 20);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(180, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(180, 22);
            cadastroToolStripMenuItem.Text = "Cadastro";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // MainContainerMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStripMDI);
            IsMdiContainer = true;
            MainMenuStrip = menuStripMDI;
            Name = "MainContainerMDI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Estoque";
            WindowState = FormWindowState.Maximized;
            menuStripMDI.ResumeLayout(false);
            menuStripMDI.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMDI;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
    }
}
