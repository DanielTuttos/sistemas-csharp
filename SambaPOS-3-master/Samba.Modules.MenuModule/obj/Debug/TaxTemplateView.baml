   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls  5       Samba.Modules.MenuModule.   (Samba.Modules.MenuModule.TaxTemplateView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6A   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6E   @d2http://schemas.microsoft.com/expression/blend/2008     5      p
UIControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5	      $Q Kpack://application:,,,/Samba.Presentation.Controls;component/OfficeTab.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Stretch=�6"      OfficeTabControl#��[  6@   .@�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *GeneralSettings+.��5      �� .+�5      �� $
��Left=�6   ��67     *Name+   Suffix$ :���� 5      $
��Left=�6   $	��200��69   ��6H   �� *Name+�� 5      $
��Left=�6   ��67     *AccountTransactionType+$ :���� 5      $
��Left=�6   $	��200��6:    �� DisplayMemberPath$
 Name��5      ��5      �� *AccountTransactionTypes+ �� SelectedItem 5      �� *AccountTransactionType+�� 5      $
��Left=�6   ��67     *Rate+$ :��<   6Samba.Presentation.Controls.UIControls.FilteredTextBox  5      $
��Left=�61      Type$ Number=�6L   $��50��6Z   ��6h   �� *Rate+�� 5      $
��Left=�6   ��67     *
Rounding+$ :��  5      $
��Left=�61   $ Digits=�6L   $��50��6Z   ��6h   �� *
Rounding+5!      5"      �� 5$      ��6     *
Mappings+.��5%      �  5&      �� 5'      $
��auto �6(   �� 5(      $��* �6(   .+�5*      ]� $��0��6    .+�5+      �� ��6      *	Mapping_f+   FormatSegment1   *TaxTemplate+$ :���� 5,      $	��2,5q�6$   �� 5-      	 �� Command	 6(   �� *MapController.AddMapCommand+.�6X   .�5.   "   �� ��6,   �� 
 �� Path$)
 #MapController.AddMapCommand.Caption�5/      50      �� 51      $	��2,5q�6$   �� 52      	 6(   �� * MapController.DeleteMapCommand+.�6[   .�53   "   �� ��6,   �� $,
 &MapController.DeleteMapCommand.Caption�54      55      56      &   System.Windows.Controls.DataGrid  57      $��1��6   $
��Left=�58         GridLinesVisibility$
 None=�65      RowHeaderWidth$ 0Q�6P   $	��0,3q�6c   $	��300��59         AutoGenerateColumns .     CanUserSortColumns .     CanUserDeleteRows .     CanUserAddRows .  #��["��5:   1   ��57   ,   �� *MapController.Maps+ 6W   �� *MapController.SelectedMap+   Columns 5;      4  .System.Windows.Controls.DataGridTemplateColumn  5=      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6S      Header 65     *
Department+   CellTemplate 5>   "   �� 5?   &   .R�5@   *   �� $��3q�64   ��6?   �� *DepartmentName+5A   '      CellEditingTemplate 5C   "   �� 5D   &   .R�5E   *   �  +� FocusedElement 6/   ��  �� ElementName$ cbDepartment��.+�5F   .   �� $��cbDepartment��67   $��Stretch=�6K    6i   �� *DepartmentName+ �� UpdateSourceTrigger$ PropertyChanged=���5G   2   �� *DepartmentNames+5H   +   5I   '   5K        5L      $ * 6S    65     *
TicketType+ 5M   "   �� 5N   &   .R�5O   *   �� $��3q�64   ��6?   �� *TicketTypeName+5P   '    5R   "   �� 5S   &   .R�5T   *   �  6/   �� $ cbTicketType��.+�5U   .   �� $��cbTicketType��67   $��Stretch=�6K    6i   �� *TicketTypeName+$ PropertyChanged=���5V   2   �� *TicketTypeNames+5W   +   5X   '   5Z        5[      $ * 6V    65     *MenuItemGroup+ 5\   "   �� 5]   &   .R�5^   *   �� $��3q�64   ��6?   �� *MenuItemGroupCodeLabel+5_   '    5a   "   �� 5b   &   .R�5c   *   �  6/   �� $ cbMenuItemGroupCode��.+�5d   .   �� $��cbMenuItemGroupCode��67   $��Stretch=�6R    6p   �� *MenuItemGroupCode+$ PropertyChanged=���5e   2   �� *MenuItemGroupCodes+5f   +   5g   '   5i        5j      $ 2* 6Q    65     *
MenuItem+ 5k   "   �� 5l   &   .R�5m   *   �� $��3q�64   ��6?   �� *MenuItemLabel+5n   '    5p   "   �� 5q   &   .R�5r   *   �  6/   �� $ 
cbMenuItem��.+�5s   .   �� $��
cbMenuItem��67   $��Stretch=�6I   $
 Name��6g    �� SelectedValuePath$ Id��5t   2    �� SelectedValue 6I   �� *
MenuItemId+$ PropertyChanged=���5u   2   �� *	MenuItems+5v   +   5w   '   5y      5{      5|      5}      5~      �� 5   
   $��1��6   .+�5�      �� $
��Left=�6   $
��0,10q�60   $��70��6>   ��6L   �� *SaveCommand.Caption+��5�      �� *SaveCommand+�� 5�      
���  ����6   �� *Error+6.   5�      5�      5�      