   M S B A M L   `   `   `  ����\  XPropertyTools.Wpf, Version=2012.4.14.1, Culture=neutral, PublicKeyToken=ea0c9f2b460934d0P:clr-namespace:PropertyTools.Wpf;assembly=PropertyTools.WpfPropertyTools.Wpf  5      V RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls 5       Samba.Modules.TicketModule8   2Samba.Modules.TicketModule.CalculationSelectorView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      \PropertyEditorLibrary:clr-namespace:PropertyTools.Wpf;assembly=PropertyTools.Wpf     5      p
uiControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5        � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $Q Kpack://application:,,,/Samba.Presentation.Controls;component/OfficeTab.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   ��    OfficeTabControl#��[  6   .@�5      �� $��General Settings��6   .��5      �� .+�5      �� $
��Left=�6   ��67   4  .Samba.Localization.Extensions.LocTextExtension  *Name+   Suffix$ :���� 5      $
��Left=�6   $	��200��69   ��6H   �� *Name+�� 5      $
��Left=�6   ��67     *ButtonHeader+$ :���� 5      $
��Left=�6   $	��200��69   ��6H   �� *ButtonHeader+�� 5      $
��Left=�6   ��67     *ButtonColor+$ :��$   PropertyTools.Wpf.ColorPicker2  5       $
��Left=�69   $	��150��6T      SelectedColor 5!      �� *ButtonColor+�� 5"      $
��Left=�6   ��67     *
FontSize+$ :��<  6Samba.Presentation.Controls.UIControls.FilteredTextBox  5#      $
��Left=�61   $	��150��6L      Type$ Digits=�6u   ��6[   �� *
FontSize+6u   �� 5$       �� Orientation$ 
Horizontal=�6!   $��0,10,0,0q�6:   .+�5%      &   System.Windows.Controls.DataGrid  $	��170��6#   $��Stretch=�5&   &      GridLinesVisibility$
 None=�6D   	   RowHeaderWidth$	 0Q�6_   $	��0,3q�6r   
   CanUserDeleteRows
 .     CanUserAddRows .     AutoGenerateColumns .     CanUserSortColumns .     
IsReadOnly . #��["��5'   o   ��5%   2   �� *CalculationTypes+ �� SelectedItem 6[   �� *SelectedCalculationType+ �� Mode$ TwoWay=�   Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)   "   ,  &System.Windows.Controls.DataGridColumn   MinWidth$	 100Q�5*   .      Header 5)   5     *CalculationType+1  +System.Windows.Controls.DataGridBoundColumn   Binding 5*   =   �� *Name+ � ContextMenu 5,      �� 5-   "   .@�5.   &   m�  m� Command 6/   �� *AddCalculationTypeCommand+��6]   �� *#!AddCalculationTypeCommand.Caption+m� 5/   &    6/   �� *DeleteCalculationTypeCommand+��6`   �� *&$DeleteCalculationTypeCommand.Caption+50   #   52      �� 53      $��10q�6%   .+�54      �� $	��2,3q�6(   �� 55   *    �� Command 64   �� *AddCalculationTypeCommand+.�6b   .�56   .   �� ��68   ��  �� Path$' !AddCalculationTypeCommand.Caption�57   +   58   '   �� 59      $	��2,3q�6(   �� 5:   *    64   �� *DeleteCalculationTypeCommand+.�6e   .�5;   .   �� ��68   �� $* $DeleteCalculationTypeCommand.Caption�5<   +   5=   '   5>      5?      5@      5A      �� 5C      ��6     *
Mappings+.��5D      �  5E      �� 5F      $
��auto �6(   �� 5G      $��* �6(   .+�5I      ]� $��0��6    .+�5J      �� ��6      *
Mappings+$ :���� 5K      $	��2,5q�6$   �� 5L       6(   �� *MapController.AddMapCommand+.�6X   .�5M   "   �� ��6,   �� $) #MapController.AddMapCommand.Caption�5N      5O      �� 5P      $	��2,5q�6$   �� 5Q       6(   �� * MapController.DeleteMapCommand+.�6[   .�5R   "   �� ��6,   �� $, &MapController.DeleteMapCommand.Caption�5S      5T      5U        5W      $��1��6   $
��Left=�5X      $
 None=�6:   $	 0Q�6U   $	��0,3q�6h   $	��300��6u    .   .   .  
 .  #��["��5Z      ��5W   ,   �� *MapController.Maps+ 6W   �� *MapController.SelectedMap+ 5[      4  .System.Windows.Controls.DataGridTemplateColumn  5\         Width5	  /System.Windows.Controls.DataGridLengthConverter$ *	 6Q    65     *
UserRole+   CellTemplate 5]   "   �� 5^   &   .R�5_   *   �� $��3q�64   ��6?   �� *UserRoleName+5`   '      CellEditingTemplate 5b   "   �� 5c   &   .R�5d   *   �  +� FocusedElement 6/   ��  �� ElementName$ 
cbUserRole��.+�5e   .   �� $��
cbUserRole��67   $��Stretch=�6J    6h   �� *UserRoleName+ �� UpdateSourceTrigger$ PropertyChanged=���5f   ;   �� *UserRoleNames+5g   +   5h   '   5j        5k      $ 2*	 6S    65     *
Department+ 5l   "   �� 5m   &   .R�5n   *   �� $��3q�64   ��6?   �� *DepartmentName+5o   '    5q   "   �� 5r   &   .R�5s   *   �  6/   �� $ cbDepartment��.+�5t   .   �� $��cbDepartment��67   $��Stretch=�6L    6j   �� *DepartmentName+$ PropertyChanged=���5u   3   �� *DepartmentNames+5v   +   5w   '   5y        5z      $ *	 6S    65     *
TicketType+ 5{   "   �� 5|   &   .R�5}   *   �� $��3q�64   ��6?   �� *TicketTypeName+5~   '    5�   "   �� 5�   &   .R�5�   *   �  6/   �� $ cbTicketType��.+�5�   .   �� $��cbTicketType��67   $��Stretch=�6K    6i   �� *TicketTypeName+$ PropertyChanged=���5�   2   �� *TicketTypeNames+5�   +   5�   '   5�      5�      5�      5�      5�      �� 5�   
   $��1��6   .+�5�      �� $ 
Horizontal=�6   .+�5�      �� $
��Left=�6   $��0,10,3,0q�64   $��70��6F   ��6T   �� *SaveCommand.Caption+��5�      �� *SaveCommand+5�      �� 5�      
���  ����6   �� *Error+6.   5�      5�      5�      