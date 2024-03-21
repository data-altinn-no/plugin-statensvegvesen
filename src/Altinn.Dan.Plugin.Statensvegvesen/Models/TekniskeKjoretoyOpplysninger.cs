
using System;

public class TekniskeKjoretoyOpplysninger
{
    public int gjenstaendeKvote { get; set; }
    public string feilmelding { get; set; }
    public Request request { get; set; }
    public Kjoretoydataliste[] kjoretoydataListe { get; set; }
}

public class Request
{
    public string organisasjonsnummer { get; set; }
    public DateTime dtg { get; set; }
    public int side { get; set; }
    public int antall { get; set; }
}

public class Kjoretoydataliste
{
    public Kjoretoydata kjoretoydata { get; set; }
    public string feilmelding { get; set; }
}

public class Kjoretoydata
{
    public Kjoretoyid kjoretoyId { get; set; }
    public Forstegangsregistrering forstegangsregistrering { get; set; }
    public Kjennemerke[] kjennemerke { get; set; }
    public Registrering registrering { get; set; }
    public Godkjenning godkjenning { get; set; }
    public Periodiskkjoretoykontroll periodiskKjoretoyKontroll { get; set; }
    public Eierskap eierskap { get; set; }
}

public class Kjoretoyid
{
    public string kjennemerke { get; set; }
    public string understellsnummer { get; set; }
    public string kuid { get; set; }
}

public class Forstegangsregistrering
{
    public string registrertForstegangNorgeDato { get; set; }
}

public class Registrering
{
    public DateTime fomTidspunkt { get; set; }
    public Kjoringensart kjoringensArt { get; set; }
    public string neringskode { get; set; }
    public string neringskodeBeskrivelse { get; set; }
    public Registreringsstatus registreringsstatus { get; set; }
    public DateTime registrertForstegangPaEierskap { get; set; }
    public DateTime tilTidspunkt { get; set; }
    public Vektarsavgiftoppgittgrunnlag vektarsavgiftOppgittGrunnlag { get; set; }
    public DateTime avregistrertSidenDato { get; set; }
}

public class Kjoringensart
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Registreringsstatus
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Vektarsavgiftoppgittgrunnlag
{
    public int antallAkslerTilhenger { get; set; }
    public int totalvektTilhenger { get; set; }
}

public class Godkjenning
{
    public Forstegangsgodkjenning forstegangsGodkjenning { get; set; }
    public Kjoretoymerknad[] kjoretoymerknad { get; set; }
    public Registreringsbegrensninger registreringsbegrensninger { get; set; }
    public Tekniskgodkjenning tekniskGodkjenning { get; set; }
    public Tilleggsgodkjenninger[] tilleggsgodkjenninger { get; set; }
}

public class Forstegangsgodkjenning
{
    public Bruktimport bruktimport { get; set; }
    public string forstegangRegistrertDato { get; set; }
    public Fortollingogmva fortollingOgMva { get; set; }
    public string godkjenningsId { get; set; }
    public Godkjenningsundertype godkjenningsundertype { get; set; }
    public string gyldigFraDato { get; set; }
    public DateTime gyldigFraDatoTid { get; set; }
    public Kvalitetskodeforstegangregdato kvalitetskodeForstegangRegDato { get; set; }
    public Oppbygdmedavgiftsfritak oppbygdMedAvgiftsfritak { get; set; }
    public Unntak[] unntak { get; set; }
}

public class Bruktimport
{
    public Importland importland { get; set; }
    public int kilometerstand { get; set; }
    public string tidligereUtenlandskKjennemerke { get; set; }
    public string tidligereUtenlandskVognkortNummer { get; set; }
}

public class Importland
{
    public string landNavn { get; set; }
    public string landkode { get; set; }
}

public class Fortollingogmva
{
    public string annenReferanse { get; set; }
    public string beskrivelse { get; set; }
    public string dokumentreferanse { get; set; }
    public string fortollingsreferanse { get; set; }
    public int linje { get; set; }
}

public class Godkjenningsundertype
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Kvalitetskodeforstegangregdato
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Oppbygdmedavgiftsfritak
{
    public string[] arkivreferanse { get; set; }
    public Delekjoretoy[] delekjoretoy { get; set; }
    public Erstattetkjoretoy erstattetKjoretoy { get; set; }
}

public class Erstattetkjoretoy
{
    public string kuid { get; set; }
    public Understellsbasertid understellsbasertId { get; set; }
}

public class Understellsbasertid
{
    public string merkekode { get; set; }
    public string understellsnummer { get; set; }
}

public class Delekjoretoy
{
    public string kuid { get; set; }
    public Understellsbasertid1 understellsbasertId { get; set; }
}

public class Understellsbasertid1
{
    public string merkekode { get; set; }
    public string understellsnummer { get; set; }
}

public class Unntak
{
    public string[] merknad { get; set; }
    public Unntak1 unntak { get; set; }
}

public class Unntak1
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Registreringsbegrensninger
{
    public Registreringsbegrensning[] registreringsbegrensning { get; set; }
}

