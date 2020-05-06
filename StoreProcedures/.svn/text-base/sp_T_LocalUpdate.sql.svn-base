if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_LocalUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_LocalUpdate]
GO

CREATE PROCEDURE [dbo].[sp_T_LocalUpdate]
(
	@Id_Local int,
	@Nombre varchar(255),
	@Direccion varchar(255),
	@Telefono int
)

AS

SET NOCOUNT ON

UPDATE [T_Local]
SET [Nombre] = @Nombre,
	[Direccion] = @Direccion,
	[Telefono] = @Telefono
WHERE [Id_Local] = @Id_Local
GO
