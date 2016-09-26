namespace BiblioReg
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bIBLIOREGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMINISTRACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANUALDEUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCERCADEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bIBLIOREGToolStripMenuItem,
            this.aDMINISTRACIONToolStripMenuItem,
            this.mANUALDEUSUARIOToolStripMenuItem,
            this.aCERCADEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bIBLIOREGToolStripMenuItem
            // 
            this.bIBLIOREGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.bIBLIOREGToolStripMenuItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIBLIOREGToolStripMenuItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.bIBLIOREGToolStripMenuItem.Name = "bIBLIOREGToolStripMenuItem";
            this.bIBLIOREGToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.bIBLIOREGToolStripMenuItem.Text = "BIBLIOREG";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // aDMINISTRACIONToolStripMenuItem
            // 
            this.aDMINISTRACIONToolStripMenuItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDMINISTRACIONToolStripMenuItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.aDMINISTRACIONToolStripMenuItem.Name = "aDMINISTRACIONToolStripMenuItem";
            this.aDMINISTRACIONToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.aDMINISTRACIONToolStripMenuItem.Text = "REGISTRO";
            this.aDMINISTRACIONToolStripMenuItem.Click += new System.EventHandler(this.aDMINISTRACIONToolStripMenuItem_Click);
            // 
            // mANUALDEUSUARIOToolStripMenuItem
            // 
            this.mANUALDEUSUARIOToolStripMenuItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mANUALDEUSUARIOToolStripMenuItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.mANUALDEUSUARIOToolStripMenuItem.Name = "mANUALDEUSUARIOToolStripMenuItem";
            this.mANUALDEUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.mANUALDEUSUARIOToolStripMenuItem.Text = "MANUAL DE USUARIO";
            this.mANUALDEUSUARIOToolStripMenuItem.Click += new System.EventHandler(this.mANUALDEUSUARIOToolStripMenuItem_Click);
            // 
            // aCERCADEToolStripMenuItem
            // 
            this.aCERCADEToolStripMenuItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCERCADEToolStripMenuItem.ForeColor = System.Drawing.Color.SeaGreen;
            this.aCERCADEToolStripMenuItem.Name = "aCERCADEToolStripMenuItem";
            this.aCERCADEToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.aCERCADEToolStripMenuItem.Text = "ACERCA DE..";
            this.aCERCADEToolStripMenuItem.Click += new System.EventHandler(this.aCERCADEToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(708, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "BIBLIOREG";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 400);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "BIBLIOREG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bIBLIOREGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANUALDEUSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCERCADEToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}