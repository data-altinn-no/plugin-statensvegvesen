using System;
using System.Collections.Generic;
using System.IO;
using Altinn.Dan.Plugin.Statensvegvesen.Clients;
using Altinn.Dan.Plugin.Statensvegvesen.Test.TestUtils;
using Altinn.Dan.Plugin.Statensvegvesen.Utils;
using Newtonsoft.Json;
using Xunit;

namespace Altinn.Dan.Plugin.Statensvegvesen.Test.Utils;

public class UtilsTest
{
    [Fact]
    public void MapToInternal_ok()
    {
        var kjoretoysokResponse = TestHelpers.LoadJson<KjoretoysokResponse>("KjoretoysokResponse_from_svv.json");
        var svvResponse = OedUtils.MapToInternal(kjoretoysokResponse);

        Assert.Equal("CU 10942", svvResponse.Vehicles[0].RegNr);
        Assert.Equal("MITSUBISHI", svvResponse.Vehicles[0].Brand);
        Assert.Equal("Personbil", svvResponse.Vehicles[0].GroupName);
        Assert.Equal("M1", svvResponse.Vehicles[0].GroupValue);
        Assert.Equal("Mitsubishi Outlander", svvResponse.Vehicles[0].Model);
        Assert.Equal("HELGE KROKEN", svvResponse.Vehicles[0].Owner);
        Assert.Equal(new DateTime(2023, 4, 15), svvResponse.Vehicles[0].LatestEUApproval);
        Assert.Equal(new DateTime(2025, 4, 21), svvResponse.Vehicles[0].DeadlineEUApproval);
        Assert.Equal("JARLE BERGER", svvResponse.Vehicles[0].CoOwner);
        Assert.Equal(new DateTime(2021, 4, 21), svvResponse.Vehicles[0].RegistrationDate);
        Assert.Equal("REGISTRERT", svvResponse.Vehicles[0].Status);

        Assert.Equal("EC 80261", svvResponse.Vehicles[1].RegNr);
        Assert.Equal("TESLA MOTORS", svvResponse.Vehicles[1].Brand);
        Assert.Equal("Personbil", svvResponse.Vehicles[1].GroupName);
        Assert.Equal("M1", svvResponse.Vehicles[1].GroupValue);
        Assert.Equal("Model X", svvResponse.Vehicles[1].Model);
        Assert.Equal("JARLE BERGER", svvResponse.Vehicles[1].Owner);
        Assert.Null(svvResponse.Vehicles[1].LatestEUApproval);
        Assert.Equal(new DateTime(2025, 4, 21), svvResponse.Vehicles[1].DeadlineEUApproval);
        Assert.Empty(svvResponse.Vehicles[1].CoOwner);
        Assert.Equal(new DateTime(2021, 4, 21), svvResponse.Vehicles[1].RegistrationDate);
        Assert.Equal("REGISTRERT", svvResponse.Vehicles[1].Status);
    }
}
