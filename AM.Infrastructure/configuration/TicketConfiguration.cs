﻿using AM.ApplicationCore.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.configuration
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => new { t.FlightFk, t.PassengerFk });
            builder.HasOne(t => t.Flight).WithMany(f => f.Tickets).HasForeignKey(t=>t.FlightFk);
            builder.HasOne(t => t.Passenger).WithMany(p => p.Tickets).HasForeignKey(t => t.PassengerFk);
        }
    }
}
