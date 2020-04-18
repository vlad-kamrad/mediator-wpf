using System.Collections.Generic;

namespace Mediator.WPF.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Job> Jobs { get; set; }
    }
}
