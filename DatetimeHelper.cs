using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Kwetterr.Function
{
  public static class DateTimeHelper
  {
    /// <summary>
    /// Converts a given DateTime into a Unix timestamp
    /// </summary>
    /// <param name="value">Any DateTime</param>
    /// <returns>The given DateTime in Unix timestamp format</returns>
    public static long ToUnixTimestamp(this DateTime value)
    {
      return (long)(value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
    }

    /// <summary>
    /// Gets a Unix timestamp representing the current moment
    /// </summary>
    /// <param name="ignored">Parameter ignored</param>
    /// <returns>Now expressed as a Unix timestamp</returns>
    public static long UnixTimestamp(this DateTime ignored)
    {
      return (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
    }

    /// <summary>
    /// Returns a local DateTime based on provided unix timestamp
    /// </summary>
    /// <param name="timestamp">Unix/posix timestamp</param>
    /// <returns>Local datetime</returns>
    public static DateTime ParseUnixTimestamp(long timestamp)
    {
      return (new DateTime(1970, 1, 1)).AddSeconds(timestamp).ToLocalTime();
    }

    public static TimeResponse GetTimeDiff(double timeStamp)
    {
      var date = ParseUnixTimestamp((long)timeStamp);
      var diff = DateTimeOffset.Now.Subtract(date);
      return new TimeResponse
      {
        Days = diff.Days.ToString(),
        Hours = diff.Hours.ToString(),
        Minutes = diff.Minutes.ToString()
      };
    }
  }
}
