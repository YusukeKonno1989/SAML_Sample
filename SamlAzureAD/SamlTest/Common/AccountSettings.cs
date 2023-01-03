using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// AccountSettings
/// 
/// Replace this class with an interface to your own applications account settings. 
/// 
/// Each account should as a minimum have the following:
///  - A URL pointing to the identity provider for sending Auth Requests
///  - A X.509 certificate for validating the SAML Responses from the identity provider
/// 
/// These should be retrieved from the account store/database on each request in the authentication flow.
/// </summary>
public class AccountSettings
{
    public string certificate = "-----BEGIN CERTIFICATE-----MIIC8DCCAdigAwIBAgIQHqvqPMJolrpNJ+dYkDBuejANBgkqhkiG9w0BAQsFADA0MTIwMAYDVQQDEylNaWNyb3NvZnQgQXp1cmUgRmVkZXJhdGVkIFNTTyBDZXJ0aWZpY2F0ZTAeFw0yMjExMDQwNzQxMjBaFw0yNTExMDQwNzQxMjBaMDQxMjAwBgNVBAMTKU1pY3Jvc29mdCBBenVyZSBGZWRlcmF0ZWQgU1NPIENlcnRpZmljYXRlMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEArwMYrmJZgYV31nGZTzN0QRR2KiFYdtUQFJyjng1L0aWAg/MZVBKPv6q7p4HdxdzSk7AYvwFvG9fsSp8n2oGU3jsQHRxwIXKOIaP4+TXQk/Y0TaWXFeOZ0Mt//1sM66+e2tpElbuAPRdWhtfevNrjpWLsUJtPyJcjEC0od6GRTW9oLz0B035+40q5AstjMJ74s12O9ynTNc9ox2+lr3h9PX3auUjxsiFQ0B46WNqLgRQGr2TkGGhyaETc3XNzbgfCeJ/jNuicOBrDYCon37ariLKwzVdWfcjtoZcm+tlxeOjwIgp2sASGumN+zayfXfiAQqmnyI64pkSPBM5qCrM7RQIDAQABMA0GCSqGSIb3DQEBCwUAA4IBAQCFfMqSGXol3Fbnk18+EoHmbbCqQANwtQ7b9aEYv4aE/16zwM/N1CqFaj02gMv0ME8aFD4j+dZ5Zf/4Ns+ohK9pBp/PT4CqaG+f7Og2r4/DpvsYbTXZy+vDTQKh06CNe6m2/zIi8mZNSdGU5wg794OZmI/AeS4t47CHESR1h39QcCgrxHcnz1YQWoJtz/jUbCsraR/JN5euo7Wae89Wfnjnv4Q+yh3azCG0A3ZHRxyyZ21NDVb0auu3/KbPpCXVn6gtRJr6KEYXiiO3M0wdWKatebeo6KGH+8bUt5gREQk6/a7UNqSQWwQ8ps3fyy3vkbMWr6KVJLtEGD3VIwlGJBZ+-----END CERTIFICATE-----";
    public string idp_sso_target_url = "https://login.microsoftonline.com/bdcac6e9-e434-4c77-86ad-1527d31b0b15/saml2";

}
