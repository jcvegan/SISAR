if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_ProductoSelectAllMenu]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_ProductoSelectAllMenu]
GO

CREATE PROCEDURE [dbo].[sp_T_ProductoSelectAllMenu]

AS

SET NOCOUNT ON

declare @entrada int
declare @fondo int
declare @postre int
set @entrada = (select Id_Categoria from T_Categoria where Nombre='Entradas') 
set @fondo = (select Id_Categoria from T_Categoria where Nombre='Platos de Fondo') 
set @postre = (select Id_Categoria from T_Categoria where Nombre='Postres') 
SELECT [Id_Producto],
	P.[Nombre],
	P.[Descripcion],
	P.[PrecioUnitario],
	P.[Imagen],
	P.[Observacion],
	P.[Id_Categoria],
	P.[Id_Moneda]
FROM [T_Producto] as P
INNER JOIN [T_Categoria] as C ON P.Id_Categoria = C.Id_Categoria
WHERE P.Id_Categoria = @entrada or P.Id_Categoria =@fondo or P.Id_Categoria= @postre
union all
SELECT [Id_Producto],
	P.[Nombre],
	P.[Descripcion],
	P.[PrecioUnitario],
	P.[Imagen],
	P.[Observacion],
	C.[Categoria_Padre],
	P.[Id_Moneda]
FROM [T_Producto] as P
INNER JOIN [T_Categoria] as C ON P.Id_Categoria = C.Id_Categoria
WHERE 
C.Categoria_Padre = @entrada or C.Categoria_Padre =@fondo or C.Categoria_Padre= @postre
GO