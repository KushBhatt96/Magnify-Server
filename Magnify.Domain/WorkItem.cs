namespace Magnify.Domain
{
    public class WorkItem
    {
        public Guid WorkItemId { get; set; }
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Guid OwnerId { get; set; }

        public int StoryPoints { get; set; }

        public WorkItemType WorkItemType { get; set; }

        public WorkItemStatus WorkItemStatus { get; set; }

        public Guid ProjectId { get; set; }

        public DateTime CreateAt { get; set; }
    }

    public enum WorkItemType
    {
        Story,
        Bug
    }

    public enum WorkItemStatus
    {
        New,
        Development,
        Review,
        Testing,
        Resolved
    }
}
