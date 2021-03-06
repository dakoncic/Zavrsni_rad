﻿using ModelsLayer.DatabaseEntities;
using System.Collections.Generic;

namespace ModelsLayer.Identity
{
    public class NewsEventModel
    {
        public List<Event> CreatedEvents { get; set; }
        public List<ChangedEvent> ChangedEvents { get; set; }
        public List<DeletedEvent> DeletedEvents { get; set; }
    }
}
