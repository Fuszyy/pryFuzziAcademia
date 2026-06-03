namespace pryFuzziAcademia
{
    partial class frmCargaPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaPlan));
            this.btnCancelPlan = new System.Windows.Forms.Button();
            this.btnLoadPlan = new System.Windows.Forms.Button();
            this.txtPlanName = new System.Windows.Forms.TextBox();
            this.lblPlanName = new System.Windows.Forms.Label();
            this.btnPlanList = new System.Windows.Forms.Button();
            this.lstPlans = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelPlan
            // 
            this.btnCancelPlan.Location = new System.Drawing.Point(89, 135);
            this.btnCancelPlan.Name = "btnCancelPlan";
            this.btnCancelPlan.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPlan.TabIndex = 0;
            this.btnCancelPlan.Text = "Cancelar";
            this.btnCancelPlan.UseVisualStyleBackColor = true;
            this.btnCancelPlan.Click += new System.EventHandler(this.btnCancelPlan_Click);
            // 
            // btnLoadPlan
            // 
            this.btnLoadPlan.Location = new System.Drawing.Point(170, 135);
            this.btnLoadPlan.Name = "btnLoadPlan";
            this.btnLoadPlan.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPlan.TabIndex = 1;
            this.btnLoadPlan.Text = "Cargar";
            this.btnLoadPlan.UseVisualStyleBackColor = true;
            this.btnLoadPlan.Click += new System.EventHandler(this.btnLoadPlan_Click);
            // 
            // txtPlanName
            // 
            this.txtPlanName.Location = new System.Drawing.Point(62, 34);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(108, 20);
            this.txtPlanName.TabIndex = 2;
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Location = new System.Drawing.Point(9, 37);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(47, 13);
            this.lblPlanName.TabIndex = 3;
            this.lblPlanName.Text = "Nombre:";
            // 
            // btnPlanList
            // 
            this.btnPlanList.Location = new System.Drawing.Point(8, 135);
            this.btnPlanList.Name = "btnPlanList";
            this.btnPlanList.Size = new System.Drawing.Size(75, 23);
            this.btnPlanList.TabIndex = 4;
            this.btnPlanList.Text = "Listar";
            this.btnPlanList.UseVisualStyleBackColor = true;
            this.btnPlanList.Click += new System.EventHandler(this.btnPlanList_Click);
            // 
            // lstPlans
            // 
            this.lstPlans.FormattingEnabled = true;
            this.lstPlans.Location = new System.Drawing.Point(12, 60);
            this.lstPlans.Name = "lstPlans";
            this.lstPlans.Size = new System.Drawing.Size(158, 69);
            this.lstPlans.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(258, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnBack
            // 
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(51, 20);
            this.btnBack.Text = "Volver";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // frmCargaPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 168);
            this.Controls.Add(this.lstPlans);
            this.Controls.Add(this.btnPlanList);
            this.Controls.Add(this.lblPlanName);
            this.Controls.Add(this.txtPlanName);
            this.Controls.Add(this.btnLoadPlan);
            this.Controls.Add(this.btnCancelPlan);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCargaPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Plan de Estudio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelPlan;
        private System.Windows.Forms.Button btnLoadPlan;
        private System.Windows.Forms.TextBox txtPlanName;
        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.Button btnPlanList;
        private System.Windows.Forms.ListBox lstPlans;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
    }
}