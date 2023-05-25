namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of RetireSponsorsTier
    /// </summary>
    public class RetireSponsorsTierPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The tier that was retired.
        /// </summary>
        public SponsorsTier SponsorsTier { get; set; }
    }
}