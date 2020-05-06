if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_CategoriaDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_CategoriaDelete]
GO

CREATE PROCEDURE [dbo].[sp_T_CategoriaDelete]
(
	@Id_Categoria int
)

AS

SET NOCOUNT ON

DELETE FROM [T_Categoria]
WHERE [Id_Categoria] = @Id_Categoria
GO
