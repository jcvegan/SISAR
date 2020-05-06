if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_CategoriaSelectAllByCategoria_Padre]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_CategoriaSelectAllByCategoria_Padre]
GO

CREATE PROCEDURE [dbo].[sp_T_CategoriaSelectAllByCategoria_Padre]
(
	@Categoria_Padre int
)

AS

SET NOCOUNT ON

SELECT [Id_Categoria],
	[Nombre],
	[Descripcion],
	[Categoria_Padre]
FROM [T_Categoria]
WHERE [Categoria_Padre] = @Categoria_Padre
GO
