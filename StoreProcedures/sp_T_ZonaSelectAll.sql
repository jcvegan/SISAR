if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_ZonaSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_ZonaSelectAll]
GO

CREATE PROCEDURE [dbo].[sp_T_ZonaSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Zona],
	[Nombre],
	[Descripcion],
	[Id_Local],
	[Aforo]
FROM [T_Zona]
GO
