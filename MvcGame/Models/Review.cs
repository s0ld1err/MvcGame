using MvcGame.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Review
{
    public int Id { get; set; }
    public string? UserName { get; set; }
    public DateTime Date { get; set; }
    public string? Content { get; set; }
    public int GameId { get; set; }
    public Game? Game { get; set; }
}
