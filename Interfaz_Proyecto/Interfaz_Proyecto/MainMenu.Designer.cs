namespace Interfaz_Proyecto
{
    partial class MainMenu
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
            aFNSToolStripMenuItem = new ToolStripMenuItem();
            basicoToolStripMenuItem = new ToolStripMenuItem();
            unionToolStripMenuItem = new ToolStripMenuItem();
            concatenacionToolStripMenuItem = new ToolStripMenuItem();
            cerraduraToolStripMenuItem = new ToolStripMenuItem();
            cerraduraToolStripMenuItem1 = new ToolStripMenuItem();
            opcionalToolStripMenuItem = new ToolStripMenuItem();
            unionParaAnalizadorLexicoToolStripMenuItem = new ToolStripMenuItem();
            convertirAFNAAFDToolStripMenuItem = new ToolStripMenuItem();
            analizadorDeUnaCadenaToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aFNSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aFNSToolStripMenuItem
            // 
            aFNSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { basicoToolStripMenuItem, unionToolStripMenuItem, concatenacionToolStripMenuItem, cerraduraToolStripMenuItem, cerraduraToolStripMenuItem1, opcionalToolStripMenuItem, unionParaAnalizadorLexicoToolStripMenuItem, convertirAFNAAFDToolStripMenuItem, analizadorDeUnaCadenaToolStripMenuItem });
            aFNSToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aFNSToolStripMenuItem.Name = "aFNSToolStripMenuItem";
            aFNSToolStripMenuItem.Size = new Size(82, 34);
            aFNSToolStripMenuItem.Text = "AFN's";
            // 
            // basicoToolStripMenuItem
            // 
            basicoToolStripMenuItem.Name = "basicoToolStripMenuItem";
            basicoToolStripMenuItem.Size = new Size(367, 34);
            basicoToolStripMenuItem.Text = "Basico";
            basicoToolStripMenuItem.Click += basicoToolStripMenuItem_Click;
            // 
            // unionToolStripMenuItem
            // 
            unionToolStripMenuItem.Name = "unionToolStripMenuItem";
            unionToolStripMenuItem.Size = new Size(367, 34);
            unionToolStripMenuItem.Text = "Union";
            // 
            // concatenacionToolStripMenuItem
            // 
            concatenacionToolStripMenuItem.Name = "concatenacionToolStripMenuItem";
            concatenacionToolStripMenuItem.Size = new Size(367, 34);
            concatenacionToolStripMenuItem.Text = "Concatenacion";
            // 
            // cerraduraToolStripMenuItem
            // 
            cerraduraToolStripMenuItem.Name = "cerraduraToolStripMenuItem";
            cerraduraToolStripMenuItem.Size = new Size(367, 34);
            cerraduraToolStripMenuItem.Text = "Cerradura +";
            // 
            // cerraduraToolStripMenuItem1
            // 
            cerraduraToolStripMenuItem1.Name = "cerraduraToolStripMenuItem1";
            cerraduraToolStripMenuItem1.Size = new Size(367, 34);
            cerraduraToolStripMenuItem1.Text = "Cerradura *";
            // 
            // opcionalToolStripMenuItem
            // 
            opcionalToolStripMenuItem.Name = "opcionalToolStripMenuItem";
            opcionalToolStripMenuItem.Size = new Size(367, 34);
            opcionalToolStripMenuItem.Text = "Opcional";
            // 
            // unionParaAnalizadorLexicoToolStripMenuItem
            // 
            unionParaAnalizadorLexicoToolStripMenuItem.Name = "unionParaAnalizadorLexicoToolStripMenuItem";
            unionParaAnalizadorLexicoToolStripMenuItem.Size = new Size(367, 34);
            unionParaAnalizadorLexicoToolStripMenuItem.Text = "Union para analizador lexico";
            // 
            // convertirAFNAAFDToolStripMenuItem
            // 
            convertirAFNAAFDToolStripMenuItem.Name = "convertirAFNAAFDToolStripMenuItem";
            convertirAFNAAFDToolStripMenuItem.Size = new Size(367, 34);
            convertirAFNAAFDToolStripMenuItem.Text = "Convertir AFN a AFD";
            // 
            // analizadorDeUnaCadenaToolStripMenuItem
            // 
            analizadorDeUnaCadenaToolStripMenuItem.Name = "analizadorDeUnaCadenaToolStripMenuItem";
            analizadorDeUnaCadenaToolStripMenuItem.Size = new Size(367, 34);
            analizadorDeUnaCadenaToolStripMenuItem.Text = "Analizador de una cadena";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(603, 364);
            button1.Name = "button1";
            button1.Size = new Size(185, 74);
            button1.TabIndex = 1;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aFNSToolStripMenuItem;
        private ToolStripMenuItem basicoToolStripMenuItem;
        private ToolStripMenuItem unionToolStripMenuItem;
        private ToolStripMenuItem concatenacionToolStripMenuItem;
        private ToolStripMenuItem cerraduraToolStripMenuItem;
        private ToolStripMenuItem cerraduraToolStripMenuItem1;
        private ToolStripMenuItem opcionalToolStripMenuItem;
        private ToolStripMenuItem unionParaAnalizadorLexicoToolStripMenuItem;
        private ToolStripMenuItem convertirAFNAAFDToolStripMenuItem;
        private ToolStripMenuItem analizadorDeUnaCadenaToolStripMenuItem;
        private Button button1;
    }
}
