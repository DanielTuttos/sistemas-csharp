   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls  5       Samba.Modules.EntityModule1   +Samba.Modules.EntityModule.EntityScreenView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      p
UIControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5        � 	Resources  5       �� MergedDictionaries �� Source�� 5	   
    5
      �� 5      $Q Kpack://application:,,,/Samba.Presentation.Controls;component/OfficeTab.xaml?�6%   %    5      .��5      � -   5        $��MainGrid��5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Stretch=�6"      OfficeTabControl#��[  6@   .@�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *GeneralSettings+.��5      �� $
��Auto=�6   .��5      �� $��0��6!   $��0,0,20,0q�6.   .+�5      �� ��6      *Name+   Suffix$ :���� 5      $
��Left=�6"   $	��250��6=   ��6L   �� *Name+�� 5      ��6      *
TicketType+$ :���� 5      $
��Left=�6#   $	��170��6>    �� SelectedValuePath$ Id��5   G    �� DisplayMemberPath$
 Name��6^    �� SelectedValue 5   M   �� *TicketTypeId+��5   #   �� *TicketTypes+6^   �� 5      $	��0,5q�6i   ��6#     *AskTicketType+ d� 	IsChecked 6E   �� *AskTicketType+6i   �� 5      ��6      *
ViewMode+$ :���� 5      $
��Left=�6#   $	��150��6>   	 �� SelectedItem	 6M   �� *DisplayMode+��5    !   �� *DisplayModes+�� 5!      ��6      *BackgroundImage+$ :���� 5"      $
��Left=�6"   $	��250��6=   ��6L   �� *BackgroundImage+�� 5$      ��6      *SearchValueReplacePattern+$ :���� 5%      $
��Left=�6"   $	��150��6=   ��6L   �� *SearchValueReplacePattern+A� 5'      
 A� Columns$
 2��6&   $��0,5,0,0q�62   $
