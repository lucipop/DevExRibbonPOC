using System.Collections.Generic;
using System.ComponentModel;

namespace DXRibbon.Seed.Commands
{
    public class CommandSeed : IDataSeed
    {
        public static IList<Comand> SeedList()
        {
            IList<Comand> commands = new List<Comand>
            {
                new Comand("TD-20-0881", "AC Project Societa' a Responsabilita' Limitata Semplificata - client", "Italia"),
                new Comand("RO28551263", "Adri&Vivi S.R.L. - client", "România"),
                new Comand("RO14349460", "Agrisorg S.R.L. - client", "România"),
                new Comand("RO28551263", "Aigle Consult S.R.L. - client", "România"),
                new Comand("RO5326629", "Adri&Vivi S.R.L. - client", "România"),
                new Comand("RO28551263", "Almi International S.R.L. - client", "România"),
                new Comand("NL005879917B01", "Alpina Van Beers B.V. - client", "Olanda"),
                new Comand("RO36329994", "Amiral Euroexpres S.R.L. - client", "România"),
                new Comand("RO27213400", "Andrade Textile S.R.L. - client", "România"),
                new Comand("IT00301170445", "Annabella S.P.A. - client", "Italia"),
                new Comand("RO23646540", "Arox Equipment S.R.L. - client", "România"),
                new Comand("RO36369662", "Arrigoni Texagri S.R.L. - client", "România"),
                new Comand("RO7366654", "Atp - Exodus S.R.L. - client", "România"),
                new Comand("RO22315700", "Atp Motors Ro S.R.L. - client", "România"),
            };

            return commands;
        }
    }

    public class Comand
    {
        [DisplayName("Nr. comandă")]
        public string CommandNumber { get; set; }
        public string Client { get; set; }
        [DisplayName("Transportator")]
        public string Shipper { get; set; }
        public Comand()
        {

        }
        public Comand(string CommandNumber, string Client, string Shipper)
        {
            this.CommandNumber = CommandNumber;
            this.Client = Client;
            this.Shipper = Shipper;
        }
    }
}
