   M S B A M L   `   `   `  ����E  AFlexButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;,clr-namespace:FlexButton;assembly=FlexButton
FlexButton  5       Samba.Modules.PosModule,   &Samba.Modules.PosModule.TicketListView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      C
FlexButton,clr-namespace:FlexButton;assembly=FlexButton     5      .��5      �   � RowDefinitions  5	   
   �� 5
      $��* �6   �� 5      $��8* �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      (� $��0��6   $
��Left=�6&   .��5      �� $
��Bold"�66   ��6   �� *
ListName+6J   5      (� 5      $��1��6   $��20,0,0,0q�6&   $��Right=�68   .��5      �� $
��Bold"�6G   ��6   �� *TotalRemainingAmountLabel+6[   5      5      �� 5   
   $��1��6   $��Stretch=�6D    � IsSharedSizeScope . ��6$   �� *	Tickets+��5      �� 5      .R�5      A�  A� Rows 6"   �� *
RowCount+6>   5      ��5!      �� 5"       � 	Resources 5#         ButtonClick �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value  Release��%�  &	        &	 �     �� 5$      .��5%      �� $0 *(Panel.Background).(SolidColorBrush.Color)�6;   $ border��5&   *   .g�5'   "     $ 0��66   $ Silver��6B   5(      5)      �� 5*      .��5+      �� $0 *(Panel.Background).(SolidColorBrush.Color)�6;   $ border��5,   *   .g�5-   "     $ 0��66   $ Silver��6B     5.   "   $ 0:0:0.2��66   $ 	Gainsboro��6H   5/      50      51      .R�52      � $��0,0,0,5q�6    53      �� 54      $
��auto �6/   $��60��6=   	 z� SharedSizeGroup$
	 Grp1��6K   �� 55      $��* �6/   .+�57      �� 
 ��Name$
 selector��6!     ItemsControlButtonStyle#��[ 63   ��6d   �� *SelectTicketCommand+.��58      �� $��0��6%   $��1,1,0,1q�65    �� CornerRadius$ 5,0,0,5��6O   
���������6{   �� *SelectionBackground+._�59   "   (� $��5q�6*   .��5:   &   �� $
��Left=�6N   ��60   �� *TicketNumber+��6i   �� *SelectionForeground+5;   #   5<      5=      �� 5>      $
 button��6!   $��1��61   #��[ 6A   ��6r   �� *OpenTicketCommand+.��5?      ��  ��Name$ border��6%   $��1��65   $��1q�6F   
���������6Z   �� *SelectionBackground+._�5@   "   �   5A   &   �� 5B   *   $��* �68   �� 5C   *   $��* �68   .+�5E   &   (� $��0��6.   $
��Left=�6;   .��5F   *   �� ��67   �� *
TicketTags+��5G   .   �� 5H   2   .R�5I   6   � 6B   5J   3   ��5L   .   �� 5M   2   .R�5N   6   �� 
�������$��1q�6R   
�������$ 2��6}   $��3q�6�    �� Padding$ 3q�6�   ._�5O   :   �� ��6D   �� *
TagValue+ � ToolTip 6^   �� *	TagName+5P   7   5Q   3   5S   +   5T   '   � 5U   &   $��1��6+    5V   *   �� 5W   .   $��* �6?   �� 5X   .   $
��auto �6?   .+�5Z   *   (� $��0��62   $
��Left=�6B   .��5[   .   �� ��6;   �� *ResourceNames+��5\   2   �� 5]   6   .R�5^   :   � 6F   5_   7   ��5a   2   �� 5b   6   .R�5c   :   �� 
�������$ 2��6U   $��3q�6f   $ 3q�6q   ._�5d   >   �� ��6H   �� *.+5e   ;   5f   7   5h   /   5i   +   (� 5j   *   $��1��62   .��5k   .   �� $��0,0,3,0q�6^   ��68   �� *RemainingAmountLabel+6^   5l   +   5m   '   5n   #   5o      5p      5r       �� Triggers 5s      P� 5t       P� 
SourceName$ button��6D    P� Property � �� P� Value .  N� ExitActions 5u      �� 5v   "    ��Name$ Release_BeginStoryboard��62   #��[ 6S    N� EnterActions 5x      �� 5y   "   #��[  62   5{      5}      5      �� 5�   
   $��2��6   ��6$   �� *CommandButtons+��5�      �� 5�      .R�5�      A� $ 1��6"   5�      ��5�      �� 5�      .R�5�         FlexButton.FlexButton  |�.  $��3,3,3,0q�5�   q   ��5�   ,   �� *
FontSize+   ButtonColor 6\   �� *Color+  NullBrushConverter �� 	Converter# [ ��6�   �� *	Command+��5�   .   �� *	Parameter+��6U   �� *	Caption+5�      5�      5�      5�      5�      