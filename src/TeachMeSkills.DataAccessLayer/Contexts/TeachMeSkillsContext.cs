﻿using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeachMeSkills.DataAccessLayer.Configurations;
using TeachMeSkills.DataAccessLayer.Entities;

namespace TeachMeSkills.DataAccessLayer.Contexts
{
    /// <summary>
    /// TeachMeSkills database context.
    /// </summary>
    public class TeachMeSkillsContext : IdentityDbContext<User>
    {
        /// <summary>
        /// Contructor with params.
        /// </summary>
        /// <param name="options">Database context options.</param>
        public TeachMeSkillsContext(DbContextOptions<TeachMeSkillsContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Todos.
        /// </summary>
        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ApplyConfiguration(new TodoConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
