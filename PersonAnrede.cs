using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbeitLinq;

   public class PersonAnrede
    {
    public Person Item { get; set; }
    public string Anrede { get; set; }

    public PersonAnrede(string anrede, Person item)
    {
        this.Item = item;
        this.Anrede = anrede;
    }
}

