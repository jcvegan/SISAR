if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sp_T_Detalle_PedidoSelectAllById_ZonaAndNumero_Mesa]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [dbo].[sp_T_Detalle_PedidoSelectAllById_ZonaAndNumero_Mesa]
GO

CREATE PROCEDURE [dbo].[sp_T_Detalle_PedidoSelectAllById_ZonaAndNumero_Mesa]
(
	@Id_Zona int,
	@Numero_Mesa int
)

AS

SET NOCOUNT ON
declare @Id_Codigo_Mesa int
declare @Id_Distribucion int
set @Id_Distribucion = (SELECT [Id_Distribucion] FROM [T_Distribucion] WHERE[Id_Zona] =  @Id_Zona and [Estado] = 'true')
set @Id_Codigo_Mesa =(SELECT [Id_Codigo_Mesa] FROM [T_DistribucionxMesa] WHERE [Id_Distribucion] = @Id_Distribucion and [Numero_Mesa] = @Numero_Mesa)
 exec sp_T_Detalle_PedidoSelectAllById_Codigo_Mesa @Id_Codigo_Mesa
GO
