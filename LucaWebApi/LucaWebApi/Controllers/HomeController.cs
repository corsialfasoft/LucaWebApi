using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LucaWebApi.Models;

namespace LucaWebApi.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {
			ViewBag.Title = "Home Page";

			return View();
		}

		public ActionResult About() {
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact() {
			ViewBag.Message = "Your contact page.";

			return View();
		}
		public ActionResult RicercaProdotti() {
			ViewBag.Messagge = "Benvenuto nella pagina di ricerca prodotto!";
			return View();
		}
		public ActionResult RicercaProdotti(string codice, string descrizione) {
			int cod;
			DomainModels dm = new DomainModels();
			if (int.TryParse(codice, out cod)) {
				ViewBag.prodotto = dm.RicercaId(cod);
				return View("DettagliOProdotto");
			}

			return View();
		}

		public ActionResult DettaglioProdotto() {
			ViewBag.Messagge = " ECCO I DETTAGLI DEL TUO PRODOTTO!";
			return View();
		}

		public ActionResult DettaglioProdotto(int id) {
			DomainModels dm = new DomainModels();
			ViewBag.Messagge = " ECCO I DETTAGLI DEL TUO PRODOTTO!";
			ViewBag.prodotto = dm.RicercaId(id);
			return View();
		}
		public ActionResult PreviewRichiesta() {
			return View();
		}
		public ActionResult ElencoProdotti() {
			return View();
		}
		public ActionResult AggiungiCarrello(string codice, string Quantita) {
			return View();
		}
	}
}
