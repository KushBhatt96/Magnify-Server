namespace Magnify.Domain
{
    public class Project
    {
        public Guid ProjectId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ProjectType ProjectType { get; set; }

        public ProjectStatus ProjectStatus { get; set; }

        public IList<WorkItem> WorkItems { get; set; } = new List<WorkItem>();
    }

    public enum ProjectType
    {
        Desktop,
        Web,
        Server,
        Mobile,
        Game,
        Other
    }

    public enum ProjectStatus
    {
        New,
        Active,
        OnHold,
        Completed,
        Closed
    }
}