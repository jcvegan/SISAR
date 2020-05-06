if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_Detalle_MenuInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_Detalle_MenuInsert]
GO

CREATE PROCEDURE [dbo].[sp_T_Detalle_MenuInsert]
(
	@Id_Producto int,
	@Id_Menu int
)

AS

SET NOCOUNT ON

INSERT INTO [T_Detalle_Menu]
(
	[Id_Producto],
	[Id_Menu]
)
VALUES
(
	@Id_Producto,
	@Id_Menu
)
GO
