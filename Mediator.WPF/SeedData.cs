using Mediator.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator.WPF
{
    public static class SeedData
    {
        public static IList<User> Users;
        public static IList<Job> Jobs;

        static SeedData()
        {
            var now = DateTime.Now;

            Jobs = new List<Job> {
                new Job { Id = 1, Title = "Gogolya, 15A / Developing", StartDate = now, EndDate = now.AddDays(1) },
                new Job { Id = 2, Title = "Groove Street / Nothing", StartDate = now.AddDays(-5), EndDate = now.AddDays(5) },
                new Job { Id = 3, Title = "Gagarina 123 / Street sweeping", StartDate = now.AddDays(4), EndDate = now.AddDays(10) },
                new Job { Id = 4, Title = "Liberty Boulevard / Sale of leaflets", StartDate = now, EndDate = now.AddDays(15) }
            };

            Users = new List<User> {
                new User { Id = 1, Name = "Constantine", Jobs =  GetJobList(new int[] { 1, 2, 3, 4 }) },
                new User { Id = 2, Name = "Serhii", Jobs = GetJobList(new int[] { 3, 4 }) },
                new User { Id = 3, Name = "Nataliya", Jobs = GetJobList(new int[] { 1, 3 }) },
                new User { Id = 4, Name = "Olga", Jobs = GetJobList(new int[] { 3 }) },
                new User { Id = 5, Name = "Petr", Jobs = GetJobList(new int[] { 1, 2, 3 }) }
            };
        }

        private static List<Job> GetJobList(int[] ids) =>
            Jobs.Where(x => ids.Contains(x.Id)).ToList();

    }
}
