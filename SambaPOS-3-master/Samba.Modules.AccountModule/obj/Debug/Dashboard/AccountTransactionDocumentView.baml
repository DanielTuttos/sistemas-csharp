   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls  5       Samba.Modules.AccountModuleJ   DSamba.Modules.AccountModule.Dashboard.AccountTransactionDocumentView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      p
UIControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   ]� $��0,3,0,3q�6   .+�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *Name_f+   FormatSegment1   *TransactionDocument+   Suffix$ :���� 5      $��Center=�6,   ��6   �� *Name+6P   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��DataGrid��5      $��1��6#      AutoGenerateColumns .     RowHeaderWidth$ 0Q�6x      HorizontalGridLinesBrush
 �����   VerticalGridLinesBrush
 �������60   �� *AccountTransactions+ �� SelectedItem 5      �� *SelectedTransaction+ �� Mode$ TwoWay=�	   Columns	 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header
 6)     *Transaction+   CellTemplate 5      �� 5      .R�5      �� $��3q�6(   ��63   �� *AccountTransactionType.Name+5         CellEditingTemplate 5      �� 5       .R�5!      �  +� FocusedElement 6#   ��  �� ElementName$ cb��.+�5"   "   �� $��cb��6+    �� 
IsEditable .  �� DisplayMemberPath$
 Name��5%   +   ��5#   +   �� *AccountTransactionTypes+ 5$   +   �� *AccountTransactionType+ �� UpdateSourceTrigger$ PropertyChanged=�5%   +   5&      5'      5)        5+      
 6)     *Source+ 5,      �� 5-      .R�5.      �� $��3q�6(   ��63   �� *SourceAccount.Name+5/       51      �� 52      .R�53      �  6#   �� $	 cb1��.+�54   "   �� $	��cb1��6+    . $
 Name��57   +   ��55   +   �� *SourceAccounts+ 56   +   �� *SourceAccount+$ PropertyChanged=�57   +   58      59      5;        5=      
 6)     *Target+ 5>      �� 5?      .R�5@      �� $��3q�6(   ��63   �� *TargetAccount.Name+5A       5C      �� 5D      .R�5E      �  6#   �� $	 cb2��.+�5F   "   �� $	��cb2��6+    . $
 Name��5I   +   ��5G   +   �� *TargetAccounts+ �� SelectedValue 5H   +   �� *TargetAccount+$ PropertyChanged=�5I   +   5J      5K      5M        5O         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6H   
 6)     *Description+ 5P      �� 5Q      .R�5R      �� $��3q�6(   ��63   �� *Name+5S       5U      �� 5V      .R�5W      �  6#   �� $	 tx3��.+�5X   "   �� $	��tx3��6L   $��Center=�6*   ��6W   �� *Name+5Y      5Z      5\        5^      
 6)     *Amount+ 5_      �� 5`      .R�5a      �� $��3q�6(    �� TextAlignment$ Right=�63   ��6I   �� *Amount+ �� StringFormat$ #,#0.00��5b       5d      �� 5e      .R�5f      �  6#   �� $	 cb3��.+�5g   "   <   6Samba.Presentation.Controls.UIControls.FilteredTextBox  $	��cb3��6_   $��Center=�6=      Type$ Number=�6j   ��6x   �� *Amount+5h      5i      5k      5m      �� 5n   
   $��2��6   .+�5o      ��  �� Orientation$ 
Horizontal=�6   .+�5p      �� $
��Left=�6   $��	0,10,0,10q�64   $��70��6G   ��6U   �� *SaveCommand.Caption+��5q      �� *SaveCommand+�� 5r      $
��Left=�6   $��
10,10,0,10q�64   $��70��6H   ��6V   �� *AddItemCommand.Caption+��5s      �� *AddItemCommand+�� 5t      $
��Left=�6   $��
10,10,0,10q�64   $��70��6H   ��6V   �� *DeleteItemCommand.Caption+��5u      �� *DeleteItemCommand+�� 5v      $
��Left=�6   $��
10,10,0,10q�64   $��70��6H   ��6V   �� *PrintCommand.Caption+��5w      �� *PrintCommand+5x      �� 5y      
���  ����6   �� *Error+6.   5z      5{      5|      