   M S B A M L   `   `   `  ����E  AFlexButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:FlexButton;assembly=FlexButton
FlexButton  5      V RSamba.Modules.AccountModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Samba.Modules.AccountModuleSamba.Modules.AccountModule 5      5   /Samba.Modules.AccountModule.AccountSelectorView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      C
FlexButton,clr-namespace:FlexButton;assembly=FlexButton     5      ;local)clr-namespace:Samba.Modules.AccountModule     5      $��16(�5   .     � 	Resources  5
      8  2Samba.Modules.AccountModule.AccountGroupsConverter   AccountGroupsConverter  
viewSource �� Source �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription   PropertyName  GroupLabelStyle �� 
TargetType �� Triggers �� Binding �� Value �� Property	 �� Value��%*  &	        &	      &	 t       5   
   6(   �� 5   
    62   �� *
Accounts+ 5        5      $ GroupKey��6+   5      �� 5   
   " ��6(    5      �� 5       6   �� *Name+ 67   Z� .a�5      ��  � y�$	 	Collapsed=�63   5      5      5      .��5      � 
 � ColumnDefinitions
 5   
   �� 5      $��9* �6   �� 5       $��* �6    � RowDefinitions 5"   
   �� 5#      $��* �6   �� 5$      $��9* �6   .+�5&   
   �� 
�������$��2��6U   ��6   �� *AccountButtons+��5'      �� 5(      .R�5)         FlexButton.FlexButton  $��2q�6,   $��26(�6S   ��67   �� *	Caption+��5*   ,   �� **(DataContext.AccountButtonSelectedCommand+ �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" ����5+   ,   �� *Model+   ButtonColor 6O   �� *ButtonColor+5,      ��5.      �� 5/      .R�50      A�  A� Rows$ 1��6"   51      53      �� 54   
   -   5        $��MainListView��54      $��20(�6'   $��0��65   $��1��6E      ListViewItemExContainerStyle#��[ 55       � IsSharedSizeScope . ��54   R   ��  �� Source# [  �� SelectedItem 6�   �� *SelectedAccount+ �� View 56      �� 57      ! �� ColumnHeaderContainerStyle 58      �� 59      .�5:      ��  � y�$	 	Collapsed=�6L   5;      P�5=      �� 5>       �� Width$
 auto��6e   ��6)   4  .Samba.Localization.Extensions.LocTextExtension  *Name_f+   FormatSegment1   *	Account+ �� CellTemplate 5?      �� 5@   "   .R�5A   &   �� $	��250��60   $��15,0,0,0q�6?    �� TextAlignment$
 Left=�5B      ��5A   Q   �� *Name+5B      5C   #   5E      �� 5F      ��6)     *	Balance+ 5G      �� 5H   "   .R�5I   &   �� $ Right=�6L   $	��150��6b   ��60   �� *
BalanceStr+6b   5J   #   5L      5U       �� 
GroupStyle 5W      (  "System.Windows.Controls.GroupStyle  5X         ContainerStyle 5Y      �� 5Z      " ��6    .�5[      ��  � ��$	 0,1,0,5q�67   �� 5\       � ��	 5]   "   �� 5^   &    �� 
TargetType" ��66   .R�5_   *   �  5`   .   �� 5a   2   $
��auto �6@   �� 5b   2   $��* �6@   .+�5d   .   �� $��0,0,0,1q�65   
�������._�5e   2   � $��0��67   
 5f   6   �� 5g   :   $
��Auto �6K    z� SharedSizeGroup$
 Left��6X   �� 5h   :   $
��Auto �6K   $ Right��6X   .+�5j   6   �� $��5,0,0,0q�6@   $��0��6Q   $
��Bold"�6w   
�������#��[ 5k   [   ��5j   a   �� *Name+5k   [   �� 5l   6   $��10,0,0,0q�6@   $��1��6R   $ Right=�6b   $
��Bold"�5m   �   
�������#��[ 5n   R   ��5m   @   ��  �� Path$ Items� �� 	Converter# [  5n   R   5o   3   5p   /   �� 5q   .   $��1��6=   5r   +   5s   '   5u      5v      5x      5z      �� 5{   
   $��1��6   $��1��6%   
�������.+�5|        $��60��6$   $��20(�60   $��2q�6>   ��6I   �� *ShowAccountDetailsCommand+��6w   �� *#!ShowAccountDetailsCommand.Caption+  5}      $��60��6$   $��20(�60   $��2q�6>   ��6I   �� *PrintCommand+��6j   �� *PrintCommand.Caption+�� 5~      ��6   �� *AutomationCommands+��5      �� 5�      .R�5�        $��20(�60   $��2q�6>   $��60��6I   ��6U   �� *ButtonHeader+��5�   
   �� *OnAutomationCommandSelected+��6:   �� *Model+5�      5�      �� 5�      ��6   �� *BatchDocumentButtons+��5�      �� 5�      .R�5�        $��20(�60   $��2q�6>   $��60��6I   ��6U   �� *ButtonHeader+ 5�   
   �� *ButtonColor+��6.   �� *SelectDocumentTypeCommand+5�      5�      5�      5�      5�      