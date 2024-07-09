using System;
using System.Collections.Generic;

namespace Warehouse
{
    public class TWarehouseOperation{
    public int Id { get; set; }
    TProduct Product{ get; set; }
    public DateTime OperationDate{ get; set; }
    public enum EntryType{
        InputOperation,
        OutputOperation,
        ReturnInput
    }

    public int ProductionValue { get; set; }
     public double OperationUnitCost { get; set; }
     public double CalculatedPayment { get; set; }                                                                                                                     

}
}
