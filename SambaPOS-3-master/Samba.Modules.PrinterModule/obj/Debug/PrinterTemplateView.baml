   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls  5       Samba.Modules.PrinterModule5   /Samba.Modules.PrinterModule.PrinterTemplateView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6H   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6=   @d2http://schemas.microsoft.com/expression/blend/2008     5      ` \ICSharpCode.AvalonEdit, Version=4.2.0.8783, Culture=neutral, PublicKeyToken=9cc39be672370310?
avalonedit.http://icsharpcode.net/sharpdevelop/avalonedit  5      j
uiControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls  5      .��5      �   � ColumnDefinitions  5	   
   �� 5
      $��* �6   �� 5      $
��Auto �6   $	��400��6,   $	��200��6;    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6"   .+�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *TemplateName+   Suffix$ :���� 5      $	��200��6,   $
��Left=�6;   ��6   �� *Name+6;   �� 5      $��0,3,0,0q�6   $
��Left=�6I    d� 	IsChecked 6(   �� *
MergeLines+��6d     *
MergeLines+5      � 5   
   $��1��6   $��0��6    5      �� 5      $
��auto �6    �� 5      $��* �6    .+�5      �� $��0��6   ��6!     *
Template+$ :���� 5      $��1��6   $��1q�6"   #��["��66   ._�5       '  !ICSharpCode.AvalonEdit.TextEditor  $��Lucida Console)�6(   $��12(�6D      SyntaxHighlightingM  GICSharpCode.AvalonEdit.Highlighting.HighlightingDefinitionTypeConverter$ Template 6t   $	��250��6�   $	��200��6�   $   HorizontalScrollBarVisibility$
 Auto=�5!   (   "   VerticalScrollBarVisibility$ Visible=�6M      Document 5    R   �� *TemplateText+5!   M   5"      5#      ,� 5%   
   $��1��6#   $��0��63   $��2��6@   " ,� VerticalScrollBarVisibility$
 Auto=�6Q   $
��Left=�6t   .��5&      /� -   5        	 �Name$	 HelpDocument��5&      
 /� 
FontFamily$
 Segoe UI)�6/    /� FontSize$ 12(�6E   5'      �� 5)   
   $��2��6   $��0��6"   $��2��62   .+�5*      ��  �� Orientation$ 
Horizontal=�6   .+�5+      �� $
��Left=�6   $
��0,10q�64   $��70��6B   ��6P   �� *SaveCommand.Caption+��5,      �� *SaveCommand+;   5Samba.Presentation.Controls.UIControls.DropDownButton  5-      $
��5,10q�6E   $��70��6S   ��6,     *Load+   DropDown 5.      �� 5/      .@�50      m� ��6'     *TicketTemplate+ m� Command 6I   �� *LoadTicketTemplateCommand+6y   m� 51      ��6'     *KitchenOrderTemplate+ 6O   �� *!LoadKitchenOrderTemplateCommand+6�   m� 52      ��6'     *CustomerReceiptTemplate+ 6R   �� *LoadCustomerReceiptCommand+6�   53      55      56      �� 57      
���  ����6   �� *Error+6.   58      5:      5<      