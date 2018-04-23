Imports Microsoft.VisualBasic
Imports System
Namespace Sample___SelectedControlComboBox
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' comboBoxEdit1
			' 
			Me.comboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Top
			Me.comboBoxEdit1.Location = New System.Drawing.Point(0, 0)
			Me.comboBoxEdit1.Name = "comboBoxEdit1"
			Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBoxEdit1.Size = New System.Drawing.Size(492, 20)
			Me.comboBoxEdit1.TabIndex = 1
'			Me.comboBoxEdit1.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEdit1_SelectedIndexChanged);
			' 
			' propertyGridControl1
			' 
			Me.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGridControl1.Location = New System.Drawing.Point(0, 20)
			Me.propertyGridControl1.Name = "propertyGridControl1"
			Me.propertyGridControl1.ServiceProvider = Nothing
			Me.propertyGridControl1.Size = New System.Drawing.Size(492, 246)
			Me.propertyGridControl1.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(492, 266)
			Me.Controls.Add(Me.propertyGridControl1)
			Me.Controls.Add(Me.comboBoxEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
		Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
	End Class
End Namespace

