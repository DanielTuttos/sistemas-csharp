   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls  5       Samba.Modules.AccountModule;   5Samba.Modules.AccountModule.Dashboard.AccountTypeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      p
UIControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� .+�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *Name+   Suffix$ :���� 5      $
��Left=�6   $	��200��61   ��6@   �� *Name+�� 5      ��6     *
FilterType+$ :���� 5      $
��Left=�6_   $	��200��6z   ��6   �� *FilterTypes+ �� SelectedItem 6;   �� *
FilterType+6z   �� 5      ��6     *Rules+$ :���� 5      $
��Left=�6a   $	��200��6|   ��6   �� *WorkingRules+ 6<   �� *WorkingRule+6|   �� 5      ��6     *Tags+$ :��5      >   8Samba.Presentation.Controls.UIControls.TokenizingControl  5   
   -   5        $	��rtb��5   '   $��1��62      NameTokenTemplate   TokenTemplate# [  6?   $
��Left=�5   +   $	��150��6F   $	��300��6U    �� AcceptsReturn .  " �� VerticalScrollBarVisibility$
 Auto=�6z      Text 5   r   �� *Tags+5   z   �� 5   
   $��3��6   .+�5      �� $
��Left=�6   $
��0,10q�60   $��70��6>   ��6L   �� *SaveCommand.Caption+��5      �� *SaveCommand+�� 5      
���  ����6   �� *Error+6.   5       5!      5"      