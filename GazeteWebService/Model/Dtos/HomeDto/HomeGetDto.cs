﻿using BaseLib.Model;

namespace Model.Dtos.HomeDto
{
    public class HomeGetDto:IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }
        public string? PhotoPath { get; set; }
    }
}
