using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PetSync.Models;

namespace PetSync.Actions
{
  public static class HouseholdActions
  {
    private static readonly List<Household> households = new List<Household>();

    [FunctionName("NewHousehold")]
    public static async Task<IActionResult> CreateHousehold(
      [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]HttpRequest req, ILogger log)
    {
      var household = new Household() { name = "Cassidy" };
      households.Add(household);
      return new OkObjectResult(household);
    }

    [FunctionName("NewUser")]
    public static async Task<IActionResult> NewUser(
      [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]HttpRequest req, ILogger log)
    {
      var user = new User() { name = "Eric" };
      if (households.Count == 1)
      {
        households[0].users.Add(user);
      }
      return new OkObjectResult(user);
    }

    [FunctionName("NewPet")]
    public static async Task<IActionResult> NewPet(
      [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]HttpRequest req, ILogger log)
    {
      var pet = new Pet() { name = "Zoe" };
      if (households.Count == 1)
      {
        households[0].pets.Add(pet);
      }
      return new OkObjectResult(pet);
    }

    [FunctionName("GivePetFood")]
    public static async Task<IActionResult> GivePetFood(
      [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]HttpRequest req, ILogger log)
    {
      var feedEvent = new FeedEvent() {
        amount = 1,
        um = "cup"
      };
      if (households.Count == 1 && households[0].pets.Count > 0)
      {
        var pet = households[0].pets[0];
        pet.events.Add(feedEvent);
      }
      return new OkObjectResult(feedEvent);
    }

    [FunctionName("GivePetSupplement")]
    public static async Task<IActionResult> GivePetSupplement(
      [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]HttpRequest req, ILogger log)
    {
      var feedEvent = new FeedEvent() {
        name = "Supplement",
        amount = 1,
        um = ""
      };
      if (households.Count == 1 && households[0].pets.Count > 0)
      {
        var pet = households[0].pets[0];
        pet.events.Add(feedEvent);
      }
      return new OkObjectResult(feedEvent);
    }

    [FunctionName("GetHousehold")]
    public static async Task<IActionResult> GetHousehold(
      [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]HttpRequest req, ILogger log)
    {
      var household = new Household();
      if (households.Count == 1)
      {
        household = households[0];
      }
      return new OkObjectResult(household);
    }
  }
}