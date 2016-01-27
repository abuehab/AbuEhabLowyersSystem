namespace AbuEhab.LowyersSystem.Interface.Forms.Lowyers_Forms
{
    partial class FrmLowyers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.اضافةمحاميToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.طباعـــــةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تحـــديثToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(890, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةمحاميToolStripMenuItem,
            this.طباعـــــةToolStripMenuItem,
            this.تحـــديثToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(901, 37);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // اضافةمحاميToolStripMenuItem
            // 
            this.اضافةمحاميToolStripMenuItem.Name = "اضافةمحاميToolStripMenuItem";
            this.اضافةمحاميToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.اضافةمحاميToolStripMenuItem.Text = "اضافة محامي";
            // 
            // طباعـــــةToolStripMenuItem
            // 
            this.طباعـــــةToolStripMenuItem.Name = "طباعـــــةToolStripMenuItem";
            this.طباعـــــةToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.طباعـــــةToolStripMenuItem.Text = "طباعـــــة ";
            // 
            // تحـــديثToolStripMenuItem
            // 
            this.تحـــديثToolStripMenuItem.Name = "تحـــديثToolStripMenuItem";
            this.تحـــديثToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.تحـــديثToolStripMenuItem.Text = "تحـــديث";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "الاســم";
            this.Column2.Name = "Column2";
            // 
            // FrmLowyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 478);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmLowyers";
            this.Text = "FrmLowyers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem اضافةمحاميToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem طباعـــــةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تحـــديثToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}