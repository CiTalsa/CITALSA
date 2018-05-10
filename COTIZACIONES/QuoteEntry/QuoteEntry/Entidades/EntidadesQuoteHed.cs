using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteEntry.Entidades
{
    public class EntidadesQuoteHed
    {
        public Ice.Core.Session sess            { get; set; }
        public string Company                   { get; set; }
        public string Tipo                      { get; set; }
        public DateTime dftFecha                { get; set; }
        public string ShipToNum                 { get; set; }
        public string CustID                    { get; set; }
        public string TerritoryID               { get; set; }
        public string TaskSetID                 { get; set; }
        public string ConNum                    { get; set; }
        public string ConFunc                   { get; set; }
        public string ConName                   { get; set; }
        public string ConPhoneNum               { get; set; }
        public string SalesRepCode              { get; set; }
        public string MktgCampaignID            { get; set; }
        public string RateGrpCode               { get; set; }
        public string QuoteComment              { get; set; }
        public int CustNum                      { get; set; }
        public int MktgEvntSeq                  { get; set; }
        public string LAB                       { get; set; }
        public string LABEW                     { get; set; }
        public string CreateBy                  { get; set; }
        //CONTROLES
        public bool Totales                     { get; set; }
        //
        public System.Windows.Forms.ListView mlClientes             { get; set; }
        public MetroFramework.Controls.MetroGrid mgProdMisc         { get; set; }
        public MetroFramework.Controls.MetroGrid mgProductos        { get; set; }
        public MetroFramework.Controls.MetroGrid mgTotales          { get; set; }
    }
}
