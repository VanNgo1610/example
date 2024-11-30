using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace eLearning
{
    public class CoursesModel
    {
        //Courses information
        public int Id { get; set; } //course's id
        public string Name { get; set; } //course's name
        public string Category { get; set; } //course's category
        public string Level { get; set; } //course's level
        public double Price { get; set; } //course's price
        public string Description { get; set; } //course's description
        public string ImageUrl { get; set; } // URL course image
        public string Instructor { get; set; } // instructor name
        public int Duration { get; set; } // course's duration
        public int Students { get; set; } // amounts of students
        public int Rating { get; set; } // course's rating
        public int Reviews { get; set; } // review

        //search and fliter
        public string SearchTerm { get; set; } //search according to name
        public string SelectedCategory { get; set; } //search according to category
        public string SelectedLevel { get; set; } //search according to level
        public double? MinPrice { get; set; } //minimum price
        public double? MaxPrice { get; set; }//maxium price
    }
}