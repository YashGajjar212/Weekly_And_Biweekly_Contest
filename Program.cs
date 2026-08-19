using Microsoft.AspNetCore.SignalR;
using Weekly_And_Biweekly_Contest.Biweekly_Contest;
using Weekly_And_Biweekly_Contest.Weekly_Contest;

var builder = WebApplication.CreateBuilder(args);

Biweekly_Contest_189 biweekly_Contest_189 = new Biweekly_Contest_189();
//biweekly_Contest_189.P1_ElevatorRequests(3, [2,0,0]);
//biweekly_Contest_189.P2_MinOperations("yb");
//biweekly_Contest_189.P4_ElevatorRequests(8, 3, [3,7,1]);

Weekly_Contest_515 weekly_Contest_515 = new Weekly_Contest_515();
//weekly_Contest_515.NearestDrone([[4, 4, 5]], [8, 6]);
weekly_Contest_515.MaximumGap("aa", "aaaa");

var app = builder.Build();
app.Run();