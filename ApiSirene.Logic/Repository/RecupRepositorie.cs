using ApiSirene.DataAccess.Models;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiSirene.Logic.Repository
{
    public class RecupRepositorie:IrecupRepositorie
    {
        private readonly IMongoDatabase _databases;
        public RecupRepositorie(IMongoDatabase mongoDatabase) 
        { 
            _databases = mongoDatabase;
        }

        public async Task<List<Etablissement>> FetchAll(CancellationToken cancellationToken)
        {
            using (var httpClient = new HttpClient())
            {
                string apiUrl = "https://api.insee.fr/catalogue/site/themes/wso2/subthemes/insee/pages/item-info.jag?name=Sirene&version=V3&provider=insee";

                HttpResponseMessage response = await httpClient.GetAsync(apiUrl, cancellationToken);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var establishments = new List<Etablissement>();
                    return establishments;
                }
                else
                {
                    throw new Exception($"Recuperation echouée. code Status: {response.StatusCode}");
                }
            }
        }

    }
}
