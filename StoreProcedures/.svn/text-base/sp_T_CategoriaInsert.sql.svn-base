if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_CategoriaInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_CategoriaInsert]
GO

CREATE PROCEDURE [dbo].[sp_T_CategoriaInsert]
(
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@Categoria_Padre int
)

AS

SET NOCOUNT ON

if(@Categoria_Padre = 0)
set @Categoria_Padre=null

INSERT INTO [T_Categoria]
(
	[Nombre],
	[Descripcion],
	[Categoria_Padre]
)
VALUES
(
	@Nombre,
	@Descripcion,
	@Categoria_Padre
)
GO
