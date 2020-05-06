if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_MenuInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_MenuInsert]
GO

CREATE PROCEDURE [dbo].[sp_T_MenuInsert]
(
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@PrecioUnitario decimal(12, 2),
	@Observacion varchar(255)
)

AS

SET NOCOUNT ON

INSERT INTO [T_Menu]
(
	[Nombre],
	[Descripcion],
	[PrecioUnitario],
	[Observacion]
)
VALUES
(
	@Nombre,
	@Descripcion,
	@PrecioUnitario,
	@Observacion
)

SELECT SCOPE_IDENTITY()
GO
