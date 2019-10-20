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
using UiSystemOpenTK;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.Runtime.InteropServices;
using sort_visualiser.Sorts;
namespace sort_visualiser
{
    class Program
    {
        static void Main(string[] args)
        {


            mainClass yeet = new mainClass(800, 400);
            //yeet.Y = 500;
            yeet.VSync = VSyncMode.Off;
            yeet.Run();

        }
    }

    class mainClass : UiClass
    {
        public mainClass(int width, int height) : base(width, height)
        {
        }


        public int[] arr = new int[1];

        public int[] array {
            get {
                acceses++;
                return arr;
            }
            set {
                arr = value;
            }
        }

        public float stretchX = 0.8f;
        public float stretchY = 0.4f;

        public uint acceses = 0;
        public uint comps = 0;

        public int sleepTime = 0;

        int index = 0;
        Random rand;
        Matrix4 projMatrix;
        int snapshotCount = 0;

        float timeCounter = 0;
        float fpsMedian = 0;
        float fps = 0;
        float num = 0;
        double sec_elapsed_time;

        bool showShuffleAnim = true;
        public int[] alreadySortedArray = new int[0];

        public int[] marked = new int[0];

        public int INSTRUMENT = 197;

        public void clearMarked()
        {
            for (int i = 0; i < marked.Length; i++)
            {
                marked[i] = -5;
            }
        }


        //SETTINGS 
        public string javaPath = @"C:\Program Files\Java\jre1.8.0_151\bin\java.exe";





        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            projMatrix = Matrix4.CreateOrthographicOffCenter(0, Width, Height, 0, 0, 1);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projMatrix);

            inst = this;
            InitializeChars();


