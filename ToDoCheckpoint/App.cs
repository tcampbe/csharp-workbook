using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace ToDoCheckpoint
{
    class App              // between ConsoleUtils and ItemRepository
    {
        ItemRpository Repo = new ItemRpository();
        //all the rules and coordinates user (consoleutils)
        // and the database (itemrepository)

        public App()
        {
        }

        public void Add(string Add)
        {
            ToDo Item = new ToDo(Add);
            Repo.Add(Item);
        }

        public void Change(string Change)
        {
            int cng = Int32.Parse(Change);
            Repo.Change(cng);
        }

        public void DelItem(string Delet)
        {
            int del = Int32.Parse(Delet);
            Repo.DelItem(del);
        }

        public void PrintPending()
        {
            Repo.PendingTable();
        }
        public void PrintDone()
        {
            Repo.DoneTable();
        }
        public void PrintAll()
        {
            Repo.Table();
        }
    }
}
