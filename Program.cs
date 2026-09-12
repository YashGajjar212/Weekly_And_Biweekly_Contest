using Microsoft.AspNetCore.SignalR;
using Weekly_And_Biweekly_Contest.Biweekly_Contest;
using Weekly_And_Biweekly_Contest.Weekly_Contest;

var builder = WebApplication.CreateBuilder(args);

Weekly_Contest_515 weekly_Contest_515 = new Weekly_Contest_515();
//weekly_Contest_515.NearestDrone([[4, 4, 5]], [8, 6]);
//weekly_Contest_515.MaximumGap("aa", "aaaa");

Weekly_Contest_516 weekly_Contest_516 = new Weekly_Contest_516();
//weekly_Contest_516.FindDisappearedNumbers([567, 616, 615, 739], 613, 619);


Weekly_Contest_517 weekly_Contest_517 = new Weekly_Contest_517();
//weekly_Contest_517.CountSpecialIntegers([9, 62, 62, 75, 75, 75, 96, 96, 96, 96, 96, 96, 96, 96, 9, 9, 9, 9, 9, 75, 75, 75, 9, 9]);

Weekly_Contest_518 weekly_Contest_518 = new Weekly_Contest_518();
//weekly_Contest_518.CountRotations("aab", 1);
//weekly_Contest_518.CountGroups([1, 5, 6, 20], [4, 3, 2, 3], 1);

Biweekly_Contest_189 biweekly_Contest_189 = new Biweekly_Contest_189();
//biweekly_Contest_189.P1_ElevatorRequests(3, [2,0,0]);
//biweekly_Contest_189.P2_MinOperations("yb");
//biweekly_Contest_189.P4_ElevatorRequests(8, 3, [3,7,1]);

Biweekly_Contest_191 biweekly_Contest_191 = new Biweekly_Contest_191();
//biweekly_Contest_191.CountSpecialIntegers([8, 6, 6, 8, 8]);
biweekly_Contest_191.MinDays(9);

var app = builder.Build();
app.Run();