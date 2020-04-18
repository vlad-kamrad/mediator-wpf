﻿using System;

namespace Mediator.WPF.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
