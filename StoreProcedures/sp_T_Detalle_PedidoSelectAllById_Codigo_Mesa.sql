if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_Detalle_PedidoSelectAllById_Codigo_Mesa]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_Detalle_PedidoSelectAllById_Codigo_Mesa]
GO

CREATE PROCEDURE [dbo].[sp_T_Detalle_PedidoSelectAllById_Codigo_Mesa]
(
	@Id_Codigo_Mesa int
)

AS

SET NOCOUNT ON
declare @Id_Pedido int
set @Id_Pedido = (SELECT [Id_Pedido] FROM [T_Pedido] WHERE [Id_Codigo_Mesa] = @Id_Codigo_Mesa and [Estado] = 'ATENDIDO')
exec sp_T_Detalle_PedidoSelectAllById_Pedido @Id_Pedido
GO 
