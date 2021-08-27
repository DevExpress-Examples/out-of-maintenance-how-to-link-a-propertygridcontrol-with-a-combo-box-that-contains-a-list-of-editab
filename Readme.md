<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128638844/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E505)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to link a PropertyGridControl with a combo box that contains a list of editable objects


<p>This example shows how to link a PropertyGridControl with a combo box that contains a list of editable objects or controls.<br />
First, you should populate the ComboBoxEdit.Properties.Items collection with controls you wish to show in the dropdown list. In the ComboBoxEdit.SelectedIndexChanged event handler, assign the ComboBoxEdit.SelectedItem property value to the PropertyGridControl.SelectedObject property.</p>

<br/>


