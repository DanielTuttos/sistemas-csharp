   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:Samba.Presentation.Controls.ListViewEx&Samba.Presentation.Controls.ListViewEx  5      _4clr-namespace:Samba.Presentation.Controls.Converters&Samba.Presentation.Controls.Converters  5      _4clr-namespace:Samba.Presentation.Controls.UIControls&Samba.Presentation.Controls.UIControls  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089@    :Samba.Presentation.Controls.Converters.VisibilityConverter   VisibilityConverter@   :Samba.Presentation.Controls.Converters.FontWeightConverter  FontWeightConverter?   9Samba.Presentation.Controls.Converters.NullValueConverter  NullValueConverter?   9Samba.Presentation.Controls.Converters.NullBrushConverter  NullBrushConverter  NameTokenTemplate  ��Name �� CornerRadius �� Padding  TabControlNormalBorderBrush �� Color@   :Samba.Presentation.Controls.ListViewEx.BackgroundConvertor  backgroundConverter  HeaderTemplateSortAsc �Name � ColumnDefinitions ��Name ^� ToolTip F�Name	 J� Opacity
 �� ElementName �� Path  HeaderTemplateSortDesc 	 HeaderTemplateSortNon 
 BlueBackground �� 
TargetType �� Property �� Value  SilverBackground  
BlueHeader  WrappedHeaderTemplate  WrappedFooterTemplate   ListViewItemExContainerStyle �� 
TargetType ��Name �� Triggers P� Property P� Value �� 	Converter �� RelativeSource  SearchTextBox_Background  SearchTextBox_Foreground  SearchTextBox_Border �� 
StartPoint �� EndPoint � Color � Offset ! SearchTextBox_BorderMouseOver " SearchTextBox_SearchIconBorder & "SearchTextBox_SearchIconBackground , (SearchTextBox_SearchIconBorder_MouseOver 0 ,SearchTextBox_SearchIconBackground_MouseOver , (SearchTextBox_SearchIconBorder_MouseDown 0 ,SearchTextBox_SearchIconBackground_MouseDown   SearchTextBox_LabelTextColor:   4Samba.Presentation.Controls.UIControls.SearchTextBox ��Name ��Name ��Name �� 
TargetName ]� 
Conditions �� Property  �� Value! �� 
SourceName�� 5      H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml     5      C
ListViewEx4clr-namespace:Samba.Presentation.Controls.ListViewEx  5      C
Converters4clr-namespace:Samba.Presentation.Controls.Converters  5      C
UIControls4clr-namespace:Samba.Presentation.Controls.UIControls  5      %J  &	        &	      &	 &     &	 9     &	 L     &	 \    &	 }    &	 �    &	 �    &		 �    &	
 �    &	     &	 t    &	 �    &	 �    &	 �	    7��7��7  &	 �    &	     &	 !    &	 �    &	 �    &	 �    &	 �    &	 �    &	 �    &	 (    &	 %    '  C    7  7  7  7  7  7  7  7  7  7  7  7     5	      6"     5
      6"     5      6!     5      6!   �� 5      .R�5      �� $  border��6   
�������$��1q�60   $ 3��6D   $
��Auto��6U   $ 2q�6c   $��2,2,5,2q�6o   
�������._�5      �� $��NoWrap=�6   $��Center=�66   $��Center=�6Q   $��2,0,2,0q�6n   ��6%   �� 6n   5      5      �� 5      $ #8C8E94��67     5      6"   �� 5      .R�5      � $ HeaderTemplateSortAscGrid��6   $��30��6	    5      �� 5      $��* �6   �� 5      $
��Auto �6   .+�5      �� $ 
HeaderText��5    
   $��0��5      $��Center=�6!   $��Center=�5   
   $��CharacterEllipsis=�5!   
   $
��Wrap=�6+   ��5"   
   ��  6   �� F� 5#      $ arrow��6
   $��1��5$      $		 0.7Q�5%      $��Center=�5'      $��1��5(      +����@KL ��� ���� ��� р�� @KL �@KL ��� 	��5&      �� $
 
HeaderText��$ 
Foreground�5*      5+      5,      �� 5.      .R�5/      � $��30��6	    50      �� 51      $��* �6   �� 52      $
��Auto �6   .+�54      �� $ 
HeaderText��56      $��0��54      $��Center=�6!   $��Center=�55   
   $��CharacterEllipsis=�57   
   $
��Wrap=�6+   ��58   
   ��  6   �� F� 59      $ arrow��6
   $��1��5:      $��Center=�5;      $��1��5<      $		 0.7Q�5=      +����@KL @KL р�� ��� ���� @KL �@KL @KL 	��5>   	   �� $
 
HeaderText��$ 
Foreground�5@      5A      5B      �� 5D      .R�5E      ]� $��30��6   .+�5F      �� $��Center=�6   $��CharacterEllipsis=�6,   $��Center=�5G   
   $