public class Registreringsbegrensning
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Tekniskgodkjenning
{
    public string godkjenningsId { get; set; }
    public Godkjenningsundertype1 godkjenningsundertype { get; set; }
    public string gyldigFraDato { get; set; }
    public DateTime gyldigFraDatoTid { get; set; }
    public Kjoretoyklassifisering kjoretoyklassifisering { get; set; }
    public Korreksjon korreksjon { get; set; }
    public Krav[] krav { get; set; }
    public Tekniskedata tekniskeData { get; set; }
    public Unntak2[] unntak { get; set; }
}

public class Godkjenningsundertype1
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Kjoretoyklassifisering
{
    public string beskrivelse { get; set; }
    public Eftypegodkjenning efTypegodkjenning { get; set; }
    public Kjoretoyavgiftskode kjoretoyAvgiftsKode { get; set; }
    public Nasjonalgodkjenning nasjonalGodkjenning { get; set; }
    public string spesielleKjennetegn { get; set; }
    public Tekniskkode tekniskKode { get; set; }
    public Tekniskunderkode tekniskUnderkode { get; set; }
    public bool iSamsvarMedTypegodkjenning { get; set; }
}

public class Eftypegodkjenning
{
    public string typegodkjenningNrTekst { get; set; }
    public Typegodkjenningnummer typegodkjenningnummer { get; set; }
    public string variant { get; set; }
    public string versjon { get; set; }
}

public class Typegodkjenningnummer
{
    public string direktiv { get; set; }
    public string land { get; set; }
    public string serie { get; set; }
    public string utvidelse { get; set; }
}

public class Kjoretoyavgiftskode
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Nasjonalgodkjenning
{
    public string nasjonaltGodkjenningsAr { get; set; }
    public string nasjonaltGodkjenningsHovednummer { get; set; }
    public string nasjonaltGodkjenningsUndernummer { get; set; }
}

public class Tekniskkode
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Tekniskunderkode
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Korreksjon
{
    public bool godkjenningErKorrigert { get; set; }
    public string virkningsdato { get; set; }
    public string[] felterEndret { get; set; }
}

public class Tekniskedata
{
    public Akslinger akslinger { get; set; }
    public Bremser bremser { get; set; }
    public Dekkogfelg dekkOgFelg { get; set; }
    public Dimensjoner dimensjoner { get; set; }
    public Generelt generelt { get; set; }
    public Karosserioglasteplan karosseriOgLasteplan { get; set; }
    public Miljodata miljodata { get; set; }
    public Motorogdrivverk motorOgDrivverk { get; set; }
    public Ovrigetekniskedata[] ovrigeTekniskeData { get; set; }
    public Persontall persontall { get; set; }
    public Tilhengerkopling tilhengerkopling { get; set; }
    public Vekter vekter { get; set; }
}

public class Akslinger
{
    public Akselgruppe[] akselGruppe { get; set; }
    public int antallAksler { get; set; }
    public Forbindelsemellomdrivaksler forbindelseMellomDrivaksler { get; set; }
}

public class Forbindelsemellomdrivaksler
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Akselgruppe
{
    public Akselliste akselListe { get; set; }
    public int egenvektAkselGruppe { get; set; }
    public int egenvektAkselGruppeMaks { get; set; }
    public int egenvektAkselGruppeMin { get; set; }
    public int fordelingAvTillattTotalvektAkselGruppeMaks { get; set; }
    public int fordelingAvTillattTotalvektAkselGruppeMin { get; set; }
    public int id { get; set; }
    public string plasseringAkselGruppe { get; set; }
    public int tekniskTillattAkselGruppeLast { get; set; }
    public int tekniskTillattAkselGruppeLastVeg { get; set; }
}

public class Akselliste
{
    public Aksel[] aksel { get; set; }
}

public class Aksel
{
    public int antallHjul { get; set; }
    public int avstandTilNesteAksling { get; set; }
    public bool belastbar { get; set; }
    public bool bremseAksel { get; set; }
    public bool drivAksel { get; set; }
    public int egenvektAksel { get; set; }
    public int egenvektAkselMaks { get; set; }
    public int egenvektAkselMin { get; set; }
    public int fordelingAvTillattTotalvektAkselMaks { get; set; }
    public int fordelingAvTillattTotalvektAkselMin { get; set; }
    public int id { get; set; }
    public bool loftbar { get; set; }
    public bool luftfjaering { get; set; }
    public int maksAvstandTilNesteAksling { get; set; }
    public int maksimalSporvidde { get; set; }
    public int minAvstandTilNesteAksling { get; set; }
    public int minimalSporvidde { get; set; }
    public string plasseringAksel { get; set; }
    public int sporvidde { get; set; }
    public bool styreAksel { get; set; }
    public int tekniskTillattAkselLast { get; set; }
    public int tekniskTillattAkselLastForhoyet { get; set; }
    public int tekniskTillattAkselLastVeg { get; set; }
}

