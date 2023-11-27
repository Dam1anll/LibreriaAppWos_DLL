using System.Collections.Generic;

namespace Libreria_DLL.Data.Models
{
    public class Author
    {
        public int id { get; set; }
        public string FullName { get; set; }

        //Propiedades de navegacion
        public List<Book_Author> Book_Authors { get; set; }
    }
}
