﻿using BaseLib.Model;

namespace Model.Dtos.OnsozOzelDto
{
    public class OnsozOzelGetDto:IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }
        public string? PhotoPath { get; set; }
    }
}
