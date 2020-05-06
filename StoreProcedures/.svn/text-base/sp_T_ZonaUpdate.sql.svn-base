if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_ZonaUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_ZonaUpdate]
GO

CREATE PROCEDURE [dbo].[sp_T_ZonaUpdate]
(
	@Id_Zona int,
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@Id_Local int,
	@Aforo int
)

AS

SET NOCOUNT ON

UPDATE [T_Zona]
SET [Nombre] = @Nombre,
	[Descripcion] = @Descripcion,
	[Id_Local] = @Id_Local,
	[Aforo] = @Aforo
WHERE [Id_Zona] = @Id_Zona
GO
