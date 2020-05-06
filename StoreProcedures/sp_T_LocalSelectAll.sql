if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_LocalSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_LocalSelectAll]
GO

CREATE PROCEDURE [dbo].[sp_T_LocalSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Local],
	[Nombre],
	[Direccion],
	[Telefono]
FROM [T_Local]
GO