            rand = new Random();
            LoadSorts();
            initializeUI();
            //inputStream;

            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);

            i = this;
            
            StartSynth();

           
            
        }

        public void LoadSorts()
        {
            sorts = new Sort[17];

            bubbleSort bubbleSort = new bubbleSort();
            bubbleSort.array = array;

            sorts[0] = bubbleSort;

            cocktailShakerSort cocktailShakerSort = new cocktailShakerSort();
            cocktailShakerSort.array = array;

            sorts[1] = cocktailShakerSort;

            selectionSort selectionSort = new selectionSort();
            selectionSort.array = array;

            sorts[2] = selectionSort;

            doubleSelectionSort doubleSelectionSort = new doubleSelectionSort();
            doubleSelectionSort.array = array;

            sorts[3] = doubleSelectionSort;

            insertionSort insertionSort = new insertionSort();
            insertionSort.array = array;

            sorts[4] = insertionSort;

            shellSort shellSort = new shellSort();
            shellSort.array = array;

            sorts[5] = shellSort;

            mergeSortIP mergeSortIP = new mergeSortIP();
            mergeSortIP.array = array;

            sorts[6] = mergeSortIP;

            mergeSort mergeSort = new mergeSort();
            mergeSort.array = array;

            sorts[7] = mergeSort;

            waveMergeSort waveMergeSort = new waveMergeSort();
            waveMergeSort.array = array;

            sorts[8] = waveMergeSort;

            maxHeapSort maxHeapSort = new maxHeapSort();
            maxHeapSort.array = array;

            sorts[9] = maxHeapSort;

            quickSort quickSort = new quickSort();
            quickSort.array = array;

            sorts[10] = quickSort;

            countingSort countingSort = new countingSort();
            countingSort.array = array;

            sorts[11] = countingSort;

            gravitySort gravitySort = new gravitySort();
            gravitySort.array = array;

            sorts[12] = gravitySort;

            timeSort timeSort = new timeSort();
            timeSort.array = array;

            sorts[13] = timeSort;

            radixLsdSort radixLsdSort = new radixLsdSort();
            radixLsdSort.array = array;

            sorts[14] = radixLsdSort;

            inplaceRadixSort inplaceRadixSort = new inplaceRadixSort();
            inplaceRadixSort.array = array;

            sorts[15] = inplaceRadixSort;

            radixMsdSort radixMsdSort = new radixMsdSort();
            radixMsdSort.array = array;

            sorts[16] = radixMsdSort;
        }

        public void StartSynth ()
        {
            synthProcess = new Process();
            synthProcess.StartInfo.FileName = javaPath;
            synthProcess.StartInfo.Arguments = @"-jar " + (char)34 + @"synth.jar" + (char)34;
            synthProcess.StartInfo.RedirectStandardInput = true;
            synthProcess.StartInfo.UseShellExecute = false;
            synthProcess.Start();

            messageStream = synthProcess.StandardInput;
        }

        public void BuildArray(int size)
        {
            array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                //dT();

            }
            marked = new int[array.Length];
            clearMarked();
            alreadySortedArray = new int[array.Length];
            Array.Copy(array, alreadySortedArray, array.Length);
            stretchX = (float)Width / (float)array.Length;
            stretchY = (float)Height / (float)array.Length;
        }



       

        

        
        
       

       

       

        

        
        public static mainClass i;
        




        

       



        

        

        public Bitmap TakeScreenshot()
        {
            Bitmap bmp = new Bitmap(Width, Height);
            System.Drawing.Imaging.BitmapData dat = bmp.LockBits(new Rectangle(0, 0, Width, Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.Finish();
            GL.ReadBuffer(ReadBufferMode.Back);
            GL.ReadPixels(0, 0, Width, Height, PixelFormat.Bgra, PixelType.UnsignedByte, dat.Scan0);
            bmp.UnlockBits(dat);
            bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
            return bmp;
        }

        int screenshotTexture = 0;
        public Process synthProcess;
        public StreamWriter messageStream;
        public int arrSize = 1000;

        Sort[] sorts;

        public Sort sortToRun;

        protected override void OnRender(FrameEventArgs e)
        {
            //base.OnRenderFrame(e);

            sec_elapsed_time = e.Time;

            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.ClearColor(Color.White);

           // GL.Color4(Color4.Black);


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

            ;
            
            if (GetKeyPressed(Key.Space))
            {
                BuildArray(arrSize);
                initCirclePoints();
                genCirclePoints();
                // sleepTime = 10;
                //copied sorts
                showShuffleAnim = true;

                sm = ShuffleModes.NormalSwap;
                //   Shuffle();
                //   mergeSort(array, 0, array.Length - 1);
                //  Shuffle();
                //  shellSort(array,array.Length,2);
                // Shuffle();
                //  quickSort(array,0,array.Length-1);
                //   Shuffle();
                //  GravitySort(array);
                // Shuffle();
                // selectionSort(array);
                //  Shuffle();
                //  bubbleSort(array);
                //   Shuffle();
                //   cocktailShakerSort(array);
                // Shuffle();
                // insertionSort(array);

                // Shuffle();
                //  maxheapsort(array);
                // Console.WriteLine(Environment.GetEnvironmentVariable("Path"));
                //  Shuffle();
                //  weaveMergeSort(array, 0, array.Length - 1);
                // Shuffle();
                // countingSort(array);
                //  Shuffle();
                //Shuffle();
                //timeSort(array, 4);
                //Shuffle();
                //radixLSDsort(array, 4);
                //Shuffle();
                //inPlaceRadixLSDSort(array, 10);
                //  Shuffle();
                //  mergeSortOP(array);

                //Shuffle();
                //radixMSDSort(array, 4);

                // Shuffle();
                // RadixSort(array, 4);
                // Shuffle();
                // DoubleSelectionSort(array);
                //Shuffle();
                //inplaceRadixSort rads = new inplaceRadixSort();
                //rads.Base = 2;
                //rads.array = array;
                //rads.run();

                Shuffle();

                for (int i = 0; i < sorts.Length; i++)
                {
                    sorts[i].array = array;
                }

                sortToRun.run();

                bool sorted = CheckIfSortFinished();

                if (sorted)
                {
                    currentErrorString = "";
                    currentInfoString = "Sort finished succesfully!";
                }
                else
                {
                    currentInfoString = "";
                    currentErrorString = "Sort not finished!";
                }
                messageStream.WriteLine("0,0,0,0");
                messageStream.Flush();
                screenshotTexture = LoadTexture(TakeScreenshot());
            }
            GL.Enable(EnableCap.Texture2D);
            drawQuadWithTexture(0, 0, Width, Height, screenshotTexture);
            GL.Disable(EnableCap.Texture2D);
            DrawString("awaiting input..", 12, 12, 18, Color.Blue);
            if (currentErrorString != "")
                drawBetterButSlowString(currentErrorString, 12, Height- 40, 18, Color.Black, Color.Red);
            if (currentInfoString != "" && currentErrorString == "")
                drawBetterButSlowString(currentInfoString, 12, Height - 40, 18, Color.Black, Color.Green);
            else if(currentInfoString != "" && currentErrorString != "")
                drawBetterButSlowString(currentInfoString, 12, Height - 80, 18, Color.Black, Color.Green);
            //drawBetterButSlowString(currentInfoString, 12, 36, 18, Color.Black, Color.Green);
            //   GL.Color4(Color4.Black);
            //   GL.LineWidth(1);
            //   GL.Begin(PrimitiveType.Lines);
            //   for (int i = 0; i < snapshop[index].Length; i++)
            //   {
            //
            //
            //       GL.Vertex2(stretchX * i, Height);
            //       GL.Vertex2(stretchX * i, Height - stretchY * snapshop[index][i]);
            //
            //
            //
            //       //  drawColoredQuad( (int)  (stretchX* i),(int) Height,(int) stretchX,(int)( Height - (stretchY * snapshop[index][i])),Color.Blue);
            //
            //   }
            //   GL.End();
            //   index++;
            //   DrawString(index.ToString(), 12, 12, 12, Color.Black);
            //   if (index > snapshotCount - 1)
            //       index = 0;
            //      Thread.Sleep(1);



            UiElement[] SortedUis = uis.OrderBy(o => o.order).ToArray();

            foreach (UiElement element in SortedUis)
            {

                if (element.drawInLoop)
                    element.Draw();

                
            }





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

        string currentErrorString = "";
        string currentInfoString = "";

        public List<UiElement> uis;

        public TextBox reverbBox;
        public Label reverbBoxLabel;

        public TextBox NumChannelsBox;
        public Label   NumChannelsBoxLabel;

        public TextBox SoundMulBox;
        public Label   SoundMulBoxLabel;


        public TextBox PitchMaxBox;
        public Label   PitchMaxBoxLabel;

        public TextBox PitchMinBox;
        public Label   PitchMinBoxLabel;

        public Button crashSynthBut;

        public Button restartSynthBut;

        public TextBox InstrumentBox;
        public Label   InstrumentBoxLabel;

        public Button showAudioMenuBut;

        public TextBox visModeBox;
        public Label visModeBoxLabel;
        public Label currentVisModeBoxLabel;

        public Button visModePlusBut;
        public Button visModeMinusBut;

        public TextBox ArraySizeBox;
        public Label   ArraySizeBoxLabel;

        public TextBox DelayBox;
        public Label   DelayBoxLabel;

        public Button[] sortButtons;

        public void initializeUI()
        {
            uis = new List<UiElement>();

            reverbBox = new TextBox();
            reverbBox.x = 12;
            reverbBox.y = 80;
            reverbBox.width = 100;
            reverbBox.height = 20;
            reverbBox.OnTextEntered += reverb_box_on_entered;
            reverbBoxLabel = new Label();
            reverbBoxLabel.x = 12;
            reverbBoxLabel.y = 60;
            reverbBoxLabel.text = "Reverb";
            reverbBoxLabel.fontSize = 12;

            NumChannelsBox = new TextBox();
            NumChannelsBox.x = 12;
            NumChannelsBox.y = 120;
            NumChannelsBox.width = 100;
            NumChannelsBox.height = 20;
            NumChannelsBox.OnTextEntered += num_channels_box_on_entered;
            NumChannelsBoxLabel = new Label();
            NumChannelsBoxLabel.x = 12;
            NumChannelsBoxLabel.y = 100;
            NumChannelsBoxLabel.text = "Note num";
            NumChannelsBoxLabel.fontSize = 12;

            SoundMulBox = new TextBox();
            SoundMulBox.x = 12;
            SoundMulBox.y = 160;
            SoundMulBox.width = 100;
            SoundMulBox.height = 20;
            SoundMulBox.OnTextEntered += sound_mul_box_on_entered;
            SoundMulBoxLabel = new Label();
            SoundMulBoxLabel.x = 12;
            SoundMulBoxLabel.y = 140;
            SoundMulBoxLabel.text = "Sound Mul";
            SoundMulBoxLabel.fontSize = 12;

            PitchMaxBox = new TextBox();
            PitchMaxBox.x = 12;
            PitchMaxBox.y = 200;
            PitchMaxBox.width = 100;
            PitchMaxBox.height = 20;
            PitchMaxBox.OnTextEntered += pitch_max_box_on_entered;
            PitchMaxBoxLabel = new Label();
            PitchMaxBoxLabel.x = 12;
            PitchMaxBoxLabel.y = 180;
            PitchMaxBoxLabel.text = "Max Pitch";
            PitchMaxBoxLabel.fontSize = 12;

            PitchMinBox = new TextBox();
            PitchMinBox.x = 12;
            PitchMinBox.y = 240;
            PitchMinBox.width = 100;
            PitchMinBox.height = 20;
            PitchMinBox.OnTextEntered += pitch_min_box_on_entered;
            PitchMinBoxLabel = new Label();
            PitchMinBoxLabel.x = 12;
            PitchMinBoxLabel.y = 220;
            PitchMinBoxLabel.text = "Min Pitch";
            PitchMinBoxLabel.fontSize = 12;

            InstrumentBox = new TextBox();
            InstrumentBox.x = 120;
            InstrumentBox.y = 240;
            InstrumentBox.width = 100;
            InstrumentBox.height = 20;
            InstrumentBox.OnTextEntered += instrument_box_on_entered;
            InstrumentBoxLabel = new Label();
            InstrumentBoxLabel.x = 120;
            InstrumentBoxLabel.y = 220;
            InstrumentBoxLabel.text = "Intrument";
            InstrumentBoxLabel.fontSize = 12;

            crashSynthBut = new Button();
            crashSynthBut.x = 12;
            crashSynthBut.y = 280;
            crashSynthBut.width = 112;
            crashSynthBut.height = 20;
            crashSynthBut.text = "Crash synth!";
            crashSynthBut.OnClick += crash_synth_but_click;
            
            restartSynthBut = new Button();
            restartSynthBut.x = 130;
            restartSynthBut.y = 280;
            restartSynthBut.width = 125;
            restartSynthBut.height = 20;
            restartSynthBut.text = "Restart synth!";
            restartSynthBut.OnClick += restart_synth_but_click;


            showAudioMenuBut = new Button();
            showAudioMenuBut.x = 12;
            showAudioMenuBut.y = 120;
            showAudioMenuBut.width = 150;
            showAudioMenuBut.height = 20;
            showAudioMenuBut.text = "Show audio menu";
            showAudioMenuBut.OnClick += audio_settings_but_click;


            reverbBox.text = REVERB.ToString();
            NumChannelsBox.text = NUMCHANNELS.ToString();
            SoundMulBox.text = SOUNDMUL.ToString();
            PitchMaxBox.text = PITCHMAX.ToString();
            PitchMinBox.text = PITCHMIN.ToString();
            InstrumentBox.text = INSTRUMENT.ToString();


            visModeBox = new TextBox();
            visModeBox.x = 12;
            visModeBox.y = 80;
            visModeBox.width = 100;
            visModeBox.height = 20;
            visModeBox.OnTextChanged += vis_mode_box_on_changed;
            visModeBoxLabel = new Label();
            visModeBoxLabel.x = 12;
            visModeBoxLabel.y = 60;
            visModeBoxLabel.text = "Vis mode";
            visModeBoxLabel.fontSize = 12;
            currentVisModeBoxLabel = new Label();
            currentVisModeBoxLabel.x = 12;
            currentVisModeBoxLabel.y = 100;
            currentVisModeBoxLabel.text = visModeNames[visMode];
            currentVisModeBoxLabel.fontSize = 12;

            visModePlusBut = new Button();
            visModePlusBut.x = 110;
            visModePlusBut.y = 80;
            visModePlusBut.width = 20;
            visModePlusBut.height = 20;
            visModePlusBut.text = "+";
            visModePlusBut.OnClick += vis_mode_plus_but_click;

            visModeMinusBut = new Button();
            visModeMinusBut.x = 130;
            visModeMinusBut.y = 80;
            visModeMinusBut.width = 20;
            visModeMinusBut.height = 20;
            visModeMinusBut.text = "-";
            visModeMinusBut.OnClick += vis_mode_minus_but_click;

            visModeBox.text = visMode.ToString();

            ArraySizeBox = new TextBox();
            ArraySizeBox.x = 12;
            ArraySizeBox.y = 160;
            ArraySizeBox.width = 100;
            ArraySizeBox.height = 20;
            ArraySizeBox.OnTextEntered += array_size_box_on_entered;
            ArraySizeBoxLabel = new Label();
            ArraySizeBoxLabel.x = 12;
            ArraySizeBoxLabel.y = 140;
            ArraySizeBoxLabel.text = "Array Size";
            ArraySizeBoxLabel.fontSize = 12;

            ArraySizeBox.text = arrSize.ToString();

            DelayBox = new TextBox();
            DelayBox.x = 12;
            DelayBox.y = 200;
            DelayBox.width = 100;
            DelayBox.height = 20;
            DelayBox.OnTextEntered += delay_box_on_entered;
            DelayBoxLabel = new Label();
            DelayBoxLabel.x = 12;
            DelayBoxLabel.y = 180;
            DelayBoxLabel.text = "Delay";
            DelayBoxLabel.fontSize = 12;

            DelayBox.text = sleepTime.ToString();

            reverbBox.Enabled =     false;
                 reverbBoxLabel.Enabled =false;
                                         
               PitchMaxBox.Enabled =     false;
               PitchMaxBoxLabel.Enabled =false;
                                         
               PitchMinBox.Enabled =     false;
               PitchMinBoxLabel.Enabled =false;
                                         
             InstrumentBox.Enabled =     false;
             InstrumentBoxLabel.Enabled =false;
                                         
            NumChannelsBox.Enabled =     false;
            NumChannelsBoxLabel.Enabled =false;
                                         
               SoundMulBox.Enabled =     false;
               SoundMulBoxLabel.Enabled =false;



                 reverbBox.     order = 1;
                 reverbBoxLabel.order = 1;
                                 
               PitchMaxBox.     order = 1;
               PitchMaxBoxLabel.order = 1;
                               
               PitchMinBox.     order = 1;
               PitchMinBoxLabel.order = 1;
                               
             InstrumentBox.     order = 1;
             InstrumentBoxLabel.order = 1;
                               
             NumChannelsBox.    order = 1;
            NumChannelsBoxLabel.order = 1;
                              
               SoundMulBox.     order = 1;
               SoundMulBoxLabel.order = 1;

            sortButtons = new Button[sorts.Length];
            
            for (int i = 0; i < sortButtons.Length; i++)
            {
                sortButtons[i] = new Button();
                sortButtons[i].x = 300;
                int space = Height/sorts.Length;
                sortButtons[i].y = i * space ;
                sortButtons[i].fontSize = Height / sorts.Length-13;
                sortButtons[i].width = (sorts[i].name.Length + 3) * sortButtons[i].fontSize;
                sortButtons[i].height = Height / sorts.Length;
                sortButtons[i].text = i.ToString() + "." + sorts[i].name;
                sortButtons[i].OnClick += runsort;

                
            }

            foreach (Button b in sortButtons)
            {
                uis.Add(b);
            }

            uis.Add(DelayBox);
            uis.Add(DelayBoxLabel);

            uis.Add(ArraySizeBox);
            uis.Add(ArraySizeBoxLabel);

            uis.Add(visModePlusBut);
            uis.Add(visModeMinusBut);

            uis.Add(visModeBox);
            uis.Add(visModeBoxLabel);
            uis.Add(currentVisModeBoxLabel);

            uis.Add(restartSynthBut);

            uis.Add(crashSynthBut);

            uis.Add(InstrumentBox);
            uis.Add(InstrumentBoxLabel);

            uis.Add(reverbBox);
            uis.Add(reverbBoxLabel);
            
            uis.Add(SoundMulBox);
            uis.Add(SoundMulBoxLabel);
            
            uis.Add(NumChannelsBox);
            uis.Add(NumChannelsBoxLabel);
            
            uis.Add(PitchMinBox);
            uis.Add(PitchMinBoxLabel);
           
            uis.Add(PitchMaxBox);
            uis.Add(PitchMaxBoxLabel);
            uis.Add(showAudioMenuBut);
        }

        private void delay_box_on_entered(object sender, EventArgs e)
        {
            int delay = 0;
            bool success = int.TryParse(DelayBox.text, out delay);
            if (success)
            {
                sleepTime = delay;
            }
        }

        private void array_size_box_on_entered(object sender, EventArgs e)
        {
            int size = 0;
            bool success = int.TryParse(ArraySizeBox.text, out size);
            if (success) {
                arrSize = size;
                }
        }

        private void vis_mode_plus_but_click(object sender, EventArgs e)
        {
            if (visMode+1 < visModeNames.Length)
            {
                visModeBox.text = (visMode + 1).ToString();

                vis_mode_box_on_changed(this, new EventArgs());
            }
        }

        private void runsort(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string num = b.text.Split('.')[0];
            int sort = int.Parse(num);

            sortToRun = sorts[sort];
        }

        private void vis_mode_minus_but_click(object sender, EventArgs e)
        {
            if (visMode > 0)
            {
                visModeBox.text = (visMode-1).ToString();

                vis_mode_box_on_changed(this, new EventArgs());
            }
        }

        private void vis_mode_box_on_changed(object sender, EventArgs e)
        {
            int mode = 0;
            bool success = int.TryParse(visModeBox.text, out mode);
            if (success)
            {
                if (mode < visModeNames.Length)
                {
                    visMode = mode;
                    currentVisModeBoxLabel.text = visModeNames[visMode];
                } else
                {
                    visMode = 0;
                    currentVisModeBoxLabel.text = "Invalid mode";
                }
            } else
            {
                visMode = 0;
                currentVisModeBoxLabel.text = "Invalid number";
            }
        }

        public List<bool> oldEnableStates;
        bool showAudioPanel = false;
        private void audio_settings_but_click(object sender, EventArgs e)
        {
            if (showAudioPanel == false)
            {
                oldEnableStates = new List<bool>();

                for (int i = 0; i < uis.ToArray().Length; i++)
                {
                    oldEnableStates.Add(uis[i].Enabled);
                    uis[i].Enabled = false;
                }

                showAudioPanel = true;

                showAudioMenuBut.x = 12;
                showAudioMenuBut.y = Height - 100;

                reverbBox.Enabled = true;
                reverbBoxLabel.Enabled = true;

                PitchMaxBox.Enabled = true;
                PitchMaxBoxLabel.Enabled = true;

                PitchMinBox.Enabled = true;
                PitchMinBoxLabel.Enabled = true;

                InstrumentBox.Enabled = true;
                InstrumentBoxLabel.Enabled = true;

                NumChannelsBox.Enabled = true;
                NumChannelsBoxLabel.Enabled = true;

                SoundMulBox.Enabled = true;
                SoundMulBoxLabel.Enabled = true;

                showAudioMenuBut.Enabled = true;

                showAudioMenuBut.text = "Hide audio menu";
            } else
            {
                for (int i = 0; i < oldEnableStates.Count-1; i++)
                {
                    uis[i].Enabled = oldEnableStates[i];
                }

                showAudioMenuBut.text = "Show audio menu";

                showAudioMenuBut.x = 12;
                showAudioMenuBut.y = 120;

                showAudioPanel = false;
            }
        }

        private void restart_synth_but_click(object sender, EventArgs e)
        {
            StartSynth();
        }

        private void instrument_box_on_entered(object sender, EventArgs e)
        {
            INSTRUMENT = int.Parse(InstrumentBox.text);
            SendMsg("instr " +InstrumentBox.text);
            //SendMsg("");
        }

        private void crash_synth_but_click(object sender, EventArgs e)
        {
            SendMsg("-1,-1,-1.-1,-1");
        }

        private void pitch_min_box_on_entered(object sender, EventArgs e)
        {
            PITCHMIN = double.Parse(PitchMinBox.text);
        }

        private void pitch_max_box_on_entered(object sender, EventArgs e)
        {
            PITCHMAX = double.Parse(PitchMaxBox.text);
        }

        private void sound_mul_box_on_entered(object sender, EventArgs e)
        {
            SOUNDMUL = double.Parse(SoundMulBox.text);
        }

        private void num_channels_box_on_entered(object sender, EventArgs e)
        {
            NUMCHANNELS = double.Parse(NumChannelsBox.text);
        }

        private void reverb_box_on_entered(object sender, EventArgs e)
        {
             REVERB = int.Parse(reverbBox.text);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if (synthProcess.HasExited == false)
                synthProcess.Kill();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }

        public static Color HSL2RGB(double h, double sl, double l)

        {

            double v;

            double r, g, b;



            r = l;   // default to gray

            g = l;

            b = l;

            v = (l <= 0.5) ? (l * (1.0 + sl)) : (l + sl - l * sl);

            if (v > 0)

            {

                double m;

                double sv;

                int sextant;

                double fract, vsf, mid1, mid2;



                m = l + l - v;

                sv = (v - m) / v;

                h *= 6.0;

                sextant = (int)h;

                fract = h - sextant;

                vsf = v * sv * fract;

                mid1 = m + vsf;

                mid2 = v - vsf;

                switch (sextant)

                {

                    case 0:

                        r = v;

                        g = mid1;

                        b = m;

                        break;

                    case 1:

                        r = mid2;

                        g = v;

                        b = m;

                        break;

                    case 2:

                        r = m;

                        g = v;

                        b = mid1;

                        break;

                    case 3:

                        r = m;

                        g = mid2;

                        b = v;

                        break;

                    case 4:

                        r = mid1;

                        g = m;

                        b = v;

                        break;

                    case 5:

                        r = v;

                        g = m;

                        b = mid2;

                        break;

                }

            }

            Color rgb = Color.FromArgb(Convert.ToByte(r * 255.0f), Convert.ToByte(g * 255.0f), Convert.ToByte(b * 255.0f));


            return rgb;

        }












      

       








































       










       

        void HsvToRgb(double h, double S, double V, out int r, out int g, out int b)
        {
            // ######################################################################
            // T. Nathan Mundhenk
            // mundhenk@usc.edu
            // C/C++ Macro HSV to RGB

            double H = h;
            while (H < 0) { H += 360; };
            while (H >= 360) { H -= 360; };
            double R, G, B;
            if (V <= 0)
            { R = G = B = 0; }
            else if (S <= 0)
            {
                R = G = B = V;
            }
            else
            {
                double hf = H / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = V * (1 - S);
                double qv = V * (1 - S * f);
                double tv = V * (1 - S * (1 - f));
                switch (i)
                {

                    // Red is the dominant color

                    case 0:
                        R = V;
                        G = tv;
                        B = pv;
                        break;

                    // Green is the dominant color

                    case 1:
                        R = qv;
                        G = V;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = V;
                        B = tv;
                        break;

                    // Blue is the dominant color

                    case 3:
                        R = pv;
                        G = qv;
                        B = V;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = V;
                        break;

                    // Red is the dominant color

                    case 5:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // Just in case we overshoot on our math by a little, we put these here. Since its a switch it won't slow us down at all to put these here.

                    case 6:
                        R = V;
                        G = tv;
                        B = pv;
                        break;
                    case -1:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // The color is not defined, we should throw an error.

                    default:
                        //LFATAL("i Value error in Pixel conversion, Value is %d", i);
                        R = G = B = V; // Just pretend its black/white
                        break;
                }
            }
            r = Clamp((int)(R * 255.0));
            g = Clamp((int)(G * 255.0));
            b = Clamp((int)(B * 255.0));
        }

        /// <summary>
        /// Clamp a value to 0-255
        /// </summary>
        int Clamp(int i)
        {
            if (i < 0) return 0;
            if (i > 255) return 255;
            return i;
        }

        

        






        public bool CheckIfSortFinished()
        {
            bool b = true;
            for (int i = 0; i < array.Length; i++)
            {
                if(i == 0)
                {
                    marked[1] = i;
                    marked[2] = i;
                    if((array[i] > array[i]))
                    b = false;
                    dT();
                } else
                {
                    marked[1] = i;
                    marked[2] = i-1;
                    if ((array[i-1] > array[i]))
                        b = false;
                    dT();
                }
            }
            return b;
        }










        



        

        


       



        enum ShuffleModes
        {
            NormalSwap = 0,
            AlreadySorted =1,
            DecendingArray = 2,
            TotallyRandomized = 3,
            DescendingThenIncreasing = 4
        }


        ShuffleModes sm = ShuffleModes.NormalSwap;

        public void Shuffle(bool swapitms = true)
        {

            switch(sm)
            {
                case ShuffleModes.NormalSwap:
                    for (int i = 0; i < array.Length; i++)
                    {
                        swap(ref array[i], ref array[rand.Next(0, array.Length)]);
                        if (showShuffleAnim)
                            dT();
                        //Thread.Sleep(0);

                    }
                    break;

                case ShuffleModes.TotallyRandomized:
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = rand.Next(0, array.Length);
                        marked[1] = i;
                        if(showShuffleAnim)
                        dT();
                        //Thread.Sleep(0);

                    }
                    break;
                case ShuffleModes.DecendingArray:
                    for (int i = 0; i < array.Length/2; i++)
                    {
                       Util.  swap(array, i, array.Length - i-1);
                        if(showShuffleAnim)
                        dT();
                    }
                    break;
                case ShuffleModes.AlreadySorted:
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = i;
                        marked[1] = i;
                        if (showShuffleAnim)
                            dT();
                    }
                    break;
                case ShuffleModes.DescendingThenIncreasing:

                    for (int i = 0; i < array.Length/2; i++)
                    {
                        array[i] =(int) makeInRange(i, 0, array.Length/2, 0, array.Length);
                        marked[1] = i;
                        if (showShuffleAnim)
                            dT();
                    }

                    for (int i = array.Length/2; i < array.Length; i++)
                    {
                        array[i] = (int)makeInRange(i, array.Length , array.Length/2, 0, array.Length); ;
                        marked[1] = i;
                        if (showShuffleAnim)
                            dT();
                    }

                    break;
            }

                 


                


               
            
        }

       

        

       




        public void Shuffle(int[] array, bool swapitms = true)
        {
            if (swapitms)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    swap(ref array[i], ref array[rand.Next(0, array.Length)]);
                    dT();
                    //Thread.Sleep(0);

                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, array.Length);
                    dT();
                    //Thread.Sleep(0);

                }
            }
        }

        public void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;

            marked[1] = m;
            marked[2] = n;

            dT();
            //dT(n);
        }





        public void dT()
        {
            //  int[] copyArray = new int[array.Length];
            //  Array.Copy(array, copyArray, array.Length);
            //  snapshop.Add(copyArray);
            //  //cursorPoses.Add()
            //  snapshotCount++;



            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.ClearColor(Color.White);

            for (int i = 0; i < marked.Length; i++)
            {
                if (marked[i] >= array.Length)
                    marked[i] = array.Length - 1;
            }


            // DrawString(acceses.ToString(), 12, 12, 12, Color.Black);



            switch (visMode)
            {


                case 0:

                    GL.PointSize(stretchX);
                    GL.Begin(PrimitiveType.Points);

                    GL.Color4(Color4.Black);
                    for (int ia = 0; ia < array.Length; ia++)
                    {




                        if(useColor)
                            setColor(ia);


                        // sine plot  
                        //  GL.Vertex2(stretchX * ia, Height -(( stretchY * array[ia])+(float)Math.Cos (ia*0.1)*10));
                        GL.Vertex2(stretchX * ia, Height - stretchY * array[ia]);



                    }
                    GL.End();


                    GL.Color4(Color4.Red);
                    GL.PointSize(10);
                    GL.Begin(BeginMode.Lines);

                    for (int i = 0; i < marked.Length; i++)
                    {
                        if (marked[i] != -5)
                        {
                            GL.Vertex2(0, Height - (array[marked[i]] * stretchY));
                            GL.Vertex2(Width, Height - (array[marked[i]] * stretchY));

                            GL.Vertex2(marked[i] * stretchX, 0);
                            GL.Vertex2(marked[i] * stretchX, Height);
                        }
                    }

                    GL.End();

                    break;















                case 1:


                    GL.Begin(PrimitiveType.Lines);
                    GL.Color4(Color4.Black);
                    // GL.Color4(Color4.Black);
                    for (int ia = 0; ia < array.Length; ia++)
                    {
                        //    int r = 0;
                        //    int g = 0;
                        //    int b = 0;
                        //
                        //    HsvToRgb(makeInRange(ia, 0, array.Length, 0, 255), 1, 0.8, out r, out g, out b);
                        //
                        //    GL.Color4(new Color4((byte)r, (byte)g, (byte)b, (byte)255));
                        if(useColor)
                            setColor(ia);
                        GL.Vertex2(stretchX * ia, Height);
                        //sine plot
                        //GL.Vertex2(stretchX * ia, Height - ((stretchY * array[ia]) + (float)Math.Cos(ia * 0.1) * 10));
                        GL.Vertex2(stretchX * ia, Height - stretchY * array[ia]);
                        ;
                        //Console.Beep(snapshop[index][i] + 500, 1);
                        //acceses -= 2;

                    }
                    GL.End();




                    GL.Color4(Color4.Red);

                    GL.Begin(BeginMode.Lines);

                    for (int i = 0; i < marked.Length; i++)
                    {
                        if (marked[i] != -5)
                        {
                            GL.Vertex2(marked[i] * stretchX, 0);
                            GL.Vertex2(marked[i] * stretchX, Height);

                            //  int channel = 1;
                            //  int noteNumber = (int)makeInRange(marked[i], 0, array.Length, 50, 0);
                            //  var noteOnEvent = new NoteOnEvent(0, channel, noteNumber, 100, 5);
                            //  
                            //  midiOut.Send(noteOnEvent.GetAsShortMessage());

                        }
                    }

                    GL.End();

                    break;





                case 2:

                    //connected lines plot
                    GL.Begin(BeginMode.LineStrip);
                    GL.Color4(Color.Black);
                    for (int ia = 0; ia < array.Length; ia++)
                    {
                        if(useColor)
                            setColor(ia);
                        GL.Vertex2(ia * stretchX, Height - (array[ia] * stretchY));
                    }
                    GL.End();

                    GL.Color4(Color4.Red);

                    GL.Begin(BeginMode.Lines);

                    for (int i = 0; i < marked.Length; i++)
                    {
                        if (marked[i] != -5)
                        {
                            GL.Vertex2(marked[i] * stretchX, 0);
                            GL.Vertex2(marked[i] * stretchX, Height);

                        }
                    }

                    GL.End();

                    break;
















                case 3:
                    {
                        //scatter circle
                        float radiusX = (stretchX * array.Length / 2);
                        float radiusY = (stretchY * array.Length / 2);
                        GL.Begin(BeginMode.Points);
                        GL.Color4(Color4.Black);
                        for (int ia = 0; ia < array.Length; ia++)
                        {

                            

                            // GL.Vertex2(Width / 2, Height / 2);
                            GL.Vertex2(Width / 2 + (Math.Cos(array[ia]) * radiusX), Height / 2 + (Math.Sin(ia) * radiusY));
                        }
                        GL.End();

                        GL.Color4(Color4.Red);

                        GL.Begin(BeginMode.Lines);

                        for (int i = 0; i < marked.Length; i++)
                        {
                            if (marked[i] != -5)
                            {
                                GL.Vertex2(Width / 2, Height / 2);
                                GL.Vertex2(Width / 2 + (Math.Cos(marked[i]) * radiusX), Height / 2 + (Math.Sin(marked[i]) * marked[i] * radiusY));

                            }
                        }

                        GL.End();
                    }
                    break;
                //rainbow


                case 4:
                    GL.Begin(BeginMode.Lines);
                    for (int ia = 0; ia < array.Length; ia++)
                    {

                        setColor(ia);

                        GL.Vertex2(ia * stretchX, 0);
                        GL.Vertex2(ia * stretchX, Height);
                    }
                    GL.End();

                    GL.Begin(BeginMode.Lines);
                    GL.Color4(Color4.Red);
                    for (int i = 0; i < marked.Length; i++)
                    {
                        if (marked[i] != -5)
                        {
                            GL.Vertex2(marked[i] * stretchX, 0);
                            GL.Vertex2(marked[i] * stretchX, Height);
                        }
                    }

                    GL.End();

                    break;


                case 5:
                    GL.Begin(BeginMode.Lines);
                    GL.Color4(Color4.Black);
                    for (int ia = 0; ia < array.Length; ia++)
                    {
                        if(useColor)
                            setColor(ia);
                        GL.Vertex2(Width - ia * stretchX, array[ia] * 0.5f * stretchY);
                        GL.Vertex2(Width - ia * stretchX, Height - (array[ia] * 0.5f * stretchY));
                    }
                    GL.End();

                    GL.Color4(Color4.Red);

                    GL.Begin(BeginMode.Lines);

                    for (int i = 0; i < marked.Length; i++)
                    {
                        if (marked[i] != -5)
                        {
                            GL.Vertex2(Width - marked[i] * stretchX, 0);
                            GL.Vertex2(Width - marked[i] * stretchX, Height);

                        }
                    }

                    GL.End();
                    break;

                case 6:
                    GL.Begin(BeginMode.Lines);
                    GL.Color4(Color4.Black);
                    for (int ia = 0; ia < array.Length; ia++)
                    {
                        GL.Vertex2(Width - ia * stretchX, array[ia] * stretchY);
                        GL.Vertex2(Width - ia * stretchX, Height - (array[ia] * stretchY));
                    }
                    GL.End();

                    GL.Color4(Color4.Red);

                    GL.Begin(BeginMode.Lines);

                    for (int i = 0; i < marked.Length; i++)
                    {
                        if (marked[i] != -5)
                        {
                            GL.Vertex2(Width - marked[i] * stretchX, 0);
                            GL.Vertex2(Width - marked[i] * stretchX, Height);

                        }
                    }

                    GL.End();
                    break;

                case 7:
                    {
                        //color circle plot
                        //finally after a punch to the screen and a week of shit, this came togheter.
                        //turns out i just needed to convert the elements to radians
                        //and fuck with the stretch value
                        GL.Begin(/*BeginMode.TriangleFan*/BeginMode.Triangles);

                        //finally found this equasion
                        float stretchXY = (7f / array.Length) * 51.43f;
                        float radiusX = (stretchX * array.Length / 2);
                        float radiusY = (stretchY * array.Length / 2);
                        // Console.WriteLine(stretchXY.ToString());
                        for (int ia = 0; ia < array.Length; ia++)
                        {
                            setColor(ia);
                            

                            GL.Vertex2(Width / 2, Height / 2);
                            GL.Vertex2(Width / 2 + (Math.Cos(ia * stretchXY * (0.01745329252) - Math.PI / 2) * radiusX), Height / 2 + (Math.Sin(ia * stretchXY * (0.01745329252) - Math.PI / 2) * radiusY));



                            GL.Vertex2(Width / 2 + (Math.Cos((ia * stretchXY + stretchXY) * (0.01745329252) - Math.PI / 2) * radiusX), Height / 2 + (Math.Sin((ia * stretchXY + stretchXY) * (0.01745329252) - Math.PI / 2) * radiusY));
                        }
                        GL.End();

                        GL.Begin(/*BeginMode.TriangleFan*/BeginMode.Triangles);
                        GL.Color4(Color4.Red);
                        for (int ia = 0; ia < array.Length; ia++)
                        {
                            if (marked[ia] != -5)
                            {
                                int i = marked[ia];

                                GL.Vertex2(Width / 2, Height / 2);
                                GL.Vertex2(Width / 2 + (Math.Cos(i * stretchXY * (0.01745329252) - Math.PI / 2) * radiusX), Height / 2 + (Math.Sin(i * stretchXY * (0.01745329252) - Math.PI / 2) * radiusY));



                                GL.Vertex2(Width / 2 + (Math.Cos((i * stretchXY + stretchXY) * (0.01745329252) - Math.PI / 2) * radiusX), Height / 2 + (Math.Sin((i * stretchXY + stretchXY) * (0.01745329252) - Math.PI / 2) * radiusY));
                            }
                        }
                        GL.End();
                    }
                    break;










                case 8:
                    {
                        GL.Begin(/*BeginMode.TriangleFan*/BeginMode.Triangles);

                        float stretchXY = (7f / array.Length) * 51.43f;
                        float radiusX = (stretchX * array.Length / 2);
                        float radiusY = (stretchY * array.Length / 2);
                        GL.Color4(Color4.Black);

                        for (int ia = 0; ia < array.Length; ia++)
                        {

                            // int r = 0;
                            // int g = 0;
                            // int b = 0;
                            //
                            // HsvToRgb(makeInRange(array[ia], 0, array.Length, 255, 0), 1, 1, out r, out g, out b);
                            //
                            // GL.Color4((byte)r, (byte)g, (byte)b, (byte)255);
                            if (useColor)
                                setColor(ia);

                            GL.Vertex2(Width / 2, Height / 2);
                            //float stretchVal = ;
                            GL.Vertex2(Width / 2 + (Math.Cos(ia * stretchXY * (0.01745329252) - Math.PI / 2) * (array[ia] * stretchX / 2)), Height / 2 + (Math.Sin(ia * stretchXY * (0.01745329252) - Math.PI / 2) * (array[ia] * stretchY / 2)));



                            GL.Vertex2(Width / 2 + (Math.Cos((ia * stretchXY + stretchXY) * (0.01745329252) - Math.PI / 2) *  (array[ia] * stretchX / 2)), Height / 2 + (Math.Sin((ia * stretchXY + stretchXY) * (0.01745329252) - Math.PI / 2) * (array[ia] * stretchY / 2)));
                        }
                        GL.End();

                        GL.Begin(/*BeginMode.TriangleFan*/BeginMode.Triangles);
                        GL.Color4(Color4.Red);
                        for (int ia= 0; ia < array.Length; ia++)
                        {
                            if (marked[ia] != -5)
                            {
                                int i = marked[ia];

                                GL.Vertex2(Width / 2, Height / 2);
                                GL.Vertex2(Width / 2 + (Math.Cos(i * stretchXY * (0.01745329252) - Math.PI / 2) * radiusX), Height / 2 + (Math.Sin(i * stretchXY * (0.01745329252) - Math.PI / 2) * radiusY));



                                GL.Vertex2(Width / 2 + (Math.Cos((i * stretchXY + stretchXY) * (0.01745329252) - Math.PI / 2) * radiusX), Height / 2 + (Math.Sin((i * stretchXY + stretchXY) * (0.01745329252) - Math.PI / 2) * radiusY));
                            }
                        }
                        GL.End();
                    }
                    break;


                case 9:
                    {
                       
                        GL.Begin(/*BeginMode.TriangleFan*/BeginMode.Triangles);

                       // Console.WriteLine(stretchXY.ToString());
                        for (int ia = 0; ia < array.Length; ia++)
                        {

                            if(useColor)
                                setColor(ia);

                            GL.Vertex2(Width / 2, Height / 2);
                            GL.Vertex2(colorCirclePoints1[ia]);
                            GL.Vertex2(colorCirclePoints2[ia]);
                        }
                        GL.End();
                        GL.Begin(/*BeginMode.TriangleFan*/BeginMode.Triangles);
                        GL.Color4(Color4.Red);
                        for (int ia = 0; ia < array.Length; ia++)
                        {
                            if (marked[ia] != -5)
                            {
                                int i = marked[ia];

                                GL.Vertex2(Width / 2, Height / 2);
                                GL.Vertex2(colorCirclePoints1[i]);
                                GL.Vertex2(colorCirclePoints2[i]);
                            }
                        }
                        GL.End();
                    }
                    break;

                case 10:
                    {
                        GL.Begin(/*BeginMode.TriangleFan*/BeginMode.Triangles);

                        float stretchXY = (7f / array.Length) * 51.43f;
                        float radiusX = (stretchX * array.Length / 2)-100;
                        float radiusY = (stretchY * array.Length / 2)-100;
                        GL.Color4(Color4.Black);
                        // Console.WriteLine(stretchXY.ToString());
                        for (int ia = 0; ia < array.Length; ia++)
                        {
                            if(useColor)
                                setColor(ia);
                            int dist = Math.Abs(ia - array[ia]);
                               float disparity = 1.0f - ((float)Math.Min(dist, array.Length - dist) / ((float)array.Length / 2.0f));
                               float lenght = (float)disparity * radiusY;
                            //int iaMinusArrayIa = ia - array[ia];
                            //int dist = Math.Abs(iaMinusArrayIa);
                            //int lenghtMinusDist = array.Length - dist;
                            //float arrayLenghtDividedByTwo = (float)array.Length / 2.0f;
                            //float minimum = (float)Math.Min(dist, lenghtMinusDist);
                            //float minimumDividedByLenght = (minimum / (arrayLenghtDividedByTwo));
                            //float disparity = 1.0f - minimumDividedByLenght;
                            //float lenght = (float)disparity * radiusY;

                            GL.Vertex2(Width / 2, Height / 2);
                            GL.Vertex2(Width / 2 + (Math.Cos(ia * stretchXY * (0.01745329252) - Math.PI / 2) * (radiusX+lenght)), Height / 2 + (Math.Sin(ia * stretchXY * (0.01745329252) - Math.PI / 2) * (radiusY + lenght)));



                            GL.Vertex2(Width / 2 + (Math.Cos((ia * stretchXY + stretchXY) * (0.01745329252) - Math.PI / 2) * (radiusX + lenght)), Height / 2 + (Math.Sin((ia * stretchXY + stretchXY) * (0.01745329252) - Math.PI / 2) * (radiusY + lenght)));
                        }
                        GL.End();

                        GL.Begin(/*BeginMode.TriangleFan*/BeginMode.Triangles);
                        GL.Color4(Color4.Red);
                        for (int ia = 0; ia < array.Length; ia++)
                        {
                            if (marked[ia] != -5)
                            {
                                int i = marked[ia];

                                int dist = Math.Abs(i - array[i]);
                                float disparity = 1.0f - ((float)Math.Min(dist, array.Length - dist) / ((float)array.Length / 2.0f));
                                float lenght = (float)disparity * radiusY;

                                GL.Vertex2(Width / 2, Height / 2);
                                GL.Vertex2(Width / 2 + (Math.Cos(i * stretchXY * (0.01745329252) - Math.PI / 2) * (radiusX + lenght)), Height / 2 + (Math.Sin(i * stretchXY * (0.01745329252) - Math.PI / 2) * (radiusY + lenght)));



                                GL.Vertex2(Width / 2 + (Math.Cos((i * stretchXY + stretchXY) * (0.01745329252) - Math.PI / 2) * (radiusX + lenght)), Height / 2 + (Math.Sin((i * stretchXY + stretchXY) * (0.01745329252) - Math.PI / 2) * (radiusY + lenght)));
                            }
                        }
                        GL.End();
                    }
                    break;

                case 11:
                    {
                        GL.Begin(/*BeginMode.TriangleFan*/BeginMode.Points);

                        float stretchXY = (7f / array.Length) * 51.43f;
                        float radiusX = (stretchX * array.Length / 2) - 100;
                        float radiusY = (stretchY * array.Length / 2) - 100;
                        GL.Color4(Color4.Black);
                        // Console.WriteLine(stretchXY.ToString());
                        for (int ia = 0; ia < array.Length; ia++)
                        {
                            if(useColor)
                                setColor(ia);
                            int dist = Math.Abs(ia - array[ia]);
                            float disparity = 1.0f - ((float)Math.Min(dist, array.Length - dist) / ((float)array.Length / 2.0f));
                            float lenght = (float)disparity * radiusY;

                            
                            GL.Vertex2(Width / 2 + (Math.Cos(ia * stretchXY * (0.01745329252) - Math.PI / 2) * (radiusX + lenght)), Height / 2 + (Math.Sin(ia * stretchXY * (0.01745329252) - Math.PI / 2) * (radiusY + lenght)));



                            
                        }
                        GL.End();

                        GL.Begin(/*BeginMode.TriangleFan*/BeginMode.Lines);
                        GL.Color4(Color4.Red);
                        for (int ia = 0; ia < array.Length; ia++)
                        {
                            if (marked[ia] != -5)
                            {
                                int i = marked[ia];

                                int dist = Math.Abs(i - array[i]);
                                float disparity = 1.0f - ((float)Math.Min(dist, array.Length - dist) / ((float)array.Length / 2.0f));
                                float lenght = (float)disparity * radiusY;

                                GL.Vertex2(Width / 2, Height / 2);
                                GL.Vertex2(Width / 2 + (Math.Cos(i * stretchXY * (0.01745329252) - Math.PI / 2) * (radiusX + lenght)), Height / 2 + (Math.Sin(i * stretchXY * (0.01745329252) - Math.PI / 2) * (radiusY + lenght)));
                            }
                        }
                        GL.End();
                    }
                    break;

                case 12:
                    {
                        GL.Begin(/*BeginMode.TriangleFan*/BeginMode.LineStrip);

                        float stretchXY = (7f / array.Length) * 51.43f;
                        float radiusX = (stretchX * array.Length / 2) - 100;
                        float radiusY = (stretchY * array.Length / 2) - 100;
                        GL.Color4(Color4.Black);
                        // Console.WriteLine(stretchXY.ToString());
                        for (int ia = 0; ia < array.Length; ia++)
                        {
                            if(useColor)
                                setColor(ia);
                            int dist = Math.Abs(ia - array[ia]);
                            float disparity = 1.0f - ((float)Math.Min(dist, array.Length - dist) / ((float)array.Length / 2.0f));
                            float lenght = (float)disparity * radiusY;


                            GL.Vertex2(Width / 2 + (Math.Cos(ia * stretchXY * (0.01745329252) - Math.PI / 2) * (radiusX + lenght)), Height / 2 + (Math.Sin(ia * stretchXY * (0.01745329252) - Math.PI / 2) * (radiusY + lenght)));




                        }
                        GL.End();

                        GL.Begin(/*BeginMode.TriangleFan*/BeginMode.Lines);
                        GL.Color4(Color4.Red);
                        for (int ia = 0; ia < array.Length; ia++)
                        {
                            if (marked[ia] != -5)
                            {
                                int i = marked[ia];

                                int dist = Math.Abs(i - array[i]);
                                float disparity = 1.0f - ((float)Math.Min(dist, array.Length - dist) / ((float)array.Length / 2.0f));
                                float lenght = (float)disparity * radiusY;

                                GL.Vertex2(Width / 2, Height / 2);
                                GL.Vertex2(Width / 2 + (Math.Cos(i * stretchXY * (0.01745329252) - Math.PI / 2) * (radiusX + lenght)), Height / 2 + (Math.Sin(i * stretchXY * (0.01745329252) - Math.PI / 2) * (radiusY + lenght)));
                            }
                        }
                        GL.End();
                    }
                    break;

                case 13:
                    GL.Begin(BeginMode.Lines);
                    GL.Color4(Color4.Black);
                    for (int ia = 0; ia < array.Length; ia++)
                    {
                        if(useColor)
                            setColor(ia);
                        GL.Vertex2(array[ia] * 0.5f * stretchX, Height - ia * stretchY);
                        GL.Vertex2(Width-( array[ia] * 0.5f * stretchX), Height - ia * stretchY);
                    }
                    GL.End();

                    GL.Color4(Color4.Red);

                    GL.Begin(BeginMode.Lines);

                    for (int i = 0; i < marked.Length; i++)
                    {
                        if (marked[i] != -5)
                        {

                            GL.Vertex2(0, Height - marked[i] * stretchX);
                            GL.Vertex2(Width, Height - marked[i] * stretchX);
                        }
                    }
                    GL.End();
                    break;

                case 14:
                    GL.Begin(BeginMode.Lines);
                    GL.Color4(Color4.Black);
                    for (int ia = 0; ia < array.Length; ia++)
                    {
                        if(useColor)
                            setColor(ia);
                        GL.Vertex2(array[ia] *stretchX, Height - ia * stretchY);
                        GL.Vertex2(Width - (array[ia]  * stretchX), Height - ia * stretchY);
                    }
                    GL.End();

                    GL.Color4(Color4.Red);

                    GL.Begin(BeginMode.Lines);

                    for (int i = 0; i < marked.Length; i++)
                    {
                        if (marked[i] != -5)
                        {

                            GL.Vertex2(0, Height - marked[i] * stretchX);
                            GL.Vertex2(Width, Height - marked[i] * stretchX);
                        }
                    }
                    GL.End();
                    break;
            }






            //GL.Vertex2(Width / 2, Height / 2);
            //GL.PointSize(3);
            //GL.LineWidth(5);


            //GL.End();



            //   GL.Begin(BeginMode.Triangles);
            //
            //   GL.Color4(Color4.Black);
            //   GL.Vertex2(Width / 2, Height / 2);
            //   GL.Vertex2(Width / 2 + (Math.Cos(iaa) * 200), Height / 2 + (Math.Sin(iaa) * 200));
            //   GL.Vertex2(Width / 2 + (Math.Cos(iaa) * 200), Height / 2 + (Math.Sin(iaa+0.01f) * 200));
            //
            //
            //   GL.End();



            //epilepsy mode

            //  vismodeaccumulator += 0.001f;
            //  if (vismodeaccumulator > 6)
            //      vismodeaccumulator = 0;
            //  visMode = (int)vismodeaccumulator;
            int noteCount = (int)Math.Min(getMarkedCount(), NUMCHANNELS);
            int voice = 0;
            string msgStr = "";
            for (int i = 0; i < marked.Length; i++)
            {

                if (marked[i] != -5)
                {
                    
                    int currentLen = array.Length;

                    //PITCH
                    double pitch = array[Math.Min(Math.Max(marked[i], 0), currentLen - 1)] / (double)currentLen * (PITCHMAX - PITCHMIN) + PITCHMIN;
                    int pitchmajor = (int)pitch;
                    int pitchminor = (int)((pitch - ((int)pitch)) * 8192d) + 8192;

                    int vel = (int)(Math.Pow(PITCHMAX - pitchmajor, 2d) * (Math.Pow(noteCount, -0.25)) * 64d * SOUNDMUL) / 2; //I'VE SOLVED IT!!

                    if (SOUNDMUL >= 1 && vel < 256)
                    {
                        vel *= vel;
                    }

                    // channels[voice].noteOn(pitchmajor, vel);
                    // channels[voice].setPitchBend(pitchminor);
                    // channels[voice].controlChange(REVERB, 10);
                    //  var noteOnEvent = new NoteOnEvent(0, 1, pitchmajor,(int) velnew, 500);
                    //
                    //  midiOut.Send(noteOnEvent.GetAsShortMessage());
                    msgStr += pitchmajor.ToString() + ',' + vel.ToString() + ',' + pitchmajor.ToString() + ',' + REVERB + ';';
                    if ((++voice % Math.Max(noteCount, 1)) == 0)
                        break;
                }

            }
            //  if(msgStr != "")
            //msgStr = msgStr.Remove(msgStr.Length - 1);

            if (msgStr != "")
            {
                SendMsg(msgStr);
                msgStr = "";
            }



            clearMarked();

            this.SwapBuffers();
            if (sleepTime != 0)
                Thread.Sleep(sleepTime);
        }
        Vector2[] colorCirclePoints1;
        Vector2[] colorCirclePoints2;
        public void SendMsg(string msg)
        {
            if (synthProcess.HasExited == false)
            {
                messageStream.WriteLine(msg);
                messageStream.Flush();
                //messageStream.WriteLine("0,0,0,0");
                //messageStream.Flush();
            }
        }
        public void genCirclePoints ()
        {
            colorCirclePoints1 = new Vector2[array.Length];
            colorCirclePoints2 = new Vector2[array.Length];
            float stretchXY = (7f / array.Length) * 51.43f;
            float radiusX = (stretchX * array.Length / 2);
            float radiusY = (stretchY * array.Length / 2);
            for (int ia = 0; ia < array.Length; ia++)
            {
                Vector2 p1 = new Vector2((Width / 2 + ((float)Math.Cos(ia * stretchXY * (0.01745329252f) - Math.PI / 2) * radiusX)), Height / 2 + ((float)Math.Sin(ia * stretchXY * (0.01745329252f) - Math.PI / 2) * radiusY));
                Vector2 p2 = new Vector2(Width / 2 + ((float)Math.Cos((ia * stretchXY + stretchXY) * (0.01745329252f) - Math.PI / 2) * radiusX), Height / 2 + ((float)Math.Sin((ia * stretchXY + stretchXY) * (0.01745329252f) - Math.PI / 2) * radiusY));

                colorCirclePoints1[ia] = p1;
                colorCirclePoints2[ia] = p2;
            }
        }

        int iaa = 0;
        //16
         double NUMCHANNELS = 16;
         double PITCHMIN = 25d;
         double PITCHMAX = 105d;
        //1d
         double SOUNDMUL = 0.5d;
        public float vismodeaccumulator = 0;
        public bool useColor = true;
        public int visMode = 0;
        //0. points
        //1. lines
        //2. connected lines
        //3. scatter cirlce gay
        //4. rainbow
        //5. horizontal pyramid
        //6. double horizontal pyramid
        //7. color circle
        //8. spiral tri plot
        //9. color circle quick
        //10. disparity circle
        //11. scatter circle
        //12. connected scatter circle
        //13. vertical pyramid
        //14. double vertical pyramid

        //91
        public string[] visModeNames = {
            "Scatter points",
            "Line graph",
            "Connected lines",
            "idk",
            "Rainbow",
            "Horizontal pyramid",
            "Double horizontal pyramid",
            "Color circle",
            "Spiral",
                "Dast color circle",
                "Disparity circle",
                "Scatter circle",
                "Connected circle",
                "Vertical pyramid",
                "Double vertical pyramid"
        };
        private int REVERB = 50;
        public void setColor (int ia)
        {
            int r = 0;
            int g = 0;
            int b = 0;

            HsvToRgb(makeInRange(array[ia], 0, array.Length, 0, 360), 1, 1, out r, out g, out b);


            GL.Color4((byte)r, (byte)g, (byte)b, (byte)255);
        }
        public int getMarkedCount()
        {
            int ret = 0;
            for (int i = 0; i < marked.Length; i++)
            {
                if (marked[i] != -5)
                    ret++;
            }
                return ret;
        }
        

        public void dT(int[] arr)
        {
            //      int[] copyArray = new int[arr.Length];
            //      Array.Copy(arr, copyArray, arr.Length);
            //      snapshop.Add(copyArray);
            //      //cursorPoses.Add()
            //      snapshotCount++;
            int[] oldarray = new int[array.Length];
            Array.Copy(array, oldarray, array.Length);
            array = arr;
            dT();
            array = oldarray;
            oldarray = null;
        }



        void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            marked[1] = a;
            marked[2] = b;

        }

        
    }

   
}
