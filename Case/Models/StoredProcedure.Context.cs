﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Case.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CaseEntitiesSP : DbContext
    {
        public CaseEntitiesSP()
            : base("name=CaseEntitiesSP")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<SP_CaseReport_Result> SP_CaseReport(Nullable<int> unvan, Nullable<int> departman, Nullable<System.DateTime> tarih)
        {
            var unvanParameter = unvan.HasValue ?
                new ObjectParameter("unvan", unvan) :
                new ObjectParameter("unvan", typeof(int));
    
            var departmanParameter = departman.HasValue ?
                new ObjectParameter("departman", departman) :
                new ObjectParameter("departman", typeof(int));
    
            var tarihParameter = tarih.HasValue ?
                new ObjectParameter("tarih", tarih) :
                new ObjectParameter("tarih", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CaseReport_Result>("SP_CaseReport", unvanParameter, departmanParameter, tarihParameter);
        }
    }
}
