using Guardando_Archivos.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO.Compression;
namespace Guardando_Archivos.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            //solo para momstrar un mensaje de exito
            if (TempData["Message"] != null)
                ViewBag.Message = TempData["Message"].ToString();
            return View();
        }

         [HttpPost]
        public ActionResult Save(FilesViewModel model)
        {
            //los ifs comprueban si alguna varible que contiene imagen es nula y por lo tanto no la guarda.
            if (model.Archivo1 == null)
            {
                if (model.Archivo2 == null)
                {
                    //instruccion que nos ayuda a guardar los archivos especificados en la ruta que pasamos como parametro especificando tambien el formato y nombre
                    model.Archivo3.SaveAs("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados/Archivo3.pdf");
                    //mensaje de exito
                    @TempData["Message"] = "Se cargaron los archivos";
                    return RedirectToAction("Index");
                }
                //lo del if anterior se repite para todos los casos segun cual fuera nuelo en cada oportunidad.
                else if (model.Archivo3 == null)
                {
                    model.Archivo2.SaveAs("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados/Archivo2.pdf");
                    @TempData["Message"] = "Se cargaron los archivos";
                    return RedirectToAction("Index");
                }
                else
                {
                    model.Archivo2.SaveAs("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados/Archivo2.pdf");
                    model.Archivo3.SaveAs("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados/Archivo3.pdf");
                    @TempData["Message"] = "Se cargaron los archivos";
                    return RedirectToAction("Index");
                }
            }
            else if (model.Archivo2 == null)
            {
                if (model.Archivo1 == null)
                {
                    model.Archivo3.SaveAs("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados/Archivo3.pdf");
                    @TempData["Message"] = "Se cargaron los archivos";
                    return RedirectToAction("Index");
                }
                else if (model.Archivo3 == null)
                {
                    model.Archivo1.SaveAs("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados/Archivo1.pdf");
                    @TempData["Message"] = "Se cargaron los archivos";
                    return RedirectToAction("Index");
                }
                else
                {
                    model.Archivo1.SaveAs("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados/Archivo1.pdf");
                    model.Archivo3.SaveAs("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados/Archivo3.pdf");
                    @TempData["Message"] = "Se cargaron los archivos";
                    return RedirectToAction("Index");
                }
            }
            else if (model.Archivo3 == null)
            {
                if (model.Archivo1 == null)
                {
                    model.Archivo2.SaveAs("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados/Archivo2.pdf");
                    @TempData["Message"] = "Se cargaron los archivos";
                    return RedirectToAction("Index");
                }
                else if (model.Archivo2 == null)
                {
                    model.Archivo1.SaveAs("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados/Archivo1.pdf");
                    @TempData["Message"] = "Se cargaron los archivos";
                    return RedirectToAction("Index");
                }
                else
                {
                    model.Archivo1.SaveAs("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados/Archivo1.pdf");
                    model.Archivo2.SaveAs("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados/Archivo2.pdf");
                    @TempData["Message"] = "Se cargaron los archivos";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                model.Archivo1.SaveAs("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados/Archivo1.pdf");
                model.Archivo2.SaveAs("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados/Archivo2.pdf");
                model.Archivo3.SaveAs("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados/Archivo3.pdf");

                @TempData["Message"] = "Se cargaron los archivos";
                return RedirectToAction("Index");
            }
        }
        //clase para comprimir la carpeta donde esten nuestros archivos
        public ActionResult Comprimir(FilesViewModel model)
        {
            //comprobacion de si existe o no el archivo comprimido y si es asi lo elimina porque lo escribiremos nuevamente
            if (System.IO.File.Exists("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/comprimidos.zip"))
            {
                System.IO.File.Delete("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/comprimidos.zip");
            }
            //instruccion que comprime el directorio especificado por la rua del primer parametro en el archivo especificado por la ruta del segundo parametro
            ZipFile.CreateFromDirectory("C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/Archivo_ guardados", "C:/Users/chakp/source/repos/Guardando_Archivos/Guardando_Archivos/comprimidos.zip");
            //mensaje de exito
            @TempData["Message"] = "Se comprimieron los archivos";
            return RedirectToAction("Index");
            
        }

    }
}