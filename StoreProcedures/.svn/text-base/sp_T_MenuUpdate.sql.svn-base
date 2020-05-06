if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_MenuUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_MenuUpdate]
GO

CREATE PROCEDURE [dbo].[sp_T_MenuUpdate]
(
	@Id_Menu int,
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@PrecioUnitario decimal(12, 2),
	@Observacion varchar(255)
)

AS

SET NOCOUNT ON

UPDATE [T_Menu]
SET [Nombre] = @Nombre,
	[Descripcion] = @Descripcion,
	[PrecioUnitario] = @PrecioUnitario,
	[Observacion] = @Observacion
WHERE [Id_Menu] = @Id_Menu
GO
