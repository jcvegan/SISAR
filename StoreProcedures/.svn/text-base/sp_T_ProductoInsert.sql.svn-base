if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_ProductoInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_ProductoInsert]
GO

CREATE PROCEDURE [dbo].[sp_T_ProductoInsert]
(
	@Nombre varchar(255),
	@Descripcion varchar(255),
	@PrecioUnitario decimal(12, 2),
	@Imagen image,
	@Observacion varchar(255),
	@Id_Categoria int,
	@Id_Moneda int
)

AS

SET NOCOUNT ON

INSERT INTO [T_Producto]
(
	[Nombre],
	[Descripcion],
	[PrecioUnitario],
	[Imagen],
	[Observacion],
	[Id_Categoria],
	[Id_Moneda]
)
VALUES
(
	@Nombre,
	@Descripcion,
	@PrecioUnitario,
	@Imagen,
	@Observacion,
	@Id_Categoria,
	@Id_Moneda
)
GO
