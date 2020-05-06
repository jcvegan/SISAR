if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_UsuarioUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_UsuarioUpdate]
GO

CREATE PROCEDURE [dbo].[sp_T_UsuarioUpdate]
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

if(@Id_Local =0)
set @Id_Local = null

UPDATE [T_Usuario]
SET [Nombres] = @Nombres,
	[Apellidos] = @Apellidos,
	[Telefono] = @Telefono,
	[Direccion] = @Direccion,
	[Email] = @Email,
	[Fecha_Registro] = @Fecha_Registro,
	[Contraseña] = @Contraseña,
	[Estado] = @Estado,
	[Id_Local] = @Id_Local,
	[Id_Perfil] = @Id_Perfil,
	[Fecha_Nacimiento] = @Fecha_Nacimiento
WHERE [Id_Usuario] = @Id_Usuario
GO
