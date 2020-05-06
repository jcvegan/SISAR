if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_DistribucionInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_DistribucionInsert]
GO

CREATE PROCEDURE [dbo].[sp_T_DistribucionInsert]
(
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@Id_Zona int,
	@Estado bit
)

AS

SET NOCOUNT ON

if(@Estado=1)
	update T_Distribucion set Estado=0 where Id_Zona = @Id_Zona and Estado = 1

INSERT INTO [T_Distribucion]
(
	[Nombre],
	[Descripcion],
	[Id_Zona],
	[Estado]
)
VALUES
(
	@Nombre,
	@Descripcion,
	@Id_Zona,
	@Estado
)

SELECT SCOPE_IDENTITY()
GO
