if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_UsuarioInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_UsuarioInsert]
GO

CREATE PROCEDURE [dbo].[sp_T_UsuarioInsert]
(
	@Id_Usuario int,
	@Nombres varchar(255),
	@Apellidos varchar(255),
	@Telefono varchar(255),
	@Direccion varchar(255),
	@Email varchar(255),
	@Fecha_Registro datetime,
	@Contraseña varchar(255),
	@Estado varchar(255),
	@Id_Local int,
	@Id_Perfil int,
	@Fecha_Nacimiento datetime
)

AS

SET NOCOUNT ON

if(@Id_Local=0)
set @Id_Local = null

INSERT INTO [T_Usuario]
(
	[Id_Usuario],
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
)
VALUES
(
	@Id_Usuario,
	@Nombres,
	@Apellidos,
	@Telefono,
	@Direccion,
	@Email,
	@Fecha_Registro,
	@Contraseña,
	@Estado,
	@Id_Local,
	@Id_Perfil,
	@Fecha_Nacimiento
)
GO
