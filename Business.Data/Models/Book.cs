﻿namespace Business.Data.Models;

public class Book
{
    public Guid Id { get; set; }
    public string BookName { get; set; }
    public string BookCode { get; set; }
    public bool IsCompleted { get; set; }

}