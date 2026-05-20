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
            this.btnCancelPlan = new System.Windows.Forms.Button();
            this.btnLoadPlan = new System.Windows.Forms.Button();
            this.txtPlanName = new System.Windows.Forms.TextBox();
            this.lblPlanName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelPlan
            // 
            this.btnCancelPlan.Location = new System.Drawing.Point(86, 85);
            this.btnCancelPlan.Name = "btnCancelPlan";
            this.btnCancelPlan.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPlan.TabIndex = 0;
            this.btnCancelPlan.Text = "Cancelar";
            this.btnCancelPlan.UseVisualStyleBackColor = true;
            // 
            // btnLoadPlan
            // 
            this.btnLoadPlan.Location = new System.Drawing.Point(167, 85);
            this.btnLoadPlan.Name = "btnLoadPlan";
            this.btnLoadPlan.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPlan.TabIndex = 1;
            this.btnLoadPlan.Text = "Cargar";
            this.btnLoadPlan.UseVisualStyleBackColor = true;
            this.btnLoadPlan.Click += new System.EventHandler(this.btnLoadPlan_Click);
            // 
            // txtPlanName
            // 
            this.txtPlanName.Location = new System.Drawing.Point(92, 43);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(108, 20);
            this.txtPlanName.TabIndex = 2;
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Location = new System.Drawing.Point(39, 46);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(47, 13);
            this.lblPlanName.TabIndex = 3;
            this.lblPlanName.Text = "Nombre:";
            // 
            // frmCargaPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 117);
            this.Controls.Add(this.lblPlanName);
            this.Controls.Add(this.txtPlanName);
            this.Controls.Add(this.btnLoadPlan);
            this.Controls.Add(this.btnCancelPlan);
            this.Name = "frmCargaPlan";
            this.Text = "Cargar Plan de Estudio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelPlan;
        private System.Windows.Forms.Button btnLoadPlan;
        private System.Windows.Forms.TextBox txtPlanName;
        private System.Windows.Forms.Label lblPlanName;
    }
}