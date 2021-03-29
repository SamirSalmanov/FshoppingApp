﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Web.Models
{
    public enum OrderStatus
    {
        Placed = 1,
        Processing = 2,
        Delivered = 3,
        Failed = 4,
        Cancelled = 5,
        OnHold = 6,
        WaitingForPayment = 7,
        Refunded = 8
    }
}
