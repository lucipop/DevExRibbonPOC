using DXRibbon.Seed.Partners;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXRibbon.Seed.Documents
{
    public class InvoiceSeed : IDataSeed
    {
        public static string Emitted = "Emisă";
        public static string Invoiced = "Încasată";
        public static string Sent = "Expediată";
        public static string Overdue = "Depășită";
        public static string Cancelled = "Anulată";

        public static IList<Invoice> SeedList()
        {
            IList<Invoice> clients = new List<Invoice>
            {
                new Invoice("AG-20-0449", 1215, "ARG", "Quattro Intersped S.R.L.", "Emisă"),
                new Invoice("AG-20-2552", 1214, "ARG", "Class Shoe S.R.L.", "Încasată"),
                new Invoice("AG-20-7647", 1216, "ARG", "Reropam S.R.L.", "Emisă"),
                new Invoice("AG-20-3245", 1217, "ARG", "Reropam S.R.L.", "Expediată"),
                new Invoice("AG-20-4774", 1218, "ARG", "Poelman B.V.", "Emisă"),
                new Invoice("AG-20-2323", 1219, "ARG", "Microrom S.R.L.", "Anulată"),
                new Invoice("AG-20-1202", 1220, "ARG", "Azaria Food S.R.L.", "Emisă"),
                new Invoice("AG-20-2212", 1221, "ARG", "Criano S.R.L.", "Depășită"),
                new Invoice("AG-20-4335", 1222, "ARG", "Atp S.R.L.", "Emisă"),
                new Invoice("AG-20-6844", 1223, "ARG", "Frigoglass Romania S.R.L.", "Emisă"),
                new Invoice("AG-20-3425", 1224, "ARG", "Ifaba Calapoade S.R.L.", "Emisă"),
                new Invoice("AG-20-5831", 1225, "ARG", "L & F Shoes S.R.L.", "Emisă"),
                new Invoice("AG-20-1699", 1226, "ARG", "Alpina Van Beers B.V.", "Emisă"),
                new Invoice("AG-20-2345", 1227, "ARG", "Rao Import Export S.R.L.", "Emisă")
            };

            return clients;
        }
    }

    public class Invoice
    {
        [DisplayName("Nr. comandă")]
        public string ContractNumber { get; set; }
        [DisplayName("Nr. factură")]
        public int InvoiceNumber { get; set; }
        [DisplayName("Serie factură")]
        public string InvoiceSeries { get; set; }
        [DisplayName("Client")]
        public string ClientName { get; set; }
        [DisplayName("Data facturării")]
        public string InvoiceStatus { get; set; }
        //[Display(AutoGenerateField = false)]
        //public int InvoiceStatus { get; set; }
    
        public Invoice(
            string ContractNumber, 
            int InvoiceNumber, 
            string InvoiceSeries, 
            string ClientName, 
            string InvoiceStatus)
        {
            this.ContractNumber = ContractNumber;
            this.InvoiceNumber = InvoiceNumber;
            this.InvoiceSeries = InvoiceSeries;
            this.ClientName = ClientName;
            this.InvoiceStatus = InvoiceStatus;
        }

    }

}
