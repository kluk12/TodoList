

CREATE PROC [dbo].[Penalties](@baseDate DATETIME) AS
BEGIN
SELECT inst.order_date
      ,inst.segment
      ,inst.cost
      ,inst.installation_date
	  ,cust.customer_name
      ,cust.segment AS CustomersSegment
	  ,citi.NAME
	 ,CASE inst.segment-- (if installation_date ==null){if(Penalties<0)0 else Penalties}else{Penalties}
		WHEN 'A' THEN Iif( inst.installation_date IS NULL, Iif(((inst.cost *0.05)*(Datediff(day, inst.order_date, @baseDate )-90))<0,0,(inst.cost *0.05)*(Datediff(day, inst.order_date, @baseDate )-90)),(Datediff(day, inst.order_date, inst.installation_date)-90)*(inst.cost *0.05))
		WHEN 'B' THEN Iif( inst.installation_date IS NULL,Iif((inst.cost *0.1)*(Datediff(day, inst.order_date, @baseDate )-60)<0,0,(inst.cost *0.1)*(Datediff(day, inst.order_date, @baseDate )-60)),(Datediff(day, inst.order_date, inst.installation_date)-60)*(inst.cost *0.1))
		WHEN 'C' THEN Iif( inst.installation_date IS NULL,Iif((inst.cost *0.15)*(Datediff(day, inst.order_date, @baseDate )-30)<0,0,(inst.cost *0.15)*(Datediff(day, inst.order_date, @baseDate )-30)),(Datediff(day, inst.order_date, inst.installation_date)-30)*(inst.cost *0.15))
		ELSE 0
		END AS Penalties
	,CASE inst.segment
		WHEN 'A' THEN (inst.cost *0.05)
		WHEN 'B' THEN (inst.cost *0.1)
		WHEN 'C' THEN (inst.cost *0.15)
		ELSE 0
		END AS CostBySegmentPerDay
	,CASE inst.segment
		WHEN 'A' THEN Isnull((Datediff(day, inst.order_date, inst.installation_date)-90), 0)
		WHEN 'B' THEN Isnull((Datediff(day, inst.order_date, inst.installation_date)-60), 0)
		WHEN 'C' THEN Isnull((Datediff(day, inst.order_date, inst.installation_date)-30), 0)
		ELSE 0
		END AS PenalDaysInstallationsDelivered
	,CASE inst.segment
		WHEN 'A' THEN Iif(inst.installation_date IS NOT NULL OR Isnull((Datediff(day, inst.order_date, @baseDate)-90), 0)<0,0,Isnull((Datediff(day, inst.order_date, @baseDate)-90), 0))
		WHEN 'B' THEN Iif(inst.installation_date IS NOT NULL OR Isnull((Datediff(day, inst.order_date, @baseDate)-60), 0)<0,0,Isnull((Datediff(day, inst.order_date, @baseDate)-60), 0))
		WHEN 'C' THEN Iif(inst.installation_date IS NOT NULL OR Isnull((Datediff(day, inst.order_date, @baseDate)-30), 0)<0,0,Isnull((Datediff(day, inst.order_date, @baseDate)-30), 0))
		ELSE 0
		END AS PenalDaysInstallationsNotDelivered
	
FROM installations AS inst
LEFT JOIN customers AS cust ON inst.customer_id=cust.id
LEFT JOIN cities AS citi ON inst.city_id=citi.id
WHERE (inst.segment ='A' AND Datediff(day, inst.order_date, inst.installation_date) >=90)
OR (inst.segment ='B' AND Datediff(day, inst.order_date, inst.installation_date) >=60)
OR (inst.segment ='C' AND Datediff(day, inst.order_date, inst.installation_date) >=30)
OR inst.installation_date IS NULL

END
go
EXEC Penalties '2021-04-01'
go