﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MI9Challenge.Models
{
    //Model for the service request
    public class FilterShowRequest
    {
        public List<Show> payload { get; set; }
        public int skip { get; set; }
        public int take { get; set; }
        public int totalRecords { get; set; }

    }
    public class Show
    {
        public string country { get; set; }
        public string description { get; set; }
        public bool drm { get; set; }
        public int episodeCount { get; set; }
        public string genre { get; set; }
        public Image image { get; set; }
        public string language { get; set; }
        public Episode nextEpisode { get; set; }
        public string primaryColour { get; set; }
        public List<Season> seasons { get; set; }
        public string slug { get; set; }
        public string title { get; set; }
        public string tvChannel { get; set; }
    }
    public class Image
    {

        public string showImage { get; set; }
    }
    public class Episode
    {
        public string channel { get; set; }
        public string channelLogo { get; set; }
        public DateTime? date { get; set; }
        public string html { get; set; }
        public string url { get; set; }
    }
    public class Season
    {
        public string slug { get; set; }
    }
}
