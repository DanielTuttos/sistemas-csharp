   M S B A M L   `   `   `  ����!  Samba.Presentation.ViewModels5    /Samba.Presentation.ViewModels.MapControllerView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      �   � RowDefinitions  5	   
   �� 5
      $
��auto �6   �� 5      $��* �6   .+�5   
   ]� $��0��6   $��0,10,0,0q�6!   .+�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *
Mappings+   Suffix$ :���� 5      $	��2,5q�6   �� 5       �� Command 6(   �� *AddMapCommand+.�6J   .�5   "   �� ��6,   ��  �� Path$ AddMapCommand.Caption�5      5      �� 5      $	��2,5q�6   �� 5       6(   �� *DeleteMapCommand+.�6M   .�5   "   �� ��6,   �� $ DeleteMapCommand.Caption�5      5      5      &   System.Windows.Controls.DataGrid  5   
   $��1��6   $
��Left=�5         GridLinesVisibility$
 None=�6:      RowHeaderWidth$ 0Q�6U   $	��0,3q�6h   $	��300��6u      AutoGenerateColumns .     CanUserSortColumns .     CanUserAddRows .  	   CanUserDeleteRows	 .  #��["��5      ��5       �� *Maps+
 �� SelectedItem
 6=   �� *SelectedMap+   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5       ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6E      Header 6)     *
Terminal+   CellTemplate 5!      �� 5"      .R�5#      �� $��3q�6(   ��63   �� *TerminalName+5$         CellEditingTemplate 5&      �� 5'      .R�5(      �  +� FocusedElement 6#   ��  �� ElementName$ 
cbTerminal��.+�5)   "   �� $��
cbTerminal��6+   $��Stretch=�6>   
 6\   �� *TerminalName+ �� UpdateSourceTrigger$ PropertyChanged=���5*   ;   �� *TerminalNames+5+      5,      5.        5/      $ * 6E    6)     *
UserRole+ 50      �� 51      .R�52      �� $��3q�6(   ��63   �� *UserRoleName+53       55      �� 56      .R�57      �  6#   �� $ 
cbUserRole��.+�58   "   �� $��
cbUserRole��6+   $��Stretch=�6>   
 6\   �� *UserRoleName+$ PropertyChanged=���59   ;   �� *UserRoleNames+5:      5;      5=        5>      $ 2* 6G    6)     *
Department+ 5?      �� 5@      .R�5A      �� $��3q�6(   ��63   �� *DepartmentName+5B       5D      �� 5E      .R�5F      �  6#   �� $ cbDepartment��.+�5G   "   �� $��cbDepartment��6+   $��Stretch=�6@   
 6^   �� *DepartmentName+$ PropertyChanged=���5H   3   �� *DepartmentNames+5I      5J      5L      5N      5O      5P      