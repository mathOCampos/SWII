using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
//MATHEUS DE OLIVEIRA CAMPOS, LUCAS MOURA
namespace tp01web
{
    class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }

        public Author (string _name, string _email, char _gender)
        {
            this.Name = _name;
            this.Email = _email;
            this.Gender = _gender;
        }
        public Author()
        {
            Email = "example@example";
            Gender = 'm';
        }
        
    }
    
}
