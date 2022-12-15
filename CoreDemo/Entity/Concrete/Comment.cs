using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Comment
    {
        [Key]
        public int ComentID { get; set; }
        public string ComentUserName { get; set; }
        public string ComentTitle { get; set; }
        public string ComentContent { get; set; }
        public DateTime ComentDate { get; set; }
        public int BlogScore { get; set; }
        public bool WriterStatus { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
