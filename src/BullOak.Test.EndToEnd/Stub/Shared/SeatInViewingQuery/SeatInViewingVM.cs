﻿namespace BullOak.Test.EndToEnd.Stub.Shared.SeatInViewingQuery
{
    using System;

    public class SeatInViewingVM
    {
        public Guid ViewingId { get; set; }
        public int SeatNumber { get; set; }

        public bool IsReserved { get; set; }
    }
}
