   M S B A M L   `   `   `  ����T  PSamba.Modules.LoginModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Samba.Modules.LoginModuleSamba.Modules.LoginModule  5   C   )    #Samba.Modules.LoginModule.LoginView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6<   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :Login1'clr-namespace:Samba.Modules.LoginModule     6C   -   5        #��["��5   �   .��5      �   � ColumnDefinitions  5   
   �� 5      -   5         �Name$ Column1��5      $��* �6.   �� 5	      -   5        $ Column2��5	      $��* �6.    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $
��None=�6    $��Center=�6K   $��Center=�5      ��5   /   �� *
LogoPath+5      �� 5   
   $��1��6   $��2��6!   $��30(�65   $��Black"�6C   
�������$��5,0,0,0q�5      ��5   n   �� *
AppLabel+ J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Opacity$	 0.3Q�6#      ShadowDepth$ 1Q�61      
BlurRadius$ 3Q�6A   5      5      �� 5   
   $��1��6   $��2��6%   $��Center=�66   .+�5      �� $��1��6   $	��350��6%   $	��400��61    �� CornerRadius$ 10��6>   $��2q�6P   
����İ�._�5      /   )Samba.Modules.LoginModule.LoginPadControl  -   5          Name$ 
PadControl��5   )   /   )Samba.Modules.LoginModule.LoginPadControl	   PinSubmitted$"	 LoginPadControl_PinSubmitted��6I   $��15q�6=   6I   5      �� 5      $��14(�6   $��Center=�6&   
 �� TextAlignment$
 Center=�5      ��5   C   �� *AdminPasswordHint+5      �� 5       -   5        $��Center=�5       $	��110��62   $��50��6A   $
��Bold"�6M   $��18(�6_   $��5q�5!      .��5"      ]� .+�5#      �� $!��Images/LanShutDown.icon.gif��6   $
��None=�6A   �� 5$      ��6   4  .Samba.Localization.Extensions.LocTextExtension  *Exit+5%      5&      5'      5(      5)      