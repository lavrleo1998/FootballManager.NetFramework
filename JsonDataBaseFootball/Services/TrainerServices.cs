﻿using JsonDataBaseFootball.DataBase;
using JsonDataBaseFootball.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.Services
{
    class TrainerServices
    {
        public static string Download()
        {
            string str = "Тренера\n";
            foreach (var trainer in Repository.Get<Trainer>())
            {
                str += "Айди: " + trainer.ID
                    + "; Имя тренера: " + trainer.Name
                    + "\n";
            }
            return str;
        }
        public static void Add(int ID, string name) =>
           Repository.Add(new Trainer(ID, name));
        public static void Delete(int teamTypeID) =>
            Repository.Delete<Trainer>(teamTypeID);
        public static void Update(int ID, string name) =>
            Repository.Update<Trainer>(new Trainer(ID, name));
    }
}
