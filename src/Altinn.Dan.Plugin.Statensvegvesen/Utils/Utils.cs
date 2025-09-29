using System;
using System.Collections.Generic;
using System.Linq;
using Altinn.Dan.Plugin.Brreg.Models;
using System.Threading.Tasks;
using Altinn.Dan.Plugin.Statensvegvesen.Clients;
using Altinn.Dan.Plugin.Statensvegvesen.Models;

namespace Altinn.Dan.Plugin.Statensvegvesen.Utils
{
    public static class OedUtils
    {
        public static SvvResponse MapToInternal(KjoretoysokResponse externalResponse)
        {
            var internalResponse = new SvvResponse { Vehicles = new List<Vehicle>() };
            if (externalResponse != null)
                foreach (var kjoretoyResponse in externalResponse.Kjoretoyresponser.Where(x=>x.Kjoretoy != null))
                {
                    var technicalApproval = kjoretoyResponse.Kjoretoy?.Godkjenning?.TekniskGodkjenning;
                    internalResponse.Vehicles.Add(new Vehicle
                    {
                        RegNr = kjoretoyResponse.Kjoretoy?.KjoretoyId?.Kjennemerke,
                        Brand = technicalApproval?.TekniskeData?.Generelt?.Merke?.FirstOrDefault()?.Merke1,
                        GroupName = technicalApproval?.Kjoretoyklassifisering?.TekniskKode?.KodeNavn,
                        GroupValue = technicalApproval?.Kjoretoyklassifisering?.TekniskKode?.KodeVerdi,
                        Model = technicalApproval?.TekniskeData?.Generelt?.Handelsbetegnelse?.FirstOrDefault(),
                        Owner = GetNameOfOwner(kjoretoyResponse),
                        CoOwner = GetNameOfCoOwner(kjoretoyResponse),
                        DeadlineEUApproval = kjoretoyResponse.Kjoretoy?.PeriodiskKjoretoyKontroll?.Kontrollfrist?.DateTime,
                        LatestEUApproval = kjoretoyResponse.Kjoretoy?.PeriodiskKjoretoyKontroll?.SistGodkjent?.DateTime,
                        RegistrationDate = kjoretoyResponse.Kjoretoy?.Forstegangsregistrering?.RegistrertForstegangNorgeDato?.DateTime,
                        Status = kjoretoyResponse.Kjoretoy?.Registrering?.Registreringsstatus?.KodeVerdi
                    });
                }

            return internalResponse;
        }

        private static string GetNameOfCoOwner(KjoretoyResponse kjoretoyResponse)
        {
            if (kjoretoyResponse.Kjoretoy?.Eierskap?.Medeier == null) return string.Empty;

            var firstnameOfCoOwner = kjoretoyResponse.Kjoretoy?.Eierskap?.Medeier?.Person?.Fornavn;
            var lastnameOfCoOwner = kjoretoyResponse.Kjoretoy?.Eierskap?.Medeier?.Person?.Etternavn;

            return FormatName(firstnameOfCoOwner, lastnameOfCoOwner);
        }

        private static string GetNameOfOwner(KjoretoyResponse kjoretoyResponse)
        {
            var firstnameOfOwner = kjoretoyResponse.Kjoretoy?.Eierskap?.Eier?.Person?.Fornavn;
            var lastnameOfOwner = kjoretoyResponse.Kjoretoy?.Eierskap?.Eier?.Person?.Etternavn;

            return FormatName(firstnameOfOwner, lastnameOfOwner);
        }

        private static string FormatName(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName)) return lastName;

            if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName)) return string.Empty;

            if (!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName)) return firstName;

            return $"{firstName} {lastName}";
        }
    }

    public static class DueDiligenceUtils
    {
        public static List<DueDiligenceVehicle> MapToExternal(OrganisasjonsnummerResponse sok, string orgno)
        {
            var result = new List<DueDiligenceVehicle>();

            foreach (var car in sok.KjoretoydataListe)
            {
                var vehicle = new DueDiligenceVehicle
                {
                    Leased = car.Kjoretoydata.Eierskap.Leasingtaker?.Enhet?.Organisasjonsnummer == orgno,
                    Brand = string.Join(",", car.Kjoretoydata.Godkjenning.TekniskGodkjenning.TekniskeData.Generelt.Merke.Select(x => x.Merke1)),
                    Number = car.Kjoretoydata.KjoretoyId.Kjennemerke,
                    Ownership = car.Kjoretoydata.Eierskap.Eier?.Enhet?.Organisasjonsnummer == orgno,
                    VehicleGroup = string.Join(",", car.Kjoretoydata.Kjennemerke.Select(x => x.Kjennemerketype.KodeNavn)),         //car.Kjoretoydata.Godkjenning.TekniskGodkjenning.Kjoretoyklassifisering.TekniskKode.KodeNavn,
                    LastPassedEUControl = car.Kjoretoydata.PeriodiskKjoretoyKontroll.SistGodkjent == null ? "" : car.Kjoretoydata.PeriodiskKjoretoyKontroll.SistGodkjent.ToString(),
                    FirstRegisteredDateTime = car.Kjoretoydata.Forstegangsregistrering.RegistrertForstegangNorgeDato.ToString(),
                    VIN = car.Kjoretoydata.KjoretoyId.Understellsnummer,
                    MileageRegisteredDateTime = "",
                    CO2 = car.Kjoretoydata.Godkjenning.TekniskGodkjenning.TekniskeData.Miljodata?.MiljoOgdrivstoffGruppe[0]?.ForbrukOgUtslipp[0]?.Co2BlandetKjoring,
                    EnvironmentClassification = string.Join(", ", car.Kjoretoydata.Godkjenning.TekniskGodkjenning?.TekniskeData?.Miljodata?.MiljoOgdrivstoffGruppe?.Select(x => x.DrivstoffKodeMiljodata.KodeNavn)),
                    FuelType = car.Kjoretoydata.Godkjenning.TekniskGodkjenning.TekniskeData.Miljodata?.EuroKlasse?.KodeVerdi?.ToString(),
                    GearBoxType = car.Kjoretoydata.Godkjenning.TekniskGodkjenning.TekniskeData.MotorOgDrivverk.Girkassetype?.KodeNavn,
                    Mileage = -1,
                    NOx = car.Kjoretoydata.Godkjenning.TekniskGodkjenning.TekniskeData.Miljodata.MiljoOgdrivstoffGruppe[0].ForbrukOgUtslipp[0].UtslippNOxMgPrKm,
                };

                result.Add(vehicle);
            }
            return result;
        }
    }
}

