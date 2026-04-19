using System;
using System.Collections.Generic;

namespace EntityFrameWorkCore_DBFirst_4DBCommunication.hotelmanagementModels;

public partial class Customer
{
    public int? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? Email { get; set; }
}
