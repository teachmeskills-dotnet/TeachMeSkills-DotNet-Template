﻿namespace TeachMeSkills.DataAccessLayer.Interfaces
{
    /// <summary>
    /// Interface for implement identity.
    /// </summary>
    public interface IHasDbIdentity
    {
        /// <summary>
        /// Identifier.
        /// </summary>
        int Id { get; set; }
    }
}