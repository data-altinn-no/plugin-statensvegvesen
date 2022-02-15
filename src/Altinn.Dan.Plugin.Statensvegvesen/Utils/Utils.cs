using System.Collections.Generic;
using System.Linq;
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
                foreach (var kjoretoyResponse in externalResponse?.Kjoretoyresponser)
                {
                    var technicalApproval = kjoretoyResponse.Kjoretoy?.Godkjenning?.TekniskGodkjenning;
                    internalResponse.Vehicles.Add(new Vehicle
                    {
                        RegNr = kjoretoyResponse.Kjoretoy?.KjoretoyId?.Kjennemerke,
                        Brand = technicalApproval?.TekniskeData?.Generelt?.Merke?.First().Merke1,
                        GroupName = technicalApproval?.Kjoretoyklassifisering?.TekniskKode?.KodeNavn,
                        GroupValue = technicalApproval?.Kjoretoyklassifisering?.TekniskKode?.KodeVerdi,
                        Model = technicalApproval?.TekniskeData?.Generelt?.Handelsbetegnelse?.First(),
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
}
