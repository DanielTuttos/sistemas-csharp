   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls  5       Samba.Modules.TicketModule4   .Samba.Modules.TicketModule.CalculationTypeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      p
UIControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� .+�5      �� $
��Left=�6   ��6/   4  .Samba.Localization.Extensions.LocTextExtension  *TemplateName+   Suffix$ :���� 5      $
��Left=�6   $	��200��61   ��6@   �� *Name+�� 5      $	��120��6   ��6#     *AccountTransactionType+$ :���� 5      $
��Left=�6   $	��170��62    �� DisplayMemberPath$
 Name��6A   ��6Z   �� *AccountTransactionTypes+ �� SelectedItem 5      �� *AccountTransactionType+�� 5      $
��Left=�6   ��6/     *CalculationMethod+$ :���� 5      $
��Left=�6   $	��250��62   ��6A   �� *CalculationMethods+ 5      �� *SelectedCalculationMethod+5      �� 5      $
��Left=�6   ��6/     *RateOrAmount+$ :��<   6Samba.Presentation.Controls.UIControls.FilteredTextBox  5      $
��Left=�6)   $��50��6D      Type$ Number=�6R   ��5      �� *Amount+�� 5      $
��Left=�6   $��Max Amount:��6/     5      $
��Left=�6)   $��50��6D   $ Number=�6R   ��5      �� *	MaxAmount+�� 5      $��0,5,0,0q�6    d� 	IsChecked 6(   �� *
IncludeTax+��6I     *
IncludeTax+�� 5        6   �� *DecreaseAmount+��6<     *DecreaseAmount+�� 5!       6   �� *UsePlainSum+��69     *UsePlainSum+�� 5"       6   �� *ToggleCalculation+��6?     *ToggleCalculation+5#      �� 5%   
   $��1��6   .+�5&      ��  �� Orientation$ 
Horizontal=�6   .+�5'      �� $
��Left=�6   $��0,10,3,0q�64   $��70��6F   ��6T   �� *SaveCommand.Caption+��5(      �� *SaveCommand+5)      �� 5*      
���  ����6   �� *Error+6.   5+      5-      5.      