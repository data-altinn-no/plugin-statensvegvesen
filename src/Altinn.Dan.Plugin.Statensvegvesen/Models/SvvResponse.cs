using System;
using System.Collections.Generic;

namespace Altinn.Dan.Plugin.Statensvegvesen.Models;

public class SvvResponse
{
    public List<Vehicle> Vehicles { get; set; }
}

public class Vehicle
{
    public string RegNr { get; set; }
    public string Brand { get; set; }
    public string GroupName { get; set; }
    public string GroupValue { get; set; }
    public string Model { get; set; }
    public string Owner { get; set; }
    public DateTime? LatestEUApproval { get; set; }
    public DateTime? DeadlineEUApproval { get; set; }
    public string CoOwner { get; set; }
    public DateTime? RegistrationDate { get; set; }
    public string Status { get; set; }
}
