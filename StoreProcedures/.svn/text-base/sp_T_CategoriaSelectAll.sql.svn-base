if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_CategoriaSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_CategoriaSelectAll]
GO

CREATE PROCEDURE [dbo].[sp_T_CategoriaSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Categoria],
	[Nombre],
	[Descripcion],
	[Categoria_Padre]
FROM [T_Categoria]
GO
