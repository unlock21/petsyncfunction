using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace PetSync.Actions
{
  public static class ScheduledTasks
  {
    [FunctionName("ClearPetFeedSchedule")]
    public static void Run([TimerTrigger("0 0 4 * * *")] TimerInfo myTimer, ILogger log)
    {
      HouseholdActions.ClearEvents();
      log.LogInformation($"Events cleared at: {DateTime.Now}");
    }
  }
}
