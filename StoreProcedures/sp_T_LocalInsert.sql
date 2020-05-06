if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_LocalInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_LocalInsert]
GO

CREATE PROCEDURE [dbo].[sp_T_LocalInsert]
(
	@Nombre varchar(255),
	@Direccion varchar(255),
	@Telefono int
)

AS

SET NOCOUNT ON

INSERT INTO [T_Local]
(
	[Nombre],
	[Direccion],
	[Telefono]
)
VALUES
(
	@Nombre,
	@Direccion,
	@Telefono
)

SELECT SCOPE_IDENTITY()
GO
