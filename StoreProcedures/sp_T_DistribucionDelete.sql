if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_DistribucionDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_DistribucionDelete]
GO

CREATE PROCEDURE [dbo].[sp_T_DistribucionDelete]
(
	@Id_Distribucion int
)

AS

SET NOCOUNT ON

DELETE FROM [T_Distribucion]
WHERE [Id_Distribucion] = @Id_Distribucion
GO
