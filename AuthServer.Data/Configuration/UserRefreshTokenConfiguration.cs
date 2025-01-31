﻿using AuthServer.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Data.Configuration
{
    /*
     * AppDbContext sınıfında bulunan OnModelCreating methodunda bu sınıfın kullanılabilmesi için ProductConfiguration sınıfı IEntityTypeConfiguration interface 
     * inden miras almaktadır
     * 
     */
    public class UserRefreshTokenConfiguration : IEntityTypeConfiguration<UserRefreshToken>
    {
        public void Configure(EntityTypeBuilder<UserRefreshToken> builder)
        {
            builder.HasKey(x => x.UserId);

            builder.Property(x => x.RefreshTokenCode).IsRequired().HasMaxLength(200);
        }
    }
}
