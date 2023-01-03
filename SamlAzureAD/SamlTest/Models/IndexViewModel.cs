using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;

using OneLogin.Saml;
namespace SamlTest.Models
{
    public class IndexViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }
        public string Password { get; set; }

    }

}