   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   C   E AFlexButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:FlexButton;assembly=FlexButton
FlexButton 5       Samba.Modules.TicketModule3   -Samba.Modules.TicketModule.TicketExplorerView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6F   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6=   @d2http://schemas.microsoft.com/expression/blend/2008     5      6sys&clr-namespace:System;assembly=mscorlib     6C   C
FlexButton,clr-namespace:FlexButton;assembly=FlexButton     5      $��20(�6_   .��5      � $��0,5,5,0q�6     � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5	      $
��auto �6   �� 5
      $��* �6   �� 5      $
��auto �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��auto �6#   .+�5      � {�6   �� *CanChanageDateFilter+ 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $
��auto �6'   �� 5      $
��auto �6'   .+�5      (  "System.Windows.Controls.DatePicker  $��16(�6   $��0��6+   $��5,0,0,0q�6;   $��1q�6o      SelectedDate 6L   �� *	StartDate+ � LayoutTransform 5      �� 5       �� ScaleY$ 2Q�6)    �� ScaleX$ 2Q�64   5        5      $��16(�6   $��1��6+   $��5,0,0,0q�6;   $��1q�6m    6L   �� *	EndDate+ 5      �� 5       $ 2Q�6)   $ 2Q�64   5"      �� 5#      $��50��6   $��2��6'   $��5,0,5,0q�67   ��6H   �� *PreviousWorkPeriod.Caption+��5$      �� *PreviousWorkPeriod+�� 5%      $��50��6   $��3��6'   ��67   �� *NextWorkPeriod.Caption+��5&      �� *NextWorkPeriod+5'      �� 5(      $��1��6   $��50��6%   $��5,0,0,0q�63   ��6D   �� *RefreshDatesCommand+��6l   4  .Samba.Localization.Extensions.LocTextExtension  *	Refresh+5*      �� 5+   
   $��1��6   $��5,3,0,3q�6D   ��6$   �� *	Filters+��5,      �� 5-      .R�5.      �  5/      �� 50      $��* �6/   �� 51      $
��auto �6/   .+�53      ��  �� SelectedItem 6#   �� *
FilterType+��6G   �� *FilterTypes+54      �� 55      $��1��6#   $	��200��63   $��3,0,0,0q�6B    �� 
IsEditable .  �� Text 6S   �� *FilterValue+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=���56      �� *FilterValues+{�6U   �� *IsTextBoxEnabled+ � 	Resources 57      ��%X   (��       58   -   *,*SystemParameters.VerticalScrollBarWidthKey+)X�6"   0Q�6n   59      5:      5;      5<      5>      &   System.Windows.Controls.DataGrid  5?   
   -   5        $��DataGrid��5?      $��2��6#      
IsReadOnly .    AutoGenerateColumns .     HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �����   SelectionMode$ Single=�5A   P      HeadersVisibility$ Column=�5B   =    $� IsVirtualizing . $��5,0,0,0q�5C         AlternatingRowBackground
 �����   GridLinesVisibility$	 All=�5D   3      RowDetailsVisibilityMode$ VisibleWhenSelected=�5E      ��5?   0   �� *	Tickets+ 6P   �� *SelectedRow+   Columns 5F      0  *System.Windows.Controls.DataGridTextColumn  5G      ,  &System.Windows.Controls.DataGridColumn   Header 6%     *Number+1  +System.Windows.Controls.DataGridBoundColumn   Binding 5H      �� *TicketNumber+  5I       6%     *Date+ 5J      �� *Date+  5K       6%     *OpenClose_ab+ 5L      �� *
TimeInfo+  5M         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6C    6%     *
TicketNote+ 5N      �� *
TicketNote+  5O         MinWidth$ 65Q�5P   E      RightAlignedCellStyle   	CellStyle# [  6S    5O   %     *Total+ 5P      �� *Sum+ �� StringFormat$ #,#0.00��6S    5R      ��%Y   (��       5S      *,*SystemParameters.VerticalScrollBarWidthKey+)X�6   30Q�6_   5T         RowDetailsTemplate 5U      �� 5V      .R�5W      � $	��114��6   
������� 5X      �� 5Y      $��9* �6/   �� 5Z      $��* �6/   .+�5\      �� $��0��6!   
�������$��1q�6F   ._�5]      �� $��0��6+   $��3,2,0,0q�6;   .��5^   "   �� $��0q�6O   
������ ��6/   �� *	Details+6c   5_      5`      A� 5a       A� Rows$ 2��6&   $��1��6/   .+�5b        FlexButton.FlexButton  ��5c   !   �� *" DataContext.DisplayTicketCommand+ �� RelativeSource ��   �� Mode$  FindAncestor=�! �� AncestorType"! ����5d   !   �� **(DataContext.DisplayTicketCommand.Caption+ �� $  FindAncestor=�"! ��5e      5f      5g      5i      �� 5j   
   $��3��6   $��3q�6!   " �� TextAlignment$" Right=�6,   $
��Bold"�6\   ��6B   �� *
TotalStr+6\   5k      5l      