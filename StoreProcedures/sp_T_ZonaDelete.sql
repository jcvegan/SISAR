if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_ZonaDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_ZonaDelete]
GO

CREATE PROCEDURE [dbo].[sp_T_ZonaDelete]
(
	@Id_Zona int
)

AS

SET NOCOUNT ON

DELETE FROM [T_Zona]
WHERE [Id_Zona] = @Id_Zona
GO
