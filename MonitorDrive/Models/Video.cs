using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorDrive.Models
{
    public class Video
    {
        public string Titulo { get; set; }
        public string Duracion { get; set; }
        public string Url { get; set; } // URL del video
        public string IframeHtml { get; set; } // Código HTML del iframe
    }
}
