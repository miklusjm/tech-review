﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }                 //Key ID number for each review
        public string Title { get; set; }           //Title of the review
        public string Text { get; set; }            //Body text of the review
        public int Rating { get; set; }             //Rating out of 5 stars
        private DateTime _date = DateTime.Now;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}