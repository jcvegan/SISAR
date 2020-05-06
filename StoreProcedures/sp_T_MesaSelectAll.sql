if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_MesaSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_MesaSelectAll]
GO

CREATE PROCEDURE [dbo].[sp_T_MesaSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Mesa],
	[Descripcion],
	[Imagen],
	[Cantidad],
	[Width],
	[Height]
FROM [T_Mesa]
GO