��Left=�6C   .+�5(      �� $��0,5,0,0q�6$   ��65     *ColumnCount+$ :��<   6Samba.Presentation.Controls.UIControls.FilteredTextBox  5)         Type$ Digits=�69   $��0,5,0,0q�6G   $
��Left=�6X   $��50��5*   %   ��63   �� *ColumnCount+�� 5+      $��0,5,0,0q�6$   ��65     *
RowCount+$ :��  5,      $ Digits=�69   $��0,5,0,0q�6G   $
��Left=�6X   $��50��5-   %   ��63   �� *
RowCount+�� 5.      $��0,5,0,0q�6$   ��65     *ButtonHeight+$ :��  5/      $ Digits=�69   $��0,5,0,0q�6G   $
��Left=�6X   $��50��50   %   ��63   �� *ButtonHeight+�� 51      $��0,5,0,0q�6$   ��65     *	PageCount+$ :��  52      $ Digits=�69   $��0,5,0,0q�6G   $
��Left=�6X   $��50��53   %   ��63   �� *	PageCount+�� 54      $��0,5,0,0q�6$   ��65     *
FontSize+$ :��  55      $ Digits=�69   $��0,5,0,0q�6G   $
��Left=�6X   $��50��56   %   ��63   �� *
FontSize+57      58      59      5:      �� 5;      ��6     *List_f+   FormatSegment1   *Entity+.��5<      �  5=      �� 5>      $
��auto �6(   �� 5?      $��* �6(   .+�5A      �� .+�5B      �� $��0��6%   .+�5C      �� ��6$     *
EntityType+$ :���� 5D       �� 
IsEditable . $
��Left=�69   $	��150��6T   $ Id��5E   E   $
 Name��6\    5D   c   �� *EntityTypeId+��5E   !   �� *EntityTypes+6\   �� 5F      ��6$     *DisplayState+$ :���� 5I      $
��Left=�6D   $	��150��6_   ��6&   �� *DisplayState+6p   �� 5J      ��6$     *StateFilter+$ :���� 5K       . $
��Left=�69   $	��150��6T   $
 Name��5L   F   $
 Name��6_    5K   c   �� *StateFilter+��5L   !   �� *EntityStates+6_   �� 5M       �� Orientation$ 
Horizontal=�6)   .+�5N   "   �� ��6(     *
Entities+$ :���� 5O   "   $	��2,5q�6,   �� 5P   "    �� Command 6,   �� *SelectScreenItemsCommand+.�6Y   .�5Q   &   �� ��60   ��  �� Path$&  SelectScreenItemsCommand.Caption�5R   #   5S      5T      5U      5V      �� 5W      $��1��6   $
 Name��6a   $	��150��6z   $	��150��5X      $��1q�6)   ��5W   +   �� *EntityScreenItems+ �� Mode$ OneWay=�5X   )   5Y      5Z      �� 5[      ��6     *
Mappings+.��5\      �  5]      �� 5^      $
��auto �6(   �� 5_      $��* �6(   .+�5a      ]� $��0��6    .+�5b      �� ��6      *
Mappings+$ :���� 5c      $	��2,5q�6$   �� 5d       6(   �� *MapController.AddMapCommand+.�6X   .�5e   "   �� ��6,   �� $) #MapController.AddMapCommand.Caption�5f      5g      �� 5h      $	��2,5q�6$   �� 5i       6(   �� * MapController.DeleteMapCommand+.�6[   .�5j   "   �� ��6,   �� $, &MapController.DeleteMapCommand.Caption�5k      5l      5m      &   System.Windows.Controls.DataGrid  5o      $��1��6   $
��Left=�5p         GridLinesVisibility$
 None=�6:      RowHeaderWidth$ 0Q�6U   $	��0,3q�6h   $	��300��6u      AutoGenerateColumns .     CanUserSortColumns .     CanUserDeleteRows .     CanUserAddRows .  #��["��5r      ��5o   ,   �� *MapController.Maps+	 6W   �� *MapController.SelectedMap+   Columns 5s      4  .System.Windows.Controls.DataGridTemplateColumn  5t      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Q      Header 65     *
UserRole+   CellTemplate 5u   "   �� 5v   &   .R�5w   *   �� $��3q�64   ��6?   �� *UserRoleName+5x   '      CellEditingTemplate 5z   "   �� 5{   &   .R�5|   *   �  +� FocusedElement 6/   ��  �� ElementName$ 
cbUserRole��.+�5}   .   �� $��
cbUserRole��67   $��Stretch=�6J   	 6h   �� *UserRoleName+ �� UpdateSourceTrigger$ PropertyChanged=���5~   ;   �� *UserRoleNames+5   +   5�   '   5�        5�      $ 2* 6S    65     *
Department+ 5�   "   �� 5�   &   .R�5�   *   �� $��3q�64   ��6?   �� *DepartmentName+5�   '    5�   "   �� 5�   &   .R�5�   *   �  6/   �� $ cbDepartment��.+�5�   .   �� $��cbDepartment��67   $��Stretch=�6L   	 6j   �� *DepartmentName+$ PropertyChanged=���5�   3   �� *DepartmentNames+5�   +   5�   '   5�        5�      $ * 6S    65     *
TicketType+ 5�   "   �� 5�   &   .R�5�   *   �� $��3q�64   ��6?   �� *TicketTypeName+5�   '    5�   "   �� 5�   &   .R�5�   *   �  6/   �� $ cbTicketType��.+�5�   .   �� $��cbTicketType��67   $��Stretch=�6K   	 6i   �� *TicketTypeName+$ PropertyChanged=���5�   2   �� *TicketTypeNames+5�   +   5�   '   5�      5�      5�      5�      5�      �� 5�   
   $��1��6   $��2��6"   .+�5�      �� $
��Left=�6   $
��0,10q�60   $��70��6>   ��6L   �� *SaveCommand.Caption+��5�      �� *SaveCommand+�� 5�      
���  ����6   �� *Error+6.   5�      5�      5�      