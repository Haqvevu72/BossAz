﻿using System.Text.Json;

class Worker : Human
{
    public CV cv { get; set; }
    public Worker(Guid id, string? name, string? surname, short? age, string? phone, string? city, string? username, string? password,CV cv) : base(id, name, surname, age, phone, city, username, password)
    {
        this.cv = cv;
    }



    public override string ToString()
    {
        return base.ToString()+cv.ToString();
    }
}
