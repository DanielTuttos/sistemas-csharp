   M S B A M L   `   `   `  ����\  XPropertyTools.Wpf, Version=2012.4.14.1, Culture=neutral, PublicKeyToken=ea0c9f2b460934d0P:clr-namespace:PropertyTools.Wpf;assembly=PropertyTools.WpfPropertyTools.Wpf  5      V RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls 5      " Samba.Modules.AutomationModule:   4Samba.Modules.AutomationModule.AutomationCommandView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      JWpf:clr-namespace:PropertyTools.Wpf;assembly=PropertyTools.Wpf     5      p
uiControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5        � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $Q Kpack://application:,,,/Samba.Presentation.Controls;component/OfficeTab.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Stretch=�6"      OfficeTabControl#��[  6@   .@�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *GeneralSettings+.��5      �  5      �� 5      $
��Auto �6(   �� 5      $��* �6(   .+�5      �� .+�5      �� ��6      *Name+   Suffix$ :���� 5      $	��200��68   $
��Left=�6G   ��6"   �� *Name+6G   �� 5       ��6      *ButtonHeader+$ :���� 5!      $	��200��6@   $
��Left=�6O   ��6"   �� *ButtonHeader+6O   �� 5"      ��6      *Color+$ :��$   PropertyTools.Wpf.ColorPicker2  5#      $
��Left=�6+   $	��150��6F      SelectedColor 5$      �� *Color+�� 5%      $
��Left=�6    ��6;     *
FontSize+$ :��<  6Samba.Presentation.Controls.UIControls.FilteredTextBox  5&      $
��Left=�65   $	��150��6P      Type$ Digits=�6y   ��6_   �� *
FontSize+6y   �� 5'      $	��0,5q�6#    d� 	IsChecked 60   �� *ToggleValues+��6S     *ToggleValues+�� 5(      ��6      *Values+$ :��5)      �� 5+      $��1��6    �� AcceptsReturn . "	 �� VerticalScrollBarVisibility$
	 Auto=�6X   
 �� MinLines$
 3��6{   $	��200��6�   $
��Left=�6�   $	��Top=�6�   ��6+   �� *Values+6�   5,      5.      �� 50      ��6     *
Mappings+.��51      �  52      �� 53      $
��auto �6(   �� 54      $��* �6(   .+�56      ]� $��0��6    .+�57      �� ��6      *
Mappings+$ :���� 58      $	��2,5q�6$   �� 59       �� Command 6(   �� *MapController.AddMapCommand+.�6X   .�5:   "   �� ��6,   ��  �� Path$) #MapController.AddMapCommand.Caption�5;      5<      �� 5=      $	��2,5q�6$   �� 5>       6(   �� * MapController.DeleteMapCommand+.�6[   .�5?   "   �� ��6,   �� $, &MapController.DeleteMapCommand.Caption�5@      5A      5B      &   System.Windows.Controls.DataGrid  5D      $��1��6   $
��Left=�5E         GridLinesVisibility$
 None=�6:      RowHeaderWidth$ 0Q�6U   $	��0,3q�6h   $	��300��6u      AutoGenerateColumns .     CanUserSortColumns .     CanUserAddRows .     CanUserDeleteRows .  #��["��5G      ��5D   ,   �� *MapController.Maps+ �� SelectedItem 6W   �� *MapController.SelectedMap+   Columns 5H      4  .System.Windows.Controls.DataGridTemplateColumn  5I      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Q      Header 65     *
Terminal+   CellTemplate 5J   "   �� 5K   &   .R�5L   *   �� $��3q�64   ��6?   �� *TerminalName+5M   '      CellEditingTemplate 5O   "   �� 5P   &   .R�5Q   *   �  +� FocusedElement 6/   ��  �� ElementName$ 
cbTerminal��.+�5R   .   �� $��
cbTerminal��67   $��Stretch=�6J    6h   �� *TerminalName+ �� UpdateSourceTrigger$ PropertyChanged=���5S   ;   �� *TerminalNames+5T   +   5U   '   5W        5X      $ * 6Q    65     *
UserRole+ 5Y   "   �� 5Z   &   .R�5[   *   �� $��3q�64   ��6?   �� *UserRoleName+5\   '    5^   "   �� 5_   &   .R�5`   *   �  6/   �� $ 
cbUserRole��.+�5a   .   �� $��
cbUserRole��67   $��Stretch=�6J    6h   �� *UserRoleName+$ PropertyChanged=���5b   ;   �� *UserRoleNames+5c   +   5d   '   5f        5g      $ 2* 6S    65     *
Department+ 5h   "   �� 5i   &   .R�5j   *   �� $��3q�64   ��6?   �� *DepartmentName+5k   '    5m   "   �� 5n   &   .R�5o   *   �  6/   �� $ cbDepartment��.+�5p   .   �� $��cbDepartment��67   $��Stretch=�6L    6j   �� *DepartmentName+$ PropertyChanged=���5q   3   �� *DepartmentNames+5r   +   5s   '   5u        5v      $ * 6S    65     *
TicketType+ 5w   "   �� 5x   &   .R�5y   *   �� $��3q�64   ��6?   �� *TicketTypeName+5z   '    5|   "   �� 5}   &   .R�5~   *   �  6/   �� $ cbTicketType��.+�5   .   �� $��cbTicketType��67   $��Stretch=�6K    6i   �� *TicketTypeName+$ PropertyChanged=���5�   2   �� *TicketTypeNames+5�   +   5�   '   5�      0  *System.Windows.Controls.DataGridTextColumn  5�      $ Enabled States��61   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6I   �� *EnabledStates+  5�      $ Visible States��61    6I   �� *VisibleStates+  5�      $ 
Visibility��65   $ 2* 6I    5�   "   �� 5�   &   .R�5�   *   �� $��3q�64   ��6?   �� *Screen+5�   '    5�   "   �� 5�   &   .R�5�   *   �  6/   �� $ cbVisibility��.+�5�   .   �� $��cbVisibility��67    �� 
IsEditable .  ��6^   �� *	Screens+ 5�   ?   �� $ Screen�$ PropertyChanged=�5�   +   5�   '   5�      5�      5�      5�      5�      �� 5�   
   $��1��6   .+�5�      �� $
��Left=�6   $��0,10,3,0q�60   $��70��6B   ��6P   �� *SaveCommand.Caption+��5�      �� *SaveCommand+�� 5�      
���  ����6   �� *Error+6.   5�      5�      5�      