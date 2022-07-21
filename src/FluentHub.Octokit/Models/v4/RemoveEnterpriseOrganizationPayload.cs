namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of RemoveEnterpriseOrganization
    /// </summary>
    public class RemoveEnterpriseOrganizationPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The updated enterprise.
        /// </summary>
        public Enterprise Enterprise { get; set; }

        /// <summary>
        /// The organization that was removed from the enterprise.
        /// </summary>
        public Organization Organization { get; set; }

        /// <summary>
        /// The viewer performing the mutation.
        /// </summary>
        public User Viewer { get; set; }
    }
}