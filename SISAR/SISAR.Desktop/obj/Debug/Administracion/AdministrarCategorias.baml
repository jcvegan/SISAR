   M S B A M L   `   `   `  ����K  GSISAR.Converters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM8clr-namespace:SISAR.Converters;assembly=SISAR.ConvertersSISAR.Converters  5       SISAR.Desktop8   2SISAR.Desktop.Administracion.AdministrarCategorias   5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      M
converters8clr-namespace:SISAR.Converters;assembly=SISAR.Converters    5        � 	Resources  5      (   "SISAR.Converters.CategoryConverter   CategoryConverter0   *SISAR.Converters.VisibilityObjectConverter  VisibilityConverter��%:   &	        &	        5   
   6'     5   
   6/   5	      .��5
      �� -   5        $
��Form��5
      $��Administrar Categorias��6   .��5      �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      �� $��Center=�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $y�	Collapsed=�66   .+�5      �� $��Codigo��6   $	��120��6-   $��Center=�69   $��Center=�6V   �� 5      -   5        $��txtID_Categoria��5      $	��170��65   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Nombre��6   $	��120��6-   $��Center=�69   $��Center=�6V   �� 5      -   5        $��	txtNombre��5      $	��170��6/   6;   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Descripción��6   $	��120��62   $��Center=�6>   $��Center=�6[   �� 5      -   5        $��txtDescripcion��5      $	��170��64   5      �� 5      $��Categoria Padre��6   .��5      �� $ Vertical=�6!   .+�5       �� -   5        $��chbPadre��5    #   $��Tiene Categoria Padre��64   �� 5!      -   5        $��cmbCategoriaPadre��5!   #    �� SelectedValuePath$ Id_Categoria��6<   $��Center=�6]   $	��120��6z   ��6�   �� y�6�   ��  �� ElementName$ chbPadre�� �� Path$ 	IsChecked� �� 	Converter# [  �� Mode$ OneWay=���5"      �� 5#   "   .R�5$   &   �� ��60   �� $ Id_Categoria�# [  5%   #   5'      5(      5)      5*      �� 5+      $ Vertical=�6   $��1��64   .+�5,      �� $��	Categoria��6   �� 5-      -   5        $��lvCategorias��5-      ��63   ��  �� View 5.      �� 5/      .P�50   "   �� $��Codigo Categoria��61   	 �� Width$	 0��6~   
 �� DisplayMemberBinding
 6K   �� $ Id_Categoria�6~   �� 51   "   $��Nombre��61   
 6A   �� $ Nombre��� 52   "   $��Descripcion��61   
 6F   �� $ Descripcion�53      55      �� 56      $��SubCategoria��6   �� 57      -   5        $��lvSubCategorias��57      ��66   ��  58      �� 59      .P�5:   "   �� $��Codigo Sub-Categotia��61   $	 0��6�   
 6O   �� $ Id_Categoria�6�   �� 5;   "   $��Nombre��61   
 6A   �� $ Nombre��� 5<   "   $��Descripcion��61   
 6F   �� $ Descripcion��� 5=   "   $��	Categoria��61   
 6D   �� $ Categoria_Padre�# [  5>      5@      5A      5B      5C      5D      