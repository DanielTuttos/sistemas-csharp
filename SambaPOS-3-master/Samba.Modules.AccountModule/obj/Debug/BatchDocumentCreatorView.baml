   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      E AFlexButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:FlexButton;assembly=FlexButton
FlexButton 5      V RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls 5       Samba.Modules.AccountModule:   4Samba.Modules.AccountModule.BatchDocumentCreatorView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9System&clr-namespace:System;assembly=mscorlib     5      C
FlexButton,clr-namespace:FlexButton;assembly=FlexButton     5      p
UIControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5      $��18(�5	      .��5      �   � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $
��Left=�6   $��Center=�6+   $��0��6F   $
��Bold"�6p   $��20(�6�   ��6V   �� *Title+6�   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6%   .+�5        FlexButton.FlexButton  $��70��6$   $��5q�62   $��5q�6>   ��6I   �� *GoBack+��6d   �� *GoBack.Caption+  5      $��70��6$   $��5q�62   $��5q�6>   ��6I   �� *Print+��6c   �� *Print.Caption+y�6�   �� *IsPrintButtonVisible+   VisibilityConverter �� 	Converter# [    5      $��70��6$   $��5q�62   $��5q�6>   ��6I   �� *CreateDocuments+��6m   �� *CreateDocuments.Caption+5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��MainDataGrid��5      $��1��6'   $��2��64   $��Stretch=�6i      HorizontalGridLinesBrush# ["��5         VerticalGridLinesBrush# ["��5         AutoGenerateColumns .     CanUserDeleteRows .     CanUserAddRows .  #��["��5       	   RowHeaderWidth$	 0Q�6X   $	��0,3q�6k   ��5   H   �� *
Accounts+
 � 	Resources
 5"      )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Triggers �� Binding �� Path �� Value �� Property �� Value*  $System.Windows.Controls.DataGridCell �� 
TargetType��%v  '        '  �     �� 5#      "  6    5$      �� 5%       6&   �� $ 
IsSelected� True6J   .a�5&      ��  � ��$
 Bold"�6;   5'      5)      �� 5*      "  6   .�5+      ��  � �� 5,      �� 5-      "  6.   .R�5.   "   � #��z��6'   .+�5/   &   �� $��Center=�67   $��3q�6R   50   #   51      53      54      55         Columns 56      4  .System.Windows.Controls.DataGridCheckBoxColumn  57      1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *
IsSelected+,  &System.Windows.Controls.DataGridColumn   Header 6H   4  .Samba.Localization.Extensions.LocTextExtension  *
Selected+0	  *System.Windows.Controls.DataGridTextColumn	  58         MinWidth$	 250Q�6%      
IsReadOnly .    SortDirection$ 	AscendingX�6�    64   �� *Account.Name+ 6g     *	Account+6�   	  59      $	 200Q�6%    64   �� *Description+ 6T     *Description+4
  .System.Windows.Controls.DataGridTemplateColumn
  5:      $ 60Q�6C     RightAlignedGridCell   	CellStyle# [ 6Q    6)     *Amount+ 
  CellTemplate 5;      �� 5<      .R�5=      �� $��5q�6(   ��63   �� $ Amount� �� StringFormat$ #,#0.00��5>       
  CellEditingTemplate 5@      �� 5A      .R�5B      �  +� FocusedElement 6#   ��  �� ElementName$	 tb1��.+�5C   "   <  6Samba.Presentation.Controls.UIControls.FilteredTextBox  $	��tb1��6�      Type$ Number=�6=   ��6K   �� $ Amount�$ #,#0.00��  �� Empty! �� TargetNullValue#! Z  6�   5D      5E      5G      5I      5J      5K      