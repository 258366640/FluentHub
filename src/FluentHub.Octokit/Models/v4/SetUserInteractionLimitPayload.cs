namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of SetUserInteractionLimit
    /// </summary>
    public class SetUserInteractionLimitPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The user that the interaction limit was set for.
        /// </summary>
        public User User { get; set; }
    }
}