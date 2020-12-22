using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
  public static class ClearPetFeedSchedule
  {
    [FunctionName("ClearPetFeedSchedule")]
    public static void Run([TimerTrigger("0 0 4 * * *")] TimerInfo myTimer, ILogger log)
    {
      // FOREACH HOUSEHOLD
      // FOREACH PET
      // RESET TODAY
      // THISWEEK = QUERY(FEEDEVENT[](PETID) AND INTHISWEEK()
      log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
    }
  }
}
