   M S B A M L   `   `   `  ����  Samba.Modules.TicketModule/    )Samba.Modules.TicketModule.TicketTypeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5	      �� 5
      $Q Kpack://application:,,,/Samba.Presentation.Controls;component/OfficeTab.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Stretch=�6"      OfficeTabControl#��[  6@   .@�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *GeneralSettings+.��5      �� .+�5      �� $
��Left=�6   ��67     *Name_f+   FormatSegment1   *
TicketType+   Suffix$ :���� 5      $
��Left=�6   $	��200��69   ��6H   �� *Name+�� 5      ��6     *	POSMenu+$ :���� 5      $
��Left=�6   $	��150��6:    �� DisplayMemberPath$
 Name��5       �� SelectedValuePath$ Id��67   ��5   I   �� *ScreenMenus+ �� SelectedValue 5   N   �� *ScreenMenuId+�� 5      $	��120��6   ��6+     *TicketNumerator+$ :���� 5      $
��Left=�6   $	��170��6:   $
 Name��6I   ��6b   �� *
Numerators+	 �� SelectedItem	 5    &   �� *TicketNumerator+�� 5!      $	��120��6   ��6+     *OrderNumerator+$ :���� 5"      $
��Left=�6   $	��170��6:   $
 Name��6I   ��6b   �� *
Numerators+	 5#   &   �� *OrderNumerator+�� 5%      $	��120��6   ��6+     *TransactionType+$ :���� 5&      $
��Left=�6   $	��170��6:   $
 Name��6I   ��6b   �� *AccountTransactionTypes+	 5'   &   �� *SaleTransactionType+�� 5)      $
��0,10q�6a   
 d� 	IsChecked
 6   �� *TaxIncluded+��6A     *TaxIncluded+6a   5*      5+      �� 5,      ��6     *List_f+   *
EntityType+.��5-      �  5.      �� 5/      $
��Auto �6(   �� 50      $��* �6(   .+�52      ��  �� Orientation$ 
Horizontal=�6!   .+�53      �� $	��2,3q�6$   ��61     *
EntityType+$ :���� 54      $	��4,3q�6$   �� 55       �� Command 6(   �� *AddEntityTypeCommand+.�6Q   .�56   "   �� ��6,   ��  �� Path$" AddEntityTypeCommand.Caption�57      58      59      &   System.Windows.Controls.DataGrid  5:      $��Stretch=�6M      GridLinesVisibility$
 None=�5;         RowHeaderWidth$ 0Q�6:   $	��0,3q�6M   $��1��6Z      CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .     CanUserSortColumns .  #��["��5>      ��5:      �� *EntityTypeAssignments+   Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5@      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    MinWidth$	 100Q�5A   1      Header 5@   1     *
EntityType+1  +System.Windows.Controls.DataGridBoundColumn   Binding 5A   @   �� *EntityTypeName+  5B      $	 100Q�6J    61     *State+ 6Y   �� *State+4  .System.Windows.Controls.DataGridCheckBoxColumn  5C       65     *AskBeforeCreatingTicket+ 6`   �� *AskBeforeCreatingTicket+  5D       65     *Copy+ 6M   �� *CopyToNewTickets+5F      5G      5H      �� 5I      ��6     *	Mapping_f+   *Menu+.��5J      �  5K      �� 5L      $
��Auto �6(   �� 5M      $��* �6(   .+�5O      �� $ 
Horizontal=�6!   .+�5P      �� $	��2,3q�6$   ��61     *Menu+$ :���� 5Q      $	��4,3q�6$   �� 5R       6(   �� *AddMenuCommand+.�6K   .�5S   "   �� ��6,   �� $ AddMenuCommand.Caption�5T      5U      5V        5W      $��Stretch=�6G   $
 None=�5X      $ 0Q�6:   $	��0,3q�6M   $��1��6Z    .   .   .   .  #��["��5[      ��5W      �� *MenuAssignments+ 5\        5]       . $	 100Q�5^   1    5]   1     *
Terminal+ 5^   @   �� *TerminalName+4  .System.Windows.Controls.DataGridTemplateColumn  5_      $	 150Q�6M    65     *Menu+   CellTemplate 5`   "   �� 5a   &   .R�5b   *   �� $��3q�64   ��6?   �� *
MenuName+5c   '      CellEditingTemplate 5e   "   �� 5f   &   .R�5g   *   �  +� FocusedElement 6/   ��  �� ElementName$ cbMenu��.+�5h   .   �� $��cbMenu��67   $��Stretch=�6F   	 6d   �� *
MenuName+ �� UpdateSourceTrigger$ PropertyChanged=���5i   ;   �� *	MenuNames+5j   +   5k   '   5m      5o      5p      5q      5r      �� 5s   
   $��1��6   .+�5t      �� $
��Left=�6   $��0,10,3,0q�60   $��70��6B   ��6P   �� *SaveCommand.Caption+��5u      �� *SaveCommand+�� 5v      
���  ����6   �� *Error+6.   5w      5x      5y      