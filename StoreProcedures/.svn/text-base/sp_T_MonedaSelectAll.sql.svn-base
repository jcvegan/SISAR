if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_MonedaSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_MonedaSelectAll]
GO

CREATE PROCEDURE [dbo].[sp_T_MonedaSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Moneda],
	[Nombre],
	[Simbolo]
FROM [T_Moneda]
GO
