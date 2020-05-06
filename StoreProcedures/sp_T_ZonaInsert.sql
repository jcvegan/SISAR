if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_ZonaInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_ZonaInsert]
GO

CREATE PROCEDURE [dbo].[sp_T_ZonaInsert]
(
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@Id_Local int,
	@Aforo int
)

AS

SET NOCOUNT ON

INSERT INTO [T_Zona]
(
	[Nombre],
	[Descripcion],
	[Id_Local],
	[Aforo]
)
VALUES
(
	@Nombre,
	@Descripcion,
	@Id_Local,
	@Aforo
)

SELECT SCOPE_IDENTITY()
GO