��Wrap=�5H   
   ��6   ��  61   �� 5I      5J      �� 5L      " ��6    .�5M      ��  � ��
 ���w�6"   �� 5N       � ��
 �����6"   5O      �� 5Q      " ��6"   .�5R      ��  � ��
 �����6"   �� 5S       � ��
 �����6"   5T      �� 5V      " ��6   .�5W      ��  � ��
 �����6"   �� 5X       � ��
 �   �6"   5Y      �� 5[      .R�5\      ]� $��30��6   .+�5]      �� $��Center=�6   $��CharacterEllipsis=�6,   $��Center=�5^      $
��Wrap=�5_      ��6    ��  62   �� 5`      5a      �� 5c      .R�5d      ]� $��25��6   .+�5e      �� $��Stretch=�6   $��CharacterEllipsis=�6-   $��Center=�5f   	   $��16(�6%   $
��Bold"�63   $
��Wrap=�5g   	   ��6   ��  60   �� 5h      5i      �� 5k      " ��6	   .�5l      ��  � �� 5m      �� 5n      " ��6   .R�5o      � #��z��6   .+�5p      �� $ ItemContent��6   |�.  $��0��6D   5q   	   5r       5s      P� 5t       �@��
IsSelected . . �5u   	   �� 8    � ��6&   �� 5v   	   8   � ��6&   �� 5w   	    � ��$
 Auto��6"   5x   	   5|      5~      �� 5�       � �� 5�      �� 5�      8   6   �� *Self+65   5�      �� 5�       � ��$ Stretch=�61   �� 5�       � ��$ Stretch=�6/   �� 5�       � ��$
 Auto��6   5�      �� 5�      $ White��64   �� 5�      $ Black��64   �� 5�      $	 0,0&�64   $	 0,1&�6E   .��5�      � $ 	#FFABADB3��6   $
 0.05Q�6#   � 5�      $ 	#FFE2E3EA��6   $
 0.07Q�6#   � 5�      $ 	#FFE3E9EF��6   $ 1Q�6#   5�      �� 5�      $	 0,0&�6=   $	 0,1&�6N   .��5�      � $ 	#FF5C97C1��6   $
 0.05Q�6#   � 5�      $ 	#FFB9D7EB��6   $
 0.07Q�6#   � 5�      $ 	#FFC7E2F1��6   $ 1Q�6#   5�      �� 5�      $ White��6:   �� 5�      $ White��6>   �� 5�      $	 0,0&�6H   $	 0,1&�6Y   .��5�      � $ 	#FFFFFFFF��6   $ 0Q�6#   � 5�      $ 	#FFE5F4FC��6   $ 1Q�6#   5�      �� 5�      $	 0,0&�6L   $	 0,1&�6]   .��5�      � $ 	#FFE7F5FD��6   $ 0Q�6#   � 5�      $ 	#FFD2EDFC��6   $	 0.5Q�6#   � 5�      $ 	#FFB6E3FD��6   $
 0.51Q�6#   � 5�      $ 	#FF9DD5F3��6   $ 1Q�6#   5�      �� 5�      $	 0,0&�6H   $	 0,1&�6Y   .��5�      � $ 	#FFFFFFFF��6   $ 0Q�6#   � 5�      $ 	#FFE5F4FC��6   $ 1Q�6#   5�      �� 5�      $	 0,0&�6L   $	 0,1&�6]   .��5�      � $ 	#FFE7F5FD��6   $ 0Q�6#   � 5�      $ 	#FFD2EDFC��6   $	 0.5Q�6#   � 5�      $ 	#FFB6E3FD��6   $
 0.51Q�6#   � 5�      $ 	#FF9DD5F3��6   $ 1Q�6#   5�      �� 5�      $
 Gray��68   �� 5�      "  63   .�5�      ��  � ��8   6!   �� 5�       � ��8  6"   �� 5�       � ��8  6!   �� 5�       � ��$ 1q�6&   �� 5�       �@J�SnapsToDevicePixels . 6*   �� 5�       �@ 	LabelText$ Search��6    �� 5�       � ��$ 20��6    �� 5�       �@�FocusVisualStyle 6'   Z� �� 5�       �@ LabelTextColor8  6%   �� 5�       � �� 5�      �� 5�      "  6   .R�5�      �� $  Border��6   #��z��5�      #��z��5�      #��z��5�      ._�5�      � $ 
LayoutGrid��6    5�   	   �� 5�   
   $��* �6   �� 5�   
   ��6   ��  �� *TemplatedParent+$ ActualHeight�.+�5�   	   �� $ PART_ContentHost��6!   $��2q�6   $��0��6;   �� 5�   	   $ 	LabelText��6   $��2q�5�      $��0��5�      $��2,0,0,0q�5�      $��Italic$�5�      ��5�      ��  �� *TemplatedParent+$ LabelTextColor���5�      ��  �� *TemplatedParent+$ 	LabelText�5�      �� 5�   	   $  PART_SearchIconBorder��6   $��1��5�      $��1q�5�      $��Stretch=�5�      $��Stretch=�5�      8�� 8�� ._�5�   
   �� $ 
SearchIcon��6   $
��None=�5�   	   $��15��5�   	   $��15��5�   	   $��Center=�5�   	   $��Center=�5�   	   $>��8/Samba.Presentation.Controls;component/Images/search.png��5�   	   5�   
   5�   	   5�       5�      P� 5�       �@J�IsMouseOver . . �5�   	   �� 8   � ��6'   5�   	   P� 5�       �@J�IsKeyboardFocusWithin . . �5�   	   �� 8   � ��6'   5�   	   P� 5�       �@ HasText . . �5�   	   �� $ 	LabelText��6&    � y�$ Hidden=�6=   5�   	   ]� 5�       5�   	   �� 5�   
    �@ HasText  . 6'   �� 5�   
    �@ 
SearchMode$  Instant=�6*   ./�5�   	   �� $ 
SearchIcon��6"    � ��$= 7/Samba.Presentation.Controls;component/Images/clear.png��5�   
   5�   	   ]� 5�       5�   	   �� 5�   
   $! PART_SearchIconBorder��5�   
    �@J�IsMouseOver  . 5�   
   �� 5�   
    �@ HasText  . 6'   ./�5�   	   �� $ PART_SearchIconBorder��5�      8   � ��5�      �� 5�   	   $ PART_SearchIconBorder��5�      8 	  � ��5�      5   	   ]� 5      5  	   �� 5  
   $! PART_SearchIconBorder��6+    �@J�IsMouseOver  . 6N   �� 5  
    �@ IsMouseLeftButtonDown  . 65   �� 5  
    �@ HasText  . 6'   ./�5  	   �� $ PART_SearchIconBorder��5      �@��Padding$ 2,0,0,0q�5	     �� 5
  	   $ PART_SearchIconBorder��5     8 
  � ��5     �� 5  	   $ PART_SearchIconBorder��5     8   � ��5     5  	   5     5     5     5     