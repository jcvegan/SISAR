if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_PerfilInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_PerfilInsert]
GO

CREATE PROCEDURE [dbo].[sp_T_PerfilInsert]
(
	@Nombre varchar(255),
	@Descripcion varchar(255)
)

AS

SET NOCOUNT ON

INSERT INTO [T_Perfil]
(
	[Nombre],
	[Descripcion]
)
VALUES
(
	@Nombre,
	@Descripcion
)

SELECT SCOPE_IDENTITY()
GO
