
public class Event
{
    public int Id { get; set; }
    public String Host { get; set; }
    public DateTime Date { get; set; }

    public Event(int Id, String host, DateTime date)
    {
        this.Id = Id;
        this.Host = host;
        this.Date = date;
    }

}
