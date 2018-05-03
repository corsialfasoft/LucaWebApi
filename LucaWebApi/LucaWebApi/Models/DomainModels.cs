using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LucaWebApi.Models {
	public class Prodotto {
		public int ID { get; set; }
		public string Descrizione { get; set; }
		public int Quantita { get; set; }
	}

	public interface IRichieste {
		Prodotto RicercaId(int id);
		List<Prodotto> RicercaDescrizione(string descrizione);
		void AggiungiOrdine(List<Prodotto> listP);
	}

	public class DomainModels : IRichieste {
		RICHIESTEEntities db;
		public Prodotto RicercaId(int id) {

			Prodotto prod = new Prodotto();

			using (var db = new RICHIESTEEntities()) {
				ProdottiSet pSet = new ProdottiSet();
				pSet = db.ProdottiSet.Find(id);
				prod.ID = pSet.Id;
				prod.Descrizione = pSet.descrizione;
				prod.Quantita = pSet.quantita;
			}
			return prod;
		}

		public List<Prodotto> RicercaDescrizione(string descrizione) {
			List<Prodotto> listProd = new List<Prodotto>();
			using (var db = new RICHIESTEEntities()) {
				var query = from c in db.ProdottiSet
							where c.descrizione.Contains(descrizione)
							select c;
				foreach (var h in query) {
					Prodotto p = new Prodotto();
					p.ID = h.Id;
					p.Descrizione = h.descrizione;
					p.Quantita = h.quantita;
					listProd.Add(p);
				}
			}
			return listProd;
		}

		public void AggiungiOrdine(List<Prodotto> listP) {
			foreach (Prodotto p in listP) {
				using (var db = new RICHIESTEEntities()) {
					var query = new ProdottiSet {
						descrizione = p.Descrizione,
						quantita = p.Quantita
					};

					db.SaveChanges();
				}
			}
		}

		public void AddProdotto(Prodotto p){
			try{
				using(var db = new RICHIESTEEntities()) {
					ProdottiSet prod = new ProdottiSet {
						descrizione = p.Descrizione,
						quantita = p.Quantita
					};
					db.ProdottiSet.Add(prod);
					db.SaveChanges();
				}
			}catch(Exception e){
				throw e;
			}
		}

		public void DelProdotto(int id) {
			try {
				using (var db = new RICHIESTEEntities()) {
					ProdottiSet prod = db.ProdottiSet.Find(id);
					db.ProdottiSet.Remove(prod);
					db.SaveChanges();
				};
			} catch (Exception e) {
				throw e;
			}
		}
	}
}