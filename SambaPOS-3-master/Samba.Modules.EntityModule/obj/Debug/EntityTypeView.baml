   M S B A M L   `   `   `  ����  Samba.Modules.EntityModule/    )Samba.Modules.EntityModule.EntityTypeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5       �� MergedDictionaries �� Source�� 5	   
    5
      �� 5      $Q Kpack://application:,,,/Samba.Presentation.Controls;component/OfficeTab.xaml?�6%   %    5      .��5      � -   5        $��MainGrid��5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Stretch=�6"      OfficeTabControl#��[  6@   .@�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *GeneralSettings+.��5      �� .+�5      �� ��6     *Name+   Suffix$ :���� 5      $
��Left=�6   $	��200��69   ��6H   �� *Name+�� 5      ��6     *
EntityName+$ :���� 5      $
��Left=�6   $	��200��69   ��6H   �� *
EntityName+�� 5      ��6     *DisplayFormat+$ :���� 5      $
��Left=�6   $	��200��69   ��6H   �� *DisplayFormat+�� 5      ��6     *PrimaryFieldName+$ :���� 5      $
��Left=�6   $	��200��69   ��6H   �� *PrimaryFieldName+�� 5       ��6     *PrimaryFieldFormat+$ :���� 5!      $
��Left=�6   $	��200��69   ��6H   �� *PrimaryFieldFormat+�� 5"      ��6     *WarehouseType+$ :���� 5#      $
��Left=�6   $	��150��6:    �� DisplayMemberPath$
 Name��6�    �� 
IsEditable . ��6I   �� *WarehouseTypes+ �� SelectedItem 6p   �� *WarehouseType+6�   �� 5$      ��6     *AccountType+$ :���� 5%      $
��Left=�6   $	��150��6:   $
 Name��6�    . ��6I   �� *AccountTypes+ 6n   �� *AccountType+6�   �� 5&      ��6     *AccountNameTemplate+$ :���� 5'      $
��Left=�6   $	��200��69   ��6H   �� *AccountNameTemplate+�� 5(      ��6     *AccountBalanceDisplayFormat+$ :���� 5)      $
��Left=�6   $	��200��69   ��6H   �� *AccountBalanceDisplayFormat+5*      5+      �� 5,      ��6     *CustomFields+.��5-      �  5.      �� 5/      $
��auto �6(   �� 50      $��* �6(   .+�52      ]� $��0��6    .+�53      �� ��6      *CustomFields+$ :���� 54      $	��2,5q�6$   �� 55       �� Command 6(   �� *AddCustomFieldCommand+.�6R   .�56   "   �� ��6,   �� 	 �� Path$#	 AddCustomFieldCommand.Caption�57      58      �� 59      $	��2,5q�6$   �� 5:       6(   �� *DeleteCustomFieldCommand+.�6U   .�5;   "   �� ��6,   �� $&	  DeleteCustomFieldCommand.Caption�5<      5=      5>      &   System.Windows.Controls.DataGrid  5?      $��1��6   $��Stretch=�5@      
   GridLinesVisibility$

 None=�64      RowHeaderWidth$ 0Q�6O   $	��0,3q�6b      	RowHeight$ 28Q�6o      AutoGenerateColumns .     CanUserSortColumns .  #��["��5A   M     CenterAlignedGridCell   	CellStyle# [ 5B      ��5?   ,   �� *EntityCustomFields+ 6W   �� *SelectedCustomField+ �� Mode$ TwoWay=�   Columns 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      ,  &System.Windows.Controls.DataGridColumn   MinWidth$	 100Q�5E   <      Header 6     *CustomFieldName+1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  5F      $	 100Q�6R    65     *	FieldType+   CellTemplate 5G   "   �� 5H   &   .R�5I   *   �� $��3q�64   ��6?   �� *	FieldType+5J   '      CellEditingTemplate 5L   "   �� 5M   &   .R�5N   *   �  +� FocusedElement 6/   ��  �� ElementName$ cb��.+�5O   .   �� $��cb��67   ��6A   �� *
FieldTypes+ 6d   �� *	FieldType+5P   +   5Q   '   5S        5T      $	 100Q�6R    61     *EditingFormat+ 6a   �� *EditingFormat+  5U      $	 100Q�6K    61     *Values+ 6Z   �� *ValueSource+4  .System.Windows.Controls.DataGridCheckBoxColumn  5V      $ Hidden��65    6E   �� *Hidden+ � ContextMenu 5X      �� 5Y      .@�5Z   "   m�  m� Command 6+   �� *AddCustomFieldCommand+��6U   �� *AddCustomFieldCommand.Caption+m� 5[   "    6+   �� *DeleteCustomFieldCommand+��6X   �� *" DeleteCustomFieldCommand.Caption+5\      5^      5_      5`      5a      �� 5b   
   $��1��6   $��2��6"   .+�5c      �� $
��Left=�6   $
��0,10q�60   $��70��6>   ��6L   �� *SaveCommand.Caption+��5d      �� *SaveCommand+�� 5e      
���  ����6   �� *Error+6.   5f      5g      5h      