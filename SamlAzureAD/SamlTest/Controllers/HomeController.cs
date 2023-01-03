using OneLogin.Saml;
using SamlTest.Models;
using System.Web.Mvc;

namespace SamlTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SamlProcess([System.Web.Http.FromBody]IndexViewModel model)
        {
            AccountSettings accountSettings = new AccountSettings();

            AuthRequest req = new AuthRequest(new AppSettings(), accountSettings);

            var info = accountSettings.idp_sso_target_url + "?SAMLRequest=" + Server.UrlEncode(req.GetRequest(AuthRequest.AuthRequestFormat.Base64));
            Response.Redirect(info);

            return View();
        }
        [HttpPost]
        public ActionResult Redirect()
        {
            // AzureAD側に情報を送った後に、帰ってくる結果を受け取る処理
            AccountSettings accountSettings = new AccountSettings();

            Response samlResponse = new Response(accountSettings);
            samlResponse.LoadXmlFromBase64(Request.Form["SAMLResponse"]);

            // XML読み込み
            var nameId = samlResponse.GetNameID();
            var certificate = samlResponse.GetCertificate();

            if (samlResponse.IsValid())
            {
                Response.Write("OK!");
                Response.Write(samlResponse.GetNameID());
            }
            else
            {
                Response.Write("Failed");
            }

            return View();
        }
  
    }
}