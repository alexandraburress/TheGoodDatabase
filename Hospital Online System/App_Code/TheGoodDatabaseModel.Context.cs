﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class TGDBEntities : DbContext
{
    public TGDBEntities()
        : base("name=TGDBEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<AppointmentTable> AppointmentTables { get; set; }
    public virtual DbSet<DepartmentTable> DepartmentTables { get; set; }
    public virtual DbSet<DoctorTable> DoctorTables { get; set; }
    public virtual DbSet<EmailTable> EmailTables { get; set; }
    public virtual DbSet<HospitalTable> HospitalTables { get; set; }
    public virtual DbSet<PatientTable> PatientTables { get; set; }
    public virtual DbSet<PrescriptionTable> PrescriptionTables { get; set; }
    public virtual DbSet<TestTable> TestTables { get; set; }
}
