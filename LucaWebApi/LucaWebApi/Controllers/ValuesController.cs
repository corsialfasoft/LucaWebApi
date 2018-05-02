using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LucaWebApi.Models;

namespace LucaWebApi.Controllers {
	public class ValuesController : ApiController {
		DomainModels dm = new DomainModels();
		// GET api/values
		public IEnumerable<Prodotto> Get() {
			return dm.RicercaDescrizione("");
		}

		// GET api/values/5
		public Prodotto Get(int id) {
			return dm.RicercaId(id);
		}

		// POST api/values
		public void Post([FromBody]string value) {
			dm.ToString();
		}

		// PUT api/values/5
		public void Put(int id, [FromBody]string value) {
		}

		// DELETE api/values/5
		public void Delete(int id) {
		}
	}
}
