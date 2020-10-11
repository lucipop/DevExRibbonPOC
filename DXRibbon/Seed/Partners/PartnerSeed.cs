using System.Collections.Generic;
using System.ComponentModel;

namespace DXRibbon.Seed.Partners
{
    public class PartnerSeed : IDataSeed
    {
        public static IList<Partner> SeedList()
        {
            IList<Partner> clients = new List<Partner>
            {
                new Partner("IT04870520287", "AC Project Societa' a Responsabilita' Limitata Semplificata - partner", "Italia"),
                new Partner("RO28551263", "Adri&Vivi S.R.L. - partner", "România"),
                new Partner("RO14349460", "Agrisorg S.R.L. - partner", "România"),
                new Partner("RO28551263", "Aigle Consult S.R.L. - partner", "România"),
                new Partner("RO5326629", "Adri&Vivi S.R.L. - partner", "România"),
                new Partner("RO28551263", "Almi International S.R.L. - partner", "România"),
                new Partner("NL005879917B01", "Alpina Van Beers B.V. - partner", "Olanda"),
                new Partner("RO36329994", "Amiral Euroexpres S.R.L. - partner", "România"),
                new Partner("RO27213400", "Andrade Textile S.R.L. - partner", "România"),
                new Partner("IT00301170445", "Annabella S.P.A. - partner", "Italia"),
                new Partner("RO23646540", "Arox Equipment S.R.L. - partner", "România"),
                new Partner("RO36369662", "Arrigoni Texagri S.R.L. - partner", "România"),
                new Partner("RO7366654", "Atp - Exodus S.R.L. - partner", "România"),
                new Partner("RO22315700", "Atp Motors Ro S.R.L. - partner", "România"),
            };

            return clients;
        }
    }
    public class Partner
    {
        public string CIF { get; set; }
        [DisplayName("Nume complet")]
        public string Name { get; set; }
        [DisplayName("Țară")]
        public string CountryName { get; set; }
        public Partner()
        {

        }
        public Partner(string CIF, string Name, string CountryName)
        {
            this.CIF = CIF;
            this.Name = Name;
            this.CountryName = CountryName;
        }
    }
}
