   M S B A M L   `   `   `  ����  SISAR.Desktop-    'SISAR.Desktop.Atencion.ConfirmarPedidos   5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      ;toolkit-http://schemas.microsoft.com/wpf/2008/toolkit  5      -   5        .��5      � .+�5   
   )  #Microsoft.Windows.Controls.DataGrid  -   5           Name$  ListaPedidos��5      $   HorizontalScrollBarVisibility$ Hidden=�6I      SelectionMode$ Extended=�6p      CanUserAddRows .     CanUserDeleteRows .     CanUserResizeRows .     CanUserSortColumns .     AutoGenerateColumns .  ��61   ��    Columns 5      3  -Microsoft.Windows.Controls.DataGridTextColumn  5	      -   5        	CodPedido��/  )Microsoft.Windows.Controls.DataGridColumn	   Header$	 Codigo Pedido��5	   @   
   MaxWidth$
 0Q�6W      
IsReadOnly . 4  .Microsoft.Windows.Controls.DataGridBoundColumn   Binding 6d   ��  �� Path$ Id_DetallePedido�6�     5
      -   5        Producto��$	 Producto��5
   ?      MinWidth$ 60Q�6Q    .  6_   �� $ Producto�6�     5      -   5        	Categoria��$	 	Categoria��5   @   $ 60Q�6S    .  6a   �� $ 	Categoria�6�     5      -   5        Zona��$
	 Zona��5   ;   $ 40Q�6I    .  6W   �� $
 Zona�6u     5      -   5        Mesa��$
	 Mesa��5   ;   $ 40Q�6I    .  6W   �� $
 Mesa�6v     5      -   5        
HoraPedido��$	 Hora de Pedido��5   A   $ 50Q�6Y    .  6g   �� $
 Hora�6�     5      -	   5        Detalle��$	 Detalle��5   >   $ 50Q�6O    .  6]   �� $ Detalle�6   7  1Microsoft.Windows.Controls.DataGridTemplateColumn  5      -
   5        Confirmacion��$	 Confirmación��5   G    .    CellTemplate 5      �� 5      .R�5      d� -   5        $��Listo��5   +   $	��100��6;   $��30��6G   6S   5      5      5      5      5      