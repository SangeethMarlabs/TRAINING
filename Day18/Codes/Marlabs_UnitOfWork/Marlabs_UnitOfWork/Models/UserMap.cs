using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_UnitOfWork.Models
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(user => user.UserId);
            entityTypeBuilder.Property(user => user.UserName).IsRequired();
            entityTypeBuilder.Property(user => user.UserEmail).IsRequired();
            entityTypeBuilder.Property(user => user.UserContactNo).IsRequired();
            entityTypeBuilder.Property(user => user.UserAddress).IsRequired();

            entityTypeBuilder.Property(user => user.UserName).HasMaxLength(30);
            entityTypeBuilder.Property(user => user.UserContactNo).HasMaxLength(20);
            entityTypeBuilder.Property(user => user.UserAddress).HasMaxLength(50);
        }
    }
}
