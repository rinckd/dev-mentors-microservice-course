using System;
using System.Collections;
using System.Collections.Generic;
using Convey.Types;

namespace Pacco.Services.Availability.Infrastructure.Mongo.Documents
{
    internal sealed class ResourceDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public IEnumerable<string> Tags { get; set; }
        
        public IEnumerable<ReservationDocument> Reservations { get; set; }
    }
    internal sealed class ReservationDocument
    {
        public int TimeStamp { get; set; }
        public int Priority { get; set; }
        
    }
}