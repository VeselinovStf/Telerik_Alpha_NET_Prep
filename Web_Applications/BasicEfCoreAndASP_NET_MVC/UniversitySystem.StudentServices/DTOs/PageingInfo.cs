﻿namespace UniversitySystem.StudentServices.DTOs
{
    public class PageingInfo
    {
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }
    }
}