   M S B A M L   `   `   `  ����  Samba.Modules.BasicReports+    %Samba.Modules.BasicReports.ReportView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6>   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6=   @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      �   � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6"   {�62   �� *CanUserChangeDates+.+�5      �� ��6   �� *FilterGroups+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6%   5      ��5      �� 5      .R�5      �� $��16(�6#   $��3q�61   ��6<   �� *Values+ �� SelectedItem 6[   �� *SelectedValue+ �� Mode$ TwoWay=�5      5      5      5      �� 5   
   $��0��6   $��1��6"   $ 
Horizontal=�62   {�6K   �� *CanUserChangeDates+.+�5      �� $��3q�6   $��16(�6!   $��60��6/   ��6=   �� *StartDateString+$ TwoWay=� �� UpdateSourceTrigger$ 	LostFocus=��� 5       $��3q�6   $��16(�6!   $��60��6/   ��6=   �� *EndDateString+$ TwoWay=�$ 	LostFocus=�5!      �� 5"   
   $��0��6   $��2��6"   $ 
Horizontal=�62   .+�5#      �� $��3q�6   $��16(�6    $��60��6.   ��6<   4  .Samba.Localization.Extensions.LocTextExtension  *	Refresh+��5$      �� *RefreshFiltersCommand+�� 5%      $��3q�6   $��16(�6    $��60��6.   ��6<   �� *PrintDocumentCommand+��5&        *Print+�� 5'      $��3q�6   $��16(�6    $��60��6.   ��6<   �� *SaveDocumentCommand+��5(      �� *SaveDocumentCommand.Caption+5)      ,� 5*   
   $��1��6#   $��0��60   $��3��6@   ��6T   �� *
Document+5,      5-      