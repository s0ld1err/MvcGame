﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MvcGame.Models

{
    public class Game
    {
        public int Id { get; set; }
        public string? Title { get; set; }


        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }


        public string? Genre { get; set; }


        public string? Platforms { get; set; }


        [Range(0, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        //public string? Description { get; set; }



        public List<Review>? Reviews { get; set; }

    }


}
