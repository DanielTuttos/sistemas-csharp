   M S B A M L   `   `   `  ����E  AFlexButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:FlexButton;assembly=FlexButton
FlexButton  5      V RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.ListViewLM;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.ListViewLM 5      �Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls 5       Samba.Modules.AccountModule4   .Samba.Modules.AccountModule.AccountDetailsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      C
FlexButton,clr-namespace:FlexButton;assembly=FlexButton     5      p
ListViewLMYclr-namespace:Samba.Presentation.Controls.ListViewLM;assembly=Samba.Presentation.Controls     5      p
uiControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5      $��20(�5	   3   .��5
      �   � ColumnDefinitions  5   
   �� 5      $��7* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   � $��0��6   $��0��6     5      �� 5      $��* �6#   �� 5      $
��auto �6#   .+�5      �� $��0��6   $��35(�6(   $
��Bold"�66   $	��5,0q�6H   ��6U   �� *SelectedAccount.Name+�� 5       �� Orientation$ 
Horizontal=�6   $��1��62   .+�5      �� $��35(�6   $
��Bold"�6*   $	��5,0q�6<   ��6I   4  .Samba.Localization.Extensions.LocTextExtension  *	Balance+   Suffix$ :���� 5      $��35(�6   $
��Bold"�6*   $	��5,0q�6<   ��6I   �� *TotalBalance+5      5      �� 5    
   $��1��6   $ 
Horizontal=�6"   .+�5!      �� ��6   �� *FilterTypes+ �� SelectedItem 6;   �� *
FilterType+6a   ?  9Samba.Presentation.Controls.UIControls.ClickSelectTextBox  5"      -   5        $��	StartDate��5"   ,   $��3q�6=   $��16(�6H   $��60��6V   ��6d   �� *StartDateString+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ 	LostFocus=�  5#      -   5        $��EndDate��5#   ,   $��3q�6;   $��16(�6F   $��60��6T   ��6b   �� *EndDateString+$ TwoWay=�$ 	LostFocus=��� 5$      $��3q�6   $��16(�6    $��60��6.   ��6<     *	Refresh+��5%      �� *RefreshCommand+�� 5&      $��3q�6   $��16(�6    $��60��6.   ��6<   �� *PrintAccountCommand+��5'        *Print+5(      �� 5)   
   $��0q�6   $��2��6'   $��0��64   #��["��6D    $� IsVirtualizing . $ �� IsSynchronizedWithCurrentItem$
 TrueY�5*   ?   B  <Samba.Presentation.Controls.ListViewLM.ListViewLayoutManager	   Enabled	 .     ListViewItemExContainerStyle#��[  5,      ��5+   B   �� *AccountDetails+ 6i   �� *FocusedAccountTransaction+
 � 	Resources
 5-       �� 
TargetType �� Triggers �� Binding �� Path �� Value �� Property �� Value��%�   '��       �� 5.      " ��6    5/      �� 50       6&   �� $ IsBold� True6F   .a�51      ��  � ��$
 Bold"�6;   52      54      55       �� View 56      �� 57       �� AllowsColumnReorder .    BlueBackground! �� ColumnHeaderContainerStyle# [ 67     WrappedHeaderTemplate �� ColumnHeaderTemplate# [ 58      .P�59      �� ?  9Samba.Presentation.Controls.ListViewLM.ProportionalColumn   Width$	 1.7Q�6=   ��6%     *Date+ �� CellTemplate 5:      �� 5;      .R�5<   "   �� $��CharacterEllipsis=�6,   $��18(�6M   ��6[   �� *Date+��6q   �� *IsBold+  FontWeightConverter �� 	Converter# [ 5=      5?      �� 5@      $ 3Q�5A      ��5@   %     *Description+ 5B      �� 5C      .R�5D   "   �� $��CharacterEllipsis=�6,   $��18(�6M   ��6[   �� *Name+��6q   �� *IsBold+# [ 5E      5G      �� 5H      $ 1Q�5I      ��5H   %     *Debit+ 5J      �� 5K      .R�5L   "   �� $��18(�6,    �� TextAlignment$ Right=�6T   ��6:   �� *
DebitStr+��6j   �� *IsBold+# [ 5M      5O      �� 5P      $ 1Q�5Q      ��5P   %     *Credit+ 5R      �� 5S      .R�5T   "   �� $��18(�6,   $ Right=�6U   ��6:   �� *	CreditStr+��6k   �� *IsBold+# [ 5U      5W      �� 5X      $ 1Q�5Y      ��5X   %     *	Balance+ 5Z      �� 5[      .R�5\   "   �� $��18(�6,   $ Right=�6V   ��6:   �� *
BalanceStr+��6l   �� *IsBold+# [ 5]      5_      5`      5b      �� 5d   
   $��3��6   ��6$   �� *AccountSummaries+��5f      �� 5g      .R�5h      �� 	 . $��0q�6O   #��[  6c   
 5i        hs  hsr��%A  &	       &	 p     �� 5j      " ��6$   .�5k   "   ��  � ��
 �����6?   �� 5l   "    � ��
 �����6?   5m      �� 5n      " ��6$   .�5o   "   ��  � ��$ Right=�6O   �� 5p   "    � ��$
 Bold"�6?   �� 5q   "    � ��
 �����6?   �� 5r   "    � ��
 �����6?   5s      5t       5u      �� 5v       .  .P�5w   "   ��  �� HeaderContainerStyle# [ 61   $	 4.7Q�6x   ��6]   �� *	Caption+6x   �� 5x   "   # [ 61   $ 1Q�6u   ��6\   �� *Debit+6u   �� 5y   "   # [ 61   $ 1Q�6v   ��6\   �� *Credit+6v   �� 5z   "   # [ 61   $ 1Q�6w   ��6\   �� *	Balance+6w   5{      5}      5~      5�      � 5�   
   $��1��6   $��4��6   
������� 5�      �� 5�      $
��auto �6    �� 5�      $��* �6    .+�5�      �� $��0��6   .+�5�         FlexButton.FlexButton  $��2q�6(   $��60��63      ButtonColor
 �  ����6?     *Close+��5�   ,   �� *CloseAccountScreenCommand+  5�      $��2q�6(   $��60��63   ��6?   �� *DisplayTicketCommand.Caption+��5�      �� *DisplayTicketCommand+�� 5�      ��6   �� *DocumentTypes+��5�      �� 5�      .R�5�        $��2q�64   $��60��6?   ��6K   �� *ButtonHeader+ 5�   "   �� *ButtonColor+��6F   �� *SelectDocumentTypeCommand+5�      5�      5�      5�      5�      5�      