public class Bremser
{
    public bool abs { get; set; }
    public string bremsesystem { get; set; }
    public string driftsbremsBak { get; set; }
    public string driftsbremsForan { get; set; }
    public string[] tilhengerBremseforbindelse { get; set; }
    public int trykkMeterledningTilhengerkopling { get; set; }
    public int trykktilsluttning1 { get; set; }
    public int trykktilsluttning2 { get; set; }
}

public class Dekkogfelg
{
    public Akseldekkogfelgkombinasjon[] akselDekkOgFelgKombinasjon { get; set; }
    public Dekkogfelgsidevogn dekkOgFelgSidevogn { get; set; }
}

public class Dekkogfelgsidevogn
{
    public string belastningskodeDekkSidevogn { get; set; }
    public string dekkdimensjonSidevogn { get; set; }
    public string felgdimensjonSidevogn { get; set; }
    public string hastighetskodeDekkSidevogn { get; set; }
    public string innpressSidevogn { get; set; }
}

public class Akseldekkogfelgkombinasjon
{
    public Akseldekkogfelg[] akselDekkOgFelg { get; set; }
    public int tillattTotalvektTraktor { get; set; }
}

public class Akseldekkogfelg
{
    public int akselId { get; set; }
    public string belastningskodeDekk { get; set; }
    public string belastningskodeDekkTraktor { get; set; }
    public string dekkdimensjon { get; set; }
    public string felgdimensjon { get; set; }
    public string hastighetskodeDekk { get; set; }
    public string innpress { get; set; }
    public int tillattAkselLastTraktor { get; set; }
    public bool tvilling { get; set; }
}

public class Dimensjoner
{
    public int bredde { get; set; }
    public int hoyde { get; set; }
    public int lengde { get; set; }
    public int lengdeInnvendigLasteplan { get; set; }
    public int maksimalBredde { get; set; }
    public int maksimalHoyde { get; set; }
    public int maksimalLengde { get; set; }
    public int maksimalLengdeInnvendigLasteplan { get; set; }
}

public class Generelt
{
    public Fabrikant[] fabrikant { get; set; }
    public string ferdigbyggetEllerEndretSomFolger { get; set; }
    public string[] handelsbetegnelse { get; set; }
    public Merke[] merke { get; set; }
    public Tekniskkode1 tekniskKode { get; set; }
    public Tekniskunderkode1 tekniskUnderkode { get; set; }
    public string typebetegnelse { get; set; }
    public string unntakFra { get; set; }
}

public class Tekniskkode1
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Tekniskunderkode1
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Fabrikant
{
    public string fabrikantAdresse { get; set; }
    public string fabrikantNavn { get; set; }
    public string fabrikantRepresentantAdresse { get; set; }
    public string fabrikantRepresentantNavn { get; set; }
}

public class Merke
{
    public string merke { get; set; }
    public string merkeKode { get; set; }
}

public class Karosserioglasteplan
{
    public int[] antallDorer { get; set; }
    public int avstandNavSkjermbueBak { get; set; }
    public int avstandNavSkjermbueForan { get; set; }
    public string bussKategori { get; set; }
    public string[] dorUtforming { get; set; }
    public string fargeFjar { get; set; }
    public string forankringSikkerhetsseler { get; set; }
    public string forervern { get; set; }
    public string forervernBoyle { get; set; }
    public string godkjentADR { get; set; }
    public bool hydrauliskLoft { get; set; }
    public string karosseriArt { get; set; }
    public Karosseritype karosseritype { get; set; }
    public Kjennemerketypebak kjennemerketypeBak { get; set; }
    public Kjennemerkestorrelsebak kjennemerkestorrelseBak { get; set; }
    public Kjennemerketypeforan kjennemerketypeForan { get; set; }
    public Kjennemerkestorrelseforan kjennemerkestorrelseForan { get; set; }
    public Kjennemerketypevenstre kjennemerketypeVenstre { get; set; }
    public Kjennemerkestorrelsevenstre kjennemerkestorrelseVenstre { get; set; }
    public string kjoringSide { get; set; }
    public string oppbygningUnderstellsnummer { get; set; }
    public int overhengBak { get; set; }
    public Pabyggskode pabyggsKode { get; set; }
    public string passasjerHandtak { get; set; }
    public Plasseringavdorer plasseringAvDorer { get; set; }
    public Plasseringfabrikasjonsplate[] plasseringFabrikasjonsplate { get; set; }
    public string plasseringMerkeplateTrimming { get; set; }
    public Plasseringunderstellsnummer[] plasseringUnderstellsnummer { get; set; }
    public Rfarge[] rFarge { get; set; }
    public string sikkerhetsseler { get; set; }
    public string styremekanismeArt { get; set; }
    public bool temperaturregulertSkap { get; set; }
    public bool vendbarForerplass { get; set; }
}

