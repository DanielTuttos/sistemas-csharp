   M S B A M L   `   `   `  ����"  Samba.Modules.AutomationModule-    'Samba.Modules.AutomationModule.RuleView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5	      �� 5
      $Q Kpack://application:,,,/Samba.Presentation.Controls;component/OfficeTab.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   ��    OfficeTabControl#��[  6   .@�5      �� $��General Settings��6   .��5      �� $��0��6   $
��Auto=�6,   .��5      �� .+�5      �� $
��Left=�6    ��6;   4  .Samba.Localization.Extensions.LocTextExtension  *
RuleName+   Suffix$ :���� 5      $
��Left=�6"   $	��200��6=   ��6L   �� *Name+�� 5      $
��Left=�6    ��6;     *	EventName+$ :���� 5      $
��Left=�6#   $	��150��6>    �� DisplayMemberPath$ 	EventName��5       �� SelectedValuePath$ EventKey��64   ��5   M   �� *Events+ �� SelectedValue 5   Q   �� *	EventName+�� 5      $
��Left=�6#   $	��0,3q�6>   $��1q�6K   ��6W     *ExecuteActionsIf+y�6{   �� *IsConstraintsVisible+  VisibilityConverter �� 	Converter# [ .��5      �� .+�5   "   �� $	��150��6X   ��6(     *CustomConstraint+$ :��6X   �� 5    "   $	��150��6*   $��2q�69   ��6D   �� *CustomConstraint+�� 5!   "   	 � IsSharedSizeScope	 . $
��Left=�6q   ��6M   �� *Constraints+��5"   &   �� 5#   *   .R�5$   .   � $	��0,3q�63   
 � ColumnDefinitions
 5%   2   �� 5&   6   $
��Auto �6G    z� SharedSizeGroup$ Constraints��6T   �� 5'   6   $
��Auto �6G   �� 5(   6   $
��Auto �6G   .+�5*   2   �� $��0��68   $	��150��6h   ��6H   �� *NameDisplay+6h   �� 5+   2   $��1��6;   $	��3,0q�6K   $��45��6X    �� 
IsEditable .  �� Text 6x   �� *	Operation+��5,   3   �� *
Operations+�� 5-   2   $��2��6;   $��80��6K    . ��5.   3   �� *Values+ 6R   �� *Value+5/   /   50   +   52   #   53      54      �� 56      $
��Left=�6g   $	��0,5q�6�   $��5q�6�   ��6#     *List_f+   FormatSegment1   *CustomConstraint+.��57      �� .+�58   "   ]� $
��Left=�6,   $	��0,5q�6G   .+�59   &   �� $��0,0,5,0q�6,   ��6=     *ExecuteRuleIf+�� 5:   &   ��6/   �� *RuleMatchNames+ �� SelectedItem 6V   �� *RuleMatchName+5;   #   �� 5<   "   $��5q�6,   �� 5=   &    �� Command 60   �� *AddConstraintCommand+.�6Y   .�5>   *   �� ��64   ��  �� Path$" AddConstraintCommand.Caption�5?   '   5@   #   �� 5A   "   	 . ��6M   �� *RuleConstraintValues+��5B   &   �� 5C   *   .R�5D   .   � $	��0,3q�63   
 5E   2   �� 5F   6   $
��Auto �6G   $ CustomConstraints��6T   �� 5G   6   $
��Auto �6G   �� 5H   6   $
��Auto �6G   �� 5I   6   $
��Auto �6G   .+�5K   2   �� $��0��6;   $	��3,0q�6K   $��45��6X    . $ Display��5M   _   $
 Name��6{    5L   ;   �� *	TypedText+ �� UpdateSourceTrigger$ PropertyChanged=� 6z   �� *Left+��5M   3   �� *RuleConstraintNames+6{   �� 5N   2   $��1��6;   $	��3,0q�6K   $��45��6X    . $ Value��5O   d   $ Display��6~    5N   x   �� *	Operation+ �� Mode$ TwoWay=���5O   3   �� *RuleConstraintOperations+6~   �� 5P   2   $��2��6;   $��80��6K    . ��5Q   3   �� *Values+ 6R   �� *Right+�� 5R   2   $��3��6<   $��5,3,0,0q�6L   �� 5S   6    6@   �� *RemoveConstraintCommand+ �� CommandParameter 6l   �� $ .�.�6�   .�5T   :   �� ��6D   �� $% RemoveConstraintCommand.Caption�5U   7   5V   3   5W   /   5X   +   5Z   #   5[      5]      �� 5^       �� Orientation$ 
Horizontal=�6%   .+�5_      �� $
��Left=�6$   ��6?     *	Actions+$ :���� 5`      $��2,5,0,0q�6(   �� 5a       6$   �� *SelectActionsCommand+.�6M   .�5b      �� ��6(   �� $" SelectActionsCommand.Caption�5c      5d      5e      � 5f      $
��Left=�6   .+�5g      �� $
��Left=�6K   ��6+   �� *	Actions+��5h   "   �� 5i   &   .R�5j   *   9�   MainViewExpander#��[ 63    9� 
IsExpanded .  $��2q�6�   ��6]   �� *Name+.��5k   .   �� .+�5l   2   ]� .+�5m   6   �� $
��Left=�6<   $��Constraint:��6W   �� 5n   6   $��80��6`   ��6>   �� *CustomConstraint+6`   5o   3   �� 5p   2   ��6?   �� *ParameterValues+��5q   6   �� 5r   :   .R�5s   >   �� $ 
Horizontal=�6I   $	��0,3q�6b   .+�5t   B   �� $	��120��6a   ��6H   �� *Name+6a   �� 5u   B   $��80��6b    .  6K   �� *Value+��6�   �� *ParameterValues+5v   ?   5w   ;   5y   3   5z   /   5{   +   5|   '   5~      5      5�      5�      5�      �� 5�      ��6     *
Mappings+.��5�      �  5�      �� 5�      $
��auto �6(   �� 5�      $��* �6(   .+�5�      ]� $��0��6    .+�5�      �� ��6      *
Mappings+$ :���� 5�      $	��2,5q�6$   �� 5�       6(   �� *MapController.AddMapCommand+.�6X   .�5�   "   �� ��6,   �� $) #MapController.AddMapCommand.Caption�5�      5�      �� 5�      $	��2,5q�6$   �� 5�       6(   �� * MapController.DeleteMapCommand+.�6[   .�5�   "   �� ��6,   �� $, &MapController.DeleteMapCommand.Caption�5�      5�      5�      &   System.Windows.Controls.DataGrid  5�      $��1��6   $
��Left=�5�         GridLinesVisibility$
 None=�6:      RowHeaderWidth$ 0Q�6U   $	��0,3q�6h   $	��300��6u      AutoGenerateColumns .     CanUserSortColumns .     CanUserAddRows .     CanUserDeleteRows .  #��["��5�      ��5�   ,   �� *MapController.Maps+ 6W   �� *MapController.SelectedMap+   Columns 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Q      Header 65     *
Terminal+    CellTemplate  5�   "   �� 5�   &   .R�5�   *   �� $��3q�64   ��6?   �� *TerminalName+5�   '   !   CellEditingTemplate! 5�   "   �� 5�   &   .R�5�   *   � " +� FocusedElement" 6/   �� # �� ElementName$# 
cbTerminal��.+�5�   .   �� $��
cbTerminal��67   $��Stretch=�6J    6h   �� *TerminalName+$ PropertyChanged=���5�   ;   �� *TerminalNames+5�   +   5�   '   5�        5�      $ * 6Q    65     *
UserRole+  5�   "   �� 5�   &   .R�5�   *   �� $��3q�64   ��6?   �� *UserRoleName+5�   '   ! 5�   "   �� 5�   &   .R�5�   *   � " 6/   �� $# 
cbUserRole��.+�5�   .   �� $��
cbUserRole��67   $��Stretch=�6J    6h   �� *UserRoleName+$ PropertyChanged=���5�   ;   �� *UserRoleNames+5�   +   5�   '   5�        5�      $ 2* 6S    65     *
Department+  5�   "   �� 5�   &   .R�5�   *   �� $��3q�64   ��6?   �� *DepartmentName+5�   '   ! 5�   "   �� 5�   &   .R�5�   *   � " 6/   �� $# cbDepartment��.+�5�   .   �� $��cbDepartment��67   $��Stretch=�6L    6j   �� *DepartmentName+$ PropertyChanged=���5�   3   �� *DepartmentNames+5�   +   5�   '   5�        5�      $ * 6S    65     *
TicketType+  5�   "   �� 5�   &   .R�5�   *   �� $��3q�64   ��6?   �� *TicketTypeName+5�   '   ! 5�   "   �� 5�   &   .R�5�   *   � " 6/   �� $# cbTicketType��.+�5�   .   �� $��cbTicketType��67   $��Stretch=�6K    6i   �� *TicketTypeName+$ PropertyChanged=���5�   2   �� *TicketTypeNames+5�   +   5�   '   5�      5�      5�      5�      5�      �� 5�   
   $��1��6   .+�5�      �� $
��Left=�6   $��0,10,3,0q�60   $��70��6B   ��6P   �� *SaveCommand.Caption+��5�      �� *SaveCommand+�� 5�      
���  ����6   �� *Error+6.   5�      5�      5�      