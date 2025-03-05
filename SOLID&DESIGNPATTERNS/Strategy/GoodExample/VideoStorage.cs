using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DESIGNPATTERNS.Strategy.GoodExample
{
    public class VideoStorage
    {
        private ICompressor _compressor;
        private IOverlay _overlay;

        public VideoStorage(ICompressor compressor, IOverlay overlay)
        {
            _compressor = compressor;
            _overlay = overlay;
        }

        public void SetCompressor(ICompressor compressor)
        {
            _compressor = compressor;
        }

        public void SetOverlay(IOverlay overlay)
        {
            _overlay = overlay;
        }

        // OK
        public void Store(string filename)
        {
            _compressor.Compress();
            _overlay.Apply();

            Console.WriteLine("Storing video to: " + filename + _compressor + "\n");
        }
    }
}
