using System;
namespace BaseProject.Intrastructure
{
    public class DateTimeProvider : IDateTimeProvider
    {
 

            public DateTime Now
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
        
    }
}

        
    

