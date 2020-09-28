using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Nethereum.SimpleTestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var web3 = new Web3.Web3("https://mainnet.infura.io/v3/7238211010344719ad14a89db874158c");

            // Check the balance of one of the accounts provisioned in our chain, to do that, 
            // we can execute the GetBalance request asynchronously:
            var balance = await web3.Eth.GetBalance.SendRequestAsync("0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae");

            ViewBag.Message = "Balance of Ethereum Foundation's account: " + Web3.Web3.Convert.FromWei(balance.Value);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}