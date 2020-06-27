﻿using System;
using System.ComponentModel;

namespace Shared
{
    public class ConferenceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public string Location { get; set; }
        [DisplayName("Attendee Total")]
        public int AttendeeTotal { get; set; }
        public ConferenceModel()
        {
            Start = DateTime.Now;
        }
    }
}
