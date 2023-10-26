using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.GisMap
{
    internal class LayerManager
    {
        public void AddLayer()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = @"Shapefiles (*.shp)|*.shp";
            if (ofd.ShowDialog() == true)
            {
                
            }
        }
    }
}
