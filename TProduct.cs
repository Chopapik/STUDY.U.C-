using System;
using System.Collections.Generic;

namespace Warehouse
{
    public class TProduct{
    public int Id { get; set;}
    public string Name { get; set;}
    public int EanCode { get; set;}
    public DateTime ProductionDate { get; set;}
    TProducent Producent{ get; set;}
    double UnitConst{ get; set;}

    public TProduct(int id,string name,int eanCode){
        this.Id = id;
        this.Name = name;
        this.EanCode = eanCode;
        // this.ProductionDate = productionDate;
        // this.UnitConst = unitConst;
    }
}
}
