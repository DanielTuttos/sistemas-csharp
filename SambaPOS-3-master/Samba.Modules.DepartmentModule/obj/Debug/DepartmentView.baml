   M S B A M L   `   `   `  ����"  Samba.Modules.DepartmentModule3    -Samba.Modules.DepartmentModule.DepartmentView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6F   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6E   @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5
   
   �� .+�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *Name_f+   FormatSegment1   *
Department+   Suffix$ :���� 5      $
��Left=�6   $	��200��61   ��6@   �� *Name+ �� Mode$ TwoWay=��� 5      ��6     *	Default_f+   *
TicketType+$ :���� 5      $
��Left=�6   $	��170��62    �� SelectedValuePath$ Id��5   G    �� DisplayMemberPath$
 Name��6^    �� SelectedValue 5   A   �� *TicketTypeId+��5   #   �� *TicketTypes+6^   �� 5      ��6     *	Default_f+   *Menu+$ :���� 5      $
��Left=�6   $	��170��62    �� 
IsEditable . $ Id��5   G   $
 Name��6^    5   S   �� *ScreenMenuId+��5   #   �� *ScreenMenus+6^   �� 5      ��6     *	Warehouse+$ :���� 5      $
��Left=�6   $	��170��62   $ Id��5   F   $
 Name��6]    5   A   �� *WarehouseId+��5   #   �� *
Warehouses+6]   �� 5      ��6     *
PriceTag+$ :���� 5      $
��Left=�6   $	��150��62    . ��5      �� *	PriceTags+ �� Text 6A   �� *
PriceTag+�� 5      ��6     *TicketCreationMethod+$ :���� 5      $
��Left=�6   $	��150��62   ��6A   �� *TicketCreationMethods+	 �� SelectedItem	 6o   �� *TicketCreationMethod+5      �� 5   
   $��1��6   .+�5       �� $
��Left=�6   $
��0,10q�60   $��70��6>   ��6L   �� *SaveCommand.Caption+��5!      �� *SaveCommand+�� 5"      
���  ����6   �� *Error+6/   5#      5$      5%      