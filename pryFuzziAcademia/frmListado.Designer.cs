namespace pryFuzziAcademia
{
    partial class frmListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.cbxPlanSearch = new System.Windows.Forms.ComboBox();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.txtCodeSearch = new System.Windows.Forms.MaskedTextBox();
            this.rbtPlanSearch = new System.Windows.Forms.RadioButton();
            this.rbtNameSearch = new System.Windows.Forms.RadioButton();
            this.rbtCodeSearch = new System.Windows.Forms.RadioButton();
            this.rbtAllSearch = new System.Windows.Forms.RadioButton();
            this.btnListSearch = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.cbxPlanSearch);
            this.gbxSearch.Controls.Add(this.txtNameSearch);
            this.gbxSearch.Controls.Add(this.txtCodeSearch);
            this.gbxSearch.Controls.Add(this.rbtPlanSearch);
            this.gbxSearch.Controls.Add(this.rbtNameSearch);
            this.gbxSearch.Controls.Add(this.rbtCodeSearch);
            this.gbxSearch.Controls.Add(this.rbtAllSearch);
            this.gbxSearch.Location = new System.Drawing.Point(9, 6);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(200, 127);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Buscar";
            this.gbxSearch.Enter += new System.EventHandler(this.gbxSearch_Enter);
            // 
            // cbxPlanSearch
            // 
            this.cbxPlanSearch.FormattingEnabled = true;
            this.cbxPlanSearch.Location = new System.Drawing.Point(71, 93);
            this.cbxPlanSearch.Name = "cbxPlanSearch";
            this.cbxPlanSearch.Size = new System.Drawing.Size(96, 21);
            this.cbxPlanSearch.TabIndex = 6;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(71, 68);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(96, 20);
            this.txtNameSearch.TabIndex = 5;
            // 
            // txtCodeSearch
            // 
            this.txtCodeSearch.Location = new System.Drawing.Point(71, 44);
            this.txtCodeSearch.Mask = "00000";
            this.txtCodeSearch.Name = "txtCodeSearch";
            this.txtCodeSearch.Size = new System.Drawing.Size(36, 20);
            this.txtCodeSearch.TabIndex = 4;
            // 
            // rbtPlanSearch
            // 
            this.rbtPlanSearch.AutoSize = true;
            this.rbtPlanSearch.Location = new System.Drawing.Point(6, 94);
            this.rbtPlanSearch.Name = "rbtPlanSearch";
            this.rbtPlanSearch.Size = new System.Drawing.Size(46, 17);
            this.rbtPlanSearch.TabIndex = 3;
            this.rbtPlanSearch.TabStop = true;
            this.rbtPlanSearch.Text = "Plan";
            this.rbtPlanSearch.UseVisualStyleBackColor = true;
            // 
            // rbtNameSearch
            // 
            this.rbtNameSearch.AutoSize = true;
            this.rbtNameSearch.Location = new System.Drawing.Point(6, 69);
            this.rbtNameSearch.Name = "rbtNameSearch";
            this.rbtNameSearch.Size = new System.Drawing.Size(62, 17);
            this.rbtNameSearch.TabIndex = 2;
            this.rbtNameSearch.TabStop = true;
            this.rbtNameSearch.Text = "Nombre";
            this.rbtNameSearch.UseVisualStyleBackColor = true;
            // 
            // rbtCodeSearch
            // 
            this.rbtCodeSearch.AutoSize = true;
            this.rbtCodeSearch.Location = new System.Drawing.Point(6, 45);
            this.rbtCodeSearch.Name = "rbtCodeSearch";
            this.rbtCodeSearch.Size = new System.Drawing.Size(58, 17);
            this.rbtCodeSearch.TabIndex = 1;
            this.rbtCodeSearch.TabStop = true;
            this.rbtCodeSearch.Text = "Código";
            this.rbtCodeSearch.UseVisualStyleBackColor = true;
            // 
            // rbtAllSearch
            // 
            this.rbtAllSearch.AutoSize = true;
            this.rbtAllSearch.Location = new System.Drawing.Point(6, 23);
            this.rbtAllSearch.Name = "rbtAllSearch";
            this.rbtAllSearch.Size = new System.Drawing.Size(50, 17);
            this.rbtAllSearch.TabIndex = 0;
            this.rbtAllSearch.TabStop = true;
            this.rbtAllSearch.Text = "Todo";
            this.rbtAllSearch.UseVisualStyleBackColor = true;
            // 
            // btnListSearch
            // 
            this.btnListSearch.Location = new System.Drawing.Point(137, 139);
            this.btnListSearch.Name = "btnListSearch";
            this.btnListSearch.Size = new System.Drawing.Size(75, 23);
            this.btnListSearch.TabIndex = 1;
            this.btnListSearch.Text = "Buscar";
            this.btnListSearch.UseVisualStyleBackColor = true;
            this.btnListSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCode,
            this.clmName,
            this.clmSubj,
            this.clmActive});
            this.dgvGrilla.Location = new System.Drawing.Point(218, 6);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(443, 156);
            this.dgvGrilla.TabIndex = 2;
            this.dgvGrilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellContentClick);
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Código";
            this.clmCode.Name = "clmCode";
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Nombre";
            this.clmName.Name = "clmName";
            // 
            // clmSubj
            // 
            this.clmSubj.HeaderText = "Materia";
            this.clmSubj.Name = "clmSubj";
            // 
            // clmActive
            // 
            this.clmActive.HeaderText = "Activo";
            this.clmActive.Name = "clmActive";
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 167);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.btnListSearch);
            this.Controls.Add(this.gbxSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.MaskedTextBox txtCodeSearch;
        private System.Windows.Forms.RadioButton rbtPlanSearch;
        private System.Windows.Forms.RadioButton rbtNameSearch;
        private System.Windows.Forms.RadioButton rbtCodeSearch;
        private System.Windows.Forms.RadioButton rbtAllSearch;
        private System.Windows.Forms.ComboBox cbxPlanSearch;
        private System.Windows.Forms.Button btnListSearch;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubj;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmActive;
    }
}