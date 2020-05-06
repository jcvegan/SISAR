if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_CategoriaSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_CategoriaSelect]
GO

CREATE PROCEDURE [dbo].[sp_T_CategoriaSelect]
(
	@Id_Categoria int
)

AS

SET NOCOUNT ON

SELECT [Id_Categoria],
	[Nombre],
	[Descripcion],
	[Categoria_Padre]
FROM [T_Categoria]
WHERE [Id_Categoria] = @Id_Categoria
GO
