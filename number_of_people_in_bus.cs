using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int Number(List<int[]> peopleListInOut)
    {
        // Happy Coding
        // Going through each bus stop
        // People get on , and get off the bus
        // First stop gets 3 people added, 1 person gets off.
        // -1, +3
        var totalPeopleWentToTheBus = peopleListInOut.Aggregate(0, (acc, n) => acc += n[0]);
        var totalPeopleLeftTheBus = peopleListInOut.Aggregate(0, (acc, n) => acc += n[1]);
        
        
        return totalPeopleWentToTheBus - totalPeopleLeftTheBus;
    }
}