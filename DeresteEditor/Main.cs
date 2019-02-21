// C# example program to demonstrate OpenTK

//

// Steps:

// 1. Create an empty C# console application project in Visual Studio

// 2. Place OpenTK.dll in the directory of the C# source file

// 3. Add System.Drawing and OpenTK as References to the project

// 4. Paste this source code into the C# source file

// 5. Run. You should see a colored triangle. Press ESC to quit.

//

// Copyright (c) 2013 Ashwin Nanjappa

// Released under the MIT License



using System;

using OpenTK;

using OpenTK.Graphics;

using OpenTK.Graphics.OpenGL;

using OpenTK.Input;



namespace NotemapEditor

{

    class Game : GameWindow

    {
        public Game()

            : base(800, 600, GraphicsMode.Default, "OpenTK Quick Start Sample")

        {

            VSync = VSyncMode.On;

        }



        protected override void OnLoad(EventArgs e)

        {

            base.OnLoad(e);

            GL.ClearColor(0.1f, 0.2f, 0.5f, 0.0f);

            GL.Enable(EnableCap.DepthTest);

        }



        protected override void OnResize(EventArgs e)

        {

            base.OnResize(e);



            GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);



            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)Math.PI / 4, Width / (float)Height, 1.0f, 64.0f);

            GL.MatrixMode(MatrixMode.Projection);

            GL.LoadMatrix(ref projection);

        }



        protected override void OnUpdateFrame(FrameEventArgs e)

        {

            base.OnUpdateFrame(e);

            if (Keyboard.GetState().IsKeyDown(Key.Escape))
                Exit();

        }



        protected override void OnRenderFrame(FrameEventArgs e)

        {

            base.OnRenderFrame(e);



            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);



            Matrix4 modelview = Matrix4.LookAt(Vector3.Zero, Vector3.UnitZ, Vector3.UnitY);

            GL.MatrixMode(MatrixMode.Modelview);

            GL.LoadMatrix(ref modelview);



            GL.Begin(BeginMode.Triangles);



            GL.Color3(1.0f, 1.0f, 0.0f); GL.Vertex3(-1.0f, -1.0f, 4.0f);

            GL.Color3(1.0f, 0.0f, 0.0f); GL.Vertex3(1.0f, -1.0f, 4.0f);

            GL.Color3(0.2f, 0.9f, 1.0f); GL.Vertex3(0.0f, 1.0f, 4.0f);



            GL.End();



            SwapBuffers();

        }



        [STAThread]

        static void Main()
        {
            // The 'using' idiom guarantees proper resource cleanup.
            // We request 30 UpdateFrame events per second, and unlimited
            // RenderFrame events (as fast as the computer can handle).

            //Test code
            NoteFile nf=new NoteFile("hello");
            nf.AddTapNote(1, 1);
            nf.AddTapNote(1, 5);
            nf.AddTapNote(2, 1);
            nf.AddTapNote(2, 5);
            nf.AddTapNote(5, 1);
            nf.AddTapNote(5, 5);
            nf.AddTapNote(6, 1);
            nf.AddTapNote(6, 5);
            nf.Write();

            using (Game game = new Game())
            {
                game.Run(30.0);
            }
        }
    }
}