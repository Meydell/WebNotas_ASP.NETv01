using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebNotas_ASP.NETv01.Models;

namespace WebNotas_ASP.NETv01.Controllers
{
    public class CalificacionesController : Controller
    {
        private NotasModelContainer db = new NotasModelContainer();

        // GET: Calificaciones
        public ActionResult Index()
        {
            var calificaciones = db.Calificaciones.Include(c => c.Estudiante).Include(c => c.Asignatura);
            return View(calificaciones.ToList());
        }

        // GET: Calificaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificacion calificacion = db.Calificaciones.Find(id);
            if (calificacion == null)
            {
                return HttpNotFound();
            }
            return View(calificacion);
        }

        // GET: Calificaciones/Create
        public ActionResult Create()
        {
            ViewBag.EstudianteEstudianteID = new SelectList(db.Estudiantes, "EstudianteID", "Nombres");
            ViewBag.AsignaturaAsignaturaID = new SelectList(db.Asignaturas, "AsignaturaID", "Codigo");
            return View();
        }

        // POST: Calificaciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CalificacionID,Acumulado,ProyectoFinal,EstudianteEstudianteID,AsignaturaAsignaturaID")] Calificacion calificacion)
        {
            if (ModelState.IsValid)
            {
                db.Calificaciones.Add(calificacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EstudianteEstudianteID = new SelectList(db.Estudiantes, "EstudianteID", "Nombres", calificacion.EstudianteEstudianteID);
            ViewBag.AsignaturaAsignaturaID = new SelectList(db.Asignaturas, "AsignaturaID", "Codigo", calificacion.AsignaturaAsignaturaID);
            return View(calificacion);
        }

        // GET: Calificaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificacion calificacion = db.Calificaciones.Find(id);
            if (calificacion == null)
            {
                return HttpNotFound();
            }
            ViewBag.EstudianteEstudianteID = new SelectList(db.Estudiantes, "EstudianteID", "Nombres", calificacion.EstudianteEstudianteID);
            ViewBag.AsignaturaAsignaturaID = new SelectList(db.Asignaturas, "AsignaturaID", "Codigo", calificacion.AsignaturaAsignaturaID);
            return View(calificacion);
        }

        // POST: Calificaciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CalificacionID,Acumulado,ProyectoFinal,EstudianteEstudianteID,AsignaturaAsignaturaID")] Calificacion calificacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calificacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EstudianteEstudianteID = new SelectList(db.Estudiantes, "EstudianteID", "Nombres", calificacion.EstudianteEstudianteID);
            ViewBag.AsignaturaAsignaturaID = new SelectList(db.Asignaturas, "AsignaturaID", "Codigo", calificacion.AsignaturaAsignaturaID);
            return View(calificacion);
        }

        // GET: Calificaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificacion calificacion = db.Calificaciones.Find(id);
            if (calificacion == null)
            {
                return HttpNotFound();
            }
            return View(calificacion);
        }

        // POST: Calificaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Calificacion calificacion = db.Calificaciones.Find(id);
            db.Calificaciones.Remove(calificacion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
