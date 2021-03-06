﻿using ArchitectBureauDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace ArchitectBureauDataAccess
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<ProjectType> ProjectTypes { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ProjectStatus> ProjectStatuses { get; set; }
    }
}