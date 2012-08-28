using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Text.RegularExpressions;

namespace CurrencyConverter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.From = GetCountryDropDown();
            ViewBag.To = GetCountryDropDown();
            return View();
        }

        private IList<SelectListItem> GetCountryDropDown()
        {
            IList<SelectListItem> _result = new List<SelectListItem>();
            _result.Add(new SelectListItem { Value = "AED", Text = "United Arab Emirates Dirham (AED)" });
            _result.Add(new SelectListItem { Value = "ANG", Text = "Netherlands Antillean Guilder (ANG)" });
            _result.Add(new SelectListItem { Value = "ARS", Text = "Argentine Peso (ARS)" });
            _result.Add(new SelectListItem { Value = "AUD", Text = "Australian Dollar (AUD)" });
            _result.Add(new SelectListItem { Value = "BDT", Text = "Bangladeshi Taka (BDT)" });
            _result.Add(new SelectListItem { Value = "BGN", Text = "Bulgarian Lev (BGN)" });
            _result.Add(new SelectListItem { Value = "BHD", Text = "Bahraini Dinar (BHD)" });
            _result.Add(new SelectListItem { Value = "BND", Text = "Brunei Dollar (BND)" });
            _result.Add(new SelectListItem { Value = "BOB", Text = "Bolivian Boliviano (BOB)" });
            _result.Add(new SelectListItem { Value = "BRL", Text = "Brazilian Real (BRL)" });
            _result.Add(new SelectListItem { Value = "BWP", Text = "Botswanan Pula (BWP)" });
            _result.Add(new SelectListItem { Value = "CAD", Text = "Canadian Dollar (CAD)" });
            _result.Add(new SelectListItem { Value = "CHF", Text = "Swiss Franc (CHF)" });
            _result.Add(new SelectListItem { Value = "CLP", Text = "Chilean Peso (CLP)" });
            _result.Add(new SelectListItem { Value = "CNY", Text = "Chinese Yuan (CNY)" });
            _result.Add(new SelectListItem { Value = "COP", Text = "Colombian Peso (COP)" });
            _result.Add(new SelectListItem { Value = "CRC", Text = "Costa Rican Colón (CRC)" });
            _result.Add(new SelectListItem { Value = "CZK", Text = "Czech Republic Koruna (CZK)" });
            _result.Add(new SelectListItem { Value = "DKK", Text = "Danish Krone (DKK)" });
            _result.Add(new SelectListItem { Value = "DOP", Text = "Dominican Peso (DOP)" });
            _result.Add(new SelectListItem { Value = "DZD", Text = "Algerian Dinar (DZD)" });
            _result.Add(new SelectListItem { Value = "EEK", Text = "Estonian Kroon (EEK)" });
            _result.Add(new SelectListItem { Value = "EGP", Text = "Egyptian Pound (EGP)" });
            _result.Add(new SelectListItem { Value = "EUR", Text = "Euro (EUR)" });
            _result.Add(new SelectListItem { Value = "FJD", Text = "Fijian Dollar (FJD)" });
            _result.Add(new SelectListItem { Value = "GBP", Text = "British Pound Sterling (GBP)" });
            _result.Add(new SelectListItem { Value = "HKD", Text = "Hong Kong Dollar (HKD)" });
            _result.Add(new SelectListItem { Value = "HNL", Text = "Honduran Lempira (HNL)" });
            _result.Add(new SelectListItem { Value = "HRK", Text = "Croatian Kuna (HRK)" });
            _result.Add(new SelectListItem { Value = "HUF", Text = "Hungarian Forint (HUF)" });
            _result.Add(new SelectListItem { Value = "IDR", Text = "Indonesian Rupiah (IDR)" });
            _result.Add(new SelectListItem { Value = "ILS", Text = "Israeli New Sheqel (ILS)" });
            _result.Add(new SelectListItem { Value = "INR", Text = "Indian Rupee (INR)" });
            _result.Add(new SelectListItem { Value = "JMD", Text = "Jamaican Dollar (JMD)" });
            _result.Add(new SelectListItem { Value = "JOD", Text = "Jordanian Dinar (JOD)" });
            _result.Add(new SelectListItem { Value = "JPY", Text = "Japanese Yen (JPY)" });
            _result.Add(new SelectListItem { Value = "KES", Text = "Kenyan Shilling (KES)" });
            _result.Add(new SelectListItem { Value = "KRW", Text = "South Korean Won (KRW)" });
            _result.Add(new SelectListItem { Value = "KWD", Text = "Kuwaiti Dinar (KWD)" });
            _result.Add(new SelectListItem { Value = "KYD", Text = "Cayman Islands Dollar (KYD)" });
            _result.Add(new SelectListItem { Value = "KZT", Text = "Kazakhstani Tenge (KZT)" });
            _result.Add(new SelectListItem { Value = "LBP", Text = "Lebanese Pound (LBP)" });
            _result.Add(new SelectListItem { Value = "LKR", Text = "Sri Lankan Rupee (LKR)" });
            _result.Add(new SelectListItem { Value = "LTL", Text = "Lithuanian Litas (LTL)" });
            _result.Add(new SelectListItem { Value = "LVL", Text = "Latvian Lats (LVL)" });
            _result.Add(new SelectListItem { Value = "MAD", Text = "Moroccan Dirham (MAD)" });
            _result.Add(new SelectListItem { Value = "MDL", Text = "Moldovan Leu (MDL)" });
            _result.Add(new SelectListItem { Value = "MKD", Text = "Macedonian Denar (MKD)" });
            _result.Add(new SelectListItem { Value = "MUR", Text = "Mauritian Rupee (MUR)" });
            _result.Add(new SelectListItem { Value = "MVR", Text = "Maldivian Rufiyaa (MVR)" });
            _result.Add(new SelectListItem { Value = "MXN", Text = "Mexican Peso (MXN)" });
            _result.Add(new SelectListItem { Value = "MYR", Text = "Malaysian Ringgit (MYR)" });
            _result.Add(new SelectListItem { Value = "NAD", Text = "Namibian Dollar (NAD)" });
            _result.Add(new SelectListItem { Value = "NGN", Text = "Nigerian Naira (NGN)" });
            _result.Add(new SelectListItem { Value = "NIO", Text = "Nicaraguan Córdoba (NIO)" });
            _result.Add(new SelectListItem { Value = "NOK", Text = "Norwegian Krone (NOK)" });
            _result.Add(new SelectListItem { Value = "NPR", Text = "Nepalese Rupee (NPR)" });
            _result.Add(new SelectListItem { Value = "NZD", Text = "New Zealand Dollar (NZD)" });
            _result.Add(new SelectListItem { Value = "OMR", Text = "Omani Rial (OMR)" });
            _result.Add(new SelectListItem { Value = "PEN", Text = "Peruvian Nuevo Sol (PEN)" });
            _result.Add(new SelectListItem { Value = "PGK", Text = "Papua New Guinean Kina (PGK)" });
            _result.Add(new SelectListItem { Value = "PHP", Text = "Philippine Peso (PHP)" });
            _result.Add(new SelectListItem { Value = "PKR", Text = "Pakistani Rupee (PKR)" });
            _result.Add(new SelectListItem { Value = "PLN", Text = "Polish Zloty (PLN)" });
            _result.Add(new SelectListItem { Value = "PYG", Text = "Paraguayan Guarani (PYG)" });
            _result.Add(new SelectListItem { Value = "QAR", Text = "Qatari Rial (QAR)" });
            _result.Add(new SelectListItem { Value = "RON", Text = "Romanian Leu (RON)" });
            _result.Add(new SelectListItem { Value = "RSD", Text = "Serbian Dinar (RSD)" });
            _result.Add(new SelectListItem { Value = "RUB", Text = "Russian Ruble (RUB)" });
            _result.Add(new SelectListItem { Value = "SAR", Text = "Saudi Riyal (SAR)" });
            _result.Add(new SelectListItem { Value = "SCR", Text = "Seychellois Rupee (SCR)" });
            _result.Add(new SelectListItem { Value = "SEK", Text = "Swedish Krona (SEK)" });
            _result.Add(new SelectListItem { Value = "SGD", Text = "Singapore Dollar (SGD)" });
            _result.Add(new SelectListItem { Value = "SKK", Text = "Slovak Koruna (SKK)" });
            _result.Add(new SelectListItem { Value = "SLL", Text = "Sierra Leonean Leone (SLL)" });
            _result.Add(new SelectListItem { Value = "SVC", Text = "Salvadoran Colón (SVC)" });
            _result.Add(new SelectListItem { Value = "THB", Text = "Thai Baht (THB)" });
            _result.Add(new SelectListItem { Value = "TND", Text = "Tunisian Dinar (TND)" });
            _result.Add(new SelectListItem { Value = "TRY", Text = "Turkish Lira (TRY)" });
            _result.Add(new SelectListItem { Value = "TTD", Text = "Trinidad and Tobago Dollar (TTD)" });
            _result.Add(new SelectListItem { Value = "TWD", Text = "New Taiwan Dollar (TWD)" });
            _result.Add(new SelectListItem { Value = "TZS", Text = "Tanzanian Shilling (TZS)" });
            _result.Add(new SelectListItem { Value = "UAH", Text = "Ukrainian Hryvnia (UAH)" });
            _result.Add(new SelectListItem { Value = "UGX", Text = "Ugandan Shilling (UGX)" });
            _result.Add(new SelectListItem { Value = "USD", Text = "US Dollar (USD)" });
            _result.Add(new SelectListItem { Value = "UYU", Text = "Uruguayan Peso (UYU)" });
            _result.Add(new SelectListItem { Value = "UZS", Text = "Uzbekistan Som (UZS)" });
            _result.Add(new SelectListItem { Value = "VEF", Text = "Venezuelan Bolívar (VEF)" });
            _result.Add(new SelectListItem { Value = "VND", Text = "Vietnamese Dong (VND)" });
            _result.Add(new SelectListItem { Value = "XOF", Text = "CFA Franc BCEAO (XOF)" });
            _result.Add(new SelectListItem { Value = "YER", Text = "Yemeni Rial (YER)" });
            _result.Add(new SelectListItem { Value = "ZAR", Text = "South African Rand (ZAR)" });
            _result.Add(new SelectListItem { Value = "ZMK", Text = "Zambian Kwacha (ZMK)" });

            return _result;
        }

        public JsonResult Converter(decimal? amount, string fromCurrency, string toCurrency)
        {
            decimal amount1 = Convert.ToDecimal(amount);
            List<decimal> result = new List<decimal>();
            result.Add(ConvertToGoogle(amount1, fromCurrency, toCurrency));
            result.Add(ConvertToYahoo(amount1, fromCurrency, toCurrency));
            return Json(result);
        }

        private decimal ConvertToGoogle(decimal amount, string fromCurrency, string toCurrency)
        {


            WebClient web = new WebClient();
            string url = string.Format("http://www.google.com/ig/calculator?hl=en&q={2}{0}%3D%3F{1}", fromCurrency.ToUpper(), toCurrency.ToUpper(), amount);
            string response = web.DownloadString(url);
            Regex regex = new Regex("rhs: \\\"(\\d*.\\d*)");
            decimal rate = System.Convert.ToDecimal(regex.Match(response).Groups[1].Value);
            return rate;
        }

        private decimal ConvertToYahoo(decimal amount, string fromCurrency, string toCurrency)
        {
            WebClient web = new WebClient();
            string url = string.Format("http://finance.yahoo.com/d/quotes.csv?e=.csv&f=sl1d1t1&s={0}{1}=X", fromCurrency.ToUpper(), toCurrency.ToUpper());
            string response = web.DownloadString(url);
            string[] values = Regex.Split(response, ",");
            decimal rate = System.Convert.ToDecimal(values[1]);
            return rate * amount;
        }
    }
}
