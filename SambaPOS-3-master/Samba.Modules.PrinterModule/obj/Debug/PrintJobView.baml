   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.ListViewLM;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.ListViewLM  5       Samba.Modules.PrinterModule.   (Samba.Modules.PrinterModule.PrintJobView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6A   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6E   @d2http://schemas.microsoft.com/expression/blend/2008     5      p
ListViewLMYclr-namespace:Samba.Presentation.Controls.ListViewLM;assembly=Samba.Presentation.Controls     5        � 	Resources  5       �� 
TargetType   GridBlockStyle �� Property �� Value �� Path �� RelativeSource �� AncestorType  VisibilityConverter �� 	Converter �� ConverterParameter  GridEditStyle��%�  &	        7  &	 �     7  '�� a    �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5	       � y� 6+   �� $ 
IsSelected� �� *FindAncestor+" ��8   $ False��5
      �� 5   
   " �6   .�5      ��  � ��$ Center=�62   �� 5       � y� 6+   �� $ 
IsSelected� �� *FindAncestor+" ��8   $
 True��5      �� 5   
   " ��6   .�5      ��  � ��$ Stretch=�6;   5      5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   .+�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *Name_f+
   FormatSegment1
   *
PrintJob+   Suffix$ :���� 5      $
��Left=�6   $	��250��61   ��6=   �� *Name+�� 5      ��6     *PrintContent+�� 5      $
��Left=�6   $	��230��62    �� SelectedItem 6A   �� *WhatToPrint+��5      �� *WhatToPrintTypes+�� 5      $��0,5,0,2q�68    d� 	IsChecked 6   �� *
ExcludeTax+��6I     *AlwaysExcludeTax+�� 5       $��0,2,0,5q�6?    6   �� *UseForPaidTickets+��6P     *UseAtOldTickets+�� 5!       �� Orientation$ 
Horizontal=�6   .+�5"      �� ��6     *PrintMapping+$ :���� 5#      $	��2,5q�6   �� 5$       �� Command 6    �� *AddPrinterMapCommand+.�6I   .�5%      �� ��6$   �� $" AddPrinterMapCommand.Caption�5&      5'      �� 5(      $	��2,5q�6   �� 5)       6    �� *DeletePrinterMapCommand+.�6L   .�5*      �� ��6$   �� $% DeletePrinterMapCommand.Caption�5+      5,      5-      5.      �� 50   
   $��1��6   $��Stretch=�51      B   <Samba.Presentation.Controls.ListViewLM.ListViewLayoutManager   Enabled . ��50       �� *PrinterMaps+ 6D   �� *SelectedPrinterMap+ �� View 52      �� 53      .P�54      �� ?   9Samba.Presentation.Controls.ListViewLM.ProportionalColumn   Width$ 1Q�6F   ��6%     *MenuItemGroup+ �� CellTemplate 55      �� 56      .R�57   "   � .+�58   &   �� #��[  60   $��Stretch=�6X   ��6v   �� *MenuItemGroupCodeLabel+�� 59   &   #��[ 6/   $��Stretch=�6V    6t   �� *MenuItemGroupCode+��5:   *   �� *MenuItemGroupCodes+5;   #   5<      5>      �� 5?      $	 1.5Q�6A   ��6%     *
MenuItem+ 5@      �� 5A      .R�5B   "   � .+�5C   &   �� #��[  60   $��Stretch=�6X   ��6v   �� *MenuItemLabel+�� 5D   &   #��[ 6/   $��Stretch=�6V    �� DisplayMemberPath$
 Name��6t    �� SelectedValuePath$ Id��5E   /    �� SelectedValue 6F   �� *
MenuItemId+��6k   �� *	MenuItems+5F   #   5G      5I      �� 5J      $	 1.5Q�6@   ��6%     *	Printer+ 5K      �� 5L      .R�5M   "   � .+�5N   &   �� #��[  60   $��Stretch=�6X   ��6v   �� *PrinterLabel+�� 5O   &   #��[ 6/   $��Stretch=�6V   $
 Name��6t   $ Id��5P   )    6@   �� *	PrinterId+��6d   �� *
Printers+5Q   #   5R      5T      �� 5U      $	 1.5Q�6H   ��6%     *PrinterTemplate+ 5V      �� 5W      .R�5X   "   � .+�5Y   &   �� #��[  60   $��Stretch=�6X   ��6v   �� *PrinterTemplateLabel+�� 5Z   &   #��[ 6/   $��Stretch=�6V   $
 Name��6t   $ Id��5[   /    6F   �� *PrinterTemplateId+��6r   �� *PrinterTemplates+5\   #   5]      5_      5`      5b      �� 5c   
   $��2��6   .+�5d      �� $
��Left=�6   $	��0,5q�60   $��80��6=   ��6K   �� *SaveCommand+��5e      �� *SaveCommand.Caption+�� 5f      
���  ����6   �� *Error+6.   5g      5h      5i      