public class Karosseritype
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Kjennemerketypebak
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Kjennemerkestorrelsebak
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Kjennemerketypeforan
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Kjennemerkestorrelseforan
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Kjennemerketypevenstre
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Kjennemerkestorrelsevenstre
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Pabyggskode
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Plasseringavdorer
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Plasseringfabrikasjonsplate
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Plasseringunderstellsnummer
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Rfarge
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Miljodata
{
    public int co2BesparelsePgaOkoInnovasjon { get; set; }
    public Euroklasse euroKlasse { get; set; }
    public string lyddemperUtblas { get; set; }
    public Miljoogdrivstoffgruppe[] miljoOgdrivstoffGruppe { get; set; }
    public bool okoInnovasjon { get; set; }
    public string typeOkoInnovasjon { get; set; }
}

public class Euroklasse
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Miljoogdrivstoffgruppe
{
    public Drivstoffkodemiljodata drivstoffKodeMiljodata { get; set; }
    public Forbrukogutslipp[] forbrukOgUtslipp { get; set; }
    public Lyd lyd { get; set; }
}

public class Drivstoffkodemiljodata
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Lyd
{
    public int innvendigStoyniva { get; set; }
    public int kjorestoy { get; set; }
    public int standstoy { get; set; }
    public Stoymalingoppgittav stoyMalingOppgittAv { get; set; }
    public int vedAntallOmdreininger { get; set; }
}

public class Stoymalingoppgittav
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Forbrukogutslipp
{
    public int antallPartikler { get; set; }
    public int co2BlandetKjoring { get; set; }
    public int co2Bykjoring { get; set; }
    public int co2Landeveiskjoring { get; set; }
    public int coProsent { get; set; }
    public int elEnergiforbruk { get; set; }
    public int forbrukBlandetKjoring { get; set; }
    public int forbrukBykjoring { get; set; }
    public int forbrukLandeveiskjoring { get; set; }
    public Malemetode malemetode { get; set; }
    public string malemetodeAnnen { get; set; }
    public bool partikkelfilterFabrikkmontert { get; set; }
    public bool partikkelfilterUtslipp { get; set; }
    public int rekkeviddeKm { get; set; }
    public int utslippCOgPrKWh { get; set; }
    public int utslippCOmgPrKm { get; set; }
    public int utslippHCgPrKWh { get; set; }
    public int utslippHCgPrMin { get; set; }
    public int utslippHCmgPrKm { get; set; }
    public int utslippHCogNOxMgPrKm { get; set; }
    public int utslippKorrigertAbsorpsjonskoeffisient { get; set; }
    public int utslippNMHCmgPrKm { get; set; }
    public int utslippNOxGPrKWh { get; set; }
    public int utslippNOxMgPrKm { get; set; }
    public int utslippPartikkelAntallPrKm { get; set; }
    public int utslippPartiklerGPrKWh { get; set; }
    public int utslippPartiklerMgPrKm { get; set; }
    public int utslippTHCmgPrKm { get; set; }
    public int utslippTHCogNOxMgPrKm { get; set; }
    public int vektetKombinertDrivstoff { get; set; }
    public int vektetKombinertDrivstoffCO2 { get; set; }
    public Wltpkjoretoyspesifikk wltpKjoretoyspesifikk { get; set; }
    public Wltptypegodkjenningmaks wltpTypegodkjenningMaks { get; set; }
    public Wltptypegodkjenningmedium wltpTypegodkjenningMedium { get; set; }
    public Wltptypegodkjenningmin wltpTypegodkjenningMin { get; set; }
}

public class Malemetode
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Wltpkjoretoyspesifikk
{
    public int co2EkstraHoy { get; set; }
    public int co2Hoy { get; set; }
    public int co2Kombinert { get; set; }
    public int co2Lav { get; set; }
    public int co2Middels { get; set; }
    public int co2VektetKombinert { get; set; }
    public int forbrukEkstraHoy { get; set; }
    public int forbrukHoy { get; set; }
    public int forbrukKombinert { get; set; }
    public int forbrukLav { get; set; }
    public int forbrukMiddels { get; set; }
    public int forbrukVektetKombinert { get; set; }
    public int rekkeviddeKmBlandetkjoring { get; set; }
    public int rekkeviddeKmBykjoring { get; set; }
    public int elEnergiforbruk { get; set; }
    public int nedcForbrukBykjoring { get; set; }
    public int nedcForbrukLandeveiskjoring { get; set; }
    public int nedcForbrukBlandetKjoring { get; set; }
    public int nedcCo2BykjoringGPrKm { get; set; }
    public int nedcCo2LandeveiskjoringGPrKm { get; set; }
    public int nedcCo2BlandetKjoringGPrKm { get; set; }
    public int nedcVektetKombinertDrivstoffCo2 { get; set; }
    public int nedcVektetKombinertDrivstoff { get; set; }
    public int nedcEnergiforbruk { get; set; }
    public int nedcRekkeviddeKm { get; set; }
    public int veilastkoeffisientf0 { get; set; }
    public int veilastkoeffisientf1 { get; set; }
    public int veilastkoeffisientf2 { get; set; }
    public int testmasse { get; set; }
    public int frontalareal { get; set; }
}

