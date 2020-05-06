if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_MonedaSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_MonedaSelect]
GO

CREATE PROCEDURE [dbo].[sp_T_MonedaSelect]
(
	@Id_Moneda int
)

AS

SET NOCOUNT ON

SELECT [Id_Moneda],
	[Nombre],
	[Simbolo]
FROM [T_Moneda]
WHERE [Id_Moneda] = @Id_Moneda
GO
