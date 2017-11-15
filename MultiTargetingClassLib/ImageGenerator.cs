using System;

namespace MultiTargetingClassLib
{
    public class ImageGenerator
    {

        //Note the csproj defines three compilation targets
        //<TargetFrameworks>netstandard2.0;netcoreapp2.0;net461;</TargetFrameworks>

        public void DoIt()
        {
            Console.WriteLine("Generating image");
#if NETSTANDARD2_0
            //need third party image library or for ex. windows compat pack
            
#elif NET461
            var bitmap = new System.Drawing.Bitmap("anypath.bmp");
#endif
        }
    }
}
