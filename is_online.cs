using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static Dictionary<UserStatus, IEnumerable<string>> WhosOnline(User[] friends)
    {
        // Handle empty input array by returning an empty dictionary
        if (friends == null || friends.Length == 0)
        {
            return new Dictionary<UserStatus, IEnumerable<string>>();
        }

        return friends
            .Select(f => new 
            {
                Username = f.Username,
                // Remap 'Online' users to 'Away' if they've been inactive for more than 10 minutes
                CalculatedStatus = (f.Status == UserStatus.Online && f.LastActivity > 10) 
                                    ? UserStatus.Away 
                                    : f.Status
            })
            .GroupBy(f => f.CalculatedStatus)
            .ToDictionary(
                group => group.Key,
                group => group.Select(f => f.Username)
            );
    }
}