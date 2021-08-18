using AgustosMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgustosMarket.ViewModels
{
    public class HomeViewModels
    {
        public int? SeciliKategoriId { get; set; }
        public List<Kategori> Kategoriler { get; set; }
        public List<Urun> Urunler { get; set; }
    }
}
