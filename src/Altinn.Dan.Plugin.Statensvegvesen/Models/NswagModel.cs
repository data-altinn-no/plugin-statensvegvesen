using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altinn.Dan.Plugin.Statensvegvesen.Models
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UnderstellsnummerRequest
    {
        /// <summary>
        /// Kjøretøyets understellsnummer
        /// </summary>
        [Newtonsoft.Json.JsonProperty("understellsnummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Understellsnummer { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdrGodkjenning
    {
        [Newtonsoft.Json.JsonProperty("adrAnmerkninger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrAnmerkninger { get; set; }

        [Newtonsoft.Json.JsonProperty("adrAttestnummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrAttestnummer { get; set; }

        [Newtonsoft.Json.JsonProperty("adrBeskyttelseOverLastbarerKode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType AdrBeskyttelseOverLastbarerKode { get; set; }

        [Newtonsoft.Json.JsonProperty("adrEX2EX3GodkjentGods", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrEX2EX3GodkjentGods { get; set; }

        [Newtonsoft.Json.JsonProperty("adrKjoretoyLukket", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AdrKjoretoyLukket { get; set; }

        [Newtonsoft.Json.JsonProperty("adrNasjonaleKrav", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AdrNasjonaleKrav { get; set; }

        [Newtonsoft.Json.JsonProperty("adrPabyggTypeKode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType AdrPabyggTypeKode { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankTekniskeData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AdrTankTekniskeData AdrTankTekniskeData { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTidligereBestemmelser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AdrTidligereBestemmelser { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTilleggsbremsEffekt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrTilleggsbremsEffekt { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTilleggsbremsIkkeAktuelt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AdrTilleggsbremsIkkeAktuelt { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTransportorAdresse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrTransportorAdresse { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTransportorNavn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrTransportorNavn { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTransportorPostnrSted", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrTransportorPostnrSted { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTypeKode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> AdrTypeKode { get; set; }

        [Newtonsoft.Json.JsonProperty("adrVekselbyggID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrVekselbyggID { get; set; }

        [Newtonsoft.Json.JsonProperty("adrVekselbyggIDFra", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrVekselbyggIDFra { get; set; }

        [Newtonsoft.Json.JsonProperty("adrVekselbyggIDTil", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrVekselbyggIDTil { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdrTankGodkjentGods
    {
        [Newtonsoft.Json.JsonProperty("adrTankGodkjentFor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrTankGodkjentFor { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankStofferIhhtTankkode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AdrTankStofferIhhtTankkode { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdrTankInndelingVolum
    {
        [Newtonsoft.Json.JsonProperty("adrTankInndelingVolum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<int> AdrTankInndelingVolum1 { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdrTankTekniskeData
    {
        [Newtonsoft.Json.JsonProperty("adrTankAntallRom", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AdrTankAntallRom { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankFabrikat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrTankFabrikat { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankGodkjenningsnummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrTankGodkjenningsnummer { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankGodkjentGods", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<AdrTankGodkjentGods> AdrTankGodkjentGods { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankInndeling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AdrTankInndelingVolum AdrTankInndeling { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankKode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrTankKode { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankKofferdam", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AdrTankKofferdam { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankLos", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AdrTankLos { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankNesteTetthetsproveDato", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? AdrTankNesteTetthetsproveDato { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankNesteTrykkproveDato", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? AdrTankNesteTrykkproveDato { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankOverflyttetFra", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrTankOverflyttetFra { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankProduksjonsAr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AdrTankProduksjonsAr { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankSerienummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrTankSerienummer { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankSpesielleBestemmelser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdrTankSpesielleBestemmelser { get; set; }

        [Newtonsoft.Json.JsonProperty("adrTankVolum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AdrTankVolum { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Adresse
    {
        [Newtonsoft.Json.JsonProperty("adresselinje1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Adresselinje1 { get; set; }

        [Newtonsoft.Json.JsonProperty("adresselinje2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Adresselinje2 { get; set; }

        [Newtonsoft.Json.JsonProperty("adresselinje3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Adresselinje3 { get; set; }

        [Newtonsoft.Json.JsonProperty("kommunenavn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Kommunenavn { get; set; }

        [Newtonsoft.Json.JsonProperty("kommunenummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Kommunenummer { get; set; }

        [Newtonsoft.Json.JsonProperty("land", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Land { get; set; }

        [Newtonsoft.Json.JsonProperty("landkode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Landkode { get; set; }

        [Newtonsoft.Json.JsonProperty("postnummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Postnummer { get; set; }

        [Newtonsoft.Json.JsonProperty("poststed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Poststed { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Aksel
    {
        [Newtonsoft.Json.JsonProperty("antallHjul", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AntallHjul { get; set; }

        [Newtonsoft.Json.JsonProperty("avstandTilNesteAksling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AvstandTilNesteAksling { get; set; }

        [Newtonsoft.Json.JsonProperty("belastbar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Belastbar { get; set; }

        [Newtonsoft.Json.JsonProperty("bremseAksel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? BremseAksel { get; set; }

        [Newtonsoft.Json.JsonProperty("drivAksel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DrivAksel { get; set; }

        [Newtonsoft.Json.JsonProperty("egenvektAksel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? EgenvektAksel { get; set; }

        [Newtonsoft.Json.JsonProperty("egenvektAkselMaks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? EgenvektAkselMaks { get; set; }

        [Newtonsoft.Json.JsonProperty("egenvektAkselMin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? EgenvektAkselMin { get; set; }

        [Newtonsoft.Json.JsonProperty("fordelingAvTillattTotalvektAkselMaks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? FordelingAvTillattTotalvektAkselMaks { get; set; }

        [Newtonsoft.Json.JsonProperty("fordelingAvTillattTotalvektAkselMin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? FordelingAvTillattTotalvektAkselMin { get; set; }

        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [Newtonsoft.Json.JsonProperty("loftbar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Loftbar { get; set; }

        [Newtonsoft.Json.JsonProperty("luftfjaering", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Luftfjaering { get; set; }

        [Newtonsoft.Json.JsonProperty("maksAvstandTilNesteAksling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaksAvstandTilNesteAksling { get; set; }

        [Newtonsoft.Json.JsonProperty("maksimalSporvidde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaksimalSporvidde { get; set; }

        [Newtonsoft.Json.JsonProperty("minAvstandTilNesteAksling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MinAvstandTilNesteAksling { get; set; }

        [Newtonsoft.Json.JsonProperty("minimalSporvidde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MinimalSporvidde { get; set; }

        [Newtonsoft.Json.JsonProperty("plasseringAksel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlasseringAksel { get; set; }

        [Newtonsoft.Json.JsonProperty("sporvidde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Sporvidde { get; set; }

        [Newtonsoft.Json.JsonProperty("styreAksel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? StyreAksel { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskTillattAkselLast", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TekniskTillattAkselLast { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskTillattAkselLastForhoyet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TekniskTillattAkselLastForhoyet { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskTillattAkselLastVeg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TekniskTillattAkselLastVeg { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AkselDekkOgFelg
    {
        [Newtonsoft.Json.JsonProperty("akselId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? AkselId { get; set; }

        [Newtonsoft.Json.JsonProperty("belastningskodeDekk", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BelastningskodeDekk { get; set; }

        [Newtonsoft.Json.JsonProperty("belastningskodeDekkTraktor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BelastningskodeDekkTraktor { get; set; }

        [Newtonsoft.Json.JsonProperty("dekkdimensjon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Dekkdimensjon { get; set; }

        [Newtonsoft.Json.JsonProperty("felgdimensjon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Felgdimensjon { get; set; }

        [Newtonsoft.Json.JsonProperty("hastighetskodeDekk", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HastighetskodeDekk { get; set; }

        [Newtonsoft.Json.JsonProperty("innpress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Innpress { get; set; }

        [Newtonsoft.Json.JsonProperty("tillattAkselLastTraktor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TillattAkselLastTraktor { get; set; }

        [Newtonsoft.Json.JsonProperty("tvilling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Tvilling { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AkselDekkOgFelgKombinasjon
    {
        [Newtonsoft.Json.JsonProperty("akselDekkOgFelg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<AkselDekkOgFelg> AkselDekkOgFelg { get; set; }

        [Newtonsoft.Json.JsonProperty("tillattTotalvektTraktor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TillattTotalvektTraktor { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AkselGruppe
    {
        [Newtonsoft.Json.JsonProperty("akselListe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AkselListe AkselListe { get; set; }

        [Newtonsoft.Json.JsonProperty("egenvektAkselGruppe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? EgenvektAkselGruppe { get; set; }

        [Newtonsoft.Json.JsonProperty("egenvektAkselGruppeMaks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? EgenvektAkselGruppeMaks { get; set; }

        [Newtonsoft.Json.JsonProperty("egenvektAkselGruppeMin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? EgenvektAkselGruppeMin { get; set; }

        [Newtonsoft.Json.JsonProperty("fordelingAvTillattTotalvektAkselGruppeMaks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? FordelingAvTillattTotalvektAkselGruppeMaks { get; set; }

        [Newtonsoft.Json.JsonProperty("fordelingAvTillattTotalvektAkselGruppeMin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? FordelingAvTillattTotalvektAkselGruppeMin { get; set; }

        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [Newtonsoft.Json.JsonProperty("plasseringAkselGruppe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlasseringAkselGruppe { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskTillattAkselGruppeLast", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TekniskTillattAkselGruppeLast { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskTillattAkselGruppeLastVeg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TekniskTillattAkselGruppeLastVeg { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AkselInfo
    {
        [Newtonsoft.Json.JsonProperty("akselGruppe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<AkselGruppe> AkselGruppe { get; set; }

        [Newtonsoft.Json.JsonProperty("antallAksler", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AntallAksler { get; set; }

        [Newtonsoft.Json.JsonProperty("forbindelseMellomDrivaksler", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType ForbindelseMellomDrivaksler { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AkselListe
    {
        [Newtonsoft.Json.JsonProperty("aksel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Aksel> Aksel { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Bremse
    {
        [Newtonsoft.Json.JsonProperty("abs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Abs { get; set; }

        [Newtonsoft.Json.JsonProperty("bremsesystem", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bremsesystem { get; set; }

        [Newtonsoft.Json.JsonProperty("driftsbremsBak", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DriftsbremsBak { get; set; }

        [Newtonsoft.Json.JsonProperty("driftsbremsForan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DriftsbremsForan { get; set; }

        [Newtonsoft.Json.JsonProperty("tilhengerBremseforbindelse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> TilhengerBremseforbindelse { get; set; }

        [Newtonsoft.Json.JsonProperty("trykkMeterledningTilhengerkopling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? TrykkMeterledningTilhengerkopling { get; set; }

        [Newtonsoft.Json.JsonProperty("trykktilsluttning1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Trykktilsluttning1 { get; set; }

        [Newtonsoft.Json.JsonProperty("trykktilsluttning2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Trykktilsluttning2 { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BruktImportInfo
    {
        [Newtonsoft.Json.JsonProperty("importland", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Importland Importland { get; set; }

        [Newtonsoft.Json.JsonProperty("kilometerstand", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Kilometerstand { get; set; }

        [Newtonsoft.Json.JsonProperty("tidligereUtenlandskKjennemerke", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TidligereUtenlandskKjennemerke { get; set; }

        [Newtonsoft.Json.JsonProperty("tidligereUtenlandskVognkortNummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TidligereUtenlandskVognkortNummer { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DekkOgFelg
    {
        [Newtonsoft.Json.JsonProperty("akselDekkOgFelgKombinasjon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<AkselDekkOgFelgKombinasjon> AkselDekkOgFelgKombinasjon { get; set; }

        [Newtonsoft.Json.JsonProperty("dekkOgFelgSidevogn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DekkOgFelgSidevogn DekkOgFelgSidevogn { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DekkOgFelgSidevogn
    {
        [Newtonsoft.Json.JsonProperty("belastningskodeDekkSidevogn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BelastningskodeDekkSidevogn { get; set; }

        [Newtonsoft.Json.JsonProperty("dekkdimensjonSidevogn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DekkdimensjonSidevogn { get; set; }

        [Newtonsoft.Json.JsonProperty("felgdimensjonSidevogn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FelgdimensjonSidevogn { get; set; }

        [Newtonsoft.Json.JsonProperty("hastighetskodeDekkSidevogn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HastighetskodeDekkSidevogn { get; set; }

        [Newtonsoft.Json.JsonProperty("innpressSidevogn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InnpressSidevogn { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Dimensjoner
    {
        [Newtonsoft.Json.JsonProperty("bredde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Bredde { get; set; }

        [Newtonsoft.Json.JsonProperty("hoyde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Hoyde { get; set; }

        [Newtonsoft.Json.JsonProperty("lengde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Lengde { get; set; }

        [Newtonsoft.Json.JsonProperty("lengdeInnvendigLasteplan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LengdeInnvendigLasteplan { get; set; }

        [Newtonsoft.Json.JsonProperty("maksimalBredde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaksimalBredde { get; set; }

        [Newtonsoft.Json.JsonProperty("maksimalHoyde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaksimalHoyde { get; set; }

        [Newtonsoft.Json.JsonProperty("maksimalLengde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaksimalLengde { get; set; }

        [Newtonsoft.Json.JsonProperty("maksimalLengdeInnvendigLasteplan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaksimalLengdeInnvendigLasteplan { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Drivstoff
    {
        [Newtonsoft.Json.JsonProperty("drivstoffKode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType DrivstoffKode { get; set; }

        [Newtonsoft.Json.JsonProperty("effektVektForhold", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? EffektVektForhold { get; set; }

        [Newtonsoft.Json.JsonProperty("maksEffektPrTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? MaksEffektPrTime { get; set; }

        [Newtonsoft.Json.JsonProperty("maksNettoEffekt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? MaksNettoEffekt { get; set; }

        [Newtonsoft.Json.JsonProperty("maksNettoEffektVedOmdreiningstallMin1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaksNettoEffektVedOmdreiningstallMin1 { get; set; }

        [Newtonsoft.Json.JsonProperty("maksNettoEffektVedOmdreiningstallMin1Maks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaksNettoEffektVedOmdreiningstallMin1Maks { get; set; }

        [Newtonsoft.Json.JsonProperty("maksOmdreining", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaksOmdreining { get; set; }

        [Newtonsoft.Json.JsonProperty("spenning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Spenning { get; set; }

        [Newtonsoft.Json.JsonProperty("tomgangsOmdreiningstall", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TomgangsOmdreiningstall { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DyretransportGodkjenning
    {
        [Newtonsoft.Json.JsonProperty("fornyelse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Fornyelse { get; set; }

        [Newtonsoft.Json.JsonProperty("gulvareal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Gulvareal { get; set; }

        [Newtonsoft.Json.JsonProperty("hestetransporttype", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Hestetransporttype { get; set; }

        [Newtonsoft.Json.JsonProperty("takhoyde", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Takhoyde { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EFTypegodkjenningsId
    {
        [Newtonsoft.Json.JsonProperty("typegodkjenningNrTekst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypegodkjenningNrTekst { get; set; }

        [Newtonsoft.Json.JsonProperty("typegodkjenningnummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Typegodkjenningsnummer Typegodkjenningnummer { get; set; }

        [Newtonsoft.Json.JsonProperty("variant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Variant { get; set; }

        [Newtonsoft.Json.JsonProperty("versjon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Versjon { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EierskapBegrenset
    {
        [Newtonsoft.Json.JsonProperty("eier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PersonEnhetBegrenset Eier { get; set; }

        [Newtonsoft.Json.JsonProperty("leasingtaker", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PersonEnhetBegrenset Leasingtaker { get; set; }

        [Newtonsoft.Json.JsonProperty("medeier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PersonEnhetBegrenset Medeier { get; set; }

        [Newtonsoft.Json.JsonProperty("underenhet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PersonEnhetBegrenset Underenhet { get; set; }

        [Newtonsoft.Json.JsonProperty("vedtakstidspunkt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Vedtakstidspunkt { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Enhet
    {
        [Newtonsoft.Json.JsonProperty("organisasjonsnavn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Organisasjonsnavn { get; set; }

        [Newtonsoft.Json.JsonProperty("organisasjonsnummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Organisasjonsnummer { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Fabrikant
    {
        [Newtonsoft.Json.JsonProperty("fabrikantAdresse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FabrikantAdresse { get; set; }

        [Newtonsoft.Json.JsonProperty("fabrikantNavn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FabrikantNavn { get; set; }

        [Newtonsoft.Json.JsonProperty("fabrikantRepresentantAdresse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FabrikantRepresentantAdresse { get; set; }

        [Newtonsoft.Json.JsonProperty("fabrikantRepresentantNavn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FabrikantRepresentantNavn { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ForbrukOgUtslipp
    {
        [Newtonsoft.Json.JsonProperty("antallPartikler", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? AntallPartikler { get; set; }

        [Newtonsoft.Json.JsonProperty("co2BlandetKjoring", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Co2BlandetKjoring { get; set; }

        [Newtonsoft.Json.JsonProperty("co2Bykjoring", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Co2Bykjoring { get; set; }

        [Newtonsoft.Json.JsonProperty("co2Landeveiskjoring", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Co2Landeveiskjoring { get; set; }

        [Newtonsoft.Json.JsonProperty("coProsent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? CoProsent { get; set; }

        [Newtonsoft.Json.JsonProperty("elEnergiforbruk", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ElEnergiforbruk { get; set; }

        [Newtonsoft.Json.JsonProperty("forbrukBlandetKjoring", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ForbrukBlandetKjoring { get; set; }

        [Newtonsoft.Json.JsonProperty("forbrukBykjoring", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ForbrukBykjoring { get; set; }

        [Newtonsoft.Json.JsonProperty("forbrukLandeveiskjoring", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ForbrukLandeveiskjoring { get; set; }

        [Newtonsoft.Json.JsonProperty("malemetode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Malemetode { get; set; }

        [Newtonsoft.Json.JsonProperty("malemetodeAnnen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MalemetodeAnnen { get; set; }

        [Newtonsoft.Json.JsonProperty("partikkelfilterFabrikkmontert", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? PartikkelfilterFabrikkmontert { get; set; }

        [Newtonsoft.Json.JsonProperty("partikkelfilterUtslipp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? PartikkelfilterUtslipp { get; set; }

        [Newtonsoft.Json.JsonProperty("rekkeviddeKm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RekkeviddeKm { get; set; }

        [Newtonsoft.Json.JsonProperty("utslippCOgPrKWh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? UtslippCOgPrKWh { get; set; }

        [Newtonsoft.Json.JsonProperty("utslippCOmgPrKm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? UtslippCOmgPrKm { get; set; }

        [Newtonsoft.Json.JsonProperty("utslippHCgPrKWh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? UtslippHCgPrKWh { get; set; }

        [Newtonsoft.Json.JsonProperty("utslippHCgPrMin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? UtslippHCgPrMin { get; set; }

        [Newtonsoft.Json.JsonProperty("utslippHCmgPrKm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? UtslippHCmgPrKm { get; set; }

        [Newtonsoft.Json.JsonProperty("utslippHCogNOxMgPrKm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? UtslippHCogNOxMgPrKm { get; set; }

        [Newtonsoft.Json.JsonProperty("utslippKorrigertAbsorpsjonskoeffisient", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? UtslippKorrigertAbsorpsjonskoeffisient { get; set; }

        [Newtonsoft.Json.JsonProperty("utslippNMHCmgPrKm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? UtslippNMHCmgPrKm { get; set; }

        [Newtonsoft.Json.JsonProperty("utslippNOxGPrKWh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? UtslippNOxGPrKWh { get; set; }

        [Newtonsoft.Json.JsonProperty("utslippNOxMgPrKm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? UtslippNOxMgPrKm { get; set; }

        [Newtonsoft.Json.JsonProperty("utslippPartikkelAntallPrKm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? UtslippPartikkelAntallPrKm { get; set; }

        [Newtonsoft.Json.JsonProperty("utslippPartiklerGPrKWh", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? UtslippPartiklerGPrKWh { get; set; }

        [Newtonsoft.Json.JsonProperty("utslippPartiklerMgPrKm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? UtslippPartiklerMgPrKm { get; set; }

        [Newtonsoft.Json.JsonProperty("utslippTHCmgPrKm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? UtslippTHCmgPrKm { get; set; }

        [Newtonsoft.Json.JsonProperty("utslippTHCogNOxMgPrKm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? UtslippTHCogNOxMgPrKm { get; set; }

        [Newtonsoft.Json.JsonProperty("vektetKombinertDrivstoff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? VektetKombinertDrivstoff { get; set; }

        [Newtonsoft.Json.JsonProperty("vektetKombinertDrivstoffCO2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? VektetKombinertDrivstoffCO2 { get; set; }

        [Newtonsoft.Json.JsonProperty("wltpKjoretoyspesifikk", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public WLTP WltpKjoretoyspesifikk { get; set; }

        [Newtonsoft.Json.JsonProperty("wltpTypegodkjenningMaks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public WLTP WltpTypegodkjenningMaks { get; set; }

        [Newtonsoft.Json.JsonProperty("wltpTypegodkjenningMedium", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public WLTP WltpTypegodkjenningMedium { get; set; }

        [Newtonsoft.Json.JsonProperty("wltpTypegodkjenningMin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public WLTP WltpTypegodkjenningMin { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ForstegangsTekniskGodkjenning
    {
        [Newtonsoft.Json.JsonProperty("bruktimport", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BruktImportInfo Bruktimport { get; set; }

        [Newtonsoft.Json.JsonProperty("forstegangRegistrertDato", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? ForstegangRegistrertDato { get; set; }

        [Newtonsoft.Json.JsonProperty("fortollingOgMva", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FortollingOgMva FortollingOgMva { get; set; }

        [Newtonsoft.Json.JsonProperty("godkjenningsId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GodkjenningsId { get; set; }

        [Newtonsoft.Json.JsonProperty("godkjenningsundertype", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Godkjenningsundertype { get; set; }

        [Newtonsoft.Json.JsonProperty("gyldigFraDato", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? GyldigFraDato { get; set; }

        [Newtonsoft.Json.JsonProperty("gyldigFraDatoTid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? GyldigFraDatoTid { get; set; }

        [Newtonsoft.Json.JsonProperty("kvalitetskodeForstegangRegDato", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType KvalitetskodeForstegangRegDato { get; set; }

        [Newtonsoft.Json.JsonProperty("oppbygdMedAvgiftsfritak", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OppbygdMedAvgiftsfritak OppbygdMedAvgiftsfritak { get; set; }

        [Newtonsoft.Json.JsonProperty("unntak", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Unntak> Unntak { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Forstegangsregistrering
    {
        [Newtonsoft.Json.JsonProperty("registrertForstegangNorgeDato", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? RegistrertForstegangNorgeDato { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FortollingOgMva
    {
        [Newtonsoft.Json.JsonProperty("annenReferanse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AnnenReferanse { get; set; }

        [Newtonsoft.Json.JsonProperty("beskrivelse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Beskrivelse { get; set; }

        [Newtonsoft.Json.JsonProperty("dokumentreferanse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Dokumentreferanse { get; set; }

        [Newtonsoft.Json.JsonProperty("fortollingsreferanse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fortollingsreferanse { get; set; }

        [Newtonsoft.Json.JsonProperty("linje", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Linje { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Generelt
    {
        [Newtonsoft.Json.JsonProperty("fabrikant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Fabrikant> Fabrikant { get; set; }

        [Newtonsoft.Json.JsonProperty("ferdigbyggetEllerEndretSomFolger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FerdigbyggetEllerEndretSomFolger { get; set; }

        [Newtonsoft.Json.JsonProperty("handelsbetegnelse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Handelsbetegnelse { get; set; }

        [Newtonsoft.Json.JsonProperty("merke", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Merke> Merke { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskKode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType TekniskKode { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskUnderkode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType TekniskUnderkode { get; set; }

        [Newtonsoft.Json.JsonProperty("typebetegnelse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Typebetegnelse { get; set; }

        [Newtonsoft.Json.JsonProperty("unntakFra", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnntakFra { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Girutveksling
    {
        [Newtonsoft.Json.JsonProperty("girNummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GirNummer { get; set; }

        [Newtonsoft.Json.JsonProperty("girutveksling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Girutveksling1 { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Godkjenning
    {
        [Newtonsoft.Json.JsonProperty("forstegangsGodkjenning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ForstegangsTekniskGodkjenning ForstegangsGodkjenning { get; set; }

        [Newtonsoft.Json.JsonProperty("kjoretoymerknad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Kjoretoymerknad> Kjoretoymerknad { get; set; }

        [Newtonsoft.Json.JsonProperty("registreringsbegrensninger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Registreringsbegrensninger Registreringsbegrensninger { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskGodkjenning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TekniskGodkjenning TekniskGodkjenning { get; set; }

        [Newtonsoft.Json.JsonProperty("tilleggsgodkjenninger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Tilleggsgodkjenning> Tilleggsgodkjenninger { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Importland
    {
        [Newtonsoft.Json.JsonProperty("landNavn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LandNavn { get; set; }

        [Newtonsoft.Json.JsonProperty("landkode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Landkode { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KarosseriOgLasteplan
    {
        [Newtonsoft.Json.JsonProperty("antallDorer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<int> AntallDorer { get; set; }

        [Newtonsoft.Json.JsonProperty("avstandNavSkjermbueBak", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AvstandNavSkjermbueBak { get; set; }

        [Newtonsoft.Json.JsonProperty("avstandNavSkjermbueForan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AvstandNavSkjermbueForan { get; set; }

        [Newtonsoft.Json.JsonProperty("bussKategori", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BussKategori { get; set; }

        [Newtonsoft.Json.JsonProperty("dorUtforming", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> DorUtforming { get; set; }

        [Newtonsoft.Json.JsonProperty("fargeFjar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FargeFjar { get; set; }

        [Newtonsoft.Json.JsonProperty("forankringSikkerhetsseler", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ForankringSikkerhetsseler { get; set; }

        [Newtonsoft.Json.JsonProperty("forervern", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Forervern { get; set; }

        [Newtonsoft.Json.JsonProperty("forervernBoyle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ForervernBoyle { get; set; }

        [Newtonsoft.Json.JsonProperty("godkjentADR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GodkjentADR { get; set; }

        [Newtonsoft.Json.JsonProperty("hydrauliskLoft", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? HydrauliskLoft { get; set; }

        [Newtonsoft.Json.JsonProperty("karosseriArt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KarosseriArt { get; set; }

        [Newtonsoft.Json.JsonProperty("karosseritype", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Karosseritype { get; set; }

        [Newtonsoft.Json.JsonProperty("kjennemerketypeBak", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType KjennemerketypeBak { get; set; }

        [Newtonsoft.Json.JsonProperty("kjennemerkestorrelseBak", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType KjennemerkestorrelseBak { get; set; }

        [Newtonsoft.Json.JsonProperty("kjennemerketypeForan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType KjennemerketypeForan { get; set; }

        [Newtonsoft.Json.JsonProperty("kjennemerkestorrelseForan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType KjennemerkestorrelseForan { get; set; }

        [Newtonsoft.Json.JsonProperty("kjennemerketypeVenstre", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType KjennemerketypeVenstre { get; set; }

        [Newtonsoft.Json.JsonProperty("kjennemerkestorrelseVenstre", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType KjennemerkestorrelseVenstre { get; set; }

        [Newtonsoft.Json.JsonProperty("kjoringSide", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KjoringSide { get; set; }

        [Newtonsoft.Json.JsonProperty("oppbygningUnderstellsnummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OppbygningUnderstellsnummer { get; set; }

        [Newtonsoft.Json.JsonProperty("overhengBak", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? OverhengBak { get; set; }

        [Newtonsoft.Json.JsonProperty("pabyggsKode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType PabyggsKode { get; set; }

        [Newtonsoft.Json.JsonProperty("passasjerHandtak", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PassasjerHandtak { get; set; }

        [Newtonsoft.Json.JsonProperty("plasseringAvDorer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType PlasseringAvDorer { get; set; }

        [Newtonsoft.Json.JsonProperty("plasseringFabrikasjonsplate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<KodeverkType> PlasseringFabrikasjonsplate { get; set; }

        [Newtonsoft.Json.JsonProperty("plasseringMerkeplateTrimming", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlasseringMerkeplateTrimming { get; set; }

        [Newtonsoft.Json.JsonProperty("plasseringUnderstellsnummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<KodeverkType> PlasseringUnderstellsnummer { get; set; }

        [Newtonsoft.Json.JsonProperty("rFarge", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<KodeverkType> RFarge { get; set; }

        [Newtonsoft.Json.JsonProperty("sikkerhetsseler", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Sikkerhetsseler { get; set; }

        [Newtonsoft.Json.JsonProperty("styremekanismeArt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StyremekanismeArt { get; set; }

        [Newtonsoft.Json.JsonProperty("temperaturregulertSkap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? TemperaturregulertSkap { get; set; }

        [Newtonsoft.Json.JsonProperty("vendbarForerplass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? VendbarForerplass { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Kjennemerke
    {
        [Newtonsoft.Json.JsonProperty("fomTidspunkt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FomTidspunkt { get; set; }

        [Newtonsoft.Json.JsonProperty("kjennemerke", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Kjennemerke1 { get; set; }

        [Newtonsoft.Json.JsonProperty("kjennemerkekategori", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Kjennemerkekategori? Kjennemerkekategori { get; set; }

        [Newtonsoft.Json.JsonProperty("kjennemerketype", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Kjennemerketype { get; set; }

        [Newtonsoft.Json.JsonProperty("tilTidspunkt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TilTidspunkt { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KjoretoyIdentitetBegrenset
    {
        [Newtonsoft.Json.JsonProperty("kjennemerke", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Kjennemerke { get; set; }

        [Newtonsoft.Json.JsonProperty("understellsnummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Understellsnummer { get; set; }

        [Newtonsoft.Json.JsonProperty("kuid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Kuid { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KjoretoyMedBegrensedeEieropplysninger
    {
        [Newtonsoft.Json.JsonProperty("kjoretoyId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KjoretoyIdentitetBegrenset KjoretoyId { get; set; }

        [Newtonsoft.Json.JsonProperty("forstegangsregistrering", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Forstegangsregistrering Forstegangsregistrering { get; set; }

        [Newtonsoft.Json.JsonProperty("kjennemerke", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Kjennemerke> Kjennemerke { get; set; }

        [Newtonsoft.Json.JsonProperty("registrering", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Registrering Registrering { get; set; }

        [Newtonsoft.Json.JsonProperty("godkjenning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Godkjenning Godkjenning { get; set; }

        [Newtonsoft.Json.JsonProperty("periodiskKjoretoyKontroll", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PeriodiskKjoretoyKontroll PeriodiskKjoretoyKontroll { get; set; }

        [Newtonsoft.Json.JsonProperty("eierskap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EierskapBegrenset Eierskap { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Kjoretoyklassifisering
    {
        [Newtonsoft.Json.JsonProperty("beskrivelse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Beskrivelse { get; set; }

        [Newtonsoft.Json.JsonProperty("efTypegodkjenning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EFTypegodkjenningsId EfTypegodkjenning { get; set; }

        [Newtonsoft.Json.JsonProperty("kjoretoyAvgiftsKode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType KjoretoyAvgiftsKode { get; set; }

        [Newtonsoft.Json.JsonProperty("nasjonalGodkjenning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public NasjonaltGodkjenningsnummer NasjonalGodkjenning { get; set; }

        [Newtonsoft.Json.JsonProperty("spesielleKjennetegn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SpesielleKjennetegn { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskKode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType TekniskKode { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskUnderkode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType TekniskUnderkode { get; set; }

        [Newtonsoft.Json.JsonProperty("iSamsvarMedTypegodkjenning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ISamsvarMedTypegodkjenning { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Kjoretoymerknad
    {
        [Newtonsoft.Json.JsonProperty("merknad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Merknad { get; set; }

        [Newtonsoft.Json.JsonProperty("merknadtypeKode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MerknadtypeKode { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KodeverkType
    {
        [Newtonsoft.Json.JsonProperty("kodeBeskrivelse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KodeBeskrivelse { get; set; }

        [Newtonsoft.Json.JsonProperty("kodeNavn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KodeNavn { get; set; }

        [Newtonsoft.Json.JsonProperty("kodeTypeId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KodeTypeId { get; set; }

        [Newtonsoft.Json.JsonProperty("kodeVerdi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KodeVerdi { get; set; }

        [Newtonsoft.Json.JsonProperty("tidligereKodeVerdi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> TidligereKodeVerdi { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Kopling
    {
        [Newtonsoft.Json.JsonProperty("avstandFremstePktTilSenterKopling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AvstandFremstePktTilSenterKopling { get; set; }

        [Newtonsoft.Json.JsonProperty("avstandSenterKoplingTilBakerstePkt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AvstandSenterKoplingTilBakerstePkt { get; set; }

        [Newtonsoft.Json.JsonProperty("avstandSenterKoplingTilForsteAksel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AvstandSenterKoplingTilForsteAksel { get; set; }

        [Newtonsoft.Json.JsonProperty("avstandSisteAkselTilKingpinMaks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AvstandSisteAkselTilKingpinMaks { get; set; }

        [Newtonsoft.Json.JsonProperty("avstandSisteAkselTilKingpinMin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AvstandSisteAkselTilKingpinMin { get; set; }

        [Newtonsoft.Json.JsonProperty("avstandSisteAkselTilSenterKopling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AvstandSisteAkselTilSenterKopling { get; set; }

        [Newtonsoft.Json.JsonProperty("belastningDverdi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? BelastningDverdi { get; set; }

        [Newtonsoft.Json.JsonProperty("belastningLoddrettMaks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? BelastningLoddrettMaks { get; set; }

        [Newtonsoft.Json.JsonProperty("belastningSverdi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? BelastningSverdi { get; set; }

        [Newtonsoft.Json.JsonProperty("belastningUverdi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? BelastningUverdi { get; set; }

        [Newtonsoft.Json.JsonProperty("belastningVannrettMaks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? BelastningVannrettMaks { get; set; }

        [Newtonsoft.Json.JsonProperty("belastningVverdi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? BelastningVverdi { get; set; }

        [Newtonsoft.Json.JsonProperty("eftype", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Eftype { get; set; }

        [Newtonsoft.Json.JsonProperty("fabrikantKopling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FabrikantKopling { get; set; }

        [Newtonsoft.Json.JsonProperty("handelsbetegnelseKopling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HandelsbetegnelseKopling { get; set; }

        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Type { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Korreksjon
    {
        [Newtonsoft.Json.JsonProperty("godkjenningErKorrigert", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? GodkjenningErKorrigert { get; set; }

        [Newtonsoft.Json.JsonProperty("virkningsdato", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? Virkningsdato { get; set; }

        [Newtonsoft.Json.JsonProperty("felterEndret", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> FelterEndret { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Krav
    {
        [Newtonsoft.Json.JsonProperty("kravomrade", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Kravomrade { get; set; }

        [Newtonsoft.Json.JsonProperty("kravoppfyllelse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Kravoppfyllelse { get; set; }

        [Newtonsoft.Json.JsonProperty("vognkortmerknad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Vognkortmerknad { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class LarevognGodkjenning
    {
        [Newtonsoft.Json.JsonProperty("forekortklasser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Forekortklasser { get; set; }

        [Newtonsoft.Json.JsonProperty("larevogn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Larevogn { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Lyd
    {
        [Newtonsoft.Json.JsonProperty("innvendigStoyniva", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? InnvendigStoyniva { get; set; }

        [Newtonsoft.Json.JsonProperty("kjorestoy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Kjorestoy { get; set; }

        [Newtonsoft.Json.JsonProperty("standstoy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Standstoy { get; set; }

        [Newtonsoft.Json.JsonProperty("stoyMalingOppgittAv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType StoyMalingOppgittAv { get; set; }

        [Newtonsoft.Json.JsonProperty("vedAntallOmdreininger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? VedAntallOmdreininger { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Merke
    {
        [Newtonsoft.Json.JsonProperty("merke", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Merke1 { get; set; }

        [Newtonsoft.Json.JsonProperty("merkeKode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MerkeKode { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MiljoOgDrivstoffGruppe
    {
        [Newtonsoft.Json.JsonProperty("drivstoffKodeMiljodata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType DrivstoffKodeMiljodata { get; set; }

        [Newtonsoft.Json.JsonProperty("forbrukOgUtslipp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<ForbrukOgUtslipp> ForbrukOgUtslipp { get; set; }

        [Newtonsoft.Json.JsonProperty("lyd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Lyd Lyd { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Miljodata
    {
        [Newtonsoft.Json.JsonProperty("co2BesparelsePgaOkoInnovasjon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Co2BesparelsePgaOkoInnovasjon { get; set; }

        [Newtonsoft.Json.JsonProperty("euroKlasse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType EuroKlasse { get; set; }

        [Newtonsoft.Json.JsonProperty("lyddemperUtblas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LyddemperUtblas { get; set; }

        [Newtonsoft.Json.JsonProperty("miljoOgdrivstoffGruppe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<MiljoOgDrivstoffGruppe> MiljoOgdrivstoffGruppe { get; set; }

        [Newtonsoft.Json.JsonProperty("okoInnovasjon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? OkoInnovasjon { get; set; }

        [Newtonsoft.Json.JsonProperty("typeOkoInnovasjon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypeOkoInnovasjon { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Motor
    {
        [Newtonsoft.Json.JsonProperty("antallSylindre", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AntallSylindre { get; set; }

        [Newtonsoft.Json.JsonProperty("arbeidsprinsipp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Arbeidsprinsipp { get; set; }

        [Newtonsoft.Json.JsonProperty("avgassResirkulering", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AvgassResirkulering { get; set; }

        [Newtonsoft.Json.JsonProperty("blandingsDrivstoff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlandingsDrivstoff { get; set; }

        [Newtonsoft.Json.JsonProperty("drivstoff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Drivstoff> Drivstoff { get; set; }

        [Newtonsoft.Json.JsonProperty("fabrikant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fabrikant { get; set; }

        [Newtonsoft.Json.JsonProperty("fordampningsutslippKontrollSystem", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? FordampningsutslippKontrollSystem { get; set; }

        [Newtonsoft.Json.JsonProperty("katalysator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Katalysator { get; set; }

        [Newtonsoft.Json.JsonProperty("kjolesystem", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Kjolesystem { get; set; }

        [Newtonsoft.Json.JsonProperty("ladeluftkjoler", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Ladeluftkjoler { get; set; }

        [Newtonsoft.Json.JsonProperty("luftInnsproytning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? LuftInnsproytning { get; set; }

        [Newtonsoft.Json.JsonProperty("motorKode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MotorKode { get; set; }

        [Newtonsoft.Json.JsonProperty("motorNummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MotorNummer { get; set; }

        [Newtonsoft.Json.JsonProperty("oksygenSensor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? OksygenSensor { get; set; }

        [Newtonsoft.Json.JsonProperty("overladet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Overladet { get; set; }

        [Newtonsoft.Json.JsonProperty("partikkelfilterMotor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? PartikkelfilterMotor { get; set; }

        [Newtonsoft.Json.JsonProperty("slagvolum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Slagvolum { get; set; }

        [Newtonsoft.Json.JsonProperty("sylinderArrangement", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType SylinderArrangement { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MotorOgDrivverk
    {
        [Newtonsoft.Json.JsonProperty("antallGir", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AntallGir { get; set; }

        [Newtonsoft.Json.JsonProperty("antallGirBakover", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AntallGirBakover { get; set; }

        [Newtonsoft.Json.JsonProperty("effektKraftuttakKW", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? EffektKraftuttakKW { get; set; }

        [Newtonsoft.Json.JsonProperty("girPlassering", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GirPlassering { get; set; }

        [Newtonsoft.Json.JsonProperty("girkassetype", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Girkassetype { get; set; }

        [Newtonsoft.Json.JsonProperty("giroverforingsType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GiroverforingsType { get; set; }

        [Newtonsoft.Json.JsonProperty("girutvekslingPrGir", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Girutveksling> GirutvekslingPrGir { get; set; }

        [Newtonsoft.Json.JsonProperty("hybridElektriskKjoretoy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? HybridElektriskKjoretoy { get; set; }

        [Newtonsoft.Json.JsonProperty("hybridKategori", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType HybridKategori { get; set; }

        [Newtonsoft.Json.JsonProperty("maksimumHastighet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<int> MaksimumHastighet { get; set; }

        [Newtonsoft.Json.JsonProperty("maksimumHastighetMalt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<int> MaksimumHastighetMalt { get; set; }

        [Newtonsoft.Json.JsonProperty("motor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Motor> Motor { get; set; }

        [Newtonsoft.Json.JsonProperty("obd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Obd { get; set; }

        [Newtonsoft.Json.JsonProperty("totalUtvekslingHoyesteGir", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? TotalUtvekslingHoyesteGir { get; set; }

        [Newtonsoft.Json.JsonProperty("utelukkendeElektriskDrift", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? UtelukkendeElektriskDrift { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class NasjonaltGodkjenningsnummer
    {
        [Newtonsoft.Json.JsonProperty("nasjonaltGodkjenningsAr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NasjonaltGodkjenningsAr { get; set; }

        [Newtonsoft.Json.JsonProperty("nasjonaltGodkjenningsHovednummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NasjonaltGodkjenningsHovednummer { get; set; }

        [Newtonsoft.Json.JsonProperty("nasjonaltGodkjenningsUndernummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NasjonaltGodkjenningsUndernummer { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OppbygdMedAvgiftsfritak
    {
        [Newtonsoft.Json.JsonProperty("arkivreferanse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Arkivreferanse { get; set; }

        [Newtonsoft.Json.JsonProperty("delekjoretoy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<TekniskKjoretoyIdentitet> Delekjoretoy { get; set; }

        [Newtonsoft.Json.JsonProperty("erstattetKjoretoy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TekniskKjoretoyIdentitet ErstattetKjoretoy { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OvrigeTekniskeData
    {
        [Newtonsoft.Json.JsonProperty("datafeltIndeks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DatafeltIndeks { get; set; }

        [Newtonsoft.Json.JsonProperty("datafeltNavn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DatafeltNavn { get; set; }

        [Newtonsoft.Json.JsonProperty("datafeltVerdi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DatafeltVerdi { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PeriodiskKjoretoyKontroll
    {
        [Newtonsoft.Json.JsonProperty("kontrollfrist", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? Kontrollfrist { get; set; }

        [Newtonsoft.Json.JsonProperty("sistGodkjent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? SistGodkjent { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PersonEnhetBegrenset
    {
        [Newtonsoft.Json.JsonProperty("adresse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Adresse Adresse { get; set; }

        [Newtonsoft.Json.JsonProperty("enhet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Enhet Enhet { get; set; }

        [Newtonsoft.Json.JsonProperty("fomTidspunkt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FomTidspunkt { get; set; }

        [Newtonsoft.Json.JsonProperty("person", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PersonnavnMedFodselsdato Person { get; set; }

        [Newtonsoft.Json.JsonProperty("tilTidspunkt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TilTidspunkt { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PersonnavnMedFodselsdato
    {
        [Newtonsoft.Json.JsonProperty("etternavn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Etternavn { get; set; }

        [Newtonsoft.Json.JsonProperty("fodselsdato", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? Fodselsdato { get; set; }

        [Newtonsoft.Json.JsonProperty("fornavn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fornavn { get; set; }

        [Newtonsoft.Json.JsonProperty("mellomnavn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mellomnavn { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Persontall
    {
        [Newtonsoft.Json.JsonProperty("bareplasser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Bareplasser { get; set; }

        [Newtonsoft.Json.JsonProperty("rullestolplasser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Rullestolplasser { get; set; }

        [Newtonsoft.Json.JsonProperty("sitteplassListe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SitteplassListe SitteplassListe { get; set; }

        [Newtonsoft.Json.JsonProperty("sitteplasserForan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SitteplasserForan { get; set; }

        [Newtonsoft.Json.JsonProperty("sitteplasserNede", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SitteplasserNede { get; set; }

        [Newtonsoft.Json.JsonProperty("sitteplasserOppe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SitteplasserOppe { get; set; }

        [Newtonsoft.Json.JsonProperty("sitteplasserStillstand", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SitteplasserStillstand { get; set; }

        [Newtonsoft.Json.JsonProperty("sitteplasserTotalt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SitteplasserTotalt { get; set; }

        [Newtonsoft.Json.JsonProperty("sitteplasserTotaltSomVarebilKlasse2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SitteplasserTotaltSomVarebilKlasse2 { get; set; }

        [Newtonsoft.Json.JsonProperty("staplasser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Staplasser { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Registrering
    {
        [Newtonsoft.Json.JsonProperty("fomTidspunkt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? FomTidspunkt { get; set; }

        [Newtonsoft.Json.JsonProperty("kjoringensArt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType KjoringensArt { get; set; }

        [Newtonsoft.Json.JsonProperty("neringskode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Neringskode { get; set; }

        [Newtonsoft.Json.JsonProperty("neringskodeBeskrivelse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NeringskodeBeskrivelse { get; set; }

        [Newtonsoft.Json.JsonProperty("registreringsstatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Registreringsstatus { get; set; }

        [Newtonsoft.Json.JsonProperty("registrertForstegangPaEierskap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RegistrertForstegangPaEierskap { get; set; }

        [Newtonsoft.Json.JsonProperty("tilTidspunkt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TilTidspunkt { get; set; }

        [Newtonsoft.Json.JsonProperty("vektarsavgiftOppgittGrunnlag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public VektarsavgiftOppgittGrunnlag VektarsavgiftOppgittGrunnlag { get; set; }

        [Newtonsoft.Json.JsonProperty("avregistrertSidenDato", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? AvregistrertSidenDato { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Registreringsbegrensninger
    {
        [Newtonsoft.Json.JsonProperty("registreringsbegrensning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<KodeverkType> Registreringsbegrensning { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sitteplass
    {
        [Newtonsoft.Json.JsonProperty("beltekraftbegrenser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Beltekraftbegrenser { get; set; }

        [Newtonsoft.Json.JsonProperty("beltestrammer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Beltestrammer { get; set; }

        [Newtonsoft.Json.JsonProperty("frontairbag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Frontairbag { get; set; }

        [Newtonsoft.Json.JsonProperty("hodegardinairbag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Hodegardinairbag { get; set; }

        [Newtonsoft.Json.JsonProperty("kneairbag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Kneairbag { get; set; }

        [Newtonsoft.Json.JsonProperty("posisjon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Posisjon { get; set; }

        [Newtonsoft.Json.JsonProperty("rad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Rad { get; set; }

        [Newtonsoft.Json.JsonProperty("sideairbag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Sideairbag { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SitteplassListe
    {
        [Newtonsoft.Json.JsonProperty("sitteplass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Sitteplass> Sitteplass { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TekniskGodkjenning
    {
        [Newtonsoft.Json.JsonProperty("godkjenningsId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GodkjenningsId { get; set; }

        [Newtonsoft.Json.JsonProperty("godkjenningsundertype", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Godkjenningsundertype { get; set; }

        [Newtonsoft.Json.JsonProperty("gyldigFraDato", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? GyldigFraDato { get; set; }

        [Newtonsoft.Json.JsonProperty("gyldigFraDatoTid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? GyldigFraDatoTid { get; set; }

        [Newtonsoft.Json.JsonProperty("kjoretoyklassifisering", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Kjoretoyklassifisering Kjoretoyklassifisering { get; set; }

        [Newtonsoft.Json.JsonProperty("korreksjon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Korreksjon Korreksjon { get; set; }

        [Newtonsoft.Json.JsonProperty("krav", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Krav> Krav { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskeData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TekniskeData TekniskeData { get; set; }

        [Newtonsoft.Json.JsonProperty("unntak", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Unntak> Unntak { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TekniskKjoretoyIdentitet
    {
        [Newtonsoft.Json.JsonProperty("kuid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Kuid { get; set; }

        [Newtonsoft.Json.JsonProperty("understellsbasertId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UnderstellsbasertId UnderstellsbasertId { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TekniskeData
    {
        [Newtonsoft.Json.JsonProperty("akslinger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AkselInfo Akslinger { get; set; }

        [Newtonsoft.Json.JsonProperty("bremser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Bremse Bremser { get; set; }

        [Newtonsoft.Json.JsonProperty("dekkOgFelg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DekkOgFelg DekkOgFelg { get; set; }

        [Newtonsoft.Json.JsonProperty("dimensjoner", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Dimensjoner Dimensjoner { get; set; }

        [Newtonsoft.Json.JsonProperty("generelt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Generelt Generelt { get; set; }

        [Newtonsoft.Json.JsonProperty("karosseriOgLasteplan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KarosseriOgLasteplan KarosseriOgLasteplan { get; set; }

        [Newtonsoft.Json.JsonProperty("miljodata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Miljodata Miljodata { get; set; }

        [Newtonsoft.Json.JsonProperty("motorOgDrivverk", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MotorOgDrivverk MotorOgDrivverk { get; set; }

        [Newtonsoft.Json.JsonProperty("ovrigeTekniskeData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<OvrigeTekniskeData> OvrigeTekniskeData { get; set; }

        [Newtonsoft.Json.JsonProperty("persontall", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Persontall Persontall { get; set; }

        [Newtonsoft.Json.JsonProperty("tilhengerkopling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Tilhengerkopling Tilhengerkopling { get; set; }

        [Newtonsoft.Json.JsonProperty("vekter", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Vekter Vekter { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tilhengerkopling
    {
        [Newtonsoft.Json.JsonProperty("kopling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Kopling> Kopling { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tilleggsgodkjenning
    {
        [Newtonsoft.Json.JsonProperty("godkjenningstype", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Godkjenningstype { get; set; }

        [Newtonsoft.Json.JsonProperty("godkjentFra", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? GodkjentFra { get; set; }

        [Newtonsoft.Json.JsonProperty("godkjentFraDatoTid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? GodkjentFraDatoTid { get; set; }

        [Newtonsoft.Json.JsonProperty("godkjentTil", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? GodkjentTil { get; set; }

        [Newtonsoft.Json.JsonProperty("godkjentTilDatoTid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? GodkjentTilDatoTid { get; set; }

        [Newtonsoft.Json.JsonProperty("korreksjon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Korreksjon Korreksjon { get; set; }

        [Newtonsoft.Json.JsonProperty("krav", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Krav> Krav { get; set; }

        [Newtonsoft.Json.JsonProperty("tilleggsgodkjenningSpesifikkeData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TilleggsgodkjenningSpesifikkeData TilleggsgodkjenningSpesifikkeData { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TilleggsgodkjenningSpesifikkeData
    {
        [Newtonsoft.Json.JsonProperty("adrGodkjenning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AdrGodkjenning AdrGodkjenning { get; set; }

        [Newtonsoft.Json.JsonProperty("dyretransportGodkjenning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DyretransportGodkjenning DyretransportGodkjenning { get; set; }

        [Newtonsoft.Json.JsonProperty("larevognGodkjenning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LarevognGodkjenning LarevognGodkjenning { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Typegodkjenningsnummer
    {
        [Newtonsoft.Json.JsonProperty("direktiv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Direktiv { get; set; }

        [Newtonsoft.Json.JsonProperty("land", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Land { get; set; }

        [Newtonsoft.Json.JsonProperty("serie", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Serie { get; set; }

        [Newtonsoft.Json.JsonProperty("utvidelse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Utvidelse { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UnderstellsbasertId
    {
        [Newtonsoft.Json.JsonProperty("merkekode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Merkekode { get; set; }

        [Newtonsoft.Json.JsonProperty("understellsnummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Understellsnummer { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UnderstellsnummerBulkResponse
    {
        [Newtonsoft.Json.JsonProperty("gjenstaendeKvote", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? GjenstaendeKvote { get; set; }

        [Newtonsoft.Json.JsonProperty("responser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<UnderstellsnummerResponse> Responser { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UnderstellsnummerResponse
    {
        [Newtonsoft.Json.JsonProperty("feilmelding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        [Newtonsoft.Json.JsonProperty("request", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UnderstellsnummerRequest Request { get; set; }

        [Newtonsoft.Json.JsonProperty("kjoretoydataListe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<UnderstellsnummerTreffWrapper> KjoretoydataListe { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UnderstellsnummerTreffWrapper
    {
        [Newtonsoft.Json.JsonProperty("kjoretoydata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KjoretoyMedBegrensedeEieropplysninger Kjoretoydata { get; set; }

        [Newtonsoft.Json.JsonProperty("feilmelding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Unntak
    {
        [Newtonsoft.Json.JsonProperty("merknad", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Merknad { get; set; }

        [Newtonsoft.Json.JsonProperty("unntak", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KodeverkType Unntak1 { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class VektOgBremse
    {
        [Newtonsoft.Json.JsonProperty("bremseType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BremseType { get; set; }

        [Newtonsoft.Json.JsonProperty("vogntogvekt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Vogntogvekt { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class VektarsavgiftOppgittGrunnlag
    {
        [Newtonsoft.Json.JsonProperty("antallAkslerTilhenger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AntallAkslerTilhenger { get; set; }

        [Newtonsoft.Json.JsonProperty("totalvektTilhenger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TotalvektTilhenger { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Vekter
    {
        [Newtonsoft.Json.JsonProperty("egenvekt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Egenvekt { get; set; }

        [Newtonsoft.Json.JsonProperty("egenvektMaksimum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? EgenvektMaksimum { get; set; }

        [Newtonsoft.Json.JsonProperty("egenvektMinimum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? EgenvektMinimum { get; set; }

        [Newtonsoft.Json.JsonProperty("egenvektTilhengerkopling", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? EgenvektTilhengerkopling { get; set; }

        [Newtonsoft.Json.JsonProperty("frontOgHjulVekter", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FrontOgHjulVekter { get; set; }

        [Newtonsoft.Json.JsonProperty("nyttelast", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Nyttelast { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskTillattForhoyetTotalvekt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TekniskTillattForhoyetTotalvekt { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskTillattTotalvekt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TekniskTillattTotalvekt { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskTillattTotalvektVeg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TekniskTillattTotalvektVeg { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskTillattVektPahengsvogn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TekniskTillattVektPahengsvogn { get; set; }

        [Newtonsoft.Json.JsonProperty("tekniskTillattVektSemitilhenger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TekniskTillattVektSemitilhenger { get; set; }

        [Newtonsoft.Json.JsonProperty("tillattHjulLastSidevogn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TillattHjulLastSidevogn { get; set; }

        [Newtonsoft.Json.JsonProperty("tillattTaklast", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TillattTaklast { get; set; }

        [Newtonsoft.Json.JsonProperty("tillattTilhengervektMedBrems", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TillattTilhengervektMedBrems { get; set; }

        [Newtonsoft.Json.JsonProperty("tillattTilhengervektUtenBrems", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TillattTilhengervektUtenBrems { get; set; }

        [Newtonsoft.Json.JsonProperty("tillattTotalvekt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TillattTotalvekt { get; set; }

        [Newtonsoft.Json.JsonProperty("tillattVektSlepevogn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TillattVektSlepevogn { get; set; }

        [Newtonsoft.Json.JsonProperty("tillattVertikalKoplingslast", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TillattVertikalKoplingslast { get; set; }

        [Newtonsoft.Json.JsonProperty("tillattVogntogvekt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TillattVogntogvekt { get; set; }

        [Newtonsoft.Json.JsonProperty("tillattVogntogvektVeg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TillattVogntogvektVeg { get; set; }

        [Newtonsoft.Json.JsonProperty("vogntogvektAvhBremsesystem", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<VektOgBremse> VogntogvektAvhBremsesystem { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WLTP
    {
        [Newtonsoft.Json.JsonProperty("co2EkstraHoy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Co2EkstraHoy { get; set; }

        [Newtonsoft.Json.JsonProperty("co2Hoy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Co2Hoy { get; set; }

        [Newtonsoft.Json.JsonProperty("co2Kombinert", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Co2Kombinert { get; set; }

        [Newtonsoft.Json.JsonProperty("co2Lav", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Co2Lav { get; set; }

        [Newtonsoft.Json.JsonProperty("co2Middels", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Co2Middels { get; set; }

        [Newtonsoft.Json.JsonProperty("co2VektetKombinert", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Co2VektetKombinert { get; set; }

        [Newtonsoft.Json.JsonProperty("forbrukEkstraHoy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ForbrukEkstraHoy { get; set; }

        [Newtonsoft.Json.JsonProperty("forbrukHoy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ForbrukHoy { get; set; }

        [Newtonsoft.Json.JsonProperty("forbrukKombinert", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ForbrukKombinert { get; set; }

        [Newtonsoft.Json.JsonProperty("forbrukLav", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ForbrukLav { get; set; }

        [Newtonsoft.Json.JsonProperty("forbrukMiddels", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ForbrukMiddels { get; set; }

        [Newtonsoft.Json.JsonProperty("forbrukVektetKombinert", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? ForbrukVektetKombinert { get; set; }

        [Newtonsoft.Json.JsonProperty("rekkeviddeKmBlandetkjoring", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RekkeviddeKmBlandetkjoring { get; set; }

        [Newtonsoft.Json.JsonProperty("rekkeviddeKmBykjoring", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RekkeviddeKmBykjoring { get; set; }

        [Newtonsoft.Json.JsonProperty("elEnergiforbruk", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ElEnergiforbruk { get; set; }

        [Newtonsoft.Json.JsonProperty("nedcForbrukBykjoring", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? NedcForbrukBykjoring { get; set; }

        [Newtonsoft.Json.JsonProperty("nedcForbrukLandeveiskjoring", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? NedcForbrukLandeveiskjoring { get; set; }

        [Newtonsoft.Json.JsonProperty("nedcForbrukBlandetKjoring", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? NedcForbrukBlandetKjoring { get; set; }

        [Newtonsoft.Json.JsonProperty("nedcCo2BykjoringGPrKm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? NedcCo2BykjoringGPrKm { get; set; }

        [Newtonsoft.Json.JsonProperty("nedcCo2LandeveiskjoringGPrKm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? NedcCo2LandeveiskjoringGPrKm { get; set; }

        [Newtonsoft.Json.JsonProperty("nedcCo2BlandetKjoringGPrKm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? NedcCo2BlandetKjoringGPrKm { get; set; }

        [Newtonsoft.Json.JsonProperty("nedcVektetKombinertDrivstoffCo2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? NedcVektetKombinertDrivstoffCo2 { get; set; }

        [Newtonsoft.Json.JsonProperty("nedcVektetKombinertDrivstoff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? NedcVektetKombinertDrivstoff { get; set; }

        [Newtonsoft.Json.JsonProperty("nedcEnergiforbruk", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NedcEnergiforbruk { get; set; }

        [Newtonsoft.Json.JsonProperty("nedcRekkeviddeKm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NedcRekkeviddeKm { get; set; }

        [Newtonsoft.Json.JsonProperty("veilastkoeffisientf0", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Veilastkoeffisientf0 { get; set; }

        [Newtonsoft.Json.JsonProperty("veilastkoeffisientf1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Veilastkoeffisientf1 { get; set; }

        [Newtonsoft.Json.JsonProperty("veilastkoeffisientf2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Veilastkoeffisientf2 { get; set; }

        [Newtonsoft.Json.JsonProperty("testmasse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Testmasse { get; set; }

        [Newtonsoft.Json.JsonProperty("frontalareal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Frontalareal { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KuidRequest
    {
        /// <summary>
        /// Valgfri dato-tid - informasjonen som returneres er den som var gyldig på dette tidspunktet
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dtg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Dtg { get; set; }

        /// <summary>
        /// Kjøretøyets kuid
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kuid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Kuid { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KuidBulkResponse
    {
        [Newtonsoft.Json.JsonProperty("gjenstaendeKvote", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? GjenstaendeKvote { get; set; }

        [Newtonsoft.Json.JsonProperty("responser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<KuidResponse> Responser { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KuidResponse
    {
        [Newtonsoft.Json.JsonProperty("feilmelding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        [Newtonsoft.Json.JsonProperty("request", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KuidRequest Request { get; set; }

        [Newtonsoft.Json.JsonProperty("kjoretoydata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KjoretoyMedBegrensedeEieropplysninger Kjoretoydata { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KjennemerkeRequest
    {
        /// <summary>
        /// Kjøretøyets kjennemerke eller personlige kjennemerke
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kjennemerke", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Kjennemerke { get; set; }

        /// <summary>
        /// Valgfri dato-tid - informasjonen som returneres er den som var gyldig på dette tidspunktet
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dtg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Dtg { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KjennemerkeBulkResponse
    {
        [Newtonsoft.Json.JsonProperty("gjenstaendeKvote", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? GjenstaendeKvote { get; set; }

        [Newtonsoft.Json.JsonProperty("responser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<KjennemerkeResponse> Responser { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KjennemerkeResponse
    {
        [Newtonsoft.Json.JsonProperty("feilmelding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        [Newtonsoft.Json.JsonProperty("request", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KjennemerkeRequest Request { get; set; }

        [Newtonsoft.Json.JsonProperty("kjoretoydata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KjoretoyMedBegrensedeEieropplysninger Kjoretoydata { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FodselsnummerRequest
    {
        /// <summary>
        /// Fodselsnummer til eier, medeier eller leasingtaker
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fodselsnummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fodselsnummer { get; set; }

        /// <summary>
        /// Etternavn til eier, medeier eller leasingtaker
        /// </summary>
        [Newtonsoft.Json.JsonProperty("etternavn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Etternavn { get; set; }

        /// <summary>
        /// Valgfri dato-tid - informasjonen som returneres er den som var gyldig på dette tidspunktet
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dtg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Dtg { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FodselsnummerResponse
    {
        [Newtonsoft.Json.JsonProperty("gjenstaendeKvote", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? GjenstaendeKvote { get; set; }

        [Newtonsoft.Json.JsonProperty("feilmelding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        [Newtonsoft.Json.JsonProperty("request", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FodselsnummerRequest Request { get; set; }

        [Newtonsoft.Json.JsonProperty("kjoretoydataListe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<KjoretoydataWrapper> KjoretoydataListe { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Kjoretoy
    {
        [Newtonsoft.Json.JsonProperty("kjoretoyId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KjoretoyIdentitetBegrenset KjoretoyId { get; set; }

        [Newtonsoft.Json.JsonProperty("forstegangsregistrering", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Forstegangsregistrering Forstegangsregistrering { get; set; }
        
        [Newtonsoft.Json.JsonProperty("kjennemerke", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Kjennemerke> Kjennemerke { get; set; }

        [Newtonsoft.Json.JsonProperty("registrering", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Registrering Registrering { get; set; }

        [Newtonsoft.Json.JsonProperty("godkjenning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Godkjenning Godkjenning { get; set; }

        [Newtonsoft.Json.JsonProperty("periodiskKjoretoyKontroll", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PeriodiskKjoretoyKontroll PeriodiskKjoretoyKontroll { get; set; }

        [Newtonsoft.Json.JsonProperty("eierskap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EierskapBegrenset Eierskap { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KjoretoydataWrapper
    {
        [Newtonsoft.Json.JsonProperty("kjoretoydata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Kjoretoy Kjoretoydata { get; set; }

        [Newtonsoft.Json.JsonProperty("feilmelding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OrganisasjonsnummerRequest
    {
        /// <summary>
        /// Organisasjonsummeret til eier eller medeier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organisasjonsnummer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Organisasjonsnummer { get; set; }

        /// <summary>
        /// Valgfri dato-tid - informasjonen som returneres er den som var gyldig på dette tidspunktet
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dtg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Dtg { get; set; }

        /// <summary>
        /// Sidenummer for paginering hvis søkeresultatet gir flere treff enn antall-parameteren, begynner på side 0
        /// </summary>
        [Newtonsoft.Json.JsonProperty("side", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Side { get; set; }

        /// <summary>
        /// Antall treff som skal returneres per side
        /// </summary>
        [Newtonsoft.Json.JsonProperty("antall", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Antall { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OrganisasjonsnummerResponse
    {
        [Newtonsoft.Json.JsonProperty("gjenstaendeKvote", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? GjenstaendeKvote { get; set; }

        [Newtonsoft.Json.JsonProperty("feilmelding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        [Newtonsoft.Json.JsonProperty("request", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OrganisasjonsnummerRequest Request { get; set; }

        [Newtonsoft.Json.JsonProperty("kjoretoydataListe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<KjoretoydataWrapper> KjoretoydataListe { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EnkeltOppslagKjoretoydata
    {
        [Newtonsoft.Json.JsonProperty("kjoretoyId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KjoretoyIdentitetBegrenset KjoretoyId { get; set; }

        [Newtonsoft.Json.JsonProperty("forstegangsregistrering", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Forstegangsregistrering Forstegangsregistrering { get; set; }

        [Newtonsoft.Json.JsonProperty("kjennemerke", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Kjennemerke> Kjennemerke { get; set; }

        [Newtonsoft.Json.JsonProperty("registrering", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Registrering Registrering { get; set; }

        [Newtonsoft.Json.JsonProperty("godkjenning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Godkjenning Godkjenning { get; set; }

        [Newtonsoft.Json.JsonProperty("periodiskKjoretoyKontroll", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PeriodiskKjoretoyKontroll PeriodiskKjoretoyKontroll { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KjoretoydataResponse
    {
        [Newtonsoft.Json.JsonProperty("feilmelding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        [Newtonsoft.Json.JsonProperty("kjoretoydataListe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<EnkeltOppslagKjoretoydata> KjoretoydataListe { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum Kjennemerkekategori
    {

        [System.Runtime.Serialization.EnumMember(Value = @"KJORETOY")]
        KJORETOY = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"NORMAL")]
        NORMAL = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"PERSONLIG")]
        PERSONLIG = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"PROVE")]
        PROVE = 3,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    internal class DateFormatConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        public DateFormatConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
