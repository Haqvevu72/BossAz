 class Notification
{
    public string? By { get; set; }
    public string? Message { get; set; }
    public DateTime SendTime { get; set; } = DateTime.Now;

    public Notification(string? by, string? message)
    {
        By = by;
        Message = message;
    }

    public override string ToString()
    {
        return $"By: {By}\nMessage: {Message}\nSend Time: {SendTime.ToShortDateString()}";
    }
}
