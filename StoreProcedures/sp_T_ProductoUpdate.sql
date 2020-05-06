if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_ProductoUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_ProductoUpdate]
GO

CREATE PROCEDURE [dbo].[sp_T_ProductoUpdate]
(
	@Id_Producto int,
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

UPDATE [T_Producto]
SET [Nombre] = @Nombre,
	[Descripcion] = @Descripcion,
	[PrecioUnitario] = @PrecioUnitario,
	[Imagen] = @Imagen,
	[Observacion] = @Observacion,
	[Id_Categoria] = @Id_Categoria,
	[Id_Moneda] = @Id_Moneda
WHERE [Id_Producto] = @Id_Producto
GO
