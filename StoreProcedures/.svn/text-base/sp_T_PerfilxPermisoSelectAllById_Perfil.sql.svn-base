if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_PerfilxPermisoSelectAllById_Perfil]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_PerfilxPermisoSelectAllById_Perfil]
GO

CREATE PROCEDURE [dbo].[sp_T_PerfilxPermisoSelectAllById_Perfil]
(
	@Id_Perfil int
)

AS

SET NOCOUNT ON

SELECT [Id_Perfil],
	pp.[Id_Permiso],
	p.Permiso
FROM [T_PerfilxPermiso] as pp inner join T_Permiso as p on pp.Id_Permiso =p.Id_Permiso
WHERE [Id_Perfil] = @Id_Perfil
GO


