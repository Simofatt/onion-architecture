using Application.Interfaces.Services;
using Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    /* public class UniContext : AuditableContext
     {

         //private readonly ICurrentUserService _currentUserService;
         private readonly IDateTimeService _dateTimeService;

         public UniContext(DbContextOptions<UniContext> options,  IDateTimeService dateTimeService)
             : base(options)
         {

             _dateTimeService = dateTimeService;
         }


         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {


         }
         public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
         {
             foreach (var entry in ChangeTracker.Entries<IAuditableEntity>().ToList())
             {
                 switch (entry.State)
                 {
                     case EntityState.Added:
                         entry.Entity.CreatedOn = _dateTimeService.NowUtc;
                         entry.Entity.CreatedBy =1 ;
                         break;

                     case EntityState.Modified:
                         entry.Entity.LastModifiedOn = _dateTimeService.NowUtc;
                         entry.Entity.LastModifiedBy = 1;
                         break;
                 }
             }


                 return await base.SaveChangesAsync(_currentUserService.UserId, cancellationToken);

         }

     }
 }
    */
}