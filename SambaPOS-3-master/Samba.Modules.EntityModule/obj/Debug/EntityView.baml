   M S B A M L   `   `   `  ����U  QSamba.Modules.EntityModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Samba.Modules.EntityModuleSamba.Modules.EntityModule  5      +    %Samba.Modules.EntityModule.EntityView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6>   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6=   @d2http://schemas.microsoft.com/expression/blend/2008     5      AentityModule(clr-namespace:Samba.Modules.EntityModule     5        � 	Resources  5       �� 
TargetType �� Property �� Value��%|   '��       �� 5   
   " ��6   .�5      ��  � ��$	 120��6)   �� 5       � ��$ 0,3,3,0q�6'   5	      5
      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� .+�5      ]� $��3q�6   .+�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *
EntityType+   Suffix$ :���� 5      $
��Left=�6   $	��150��66    �� DisplayMemberPath$
 Name��5   ;   ��5      �� *EntityTypes+ �� SelectedItem 5      �� *
EntityType+6;   5      7   1Samba.Modules.EntityModule.EntityCustomDataEditor  5      $��4,4,0,0q�62   $	��273��6C   $
��Left=�6R   |�.   � DataContext 6   �� *CustomDataViewModel+]� 5      $��3q�6   .+�5      �� ��6     *	Warehouse+$ :���� 5      $
��Left=�6   $	��152��66   	 �� 
IsEditable	 . $
 Name��5!   :   ��5       �� *
Warehouses+ 5!      �� *	Warehouse+6:   5"      ]� 5$      $��3q�6   .+�5%      �� ��6     *	Account+$ :���� 5&      	 . $
��Left=�6o   $	��152��6�   ��6   �� *AccountNames+
 �� Text
 6@   �� *AccountName+6�   5'      5(      �� 5)   
   $��1��6   .+�5*      �� $
��Left=�6   $
��0,10q�60   $��70��6>   ��6L   �� *SaveCommand.Caption+��5+      �� *SaveCommand+�� 5,      
���  ����6   �� *Error+6.   5-      5.      5/      