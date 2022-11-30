using Newtonsoft.Json;
using SleeperAPI;
using SleeperAPI.Models;
using System.Net;
using System;
using RestSharp;

controller controller = new();
Console.WriteLine("Please enter the week you want to see the score for");

string weekNumber = Console.ReadLine();

controller.GetMatchUp(weekNumber);
