if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_Detalle_MenuSelectAllById_Menu]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_Detalle_MenuSelectAllById_Menu]
GO

CREATE PROCEDURE [dbo].[sp_T_Detalle_MenuSelectAllById_Menu]
(
	@Id_Menu int
)

AS

SET NOCOUNT ON

SELECT [Id_Producto],
	[Id_Menu]
FROM [T_Detalle_Menu]
WHERE [Id_Menu] = @Id_Menu
GO
