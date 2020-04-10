﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces.EntityInterfaces;

namespace DAL.Entities
{
    public class Game : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public int Id_Dev { get; set; }
        public int Id_Genre { get; set; }

    }
}
