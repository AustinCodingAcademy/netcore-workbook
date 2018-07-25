using System;
namespace BaseProject.Intrastructure
{
    public class DateTimeProvider
    {
 

            public DateTime Now
        {
            get
            {
                return DateTime.Now.AddDays(1);
            }
        }
    }
}

        
    

