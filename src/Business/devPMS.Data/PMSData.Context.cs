﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace devPMS.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<GroupTeam> GroupTeams { get; set; }
        public virtual DbSet<Project_Log> Project_Logs { get; set; }
        public virtual DbSet<ScopeOfService> ScopeOfServices { get; set; }
        public virtual DbSet<ScopeType> ScopeTypes { get; set; }
        public virtual DbSet<TimeLog> TimeLogs { get; set; }
        public virtual DbSet<TimeLogView> TimeLogViews { get; set; }
        public virtual DbSet<ViewApprovedVacationPerDate> ViewApprovedVacationPerDates { get; set; }
        public virtual DbSet<SubTask> SubTasks { get; set; }
        public virtual DbSet<ViewTimeLogPerDate> ViewTimeLogPerDates { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ProjectComment> ProjectComments { get; set; }
        public virtual DbSet<Status> Status { get; set; }
    }
}
