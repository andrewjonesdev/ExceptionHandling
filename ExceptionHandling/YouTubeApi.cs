using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube web service 
                // Read the data 
                // Create a list of Video objects
                throw new Exception("Oops some low level YouTube error.");//remove this so return statement is reachable just a testing example
            }
            catch (Exception ex)
            {
                // Log 

                throw new YouTubeException("Could not fetch the videos from YouTube.", ex); //wraps the low level exceptions into this
            }

            return new List<Video>();
        }
    }
}