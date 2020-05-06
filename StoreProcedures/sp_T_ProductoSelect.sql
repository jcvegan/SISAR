if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_ProductoSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_ProductoSelect]
GO

CREATE PROCEDURE [dbo].[sp_T_ProductoSelect]
(
	@Id_Producto int
)

AS

SET NOCOUNT ON

SELECT [Id_Producto],
	[Nombre],
	[Descripcion],
	[PrecioUnitario],
	[Imagen],
	[Observacion],
	[Id_Categoria],
	[Id_Moneda]
FROM [T_Producto]
WHERE [Id_Producto] = @Id_Producto
GO
