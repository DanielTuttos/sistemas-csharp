   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls  5       Samba.Modules.MenuModule+   %Samba.Modules.MenuModule.MenuItemView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6>   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6E   @d2http://schemas.microsoft.com/expression/blend/2008     5      p
UIControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5      .��5      �� =   7Samba.Presentation.Controls.UIControls.KineticBehaviour    HandleKineticScrolling  . $
��Auto=�6M   .��5   
   �� .+�5      �  � ColumnDefinitions 5	      �� 5
      $
��auto �6'   �� 5      $
��auto �6'   .+�5      �� $��0��6   $��0,0,10,0q�6-   .+�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *ProductName+   Suffix$ :���� 5      $
��Left=�6   $	��200��69   ��6H   �� *Name+ �� Mode$ TwoWay=��� 5      ��6     *	Barcode+$ :���� 5      $
��Left=�6   $	��200��69   ��6H   �� *	Barcode+$ TwoWay=�5      �� 5      $��1��6   .+�5      �� ��6     *	GroupCode+$ :���� 5      $
��Left=�6   $	��150��6:    �� 
IsEditable .  �� Text 6I   �� *	GroupCode+$ TwoWay=���5      �� *
GroupCodes+6B   �� 5      ��6     *Tag+$ :���� 5      $
��Left=�6   $	��150��6:    .  6I   �� *Tag+$ TwoWay=���5      �� *Tags+6<   5      5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��5q�5      $��5q�6&   ��5        *PortionPrices+.��5       �� $ 
Horizontal=�6!   .+�5!      &   System.Windows.Controls.DataGrid  -   5        $
��Left=�5"   "      GridLinesVisibility$
 None=�6=      RowHeaderWidth$ 0Q�6X   $	��0,3q�6k   	   AutoGenerateColumns	 .  
   CanUserSortColumns
 .  #��["��5$   "   ��5!   #   �� *
Portions+ �� SelectedItem 6D   �� *SelectedPortion+$ TwoWay=�   Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'   "   ,  &System.Windows.Controls.DataGridColumn   MinWidth$	 100Q�5(   *      Header 5'   5     *	Portion+1  +System.Windows.Controls.DataGridBoundColumn   Binding 5(   9   �� *Name+  5)   "    65     *
Multiplier+ 5*   *   ��  �� Path$ 
Multiplier� �� StringFormat$ #,##.##��  5+   "      RightAlignedCellStyle   	CellStyle# [  5,   `    5+   5     *Price+ 5,   *   �� $ Price�$ #,#0.00��6`    � ContextMenu 5.      �� 5/   "   .@�50   &   m�  m� Command 6/   �� *AddPortionCommand+��6U   �� *AddPortionCommand.Caption+m� 51   &    6/   �� *DeletePortionCommand+��6X   �� *DeletePortionCommand.Caption+52   #   54      �� 55      $��10q�6%   .+�56      �� $	��2,3q�6(   �� 57   &    �� Command 60   �� *AddPortionCommand+.�6V   .�58   *   �� ��64   �� $ AddPortionCommand.Caption�59   '   5:   #   �� 5;      $	��2,3q�6(   �� 5<   &    60   �� *DeletePortionCommand+.�6Y   .�5=   *   �� ��64   �� $" DeletePortionCommand.Caption�5>   '   5?   #   5@      5A      5B      5C      �� 5D      $
��Left=�6   $
��0,10q�60   $��70��6>   ��6L   �� *SaveCommand.Caption+��5E      �� *SaveCommand+�� 5F      
���  ����6   �� *Error+6.   5G      5H      5I      