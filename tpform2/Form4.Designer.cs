namespace tpform2
{
    partial class Form4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agrantirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.layoutToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.calculatriceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem,
            this.form3ToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.menuToolStripMenuItem.Text = "Forms";
            // 
            // form1ToolStripMenuItem
            // 
            this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            this.form1ToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.form1ToolStripMenuItem.Text = "Form2";
            this.form1ToolStripMenuItem.Click += new System.EventHandler(this.form1ToolStripMenuItem_Click);
            // 
            // form3ToolStripMenuItem
            // 
            this.form3ToolStripMenuItem.Name = "form3ToolStripMenuItem";
            this.form3ToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.form3ToolStripMenuItem.Text = "Form3";
            this.form3ToolStripMenuItem.Click += new System.EventHandler(this.form3ToolStripMenuItem_Click);
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.layoutToolStripMenuItem.Text = "Layout";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reduireToolStripMenuItem,
            this.agrantirToolStripMenuItem,
            this.fermerToolStripMenuItem1});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // reduireToolStripMenuItem
            // 
            this.reduireToolStripMenuItem.Name = "reduireToolStripMenuItem";
            this.reduireToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.reduireToolStripMenuItem.Text = "Reduire";
            this.reduireToolStripMenuItem.Click += new System.EventHandler(this.reduireToolStripMenuItem_Click);
            // 
            // agrantirToolStripMenuItem
            // 
            this.agrantirToolStripMenuItem.Name = "agrantirToolStripMenuItem";
            this.agrantirToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.agrantirToolStripMenuItem.Text = "Agrantir";
            this.agrantirToolStripMenuItem.Click += new System.EventHandler(this.agrantirToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem1
            // 
            this.fermerToolStripMenuItem1.Name = "fermerToolStripMenuItem1";
            this.fermerToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.fermerToolStripMenuItem1.Text = "Fermer";
            this.fermerToolStripMenuItem1.Click += new System.EventHandler(this.fermerToolStripMenuItem1_Click);
            // 
            // calculatriceToolStripMenuItem
            // 
            this.calculatriceToolStripMenuItem.Name = "calculatriceToolStripMenuItem";
            this.calculatriceToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.calculatriceToolStripMenuItem.Text = "Calculatrice";
            this.calculatriceToolStripMenuItem.Click += new System.EventHandler(this.calculatriceToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(654, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 419);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reduireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agrantirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem1;
    }
}