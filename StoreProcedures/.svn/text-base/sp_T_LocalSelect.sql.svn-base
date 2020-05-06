if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_LocalSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_LocalSelect]
GO

CREATE PROCEDURE [dbo].[sp_T_LocalSelect]
(
	@Id_Local int
)

AS

SET NOCOUNT ON

SELECT [Id_Local],
	[Nombre],
	[Direccion],
	[Telefono]
FROM [T_Local]
WHERE [Id_Local] = @Id_Local
GO
