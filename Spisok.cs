using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Povtorenie1
{
    internal class Spisok
    {
        private string _title;
        public string Title
        { 
            get { return _title; } 
            set { _title = value; } 
        }

        private int _identityCod;
        public int IdentityCod
        { 
            get { return _identityCod; }
            set { _identityCod = value; } 
        }

        private string _comments;
        public string Comments
        {   
            get { return _comments; }
            set { _comments = value;}
        }

        public Spisok(string titile, int cod, string comment)
        {
            _title = titile;
            _identityCod = cod;
            _comments = comment;
        }
    }
}
