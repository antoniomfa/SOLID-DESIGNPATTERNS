using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Strategy
{
    public class VideoStorage
    {
        private Compressors _compressor;
        private Overlays _overlay;

        public VideoStorage(Compressors compressors, Overlays overlay = Overlays.None)
        {
            _compressor = compressors;
            _overlay = overlay;
        }

        public void SetCompressor(Compressors compressor)
        {
            _compressor = compressor;
        }

        public void SetOverlay(Overlays overlay)
        {
            _overlay = overlay;
        }

        // BAD PRACTICE!!! IF ENUMS CHANGE WE HAVE TO CHANGE THIS EVERYTIME
        public void Store(string filename)
        {
            if (_compressor == Compressors.MOV)
            {
                Console.WriteLine("Compressing using MOV ...");
            }
            else if (_compressor == Compressors.MP4)
            {
                Console.WriteLine("Compressing using MP4 ...");
            }
            else if (_compressor == Compressors.WEBM)
            {
                Console.WriteLine("Compressing using WEBM ...");
            }

            if (_overlay == Overlays.BlackAndWhite)
            {
                    Console.WriteLine("Applying overlay BlackAndWhite ...");
            }
            else if (_overlay == Overlays.Blur)
            {
                Console.WriteLine("Applying overlay Blur ...");
            }
            else if (_overlay == Overlays.None)
            {
                Console.WriteLine("Not applying an overlay ...");
            }

            Console.WriteLine("Storing video to: " + filename + _compressor);
        }
    }
}
