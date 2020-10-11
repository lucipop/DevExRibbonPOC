using System.Collections.Generic;
using System.ComponentModel;

namespace DXRibbon.Seed.Partners
{
    public class ClientSeed : IDataSeed
    {
        public static IList<Client> SeedList()
        {
            IList<Client> clients = new List<Client>
            {
                new Client("IT04870520287", "AC Project Societa' a Responsabilita' Limitata Semplificata - client", "Italia"),
                new Client("RO28551263", "Adri&Vivi S.R.L. - client", "România"),
                new Client("RO14349460", "Agrisorg S.R.L. - client", "România"),
                new Client("RO28551263", "Aigle Consult S.R.L. - client", "România"),
                new Client("RO5326629", "Adri&Vivi S.R.L. - client", "România"),
                new Client("RO28551263", "Almi International S.R.L. - client", "România"),
                new Client("NL005879917B01", "Alpina Van Beers B.V. - client", "Olanda"),
                new Client("RO36329994", "Amiral Euroexpres S.R.L. - client", "România"),
                new Client("RO27213400", "Andrade Textile S.R.L. - client", "România"),
                new Client("IT00301170445", "Annabella S.P.A. - client", "Italia"),
                new Client("RO23646540", "Arox Equipment S.R.L. - client", "România"),
                new Client("RO36369662", "Arrigoni Texagri S.R.L. - client", "România"),
                new Client("RO7366654", "Atp - Exodus S.R.L. - client", "România"),
                new Client("RO22315700", "Atp Motors Ro S.R.L. - client", "România"),
            };

            return clients;
        }
    }

    public class Client
    {
        public string CIF { get; set; }
        [DisplayName("Nume complet")]
        public string Name { get; set; }
        [DisplayName("Țară")]
        public string CountryName { get; set; }
        public Client()
        {

        }
        public Client(string CIF, string Name, string CountryName)
        {
            this.CIF = CIF;
            this.Name = Name;
            this.CountryName = CountryName;
        }
    }
}
