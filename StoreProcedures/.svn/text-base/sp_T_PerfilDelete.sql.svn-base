if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_PerfilDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_PerfilDelete]
GO

CREATE PROCEDURE [dbo].[sp_T_PerfilDelete]
(
	@Id_Perfil int
)

AS

SET NOCOUNT ON

DELETE FROM [T_Perfil]
WHERE [Id_Perfil] = @Id_Perfil
GO
