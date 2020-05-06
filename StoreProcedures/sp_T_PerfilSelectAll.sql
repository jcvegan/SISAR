if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_PerfilSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_PerfilSelectAll]
GO

CREATE PROCEDURE [dbo].[sp_T_PerfilSelectAll]

AS

SET NOCOUNT ON

SELECT [Id_Perfil],
	[Nombre],
	[Descripcion]
FROM [T_Perfil]
GO
