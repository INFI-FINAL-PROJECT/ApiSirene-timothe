using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSirene.DataAccess.Models
{
    public class UniteLegale
    {
        [BsonElement("DenominationUniteLegale")]
        public string? DenominationUniteLegale { get; set; }
        [BsonElement("ActivitePrincipaleUniteLegale")]
        public string? ActivitePrincipaleUniteLegale { get; set; }
        [BsonElement("SexeUniteLegale")]
        public string? SexeUniteLegale { get; set; }
        [BsonElement("NomUniteLegale")]
        public string? NomUniteLegale { get; set; }
        [BsonElement("Prenom1UniteLegale")]
        public string? Prenom1UniteLegale { get; set ; }
    }
}
