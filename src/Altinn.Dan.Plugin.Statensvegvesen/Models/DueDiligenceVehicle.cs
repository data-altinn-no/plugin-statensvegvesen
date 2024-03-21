using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altinn.Dan.Plugin.Statensvegvesen.Models
{
    [JsonObject("kjoretoy")]
    public class DueDiligenceVehicle
    {
        [JsonProperty("eier")]
        public bool Ownership {  get; set; }

        [JsonProperty("leaser")]
        public bool Leased { get; set; }

        [JsonProperty("kjennemerke")]
        public string Number { get; set; }

        [JsonProperty("understellsnummer")]
        public string VIN { get; set; }

        [JsonProperty("forstegangsregistrert")]
        public string FirstRegisteredDateTime { get; set; }

        [JsonProperty("kjoretoygruppe")]
        public string VehicleGroup { get; set; }

        [JsonProperty("kjoretoymerke")]
        public string Brand { get; set; }

        [JsonProperty("miljoklasse")]
        public string EnvironmentClassification { get; set; }

        [JsonProperty("noxutslipp")]
        public double? NOx { get; set; }

        [JsonProperty("co2utslipp")]
        public double? CO2 { get; set; }

        [JsonProperty("drivstoff")]
        public string FuelType { get; set; }

        [JsonProperty("girkassetype")]
        public string GearBoxType { get; set; }

        [JsonProperty("sistEugodkjent")]
        public string LastPassedEUControl { get; set; }

        [JsonProperty("kilometerstand")]
        public int? Mileage { get; set; }

        [JsonProperty("kilometerstandSistAvlest")]
        public string MileageRegisteredDateTime { get; set; }
    }
}
