   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls  5       Samba.Modules.MenuModule/   )Samba.Modules.MenuModule.ProductTimerView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      p
UIControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $Q Kpack://application:,,,/Samba.Presentation.Controls;component/OfficeTab.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Stretch=�6"      OfficeTabControl#��[  6@   .@�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *GeneralSettings+.��5      �� .+�5      �� ��6     *Name+   Suffix$ :���� 5      $
��Left=�6   $	��200��69   ��6H   �� *Name+�� 5      ��6     *PriceDurationType+$ :���� 5      $
��Left=�6   $	��150��6:   ��6I   �� *
PriceTypes+ �� SelectedValue 6l   �� *	PriceType+�� 5      ��6     *PriceDuration+$ :��<   6Samba.Presentation.Controls.UIControls.FilteredTextBox  5      $
��Left=�61   $��50��6L      Type$ Number=�6y   ��6Z   �� *PriceDuration+6y   �� 5      ��6     *	MinTime+$ :��  5      $
��Left=�61   $��50��6L   $ Number=�6s   ��6Z   �� *	MinTime+6s   �� 5       ��6     *TimeRounding+$ :��  5!      $
��Left=�61   $��50��6L   $ Number=�6x   ��6Z   �� *TimeRounding+6x   �� 5"      ��6     *	StartTime+$ :��  5#      $
��Left=�61   $��50��6L   $ Digits=�6u   ��6Z   �� *	StartTime+6u   5$      5%      �� 5'      ��6     *
Mappings+.��5(      �  5)      �� 5*      $
��auto �6(   �� 5+      $��* �6(   .+�5-      ]� $��0��6    .+�5.      �� ��6      *	Mapping_f+   FormatSegment1   *ProductTimer+$ :���� 50      $	��2,5q�6$   �� 51       �� Command 6(   �� *MapController.AddMapCommand+.�6X   .�52   "   �� ��6,   �� 	 �� Path$)	 #MapController.AddMapCommand.Caption�53      54      �� 55      $	��2,5q�6$   �� 56       6(   �� * MapController.DeleteMapCommand+.�6[   .�57   "   �� ��6,   �� $,	 &MapController.DeleteMapCommand.Caption�58      59      5:      &   System.Windows.Controls.DataGrid  5;      $��1��6   $
��Left=�5<      
   GridLinesVisibility$

 None=�65      RowHeaderWidth$ 0Q�6P   $	��0,3q�6c   $	��300��5=         AutoGenerateColumns .     CanUserSortColumns .     CanUserDeleteRows .     CanUserAddRows .  #��["��5>   1   ��5;   ,   �� *MapController.Maps+ �� SelectedItem 6W   �� *MapController.SelectedMap+   Columns 5?      4  .System.Windows.Controls.DataGridTemplateColumn  5@      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Q      Header 65     *
UserRole+   CellTemplate 5A   "   �� 5B   &   .R�5C   *   �� $��3q�64   ��6?   �� *UserRoleName+5D   '      CellEditingTemplate 5F   "   �� 5G   &   .R�5H   *   �  +� FocusedElement 6/   ��  �� ElementName$ 
cbUserRole��.+�5I   .   �� $��
cbUserRole��67   $��Stretch=�6I    6g   �� *UserRoleName+ �� UpdateSourceTrigger$ PropertyChanged=���5J   2   �� *UserRoleNames+5K   +   5L   '   5N        5O      $ 2* 6S    65     *
Department+ 5P   "   �� 5Q   &   .R�5R   *   �� $��3q�64   ��6?   �� *DepartmentName+5S   '    5U   "   �� 5V   &   .R�5W   *   �  6/   �� $ cbDepartment��.+�5X   .   �� $��cbDepartment��67   $��Stretch=�6K    6i   �� *DepartmentName+$ PropertyChanged=���5Y   2   �� *DepartmentNames+5Z   +   5[   '   5]        5^      $ 2* 6S    65     *
TicketType+ 5_   "   �� 5`   &   .R�5a   *   �� $��3q�64   ��6?   �� *TicketTypeName+5b   '    5d   "   �� 5e   &   .R�5f   *   �  6/   �� $ cbTicketType��.+�5g   .   �� $��cbTicketType��67   $��Stretch=�6K    6i   �� *TicketTypeName+$ PropertyChanged=���5h   2   �� *TicketTypeNames+5i   +   5j   '   5l        5m      $ * 6V    65     *MenuItemGroup+ 5n   "   �� 5o   &   .R�5p   *   �� $��3q�64   ��6?   �� *MenuItemGroupCodeLabel+5q   '    5s   "   �� 5t   &   .R�5u   *   �  6/   �� $ cbMenuItemGroupCode��.+�5v   .   �� $��cbMenuItemGroupCode��67   $��Stretch=�6R    6p   �� *MenuItemGroupCode+$ PropertyChanged=���5w   2   �� *MenuItemGroupCodes+5x   +   5y   '   5{        5|      $ 2* 6Q    65     *
MenuItem+ 5}   "   �� 5~   &   .R�5   *   �� $��3q�64   ��6?   �� *MenuItemLabel+5�   '    5�   "   �� 5�   &   .R�5�   *   �  6/   �� $ 
cbMenuItem��.+�5�   .   �� $��
cbMenuItem��67   $��Stretch=�6I    �� DisplayMemberPath$
 Name��6g    �� SelectedValuePath$ Id��5�   2    6I   �� *
MenuItemId+$ PropertyChanged=���5�   2   �� *	MenuItems+5�   +   5�   '   5�      5�      5�      5�      5�      �� 5�   
   $��1��6   .+�5�      �� $
��Left=�6   $
��0,10q�60   $��70��6>   ��6L   �� *SaveCommand.Caption+��5�      �� *SaveCommand+�� 5�      
���  ����6   �� *Error+6.   5�      5�      5�      