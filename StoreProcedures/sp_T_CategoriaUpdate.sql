if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_CategoriaUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_CategoriaUpdate]
GO

CREATE PROCEDURE [dbo].[sp_T_CategoriaUpdate]
(
	@Id_Categoria int,
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@Categoria_Padre int
)

AS

SET NOCOUNT ON

if(@Categoria_Padre =0)
set @Categoria_Padre =null

UPDATE [T_Categoria]
SET [Nombre] = @Nombre,
	[Descripcion] = @Descripcion,
	[Categoria_Padre] = @Categoria_Padre
WHERE [Id_Categoria] = @Id_Categoria
GO
