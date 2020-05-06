if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_MenuSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_MenuSelectAll]
GO

CREATE PROCEDURE [dbo].[sp_T_MenuSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Menu],
	[Nombre],
	[Descripcion],
	[PrecioUnitario],
	[Observacion]
FROM [T_Menu]
GO
