   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls  5      ! Samba.Modules.InventoryModule5   /Samba.Modules.InventoryModule.InventoryItemView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6H   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6E   @d2http://schemas.microsoft.com/expression/blend/2008     5      p
UIControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5      .��5      � .+�5   
   �� .+�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *InventoryItemName+    Suffix$  :���� 5	      $
��Left=�6   $	��200��61   ��6@   �� *Name+ �� Mode$ TwoWay=��� 5
      ��6     *	GroupCode+$  :���� 5      $
��Left=�6   $	��150��62    �� 
IsEditable .  �� Text 6A   �� *	GroupCode+$ TwoWay=���5      �� *
GroupCodes+5      �� 5      ��6     *	Warehouse+$  :���� 5      $
��Left=�6   $	��150��62    .  6A   �� *	Warehouse+$ TwoWay=���5      �� *WarehouseNames+5      �� 5      ��6     *
BaseUnit+$  :���� 5      $
��Left=�6   $	��100��61   ��6@   �� *
BaseUnit+$ TwoWay=��� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� .+�5      �� ��6     *TransactionUnit+$  :���� 5      $
��Left=�6   $	��100��69   ��6H   �� *TransactionUnit+$ TwoWay=�5      �� 5      $
��10,0q�6   .+�5      �� ��6     *TransacitonUnitMultiplier+$  :��<   6Samba.Presentation.Controls.UIControls.FilteredTextBox  5      $
��Left=�61      Type$ Number=�6L   $��50��6Z   ��6h   �� *TransactionUnitMultiplier+$ TwoWay=�5      5      �� 5      $
��Left=�6   $
��0,10q�60   $��70��6>   ��6L   �� *SaveCommand.Caption+��5       �� *SaveCommand+�� 5!      
���  ����6   �� *Error+6.   5"      5#      5$      