using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Altinn.Dan.Plugin.Statensvegvesen.Models
{
    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UnderstellsnummerRequest
    {
        /// <summary>
        /// Kjøretøyets understellsnummer
        /// </summary>
        [JsonProperty("understellsnummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Understellsnummer { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdrGodkjenning
    {
        [JsonProperty("adrAnmerkninger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrAnmerkninger { get; set; }

        [JsonProperty("adrAttestnummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrAttestnummer { get; set; }

        [JsonProperty("adrBeskyttelseOverLastbarerKode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType AdrBeskyttelseOverLastbarerKode { get; set; }

        [JsonProperty("adrEX2EX3GodkjentGods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrEX2EX3GodkjentGods { get; set; }

        [JsonProperty("adrKjoretoyLukket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdrKjoretoyLukket { get; set; }

        [JsonProperty("adrNasjonaleKrav", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdrNasjonaleKrav { get; set; }

        [JsonProperty("adrPabyggTypeKode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType AdrPabyggTypeKode { get; set; }

        [JsonProperty("adrTankTekniskeData", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AdrTankTekniskeData AdrTankTekniskeData { get; set; }

        [JsonProperty("adrTidligereBestemmelser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdrTidligereBestemmelser { get; set; }

        [JsonProperty("adrTilleggsbremsEffekt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrTilleggsbremsEffekt { get; set; }

        [JsonProperty("adrTilleggsbremsIkkeAktuelt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdrTilleggsbremsIkkeAktuelt { get; set; }

        [JsonProperty("adrTransportorAdresse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrTransportorAdresse { get; set; }

        [JsonProperty("adrTransportorNavn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrTransportorNavn { get; set; }

        [JsonProperty("adrTransportorPostnrSted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrTransportorPostnrSted { get; set; }

        [JsonProperty("adrTypeKode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AdrTypeKode { get; set; }

        [JsonProperty("adrVekselbyggID", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrVekselbyggID { get; set; }

        [JsonProperty("adrVekselbyggIDFra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrVekselbyggIDFra { get; set; }

        [JsonProperty("adrVekselbyggIDTil", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrVekselbyggIDTil { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdrTankGodkjentGods
    {
        [JsonProperty("adrTankGodkjentFor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrTankGodkjentFor { get; set; }

        [JsonProperty("adrTankStofferIhhtTankkode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdrTankStofferIhhtTankkode { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdrTankInndelingVolum
    {
        [JsonProperty("adrTankInndelingVolum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<int> AdrTankInndelingVolum1 { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AdrTankTekniskeData
    {
        [JsonProperty("adrTankAntallRom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AdrTankAntallRom { get; set; }

        [JsonProperty("adrTankFabrikat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrTankFabrikat { get; set; }

        [JsonProperty("adrTankGodkjenningsnummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrTankGodkjenningsnummer { get; set; }

        [JsonProperty("adrTankGodkjentGods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<AdrTankGodkjentGods> AdrTankGodkjentGods { get; set; }

        [JsonProperty("adrTankInndeling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AdrTankInndelingVolum AdrTankInndeling { get; set; }

        [JsonProperty("adrTankKode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrTankKode { get; set; }

        [JsonProperty("adrTankKofferdam", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdrTankKofferdam { get; set; }

        [JsonProperty("adrTankLos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdrTankLos { get; set; }

        [JsonProperty("adrTankNesteTetthetsproveDato", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? AdrTankNesteTetthetsproveDato { get; set; }

        [JsonProperty("adrTankNesteTrykkproveDato", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? AdrTankNesteTrykkproveDato { get; set; }

        [JsonProperty("adrTankOverflyttetFra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrTankOverflyttetFra { get; set; }

        [JsonProperty("adrTankProduksjonsAr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AdrTankProduksjonsAr { get; set; }

        [JsonProperty("adrTankSerienummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrTankSerienummer { get; set; }

        [JsonProperty("adrTankSpesielleBestemmelser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AdrTankSpesielleBestemmelser { get; set; }

        [JsonProperty("adrTankVolum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AdrTankVolum { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Adresse
    {
        [JsonProperty("adresselinje1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Adresselinje1 { get; set; }

        [JsonProperty("adresselinje2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Adresselinje2 { get; set; }

        [JsonProperty("adresselinje3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Adresselinje3 { get; set; }

        [JsonProperty("kommunenavn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Kommunenavn { get; set; }

        [JsonProperty("kommunenummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Kommunenummer { get; set; }

        [JsonProperty("land", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Land { get; set; }

        [JsonProperty("landkode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Landkode { get; set; }

        [JsonProperty("postnummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Postnummer { get; set; }

        [JsonProperty("poststed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Poststed { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Aksel
    {
        [JsonProperty("antallHjul", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AntallHjul { get; set; }

        [JsonProperty("avstandTilNesteAksling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AvstandTilNesteAksling { get; set; }

        [JsonProperty("belastbar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Belastbar { get; set; }

        [JsonProperty("bremseAksel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? BremseAksel { get; set; }

        [JsonProperty("drivAksel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DrivAksel { get; set; }

        [JsonProperty("egenvektAksel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EgenvektAksel { get; set; }

        [JsonProperty("egenvektAkselMaks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EgenvektAkselMaks { get; set; }

        [JsonProperty("egenvektAkselMin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EgenvektAkselMin { get; set; }

        [JsonProperty("fordelingAvTillattTotalvektAkselMaks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FordelingAvTillattTotalvektAkselMaks { get; set; }

        [JsonProperty("fordelingAvTillattTotalvektAkselMin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FordelingAvTillattTotalvektAkselMin { get; set; }

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("loftbar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Loftbar { get; set; }

        [JsonProperty("luftfjaering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Luftfjaering { get; set; }

        [JsonProperty("maksAvstandTilNesteAksling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaksAvstandTilNesteAksling { get; set; }

        [JsonProperty("maksimalSporvidde", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaksimalSporvidde { get; set; }

        [JsonProperty("minAvstandTilNesteAksling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MinAvstandTilNesteAksling { get; set; }

        [JsonProperty("minimalSporvidde", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimalSporvidde { get; set; }

        [JsonProperty("plasseringAksel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PlasseringAksel { get; set; }

        [JsonProperty("sporvidde", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sporvidde { get; set; }

        [JsonProperty("styreAksel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? StyreAksel { get; set; }

        [JsonProperty("tekniskTillattAkselLast", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TekniskTillattAkselLast { get; set; }

        [JsonProperty("tekniskTillattAkselLastForhoyet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TekniskTillattAkselLastForhoyet { get; set; }

        [JsonProperty("tekniskTillattAkselLastVeg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TekniskTillattAkselLastVeg { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AkselDekkOgFelg
    {
        [JsonProperty("akselId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? AkselId { get; set; }

        [JsonProperty("belastningskodeDekk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BelastningskodeDekk { get; set; }

        [JsonProperty("belastningskodeDekkTraktor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BelastningskodeDekkTraktor { get; set; }

        [JsonProperty("dekkdimensjon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Dekkdimensjon { get; set; }

        [JsonProperty("felgdimensjon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Felgdimensjon { get; set; }

        [JsonProperty("hastighetskodeDekk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HastighetskodeDekk { get; set; }

        [JsonProperty("innpress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Innpress { get; set; }

        [JsonProperty("tillattAkselLastTraktor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TillattAkselLastTraktor { get; set; }

        [JsonProperty("tvilling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tvilling { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AkselDekkOgFelgKombinasjon
    {
        [JsonProperty("akselDekkOgFelg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<AkselDekkOgFelg> AkselDekkOgFelg { get; set; }

        [JsonProperty("tillattTotalvektTraktor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TillattTotalvektTraktor { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AkselGruppe
    {
        [JsonProperty("akselListe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AkselListe AkselListe { get; set; }

        [JsonProperty("egenvektAkselGruppe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EgenvektAkselGruppe { get; set; }

        [JsonProperty("egenvektAkselGruppeMaks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EgenvektAkselGruppeMaks { get; set; }

        [JsonProperty("egenvektAkselGruppeMin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EgenvektAkselGruppeMin { get; set; }

        [JsonProperty("fordelingAvTillattTotalvektAkselGruppeMaks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FordelingAvTillattTotalvektAkselGruppeMaks { get; set; }

        [JsonProperty("fordelingAvTillattTotalvektAkselGruppeMin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FordelingAvTillattTotalvektAkselGruppeMin { get; set; }

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("plasseringAkselGruppe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PlasseringAkselGruppe { get; set; }

        [JsonProperty("tekniskTillattAkselGruppeLast", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TekniskTillattAkselGruppeLast { get; set; }

        [JsonProperty("tekniskTillattAkselGruppeLastVeg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TekniskTillattAkselGruppeLastVeg { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AkselInfo
    {
        [JsonProperty("akselGruppe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<AkselGruppe> AkselGruppe { get; set; }

        [JsonProperty("antallAksler", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AntallAksler { get; set; }

        [JsonProperty("forbindelseMellomDrivaksler", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType ForbindelseMellomDrivaksler { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class AkselListe
    {
        [JsonProperty("aksel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Aksel> Aksel { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Bremse
    {
        [JsonProperty("abs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Abs { get; set; }

        [JsonProperty("bremsesystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Bremsesystem { get; set; }

        [JsonProperty("driftsbremsBak", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DriftsbremsBak { get; set; }

        [JsonProperty("driftsbremsForan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DriftsbremsForan { get; set; }

        [JsonProperty("tilhengerBremseforbindelse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TilhengerBremseforbindelse { get; set; }

        [JsonProperty("trykkMeterledningTilhengerkopling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? TrykkMeterledningTilhengerkopling { get; set; }

        [JsonProperty("trykktilsluttning1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Trykktilsluttning1 { get; set; }

        [JsonProperty("trykktilsluttning2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Trykktilsluttning2 { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BruktImportInfo
    {
        [JsonProperty("importland", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Importland Importland { get; set; }

        [JsonProperty("kilometerstand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kilometerstand { get; set; }

        [JsonProperty("tidligereUtenlandskKjennemerke", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TidligereUtenlandskKjennemerke { get; set; }

        [JsonProperty("tidligereUtenlandskVognkortNummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TidligereUtenlandskVognkortNummer { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DekkOgFelg
    {
        [JsonProperty("akselDekkOgFelgKombinasjon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<AkselDekkOgFelgKombinasjon> AkselDekkOgFelgKombinasjon { get; set; }

        [JsonProperty("dekkOgFelgSidevogn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DekkOgFelgSidevogn DekkOgFelgSidevogn { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DekkOgFelgSidevogn
    {
        [JsonProperty("belastningskodeDekkSidevogn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BelastningskodeDekkSidevogn { get; set; }

        [JsonProperty("dekkdimensjonSidevogn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DekkdimensjonSidevogn { get; set; }

        [JsonProperty("felgdimensjonSidevogn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FelgdimensjonSidevogn { get; set; }

        [JsonProperty("hastighetskodeDekkSidevogn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HastighetskodeDekkSidevogn { get; set; }

        [JsonProperty("innpressSidevogn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string InnpressSidevogn { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Dimensjoner
    {
        [JsonProperty("bredde", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bredde { get; set; }

        [JsonProperty("hoyde", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hoyde { get; set; }

        [JsonProperty("lengde", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lengde { get; set; }

        [JsonProperty("lengdeInnvendigLasteplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LengdeInnvendigLasteplan { get; set; }

        [JsonProperty("maksimalBredde", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaksimalBredde { get; set; }

        [JsonProperty("maksimalHoyde", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaksimalHoyde { get; set; }

        [JsonProperty("maksimalLengde", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaksimalLengde { get; set; }

        [JsonProperty("maksimalLengdeInnvendigLasteplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaksimalLengdeInnvendigLasteplan { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Drivstoff
    {
        [JsonProperty("drivstoffKode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType DrivstoffKode { get; set; }

        [JsonProperty("effektVektForhold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? EffektVektForhold { get; set; }

        [JsonProperty("maksEffektPrTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? MaksEffektPrTime { get; set; }

        [JsonProperty("maksNettoEffekt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? MaksNettoEffekt { get; set; }

        [JsonProperty("maksNettoEffektVedOmdreiningstallMin1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaksNettoEffektVedOmdreiningstallMin1 { get; set; }

        [JsonProperty("maksNettoEffektVedOmdreiningstallMin1Maks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaksNettoEffektVedOmdreiningstallMin1Maks { get; set; }

        [JsonProperty("maksOmdreining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaksOmdreining { get; set; }

        [JsonProperty("spenning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Spenning { get; set; }

        [JsonProperty("tomgangsOmdreiningstall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TomgangsOmdreiningstall { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DyretransportGodkjenning
    {
        [JsonProperty("fornyelse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fornyelse { get; set; }

        [JsonProperty("gulvareal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Gulvareal { get; set; }

        [JsonProperty("hestetransporttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Hestetransporttype { get; set; }

        [JsonProperty("takhoyde", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Takhoyde { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EFTypegodkjenningsId
    {
        [JsonProperty("typegodkjenningNrTekst", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TypegodkjenningNrTekst { get; set; }

        [JsonProperty("typegodkjenningnummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Typegodkjenningsnummer Typegodkjenningnummer { get; set; }

        [JsonProperty("variant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Variant { get; set; }

        [JsonProperty("versjon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Versjon { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EierskapBegrenset
    {
        [JsonProperty("eier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PersonEnhetBegrenset Eier { get; set; }

        [JsonProperty("leasingtaker", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PersonEnhetBegrenset Leasingtaker { get; set; }

        [JsonProperty("medeier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PersonEnhetBegrenset Medeier { get; set; }

        [JsonProperty("underenhet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PersonEnhetBegrenset Underenhet { get; set; }

        [JsonProperty("vedtakstidspunkt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Vedtakstidspunkt { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Enhet
    {
        [JsonProperty("organisasjonsnavn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Organisasjonsnavn { get; set; }

        [JsonProperty("organisasjonsnummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Organisasjonsnummer { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Fabrikant
    {
        [JsonProperty("fabrikantAdresse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FabrikantAdresse { get; set; }

        [JsonProperty("fabrikantNavn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FabrikantNavn { get; set; }

        [JsonProperty("fabrikantRepresentantAdresse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FabrikantRepresentantAdresse { get; set; }

        [JsonProperty("fabrikantRepresentantNavn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FabrikantRepresentantNavn { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ForbrukOgUtslipp
    {
        [JsonProperty("antallPartikler", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? AntallPartikler { get; set; }

        [JsonProperty("co2BlandetKjoring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Co2BlandetKjoring { get; set; }

        [JsonProperty("co2Bykjoring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Co2Bykjoring { get; set; }

        [JsonProperty("co2Landeveiskjoring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Co2Landeveiskjoring { get; set; }

        [JsonProperty("coProsent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? CoProsent { get; set; }

        [JsonProperty("elEnergiforbruk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ElEnergiforbruk { get; set; }

        [JsonProperty("forbrukBlandetKjoring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ForbrukBlandetKjoring { get; set; }

        [JsonProperty("forbrukBykjoring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ForbrukBykjoring { get; set; }

        [JsonProperty("forbrukLandeveiskjoring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ForbrukLandeveiskjoring { get; set; }

        [JsonProperty("malemetode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Malemetode { get; set; }

        [JsonProperty("malemetodeAnnen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MalemetodeAnnen { get; set; }

        [JsonProperty("partikkelfilterFabrikkmontert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PartikkelfilterFabrikkmontert { get; set; }

        [JsonProperty("partikkelfilterUtslipp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PartikkelfilterUtslipp { get; set; }

        [JsonProperty("rekkeviddeKm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RekkeviddeKm { get; set; }

        [JsonProperty("utslippCOgPrKWh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? UtslippCOgPrKWh { get; set; }

        [JsonProperty("utslippCOmgPrKm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? UtslippCOmgPrKm { get; set; }

        [JsonProperty("utslippHCgPrKWh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? UtslippHCgPrKWh { get; set; }

        [JsonProperty("utslippHCgPrMin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? UtslippHCgPrMin { get; set; }

        [JsonProperty("utslippHCmgPrKm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? UtslippHCmgPrKm { get; set; }

        [JsonProperty("utslippHCogNOxMgPrKm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? UtslippHCogNOxMgPrKm { get; set; }

        [JsonProperty("utslippKorrigertAbsorpsjonskoeffisient", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? UtslippKorrigertAbsorpsjonskoeffisient { get; set; }

        [JsonProperty("utslippNMHCmgPrKm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? UtslippNMHCmgPrKm { get; set; }

        [JsonProperty("utslippNOxGPrKWh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? UtslippNOxGPrKWh { get; set; }

        [JsonProperty("utslippNOxMgPrKm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? UtslippNOxMgPrKm { get; set; }

        [JsonProperty("utslippPartikkelAntallPrKm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? UtslippPartikkelAntallPrKm { get; set; }

        [JsonProperty("utslippPartiklerGPrKWh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? UtslippPartiklerGPrKWh { get; set; }

        [JsonProperty("utslippPartiklerMgPrKm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? UtslippPartiklerMgPrKm { get; set; }

        [JsonProperty("utslippTHCmgPrKm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? UtslippTHCmgPrKm { get; set; }

        [JsonProperty("utslippTHCogNOxMgPrKm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? UtslippTHCogNOxMgPrKm { get; set; }

        [JsonProperty("vektetKombinertDrivstoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? VektetKombinertDrivstoff { get; set; }

        [JsonProperty("vektetKombinertDrivstoffCO2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? VektetKombinertDrivstoffCO2 { get; set; }

        [JsonProperty("wltpKjoretoyspesifikk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WLTP WltpKjoretoyspesifikk { get; set; }

        [JsonProperty("wltpTypegodkjenningMaks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WLTP WltpTypegodkjenningMaks { get; set; }

        [JsonProperty("wltpTypegodkjenningMedium", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WLTP WltpTypegodkjenningMedium { get; set; }

        [JsonProperty("wltpTypegodkjenningMin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WLTP WltpTypegodkjenningMin { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class ForstegangsTekniskGodkjenning
    {
        [JsonProperty("bruktimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public BruktImportInfo Bruktimport { get; set; }

        [JsonProperty("forstegangRegistrertDato", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? ForstegangRegistrertDato { get; set; }

        [JsonProperty("fortollingOgMva", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FortollingOgMva FortollingOgMva { get; set; }

        [JsonProperty("godkjenningsId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GodkjenningsId { get; set; }

        [JsonProperty("godkjenningsundertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Godkjenningsundertype { get; set; }

        [JsonProperty("gyldigFraDato", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? GyldigFraDato { get; set; }

        [JsonProperty("gyldigFraDatoTid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? GyldigFraDatoTid { get; set; }

        [JsonProperty("kvalitetskodeForstegangRegDato", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType KvalitetskodeForstegangRegDato { get; set; }

        [JsonProperty("oppbygdMedAvgiftsfritak", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public OppbygdMedAvgiftsfritak OppbygdMedAvgiftsfritak { get; set; }

        [JsonProperty("unntak", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Unntak> Unntak { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Forstegangsregistrering
    {
        [JsonProperty("registrertForstegangNorgeDato", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? RegistrertForstegangNorgeDato { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FortollingOgMva
    {
        [JsonProperty("annenReferanse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string AnnenReferanse { get; set; }

        [JsonProperty("beskrivelse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Beskrivelse { get; set; }

        [JsonProperty("dokumentreferanse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Dokumentreferanse { get; set; }

        [JsonProperty("fortollingsreferanse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fortollingsreferanse { get; set; }

        [JsonProperty("linje", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linje { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Generelt
    {
        [JsonProperty("fabrikant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Fabrikant> Fabrikant { get; set; }

        [JsonProperty("ferdigbyggetEllerEndretSomFolger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FerdigbyggetEllerEndretSomFolger { get; set; }

        [JsonProperty("handelsbetegnelse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Handelsbetegnelse { get; set; }

        [JsonProperty("merke", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Merke> Merke { get; set; }

        [JsonProperty("tekniskKode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType TekniskKode { get; set; }

        [JsonProperty("tekniskUnderkode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType TekniskUnderkode { get; set; }

        [JsonProperty("typebetegnelse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Typebetegnelse { get; set; }

        [JsonProperty("unntakFra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string UnntakFra { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Girutveksling
    {
        [JsonProperty("girNummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GirNummer { get; set; }

        [JsonProperty("girutveksling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Girutveksling1 { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Godkjenning
    {
        [JsonProperty("forstegangsGodkjenning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ForstegangsTekniskGodkjenning ForstegangsGodkjenning { get; set; }

        [JsonProperty("kjoretoymerknad", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Kjoretoymerknad> Kjoretoymerknad { get; set; }

        [JsonProperty("registreringsbegrensninger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Registreringsbegrensninger Registreringsbegrensninger { get; set; }

        [JsonProperty("tekniskGodkjenning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TekniskGodkjenning TekniskGodkjenning { get; set; }

        [JsonProperty("tilleggsgodkjenninger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Tilleggsgodkjenning> Tilleggsgodkjenninger { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Importland
    {
        [JsonProperty("landNavn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LandNavn { get; set; }

        [JsonProperty("landkode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Landkode { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KarosseriOgLasteplan
    {
        [JsonProperty("antallDorer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<int> AntallDorer { get; set; }

        [JsonProperty("avstandNavSkjermbueBak", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AvstandNavSkjermbueBak { get; set; }

        [JsonProperty("avstandNavSkjermbueForan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AvstandNavSkjermbueForan { get; set; }

        [JsonProperty("bussKategori", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BussKategori { get; set; }

        [JsonProperty("dorUtforming", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DorUtforming { get; set; }

        [JsonProperty("fargeFjar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FargeFjar { get; set; }

        [JsonProperty("forankringSikkerhetsseler", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ForankringSikkerhetsseler { get; set; }

        [JsonProperty("forervern", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Forervern { get; set; }

        [JsonProperty("forervernBoyle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ForervernBoyle { get; set; }

        [JsonProperty("godkjentADR", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GodkjentADR { get; set; }

        [JsonProperty("hydrauliskLoft", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HydrauliskLoft { get; set; }

        [JsonProperty("karosseriArt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KarosseriArt { get; set; }

        [JsonProperty("karosseritype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Karosseritype { get; set; }

        [JsonProperty("kjennemerketypeBak", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType KjennemerketypeBak { get; set; }

        [JsonProperty("kjennemerkestorrelseBak", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType KjennemerkestorrelseBak { get; set; }

        [JsonProperty("kjennemerketypeForan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType KjennemerketypeForan { get; set; }

        [JsonProperty("kjennemerkestorrelseForan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType KjennemerkestorrelseForan { get; set; }

        [JsonProperty("kjennemerketypeVenstre", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType KjennemerketypeVenstre { get; set; }

        [JsonProperty("kjennemerkestorrelseVenstre", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType KjennemerkestorrelseVenstre { get; set; }

        [JsonProperty("kjoringSide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KjoringSide { get; set; }

        [JsonProperty("oppbygningUnderstellsnummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string OppbygningUnderstellsnummer { get; set; }

        [JsonProperty("overhengBak", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OverhengBak { get; set; }

        [JsonProperty("pabyggsKode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType PabyggsKode { get; set; }

        [JsonProperty("passasjerHandtak", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PassasjerHandtak { get; set; }

        [JsonProperty("plasseringAvDorer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType PlasseringAvDorer { get; set; }

        [JsonProperty("plasseringFabrikasjonsplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<KodeverkType> PlasseringFabrikasjonsplate { get; set; }

        [JsonProperty("plasseringMerkeplateTrimming", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string PlasseringMerkeplateTrimming { get; set; }

        [JsonProperty("plasseringUnderstellsnummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<KodeverkType> PlasseringUnderstellsnummer { get; set; }

        [JsonProperty("rFarge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<KodeverkType> RFarge { get; set; }

        [JsonProperty("sikkerhetsseler", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Sikkerhetsseler { get; set; }

        [JsonProperty("styremekanismeArt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string StyremekanismeArt { get; set; }

        [JsonProperty("temperaturregulertSkap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TemperaturregulertSkap { get; set; }

        [JsonProperty("vendbarForerplass", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? VendbarForerplass { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Kjennemerke
    {
        [JsonProperty("fomTidspunkt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FomTidspunkt { get; set; }

        [JsonProperty("kjennemerke", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Kjennemerke1 { get; set; }

        [JsonProperty("kjennemerkekategori", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public Kjennemerkekategori? Kjennemerkekategori { get; set; }

        [JsonProperty("kjennemerketype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Kjennemerketype { get; set; }

        [JsonProperty("tilTidspunkt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TilTidspunkt { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KjoretoyIdentitetBegrenset
    {
        [JsonProperty("kjennemerke", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Kjennemerke { get; set; }

        [JsonProperty("understellsnummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Understellsnummer { get; set; }

        [JsonProperty("kuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Kuid { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KjoretoyMedBegrensedeEieropplysninger
    {
        [JsonProperty("kjoretoyId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KjoretoyIdentitetBegrenset KjoretoyId { get; set; }

        [JsonProperty("forstegangsregistrering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Forstegangsregistrering Forstegangsregistrering { get; set; }

        [JsonProperty("kjennemerke", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Kjennemerke> Kjennemerke { get; set; }

        [JsonProperty("registrering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Registrering Registrering { get; set; }

        [JsonProperty("godkjenning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Godkjenning Godkjenning { get; set; }

        [JsonProperty("periodiskKjoretoyKontroll", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PeriodiskKjoretoyKontroll PeriodiskKjoretoyKontroll { get; set; }

        [JsonProperty("eierskap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public EierskapBegrenset Eierskap { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Kjoretoyklassifisering
    {
        [JsonProperty("beskrivelse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Beskrivelse { get; set; }

        [JsonProperty("efTypegodkjenning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public EFTypegodkjenningsId EfTypegodkjenning { get; set; }

        [JsonProperty("kjoretoyAvgiftsKode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType KjoretoyAvgiftsKode { get; set; }

        [JsonProperty("nasjonalGodkjenning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public NasjonaltGodkjenningsnummer NasjonalGodkjenning { get; set; }

        [JsonProperty("spesielleKjennetegn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SpesielleKjennetegn { get; set; }

        [JsonProperty("tekniskKode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType TekniskKode { get; set; }

        [JsonProperty("tekniskUnderkode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType TekniskUnderkode { get; set; }

        [JsonProperty("iSamsvarMedTypegodkjenning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ISamsvarMedTypegodkjenning { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Kjoretoymerknad
    {
        [JsonProperty("merknad", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Merknad { get; set; }

        [JsonProperty("merknadtypeKode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MerknadtypeKode { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KodeverkType
    {
        [JsonProperty("kodeBeskrivelse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KodeBeskrivelse { get; set; }

        [JsonProperty("kodeNavn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KodeNavn { get; set; }

        [JsonProperty("kodeTypeId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KodeTypeId { get; set; }

        [JsonProperty("kodeVerdi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string KodeVerdi { get; set; }

        [JsonProperty("tidligereKodeVerdi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TidligereKodeVerdi { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Kopling
    {
        [JsonProperty("avstandFremstePktTilSenterKopling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AvstandFremstePktTilSenterKopling { get; set; }

        [JsonProperty("avstandSenterKoplingTilBakerstePkt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AvstandSenterKoplingTilBakerstePkt { get; set; }

        [JsonProperty("avstandSenterKoplingTilForsteAksel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AvstandSenterKoplingTilForsteAksel { get; set; }

        [JsonProperty("avstandSisteAkselTilKingpinMaks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AvstandSisteAkselTilKingpinMaks { get; set; }

        [JsonProperty("avstandSisteAkselTilKingpinMin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AvstandSisteAkselTilKingpinMin { get; set; }

        [JsonProperty("avstandSisteAkselTilSenterKopling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AvstandSisteAkselTilSenterKopling { get; set; }

        [JsonProperty("belastningDverdi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? BelastningDverdi { get; set; }

        [JsonProperty("belastningLoddrettMaks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BelastningLoddrettMaks { get; set; }

        [JsonProperty("belastningSverdi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? BelastningSverdi { get; set; }

        [JsonProperty("belastningUverdi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? BelastningUverdi { get; set; }

        [JsonProperty("belastningVannrettMaks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BelastningVannrettMaks { get; set; }

        [JsonProperty("belastningVverdi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? BelastningVverdi { get; set; }

        [JsonProperty("eftype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Eftype { get; set; }

        [JsonProperty("fabrikantKopling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FabrikantKopling { get; set; }

        [JsonProperty("handelsbetegnelseKopling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string HandelsbetegnelseKopling { get; set; }

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Type { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Korreksjon
    {
        [JsonProperty("godkjenningErKorrigert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GodkjenningErKorrigert { get; set; }

        [JsonProperty("virkningsdato", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? Virkningsdato { get; set; }

        [JsonProperty("felterEndret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FelterEndret { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Krav
    {
        [JsonProperty("kravomrade", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Kravomrade { get; set; }

        [JsonProperty("kravoppfyllelse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Kravoppfyllelse { get; set; }

        [JsonProperty("vognkortmerknad", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Vognkortmerknad { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class LarevognGodkjenning
    {
        [JsonProperty("forekortklasser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Forekortklasser { get; set; }

        [JsonProperty("larevogn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Larevogn { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Lyd
    {
        [JsonProperty("innvendigStoyniva", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InnvendigStoyniva { get; set; }

        [JsonProperty("kjorestoy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kjorestoy { get; set; }

        [JsonProperty("standstoy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Standstoy { get; set; }

        [JsonProperty("stoyMalingOppgittAv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType StoyMalingOppgittAv { get; set; }

        [JsonProperty("vedAntallOmdreininger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? VedAntallOmdreininger { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Merke
    {
        [JsonProperty("merke", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Merke1 { get; set; }

        [JsonProperty("merkeKode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MerkeKode { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MiljoOgDrivstoffGruppe
    {
        [JsonProperty("drivstoffKodeMiljodata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType DrivstoffKodeMiljodata { get; set; }

        [JsonProperty("forbrukOgUtslipp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<ForbrukOgUtslipp> ForbrukOgUtslipp { get; set; }

        [JsonProperty("lyd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Lyd Lyd { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Miljodata
    {
        [JsonProperty("co2BesparelsePgaOkoInnovasjon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Co2BesparelsePgaOkoInnovasjon { get; set; }

        [JsonProperty("euroKlasse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType EuroKlasse { get; set; }

        [JsonProperty("lyddemperUtblas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string LyddemperUtblas { get; set; }

        [JsonProperty("miljoOgdrivstoffGruppe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<MiljoOgDrivstoffGruppe> MiljoOgdrivstoffGruppe { get; set; }

        [JsonProperty("okoInnovasjon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OkoInnovasjon { get; set; }

        [JsonProperty("typeOkoInnovasjon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TypeOkoInnovasjon { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Motor
    {
        [JsonProperty("antallSylindre", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AntallSylindre { get; set; }

        [JsonProperty("arbeidsprinsipp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Arbeidsprinsipp { get; set; }

        [JsonProperty("avgassResirkulering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AvgassResirkulering { get; set; }

        [JsonProperty("blandingsDrivstoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BlandingsDrivstoff { get; set; }

        [JsonProperty("drivstoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Drivstoff> Drivstoff { get; set; }

        [JsonProperty("fabrikant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fabrikant { get; set; }

        [JsonProperty("fordampningsutslippKontrollSystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FordampningsutslippKontrollSystem { get; set; }

        [JsonProperty("katalysator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Katalysator { get; set; }

        [JsonProperty("kjolesystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Kjolesystem { get; set; }

        [JsonProperty("ladeluftkjoler", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ladeluftkjoler { get; set; }

        [JsonProperty("luftInnsproytning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LuftInnsproytning { get; set; }

        [JsonProperty("motorKode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MotorKode { get; set; }

        [JsonProperty("motorNummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string MotorNummer { get; set; }

        [JsonProperty("oksygenSensor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OksygenSensor { get; set; }

        [JsonProperty("overladet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Overladet { get; set; }

        [JsonProperty("partikkelfilterMotor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PartikkelfilterMotor { get; set; }

        [JsonProperty("slagvolum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slagvolum { get; set; }

        [JsonProperty("sylinderArrangement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType SylinderArrangement { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class MotorOgDrivverk
    {
        [JsonProperty("antallGir", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AntallGir { get; set; }

        [JsonProperty("antallGirBakover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AntallGirBakover { get; set; }

        [JsonProperty("effektKraftuttakKW", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EffektKraftuttakKW { get; set; }

        [JsonProperty("girPlassering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GirPlassering { get; set; }

        [JsonProperty("girkassetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Girkassetype { get; set; }

        [JsonProperty("giroverforingsType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GiroverforingsType { get; set; }

        [JsonProperty("girutvekslingPrGir", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Girutveksling> GirutvekslingPrGir { get; set; }

        [JsonProperty("hybridElektriskKjoretoy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HybridElektriskKjoretoy { get; set; }

        [JsonProperty("hybridKategori", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType HybridKategori { get; set; }

        [JsonProperty("maksimumHastighet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<int> MaksimumHastighet { get; set; }

        [JsonProperty("maksimumHastighetMalt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<int> MaksimumHastighetMalt { get; set; }

        [JsonProperty("motor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Motor> Motor { get; set; }

        [JsonProperty("obd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Obd { get; set; }

        [JsonProperty("totalUtvekslingHoyesteGir", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? TotalUtvekslingHoyesteGir { get; set; }

        [JsonProperty("utelukkendeElektriskDrift", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UtelukkendeElektriskDrift { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class NasjonaltGodkjenningsnummer
    {
        [JsonProperty("nasjonaltGodkjenningsAr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string NasjonaltGodkjenningsAr { get; set; }

        [JsonProperty("nasjonaltGodkjenningsHovednummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string NasjonaltGodkjenningsHovednummer { get; set; }

        [JsonProperty("nasjonaltGodkjenningsUndernummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string NasjonaltGodkjenningsUndernummer { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OppbygdMedAvgiftsfritak
    {
        [JsonProperty("arkivreferanse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Arkivreferanse { get; set; }

        [JsonProperty("delekjoretoy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<TekniskKjoretoyIdentitet> Delekjoretoy { get; set; }

        [JsonProperty("erstattetKjoretoy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TekniskKjoretoyIdentitet ErstattetKjoretoy { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OvrigeTekniskeData
    {
        [JsonProperty("datafeltIndeks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DatafeltIndeks { get; set; }

        [JsonProperty("datafeltNavn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DatafeltNavn { get; set; }

        [JsonProperty("datafeltVerdi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string DatafeltVerdi { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PeriodiskKjoretoyKontroll
    {
        [JsonProperty("kontrollfrist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? Kontrollfrist { get; set; }

        [JsonProperty("sistGodkjent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? SistGodkjent { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PersonEnhetBegrenset
    {
        [JsonProperty("adresse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Adresse Adresse { get; set; }

        [JsonProperty("enhet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Enhet Enhet { get; set; }

        [JsonProperty("fomTidspunkt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FomTidspunkt { get; set; }

        [JsonProperty("person", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PersonnavnMedFodselsdato Person { get; set; }

        [JsonProperty("tilTidspunkt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TilTidspunkt { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PersonnavnMedFodselsdato
    {
        [JsonProperty("etternavn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Etternavn { get; set; }

        [JsonProperty("fodselsdato", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? Fodselsdato { get; set; }

        [JsonProperty("fornavn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fornavn { get; set; }

        [JsonProperty("mellomnavn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Mellomnavn { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Persontall
    {
        [JsonProperty("bareplasser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bareplasser { get; set; }

        [JsonProperty("rullestolplasser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rullestolplasser { get; set; }

        [JsonProperty("sitteplassListe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public SitteplassListe SitteplassListe { get; set; }

        [JsonProperty("sitteplasserForan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SitteplasserForan { get; set; }

        [JsonProperty("sitteplasserNede", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SitteplasserNede { get; set; }

        [JsonProperty("sitteplasserOppe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SitteplasserOppe { get; set; }

        [JsonProperty("sitteplasserStillstand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SitteplasserStillstand { get; set; }

        [JsonProperty("sitteplasserTotalt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SitteplasserTotalt { get; set; }

        [JsonProperty("sitteplasserTotaltSomVarebilKlasse2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SitteplasserTotaltSomVarebilKlasse2 { get; set; }

        [JsonProperty("staplasser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Staplasser { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Registrering
    {
        [JsonProperty("fomTidspunkt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? FomTidspunkt { get; set; }

        [JsonProperty("kjoringensArt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType KjoringensArt { get; set; }

        [JsonProperty("neringskode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Neringskode { get; set; }

        [JsonProperty("neringskodeBeskrivelse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string NeringskodeBeskrivelse { get; set; }

        [JsonProperty("registreringsstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Registreringsstatus { get; set; }

        [JsonProperty("registrertForstegangPaEierskap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? RegistrertForstegangPaEierskap { get; set; }

        [JsonProperty("tilTidspunkt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TilTidspunkt { get; set; }

        [JsonProperty("vektarsavgiftOppgittGrunnlag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public VektarsavgiftOppgittGrunnlag VektarsavgiftOppgittGrunnlag { get; set; }

        [JsonProperty("avregistrertSidenDato", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? AvregistrertSidenDato { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Registreringsbegrensninger
    {
        [JsonProperty("registreringsbegrensning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<KodeverkType> Registreringsbegrensning { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Sitteplass
    {
        [JsonProperty("beltekraftbegrenser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Beltekraftbegrenser { get; set; }

        [JsonProperty("beltestrammer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Beltestrammer { get; set; }

        [JsonProperty("frontairbag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Frontairbag { get; set; }

        [JsonProperty("hodegardinairbag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hodegardinairbag { get; set; }

        [JsonProperty("kneairbag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kneairbag { get; set; }

        [JsonProperty("posisjon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Posisjon { get; set; }

        [JsonProperty("rad", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rad { get; set; }

        [JsonProperty("sideairbag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sideairbag { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class SitteplassListe
    {
        [JsonProperty("sitteplass", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Sitteplass> Sitteplass { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TekniskGodkjenning
    {
        [JsonProperty("godkjenningsId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string GodkjenningsId { get; set; }

        [JsonProperty("godkjenningsundertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Godkjenningsundertype { get; set; }

        [JsonProperty("gyldigFraDato", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? GyldigFraDato { get; set; }

        [JsonProperty("gyldigFraDatoTid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? GyldigFraDatoTid { get; set; }

        [JsonProperty("kjoretoyklassifisering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Kjoretoyklassifisering Kjoretoyklassifisering { get; set; }

        [JsonProperty("korreksjon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Korreksjon Korreksjon { get; set; }

        [JsonProperty("krav", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Krav> Krav { get; set; }

        [JsonProperty("tekniskeData", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TekniskeData TekniskeData { get; set; }

        [JsonProperty("unntak", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Unntak> Unntak { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TekniskKjoretoyIdentitet
    {
        [JsonProperty("kuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Kuid { get; set; }

        [JsonProperty("understellsbasertId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public UnderstellsbasertId UnderstellsbasertId { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TekniskeData
    {
        [JsonProperty("akslinger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AkselInfo Akslinger { get; set; }

        [JsonProperty("bremser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Bremse Bremser { get; set; }

        [JsonProperty("dekkOgFelg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DekkOgFelg DekkOgFelg { get; set; }

        [JsonProperty("dimensjoner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Dimensjoner Dimensjoner { get; set; }

        [JsonProperty("generelt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Generelt Generelt { get; set; }

        [JsonProperty("karosseriOgLasteplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KarosseriOgLasteplan KarosseriOgLasteplan { get; set; }

        [JsonProperty("miljodata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Miljodata Miljodata { get; set; }

        [JsonProperty("motorOgDrivverk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public MotorOgDrivverk MotorOgDrivverk { get; set; }

        [JsonProperty("ovrigeTekniskeData", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<OvrigeTekniskeData> OvrigeTekniskeData { get; set; }

        [JsonProperty("persontall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Persontall Persontall { get; set; }

        [JsonProperty("tilhengerkopling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Tilhengerkopling Tilhengerkopling { get; set; }

        [JsonProperty("vekter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Vekter Vekter { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tilhengerkopling
    {
        [JsonProperty("kopling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Kopling> Kopling { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Tilleggsgodkjenning
    {
        [JsonProperty("godkjenningstype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Godkjenningstype { get; set; }

        [JsonProperty("godkjentFra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? GodkjentFra { get; set; }

        [JsonProperty("godkjentFraDatoTid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? GodkjentFraDatoTid { get; set; }

        [JsonProperty("godkjentTil", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset? GodkjentTil { get; set; }

        [JsonProperty("godkjentTilDatoTid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? GodkjentTilDatoTid { get; set; }

        [JsonProperty("korreksjon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Korreksjon Korreksjon { get; set; }

        [JsonProperty("krav", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Krav> Krav { get; set; }

        [JsonProperty("tilleggsgodkjenningSpesifikkeData", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TilleggsgodkjenningSpesifikkeData TilleggsgodkjenningSpesifikkeData { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class TilleggsgodkjenningSpesifikkeData
    {
        [JsonProperty("adrGodkjenning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AdrGodkjenning AdrGodkjenning { get; set; }

        [JsonProperty("dyretransportGodkjenning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DyretransportGodkjenning DyretransportGodkjenning { get; set; }

        [JsonProperty("larevognGodkjenning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LarevognGodkjenning LarevognGodkjenning { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Typegodkjenningsnummer
    {
        [JsonProperty("direktiv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Direktiv { get; set; }

        [JsonProperty("land", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Land { get; set; }

        [JsonProperty("serie", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Serie { get; set; }

        [JsonProperty("utvidelse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Utvidelse { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UnderstellsbasertId
    {
        [JsonProperty("merkekode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Merkekode { get; set; }

        [JsonProperty("understellsnummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Understellsnummer { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UnderstellsnummerBulkResponse
    {
        [JsonProperty("gjenstaendeKvote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GjenstaendeKvote { get; set; }

        [JsonProperty("responser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<UnderstellsnummerResponse> Responser { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UnderstellsnummerResponse
    {
        [JsonProperty("feilmelding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        [JsonProperty("request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public UnderstellsnummerRequest Request { get; set; }

        [JsonProperty("kjoretoydataListe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<UnderstellsnummerTreffWrapper> KjoretoydataListe { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class UnderstellsnummerTreffWrapper
    {
        [JsonProperty("kjoretoydata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KjoretoyMedBegrensedeEieropplysninger Kjoretoydata { get; set; }

        [JsonProperty("feilmelding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Unntak
    {
        [JsonProperty("merknad", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Merknad { get; set; }

        [JsonProperty("unntak", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KodeverkType Unntak1 { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class VektOgBremse
    {
        [JsonProperty("bremseType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string BremseType { get; set; }

        [JsonProperty("vogntogvekt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Vogntogvekt { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class VektarsavgiftOppgittGrunnlag
    {
        [JsonProperty("antallAkslerTilhenger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AntallAkslerTilhenger { get; set; }

        [JsonProperty("totalvektTilhenger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalvektTilhenger { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Vekter
    {
        [JsonProperty("egenvekt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Egenvekt { get; set; }

        [JsonProperty("egenvektMaksimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EgenvektMaksimum { get; set; }

        [JsonProperty("egenvektMinimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EgenvektMinimum { get; set; }

        [JsonProperty("egenvektTilhengerkopling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EgenvektTilhengerkopling { get; set; }

        [JsonProperty("frontOgHjulVekter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string FrontOgHjulVekter { get; set; }

        [JsonProperty("nyttelast", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nyttelast { get; set; }

        [JsonProperty("tekniskTillattForhoyetTotalvekt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TekniskTillattForhoyetTotalvekt { get; set; }

        [JsonProperty("tekniskTillattTotalvekt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TekniskTillattTotalvekt { get; set; }

        [JsonProperty("tekniskTillattTotalvektVeg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TekniskTillattTotalvektVeg { get; set; }

        [JsonProperty("tekniskTillattVektPahengsvogn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TekniskTillattVektPahengsvogn { get; set; }

        [JsonProperty("tekniskTillattVektSemitilhenger", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TekniskTillattVektSemitilhenger { get; set; }

        [JsonProperty("tillattHjulLastSidevogn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TillattHjulLastSidevogn { get; set; }

        [JsonProperty("tillattTaklast", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TillattTaklast { get; set; }

        [JsonProperty("tillattTilhengervektMedBrems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TillattTilhengervektMedBrems { get; set; }

        [JsonProperty("tillattTilhengervektUtenBrems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TillattTilhengervektUtenBrems { get; set; }

        [JsonProperty("tillattTotalvekt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TillattTotalvekt { get; set; }

        [JsonProperty("tillattVektSlepevogn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TillattVektSlepevogn { get; set; }

        [JsonProperty("tillattVertikalKoplingslast", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TillattVertikalKoplingslast { get; set; }

        [JsonProperty("tillattVogntogvekt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TillattVogntogvekt { get; set; }

        [JsonProperty("tillattVogntogvektVeg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TillattVogntogvektVeg { get; set; }

        [JsonProperty("vogntogvektAvhBremsesystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<VektOgBremse> VogntogvektAvhBremsesystem { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class WLTP
    {
        [JsonProperty("co2EkstraHoy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Co2EkstraHoy { get; set; }

        [JsonProperty("co2Hoy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Co2Hoy { get; set; }

        [JsonProperty("co2Kombinert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Co2Kombinert { get; set; }

        [JsonProperty("co2Lav", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Co2Lav { get; set; }

        [JsonProperty("co2Middels", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Co2Middels { get; set; }

        [JsonProperty("co2VektetKombinert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Co2VektetKombinert { get; set; }

        [JsonProperty("forbrukEkstraHoy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ForbrukEkstraHoy { get; set; }

        [JsonProperty("forbrukHoy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ForbrukHoy { get; set; }

        [JsonProperty("forbrukKombinert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ForbrukKombinert { get; set; }

        [JsonProperty("forbrukLav", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ForbrukLav { get; set; }

        [JsonProperty("forbrukMiddels", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ForbrukMiddels { get; set; }

        [JsonProperty("forbrukVektetKombinert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? ForbrukVektetKombinert { get; set; }

        [JsonProperty("rekkeviddeKmBlandetkjoring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RekkeviddeKmBlandetkjoring { get; set; }

        [JsonProperty("rekkeviddeKmBykjoring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RekkeviddeKmBykjoring { get; set; }

        [JsonProperty("elEnergiforbruk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ElEnergiforbruk { get; set; }

        [JsonProperty("nedcForbrukBykjoring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? NedcForbrukBykjoring { get; set; }

        [JsonProperty("nedcForbrukLandeveiskjoring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? NedcForbrukLandeveiskjoring { get; set; }

        [JsonProperty("nedcForbrukBlandetKjoring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? NedcForbrukBlandetKjoring { get; set; }

        [JsonProperty("nedcCo2BykjoringGPrKm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? NedcCo2BykjoringGPrKm { get; set; }

        [JsonProperty("nedcCo2LandeveiskjoringGPrKm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? NedcCo2LandeveiskjoringGPrKm { get; set; }

        [JsonProperty("nedcCo2BlandetKjoringGPrKm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? NedcCo2BlandetKjoringGPrKm { get; set; }

        [JsonProperty("nedcVektetKombinertDrivstoffCo2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? NedcVektetKombinertDrivstoffCo2 { get; set; }

        [JsonProperty("nedcVektetKombinertDrivstoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? NedcVektetKombinertDrivstoff { get; set; }

        [JsonProperty("nedcEnergiforbruk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NedcEnergiforbruk { get; set; }

        [JsonProperty("nedcRekkeviddeKm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NedcRekkeviddeKm { get; set; }

        [JsonProperty("veilastkoeffisientf0", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Veilastkoeffisientf0 { get; set; }

        [JsonProperty("veilastkoeffisientf1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Veilastkoeffisientf1 { get; set; }

        [JsonProperty("veilastkoeffisientf2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Veilastkoeffisientf2 { get; set; }

        [JsonProperty("testmasse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Testmasse { get; set; }

        [JsonProperty("frontalareal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Frontalareal { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KuidRequest
    {
        /// <summary>
        /// Valgfri dato-tid - informasjonen som returneres er den som var gyldig på dette tidspunktet
        /// </summary>
        [JsonProperty("dtg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Dtg { get; set; }

        /// <summary>
        /// Kjøretøyets kuid
        /// </summary>
        [JsonProperty("kuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Kuid { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KuidBulkResponse
    {
        [JsonProperty("gjenstaendeKvote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GjenstaendeKvote { get; set; }

        [JsonProperty("responser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<KuidResponse> Responser { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KuidResponse
    {
        [JsonProperty("feilmelding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        [JsonProperty("request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KuidRequest Request { get; set; }

        [JsonProperty("kjoretoydata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KjoretoyMedBegrensedeEieropplysninger Kjoretoydata { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KjennemerkeRequest
    {
        /// <summary>
        /// Kjøretøyets kjennemerke eller personlige kjennemerke
        /// </summary>
        [JsonProperty("kjennemerke", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Kjennemerke { get; set; }

        /// <summary>
        /// Valgfri dato-tid - informasjonen som returneres er den som var gyldig på dette tidspunktet
        /// </summary>
        [JsonProperty("dtg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Dtg { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KjennemerkeBulkResponse
    {
        [JsonProperty("gjenstaendeKvote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GjenstaendeKvote { get; set; }

        [JsonProperty("responser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<KjennemerkeResponse> Responser { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KjennemerkeResponse
    {
        [JsonProperty("feilmelding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        [JsonProperty("request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KjennemerkeRequest Request { get; set; }

        [JsonProperty("kjoretoydata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KjoretoyMedBegrensedeEieropplysninger Kjoretoydata { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FodselsnummerRequest
    {
        /// <summary>
        /// Fodselsnummer til eier, medeier eller leasingtaker
        /// </summary>
        [JsonProperty("fodselsnummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fodselsnummer { get; set; }

        /// <summary>
        /// Etternavn til eier, medeier eller leasingtaker
        /// </summary>
        [JsonProperty("etternavn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Etternavn { get; set; }

        /// <summary>
        /// Valgfri dato-tid - informasjonen som returneres er den som var gyldig på dette tidspunktet
        /// </summary>
        [JsonProperty("dtg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Dtg { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FodselsnummerResponse
    {
        [JsonProperty("gjenstaendeKvote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GjenstaendeKvote { get; set; }

        [JsonProperty("feilmelding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        [JsonProperty("request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public FodselsnummerRequest Request { get; set; }

        [JsonProperty("kjoretoydataListe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<KjoretoydataWrapper> KjoretoydataListe { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Kjoretoy
    {
        [JsonProperty("kjoretoyId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KjoretoyIdentitetBegrenset KjoretoyId { get; set; }

        [JsonProperty("forstegangsregistrering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Forstegangsregistrering Forstegangsregistrering { get; set; }

        [JsonProperty("kjennemerke", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Kjennemerke> Kjennemerke { get; set; }

        [JsonProperty("registrering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Registrering Registrering { get; set; }

        [JsonProperty("godkjenning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Godkjenning Godkjenning { get; set; }

        [JsonProperty("periodiskKjoretoyKontroll", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PeriodiskKjoretoyKontroll PeriodiskKjoretoyKontroll { get; set; }

        [JsonProperty("eierskap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public EierskapBegrenset Eierskap { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KjoretoydataWrapper
    {
        [JsonProperty("kjoretoydata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Kjoretoy Kjoretoydata { get; set; }

        [JsonProperty("feilmelding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OrganisasjonsnummerRequest
    {
        /// <summary>
        /// Organisasjonsummeret til eier eller medeier
        /// </summary>
        [JsonProperty("organisasjonsnummer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Organisasjonsnummer { get; set; }

        /// <summary>
        /// Valgfri dato-tid - informasjonen som returneres er den som var gyldig på dette tidspunktet
        /// </summary>
        [JsonProperty("dtg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Dtg { get; set; }

        /// <summary>
        /// Sidenummer for paginering hvis søkeresultatet gir flere treff enn antall-parameteren, begynner på side 0
        /// </summary>
        [JsonProperty("side", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Side { get; set; }

        /// <summary>
        /// Antall treff som skal returneres per side
        /// </summary>
        [JsonProperty("antall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Antall { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class OrganisasjonsnummerResponse
    {
        [JsonProperty("gjenstaendeKvote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GjenstaendeKvote { get; set; }

        [JsonProperty("feilmelding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        [JsonProperty("request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public OrganisasjonsnummerRequest Request { get; set; }

        [JsonProperty("kjoretoydataListe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<KjoretoydataWrapper> KjoretoydataListe { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class EnkeltOppslagKjoretoydata
    {
        [JsonProperty("kjoretoyId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KjoretoyIdentitetBegrenset KjoretoyId { get; set; }

        [JsonProperty("forstegangsregistrering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Forstegangsregistrering Forstegangsregistrering { get; set; }

        [JsonProperty("kjennemerke", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<Kjennemerke> Kjennemerke { get; set; }

        [JsonProperty("registrering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Registrering Registrering { get; set; }

        [JsonProperty("godkjenning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Godkjenning Godkjenning { get; set; }

        [JsonProperty("periodiskKjoretoyKontroll", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PeriodiskKjoretoyKontroll PeriodiskKjoretoyKontroll { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class KjoretoydataResponse
    {
        [JsonProperty("feilmelding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Feilmelding { get; set; }

        [JsonProperty("kjoretoydataListe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<EnkeltOppslagKjoretoydata> KjoretoydataListe { get; set; }

        private IDictionary<string, object> _additionalProperties;

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum Kjennemerkekategori
    {

        [EnumMember(Value = @"KJORETOY")]
        KJORETOY = 0,

        [EnumMember(Value = @"NORMAL")]
        NORMAL = 1,

        [EnumMember(Value = @"PERSONLIG")]
        PERSONLIG = 2,

        [EnumMember(Value = @"PROVE")]
        PROVE = 3,

    }

    [GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    internal class DateFormatConverter : IsoDateTimeConverter
    {
        public DateFormatConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