public class Wltptypegodkjenningmaks
{
    public int co2EkstraHoy { get; set; }
    public int co2Hoy { get; set; }
    public int co2Kombinert { get; set; }
    public int co2Lav { get; set; }
    public int co2Middels { get; set; }
    public int co2VektetKombinert { get; set; }
    public int forbrukEkstraHoy { get; set; }
    public int forbrukHoy { get; set; }
    public int forbrukKombinert { get; set; }
    public int forbrukLav { get; set; }
    public int forbrukMiddels { get; set; }
    public int forbrukVektetKombinert { get; set; }
    public int rekkeviddeKmBlandetkjoring { get; set; }
    public int rekkeviddeKmBykjoring { get; set; }
    public int elEnergiforbruk { get; set; }
    public int nedcForbrukBykjoring { get; set; }
    public int nedcForbrukLandeveiskjoring { get; set; }
    public int nedcForbrukBlandetKjoring { get; set; }
    public int nedcCo2BykjoringGPrKm { get; set; }
    public int nedcCo2LandeveiskjoringGPrKm { get; set; }
    public int nedcCo2BlandetKjoringGPrKm { get; set; }
    public int nedcVektetKombinertDrivstoffCo2 { get; set; }
    public int nedcVektetKombinertDrivstoff { get; set; }
    public int nedcEnergiforbruk { get; set; }
    public int nedcRekkeviddeKm { get; set; }
    public int veilastkoeffisientf0 { get; set; }
    public int veilastkoeffisientf1 { get; set; }
    public int veilastkoeffisientf2 { get; set; }
    public int testmasse { get; set; }
    public int frontalareal { get; set; }
}

public class Wltptypegodkjenningmedium
{
    public int co2EkstraHoy { get; set; }
    public int co2Hoy { get; set; }
    public int co2Kombinert { get; set; }
    public int co2Lav { get; set; }
    public int co2Middels { get; set; }
    public int co2VektetKombinert { get; set; }
    public int forbrukEkstraHoy { get; set; }
    public int forbrukHoy { get; set; }
    public int forbrukKombinert { get; set; }
    public int forbrukLav { get; set; }
    public int forbrukMiddels { get; set; }
    public int forbrukVektetKombinert { get; set; }
    public int rekkeviddeKmBlandetkjoring { get; set; }
    public int rekkeviddeKmBykjoring { get; set; }
    public int elEnergiforbruk { get; set; }
    public int nedcForbrukBykjoring { get; set; }
    public int nedcForbrukLandeveiskjoring { get; set; }
    public int nedcForbrukBlandetKjoring { get; set; }
    public int nedcCo2BykjoringGPrKm { get; set; }
    public int nedcCo2LandeveiskjoringGPrKm { get; set; }
    public int nedcCo2BlandetKjoringGPrKm { get; set; }
    public int nedcVektetKombinertDrivstoffCo2 { get; set; }
    public int nedcVektetKombinertDrivstoff { get; set; }
    public int nedcEnergiforbruk { get; set; }
    public int nedcRekkeviddeKm { get; set; }
    public int veilastkoeffisientf0 { get; set; }
    public int veilastkoeffisientf1 { get; set; }
    public int veilastkoeffisientf2 { get; set; }
    public int testmasse { get; set; }
    public int frontalareal { get; set; }
}

public class Wltptypegodkjenningmin
{
    public int co2EkstraHoy { get; set; }
    public int co2Hoy { get; set; }
    public int co2Kombinert { get; set; }
    public int co2Lav { get; set; }
    public int co2Middels { get; set; }
    public int co2VektetKombinert { get; set; }
    public int forbrukEkstraHoy { get; set; }
    public int forbrukHoy { get; set; }
    public int forbrukKombinert { get; set; }
    public int forbrukLav { get; set; }
    public int forbrukMiddels { get; set; }
    public int forbrukVektetKombinert { get; set; }
    public int rekkeviddeKmBlandetkjoring { get; set; }
    public int rekkeviddeKmBykjoring { get; set; }
    public int elEnergiforbruk { get; set; }
    public int nedcForbrukBykjoring { get; set; }
    public int nedcForbrukLandeveiskjoring { get; set; }
    public int nedcForbrukBlandetKjoring { get; set; }
    public int nedcCo2BykjoringGPrKm { get; set; }
    public int nedcCo2LandeveiskjoringGPrKm { get; set; }
    public int nedcCo2BlandetKjoringGPrKm { get; set; }
    public int nedcVektetKombinertDrivstoffCo2 { get; set; }
    public int nedcVektetKombinertDrivstoff { get; set; }
    public int nedcEnergiforbruk { get; set; }
    public int nedcRekkeviddeKm { get; set; }
    public int veilastkoeffisientf0 { get; set; }
    public int veilastkoeffisientf1 { get; set; }
    public int veilastkoeffisientf2 { get; set; }
    public int testmasse { get; set; }
    public int frontalareal { get; set; }
}

