if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_PerfilSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_PerfilSelect]
GO

CREATE PROCEDURE [dbo].[sp_T_PerfilSelect]
(
	@Id_Perfil int
)

AS

SET NOCOUNT ON

SELECT [Id_Perfil],
	[Nombre],
	[Descripcion]
FROM [T_Perfil]
WHERE [Id_Perfil] = @Id_Perfil
GO
