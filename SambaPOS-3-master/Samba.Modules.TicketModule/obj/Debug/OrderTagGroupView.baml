   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls  5      \ XPropertyTools.Wpf, Version=2012.4.14.1, Culture=neutral, PublicKeyToken=ea0c9f2b460934d0P:clr-namespace:PropertyTools.Wpf;assembly=PropertyTools.WpfPropertyTools.Wpf 5       Samba.Modules.TicketModule2   ,Samba.Modules.TicketModule.OrderTagGroupView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6E   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6E   @d2http://schemas.microsoft.com/expression/blend/2008     5      p
UIControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5      \PropertyEditorLibrary:clr-namespace:PropertyTools.Wpf;assembly=PropertyTools.Wpf     5        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5	      �� 5
      $Q Kpack://application:,,,/Samba.Presentation.Controls;component/OfficeTab.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Stretch=�6"      OfficeTabControl#��[  6@   .@�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *GeneralSettings+.��5      �� .+�5      �� ��6     *Name+   Suffix$ :���� 5      $
��Left=�6   $	��200��69   ��6H   �� *Name+ �� Mode$ TwoWay=��� 5      ��6     *MinSelectedItems+$ :��<   6Samba.Presentation.Controls.UIControls.FilteredTextBox  5      $
��Left=�61   $��50��6L      Type$ Digits=�5      ��5   Z   �� *MinSelectedItems+5      �� 5      ��6     *MaxSelectedItems+$ :��  5      $
��Left=�61   $��50��6L   $ Digits=�5      ��5   Z   �� *MaxSelectedItems+5      �� 5      $��0,10,0,0q�6   ��61     *AddTagPriceToOrderPrice+ d� 	IsChecked 5      �� *AddTagPriceToOrderPrice+�� 5       $��0,5,0,0q�6   ��60     *	TaxFree+ 5!      �� *	TaxFree+�� 5"      $��0,5,0,0q�6   ��60     *FreeTagging+ 5#      �� *FreeTagging+�� 5$      $��0,5,0,0q�6   ��60     *SaveFreeTags+ 5%      �� *SaveFreeTags+�� 5&      $��0,10,0,0q�6B   $
��left=�6T   ��6     *DisplaySettings+.��5'      A� $
��Left=�6&    A� Columns$ 2��6A   .+�5(      �� ��6$     *
GroupTag+$ :���� 5)      $��0,0,0,2q�6&   $
��Left=�67   $	��100��6R   ��6a   �� *
GroupTag+�� 5*      ��6$     *ButtonColor+$ :��$  PropertyTools.Wpf.ColorPicker2  5+      $
��Left=�6A   $	��150��6\   	   SelectedColor	 6k   �� *ButtonColor+�� 5,      ��6$     *ColumnCount+$ :��  5-      $ Digits=�69   $��0,0,0,2q�6G   $
��Left=�6X   $��50��5.   "   ��60   �� *ColumnCount+�� 5/      ��6$     *ButtonHeight+$ :��  50      $ Digits=�69   $��0,0,0,2q�6G   $
��Left=�6X   $��50��51   "   ��60   �� *ButtonHeight+�� 52      ��6$     *
FontSize+$ :��  53      $ Digits=�69   $��0,0,0,2q�6G   $
��Left=�6X   $��50��54   "   ��60   �� *
FontSize+�� 55      $	��0,5q�6'   ��64     *Hidden+ 6O   �� *Hidden+56      57      58      59      �� 5:      ��6     *List_f+
   FormatSegment1
   *
OrderTag+.��5;      � $
��Left=�6    5<      �� 5=      $
��auto �6(   �� 5>      $��* �6(    � ColumnDefinitions 5@      �� 5A      $��* �6+   �� 5B      $
��auto �6+   .+�5D      �� $��0��6   $��0��6)   $��2��69   ��6M     *List_f+
   *
OrderTag+$ :��&   System.Windows.Controls.DataGrid  5E      -   5        $��1��5E      $��0��6,   $
��Left=�5F         GridLinesVisibility$
 None=�65      RowHeaderWidth$ 0Q�6P   $	��0,3q�6c      AutoGenerateColumns .     CanUserSortColumns .  #��["��5G   Q   ��5E   <   �� *	OrderTags+ �� SelectedItem 6^   �� *SelectedOrderTag+$ TwoWay=�  5I      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5J      "  6$   .�5K   "   ��  � ��$ Center=�6O   5L   #   �� 5M   "    � �� 5N   &   �� 5O   *   .R�5P   .   �� $
��Wrap=�68   ��6L   �� 5Q   /   5R   +   5T   #   5U      5V         Columns 5W      0  *System.Windows.Controls.DataGridTextColumn  5X      ,  &System.Windows.Controls.DataGridColumn   MinWidth$	 100Q�6H      Header 61     *Tag+1  +System.Windows.Controls.DataGridBoundColumn   Binding 6W   �� *Name+  5Y        RightAlignedCellStyle   	CellStyle# [ 5Z   G      Width5	  /System.Windows.Controls.DataGridLengthConverter$ 65	 5[   "    5Y   1     *MaxQuantity+ 5Z   "   ��  �� Path$ MaxQuantity�5[   "   4
  .System.Windows.Controls.DataGridTemplateColumn
  5\      $	 100Q�6P    65     *	Product+ 
  CellTemplate 5]   "   �� 5^   &   .R�5_   *   �� $��3q�64   ��6?   �� *MenuItem.Name+5`   '    
  CellEditingTemplate 5b   "   �� 5c   &   .R�5d   *   �  +� FocusedElement 6/   ��  �� ElementName$ cb��.+�5e   .   �� $��cb��67    �� 
