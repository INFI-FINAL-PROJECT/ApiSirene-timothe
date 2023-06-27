using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSirene.DataAccess.Models
{
    [BsonIgnoreExtraElements]
    public class Etablissement
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        [BsonElement("Siren")]
        public string? Siren { get; set; }
        [BsonElement("Siret")]
        public string? Siret { get; set; }
        [BsonElement("DateCreationEtablissement")]
        public string? DateCreationEtablissement { get; set; }
        [BsonElement("UniteLegale")]
        public UniteLegale? UniteLegale { get; set; }
        [BsonElement("Addressetablissement")]
        public AdresseEtablissement? Addressetablissement { get; set; }  
    }
}
