using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Nest;

namespace OpenFDA.NET
{
    public class Client
    {
        public static string Get()
        {
            var url = "https://api.fda.gov/drug/event.json?search=patient.drug.openfda.pharm_class_epc:\"nonsteroidal+anti-inflammatory+drug\"&count=patient.reaction.reactionmeddrapt.exact";

            var syncClient = new WebClient();

            return syncClient.DownloadString(url);
        }

        public static void GetNEST()
        {
            var node = new Uri("https://api.fda.gov/");
            var settings = new ConnectionSettings(node);
            var client = new ElasticClient(settings);

            //client.Search( new SearchRequest{})
        }
    }
}
