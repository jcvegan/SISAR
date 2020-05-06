if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_Detalle_PedidoUpdateEstado]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_Detalle_PedidoUpdateEstado]
GO

CREATE PROCEDURE [dbo].[sp_T_Detalle_PedidoUpdateEstado]
(
	@Id_Detalle_Pedido int,
	@Estado varchar(255)
)

AS

SET NOCOUNT ON

UPDATE [T_Detalle_Pedido]
SET [Estado] = @Estado
WHERE [Id_Detalle_Pedido] = @Id_Detalle_Pedido 
GO