public class Motorogdrivverk
{
    public int antallGir { get; set; }
    public int antallGirBakover { get; set; }
    public int effektKraftuttakKW { get; set; }
    public string girPlassering { get; set; }
    public Girkassetype girkassetype { get; set; }
    public string giroverforingsType { get; set; }
    public Girutvekslingprgir[] girutvekslingPrGir { get; set; }
    public bool hybridElektriskKjoretoy { get; set; }
    public Hybridkategori hybridKategori { get; set; }
    public int[] maksimumHastighet { get; set; }
    public int[] maksimumHastighetMalt { get; set; }
    public Motor[] motor { get; set; }
    public bool obd { get; set; }
    public int totalUtvekslingHoyesteGir { get; set; }
    public bool utelukkendeElektriskDrift { get; set; }
}

public class Girkassetype
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Hybridkategori
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Girutvekslingprgir
{
    public string girNummer { get; set; }
    public int girutveksling { get; set; }
}

public class Motor
{
    public int antallSylindre { get; set; }
    public Arbeidsprinsipp arbeidsprinsipp { get; set; }
    public bool avgassResirkulering { get; set; }
    public string blandingsDrivstoff { get; set; }
    public Drivstoff[] drivstoff { get; set; }
    public string fabrikant { get; set; }
    public bool fordampningsutslippKontrollSystem { get; set; }
    public bool katalysator { get; set; }
    public string kjolesystem { get; set; }
    public bool ladeluftkjoler { get; set; }
    public bool luftInnsproytning { get; set; }
    public string motorKode { get; set; }
    public string motorNummer { get; set; }
    public bool oksygenSensor { get; set; }
    public bool overladet { get; set; }
    public bool partikkelfilterMotor { get; set; }
    public int slagvolum { get; set; }
    public Sylinderarrangement sylinderArrangement { get; set; }
}

public class Arbeidsprinsipp
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Sylinderarrangement
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Drivstoff
{
    public Drivstoffkode drivstoffKode { get; set; }
    public double effektVektForhold { get; set; }
    public double maksEffektPrTime { get; set; }
    public double maksNettoEffekt { get; set; }
    public double maksNettoEffektVedOmdreiningstallMin1 { get; set; }
    public double maksNettoEffektVedOmdreiningstallMin1Maks { get; set; }
    public double maksOmdreining { get; set; }
    public double spenning { get; set; }
    public double tomgangsOmdreiningstall { get; set; }
}

public class Drivstoffkode
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Persontall
{
    public int bareplasser { get; set; }
    public int rullestolplasser { get; set; }
    public Sitteplassliste sitteplassListe { get; set; }
    public int sitteplasserForan { get; set; }
    public int sitteplasserNede { get; set; }
    public int sitteplasserOppe { get; set; }
    public int sitteplasserStillstand { get; set; }
    public int sitteplasserTotalt { get; set; }
    public int sitteplasserTotaltSomVarebilKlasse2 { get; set; }
    public int staplasser { get; set; }
}

public class Sitteplassliste
{
    public Sitteplass[] sitteplass { get; set; }
}

public class Sitteplass
{
    public bool beltekraftbegrenser { get; set; }
    public bool beltestrammer { get; set; }
    public bool frontairbag { get; set; }
    public bool hodegardinairbag { get; set; }
    public bool kneairbag { get; set; }
    public string posisjon { get; set; }
    public int rad { get; set; }
    public bool sideairbag { get; set; }
}

public class Tilhengerkopling
{
    public Kopling[] kopling { get; set; }
}

public class Kopling
{
    public int avstandFremstePktTilSenterKopling { get; set; }
    public int avstandSenterKoplingTilBakerstePkt { get; set; }
    public int avstandSenterKoplingTilForsteAksel { get; set; }
    public int avstandSisteAkselTilKingpinMaks { get; set; }
    public int avstandSisteAkselTilKingpinMin { get; set; }
    public int avstandSisteAkselTilSenterKopling { get; set; }
    public int belastningDverdi { get; set; }
    public int belastningLoddrettMaks { get; set; }
    public int belastningSverdi { get; set; }
    public int belastningUverdi { get; set; }
    public int belastningVannrettMaks { get; set; }
    public int belastningVverdi { get; set; }
    public string eftype { get; set; }
    public string fabrikantKopling { get; set; }
    public string handelsbetegnelseKopling { get; set; }
    public Type type { get; set; }
}

public class Type
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Vekter
{
    public int egenvekt { get; set; }
    public int egenvektMaksimum { get; set; }
    public int egenvektMinimum { get; set; }
    public int egenvektTilhengerkopling { get; set; }
    public string frontOgHjulVekter { get; set; }
    public int nyttelast { get; set; }
    public int tekniskTillattForhoyetTotalvekt { get; set; }
    public int tekniskTillattTotalvekt { get; set; }
    public int tekniskTillattTotalvektVeg { get; set; }
    public int tekniskTillattVektPahengsvogn { get; set; }
    public int tekniskTillattVektSemitilhenger { get; set; }
    public int tillattHjulLastSidevogn { get; set; }
    public int tillattTaklast { get; set; }
    public int tillattTilhengervektMedBrems { get; set; }
    public int tillattTilhengervektUtenBrems { get; set; }
    public int tillattTotalvekt { get; set; }
    public int tillattVektSlepevogn { get; set; }
    public int tillattVertikalKoplingslast { get; set; }
    public int tillattVogntogvekt { get; set; }
    public int tillattVogntogvektVeg { get; set; }
    public Vogntogvektavhbremsesystem[] vogntogvektAvhBremsesystem { get; set; }
}

