namespace Laboratorium3___App.Models
{
    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime GetDateTime() => DateTime.Now;
    }
}
