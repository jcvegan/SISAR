if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_ProductoDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_ProductoDelete]
GO

CREATE PROCEDURE [dbo].[sp_T_ProductoDelete]
(
	@Id_Producto int
)

AS

SET NOCOUNT ON

DELETE FROM [T_Producto]
WHERE [Id_Producto] = @Id_Producto
GO
