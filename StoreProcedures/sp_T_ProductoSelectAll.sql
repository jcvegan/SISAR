if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_ProductoSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_ProductoSelectAll]
GO

CREATE PROCEDURE [dbo].[sp_T_ProductoSelectAll]

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
GO
