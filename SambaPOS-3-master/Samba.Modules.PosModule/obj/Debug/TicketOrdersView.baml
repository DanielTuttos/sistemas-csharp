   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      V RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls 5       Samba.Modules.PosModule.   (Samba.Modules.PosModule.TicketOrdersView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6sys&clr-namespace:System;assembly=mscorlib     5      p
UIControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5        � 	Resources  5
         GroupLabelStyle �� 
TargetType �� Triggers �� Binding �� Value �� Property �� Value��%�   &	        �� 5   
   " ��6(    5      �� 5       6   �� *Name+ 67   Z� .a�5      ��  � y�$ 	Collapsed=�63   5      5      5      .��5      �� $��1q�6   #��["��6!   ._�5   
   �� -   5        $��Scroller��5   )   |�.  =  7Samba.Presentation.Controls.UIControls.KineticBehaviour   HandleKineticScrolling . $
��Auto=�6s   .��5      �� $��0q�6    �� AlternationCount$ 2��6W   $��Stretch=�5   K   ��5   /   �� *TicketBackground+��5      �� *ItemsViewSource.View+	 �� 
GroupStyle	 5      (  "System.Windows.Controls.GroupStyle  5      
   ContainerStyle
 5      �� 5      " ��6$   .�5   "   ��  � ��$ 0,1,0,5q�6;   �� 5   "    � �� 5   &   �� 5   *    �� 
TargetType" ��6:   .R�5   .   �  � RowDefinitions 5    2   �� 5!   6   $
��auto �6D   �� 5"   6   $��* �6D   .+�5$   2   �� $��0,0,0,1q�69   
�������._�5%   6   � $��0��6;    � ColumnDefinitions 5&   :   �� 5'   >   $
��auto �6O   �� 5(   >   $��* �6O   .+�5*   :   �� $��15,0,0,0q�6D   $��0��6V   $
��Bold"�6�   
�������#��[  5+   [   ��5*   f   �� *Name.OrderNumber+5+   [   �� 5,   :   $��5,0,0,0q�6D   $��1��6U   $
��Bold"�6�   
�������#��[  5-   [   ��5,   e   �� *	Name.Time+5-   [   5.   7   5/   3   �� 50   2   $��1��6A   51   /   52   +   54   #   55      57      ��59      �� 5:      .R�5;      ��   ItemsControlButtonStyle#��[ 6!    � IsSharedSizeScope . ��6R   �� *ItemSelectedCommand+��5<   *   �� .��5=      � .+�5>   "   �� .+�5?   &   � $��-1q�6+   ��67   �� *
Background+ 5@   *   �� 5A   .   $
��auto �6?    z� SharedSizeGroup$ QuantityGrp��6L   �� 5B   .   $��* �6?   �� 5C   .   $
��auto �6?   �� 5D   .   $
��auto �6?    5F   *   �� 5G   .   �� 5H   .   .+�5K   *   �� $��0��6�    �� Padding$ 1q�5L   :   $��21(�6h   $��5,5,6,5q�5M   :   ��5K   4   �� *
FontWeight+��6V   �� *TextDecoration+��5L   F   �� *
Foreground+��6w   �� *
Quantity+ �� StringFormat$ 0.###��5M   :   �� 5O   *   $��1��6�   $ 1q�5P   :   $��21(�6h   $��CharacterEllipsis=�5Q   :   $��5q�6[   ��5O   4   �� *
FontWeight+��6V   �� *TextDecoration+��5P   F   �� *
Foreground+��6w   �� *Description+5Q   [   �� 5S   *   $ 1q�5T   :   
�������$��12(�6X   $��2��6f   $��Right=�5U   :   $��Center=�6V   ��5S   4   �� *TextDecoration+��5T   v   �� *
PriceTag+5U   V   �� 5W   *   $��3��6�   $ 1q�5X   :   $��21(�6h   $��5q�5Y   :   $��Right=�6E   ��5W   4   �� *
FontWeight+��6V   �� *TextDecoration+��5X   F   �� *
Foreground+��6w   �� *TotalPriceStr+5Y   E   �� 5[   *   $��1��65   $��2��6B   $��1��6V   $��8,-7,5,2q�5\   :   $��12(�6L   $
��Left=�5]   :   $	��Top=�6U   y�5[   f   �� *IsStateVisible+  VisibilityConverter �� 	Converter# [ ��5\   Z   �� *State+��5]   m   �� *
Foreground+5^   '   �� 5_   &   $��14(�6R   $
��Bold"�6`   $��	30,-2,0,2q�6r   ��60   �� *
TimerColor+��5`   )   �� *TimerDescription+y�6K   �� *IsTimerVisible+# [ �� 5a   &   ��63   �� *OrderTagValues+��5b   *   �� 5c   .   .R�5d   2   �  5e   6   �� 5f   :   $��* �6K   �� 5g   :   $
��auto �6K   .+�5i   6   �� $��0��6@   
����  �$��14(�6f   $
��Bold"�6t   $��30,0,0,0q�5j   F   ��5i   �   �� *DisplayString+5j   F   �� 5k   6   $��1��6@   
����  �$��14(�6f   $
��Bold"�6t   $ 1q�5l   F   $��0,0,5,0q�6R   $��Right=�6c   ��5k   �   �� *PriceString+5l   c   5m   3   5n   /   5p   '   5q   #   �� 5r   "    ��Name$ 	Rectangle��6=   $��1,1,2,1q�6,   
������ #��["��6c    �� StrokeDashCap$ Square=�5s   2    J� SnapsToDevicePixels . ��6I   �� *BorderThickness+ �� StrokeDashArray 5u   *   X�5Q�68   5w   #   5y      5z      5{      5}      5~      5      5�      