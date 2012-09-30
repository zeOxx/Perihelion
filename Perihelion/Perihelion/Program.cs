using System;

namespace Perihelion
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (cameraTest game = new cameraTest())
            {
                game.Run();
            }
        }
    }
#endif
}

