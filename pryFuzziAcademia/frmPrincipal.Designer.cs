namespace pryFuzziAcademia
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
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.btnRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListado = new System.Windows.Forms.ToolStripMenuItem();
            this.stsMenu = new System.Windows.Forms.StatusStrip();
            this.lblDateNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.mstMenu.SuspendLayout();
            this.stsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMenu
            // 
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistro,
            this.btnListado});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(336, 24);
            this.mstMenu.TabIndex = 0;
            this.mstMenu.Text = "menuStrip1";
            // 
            // btnRegistro
            // 
            this.btnRegistro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAlumno,
            this.btnMateria,
            this.btnPlan});
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(62, 20);
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnAlumno
            // 
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(180, 22);
            this.btnAlumno.Text = "Alumno";
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // btnMateria
            // 
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(180, 22);
            this.btnMateria.Text = "Materia";
            this.btnMateria.Click += new System.EventHandler(this.btnMateria_Click);
            // 
            // btnPlan
            // 
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(180, 22);
            this.btnPlan.Text = "Plan de estudio";
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // btnListado
            // 
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(57, 20);
            this.btnListado.Text = "Listado";
            this.btnListado.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // stsMenu
            // 
            this.stsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDateNow});
            this.stsMenu.Location = new System.Drawing.Point(0, 113);
            this.stsMenu.Name = "stsMenu";
            this.stsMenu.Size = new System.Drawing.Size(336, 22);
            this.stsMenu.TabIndex = 1;
            this.stsMenu.Text = "statusStrip1";
            this.stsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.stsMenu_ItemClicked);
            // 
            // lblDateNow
            // 
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(12, 17);
            this.lblDateNow.Text = "-";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryFuzziAcademia.Properties.Resources._12123132;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(336, 135);
            this.Controls.Add(this.stsMenu);
            this.Controls.Add(this.mstMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstMenu;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.stsMenu.ResumeLayout(false);
            this.stsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.ToolStripMenuItem btnRegistro;
        private System.Windows.Forms.ToolStripMenuItem btnAlumno;
        private System.Windows.Forms.ToolStripMenuItem btnMateria;
        private System.Windows.Forms.ToolStripMenuItem btnPlan;
        private System.Windows.Forms.ToolStripMenuItem btnListado;
        private System.Windows.Forms.StatusStrip stsMenu;
        private System.Windows.Forms.ToolStripStatusLabel lblDateNow;
    }
}