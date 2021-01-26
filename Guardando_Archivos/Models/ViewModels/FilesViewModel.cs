using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Guardando_Archivos.Models.ViewModels
{
    public class FilesViewModel
    {
        //definicion de las variables que guardaran los datos de nuestros archivos
        [Required] 
        [DisplayName("Mi archivo")]
        public HttpPostedFileBase Archivo1 { get; set; }
        [Required]
        [DisplayName("Mi segundo archivo")]
        public HttpPostedFileBase Archivo2 { get; set; }
        [Required]
        [DisplayName("Mi tercer archivo")]
        public HttpPostedFileBase Archivo3 { get; set; }
    }
}