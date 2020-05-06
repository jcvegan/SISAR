if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_Detalle_PedidoSelectAllById_Local]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_Detalle_PedidoSelectAllById_Local]
GO

CREATE PROCEDURE [dbo].[sp_T_Detalle_PedidoSelectAllById_Local]
(
	@Id_Local int
)
AS

SET NOCOUNT ON

SELECT [Id_Detalle_Pedido],
	producto.[Nombre] as Producto,
	categoria.[nombre] as Categoria,
	zona.[Nombre] as Zona,
	distribucionxMesa.[Numero_Mesa] as Mesa,
	pedido.[Fecha] as Hora,
	detalle.[Observacion] as Detalle	
FROM [T_Detalle_Pedido] as detalle
inner join [T_Producto] as producto ON producto.Id_Producto = detalle.Id_Producto
inner join [T_Categoria] as categoria ON categoria.Id_Categoria = producto.Id_Categoria
inner join [T_Pedido] as pedido ON pedido.Id_Pedido = detalle.Id_Pedido
inner join [T_DistribucionxMesa] as distribucionxMesa ON distribucionxMesa.Id_Codigo_Mesa = pedido.Id_Codigo_Mesa
inner join [T_Distribucion] as distribucion ON distribucion.Id_Distribucion = distribucionxMesa.Id_Distribucion
inner join [T_Zona] as zona ON zona.Id_Zona = distribucion.Id_Zona
WHERE zona.[Id_Local] = @Id_Local and detalle.Estado = 'SOLICITADO'
GO
