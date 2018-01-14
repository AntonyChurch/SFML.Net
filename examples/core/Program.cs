using System;
using System.Runtime.InteropServices;
using SFML.Window;
using SFML.System;
using SFML.Graphics;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;


namespace core
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            RenderWindow window = new RenderWindow(new VideoMode(800, 600), "This is a winner");
            CircleShape circle = new CircleShape(100.0f);
            circle.FillColor = SFML.Graphics.Color.Green;

            while(window.IsOpen)
            {
                // SFML.Window.Event event = new SFML.Window.Event();
                // while(window.PollEvent(out event))
                // {
                //     if (event.Type == EventType.Closed)
                //     {
                //         window.Close();
                //     }
                // }

                window.Clear();
                window.Draw(circle);
                window.Display();
            }
        }
    }
}
