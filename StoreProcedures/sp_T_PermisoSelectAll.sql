if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_PermisoSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_PermisoSelectAll]
GO

CREATE PROCEDURE [dbo].[sp_T_PermisoSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Permiso],
	[Permiso],
	[Paquete]
FROM [T_Permiso]
GO
