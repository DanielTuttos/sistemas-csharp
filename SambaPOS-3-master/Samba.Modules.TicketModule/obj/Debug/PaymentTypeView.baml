   M S B A M L   `   `   `  ����\  XPropertyTools.Wpf, Version=2012.4.14.1, Culture=neutral, PublicKeyToken=ea0c9f2b460934d0P:clr-namespace:PropertyTools.Wpf;assembly=PropertyTools.WpfPropertyTools.Wpf  5   C   V RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls 5       Samba.Modules.TicketModule0   *Samba.Modules.TicketModule.PaymentTypeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6C   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6=   @d2http://schemas.microsoft.com/expression/blend/2008     5      \PropertyEditorLibrary:clr-namespace:PropertyTools.Wpf;assembly=PropertyTools.Wpf     6C   p
uiControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5	      $Q Kpack://application:,,,/Samba.Presentation.Controls;component/OfficeTab.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Stretch=�6"      OfficeTabControl#��[  6@   .@�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *GeneralSettings+.��5      �� .+�5      �� $
��Left=�6   ��67     *TemplateName+   Suffix$ :���� 5      $
��Left=�6   $	��200��69   ��6H   �� *Name+�� 5      $
��Left=�6   ��67     *AccountTransactionType+$ :���� 5      $
��Left=�6   $	��200��6:    �� DisplayMemberPath$
 Name��5   I   ��5   I   �� *AccountTransactionTypes+ �� SelectedItem 5      �� *AccountTransactionType+6I   �� 5      $
��Left=�6   ��67     *	Account+$ :���� 5      $
��Left=�6   $	��200��6:   $
 Name��5   :   ��5   I   �� *
Accounts+ 5      �� *	Account+6:   �� 5      $
��Left=�6   ��67     *ButtonColor+$ :��$   PropertyTools.Wpf.ColorPicker2  5      $
��Left=�69   $	��150��6T      SelectedColor 6c   �� *ButtonColor+�� 5      $
��Left=�6   ��67     *
FontSize+$ :��<  6Samba.Presentation.Controls.UIControls.FilteredTextBox  5       $
��Left=�61   $	��150��6L      Type$ Digits=�6u   ��6[   �� *
FontSize+6u   5"      5#      �� 5%      ��6     *
Mappings+.��5&      �  5'      �� 5(      $
��auto �6(   �� 5)      $��* �6(   .+�5+      ]� $��0��6    .+�5,      �� ��6      *
Mappings+$ :���� 5.      $	��2,5q�6$   �� 5/      	 �� Command	 6(   �� *MapController.AddMapCommand+.�6X   .�50   "   �� ��6,   �� 
 �� Path$)
 #MapController.AddMapCommand.Caption�51      52      �� 53      $	��2,5q�6$   �� 54      	 6(   �� * MapController.DeleteMapCommand+.�6[   .�55   "   �� ��6,   �� $,
 &MapController.DeleteMapCommand.Caption�56      57      58      &   System.Windows.Controls.DataGrid  5:      $��1��6   $
��Left=�5;         GridLinesVisibility$
 None=�6:      RowHeaderWidth$ 0Q�6U   $	��0,3q�6h   $	��300��6u      AutoGenerateColumns .     CanUserSortColumns .     CanUserAddRows .     CanUserDeleteRows .  #��["��5=      ��5:   ,   �� *MapController.Maps+ 6W   �� *MapController.SelectedMap+   Columns 5>      4  .System.Windows.Controls.DataGridTemplateColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Q      Header 65     *
UserRole+   CellTemplate 5@   "   �� 5A   &   .R�5B   *   �� $��3q�64   ��6?   �� *UserRoleName+5C   '      CellEditingTemplate 5E   "   �� 5F   &   .R�5G   *   �  +� FocusedElement 6/   ��  �� ElementName$ 
cbUserRole��.+�5H   .   �� $��
cbUserRole��67   $��Stretch=�6J    6h   �� *UserRoleName+ �� UpdateSourceTrigger$ PropertyChanged=���5I   ;   �� *UserRoleNames+5J   +   5K   '   5M        5N      $ 2* 6S    65     *
Department+ 5O   "   �� 5P   &   .R�5Q   *   �� $��3q�64   ��6?   �� *DepartmentName+5R   '    5T   "   �� 5U   &   .R�5V   *   �  6/   �� $ cbDepartment��.+�5W   .   �� $��cbDepartment��67   $��Stretch=�6L    6j   �� *DepartmentName+$ PropertyChanged=���5X   3   �� *DepartmentNames+5Y   +   5Z   '   5\        5]      $ * 6S    65     *
TicketType+ 5^   "   �� 5_   &   .R�5`   *   �� $��3q�64   ��6?   �� *TicketTypeName+5a   '    5c   "   �� 5d   &   .R�5e   *   �  6/   �� $ cbTicketType��.+�5f   .   �� $��cbTicketType��67   $��Stretch=�6K    6i   �� *TicketTypeName+$ PropertyChanged=���5g   2   �� *TicketTypeNames+5h   +   5i   '   5k      5m      5n      5o      5p      �� 5q   
   $��1��6   .+�5r      �� $
��Left=�6   $��0,10,3,0q�60   $��70��6B   ��6P   �� *SaveCommand.Caption+��5s      �� *SaveCommand+�� 5t      
���  ����6   �� *Error+6.   5u      5v      5x      