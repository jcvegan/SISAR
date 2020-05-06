if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_MenuDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_MenuDelete]
GO

CREATE PROCEDURE [dbo].[sp_T_MenuDelete]
(
	@Id_Menu int
)

AS

SET NOCOUNT ON

DELETE FROM [T_Menu]
WHERE [Id_Menu] = @Id_Menu
GO