public class Vogntogvektavhbremsesystem
{
    public string bremseType { get; set; }
    public int vogntogvekt { get; set; }
}

public class Ovrigetekniskedata
{
    public int datafeltIndeks { get; set; }
    public string datafeltNavn { get; set; }
    public string datafeltVerdi { get; set; }
}

public class Krav
{
    public Kravomrade kravomrade { get; set; }
    public Kravoppfyllelse kravoppfyllelse { get; set; }
    public string vognkortmerknad { get; set; }
}

public class Kravomrade
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Kravoppfyllelse
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Unntak2
{
    public string[] merknad { get; set; }
    public Unntak3 unntak { get; set; }
}

public class Unntak3
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Kjoretoymerknad
{
    public string merknad { get; set; }
    public string merknadtypeKode { get; set; }
}

public class Tilleggsgodkjenninger
{
    public Godkjenningstype godkjenningstype { get; set; }
    public string godkjentFra { get; set; }
    public DateTime godkjentFraDatoTid { get; set; }
    public string godkjentTil { get; set; }
    public DateTime godkjentTilDatoTid { get; set; }
    public Korreksjon1 korreksjon { get; set; }
    public Krav1[] krav { get; set; }
    public Tilleggsgodkjenningspesifikkedata tilleggsgodkjenningSpesifikkeData { get; set; }
}

public class Godkjenningstype
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Korreksjon1
{
    public bool godkjenningErKorrigert { get; set; }
    public string virkningsdato { get; set; }
    public string[] felterEndret { get; set; }
}

public class Tilleggsgodkjenningspesifikkedata
{
    public Adrgodkjenning adrGodkjenning { get; set; }
    public Dyretransportgodkjenning dyretransportGodkjenning { get; set; }
    public Larevogngodkjenning larevognGodkjenning { get; set; }
}

public class Adrgodkjenning
{
    public string adrAnmerkninger { get; set; }
    public string adrAttestnummer { get; set; }
    public Adrbeskyttelseoverlastbarerkode adrBeskyttelseOverLastbarerKode { get; set; }
    public string adrEX2EX3GodkjentGods { get; set; }
    public bool adrKjoretoyLukket { get; set; }
    public bool adrNasjonaleKrav { get; set; }
    public Adrpabyggtypekode adrPabyggTypeKode { get; set; }
    public Adrtanktekniskedata adrTankTekniskeData { get; set; }
    public bool adrTidligereBestemmelser { get; set; }
    public string adrTilleggsbremsEffekt { get; set; }
    public bool adrTilleggsbremsIkkeAktuelt { get; set; }
    public string adrTransportorAdresse { get; set; }
    public string adrTransportorNavn { get; set; }
    public string adrTransportorPostnrSted { get; set; }
    public string[] adrTypeKode { get; set; }
    public string adrVekselbyggID { get; set; }
    public string adrVekselbyggIDFra { get; set; }
    public string adrVekselbyggIDTil { get; set; }
}

public class Adrbeskyttelseoverlastbarerkode
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Adrpabyggtypekode
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Adrtanktekniskedata
{
    public int adrTankAntallRom { get; set; }
    public string adrTankFabrikat { get; set; }
    public string adrTankGodkjenningsnummer { get; set; }
    public Adrtankgodkjentgod[] adrTankGodkjentGods { get; set; }
    public Adrtankinndeling adrTankInndeling { get; set; }
    public string adrTankKode { get; set; }
    public bool adrTankKofferdam { get; set; }
    public bool adrTankLos { get; set; }
    public string adrTankNesteTetthetsproveDato { get; set; }
    public string adrTankNesteTrykkproveDato { get; set; }
    public string adrTankOverflyttetFra { get; set; }
    public int adrTankProduksjonsAr { get; set; }
    public string adrTankSerienummer { get; set; }
    public string adrTankSpesielleBestemmelser { get; set; }
    public int adrTankVolum { get; set; }
}

public class Adrtankinndeling
{
    public int[] adrTankInndelingVolum { get; set; }
}

public class Adrtankgodkjentgod
{
    public string adrTankGodkjentFor { get; set; }
    public bool adrTankStofferIhhtTankkode { get; set; }
}

public class Dyretransportgodkjenning
{
    public bool fornyelse { get; set; }
    public int gulvareal { get; set; }
    public Hestetransporttype hestetransporttype { get; set; }
    public int takhoyde { get; set; }
}

public class Hestetransporttype
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Larevogngodkjenning
{
    public Forekortklasser forekortklasser { get; set; }
    public Larevogn larevogn { get; set; }
}

