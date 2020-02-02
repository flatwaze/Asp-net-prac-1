using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class BasicObjectView
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле обязатлеьно для ввода.")]
        public string Name { get; set; }
    }
}
