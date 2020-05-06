if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_DistribucionxMesaInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_DistribucionxMesaInsert]
GO

CREATE PROCEDURE [dbo].[sp_T_DistribucionxMesaInsert]
(
	@Posicion_X decimal(12, 2),
	@Posicion_Y decimal(12, 2),
	@Numero_Mesa int,
	@Id_Distribucion int,
	@Id_Mesa int,
	@Estado varchar(255)
)

AS

SET NOCOUNT ON

INSERT INTO [T_DistribucionxMesa]
(
	[Posicion_X],
	[Posicion_Y],
	[Numero_Mesa],
	[Id_Distribucion],
	[Id_Mesa],
	[Estado]
)
VALUES
(
	@Posicion_X,
	@Posicion_Y,
	@Numero_Mesa,
	@Id_Distribucion,
	@Id_Mesa,
	@Estado
)

SELECT SCOPE_IDENTITY()
GO
