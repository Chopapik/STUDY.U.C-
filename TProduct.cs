using System;
using System.Collections.Generic;

namespace Warehouse
{
    public class TProduct{
    public int Id { get; set;}
    public string Name { get; set;}
    public double EanCode { get; set;}
    public DateTime ProductionDate { get; set;}
    TProducent Producent{ get; set;}
    public double UnitCost{ get; set;}

    public TProduct(int id,string name,double eanCode,DateTime productionDate,double unitCost)
    {
        this.Id = id;
        this.Name = name;
        this.EanCode = eanCode;
        this.ProductionDate = productionDate;
        this.UnitCost = unitCost;
    }
}
}
