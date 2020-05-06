if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_UsuarioDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_UsuarioDelete]
GO

CREATE PROCEDURE [dbo].[sp_T_UsuarioDelete]
(
	@Id_Usuario int
)

AS

SET NOCOUNT ON

DELETE FROM [T_Usuario]
WHERE [Id_Usuario] = @Id_Usuario
GO
