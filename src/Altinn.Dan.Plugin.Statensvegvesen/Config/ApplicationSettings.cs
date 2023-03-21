using System;

namespace Altinn.Dan.Plugin.Statensvegvesen.Config;

public class ApplicationSettings
{
    public string RedisConnectionString { get; set; }
    public TimeSpan BreakerRetryWaitTime { get; set; }
    public string SvvUrl { get; set; }
    public string SvvUsername { get; set; }
    public string SvvPassword { get; set; }

    public string SvvBilpleieKey { get; set; }

    public string SvvBilpleieUrl { get; set; }
}
