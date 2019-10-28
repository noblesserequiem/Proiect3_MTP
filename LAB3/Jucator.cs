using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    class Jucator
    {
        private String nume;
        private String cnp;
        private Post post_jucator;
        public Jucator(String nume, String cnp, Post post)
        {
            this.nume = nume;
            this.cnp = cnp;
            this.post_jucator = post;
        }

        
    }
    enum Post : int
    {
        Portar,
        Fundas,
        Mijlocas,
        Atacant
    }
}
