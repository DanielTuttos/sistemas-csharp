   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls  5       Samba.Modules.PrinterModule-   'Samba.Modules.PrinterModule.PrinterView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      p
UIControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5      .��5      � .+�5	   
   �� .+�5
      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *PrinterName+    Suffix$  :���� 5      $
��Left=�6   $	��250��61   ��6=   �� *Name+�� 5      ��6     *ShareNameAndPortName+$  :���� 5      $
��Left=�6   $	��250��62    �� 
IsEditable . ��6S   �� *PrinterNames+ �� Text 5      �� *	ShareName+�� 5      ��6     *PrinterType+$  :���� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $
��Left=�6   $	��150��66   ��6E   �� *PrinterTypes+ �� SelectedItem 5      �� *PrinterType+�� 5      $	��5,0q�6   $
��Left=�6(   $	��100��6C   ��6R   �� *CustomPrinterNames+ 5      �� *CustomPrinterName+y�6F   �� *IsCustomPrinter+   VisibilityConverter �� 	Converter# [  �� 5      $	��2,5q�6   y�6)   �� *IsCustomPrinter+# [  �� 5       �� Command 6    �� *" EditCustomPrinterSettingsCommand+.�6U   .�5      �� ��6$   ��  �� Path$. (EditCustomPrinterSettingsCommand.Caption�5      5      5      �� 5      ��6     *CharacterSet+$  :��<   6Samba.Presentation.Controls.UIControls.FilteredTextBox  5         Type$ Digits=�6)   $
��Left=�67   $	��100��6R   ��6a   �� *
CodePage+�� 5      ��6     *	LineCount+$  :��  5       $ Digits=�6)   $
��Left=�67   $	��100��6R   ��6a   �� *
PageHeight+�� 5!      ��6     *LineCharacterCount+$  :��  5#      $ Digits=�6)   $
��Left=�67   $	��100��6R   ��6a   �� *CharsPerLine+�� 5$      $
��Left=�6   $
��0,10q�60   $��70��6>   ��6L   �� *SaveCommand.Caption+��5%      �� *SaveCommand+�� 5&      
���  ����6   �� *Error+6.   �� 5'      $	��250��65   $
��Left=�6D   $��WrapWithOverflow=�6_   ��6   �� *Description+6�   5(      5)      5*      