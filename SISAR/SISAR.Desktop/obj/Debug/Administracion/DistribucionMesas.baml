   M S B A M L   `   `   `  ����H  DSISAR.Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SISAR.Desktop.AdministracionSISAR.Desktop.Administracion  5      4    .SISAR.Desktop.Administracion.DistribucionMesas   5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      :local*clr-namespace:SISAR.Desktop.Administracion    5      -   5          � 	Resources  5         TemplateItem+   %SISAR.Desktop.Administracion.MesaItem 	 Mesa1 	 Mesa2 	 Mesa3��%  &	        &	 (     &	 m     &	 �     �� 5   
   .R�5	        5
      �� 5   
   $1��+/SISAR.Desktop;Component/Imagenes/Mesa2.png��6   �� 5   
   $1��+/SISAR.Desktop;Component/Imagenes/Mesa4.png��6   �� 5   
   $1��+/SISAR.Desktop;Component/Imagenes/Mesa8.png��6   5      .��5      �� $��Distribución de Mesas��6   .��5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    $	��100��6.   �� 5      $��* �6    .+�5      � $��Center=�6   .+�5      ��  �� Orientation$ Vertical=�6   .+�5      �� $ 
Horizontal=�6!   $y�	Collapsed=�6:   .+�5      �� $��Codigo Distribucion��6    $	��120��6>   $��Center=�6J   $��Center=�6g   �� 5      -   5        $��txtID_Distribucion��5   "   $	��150��6=   5      �� 5      $ 
Horizontal=�6!   .+�5      �� $��Nombre��6    $	��120��61   $��Center=�6=   $��Center=�6Z   �� 5      -   5        $��	txtNombre��5   "   $	��150��63   6?   5       �� 5!      $ 
Horizontal=�6!   .+�5"      �� $��Descripcion��6    $	��120��66   $��Center=�6B   $��Center=�6_   �� 5#      -   5        $��txtDescripcion��5#   "   $	��150��68   5$      �� 5%      $ 
Horizontal=�6!   .+�5&      �� -   5        $��	chbEstado��5&   #   $��Establecer como principal��65   $��Center=�6Z   $��Center=�6w   5'      5(      5)      �� 5*      -   5        $��lvDistribucion��5*      ��. $��1��6�   ��6-   ��  �� View 5+      �� 5,      .P�5-      �� $��Codigo Distribucion��6)    �� Width$ 0��6|    �� DisplayMemberBinding 6F   ��  �� Path$ Id_Distribucion�6|   �� 5.      $��Nombres��6)    6:   �� $ Nombre��� 5/      $��Descripción��6)    6>   �� $ Descripcion��� 50      $��Estado��6)    69   �� $ Estado�51      53      � 54   
   $��2��6    � ColumnDefinitions 55      �� 56      $
��0.8* �6#   �� 57      $
��0.2* �6#   .+�59      �� $��
Utilidades��6   $��1��6+   .��5:      �  5;      �� 5<      $
��Auto �6(   �� 5=      $
��Auto �6(   �� 5>      $��* �6(   .+�5@      �� �� 5A      $��Mesas��6   �� 5B      -   5        $
��list��5B      $��1��6*   �� 5C      -   5        $��trash��5C   !   $��2��6.   
������ 6<   5D      5E      �� 5F      -	   5        $��Zonas��5F      6&   �� 5G       �� ResizeDirection$ Columns=�6   $��0��65   $��1��6E   
���iii�$��3��6n   5H      5I      5J      5K      