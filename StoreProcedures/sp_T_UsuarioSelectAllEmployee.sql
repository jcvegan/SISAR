if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_UsuarioSelectAllEmployee]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_UsuarioSelectAllEmployee]
GO

CREATE PROCEDURE [dbo].[sp_T_UsuarioSelectAllEmployee]

AS

SET NOCOUNT ON

SELECT [Id_Usuario],
	[Nombres],
	[Apellidos],
	[Telefono],
	[Direccion],
	[Email],
	[Fecha_Registro],
	[Contraseña],
	[Estado],
	[Id_Local],
	[Id_Perfil],
	[Fecha_Nacimiento]
FROM [T_Usuario]
Where Id_Local is not null
GO
