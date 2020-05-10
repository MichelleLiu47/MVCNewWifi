using MVCNewWifi.Models;
using PagedList;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCNewWifi.ViewModels
{
    public class HotSpotViewModel
    {
        public HotSpotSearchModel SearchParameter { get; set; }

        public IPagedList<HotSpot> HotSpots { get; set; }

        public List<SelectListItem> Districts { get; set; }

        public List<SelectListItem> HotSpotTypes { get; set; }

        public List<SelectListItem> Companys { get; set; }

        public int PageIndex { get; set; }
    }
}