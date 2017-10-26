using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace U241017.DATA
{
    public class Repository
    {
        private static Repository _repo = new Repository();
        public static Repository GetRepo { get { return _repo; } }

        private List<Class1> prod = new List<Class1>();

        public Repository()
        {
            prod.Add(new Class1() { Name = "Thailand", Event = "Dans", Place="Östra gymnasiet", Time="2017-10-24 kl 14:00", Id = 10});
            prod.Add(new Class1() { Name = "Thailand", Event = "Dans", Place = "Östra gymnasiet", Time = "2017-10-24 kl 14:00", Id = 20 });
            prod.Add(new Class1() { Name = "Tyskland", Event = "Dans", Place = "Östra gymnasiet", Time = "2017-10-24 kl 14:00", Id = 30 });
            prod.Add(new Class1() { Name = "Thailand", Event = "Dans", Place = "Östra gymnasiet", Time = "2017-10-24 kl 14:00", Id = 40 });
            prod.Add(new Class1() { Name = "Thailand", Event = "Dans", Place = "Östra gymnasiet", Time = "2017-10-24 kl 14:00", Id = 50 });
        }

        //Create
        public List<Class1> Products
        {
            get
            {
                return prod;
            }
        }

        //Update
        public void Add(Class1 p)
        {
            
            int id = prod.Max(x => x.Id);
            p.Id = id + 10;
            prod.Add(p);
        }

        //Delete
        public void Remove (int id)
        {
            Class1 p = prod.Find( x => x.Id == id);
            prod.Remove(p);
        }
    }
}
