using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUICBSData.MainScreen
{
    class SelectValue
    {
        public string Origenal;
        private string MooiUitZiendeStringVoorRubenVanDenEngel = "";
        public SelectValue(string origenal)
        {
            // TODO: Complete member initialization
            this.Origenal = origenal;

            this.MooiUitZiendeStringVoorRubenVanDenEngel = origenal;
            int index_ = this.MooiUitZiendeStringVoorRubenVanDenEngel.IndexOf('_');

            if(index_!=-1)
            {
                this.MooiUitZiendeStringVoorRubenVanDenEngel = this.MooiUitZiendeStringVoorRubenVanDenEngel.Remove(index_);
            }

            try
            {
                List<char> gehad = new List<char>();
                foreach(char hoofletter in this.MooiUitZiendeStringVoorRubenVanDenEngel.Where(x => (int)x < 91 && (int)x>64))
                {
                    if(!gehad.Exists(x=>x==hoofletter))
                    {
                        gehad.Add(hoofletter);
                        this.MooiUitZiendeStringVoorRubenVanDenEngel = this.MooiUitZiendeStringVoorRubenVanDenEngel.Replace(hoofletter.ToString(), " " + hoofletter);
                    }
                }                
            }
            catch { }
        }

        public override string ToString()
        {
            return this.MooiUitZiendeStringVoorRubenVanDenEngel;
        }
    }
}
