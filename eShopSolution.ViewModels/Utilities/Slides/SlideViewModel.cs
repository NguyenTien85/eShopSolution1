﻿using eShopSolution.Data.Enums;

namespace eShopSolution.ViewModels.Utilities.Slides
{
    public class SlideViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int SortOrder { get; set; }
        public Status Status { get; set; }
        public string Image { get; set; }
    }
}