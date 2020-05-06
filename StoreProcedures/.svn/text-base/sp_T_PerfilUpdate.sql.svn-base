if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_PerfilUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_PerfilUpdate]
GO

CREATE PROCEDURE [dbo].[sp_T_PerfilUpdate]
(
	@Id_Perfil int,
	@Nombre varchar(255),
	@Descripcion varchar(255)
)

AS

SET NOCOUNT ON

UPDATE [T_Perfil]
SET [Nombre] = @Nombre,
	[Descripcion] = @Descripcion
WHERE [Id_Perfil] = @Id_Perfil
GO
