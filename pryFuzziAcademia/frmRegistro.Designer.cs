namespace pryFuzziAcademia
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbxPlan = new System.Windows.Forms.ComboBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(22, 40);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(40, 13);
            this.lblCode.TabIndex = 7;
            this.lblCode.Text = "Código";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nombre";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(22, 105);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(28, 13);
            this.lblPlan.TabIndex = 9;
            this.lblPlan.Text = "Plan";
            this.lblPlan.Click += new System.EventHandler(this.lblPlan_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(73, 37);
            this.txtCode.Mask = "00000";
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(36, 20);
            this.txtCode.TabIndex = 0;
            this.txtCode.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCode_MaskInputRejected);
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(73, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbxPlan
            // 
            this.cbxPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPlan.Enabled = false;
            this.cbxPlan.FormattingEnabled = true;
            this.cbxPlan.Location = new System.Drawing.Point(73, 102);
            this.cbxPlan.Name = "cbxPlan";
            this.cbxPlan.Size = new System.Drawing.Size(124, 21);
            this.cbxPlan.TabIndex = 2;
            this.cbxPlan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(22, 143);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(37, 13);
            this.lblActive.TabIndex = 10;
            this.lblActive.Text = "Activo";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(72, 143);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(15, 14);
            this.chkActive.TabIndex = 3;
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(23, 173);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Registrar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(271, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnBack
            // 
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(51, 20);
            this.btnBack.Text = "Volver";
            this.btnBack.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(104, 173);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Modificar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(185, 173);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Eliminar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 204);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.cbxPlan);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Asignatura";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.MaskedTextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbxPlan;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
    }
}