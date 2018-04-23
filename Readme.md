# How to link a PropertyGridControl with a combo box that contains a list of editable objects


<p>This example shows how to link a PropertyGridControl with a combo box that contains a list of editable objects or controls.<br />
First, you should populate the ComboBoxEdit.Properties.Items collection with controls you wish to show in the dropdown list. In the ComboBoxEdit.SelectedIndexChanged event handler, assign the ComboBoxEdit.SelectedItem property value to the PropertyGridControl.SelectedObject property.</p>

<br/>


