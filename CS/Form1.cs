using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace Sample___SelectedControlComboBox {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			PopulateComboBox(Controls, comboBoxEdit1);
		}

		private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {
			ComboBoxEdit comboBox = (ComboBoxEdit)sender;
			CmbItem item = (CmbItem)comboBox.SelectedItem;
			if(item == null)
				return;
			propertyGridControl1.SelectedObject = item.Component;
			
		}
		private void PopulateComboBox(Control.ControlCollection controls, ComboBoxEdit comboBox) {
			ArrayList items = new ArrayList(controls.Count);
			foreach(Control c in controls) {
			    if(c != null)
			        items.Add(new CmbItem(c));
			}
			((System.ComponentModel.ISupportInitialize)(comboBox.Properties)).BeginInit();
			try {
				comboBox.Properties.Items.Clear();
				comboBox.Properties.Items.AddRange(items.ToArray());
			} finally {
				((System.ComponentModel.ISupportInitialize)(comboBox.Properties)).EndInit();
			}
		}
	}
	class CmbItem {
		Control control;

		string DisplayTypeName {
			get { return control.GetType().Name; }
		}
		public IComponent Component {
			get { return control; }
		}
		public CmbItem(Control control) {
			this.control = control;
		}
		public override string ToString() {
			return string.Concat(control.Name, "   ", DisplayTypeName);
		}
	}
}