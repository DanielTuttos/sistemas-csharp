   M S B A M L   `   `   `  ����  Samba.Modules.TicketModule6    0Samba.Modules.TicketModule.ChangePaymentTypeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6I   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6=   @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $Q Kpack://application:,,,/Samba.Presentation.Controls;component/OfficeTab.xaml?�6%   %    5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Stretch=�6"      OfficeTabControl#��[  6@   .@�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *GeneralSettings+.��5      �� .+�5      �� $
��Left=�6   ��67     *TemplateName+   Suffix$ :���� 5      $
��Left=�6   $	��200��69   ��6H   �� *Name+�� 5      $
��Left=�6   ��67     *AccountTransactionType+$ :���� 5      $
��Left=�6   $	��200��6:    �� DisplayMemberPath$
 Name��5   I   ��5   I   �� *AccountTransactionTypes+ �� SelectedItem 5      �� *AccountTransactionType+6I   �� 5      $
��Left=�6   ��67     *	Account+$ :���� 5      $
��Left=�6   $	��200��6:   $
 Name��5   :   ��5   I   �� *
Accounts+ 5      �� *	Account+6:   5      5      �� 5      ��6     *
Mappings+.��5      �  5       �� 5!      $
��auto �6(   �� 5"      $��* �6(   .+�5$      ]� $��0��6    .+�5%      �� ��6      *
Mappings+$ :���� 5'      $	��2,5q�6$   �� 5(       �� Command 6(   �� *MapController.AddMapCommand+.�6X   .�5)   "   �� ��6,   ��  �� Path$) #MapController.AddMapCommand.Caption�5*      5+      �� 5,      $	��2,5q�6$   �� 5-       6(   �� * MapController.DeleteMapCommand+.�6[   .�5.   "   �� ��6,   �� $, &MapController.DeleteMapCommand.Caption�5/      50      51      &   System.Windows.Controls.DataGrid  53      $��1��6   $
��Left=�54      	   GridLinesVisibility$
	 None=�6:   
   RowHeaderWidth$
 0Q�6U   $	��0,3q�6h   $	��300��6u      AutoGenerateColumns .     CanUserSortColumns .     CanUserAddRows .     CanUserDeleteRows .  #��["��56      ��53   ,   �� *MapController.Maps+ 6W   �� *MapController.SelectedMap+   Columns 57      4  .System.Windows.Controls.DataGridTemplateColumn  58      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Q      Header 65     *
UserRole+   CellTemplate 59   "   �� 5:   &   .R�5;   *   �� $��3q�64   ��6?   �� *UserRoleName+5<   '      CellEditingTemplate 5>   "   �� 5?   &   .R�5@   *   �  +� FocusedElement 6/   ��  �� ElementName$ 
cbUserRole��.+�5A   .   �� $��
cbUserRole��67   $��Stretch=�6J    6h   �� *UserRoleName+ �� UpdateSourceTrigger$ PropertyChanged=���5B   ;   �� *UserRoleNames+5C   +   5D   '   5F        5G      $ 2* 6S    65     *
Department+ 5H   "   �� 5I   &   .R�5J   *   �� $��3q�64   ��6?   �� *DepartmentName+5K   '    5M   "   �� 5N   &   .R�5O   *   �  6/   �� $ cbDepartment��.+�5P   .   �� $��cbDepartment��67   $��Stretch=�6L    6j   �� *DepartmentName+$ PropertyChanged=���5Q   3   �� *DepartmentNames+5R   +   5S   '   5U        5V      $ * 6S    65     *
TicketType+ 5W   "   �� 5X   &   .R�5Y   *   �� $��3q�64   ��6?   �� *TicketTypeName+5Z   '    5\   "   �� 5]   &   .R�5^   *   �  6/   �� $ cbTicketType��.+�5_   .   �� $��cbTicketType��67   $��Stretch=�6K    6i   �� *TicketTypeName+$ PropertyChanged=���5`   2   �� *TicketTypeNames+5a   +   5b   '   5d      5f      5g      5h      5i      �� 5j   
   $��1��6   .+�5k      �� $
��Left=�6   $��0,10,3,0q�60   $��70��6B   ��6P   �� *SaveCommand.Caption+��5l      �� *SaveCommand+�� 5m      
���  ����6   �� *Error+6.   5n      5o      5q      