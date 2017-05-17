using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSystem.Entities
{
    public class ApplicationLog: BaseEntity
    {
        public DateTime Date { get; set; }

        [StringLength(250)]
        public string Thread { get; set; }

        [StringLength(50)]
        public string Level { get; set; }

        public string User { get; set; }

        [StringLength(250)]
        public string Logger { get; set; }

        public string Message { get; set; }

        public string Exception { get; set; }
    }
}
