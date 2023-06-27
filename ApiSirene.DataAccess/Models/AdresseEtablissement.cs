using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSirene.DataAccess.Models
{
    public class AdresseEtablissement
    {
        [BsonElement("Id")]
        public int Id { get; set; }
        [BsonElement("NumeroVoieEtablissement")]
        public string? NumeroVoieEtablissement { get; set; }
        [BsonElement("IndiceRepetitionEtablissement")]
        public string? IndiceRepetitionEtablissement { get; set; }
        [BsonElement("TypeVoieEtablissement")]
        public string? TypeVoieEtablissement { get; set; }
        [BsonElement("LibelleVoieEtablissement")]
        public string? LibelleVoieEtablissement { get; set; }
        [BsonElement("CodePostalEtablissement")]
        public string? CodePostalEtablissement { get; set; }
        [BsonElement("LibelleCommuneEtablissement")]
        public string? LibelleCommuneEtablissement { get; set; }
    }
}
