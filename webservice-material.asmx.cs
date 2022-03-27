using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MaterialWebApplication
{
    /// <summary>
    /// Summary description for WebService1Material
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1Material : System.Web.Services.WebService
    {

        [WebMethod]
        public int GetDeveloped(int umid, int aid)
        {
            string developed_material_document = "developed_material_document";
	    return developed_material_document;
        }

	public int GetPurchased(int umid)
        {
            string purchased_material_document = "purchased_material_document";
	    return purchased_material_document;
        }

	public int ReportStockLevels(int umid)
        {
            int stock_level_value = 3;
	    return stock_level_value;
        }
    }
}