IsEditable .   �� DisplayMemberPath$
  Name��6S   ��6l   �� *	MenuItems+ 5f   2   �� $ MenuItem�! �� UpdateSourceTrigger$! PropertyChanged=�5g   +   5h   '   5j        5k      # [ 5l   "    5k   1     *Price+ 6J   �� $ Price�" �� StringFormat$" #,#0.00��5l   "   # � ContextMenu# 5n      �� 5o      .@�5p   "   m� $ m� Command$ 6+   �� *AddOrderTagCommand+��6R   �� *AddOrderTagCommand.Caption+m� 5q   "   $ 6+   �� *DeleteOrderTagCommand+��6U   �� *DeleteOrderTagCommand.Caption+m� 5r   "   $ 6+   �� *SortOrderTagsCommand+��6T   �� *SortOrderTagsCommand.Caption+5s      5u      �� 5v      $��1��6!   $��1��6.   $��10q�6>   .+�5w      �� $	��2,3q�6$   �� 5x      % �� Command% 6(   �� *AddOrderTagCommand+.�6O   .�5y   "   �� ��6,   �� $  AddOrderTagCommand.Caption�5z      5{      �� 5|      $	��2,3q�6$   �� 5}      % 6(   �� *DeleteOrderTagCommand+.�6R   .�5~   "   �� ��6,   �� $# DeleteOrderTagCommand.Caption�5      5�      �� 5�      $	��2,3q�6$   �� 5�      % 6(   �� *SortOrderTagsCommand+.�6Q   .�5�   "   �� ��6,   �� $" SortOrderTagsCommand.Caption�5�      5�      5�      5�      5�      �� 5�      ��6     *
Mappings+.��5�      �  5�      �� 5�      $
��auto �6(   �� 5�      $��* �6(   .+�5�      ]� $��0��6    .+�5�      �� ��6      *	Mapping_f+
   *
OrderTag+$ :���� 5�      $	��2,5q�6$   �� 5�      % 6(   �� *MapController.AddMapCommand+.�6X   .�5�   "   �� ��6,   �� $) #MapController.AddMapCommand.Caption�5�      5�      �� 5�      $	��2,5q�6$   �� 5�      % 6(   �� * MapController.DeleteMapCommand+.�6[   .�5�   "   �� ��6,   �� $, &MapController.DeleteMapCommand.Caption�5�      5�      5�        5�      $��1��6   $
��Left=�5�      $
 None=�65   $ 0Q�6P   $	��0,3q�6c   $	��300��5�       .   .  &   CanUserDeleteRows& .  '   CanUserAddRows' .  #��["��5�   1   ��5�   ,   �� *MapController.Maps+ 6W   �� *MapController.SelectedMap+ 5�      
  5�      $ *	 6Q    65     *
UserRole+ 5�   "   �� 5�   &   .R�5�   *   �� $��3q�64   ��6?   �� *UserRoleName+5�   '    5�   "   �� 5�   &   .R�5�   *   �  6/   �� $ 
cbUserRole��.+�5�   .   �� $��
cbUserRole��67   $��Stretch=�6I    6g   �� *UserRoleName+$! PropertyChanged=���5�   2   �� *UserRoleNames+5�   +   5�   '   5�      
  5�      $ 2*	 6S    65     *
Department+ 5�   "   �� 5�   &   .R�5�   *   �� $��3q�64   ��6?   �� *DepartmentName+5�   '    5�   "   �� 5�   &   .R�5�   *   �  6/   �� $ cbDepartment��.+�5�   .   �� $��cbDepartment��67   $��Stretch=�6K    6i   �� *DepartmentName+$! PropertyChanged=���5�   2   �� *DepartmentNames+5�   +   5�   '   5�      
  5�      $ *	 6S    65     *
TicketType+ 5�   "   �� 5�   &   .R�5�   *   �� $��3q�64   ��6?   �� *TicketTypeName+5�   '    5�   "   �� 5�   &   .R�5�   *   �  6/   �� $ cbTicketType��.+�5�   .   �� $��cbTicketType��67   $��Stretch=�6K    6i   �� *TicketTypeName+$! PropertyChanged=���5�   2   �� *TicketTypeNames+5�   +   5�   '   5�      
  5�      $ *	 6V    65     *MenuItemGroup+ 5�   "   �� 5�   &   .R�5�   *   �� $��3q�64   ��6?   �� *MenuItemGroupCodeLabel+5�   '    5�   "   �� 5�   &   .R�5�   *   �  6/   �� $ cbMenuItemGroupCode��.+�5�   .   �� $��cbMenuItemGroupCode��67   $��Stretch=�6R    6p   �� *MenuItemGroupCode+$! PropertyChanged=���5�   2   �� *MenuItemGroupCodes+5�   +   5�   '   5�      
  5�      $ 2*	 6Q    65     *
MenuItem+ 5�   "   �� 5�   &   .R�5�   *   �� $��3q�64   ��6?   �� *MenuItemLabel+5�   '    5�   "   �� 5�   &   .R�5�   *   �  6/   �� $ 
cbMenuItem��.+�5�   .   �� $��
cbMenuItem��67   $��Stretch=�6I   $
  Name��6g   ( �� SelectedValuePath$( Id��5�   2   ) �� SelectedValue) 6I   �� *
MenuItemId+$! PropertyChanged=���5�   2   �� *	MenuItems+5�   +   5�   '   5�      5�      5�      5�      5�      �� 5�   
   $��1��6   .+�5�      �� $
��Left=�6   $
��0,10q�60   $��70��6>   ��6L   �� *SaveCommand.Caption+��5�      �� *SaveCommand+�� 5�      
���  ����6   �� *Error+6.   5�      5�      5�      