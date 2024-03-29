﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection5_4.Mocking
{
    public string ReadVideoTitle(IFileReader fileReader)
    {
        var str = new fileReader.Read("video.txt");
        var video = JsonConvert.DeserializeObject<Video>(str);
        if (video == null)
            return "Error parsing the video.";
        return video.Title;
    }

    public string GetUnprocessedVideosAsCsv()
    {
        var videoIds = new List<int>();

        using (var context = new VideoContext())
        {
            (from video in context.Videos
             where !video.IsProcessed
             select video).ToList();

            foreach (var v in videoIds)
                videoIds.Add(v.Id);

            return String.Join(",", videoIds);
     
        }
   
    }


        public class Video
        {
             public int Id { get; set; }
             public string Title { get; set; }
             public bool IsProcessed { get; set; }
        }

        public class VideoContext : DbContext
        {
             public DbSet<Video> Videos { get; set; }
        }
}


