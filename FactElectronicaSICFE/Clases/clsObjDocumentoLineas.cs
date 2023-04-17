using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddOn_Fact_Electronica_Sicfe.Clases
{
    public class clsObjDocumentoLineas
    {
        /* Campos de INV1 */
        public int ObjType;
        public int DocEntry;
        public int LineNum;
        public int VisOrder;
        public string BaseDocNum; //BaseDocNum
        public int UgpEntry; //UgpEntry
        public string ItemCode; // ItemCode
        public string DescripcionDocumento; // Dscription
        public string UnidadMedida; // unitMsr
        public string FreeTxt; // FreeTxt
        public string MonedaLinea; // Currency
        public string CodigoImpuesto; // TaxCode
        public decimal TipoCambioLinea; // Rate
        public decimal Cantidad; // Quantity
        public decimal CantidadInventario; // InvQty
        public decimal Precio; // Price
        public decimal PrecioAntesDelDescuento; // PriceBefDi
        public decimal TotalLinea; // LineTotal
        public decimal TotalLineaME; // TotalFrgn
        public decimal TotalIVA; // VatSum
        public decimal TotalIVAME; // VatSumFrgn
        public decimal DescuentoPorcentaje; // DiscPrcnt
        
        public string GastoAdiCodigo;
        public string GastoAdiDesc;
        public decimal GastoAdiMonto;

        /* Campos de OITM */
        public string DescripcionMaestroArt; // ItemName
        public string CodigoBarras; // CodeBars
        public string ArticuloInventario; // InvntItem
        public string UserText; // UserText
        public decimal CantidadPorPaqueteVenta; // SalPackUn
        public decimal CantidadCajas; // PackQty
        public string NombreUnidadMedidaVenta; // SalUnitMsr

        /* Campos de OSTC */
        public decimal TasaIVA; // Rate de IVA

        /* Campos de usuario*/
        public string U_CodigoRondanet; // U_RONDANET // Para G Pocha
        public string U_Marca; // U_Marca // Para Portvan y Mildanur
        public string U_Campana; // U_Campana // Para Mildanur 
        public string U_Ubicacion; // U_UBICACION // Para Mildanur 
        public string U_FeDescripcion; // U_FEDescripcion // Para Engraw 
        public DateTime U_Inicio; // U_Inicio // Para Mildanur 
        public DateTime U_Fin; // U_Fin // Para Mildanur 
        public decimal U_KgsAcond; // U_KgsAcond // Para Engraw 
        public string LoteItemCode; // ItemCode // Para Engraw 
        public string LoteBatchNum; // BatchNum // Para Engraw 
        public string U_NroDeclaracion; // U_NroDeclaracion // Para Trigueña
        public string U_NumeroNCM; // U_CodeNCM // Para Trigueña
        public decimal U_KgsBrutos; // U_KGSBRUTOS // Para Trigueña
        public decimal Volumen; // SVolume // Para Trigueña
        public decimal Peso; // SWeight1 // Para Trigueña 
        public string U_ItemFactura; // Para Trialand
    }
}
