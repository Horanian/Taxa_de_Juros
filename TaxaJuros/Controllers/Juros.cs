using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxaJuros.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    /// <summary>
    /// Este é método que fornece o valor do juros para a outra API 
    /// enquanto estiver online a API fornecerá o valor para a outra API
    /// </summary>
    public class JurosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetJuros()
        {
            var juros = 0.01m;
            return juros.ToString("F2"); // Retorna o valor dos juros como uma string formatada
        }
    }
}
