if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_DistribucionUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_DistribucionUpdate]
GO

CREATE PROCEDURE [dbo].[sp_T_DistribucionUpdate]
(
	@Id_Distribucion int,
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@Id_Zona int,
	@Estado bit
)

AS

SET NOCOUNT ON

if(@Estado=1)
	update T_Distribucion set Estado=0 where Id_Zona = @Id_Zona and Estado = 1
	
UPDATE [T_Distribucion]
SET [Nombre] = @Nombre,
	[Descripcion] = @Descripcion,
	[Id_Zona] = @Id_Zona,
	[Estado] = @Estado
WHERE [Id_Distribucion] = @Id_Distribucion
if(@Estado=0)
	 update T_Distribucion set Estado = 1 where Id_Distribucion in (select Id_Distribucion = min(Id_Distribucion) from T_Distribucion where Id_Zona = @Id_Zona and Estado = 0 and Id_Distribucion != @Id_Distribucion)

GO