public class Forekortklasser
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Larevogn
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Krav1
{
    public Kravomrade1 kravomrade { get; set; }
    public Kravoppfyllelse1 kravoppfyllelse { get; set; }
    public string vognkortmerknad { get; set; }
}

public class Kravomrade1
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Kravoppfyllelse1
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}

public class Periodiskkjoretoykontroll
{
    public string kontrollfrist { get; set; }
    public string sistGodkjent { get; set; }
}

public class Eierskap
{
    public Eier eier { get; set; }
    public Leasingtaker leasingtaker { get; set; }
    public Medeier medeier { get; set; }
    public Underenhet underenhet { get; set; }
    public DateTime vedtakstidspunkt { get; set; }
}

public class Eier
{
    public Adresse adresse { get; set; }
    public Enhet enhet { get; set; }
    public DateTime fomTidspunkt { get; set; }
    public Person person { get; set; }
    public DateTime tilTidspunkt { get; set; }
}

public class Adresse
{
    public string adresselinje1 { get; set; }
    public string adresselinje2 { get; set; }
    public string adresselinje3 { get; set; }
    public string kommunenavn { get; set; }
    public string kommunenummer { get; set; }
    public string land { get; set; }
    public string landkode { get; set; }
    public string postnummer { get; set; }
    public string poststed { get; set; }
}

public class Enhet
{
    public string organisasjonsnavn { get; set; }
    public string organisasjonsnummer { get; set; }
}

public class Person
{
    public string etternavn { get; set; }
    public string fodselsdato { get; set; }
    public string fornavn { get; set; }
    public string mellomnavn { get; set; }
}

public class Leasingtaker
{
    public Adresse1 adresse { get; set; }
    public Enhet1 enhet { get; set; }
    public DateTime fomTidspunkt { get; set; }
    public Person1 person { get; set; }
    public DateTime tilTidspunkt { get; set; }
}

public class Adresse1
{
    public string adresselinje1 { get; set; }
    public string adresselinje2 { get; set; }
    public string adresselinje3 { get; set; }
    public string kommunenavn { get; set; }
    public string kommunenummer { get; set; }
    public string land { get; set; }
    public string landkode { get; set; }
    public string postnummer { get; set; }
    public string poststed { get; set; }
}

public class Enhet1
{
    public string organisasjonsnavn { get; set; }
    public string organisasjonsnummer { get; set; }
}

public class Person1
{
    public string etternavn { get; set; }
    public string fodselsdato { get; set; }
    public string fornavn { get; set; }
    public string mellomnavn { get; set; }
}

public class Medeier
{
    public Adresse2 adresse { get; set; }
    public Enhet2 enhet { get; set; }
    public DateTime fomTidspunkt { get; set; }
    public Person2 person { get; set; }
    public DateTime tilTidspunkt { get; set; }
}

public class Adresse2
{
    public string adresselinje1 { get; set; }
    public string adresselinje2 { get; set; }
    public string adresselinje3 { get; set; }
    public string kommunenavn { get; set; }
    public string kommunenummer { get; set; }
    public string land { get; set; }
    public string landkode { get; set; }
    public string postnummer { get; set; }
    public string poststed { get; set; }
}

public class Enhet2
{
    public string organisasjonsnavn { get; set; }
    public string organisasjonsnummer { get; set; }
}

public class Person2
{
    public string etternavn { get; set; }
    public string fodselsdato { get; set; }
    public string fornavn { get; set; }
    public string mellomnavn { get; set; }
}

public class Underenhet
{
    public Adresse3 adresse { get; set; }
    public Enhet3 enhet { get; set; }
    public DateTime fomTidspunkt { get; set; }
    public Person3 person { get; set; }
    public DateTime tilTidspunkt { get; set; }
}

public class Adresse3
{
    public string adresselinje1 { get; set; }
    public string adresselinje2 { get; set; }
    public string adresselinje3 { get; set; }
    public string kommunenavn { get; set; }
    public string kommunenummer { get; set; }
    public string land { get; set; }
    public string landkode { get; set; }
    public string postnummer { get; set; }
    public string poststed { get; set; }
}

public class Enhet3
{
    public string organisasjonsnavn { get; set; }
    public string organisasjonsnummer { get; set; }
}

public class Person3
{
    public string etternavn { get; set; }
    public string fodselsdato { get; set; }
    public string fornavn { get; set; }
    public string mellomnavn { get; set; }
}

public class Kjennemerke
{
    public DateTime fomTidspunkt { get; set; }
    public string kjennemerke { get; set; }
    public string kjennemerkekategori { get; set; }
    public Kjennemerketype kjennemerketype { get; set; }
    public DateTime tilTidspunkt { get; set; }
}

public class Kjennemerketype
{
    public string kodeBeskrivelse { get; set; }
    public string kodeNavn { get; set; }
    public string kodeTypeId { get; set; }
    public string kodeVerdi { get; set; }
    public string[] tidligereKodeVerdi { get; set; }
}
