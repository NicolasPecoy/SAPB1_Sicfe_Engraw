using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AddOn_Fact_Electronica_Sicfe.Clases;

namespace AddOn_Fact_Electronica_Sicfe
{
    public class clsObjDocumento
    {
        public int DocEntry;
        public int DocNum;
        public int UserSign;
        public int UserSign2;
        public string GLN;
        public string DocType;
        public string ObjType;
        public string Printed;
        public string CardCode;
        public string CardName;
        public string DireccionFactura;
        public string DireccionEntrega;
        public string RutFactura;
        public string Comments;
        public decimal DescuentoDocPorcentaje;

        public string MedioPago;

        public string GastoAdiCodigo;
        public string GastoAdiDesc;
        public decimal GastoAdiMonto;
        public decimal GastoTotalCantLineas;
        public decimal GastoAdiTasa;
        public decimal GastoAdiMontoSujeto;

        public DateTime DocDate;
        public DateTime DocDueDate;
        public DateTime TaxDate;

        /* Campos de usuario*/
        public string U_IdCompra;
        public string U_NumeroAcuerdo; // U_NroAcuerdo // Para Trigueña
        public string U_CanalVenta; // U_CANAL_VENTA // Para G Pocha

        /* Lineas del documento */
        public List<clsObjDocumentoLineas> lineas = new List<clsObjDocumentoLineas>();
    }
}

