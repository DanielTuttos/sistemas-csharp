   M S B A M L   `   `   `  ����  
WPFejemplo    WPFejemplo.Consulta   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Consulta��5   	   $��416.166��6   $��524.798��6+    � WindowStartupLocation$ CenterScreen=�6;   .��5      � .+�5   
   �� $��Formulario de consulta��6   $
��Left=�61   $��0,10,0,0q�6L   $	��Top=�6^   $	��517��6v   $��38��6�   $��Center=�6�   $��Center=�6�   $��18(�6�   $
��Bold"�6�   �� 5   
   $��Nombre :��6   $
��Left=�6#   $��
85,235,0,0q�6>   $	��Top=�6R   $
��Bold"�6j   �� 5   
   $��	Estado : ��6   $
��Left=�6$   $��
85,296,0,0q�6?   $	��Top=�6S   $
��Bold"�6k   �� 5	   
   $��	Ventas : ��6   $
��Left=�6$   $��
85,265,0,0q�6?   $	��Top=�6S   $
��Bold"�6k   �� 5
   
   -   5         ��Name$ 	txtnombre��5
      $
��Left=�6%   $��23��6@   $��183,238,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��248��6�   �� 5   
   -   5        $ 	txtestado��5      $
��Left=�6%   $��23��6@   $��183,299,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��248��6�   �� 5   
   -   5        $ 	txtventas��5      $
��Left=�6%   $��23��6@   $��183,268,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��248��6�   �� 5   
   -   5         ��Name$ btnmodificar��5      $��	Modificar��6'   $
��Left=�6;   $��
85,330,0,0q�6V   $	��Top=�6j   $	��103��6�   $��32��6�   6�   �� 5   
   -   5        $ btneliminar��5      $��Eliminar��6&   $
��Left=�69   $��205,330,0,0q�6T   $	��Top=�6i   $	��103��6�   $��32��6�   6�   �� 5   
   -   5        $ 	btnvolver��5      $��Volver��6$   $
��Left=�65   $��328,330,0,0q�6P   $	��Top=�6e   $	��103��6}   $��32��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgdatos��5      $
��Left=�6$   $��
85,118,0,0q�6?   $	��Top=�6S   $��87��6k   $	��346��6w      AutoGenerateColumns .     GridLinesVisibility$
 None=�6�   
���   �
���   ���6�   Z�    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Nombre��6@   
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Nombre+6P     5      $	 Total ventas��6E   
 .  6%   �� *TotalVentas+6[     5      $	 Estado��6@   
 .  6%   �� *Estado+6P   5      �� 5   
   $��	Buscar : ��6   $
��Left=�6$   $��	85,73,0,0q�6?   $	��Top=�6R   $
��Bold"�6j   �� 5   
   -   5        $ 
txtmostrar��5      $
��Left=�6&   $��23��6A   $��
153,76,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��155��6�   �� 5   
   -	   5        $ 
btnmostrar��5      $��Mostrar��6%   $
��Left=�67   $��
328,76,0,0q�6R   $	��Top=�6f   $	��103��6~   $��23��6�   6�   5      5      