   M S B A M L   `   `   `  ����T  PSamba.Presentation.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Samba.Presentation.CommonSamba.Presentation.Common  5      B    <Samba.Presentation.Common.ModelBase.EntityCollectionBaseView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :Common'clr-namespace:Samba.Presentation.Common     5      -   5          � 	Resources  5         
viewSource �� Source �� GroupDescriptions2  ,System.Windows.Data.PropertyGroupDescription   PropertyName  GroupLabelStyle �� 
TargetType �� Triggers �� Binding �� Value �� Property	 �� Value��%  &	        &	 `     �� 5	   
    62   �� *Items+ 5
        5      $ 
GroupValue��6+   5      �� 5   
   " ��6(    5      �� 5       6   �� *Name+ 67   Z� .a�5      ��  � y�$	 	Collapsed=�63   5      5      5      .��5      � 
 � ColumnDefinitions
 5   
   �� 5      $��* �6   �� 5      $
��auto �6   $	��200��6,    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5"   
   �� $��1,0,0,0q�6   
�������$��5,0,0,0q�6@    �� Padding$ 2,0,0,2q�6Q   $��0��6c   $��1��6p   ._�5#      �� .+�5$      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *Search+   Suffix$ :���� 5%      -   5        $��FilterTextBox��5%      ��6/   �� *Filter+ �� UpdateSourceTrigger$ PropertyChanged=�6k   5&      5'      �� 5)   
   $��1��6   $��1��6'   $��1,0,0,0q�64   
�������
�������$��5,0,0,0q�5*   /   ��5)   c   �� *AllCommands+��5+      �� 5,      .R�5-      �� $��5q�6    �� 5.       �� Command 6$   ��  �� CommandParameter 68   �� *
DataObject+.�6`   .�5/      �� ��6(   �� *	Caption+ �� Mode$ TwoWay=�50      51      52      54      � 56   
   $��2��6    57      �� 58      $
��auto �6    �� 59      $��* �6    .+�5;      �� 
�������y�6+   �� *DisplayLimitWarning+  VisibilityConverter �� 	Converter# [ ._�5<      �� $��5q�6   �� 5=       6$   �� *RemoveLimitCommand+.�6K   .�5>      �� ��6(   �� *RemoveLimitCommand.Caption+5?      5@      5A      �� 5B      -   5        $��MainGrid��5B   s   $��1��6   $��0q�6$    �� DisplayMemberPath$
 Name��5C   K   ��5B   8   ��  �� Source# [   �� SelectedItem 5C      ��  �� Path$ SelectedItem�$ TwoWay=�  5E      *   $Samba.Presentation.Common.ElementSpy  spy P� Property P� Value��%�   &	       '��        5F      6(   �� 5G      " ��6    5H      P� 5I       �@��
IsSelected .  . �5J   "   ��  � ��	 6?   �� *
Foreground+5K      5M      5N       � ContextMenu 5O      �� 5P      -   5        $��CM��5P   "   .@�5Q      m� ��6#   �� *AddItemCommand.Caption+ m� Command 6M   �� *AddItemCommand+m� 5R      ��6#   �� *EditItemCommand.Caption+ 6N   �� *EditItemCommand+m� 5S      ��6#   �� *DeleteItemCommand.Caption+ 6P   �� *DeleteItemCommand+m� 5T      ��6#   �� *$"DeleteSelectedItemsCommand.Caption+ 6Y   �� *DeleteSelectedItemsCommand+ m� CommandParameter 5U      �� # [ $ Element.SelectedItems�m� 5V      ��6#   �� *DuplicateItemCommand.Caption+ 6S   �� *DuplicateItemCommand+5W       �� 
GroupStyle 5Y      (  "System.Windows.Controls.GroupStyle  5Z         ContainerStyle 5[      �� 5\      " ��6$   .�5]   "   ��  � ��$	 0,0,0,5q�6;   �� 5^   "    � ��	 5_   &   �� 5`   *    �� 
TargetType" ��6:   .R�5a   .   �  5b   2   �� 5c   6   $
��auto �6D   �� 5d   6   $��* �6D   .+�5f   2   �� $��0��6<   $
��Bold"�6_   #��[ 6q   ��6I   �� *Name+6q   �� 5g   2   $��1��6A   5h   /   5i   +   5k   #   5l      5n      5p      5q      5�      5�      