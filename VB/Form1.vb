Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Collections

Namespace Sample___SelectedControlComboBox
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			PopulateComboBox(Controls, comboBoxEdit1)
		End Sub

		Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEdit1.SelectedIndexChanged
			Dim comboBox As ComboBoxEdit = CType(sender, ComboBoxEdit)
			Dim item As CmbItem = CType(comboBox.SelectedItem, CmbItem)
			If item Is Nothing Then
				Return
			End If
			propertyGridControl1.SelectedObject = item.Component

		End Sub
		Private Sub PopulateComboBox(ByVal controls As Control.ControlCollection, ByVal comboBox As ComboBoxEdit)
			Dim items As New ArrayList(controls.Count)
			For Each c As Control In controls
				If c IsNot Nothing Then
					items.Add(New CmbItem(c))
				End If
			Next c
			CType(comboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Try
				comboBox.Properties.Items.Clear()
				comboBox.Properties.Items.AddRange(items.ToArray())
			Finally
				CType(comboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			End Try
		End Sub
	End Class
	Friend Class CmbItem
		Private control As Control

		Private ReadOnly Property DisplayTypeName() As String
			Get
				Return control.GetType().Name
			End Get
		End Property
		Public ReadOnly Property Component() As IComponent
			Get
				Return control
			End Get
		End Property
		Public Sub New(ByVal control As Control)
			Me.control = control
		End Sub
		Public Overrides Function ToString() As String
			Return String.Concat(control.Name, "   ", DisplayTypeName)
		End Function
	End Class
End Namespace