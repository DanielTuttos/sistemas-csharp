   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls  5       Samba.Modules.TicketModuleI   CSamba.Modules.TicketModule.Widgets.TicketLister.TicketListerControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      p
UIControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5        � 	Resources  5
       
  FadeIn �� TargetProperty g� Duration W� From	 W� To  FadeStop �� 
TargetType  FadingBorder �� Triggers :� RoutedEvent ��Name	 �� BeginStoryboardName��%�  &	        &	 {     &	 �     7   �� 5   
   .��5      W� $ Opacity�5      $ 0:0:0.2D�5      $	 0.2X�6$   $ 1X�6/   5      5      �� 5   
   .��5      W� $ Opacity�5      $ 0:0:0D�5      $ 1X�6"   $ 1X�6+   5      5      �� 5   
   " ��6    5      :� 5      $ 	MouseDown��6   .[�5      �� $ 	FadeStart��6K   8��  5      :� 5      $ MouseUp��6   .[�5      �� $	 	FadeStart��6+   6M   5      5       5!      .��5"      �� #��["��6   $��1q�6Y   ._�5#   
   �� =   7Samba.Presentation.Controls.UIControls.KineticBehaviour
   HandleKineticScrolling
 . $
��Auto=�6Q   .��5$      �� -   5        $��ListBox��5$      
�������$��0q�6   ��6*   �� *
TicketList+��6N   �� *
FontSize+��5%      �� 5&      .R�5'      ��   ItemsControlButtonStyle#��[ 6!   ��6S   �� *ItemSelectionCommand+��6|   �� .��5(      ��  �� CornerRadius$ 5��6%   #��[ 66   $��1q�6\   $	��0,3q�6�   ��6p   �� *Border+��6�   �� *BackgroundValue+._�5)   "   ��  �� Padding$ 3q�6,   
������ ��6Q   �� *ForegroundValue+��6x   �� *
MinWidth+��5*       �� *
TicketData+6>   5+      5,      5-      ��5/      �� 50      .R�51      �  K� IsItemsHost . ��52      ��  �� Path$ ActualWidth� �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" ��56      58      59      5:      5;      