if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_LocalDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_LocalDelete]
GO

CREATE PROCEDURE [dbo].[sp_T_LocalDelete]
(
	@Id_Local int
)

AS

SET NOCOUNT ON

DELETE FROM [T_Local]
WHERE [Id_Local] = @Id_Local
GO
