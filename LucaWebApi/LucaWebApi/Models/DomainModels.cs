using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LucaWebApi.Models {
	public class Prodotto{
		public int ID { get; set; }
		public string Descrizione { get; set; }
		public int Quantita { get; set; }
	}

	public interface IRichieste{
		Prodotto RicercaId(int id);
		List<Prodotto> RicercaDescrizione(string descrizione);
		void AggiungiOrdine(List<Prodotto> listP);
	}

	public class DomainModels: IRichieste {
		public Prodotto RicercaId(int id){
			throw new NotImplementedException();
		}

		public List<Prodotto> RicercaDescrizione(string descrizione) {
			throw new NotImplementedException();
		}

		public void AggiungiOrdine(List<Prodotto> listP) {
			throw new NotImplementedException();
		}

	}
}