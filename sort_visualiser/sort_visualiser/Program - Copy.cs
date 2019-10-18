using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.Runtime.InteropServices;

namespace sort_visualiser
{
    class Program
    {
        static void Main(string[] args)
        {
            

            biggay yeet = new biggay(800, 400);
            yeet.VSync = VSyncMode.Off;
            yeet.Run();

        }
    }

    class biggay : GameWindow
    {
        public biggay(int width, int height) : base(width, height)
        {
        }

        public List<int[]> snapshop = new List<int[]>();
        //public List<int> cursorPoses = new List<int>();
        public int[] array = new int[1000];

        public float stretchX = 0.8f;
        public float stretchY = 0.4f;

        int index = 0;
        Random rand;
        Matrix4 projMatrix;
        int snapshotCount = 0;

        float timeCounter = 0;
        float fpsMedian = 0;
        float fps = 0;
        float num = 0;
        double sec_elapsed_time;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            projMatrix = Matrix4.CreateOrthographicOffCenter(0, Width, Height, 0, 0, 1);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projMatrix);


            

            rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                dT();
                
            }

            stretchX = (float)Width / (float)array.Length;
            stretchY = (float)Height / (float)array.Length;

            //   Shuffle();
            //   MergeSort(array, 0, array.Length - 1);
            //   Shuffle();
            //   IntArrayShellSortNaive(array);
            Shuffle();
            // IntArrayQuickSort(array);
            GravitySort(array);
         //      Shuffle();
         //      IntArraySelectionSort(array);
         //     Shuffle();
         //     BubbleSort(array);
         //     Shuffle();
         //   Shuffle();
         //   ShakerSort(array);
        }

        public void BeadSort(int[] data)
        {
            int i, j, max, sum;
            byte[] beads;

            for (i = 1, max = data[0]; i < data.Length; ++i)
                if (data[i] > max)
                    max = data[i];

            beads = new byte[max * data.Length];

            for (i = 0; i < data.Length; ++i)
                for (j = 0; j < data[i]; ++j)
                    beads[i * max + j] = 1;

            for (j = 0; j < max; ++j)
            {
                for (sum = i = 0; i < data.Length; ++i)
                {
                    sum += beads[i * max + j];
                    beads[i * max + j] = 0;
                    


                }

                for (i = data.Length - sum; i < data.Length; ++i)
                {
                    beads[i * max + j] = 1;
                    
                }
            }

            for (i = 0; i < data.Length; ++i)
            {
                for (j = 0; j < max && Convert.ToBoolean(beads[i * max + j]); ++j)
                {
                    data[i] = j;

                }
                //dT();
            }

        }

        public void GravitySort (int[] array)
        {
            int max = array.Max();
            int[][] abacus = new int[array.Length][];

            for (int i = 0; i < abacus.Length; i++)
            {
                abacus[i] = new int[max];
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i]; j++)
                    abacus[i][abacus[0].Length - j - 1] = 1;
            }
            //apply gravity
            for (int i = 0; i < abacus[0].Length; i++)
            {
               

                for (int j = 0; j < abacus.Length; j++)
                {
                    if (abacus[j][i] == 1)
                    {
                        //Drop it
                        int droppos = j;
                        while (droppos + 1 < abacus.Length && abacus[droppos][i] == 1)
                            droppos++;
                        if (abacus[droppos][i] == 0)
                        {
                            abacus[j][i] = 0;
                            abacus[droppos][i] = 1;
                           
                        }
                    }
                }

              

                int count = 0;
                for (int x = 0; x < abacus.Length; x++)
                {
                    count = 0;
                    for (int y = 0; y < abacus[0].Length; y++)
                        count += abacus[x][y];
                    array[x] = count;
                   
                   // sleep(0.002);
                }
               dT();

                
            }
          
        }

         void ShakerSort(int[] array)
        {
            bool isSwapped = true;
            int start = 0;
            int end = array.Length;

            while (isSwapped == true)
            {

                
                isSwapped = false;

                
                for (int i = start; i < end - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        isSwapped = true;
                        dT();
                    }
                }

               
                if (isSwapped == false)
                    break;

                
                isSwapped = false;

                
                end = end - 1;

                
                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        isSwapped = true;
                        dT();
                    }
                }

                
                start = start + 1;
            }
        }

        public void BubbleSort(int[] arr)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        dT();
                    }
                }
            }
        }

        public void IntArrayQuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    exchange(data, i, j);
                    i++;
                    j--;


                }
                if (i > j)
                    break;
            }

            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
        }

        public void IntArrayQuickSort(int[] data)
        {
            IntArrayQuickSort(data, 0, data.Length - 1);
        }

        public int IntArrayMin(int[] data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])
                    minPos = pos;
            return minPos;
        }

        public void IntArraySelectionSort(int[] data)
        {
            int i;
            int N = data.Length;

            for (i = 0; i < N - 1; i++)
            {
                int k = IntArrayMin(data, i);
                if (i != k)
                    exchange(data, i, k);
            }
        }

        private void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
                dT();
            }
        }

        private void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);

                Merge(input, left, middle, right);
            }
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            sec_elapsed_time = e.Time;

            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.ClearColor(Color.White);

            GL.Color4(Color4.Black);


          //  GL.PointSize(4);
          //  GL.Begin(PrimitiveType.Points);
          //
          //  
          //  for (int i = 0; i < snapshop[index].Length; i++)
          //  {
          //      
          //      GL.Vertex2(stretchX* i, Height -stretchY* snapshop[index][i]);
          //     ;
          //      //Console.Beep(snapshop[index][i] + 500, 1);
          //     
          //  }
          //  GL.End();

              GL.Color4(Color4.Black);
            GL.LineWidth(4);
            GL.Begin(PrimitiveType.Lines);
            for (int i = 0; i < snapshop[index].Length; i++)
              {
                    
                    
                    GL.Vertex2( stretchX*i, Height);
                    GL.Vertex2( stretchX*i, Height- stretchY* snapshop[index][i]);
                    
            
            
                //  drawColoredQuad( (int)  (stretchX* i),(int) Height,(int) stretchX,(int)( Height - (stretchY * snapshop[index][i])),Color.Blue);
                 
              }
            GL.End();
            index++;
            if (index > snapshotCount-1)
                index = 0;
            Thread.Sleep(5);









            timeCounter += (float)sec_elapsed_time;
            fpsMedian += 1f / (float)sec_elapsed_time;
            num++;
            if (timeCounter >= 1)
            {
                timeCounter = 0;
                fpsMedian = fpsMedian / num;
                fps = (float)Math.Round(fpsMedian);
                fpsMedian = 0;
                num = 0;
                Console.WriteLine(fps.ToString());
            }

            //Console.WriteLine(fps.ToString());

            this.SwapBuffers();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }

        public void IntArrayShellSort(int[] data, int[] intervals)
        {
            int i, j, k, m;
            int N = data.Length;

            // The intervals for the shell sort must be sorted, ascending

            for (k = intervals.Length - 1; k >= 0; k--)
            {
                int interval = intervals[k];
                for (m = 0; m < interval; m++)
                {
                    for (j = m + interval; j < N; j += interval)
                    {
                        for (i = j; i >= interval && data[i] < data[i - interval]; i -= interval)
                        {
                            exchange(data, i, i - interval);
                        }
                    }
                }
            }
        }

        public void IntArrayShellSortNaive(int[] data)
        {
            int[] intervals = { 1, 2, 4, 8 };
            IntArrayShellSort(data, intervals);
        }

        public void Shuffle()
        {
            for (int i = 0; i < array.Length; i++)
            {
                swap(ref array[i], ref array[rand.Next(0, array.Length)]);
                dT();
                Thread.Sleep(0);

            }
        }

        public void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;

            dT();
            //dT(n);
        }

        public void dT()
        {
            int[] copyArray = new int[array.Length];
            Array.Copy(array, copyArray, array.Length);
            snapshop.Add(copyArray);
            //cursorPoses.Add()
            snapshotCount++;
        }

        public void dT(int[] arr)
        {
            int[] copyArray = new int[arr.Length];
            Array.Copy(arr, copyArray, arr.Length);
            snapshop.Add(copyArray);
            //cursorPoses.Add()
            snapshotCount++;
        }

        void swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void drawColoredQuad(int x, int y, int x2, int y2, Color c)
        {
            GL.Color4((byte)c.R, (byte)c.G, (byte)c.B, (byte)c.A);
            GL.Begin(PrimitiveType.Triangles);
            GL.Vertex3(x, y, 0);
            GL.Vertex3(x2 + x, y2 + y, 0);
            GL.Vertex3(x, y2 + y, 0);

            GL.Vertex3(x, y,0);
            GL.Vertex3(x2 + x, y, 0);
            GL.Vertex3(x2 + x, y2 + y, 0);
            GL.End();
        }
    }

    public class UiClass : GameWindow
    {
        public KeyboardState ks;
        public KeyboardState old_ks;
        public MouseState ms;
        public MouseState old_ms;
        public Vector2 oldMousePoint = new Vector2(0, 0);
        public Vector2 newMousePoint;
        public Vector2 mouseMovment;

        public struct KeyState
        {
            public bool bPressed;
            public bool bReleased;
            public bool bHeld;
        }

        public long[] keyNewState = new long[256];
        public long[] keyOldState = new long[256];
        public KeyState[] keys = new KeyState[256];

        public List<UiElement> uiElements;

        /// <summary>
        /// mouse screen coords
        /// </summary>
        public Point msc;

        public int oldScrollWheelValue = 0;
        public int newScrollWheelValue;
        public int scrollWheelChange = 0;

        public static UiClass inst;

        public char currentKeyboardPressedChar;
        public bool caps_toggle;

        public Texture2D[] charTextures;
        int fontSize = 12;
        public Texture2D firstCharTexture;
        //500
        public int textureFontSize = 50;

        #region constructor

        public UiClass(int width, int height) : base(width, height)
        {
        }
        public UiClass(int width, int height, GraphicsMode mode) : base(width, height, mode)
        {
        }
        public UiClass(int width, int height, GraphicsMode mode, string title, GameWindowFlags options) : base(width, height, mode, title, options)
        {
        }
        public UiClass(int width, int height, GraphicsMode mode, string title, GameWindowFlags options, DisplayDevice device) : base(width, height, mode, title, options, device)
        {
        }
        public UiClass(int width, int height, GraphicsMode mode, string title, GameWindowFlags options, DisplayDevice device, int major, int minor, GraphicsContextFlags flags, IGraphicsContext sharedContext) : base(width, height, mode, title, options, device, major, minor, flags, sharedContext)
        {
        }
        public UiClass(int width, int height, GraphicsMode mode, string title, GameWindowFlags options, DisplayDevice device, int major, int minor, GraphicsContextFlags flags, IGraphicsContext sharedContext, bool isSingleThreaded) : base(width, height, mode, title, options, device, major, minor, flags, sharedContext, isSingleThreaded)
        {
        }

        #endregion

        public int Clamp(int x, int lowerbound, int upperbound)
        {
            if (x > upperbound)
                x = upperbound;
            if (x < lowerbound)
                x = lowerbound;
            return x;
        }
        public float Clamp(float x, float lowerbound, float upperbound)
        {
            if (x > upperbound)
                x = upperbound;
            if (x < lowerbound)
                x = lowerbound;
            return x;
        }
        public bool isInt(float d)
        {
            //checking the thing to do the thing
            return ((d % 1) == 0);
        }

        public float makeInRange(float value, float OldMin, float OldMax, float NewMax, float NewMin)
        {
            float NewValue = (((value - OldMin) * (NewMax - NewMin)) / (OldMax - OldMin)) + NewMin;
            return NewValue;
        }

        #region Drawing functions
        public void drawColoredQuadNonRelative(int x, int y, int x2, int y2, Color c)
        {
            GL.Color4((byte)c.R, (byte)c.G, (byte)c.B, (byte)c.A);
            GL.Begin(PrimitiveType.Triangles);
            GL.Vertex2(x, y);
            GL.Vertex2(x2 + x, y2 + y);
            GL.Vertex2(x, y2 + y);

            GL.Vertex2(x, y);
            GL.Vertex2(x2 + x, y);
            GL.Vertex2(x2 + x, y2 + y);
            GL.End();
        }
        public void drawColoredQuad(int x, int y, int x2, int y2, Color c, float zLayer = 1)
        {
            GL.Color4((byte)c.R, (byte)c.G, (byte)c.B, (byte)c.A);
            GL.Begin(PrimitiveType.Triangles);
            GL.Vertex3(x, y, zLayer);
            GL.Vertex3(x2 + x, y2 + y, zLayer);
            GL.Vertex3(x, y2 + y, zLayer);

            GL.Vertex3(x, y, zLayer);
            GL.Vertex3(x2 + x, y, zLayer);
            GL.Vertex3(x2 + x, y2 + y, zLayer);
            GL.End();
        }
        public static void DrawCircleGL(float x, float y, float radius, Color4 c)
        {
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color4(c);

            GL.Vertex2(x, y);
            for (int i = 0; i < 360; i++)
            {
                GL.Vertex2(x + Math.Cos(i) * radius, y + Math.Sin(i) * radius);
            }

            GL.End();
        }
        public static void DrawRingGL1(float x, float y, float radius, Color4 c)
        {
            GL.Begin(PrimitiveType.TriangleStrip);
            GL.Color4(c);

            GL.Vertex2(x, y);
            for (int i = 0; i < 360; i++)
            {
                GL.Vertex2(x + Math.Cos(i) * radius, y + Math.Sin(i) * radius);
            }

            GL.End();
        }
        public static void DrawRingGL2(float x, float y, float radius, Color4 c, Color4 midColor)
        {
            DrawCircleGL(x, y, radius, c);
            DrawCircleGL(x, y, radius - 1, midColor);
        }
        public void Draw(int x, int y, float pointSize, Color c, bool reversed = false, bool quickDraw = false, bool reverseX = false, bool center = false, bool clamp = false)
        {
            //calculations to modify the points according to the params
            int x2 = x;
            int y2 = y;
            if (center)
            {
                x2 = Width / 2 + x2;
                y2 = Height / 2 + y2;
            }

            if (reversed == true)
            {
                y2 = (Height - 1) - y2;
            }
            if (reverseX == true)
            {
                x2 = (Width - 1) - x2;
            }
            //if the gl is on, drawing points using it
            GL.PointSize(pointSize);
            GL.Begin(PrimitiveType.Points);
            //setting point color
            GL.Color4((byte)c.R, (byte)c.G, (byte)c.B, (byte)c.A);
            GL.Vertex2(x2, y2);
            GL.End();
        }

        public void Fill(int x1, int y1, int x2, int y2, Color c, bool reversed = false, bool quickDraw = false, bool reverseX = false)
        {
            // x2 += x1;
            // y2 += y1;
            //looping through all of the pixels to set then to the color
            for (int x = x1; x < x2; x++)
            {
                for (int y = y1; y < y2; y++)
                {
                    Draw(x, y, 1, c, reversed, quickDraw, reverseX);
                    //Thread.Sleep(100);
                }
                //Thread.Sleep(100);
            }
        }
        public void drawLine0(int x, int y, int x2, int y2, float thickness, Color c, bool reversed = false, bool quickDraw = false, bool reverseX = false, bool center = false, bool clamp = false)
        {
            //just ye'ol inneficient algorithm from wikipedia
            int w = x2 - x;
            int h = y2 - y;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;

            if (w < 0)
                dx1 = -1;
            else if (w > 0)
                dx1 = 1;

            if (h < 0)
                dy1 = -1;
            else if (h > 0)
                dy1 = 1;

            if (w < 0)
                dx2 = -1;
            else if (w > 0)
                dx2 = 1;

            int longest = Math.Abs(w);
            int shortest = Math.Abs(h);

            if (!(longest > shortest))
            {
                longest = Math.Abs(h);
                shortest = Math.Abs(w);

                if (h < 0)
                    dy2 = -1;
                else if (h > 0)
                    dy2 = 1;

                dx2 = 0;
            }

            int numerator = longest >> 1;

            for (int i = 0; i <= longest; i++)
            {
                Draw(x, y, thickness, c, reversed, quickDraw, reverseX, center, clamp);

                numerator += shortest;

                if (!(numerator < longest))
                {
                    numerator -= longest;
                    x += dx1;
                    y += dy1;
                }
                else
                {
                    x += dx2;
                    y += dy2;
                }
            }
        }
        public void drawLine1(int x, int y, int x2, int y2, float thickness, Color c, bool reversed = false, bool quickDraw = false, bool reverseX = false, bool center = false, bool clamp = false)
        {
            //calculations to modify the points according to the params
            if (clamp == true)
            {
                y = Clamp(y, 0, Height - 1);
                x = Clamp(x, 0, Width - 1);
                y2 = Clamp(y, 0, Height - 1);
                x2 = Clamp(x, 0, Width - 1);
            }
            int x3 = x;
            int y3 = y;

            int x4 = x2;
            int y4 = y2;
            if (center)
            {
                x3 = Width / 2 + x3;
                y3 = Height / 2 + y3;

                x4 = Width / 2 + x4;
                y4 = Height / 2 + y4;
            }

            if (reversed == true)
            {
                y3 = (Height - 1) - y3;
                y4 = (Height - 1) - y4;
            }
            if (reverseX == true)
            {
                x3 = (Width - 1) - x3;
                x4 = (Width - 1) - x4;
            }
            //using gl to draw the line
            GL.LineWidth(thickness);
            GL.Begin(PrimitiveType.Lines);

            GL.Color4((byte)c.R, (byte)c.G, (byte)c.B, (byte)c.A);
            GL.Vertex2(x3, y3);
            GL.Vertex2(x4, y4);
            GL.End();
        }
        public void drawLine2(int x, int y, int x2, int y2, Color c, bool reversed = false, bool quickDraw = false, bool reverseX = false, bool center = false, bool clamp = false)
        {
            float num = 1;
            //calculations to modify the points according to the params
            if (clamp == true)
            {
                y = Clamp(y, 0, Height - 1);
                x = Clamp(x, 0, Width - 1);
                y2 = Clamp(y, 0, Height - 1);
                x2 = Clamp(x, 0, Width - 1);
            }
            int x3 = x;
            int y3 = y;

            int x4 = x2;
            int y4 = y2;
            if (center)
            {
                x3 = Width / 2 + x3;
                y3 = Height / 2 + y3;

                x4 = Width / 2 + x4;
                y4 = Height / 2 + y4;
            }

            if (reversed == true)
            {
                y3 = (Height - 1) - y3;
                y4 = (Height - 1) - y4;
            }
            if (reverseX == true)
            {
                x3 = (Width - 1) - x3;
                x4 = (Width - 1) - x4;
            }
            //using gl to draw the line

            //GL.Begin(PrimitiveType.Lines);

            GL.Color4((byte)c.R, (byte)c.G, (byte)c.B, (byte)c.A);

            GL.Vertex2(x3, y3);
            GL.Vertex2(x4, y4);

            //GL.End();


        }
        //dont know dont care
        public void circleBres(int xc, int yc, int r, float thickness, Color c, bool center = false)
        {
            int x = 0, y = r;
            int d = 3 - 2 * r;
            drawCircle(xc, yc, x, y, thickness, c, center);
            while (y >= x)
            {
                // for each pixel we will 
                // draw all eight pixels 

                x++;

                // check for decision parameter 
                // and correspondingly  
                // update d, x, y 
                if (d > 0)
                {
                    y--;
                    d = d + 4 * (x - y) + 10;
                }
                else
                    d = d + 4 * x + 6;
                drawCircle(xc, yc, x, y, thickness, c, center);
            }
        }
        public void drawCircle(int xc, int yc, int x, int y, float thickness, Color c, bool center = false)
        {
            Draw((xc + x), (yc + y), thickness, c, false, false, false, center);
            Draw((xc - x), (yc + y), thickness, c, false, false, false, center);
            Draw((xc + x), (yc - y), thickness, c, false, false, false, center);
            Draw((xc - x), (yc - y), thickness, c, false, false, false, center);
            Draw((xc + y), (yc + x), thickness, c, false, false, false, center);
            Draw((xc - y), (yc + x), thickness, c, false, false, false, center);
            Draw((xc + y), (yc - x), thickness, c, false, false, false, center);
            Draw((xc - y), (yc - x), thickness, c, false, false, false, center);
        }

        /// <summary>
        /// Always use GL.Enable(EnableCap.Texture2D) before running a cluster of these and GL.Disable(EnableCap.Texture2D) after
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="texture"></param>
        public void drawQuadWithTexture(int x, int y, int x2, int y2, int texture)
        {
            GL.Color4((byte)255, (byte)255, (byte)255, (byte)255);
            GL.BindTexture(TextureTarget.Texture2D, texture);

            GL.Begin(PrimitiveType.Triangles);
            GL.TexCoord2(0, 0); GL.Vertex2(x, y);
            GL.TexCoord2(1, 1); GL.Vertex2(x2 + x, y2 + y);
            GL.TexCoord2(0, 1); GL.Vertex2(x, y2 + y);

            GL.TexCoord2(0, 0); GL.Vertex2(x, y);
            GL.TexCoord2(1, 0); GL.Vertex2(x2 + x, y);
            GL.TexCoord2(1, 1); GL.Vertex2(x2 + x, y2 + y);

            GL.End();
        }
        public void drawColoredQuad(int x, int y, int width, int height, Color c)
        {
            GL.Color4((byte)c.R, (byte)c.G, (byte)c.B, (byte)c.A);
            GL.Begin(PrimitiveType.Triangles);
            GL.Vertex2(x, y);
            GL.Vertex2(width + x, height + y);
            GL.Vertex2(x, height + y);

            GL.Vertex2(x, y);
            GL.Vertex2(width + x, y);
            GL.Vertex2(width + x, height + y);
            GL.End();
        }
        #endregion

        #region text functions

        public void DrawFormattedString(string s, int x, int y, float fontSize, Color bg)
        {
            string[] strs = s.Split('\n');

            for (int i = 0; i < strs.Length; i++)
            {
                DrawString(strs[i], x, (int)(y + i * (charTextures[0].Height / (textureFontSize / fontSize))), fontSize, bg);
            }
        }

        public void DrawString(string s, int x, int y, float fontSize, Color bg, bool evenSpacing = false)
        {
            int textOffset = 0;
            fontSize = textureFontSize / fontSize;

            for (int i = 0; i < s.Length; i++)
            {
                int index = FindCharInTextureArray(s[i]);
                GL.Enable(EnableCap.Texture2D);
                if (bg != Color.Transparent)
                {
                    GL.Disable(EnableCap.Texture2D);
                    drawColoredQuad(x + textOffset, y, (int)(charTextures[index].Width / fontSize), (int)(charTextures[index].Height / fontSize), bg);
                    GL.Enable(EnableCap.Texture2D);
                }
                drawQuadWithTexture(x + textOffset, y, (int)(charTextures[index].Width / fontSize), (int)(charTextures[index].Height / fontSize), charTextures[index].ID);
                GL.Disable(EnableCap.Texture2D);

                if (evenSpacing)
                {
                    if (s[i] != ' ')
                        textOffset += (int)(fontSize - 2);
                    else
                        textOffset += (int)(fontSize);
                }
                else
                {
                    if (s[i] != ' ')
                        textOffset += (int)(charTextures[index].Width / fontSize) - 2;
                    else
                        textOffset += (int)(charTextures[index].Width / fontSize);
                }
            }

        }

        public void drawBetterButSlowString(string s, int x, int y, int fontSize, Color bg, Color fg)
        {
            Bitmap b = new Bitmap(s.Length * fontSize, fontSize * 2);
            Graphics b_g = Graphics.FromImage(b);

            SizeF str_size = b_g.MeasureString(s, new Font(FontFamily.GenericSansSerif, fontSize), new SizeF(b.Width, b.Height));

            b_g.FillRectangle(new SolidBrush(bg), 0, 0, str_size.Width, str_size.Height);

            //b_g.DrawRectangle(new Pen(bg), x,y, s.Length * fontSize, y + fontSize * 2);
            b_g.DrawString(s, new Font(FontFamily.GenericSansSerif, fontSize), new SolidBrush(fg), 0, 0);

            //b.Save("arse.png");

            Texture2D texture = LoadTexture2D(b);

            GL.Enable(EnableCap.Texture2D);

            drawQuadWithTexture(x, y, texture.Width, texture.Height, texture.ID);

            GL.Disable(EnableCap.Texture2D);

            GL.DeleteTexture(texture.ID);
        }

        public int FindCharInTextureArray(char c)
        {
            int i = 0;
            if (c == 'q')
                i = 0;
            if (c == 'w')
                i = 1;
            if (c == 'e')
                i = 2;
            if (c == 'r')
                i = 3;
            if (c == 't')
                i = 4;
            if (c == 'y')
                i = 5;
            if (c == 'u')
                i = 6;
            if (c == 'i')
                i = 7;
            if (c == 'o')
                i = 8;
            if (c == 'p')
                i = 9;
            if (c == 'a')
                i = 10;
            if (c == 's')
                i = 11;
            if (c == 'd')
                i = 12;
            if (c == 'f')
                i = 13;
            if (c == 'g')
                i = 14;
            if (c == 'h')
                i = 15;
            if (c == 'j')
                i = 16;
            if (c == 'k')
                i = 17;
            if (c == 'l')
                i = 18;
            if (c == 'z')
                i = 19;
            if (c == 'x')
                i = 20;
            if (c == 'c')
                i = 21;
            if (c == 'v')
                i = 22;
            if (c == 'b')
                i = 23;
            if (c == 'n')
                i = 24;
            if (c == 'm')
                i = 25;
            if (c == 'Q')
                i = 26;
            if (c == 'W')
                i = 27;
            if (c == 'E')
                i = 28;
            if (c == 'R')
                i = 29;
            if (c == 'T')
                i = 30;
            if (c == 'Y')
                i = 31;
            if (c == 'U')
                i = 32;
            if (c == 'I')
                i = 33;
            if (c == 'O')
                i = 34;
            if (c == 'P')
                i = 35;
            if (c == 'A')
                i = 36;
            if (c == 'S')
                i = 37;
            if (c == 'D')
                i = 38;
            if (c == 'F')
                i = 39;
            if (c == 'G')
                i = 40;
            if (c == 'H')
                i = 41;
            if (c == 'J')
                i = 42;
            if (c == 'K')
                i = 43;
            if (c == 'L')
                i = 44;
            if (c == 'Z')
                i = 45;
            if (c == 'X')
                i = 46;
            if (c == 'C')
                i = 47;
            if (c == 'V')
                i = 48;
            if (c == 'B')
                i = 49;
            if (c == 'N')
                i = 50;
            if (c == 'M')
                i = 51;
            if (c == '0')
                i = 52;
            if (c == '1')
                i = 53;
            if (c == '2')
                i = 54;
            if (c == '3')
                i = 55;
            if (c == '4')
                i = 56;
            if (c == '5')
                i = 57;
            if (c == '6')
                i = 58;
            if (c == '7')
                i = 59;
            if (c == '8')
                i = 60;
            if (c == '9')
                i = 61;
            if (c == 'µ')
                i = 62;
            if (c == '§')
                i = 63;
            if (c == '½')
                i = 64;
            if (c == '!')
                i = 65;
            if (c == '"')
                i = 66;
            if (c == '#')
                i = 67;
            if (c == '¤')
                i = 68;
            if (c == '%')
                i = 69;
            if (c == '&')
                i = 70;
            if (c == '/')
                i = 71;
            if (c == '(')
                i = 72;
            if (c == ')')
                i = 73;
            if (c == '=')
                i = 74;
            if (c == '?')
                i = 75;
            if (c == '^')
                i = 76;
            if (c == '*')
                i = 77;
            if (c == '@')
                i = 78;
            if (c == '£')
                i = 79;
            if (c == '€')
                i = 80;
            if (c == '$')
                i = 81;
            if (c == '{')
                i = 82;
            if (c == '[')
                i = 83;
            if (c == ']')
                i = 84;
            if (c == '}')
                i = 85;
            if (c == "\\".ToCharArray()[0])
                i = 86;
            if (c == '~')
                i = 87;
            if (c == '¨')
                i = 88;
            if (c == "'".ToCharArray()[0])
                i = 89;
            if (c == '-')
                i = 90;
            if (c == '_')
                i = 91;
            if (c == '.')
                i = 92;
            if (c == ':')
                i = 93;
            if (c == ',')
                i = 94;
            if (c == ';')
                i = 95;
            if (c == '<')
                i = 96;
            if (c == '>')
                i = 97;
            if (c == '|')
                i = 98;
            if (c == '°')
                i = 99;
            if (c == '©')
                i = 100;
            if (c == '®')
                i = 101;
            if (c == '±')
                i = 102;
            if (c == '¥')
                i = 103;
            if (c == ' ')
                i = 104;
            if (c == '+')
                i = 105;
            return i;
        }

        public const string characters = @"qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM0123456789µ§½!""#¤%&/()=?^*@£€${[]}\~¨'-_.:,;<>|°©®±¥ +";
        public Bitmap GenerateCharacter(Font font, char c, Brush bg)
        {
            SizeF size = GetSize(font, c);
            //initializing bitmap from size
            Bitmap bmp = new Bitmap((int)size.Width, (int)size.Height);
            //initializing gfx object from bmp
            Graphics gfx = Graphics.FromImage(bmp);
            //clearing char square and drawing char
            gfx.FillRectangle(bg, 0, 0, bmp.Width, bmp.Height);
            gfx.DrawString(c.ToString(), font, Brushes.White, 0, 0);

            return bmp;
        }
        private SizeF GetSize(Font font, char c)
        {
            Bitmap bmp = new Bitmap(512, 512);

            Graphics gfx = Graphics.FromImage(bmp);
            return gfx.MeasureString(c.ToString(), font);

        }

        public static int LoadTexture(string filePath)
        {
            Bitmap b = new Bitmap(filePath);

            int id = GL.GenTexture();

            System.Drawing.Imaging.BitmapData bd = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.BindTexture(TextureTarget.Texture2D, id);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, b.Width, b.Height, 0, PixelFormat.Bgra, PixelType.UnsignedByte, bd.Scan0);

            b.UnlockBits(bd);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);

            return id;
        }
        public static int LoadTexture(Bitmap b)
        {

            int id = GL.GenTexture();

            System.Drawing.Imaging.BitmapData bd = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.BindTexture(TextureTarget.Texture2D, id);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, b.Width, b.Height, 0, PixelFormat.Bgra, PixelType.UnsignedByte, bd.Scan0);

            b.UnlockBits(bd);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);

            return id;
        }
        public static Texture2D LoadTexture2D(string filePath)
        {
            Bitmap b = new Bitmap(filePath);

            int id = GL.GenTexture();

            System.Drawing.Imaging.BitmapData bd = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.BindTexture(TextureTarget.Texture2D, id);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, b.Width, b.Height, 0, PixelFormat.Bgra, PixelType.UnsignedByte, bd.Scan0);

            b.UnlockBits(bd);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);

            return new Texture2D(id, b.Width, b.Height);
        }
        public static Texture2D LoadTexture2D(Bitmap b)
        {

            int id = GL.GenTexture();

            System.Drawing.Imaging.BitmapData bd = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.BindTexture(TextureTarget.Texture2D, id);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, b.Width, b.Height, 0, PixelFormat.Bgra, PixelType.UnsignedByte, bd.Scan0);

            b.UnlockBits(bd);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);

            return new Texture2D(id, b.Width, b.Height);
        }

        public void InitializeChars()
        {
            Console.WriteLine("Generating char textures..");

            Console.WriteLine();
            charTextures = new Texture2D[characters.Length];
            Console.WriteLine();

            Font renderingFont = new Font(FontFamily.GenericSansSerif, textureFontSize);

            for (int i = 0; i < characters.Length; i++)
            {
                charTextures[i] = LoadTexture2D(GenerateCharacter(renderingFont, characters[i], Brushes.Transparent));
                //  Console.WriteLine("Generating char: " + characters[i]);
            }

            firstCharTexture = charTextures[0];
        }

        #endregion

        #region Input stuffs
        public bool GetKeyPressed(Key k)
        {
            if (ks.IsKeyDown(k) && old_ks.IsKeyUp(k))
            {
                //old_ks = ks;
                return true;
            }
            else
            {
                //old_ks = ks;
                return false;
            }



        }
        public bool GetKeyReleased(Key k)
        {
            if (ks.IsKeyUp(k) && old_ks.IsKeyDown(k))
            {
                //old_ks = ks;
                return true;
            }
            else
            {
                //old_ks = ks;
                return false;
            }



        }
        public bool GetKeyHeld(Key k)
        {
            if (ks.IsKeyDown(k))
                return true;
            else
                return false;
        }

        public bool MouseButtonPressed(MouseButton b)
        {
            if (ms.IsButtonDown(b) && old_ms.IsButtonUp(b))
            {

                return true;
            }
            else
            {

                return false;
            }



        }
        public bool MouseButtonReleased(MouseButton b)
        {
            if (old_ms.IsButtonUp(b) && ms.IsButtonDown(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool MouseButtonHeld(MouseButton b)
        {
            return ms.IsButtonDown(b);
        }
        public KeyState GetKeyState(Keys k)
        {
            return keys[(int)k];
        }
        #endregion

        [DllImport("user32.dll", EntryPoint = "GetAsyncKeyState")]
        public static extern short GetAsyncKeyStateShort(System.Windows.Forms.Keys vKey);


        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {

            #region keyboard handling area

            for (int i = 0; i < 256; i++)
            {
                keyNewState[i] = GetAsyncKeyStateShort((Keys)i);

                keys[i].bPressed = false;
                keys[i].bReleased = false;

                if (keyNewState[i] != keyOldState[i])
                {
                    //-32768 is the value that it gives when you press the key or you hold it
                    if (keyNewState[i] == -32768)
                    {
                        keys[i].bPressed = !keys[i].bHeld;
                        keys[i].bHeld = true;
                    }
                    else
                    {
                        keys[i].bReleased = true;
                        keys[i].bHeld = false;
                    }
                }

                keyOldState[i] = keyNewState[i];
            }

            //      if (GetKeyPressed(Key.CapsLock))
            //      {
            //          caps_toggle = !caps_toggle;
            //          oldCapsToggle = caps_toggle;
            //      }
            //
            //      if(GetKeyHeld(Key.ShiftLeft))
            //      {
            //          caps_toggle = !oldCapsToggle;
            //      }

            currentKeyboardPressedChar = '\0';

            //big char
            if (caps_toggle)
            {
                if (GetKeyState(Keys.Q).bPressed)
                    currentKeyboardPressedChar = 'Q';
                if (GetKeyState(Keys.W).bPressed)
                    currentKeyboardPressedChar = 'W';
                if (GetKeyState(Keys.E).bPressed)
                    currentKeyboardPressedChar = 'E';
                if (GetKeyState(Keys.R).bPressed)
                    currentKeyboardPressedChar = 'R';
                if (GetKeyState(Keys.T).bPressed)
                    currentKeyboardPressedChar = 'T';
                if (GetKeyState(Keys.Y).bPressed)
                    currentKeyboardPressedChar = 'Y';
                if (GetKeyState(Keys.U).bPressed)
                    currentKeyboardPressedChar = 'U';
                if (GetKeyState(Keys.I).bPressed)
                    currentKeyboardPressedChar = 'I';
                if (GetKeyState(Keys.O).bPressed)
                    currentKeyboardPressedChar = 'O';
                if (GetKeyState(Keys.P).bPressed)
                    currentKeyboardPressedChar = 'P';
                if (GetKeyState(Keys.A).bPressed)
                    currentKeyboardPressedChar = 'A';
                if (GetKeyState(Keys.S).bPressed)
                    currentKeyboardPressedChar = 'S';
                if (GetKeyState(Keys.D).bPressed)
                    currentKeyboardPressedChar = 'D';
                if (GetKeyState(Keys.F).bPressed)
                    currentKeyboardPressedChar = 'F';
                if (GetKeyState(Keys.G).bPressed)
                    currentKeyboardPressedChar = 'G';
                if (GetKeyState(Keys.H).bPressed)
                    currentKeyboardPressedChar = 'H';
                if (GetKeyState(Keys.J).bPressed)
                    currentKeyboardPressedChar = 'J';
                if (GetKeyState(Keys.K).bPressed)
                    currentKeyboardPressedChar = 'K';
                if (GetKeyState(Keys.L).bPressed)
                    currentKeyboardPressedChar = 'L';
                if (GetKeyState(Keys.Z).bPressed)
                    currentKeyboardPressedChar = 'Z';
                if (GetKeyState(Keys.X).bPressed)
                    currentKeyboardPressedChar = 'X';
                if (GetKeyState(Keys.C).bPressed)
                    currentKeyboardPressedChar = 'C';
                if (GetKeyState(Keys.V).bPressed)
                    currentKeyboardPressedChar = 'V';
                if (GetKeyState(Keys.B).bPressed)
                    currentKeyboardPressedChar = 'B';
                if (GetKeyState(Keys.N).bPressed)
                    currentKeyboardPressedChar = 'N';
                if (GetKeyState(Keys.M).bPressed)
                    currentKeyboardPressedChar = 'M';
            }
            //small char
            else
            {

                if (GetKeyState(Keys.Q).bPressed)
                    currentKeyboardPressedChar = 'q';
                if (GetKeyState(Keys.W).bPressed)
                    currentKeyboardPressedChar = 'w';
                if (GetKeyState(Keys.E).bPressed)
                    currentKeyboardPressedChar = 'e';
                if (GetKeyState(Keys.R).bPressed)
                    currentKeyboardPressedChar = 'r';
                if (GetKeyState(Keys.T).bPressed)
                    currentKeyboardPressedChar = 't';
                if (GetKeyState(Keys.Y).bPressed)
                    currentKeyboardPressedChar = 'y';
                if (GetKeyState(Keys.U).bPressed)
                    currentKeyboardPressedChar = 'u';
                if (GetKeyState(Keys.I).bPressed)
                    currentKeyboardPressedChar = 'i';
                if (GetKeyState(Keys.O).bPressed)
                    currentKeyboardPressedChar = 'o';
                if (GetKeyState(Keys.P).bPressed)
                    currentKeyboardPressedChar = 'p';
                if (GetKeyState(Keys.A).bPressed)
                    currentKeyboardPressedChar = 'a';
                if (GetKeyState(Keys.S).bPressed)
                    currentKeyboardPressedChar = 's';
                if (GetKeyState(Keys.D).bPressed)
                    currentKeyboardPressedChar = 'd';
                if (GetKeyState(Keys.F).bPressed)
                    currentKeyboardPressedChar = 'f';
                if (GetKeyState(Keys.G).bPressed)
                    currentKeyboardPressedChar = 'g';
                if (GetKeyState(Keys.H).bPressed)
                    currentKeyboardPressedChar = 'h';
                if (GetKeyState(Keys.J).bPressed)
                    currentKeyboardPressedChar = 'j';
                if (GetKeyState(Keys.K).bPressed)
                    currentKeyboardPressedChar = 'k';
                if (GetKeyState(Keys.L).bPressed)
                    currentKeyboardPressedChar = 'l';
                if (GetKeyState(Keys.Z).bPressed)
                    currentKeyboardPressedChar = 'z';
                if (GetKeyState(Keys.X).bPressed)
                    currentKeyboardPressedChar = 'x';
                if (GetKeyState(Keys.C).bPressed)
                    currentKeyboardPressedChar = 'c';
                if (GetKeyState(Keys.V).bPressed)
                    currentKeyboardPressedChar = 'v';
                if (GetKeyState(Keys.B).bPressed)
                    currentKeyboardPressedChar = 'b';
                if (GetKeyState(Keys.N).bPressed)
                    currentKeyboardPressedChar = 'n';
                if (GetKeyState(Keys.M).bPressed)
                    currentKeyboardPressedChar = 'm';
            }

            //numbers special
            if (GetKeyHeld(Key.ShiftLeft))
            {
                if (GetKeyState(Keys.D1).bPressed)
                    currentKeyboardPressedChar = '!';
                if (GetKeyState(Keys.D2).bPressed)
                    currentKeyboardPressedChar = '@';
                if (GetKeyState(Keys.D3).bPressed)
                    currentKeyboardPressedChar = '#';
                if (GetKeyState(Keys.D4).bPressed)
                    currentKeyboardPressedChar = '$';
                if (GetKeyState(Keys.D5).bPressed)
                    currentKeyboardPressedChar = '%';
                if (GetKeyState(Keys.D6).bPressed)
                    currentKeyboardPressedChar = '^';
                if (GetKeyState(Keys.D7).bPressed)
                    currentKeyboardPressedChar = '&';
                if (GetKeyState(Keys.D8).bPressed)
                    currentKeyboardPressedChar = '*';
                if (GetKeyState(Keys.D9).bPressed)
                    currentKeyboardPressedChar = '(';
                if (GetKeyState(Keys.D0).bPressed)
                    currentKeyboardPressedChar = ')';
            }
            //numbers normal
            else
            {

                if (GetKeyState(Keys.D1).bPressed)
                    currentKeyboardPressedChar = '1';
                if (GetKeyState(Keys.D2).bPressed)
                    currentKeyboardPressedChar = '2';
                if (GetKeyState(Keys.D3).bPressed)
                    currentKeyboardPressedChar = '3';
                if (GetKeyState(Keys.D4).bPressed)
                    currentKeyboardPressedChar = '4';
                if (GetKeyState(Keys.D5).bPressed)
                    currentKeyboardPressedChar = '5';
                if (GetKeyState(Keys.D6).bPressed)
                    currentKeyboardPressedChar = '6';
                if (GetKeyState(Keys.D7).bPressed)
                    currentKeyboardPressedChar = '7';
                if (GetKeyState(Keys.D8).bPressed)
                    currentKeyboardPressedChar = '8';
                if (GetKeyState(Keys.D9).bPressed)
                    currentKeyboardPressedChar = '9';
                if (GetKeyState(Keys.D0).bPressed)
                    currentKeyboardPressedChar = '0';
            }

            //extra special char
            if (GetKeyHeld(Key.ShiftLeft))
            {
                if (GetKeyState(Keys.Oemplus).bPressed)
                    currentKeyboardPressedChar = '+';
                if (GetKeyState(Keys.OemMinus).bPressed)
                    currentKeyboardPressedChar = '_';
                if (GetKeyState(Keys.OemQuestion).bPressed)
                    currentKeyboardPressedChar = '?';
                if (GetKeyState(Keys.OemPeriod).bPressed)
                    currentKeyboardPressedChar = '>';
                if (GetKeyState(Keys.Oemcomma).bPressed)
                    currentKeyboardPressedChar = '<';
                if (GetKeyState(Keys.OemSemicolon).bPressed)
                    currentKeyboardPressedChar = ':';
                if (GetKeyState(Keys.OemOpenBrackets).bPressed)
                    currentKeyboardPressedChar = '}';
                if (GetKeyState(Keys.OemCloseBrackets).bPressed)
                    currentKeyboardPressedChar = '{';
                if (GetKeyState(Keys.Oemtilde).bPressed)
                    currentKeyboardPressedChar = '~';
                if (GetKeyState(Keys.OemQuotes).bPressed)
                    currentKeyboardPressedChar = "'".ToCharArray()[0];
                if (GetKeyState(Keys.OemPipe).bPressed)
                    currentKeyboardPressedChar = '|';
                if (GetKeyState(Keys.Oem102).bPressed)
                    currentKeyboardPressedChar = '|';
            }
            else
            {
                if (GetKeyState(Keys.Oemplus).bPressed)
                    currentKeyboardPressedChar = '=';
                if (GetKeyState(Keys.OemMinus).bPressed)
                    currentKeyboardPressedChar = '-';
                if (GetKeyState(Keys.OemQuestion).bPressed)
                    currentKeyboardPressedChar = '/';
                if (GetKeyState(Keys.OemPeriod).bPressed)
                    currentKeyboardPressedChar = '.';
                if (GetKeyState(Keys.Oemcomma).bPressed)
                    currentKeyboardPressedChar = ',';
                if (GetKeyState(Keys.OemSemicolon).bPressed)
                    currentKeyboardPressedChar = ';';
                if (GetKeyState(Keys.OemOpenBrackets).bPressed)
                    currentKeyboardPressedChar = '[';
                if (GetKeyState(Keys.OemCloseBrackets).bPressed)
                    currentKeyboardPressedChar = ']';
                if (GetKeyState(Keys.Oemtilde).bPressed)
                    currentKeyboardPressedChar = '`';
                if (GetKeyState(Keys.OemQuotes).bPressed)
                    currentKeyboardPressedChar = '"';
                if (GetKeyState(Keys.OemPipe).bPressed)
                    currentKeyboardPressedChar = @"\".ToCharArray()[0];
                if (GetKeyState(Keys.Oem102).bPressed)
                    currentKeyboardPressedChar = @"\".ToCharArray()[0];
            }
            if (GetKeyState(Keys.Space).bPressed)
                currentKeyboardPressedChar = ' ';

            #endregion
            ms = OpenTK.Input.Mouse.GetCursorState();
            ks = OpenTK.Input.Keyboard.GetState();

            msc = new Point(Clamp(ms.X - X - 7, 0, Width), Clamp(ms.Y - Y - 28, 0, Height));

            //calculating mouse change vector
            newMousePoint = new Vector2(ms.X, ms.Y);
            mouseMovment = oldMousePoint - newMousePoint;
            oldMousePoint = newMousePoint;

            //calculating scroll change
            newScrollWheelValue = ms.ScrollWheelValue;
            scrollWheelChange = oldScrollWheelValue - newScrollWheelValue;

            OnRender(e);


            old_ms = ms;
            old_ks = ks;
            oldScrollWheelValue = newScrollWheelValue;
        }



        protected virtual void OnRender(FrameEventArgs e)
        {

        }




        public abstract class UiElement
        {
            public virtual void Draw() { }

            public int x;
            public int y;

            public int width;
            public int height;

            public bool Enabled = true;
            public bool canInteract = true;

            public bool drawInLoop = true;

            public int order = 0;

            public string name = null;
        }
        public struct Texture2D { private int id; private int width, height; public int ID { get { return id; } } public int Width { get { return width; } } public int Height { get { return height; } } public Texture2D(int id, int width, int height) { this.id = id; this.width = width; this.height = height; } }
        public class CheckBox : UiElement
        {
            public CheckBox()
            {
                checked_texture = UiClass.LoadTexture("checkbox_checked.png");
                unchecked_texture = UiClass.LoadTexture("checkbox_unchecked.png");
                width = 20;
                height = 20;
            }

            public override void Draw()
            {
                if (Enabled)
                {
                    //Mouse.GetCursorState().X
                    int current_texture = 0;
                    if (Checked == false)
                        current_texture = unchecked_texture;
                    else
                        current_texture = checked_texture;

                    if (UiClass.inst.msc.X > x && UiClass.inst.msc.X < width + x && UiClass.inst.msc.Y > y && UiClass.inst.msc.Y < height + y && canInteract)
                    {
                        if (UiClass.inst.MouseButtonPressed(MouseButton.Left))
                        {
                            Checked = !Checked;
                            if (OnCheckChanged != null)
                                OnCheckChanged.Invoke(this, new EventArgs());
                        }
                    }

                    UiClass.inst.DrawString(text, x + width, y + height / 2 - 8, 10, backColor);
                    GL.Enable(EnableCap.Texture2D);
                    UiClass.inst.drawQuadWithTexture(x, y, width, height, current_texture);
                    GL.Disable(EnableCap.Texture2D);
                }
            }

            public EventHandler OnCheckChanged;
            Color backColor = Color.Black;
            public int checked_texture = 0;
            public int unchecked_texture = 0;
            public string text = "checkBox";
            public bool Checked = false;
        }
        public class TextBox : UiElement
        {
            public TextBox()
            {
                width = 65;
                height = 20;

                defaultColorOutside = Color.White;
                defaultColorInside = Color.Black;


                clickedColorOutside = Color.FromArgb(175, 224, 255);
                clickedColorInside = /* Color.FromArgb(60, 109, 140);*/  Color.Black;
            }
            Color defaultColorOutside;
            Color defaultColorInside;

            Color clickedColorOutside;
            Color clickedColorInside;

            public override void Draw()
            {
                //Mouse.GetCursorState().X

                if (Enabled)
                {
                    if (charsToDisplay == 0)
                    {
                        charsToDisplay = width / fontSize;
                    }

                    if (UiClass.inst.msc.X > x && UiClass.inst.msc.X < width + x && UiClass.inst.msc.Y > y && UiClass.inst.msc.Y < height + y && canInteract)
                    {
                        if (UiClass.inst.MouseButtonPressed(MouseButton.Left))
                        {
                            Focused = true;
                        }
                    }
                    else
                    {
                        if (UiClass.inst.MouseButtonPressed(MouseButton.Left))
                        {
                            Focused = false;
                        }
                    }

                    if (Focused)
                    {
                        if (UiClass.inst.currentKeyboardPressedChar != '\0')
                        {
                            text += UiClass.inst.currentKeyboardPressedChar;
                            offset += 1;
                        }

                        if (UiClass.inst.GetKeyPressed(Key.Back) && text.Length > 0)
                        {
                            text = text.Remove(text.Length - 1);
                            offset -= 1;
                        }

                        if (UiClass.inst.GetKeyPressed(Key.Enter))
                        {
                            Focused = false;
                            if (OnTextEntered != null)
                            {
                                OnTextEntered.Invoke(this, new EventArgs());
                            }
                        }

                        if (UiClass.inst.GetKeyPressed(Key.Right))
                            offset++;
                        if (UiClass.inst.GetKeyPressed(Key.Left))
                            offset--;
                        offset = UiClass.inst.Clamp(offset, 0, text.Length);
                    }

                    if (text != oldText)
                    {
                        if (OnTextChanged != null)
                            OnTextChanged.Invoke(this, new EventArgs());
                    }

                    if (Focused)
                    {
                        UiClass.inst.drawColoredQuad(x, y, width, height, clickedColorOutside);
                        UiClass.inst.drawColoredQuad(x + border_thickness, y + border_thickness, width - border_thickness * 2, height - border_thickness * 2, clickedColorInside);
                    }
                    else
                    {
                        UiClass.inst.drawColoredQuad(x, y, width, height, defaultColorOutside);
                        UiClass.inst.drawColoredQuad(x + border_thickness, y + border_thickness, width - border_thickness * 2, height - border_thickness * 2, defaultColorInside);
                    }
                    offset = UiClass.inst.Clamp(offset, 0, text.Length - charsToDisplay);
                    if (offset + charsToDisplay >= text.Length)
                        displayString = text.Remove(0, offset);
                    else
                        displayString = (text.Length <= charsToDisplay) ? text : text.Remove(0, offset).Remove(charsToDisplay);

                    UiClass.inst.DrawString(displayString, x + 5, y + height / 2 - 8, fontSize, Color.Transparent);

                    oldText = text;
                }
            }

            public bool Focused = false;
            public int border_thickness = 2;
            public EventHandler OnTextChanged;
            public EventHandler OnTextEntered;
            public Color backColor = Color.Black;
            public int thickness;
            public int charsToDisplay = 0;
            public string displayString = "";
            public int offset;
            public int fontSize = 10;
            public string text = "";
            private string oldText = "";
        }
        public class Label : UiElement
        {
            public Label()
            {
                backColor = Color.Transparent;
                fontSize = 12;
                text = "label";
            }

            public Color backColor;
            public int fontSize = 12;
            public string text = "";
            public string displayed_text;
            public int charsToDisplay = -1;

            public override void Draw()
            {
                if (Enabled)
                {
                    if (charsToDisplay == 0)
                    {
                        charsToDisplay = width / fontSize;
                    }

                    if (text != "")
                    {
                        if (charsToDisplay != -1)
                            displayed_text = text.Remove(charsToDisplay);
                        else
                            displayed_text = text;

                        UiClass.inst.DrawFormattedString(displayed_text, x, y, fontSize, backColor);
                    }
                }
            }
        }
        public class Button : UiElement
        {
            bool c = true;

            public Button()
            {
                width = 65;
                height = 20;


                defaultColorOutside = Color.White;
                defaultColorInside = Color.Black;


                clickedColorOutside = Color.FromArgb(175, 224, 255);
                clickedColorInside = Color.FromArgb(60, 109, 140);

                hoverColorOutside = Color.FromArgb(168, 237, 255);
                hoverColorInside = Color.FromArgb(18, 87, 105);
            }

            Color defaultColorOutside;
            Color defaultColorInside;

            Color clickedColorOutside;
            Color clickedColorInside;

            Color hoverColorOutside;
            Color hoverColorInside;

            public override void Draw()
            {

                if (Enabled)
                {
                    if (hover_texture != 0 | normal_texture != 0 | clicked_texture != 0 && useCustomTexture != true)
                    {
                        useCustomTexture = true;
                    }
                    int current_texture = 0;
                    if (UiClass.inst.MouseButtonReleased(MouseButton.Left))
                        is_clicked = false;

                    if ((UiClass.inst.msc.X > x && UiClass.inst.msc.X < width + x && UiClass.inst.msc.Y > y && UiClass.inst.msc.Y < height + y) && canInteract)
                    {

                        is_hovering = true;
                        if (UiClass.inst.MouseButtonPressed(MouseButton.Left))
                        {
                            if (OnClick != null)
                                OnClick.Invoke(this, new EventArgs());

                            is_clicked = UiClass.inst.MouseButtonHeld(MouseButton.Left);
                        }

                        // else
                        //     is_clicked = false;
                    }
                    else
                        is_hovering = false;

                    if (UiClass.inst.MouseButtonHeld(MouseButton.Left) == false)
                    {
                        is_clicked = false;
                    }
                    GL.Disable(EnableCap.Texture2D);
                    if (is_clicked)
                    {
                        is_clicked = UiClass.inst.MouseButtonHeld(MouseButton.Left);

                        if (useCustomTexture)
                        {
                            current_texture = clicked_texture;
                        }
                        else
                        {
                            if (tint)
                            {
                                UiClass.inst.drawColoredQuad(x, y, width, height, clickedColorOutside);
                                UiClass.inst.drawColoredQuad(x + border_thickness, y + border_thickness, width - border_thickness * 2, height - border_thickness * 2, clickedColorInside);
                            }
                            else
                            {
                                UiClass.inst.drawColoredQuad(x, y, width, height, defaultColorOutside);
                                UiClass.inst.drawColoredQuad(x + border_thickness, y + border_thickness, width - border_thickness * 2, height - border_thickness * 2, defaultColorInside);
                            }
                        }
                    }
                    else
                    {
                        if (useCustomTexture)
                        {
                            current_texture = normal_texture;
                        }
                        else
                        {

                            UiClass.inst.drawColoredQuad(x, y, width, height, defaultColorOutside);
                            UiClass.inst.drawColoredQuad(x + border_thickness, y + border_thickness, width - border_thickness * 2, height - border_thickness * 2, defaultColorInside);
                        }
                    }
                    if ((is_hovering && is_clicked == false))
                    {

                        if (useCustomTexture)
                        {
                            current_texture = hover_texture;
                        }
                        else
                        {
                            if (tint)
                            {
                                UiClass.inst.drawColoredQuad(x, y, width, height, hoverColorOutside);
                                UiClass.inst.drawColoredQuad(x + border_thickness, y + border_thickness, width - border_thickness * 2, height - border_thickness * 2, hoverColorInside);
                            }
                            else
                            {
                                UiClass.inst.drawColoredQuad(x, y, width, height, defaultColorOutside);
                                UiClass.inst.drawColoredQuad(x + border_thickness, y + border_thickness, width - border_thickness * 2, height - border_thickness * 2, defaultColorInside);
                            }
                        }
                    }


                    GL.Enable(EnableCap.Texture2D);
                    if (useCustomTexture)
                    {
                        UiClass.inst.drawQuadWithTexture(x, y, width, height, current_texture);
                        if (tint)
                        {
                            if ((is_hovering && is_clicked == false))
                            {
                                UiClass.inst.drawColoredQuad(x, y, width, height, Color.FromArgb(100, hoverColorInside.R, hoverColorInside.G, hoverColorInside.B));
                            }
                            if (is_clicked)
                            {
                                UiClass.inst.drawColoredQuad(x, y, width, height, Color.FromArgb(100, clickedColorInside.R, clickedColorInside.G, clickedColorInside.B));
                            }
                        }
                    }
                    UiClass.inst.DrawString(text, x + 5, y + height / 2 - 8, fontSize, Color.Transparent);
                    GL.Disable(EnableCap.Texture2D);
                }
            }

            private bool useCustomTexture = false;
            public bool tint = true;
            public int normal_texture = 0;
            public int hover_texture = 0;
            public int clicked_texture = 0;

            public bool is_clicked = false;
            public bool is_hovering = false;
            public int border_thickness = 2;
            public int fontSize = 10;
            public EventHandler OnClick;
            public string text = "button";
        }
        public class Slider : UiElement
        {
            public Slider()
            {
                body_texture = UiClass.LoadTexture("slider_body.png");
                slider_texture = UiClass.LoadTexture("slider_thing.png");
            }

            public override void Draw()
            {
                if (Enabled)
                {
                    GL.Enable(EnableCap.Texture2D);

                    if (UiClass.inst.msc.X > x && UiClass.inst.msc.X < width + x && UiClass.inst.msc.Y > y && UiClass.inst.msc.Y < height + y && canInteract)
                    {
                        if (UiClass.inst.MouseButtonPressed(MouseButton.Left))
                        {


                            isSliding = UiClass.inst.MouseButtonHeld(MouseButton.Left);
                        }



                    }
                    if (isSliding)
                    {
                        isSliding = UiClass.inst.MouseButtonHeld(MouseButton.Left);
                        slider_value = UiClass.inst.msc.X - x;
                        slider_value = UiClass.inst.Clamp(slider_value, lower_bound, width - slider_width);
                        if (OnSliderValueChanged != null)
                            OnSliderValueChanged.Invoke(this, new EventArgs());
                    }
                    UiClass.inst.drawQuadWithTexture(x, y, width, height, body_texture);
                    UiClass.inst.drawQuadWithTexture((int)(x + slider_value), (int)(y - height * 0.5f), slider_width, height * 2, slider_texture);
                    GL.Disable(EnableCap.Texture2D);
                }
            }
            public int slider_width = 6;
            public float lower_bound = 0;
            public bool isSliding = false;
            public float slider_value = 0;
            public EventHandler OnSliderValueChanged;
            public int body_texture;
            public int slider_texture;
        }
    }
}
