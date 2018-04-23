namespace Sample___SelectedControlComboBox {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
			this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
			((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxEdit1
			// 
			this.comboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Top;
			this.comboBoxEdit1.Location = new System.Drawing.Point(0, 0);
			this.comboBoxEdit1.Name = "comboBoxEdit1";
			this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.comboBoxEdit1.Size = new System.Drawing.Size(492, 20);
			this.comboBoxEdit1.TabIndex = 1;
			this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
			// 
			// propertyGridControl1
			// 
			this.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGridControl1.Location = new System.Drawing.Point(0, 20);
			this.propertyGridControl1.Name = "propertyGridControl1";
			this.propertyGridControl1.ServiceProvider = null;
			this.propertyGridControl1.Size = new System.Drawing.Size(492, 246);
			this.propertyGridControl1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 266);
			this.Controls.Add(this.propertyGridControl1);
			this.Controls.Add(this.comboBoxEdit1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
		private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
	}
}

