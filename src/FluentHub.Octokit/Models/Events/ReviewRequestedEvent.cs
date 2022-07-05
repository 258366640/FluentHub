﻿namespace FluentHub.Octokit.Models.Events
{
    public class ReviewRequestedEvent
    {
        public Actor Actor { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public string CreatedAtHumanized { get; set; }

        public RequestedReviewer RequestedReviewer { get; set; }
    }
}
