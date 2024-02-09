﻿using System;
using System.Collections.Generic;

namespace ContosoPizzaContext.RE2.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime OrderPalced { get; set; }

    public DateTime? OrderFulfilled { get; set; }

    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
