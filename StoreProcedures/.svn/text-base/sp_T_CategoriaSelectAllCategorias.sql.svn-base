if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_CategoriaSelectAllCategorias]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_CategoriaSelectAllCategorias]
GO

CREATE PROCEDURE [dbo].[sp_T_CategoriaSelectAllCategorias]

AS

SET NOCOUNT ON

SELECT [Id_Categoria],
	[Nombre],
	[Descripcion]
FROM [T_Categoria]
where Categoria_Padre is null
GO
