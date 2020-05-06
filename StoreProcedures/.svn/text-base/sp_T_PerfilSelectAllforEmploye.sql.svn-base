if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_PerfilSelectAllforEmploye]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_PerfilSelectAllforEmploye]
GO

CREATE PROCEDURE [dbo].[sp_T_PerfilSelectAllforEmploye]

AS

SET NOCOUNT ON

SELECT [Id_Perfil],
	[Nombre],
	[Descripcion]
FROM [T_Perfil]
where Descripcion like 'Trabajador%'
GO

