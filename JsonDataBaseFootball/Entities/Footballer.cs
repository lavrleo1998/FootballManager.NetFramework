﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Entities
{
    public class Footballer : Entity
    {
        public string Name { get; set; }
        ///public Position Position { get; set;}
        public Footballer(int id, string name)
        {
            ID = id;
            Name = name;
            /*Заметка Спиридона
            Position = new Position
            {
                ID = 123,
                Name = "dasdas"
            };
            */

        }
    }
}
