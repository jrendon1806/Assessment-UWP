using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace Assessment.ViewModels
{
    public class Item
    {
        public string Name { get; set; }
        public Brush ColorCode { get; set; }
        public ImageSource Image { get; set; }
        public bool IsImageSelected { get; set; }
        public bool IsPhotoSelected { get; set; }
    }
}
