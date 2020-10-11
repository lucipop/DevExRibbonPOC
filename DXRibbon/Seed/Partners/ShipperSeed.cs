using System.Collections.Generic;

namespace DXRibbon.Seed.Partners
{
    public class ShipperSeed : IDataSeed
    {
        public static IList<Shipper> SeedList()
        {
            IList<Shipper> clients = new List<Shipper>
            {
                new Shipper("IT04870520287", "AC Project Societa' a Responsabilita' Limitata Semplificata - shipper", "Italia"),
                new Shipper("RO28551263", "Adri&Vivi S.R.L. - shipper", "România"),
                new Shipper("RO14349460", "Agrisorg S.R.L. - shipper", "România"),
                new Shipper("RO28551263", "Aigle Consult S.R.L. - shipper", "România"),
                new Shipper("RO5326629", "Adri&Vivi S.R.L. - shipper", "România"),
                new Shipper("RO28551263", "Almi International S.R.L. - shipper", "România"),
                new Shipper("NL005879917B01", "Alpina Van Beers B.V. - shipper", "Olanda"),
                new Shipper("RO36329994", "Amiral Euroexpres S.R.L. - shipper", "România"),
                new Shipper("RO27213400", "Andrade Textile S.R.L. - shipper", "România"),
                new Shipper("IT00301170445", "Annabella S.P.A. - shipper", "Italia"),
                new Shipper("RO23646540", "Arox Equipment S.R.L. - shipper", "România"),
                new Shipper("RO36369662", "Arrigoni Texagri S.R.L. - shipper", "România"),
                new Shipper("RO7366654", "Atp - Exodus S.R.L. - shipper", "România"),
                new Shipper("RO22315700", "Atp Motors Ro S.R.L. - shipper", "România"),
            };

            return clients;
        }
    }
    public class Shipper
    {
        public string CIF { get; set; }
        public string Name { get; set; }
        public string CountryName { get; set; }
        public Shipper()
        {

        }
        public Shipper(string CIF, string Name, string CountryName)
        {
            this.CIF = CIF;
            this.Name = Name;
            this.CountryName = CountryName;
        }
    }

}
