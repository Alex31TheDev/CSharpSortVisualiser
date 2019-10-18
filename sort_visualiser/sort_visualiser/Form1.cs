using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using ConsolaGraphicsEngine;
using System.Runtime.InteropServices;
using System.Reflection;
using org.mariuszgromada.math.mxparser;
using OpenTK.Audio.OpenAL;
using OpenTK.Audio;
using static OpenTK.Audio.OpenAL.XRamExtension;
using System.Media;

namespace GraphingCalc
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();



            //offsetBoxX.Text = offsetX.ToString();
            //textBox3.Text = offsetY.ToString();
            //stretchBoxX.Text = stretchX.ToString();
            //textBox4.Text = stretchY.ToString();
            //stepSizeBox.Text = stepSize.ToString();
            //stepNumberBox.Text = steps.ToString();
            //stepStartBox.Text = startSteps.ToString();
            //fStepBox.Text = stepOnFunction.ToString();
            //thicknessBox.Text = thickness.ToString();
            //checkBox1.Checked = hasGrid;
            //checkBox2.Checked = useNewAlg;

            //button
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            //for (int i = 0; i < 2000; i++)
            //{
            //    debug(Convert.ToChar(i).ToString());
            //}
            //√

            Thread t = new Thread(new ThreadStart(ss));
            t.Start();

            s();

            //Thread t = new Thread(new ThreadStart(s));
            //t.Start();

            //DoUpdate();
        }
        public PSD sal;

        void s()
        {
            sal = new PSD(804, 574);
            //sal.b = new Bitmap(804, 574);
            sal.VSync = VSyncMode.Off;
            sal.Run();
        }
        Image b;

        void ss()
        {
            //File.CreateText("daaddadadadaddaadadda");
        }

        async void DoUpdate()
        {
            int i = 0;
            while (true)
            {
                await Task.Delay(1);

                void Reciever()
                {
                    if (File.Exists("written.txt"))
                    {
                        if (File.Exists("1.bmp"))
                        {
                            Bitmap bmp = new Bitmap("1.bmp");




                            //bmp.Save(i + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                            b = new Bitmap(bmp);
                            graphBox.Image = b;
                            bmp.Dispose();
                            File.Delete("1.bmp");
                            //File.Delete("1.bmp");
                            File.Move("written.txt", "read.txt");

                        }

                    }
                }

                Reciever();
                i++;
            }
        }

        #region shit
        private void offsetBoxX_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void stretchBoxX_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void stepSizeBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void stepNumberBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void stepStartBox_TextChanged(object sender, EventArgs e)
        {
        }
        //
        private void startButton_Click(object sender, EventArgs e)
        {
            //        Graph();
        }
        //
        private void saveButton_Click(object sender, EventArgs e)
        {
            //        b.Save("capture " + DateTime.Now.ToString().Replace('.', '_').Replace('/', '_').Replace(':', '_').Replace(' ', '_') + ".bmp");
        }
        //
        private void fStepBox_TextChanged(object sender, EventArgs e)
        {
            //
        }
        //
        private void clearButton_Click(object sender, EventArgs e)
        {
            //        float elapsed_time = 0;
            //        var stopwatch = new Stopwatch();
            //        stopwatch.Start();
            //
            //        Fill(0, 0, Width, Height, backColor, false, true);
            //
            //        UpdateScreen(true);
            //
            //        stopwatch.Stop();
            //        elapsed_time = stopwatch.ElapsedMilliseconds;
            //
            //        debug("Elapsed clear time: " + elapsed_time.ToString());
        }
        //
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //        hasGrid = checkBox1.Checked;
        }
        //
        private void numberButton1_Click(object sender, EventArgs e)
        {

        }

        private void numberButton2_Click(object sender, EventArgs e)
        {

        }

        private void numberButton3_Click(object sender, EventArgs e)
        {

        }

        private void numberButton4_Click(object sender, EventArgs e)
        {

        }

        private void numberButton5_Click(object sender, EventArgs e)
        {

        }

        private void numberButton6_Click(object sender, EventArgs e)
        {

        }

        private void numberButton7_Click(object sender, EventArgs e)
        {

        }

        private void numberButton8_Click(object sender, EventArgs e)
        {

        }

        private void numberButton9_Click(object sender, EventArgs e)
        {
            //
        }
        //
        private void numberButton0_Click(object sender, EventArgs e)
        {
            //
        }
        //
        private void numberButtonMultiply_Click(object sender, EventArgs e)
        {
            //        func += Function.operatorKeyword + Function.multiplicationKeyword + Function.separator;
            //        operationBox.Text += "* ";
        }
        //
        private void numberButtonDivide_Click(object sender, EventArgs e)
        {
            //        func += Function.operatorKeyword + Function.divisionKeyword + Function.separator;
            //        operationBox.Text += "/ ";
        }
        //
        private void numberButtonAdd_Click(object sender, EventArgs e)
        {
            //        func += Function.operatorKeyword + Function.additionKeyword + Function.separator;
            //        operationBox.Text += "+ ";
        }
        //
        private void numberButtonPow_Click(object sender, EventArgs e)
        {
            //        func += Function.operatorKeyword + Function.powerKeyword + Function.separator;
            //        operationBox.Text += "^ ";
        }
        //
        private void numberButtonSubstract_Click(object sender, EventArgs e)
        {
            //        func += Function.operatorKeyword + Function.subtractionKeyword + Function.separator;
            //        operationBox.Text += "- ";
        }
        //
        private void numberButtonX_Click(object sender, EventArgs e)
        {
            //        func += Function.varKeyword + "x" + Function.separator;
            //        operationBox.Text += "x ";
        }
        //
        private void numberButtonDot_Click(object sender, EventArgs e)
        {

        }

        private void numberButtonCos_Click(object sender, EventArgs e)
        {

        }

        private void numberButtonSin_Click(object sender, EventArgs e)
        {

        }
        //
        private void numberButtonDelete_Click(object sender, EventArgs e)
        {
            //        if (func.Length != 0)
            //        {
            //            List<string> pieces = func.Split(Function.separator).ToList();
            //            if (pieces.ToArray().Length >= 1)
            //            {
            //                //pieces.RemoveAt(pieces.ToArray().Length - 2);
            //                pieces.RemoveAt(pieces.ToArray().Length-2);
            //                operationBox.Text = operationBox.Text.Remove(operationBox.Text.Length - 2, 2);
            //            }
            //            else
            //            {
            //                operationBox.Text = operationBox.Text.Remove(0, 2);
            //                pieces.RemoveAt(0);
            //            }
            //
            //            func = "";
            //            for (int i = 0; i < pieces.ToArray().Length-1; i++)
            //            {
            //                func += pieces[i] + Function.separator;
            //            }
            //        }
        }
        //
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //        useNewAlg = checkBox2.Checked;
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            //        numberButton0.Enabled = !numberButton0.Enabled;
            //        numberButton1.Enabled = !numberButton1.Enabled;
            //        numberButton2.Enabled = !numberButton2.Enabled;
            //        numberButton3.Enabled = !numberButton3.Enabled;
            //        numberButton4.Enabled = !numberButton4.Enabled;
            //        numberButton5.Enabled = !numberButton5.Enabled;
            //        numberButton6.Enabled = !numberButton6.Enabled;
            //        numberButton7.Enabled = !numberButton7.Enabled;
            //        numberButton8.Enabled = !numberButton8.Enabled;
            //        numberButton9.Enabled = !numberButton9.Enabled;
            //
            //        numberButtonSin.Enabled = !numberButtonSin.Enabled;
            //        numberButtonCos.Enabled = !numberButtonCos.Enabled;
            //
            //        numberButtonDelete.Enabled = !numberButtonDelete.Enabled;
            //
            //        numberButtonParantesesOpen  .Enabled   = !numberButtonParantesesOpen.Enabled;
            //        numberButtonParantesesClosed.Enabled = !numberButtonParantesesClosed.Enabled;
            //
            //        numberButtonAdd      .Enabled      = !numberButtonAdd.Enabled;
            //        numberButtonSubtract .Enabled = !numberButtonSubtract.Enabled;
            //        numberButtonMultiply .Enabled = !numberButtonMultiply.Enabled;
            //        numberButtonDivide   .Enabled   = !numberButtonDivide.Enabled;
            //        numberButtonPow      .Enabled      = !numberButtonPow.Enabled;
            //        numberButtonX        .Enabled        = !numberButtonX.Enabled;
            //        numberButtonDot      .Enabled      = !numberButtonDot.Enabled;
            //
            //        operationBox.Enabled = !operationBox.Enabled;
            //
            //
            //
            //        numberButton0.Visible = !numberButton0.Visible;
            //        numberButton1.Visible = !numberButton1.Visible;
            //        numberButton2.Visible = !numberButton2.Visible;
            //        numberButton3.Visible = !numberButton3.Visible;
            //        numberButton4.Visible = !numberButton4.Visible;
            //        numberButton5.Visible = !numberButton5.Visible;
            //        numberButton6.Visible = !numberButton6.Visible;
            //        numberButton7.Visible = !numberButton7.Visible;
            //        numberButton8.Visible = !numberButton8.Visible;
            //        numberButton9.Visible = !numberButton9.Visible;
            //
            //        numberButtonSin.Visible = !numberButtonSin.Visible;
            //        numberButtonCos.Visible = !numberButtonCos.Visible;
            //
            //        numberButtonDelete.Visible = !numberButtonDelete.Visible;
            //
            //        numberButtonParantesesOpen  .Visible   = !numberButtonParantesesOpen.Visible;
            //        numberButtonParantesesClosed.Visible = !numberButtonParantesesClosed.Visible;
            //
            //        numberButtonAdd     .Visible      = !numberButtonAdd.Visible;
            //        numberButtonSubtract.Visible = !numberButtonSubtract.Visible;
            //        numberButtonMultiply.Visible = !numberButtonMultiply.Visible;
            //        numberButtonDivide  .Visible   = !numberButtonDivide.Visible;
            //        numberButtonPow     .Visible      = !numberButtonPow.Visible;
            //        numberButtonX       .Visible        = !numberButtonX.Visible;
            //        numberButtonDot     .Visible      = !numberButtonDot.Visible;
            //
            //        operationBox.Visible = !operationBox.Visible;
            //    }
        }
        #endregion


    }

    


    public class PSD : UiClass
    {

        

        int alternationCount = 0;
        public class Fffff
        {
            string content = "";

            public const string constKeyword = "[const]";
            public const string funcKeyword = "[func]";
            public const string operatorKeyword = "[op]";
            public const string varKeyword = "[var]";
            public const string parantesesKeyword = "[paran]";

            public const string additionKeyword = "add";
            public const string subtractionKeyword = "sub";
            public const string multiplicationKeyword = "mul";
            public const string divisionKeyword = "div";
            public const string powerKeyword = "pow";

            public const char separator = ';';

            static string[] SYMBOLS = { constKeyword, funcKeyword, operatorKeyword, varKeyword, parantesesKeyword };
            static List<int> constantsIndexes;
            static List<int> parantesesIndexes;
            static List<int> additionIndexes;
            static List<int> subtractionIndexes;
            static List<int> multiplicationIndexes;
            static List<int> divisionIndexes;
            static List<int> powerIndexes;
            static List<int> variableIndexes;
            static int numOfAdditions;
            static int numOfSubtractions;
            static int numOfMultiplications;
            static int numOfDivisions;
            static int numOfPowers;
            static int numOfVariables = 0;
            public static float Eval(string func, float x = float.PositiveInfinity)
            {
                if (func == "")
                    return 0;
                float result = 0;
                List<string> values = new List<string>();
                List<string> pieces = func.Split(separator).ToList();

                constantsIndexes = new List<int>();
                parantesesIndexes = new List<int>();
                additionIndexes = new List<int>();
                subtractionIndexes = new List<int>();
                multiplicationIndexes = new List<int>();
                divisionIndexes = new List<int>();

                numOfAdditions = 0;
                numOfSubtractions = 0;
                numOfMultiplications = 0;
                numOfDivisions = 0;
                numOfPowers = 0;
                for (int i = 0; i < pieces.ToArray().Length; i++)
                {
                    if (pieces[i].StartsWith(varKeyword))
                    {
                        pieces[i] = constKeyword + x.ToString();
                    }
                    if (pieces[i].StartsWith(constKeyword))
                    {
                        if (pieces[i].Remove(0, constKeyword.Length) == "pi")
                            pieces[i] = constKeyword + Math.PI.ToString();
                        if (pieces[i].Remove(0, constKeyword.Length) == "e")
                            pieces[i] = constKeyword + Math.E.ToString();

                    }
                }


                CalculateIndexes(pieces);
                //idea: call solve inside the paranteses (everything between the index of the first one to the index of the second one)
                //then replace the thing with a const
                //and calculate everything outside the paranteses
                //if there are multiple layers of paranteses solve the inside one and then solve the outter one and solve everything outside (using a for loop or something)
                Solve(ref pieces);

                result = float.Parse(pieces[0].Remove(0, constKeyword.Length).Replace(separator, ' '));
                return result;
            }
            public static void Solve(ref List<string> pieces)
            {
                for (int i = 0; i < numOfPowers; i++)
                {
                    float num1 = 0;
                    float num2 = 0;
                    if (pieces[constantsIndexes[powerIndexes[0] - 1]].StartsWith(constKeyword))
                        num1 = float.Parse(pieces[constantsIndexes[powerIndexes[0] - 1]].Remove(0, constKeyword.Length));
                    if (pieces[constantsIndexes[powerIndexes[0] + 1]].StartsWith(constKeyword))
                        num2 = float.Parse(pieces[constantsIndexes[powerIndexes[0] + 1]].Remove(0, constKeyword.Length));
                    pieces[powerIndexes[0] - 1] = constKeyword + (Math.Pow(num1, num2)).ToString();
                    pieces.RemoveAt(powerIndexes[0] + 1);
                    pieces.RemoveAt(powerIndexes[0]);
                    CalculateIndexes(pieces, false, false);

                }

                for (int i = 0; i < numOfMultiplications; i++)
                {
                    float num1 = 0;
                    float num2 = 0;
                    if (pieces[constantsIndexes[multiplicationIndexes[0] - 1]].StartsWith(constKeyword))
                        num1 = float.Parse(pieces[constantsIndexes[multiplicationIndexes[0] - 1]].Remove(0, constKeyword.Length));
                    if (pieces[constantsIndexes[multiplicationIndexes[0] + 1]].StartsWith(constKeyword))
                        num2 = float.Parse(pieces[constantsIndexes[multiplicationIndexes[0] + 1]].Remove(0, constKeyword.Length));
                    pieces[multiplicationIndexes[0] - 1] = constKeyword + (num1 * num2).ToString();

                    pieces.RemoveAt(multiplicationIndexes[0] + 1);
                    pieces.RemoveAt(multiplicationIndexes[0]);
                    CalculateIndexes(pieces, false, false);
                }
                for (int i = 0; i < numOfDivisions; i++)
                {
                    float num1 = 0;
                    float num2 = 0;
                    if (pieces[constantsIndexes[divisionIndexes[0] - 1]].StartsWith(constKeyword))
                        num1 = float.Parse(pieces[constantsIndexes[divisionIndexes[0] - 1]].Remove(0, constKeyword.Length));
                    if (pieces[constantsIndexes[divisionIndexes[0] + 1]].StartsWith(constKeyword))
                        num2 = float.Parse(pieces[constantsIndexes[divisionIndexes[0] + 1]].Remove(0, constKeyword.Length));
                    pieces[divisionIndexes[0] - 1] = constKeyword + (num1 / num2).ToString();
                    pieces.RemoveAt(divisionIndexes[0] + 1);
                    pieces.RemoveAt(divisionIndexes[0]);
                    CalculateIndexes(pieces, false, false);
                }

                for (int i = 0; i < numOfAdditions; i++)
                {
                    float num1 = 0;
                    float num2 = 0;
                    if (pieces[constantsIndexes[additionIndexes[0] - 1]].StartsWith(constKeyword))
                        num1 = float.Parse(pieces[constantsIndexes[additionIndexes[0] - 1]].Remove(0, constKeyword.Length));
                    if (pieces[constantsIndexes[additionIndexes[0] + 1]].StartsWith(constKeyword))
                        num2 = float.Parse(pieces[constantsIndexes[additionIndexes[0] + 1]].Remove(0, constKeyword.Length));
                    pieces[additionIndexes[0] - 1] = constKeyword + (num1 + num2).ToString();
                    pieces.RemoveAt(additionIndexes[0] + 1);
                    pieces.RemoveAt(additionIndexes[0]);
                    CalculateIndexes(pieces, false, false);
                }
                for (int i = 0; i < numOfSubtractions; i++)
                {
                    float num1 = 0;
                    float num2 = 0;
                    if (pieces[constantsIndexes[subtractionIndexes[0] - 1]].StartsWith(constKeyword))
                        num1 = float.Parse(pieces[constantsIndexes[subtractionIndexes[0] - 1]].Remove(0, constKeyword.Length));
                    if (pieces[constantsIndexes[subtractionIndexes[0] + 1]].StartsWith(constKeyword))
                        num2 = float.Parse(pieces[constantsIndexes[subtractionIndexes[0] + 1]].Remove(0, constKeyword.Length));
                    pieces[subtractionIndexes[0] - 1] = constKeyword + (num1 - num2).ToString();
                    pieces.RemoveAt(subtractionIndexes[0] + 1);
                    pieces.RemoveAt(subtractionIndexes[0]);
                    CalculateIndexes(pieces, false, false);
                }
            }
            public static void CalculateIndexes(List<string> pieces, bool updateNumOf = true, bool resetNum = true)
            {
                constantsIndexes = new List<int>();
                parantesesIndexes = new List<int>();
                additionIndexes = new List<int>();
                subtractionIndexes = new List<int>();
                multiplicationIndexes = new List<int>();
                divisionIndexes = new List<int>();
                powerIndexes = new List<int>();

                if (resetNum)
                {
                    numOfAdditions = 0;
                    numOfSubtractions = 0;
                    numOfMultiplications = 0;
                    numOfDivisions = 0;
                    numOfPowers = 0;
                }

                for (int i = 0; i < pieces.ToArray().Length; i++)
                {
                    string s = pieces[i];
                    if (s.StartsWith(constKeyword))
                    {
                        constantsIndexes.Add(i);
                    }
                    else
                    {
                        constantsIndexes.Add(pieces.ToArray().Length + 1);
                    }
                    if (s.StartsWith(parantesesKeyword))
                    {
                        parantesesIndexes.Add(i);
                    }
                    else
                    {
                        parantesesIndexes.Add(pieces.ToArray().Length + 1);
                    }
                    if (s.StartsWith(operatorKeyword))
                    {
                        s = s.Remove(0, operatorKeyword.Length);
                        if (s == additionKeyword)
                        {
                            if (updateNumOf)
                                numOfAdditions++;
                            additionIndexes.Add(i);
                        }

                        if (s == subtractionKeyword)
                        {
                            if (updateNumOf)
                                numOfSubtractions++;
                            subtractionIndexes.Add(i);
                        }

                        if (s == multiplicationKeyword)
                        {
                            if (updateNumOf)
                                numOfMultiplications++;
                            multiplicationIndexes.Add(i);
                        }

                        if (s == divisionKeyword)
                        {
                            if (updateNumOf)
                                numOfDivisions++;
                            divisionIndexes.Add(i);
                        }

                        if (s == powerKeyword)
                        {
                            if (updateNumOf)
                                numOfPowers++;
                            powerIndexes.Add(i);
                        }

                    }
                    if (s.StartsWith(varKeyword))
                    {
                        constantsIndexes[i] = i;
                    }
                }
            }
        }


        #region Global variables

        float offsetY = 0;
        float offsetX = 0;

        float stretchX = 66;
        float stretchY = 66;

        float stepSize = 0.01f;
        //78
        //200
        float stepsPos = 20;
        float stepsNeg = 20;

        float startStepsPos = 0;
        float startStepsNeg = 0;

        float stepOnFunction = 0.00f;
        int circleRadius = 2;
        bool has_grid = true;
        bool useRealTimePlot = false;
        bool shouldRenderConsole = false;
        Color gridColor = Color.FromArgb(27, 108, 128);
        Color backGridColor = Color.FromArgb(25, Color.Gray.R - 25, Color.Gray.G - 25, Color.Gray.B - 25);
        Color backColor = Color.FromArgb(0, 0, 0);
        Color axisColor = Color.FromArgb(255, 255, 255);
        Color graphColor = Color.FromArgb(225, 231, 108);

        float gridThickness = 1f;
        float axisThickness = 1f;
        float graphThickness = 1f;

        float gridStep = 1;

        float globalOffsetX = 0;
        float globalOffsetY = 0;

        float gridOffsetX = 0;
        float gridOffsetY = 0;

        float functionJumpThreshold = 1;

        public bool enableGraphSliding = true;

        //public Bitmap b;
        List<float> plotPoints1;
        List<float> plotPoints2;
        List<float> plotPoints3;

        List<float> negative_plotPoints2;
        List<float> negative_plotPoints3;
        List<float> negative_plotPoints1;











        

        public static PSD i;
        public static GraphicsHandler cg;
        Matrix4 projMatrix;

        



        

        float scrollSensitivity = 12;
        float stretchSensitivity = 12;

        float stretchAmmount = 10f;




        #endregion




        Vector2[] lines;
        int LinesVBO = 0;
        int negVboCount = 0;
        int posVboCount = 0;

        int countPos = 0;
        int countNeg = 0;

        int expectedArraySizePos = 0;
        int expectedArraySizeNeg = 0;

        float timeCounter = 0;
        float fpsMedian = 0;
        float fps = 0;
        float num = 0;
        Matrix4 modelViewMat;

        float sec_elapsed_time;

        bool enable_jump_detection = true;


        

        

        public bool sleep = false;

        public int framesPassed = 0;

        string functionToGraph = "x";
        string error_string = "";


        public float gridNumbersSpacingMultiplier = 1f;
        public Random rand;


        public struct GraphLine
        {
            public int buffer;
            public Color color;
            public int lineWidth;
            public int negVboCount;
            public int posVboCount;
            public bool isShown;
            public Func<float, float> f;

            public Vector2[] optional_lines_array;
            public bool draw_wirh_lines;
            public GraphLine(int buffer, Color color, int lineWidth, Func<float, float> f)
            {
                this.buffer = buffer;
                this.color = color;
                this.lineWidth = lineWidth;
                this.f = f;

                negVboCount = 0;
                posVboCount = 0;
                isShown = true;

                optional_lines_array = new Vector2[0];
                draw_wirh_lines = false;
            }

        }

        GraphLine[] graphs;
        IGraphicsContext renderingContext;
        IGraphicsContext loadingScreenContext;
        Thread initializationThread;

        public bool show_ui = true;

        public void AddGraph(GraphLine gh, ref GraphLine[] array)
        {


            GraphLine[] oldArray = array;
            array = new GraphLine[oldArray.Length + 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = oldArray[i];
            }
            array[array.Length-1] = gh;
        }


        Color[] gc = new Color[] {
        Color.FromArgb(255,255,255),
        Color.FromArgb(224,224,224),
        Color.FromArgb(192,192,192),
        Color.FromArgb(128,128,128),
        Color.FromArgb(96,96,96),
        Color.FromArgb(64,64,64),
        Color.FromArgb(221,46,46),
        Color.FromArgb(219,97,20),
        Color.FromArgb(254,215,0),
        Color.FromArgb(47,125,50),
        Color.FromArgb(0,153,255),
        Color.FromArgb(21,100,192),
        Color.FromArgb(255,192,203),
        Color.FromArgb(255,239,213),
        Color.FromArgb(253,250,205),
        Color.FromArgb(208,240,191),
        Color.FromArgb(174,238,238),
        Color.FromArgb(189,212,230),
        Color.FromArgb(204,204,254),
        Color.FromArgb(255,153,203),
        Color.FromArgb(255,204,51),
        Color.FromArgb(254,255,153),
        Color.FromArgb(205,255,204),
        Color.FromArgb(253,255,255),
        Color.FromArgb(153,205,255),
        Color.FromArgb(204,153,254),
        Color.FromArgb(255,51,102),
        Color.FromArgb(255,153,52),
        Color.FromArgb(255,255,0),
        Color.FromArgb(153,255,153),
        Color.FromArgb(0,255,255),
        Color.FromArgb(101,153,255),
        Color.FromArgb(153,102,255),
        Color.FromArgb(254,0,50),
        Color.FromArgb(255,102,0),
        Color.FromArgb(255,204,102),
        Color.FromArgb(1,204,0),
        Color.FromArgb(0,153,203),
        Color.FromArgb(125,125,255),
        Color.FromArgb(102,0,205),
        Color.FromArgb(128,0,0),
        Color.FromArgb(154,102,0),
        Color.FromArgb(153,52,0),
        Color.FromArgb(0,100,1),
        Color.FromArgb(0,51,204),
        Color.FromArgb(0,0,204),
        Color.FromArgb(75,0,129),
        Color.FromArgb(50,0,0),
        Color.FromArgb(51,51,0),
        Color.FromArgb(102,50,0),
        Color.FromArgb(1,51,0),
        Color.FromArgb(0,51,153),
        Color.FromArgb(0,0,50),
        Color.FromArgb(50,0,51),
        };
        
        Color getRandomGraphcolor ()
        {
            return gc[rand.Next(12, 41)];
        }

        char[] autoFunctionNames = "fghpqrstlopnmcvj".ToCharArray();

        public int noOfCharsFromFunctionsToDisplay = 15;
        public int noOfCharsFromFunctionsNameToDisplay = 4;
        public int noOfLinesToDisplay = 50;

        public bool ajustParams = true;

        string Instructions = "Hai sal! acest program este gay!";

        protected override void OnRender(FrameEventArgs e)
        {
            if (initializationThread.IsAlive == false)
            {
                if (Focused == true && sleep == false)
                {
                    sec_elapsed_time = (float)e.Time;
                    // elapsed_time = 0;
                    // var stopwatch = new Stopwatch();
                    // stopwatch.Start();




                    // stretchY = Clamp(stretchY, 4, float.PositiveInfinity);
                    // stretchX = Clamp(stretchX, 4, float.PositiveInfinity);


                    stepSize = Clamp(stepSize, 0, float.PositiveInfinity);

                    //storing mouse and keybord state



                    // Console.WriteLine("scw " + scrollWheelChange.ToString());
                    //
                    // Console.WriteLine("mcvX " + mouseMovment.X.ToString());
                    // Console.WriteLine("mcvY " + mouseMovment.Y.ToString());
                    //
                    // Console.WriteLine("actualMouseX " + msc.X.ToString());
                    // Console.WriteLine("actualMouseY " + msc.Y.ToString());
                    //
                    // Console.WriteLine("radio_checked " + grid_box.Checked);
                    //base.OnRenderFrame(e);



                    GL.Clear(ClearBufferMask.ColorBufferBit);
                    GL.ClearColor(backColor);


                    offsetX = globalOffsetX;
                    gridOffsetX = globalOffsetX;
                    offsetY = globalOffsetY;
                    gridOffsetY = globalOffsetY;

                    // !! always update the STEPS BEFORE THE GRAPH CALL !!
                    if (MouseButtonHeld(MouseButton.Left) && enableGraphSliding)
                    {
                        globalOffsetX -= mouseMovment.X;
                        globalOffsetY += mouseMovment.Y;
                    }

                    //Graph();


                    if (GetKeyHeld(Key.Right))
                        globalOffsetX -= 200 * sec_elapsed_time;
                    if (GetKeyHeld(Key.Left))
                        globalOffsetX += 200 * sec_elapsed_time;

                    if (GetKeyHeld(Key.Up))
                        globalOffsetY -= 200 * sec_elapsed_time;
                    if (GetKeyHeld(Key.Down))
                        globalOffsetY += 200 * sec_elapsed_time;

                    if (GetKeyHeld(Key.Up) && GetKeyHeld(Key.Down) && GetKeyHeld(Key.KeypadPlus))
                        stretchY += stretchAmmount * sec_elapsed_time * (stretchY / stretchSensitivity);
                    if (GetKeyHeld(Key.Up) && GetKeyHeld(Key.Down) && GetKeyHeld(Key.KeypadMinus))
                        stretchY -= stretchAmmount * sec_elapsed_time * (stretchY / stretchSensitivity);
                    if (GetKeyHeld(Key.Right) && GetKeyHeld(Key.Left) && GetKeyHeld(Key.KeypadPlus))
                        stretchX += stretchAmmount * sec_elapsed_time * (stretchX / stretchSensitivity);
                    if (GetKeyHeld(Key.Right) && GetKeyHeld(Key.Left) && GetKeyHeld(Key.KeypadMinus))
                        stretchX -= stretchAmmount * sec_elapsed_time * (stretchX / stretchSensitivity);


                    // Console.WriteLine(elapsed_time.ToString());






                    //grid drawing
                    if (has_grid == true)
                    {









                        GL.LineWidth(gridThickness);
                        GL.Begin(PrimitiveType.Lines);
                        //vertical grid line drawing
                        float offset = 0;



                        if (gridOffsetX < 0)
                            offset = -gridOffsetX;
                        else
                            offset = gridOffsetX;
                        for (float i = 0; i < ((Width / circleRadius)) + offset; i += gridStep)
                        {
                            //setting color
                            Color c = Color.White;
                            if (isInt(i)) c = gridColor;
                            if (isInt(i) == false) c = backGridColor;
                            //if (i == 0) c = axisColor;
                            //line drawing
                            drawLine2((int)((i * stretchX) + gridOffsetX), -(int)(((Height - 1) / 2)), (int)((i * stretchX) + gridOffsetX), (int)(((Height - 1) / 2)), c, false, false, false, true);
                            drawLine2((int)((i * stretchX) - gridOffsetX), -(int)(((Height - 1) / 2)), (int)((i * stretchX) - gridOffsetX), (int)(((Height - 1) / 2)), c, false, false, true, true);

                        }

                        //horizontal grid line drawing
                        if (gridOffsetY < 0)
                            offset = -gridOffsetY;
                        else
                            offset = gridOffsetY;
                        for (float i = 0; i < ((((Height)) / circleRadius)) + offset; i += gridStep)
                        {
                            //setting color
                            Color c = Color.White;
                            if (isInt(i)) c = gridColor;
                            if (isInt(i) == false) c = backGridColor;
                            //if (i == 0) c = axisColor;
                            //line drawing
                            drawLine2(-((Width - 1) / 2), (int)(i * stretchY - gridOffsetY), (int)((Width - 1) / 2), (int)(i * stretchY - gridOffsetY), c, false, false, false, true);
                            drawLine2(-((Width - 1) / 2), (int)(i * stretchY + gridOffsetY), (int)((Width - 1) / 2), (int)(i * stretchY + gridOffsetY), c, true, false, true, true);

                        }

                        //axis drawing
                        GL.End();
                        GL.LineWidth(axisThickness);
                        GL.Begin(PrimitiveType.Lines);
                        drawLine2(-((Width - 1) / 2), (int)(0 - gridOffsetY), (int)((Width - 1) / 2), (int)(0 - gridOffsetY), axisColor, false, false, false, true);
                        drawLine2((int)((0) + gridOffsetX), -(int)(((Height - 1) / 2)), (int)((0) + gridOffsetX), (int)(((Height - 1) / 2)), axisColor, false, false, false, true);
                        GL.End();









                        int textOffset = 0;

                        for (float i = gridOffsetX; i < (Width / 2 - (gridOffsetX)); i += stretchX * gridNumbersSpacingMultiplier)
                        {
                            //DrawString(iijjkk.ToString(), (int)(i + ((gridOffsetX+Width/2)-7)), 0, 12, Color.Transparent);
                            DrawString((textOffset * gridNumbersSpacingMultiplier).ToString(), (int)(((textOffset * stretchX * gridNumbersSpacingMultiplier) + gridOffsetX) + Width / 2), (int)(Height / 2 - gridOffsetY), 12, Color.Transparent);
                            if(textOffset != 0)
                            drawColoredQuad(((int)(((textOffset * stretchX * gridNumbersSpacingMultiplier) + gridOffsetX) + Width / 2)-2), (int)((Height / 2 - gridOffsetY) - 4), 3, 7, Color.White);
                            circleBres(((int)(((textOffset * stretchX * gridNumbersSpacingMultiplier) + gridOffsetX) + Width / 2)-1), (int)((Height / 2 - gridOffsetY)), 6, 1, Color.Blue);
                            textOffset++;
                        }


                        textOffset = 0;


                        for (float i = -gridOffsetX; i < (Width / 2 + (gridOffsetX)); i += stretchX * gridNumbersSpacingMultiplier)
                        {
                            //DrawString(iijjkk.ToString(), (int)(i + ((gridOffsetX+Width/2)-7)), 0, 12, Color.Transparent);
                            DrawString((-textOffset * gridNumbersSpacingMultiplier).ToString(), (int)(-((textOffset * stretchX * gridNumbersSpacingMultiplier) - gridOffsetX) + Width / 2), (int)(Height / 2 - gridOffsetY), 12, Color.Transparent);
                            if (textOffset != 0)
                                drawColoredQuad((int)((-((textOffset * stretchX * gridNumbersSpacingMultiplier) - gridOffsetX) + Width / 2)-3), (int)((Height / 2 - gridOffsetY) - 4), 3, 7, Color.White);
                            circleBres((int)((-((textOffset * stretchX * gridNumbersSpacingMultiplier) - gridOffsetX) + Width / 2)-2), (int)((Height / 2 - gridOffsetY)), 6, 1, Color.Blue);
                            textOffset++;
                        }


                        textOffset = 0;
                        for (float i = gridOffsetY; i < (Height / 2 - (gridOffsetY)); i += stretchY * gridNumbersSpacingMultiplier)
                        {
                            //DrawString(iijjkk.ToString(), (int)(i + ((gridOffsetX+Width/2)-7)), 0, 12, Color.Transparent);
                            DrawString((textOffset * gridNumbersSpacingMultiplier).ToString(), (int)(Width / 2 + gridOffsetX), (int)(((-(textOffset) * stretchY * gridNumbersSpacingMultiplier) - gridOffsetY) + Height / 2), 12, Color.Transparent);
                            if (textOffset != 0)
                                drawColoredQuad((int)((Width / 2 + gridOffsetX) - 4), (int)((((-(textOffset) * stretchY * gridNumbersSpacingMultiplier) - gridOffsetY) + Height / 2)-3), 7, 3, Color.White);
                            circleBres((int)((Width / 2 + gridOffsetX) - 1), (int)((((-(textOffset) * stretchY * gridNumbersSpacingMultiplier) - gridOffsetY) + Height / 2)-1), 6, 1, Color.Blue);
                            textOffset++;
                        }

                        textOffset = 0;
                        for (float i = -gridOffsetY; i < (Height / 2 + (gridOffsetY)); i += stretchY * gridNumbersSpacingMultiplier)
                        {
                            //DrawString(iijjkk.ToString(), (int)(i + ((gridOffsetX+Width/2)-7)), 0, 12, Color.Transparent);
                            DrawString((-textOffset * gridNumbersSpacingMultiplier).ToString(), (int)(Width / 2 + gridOffsetX), (int)((((textOffset) * stretchY * gridNumbersSpacingMultiplier) - gridOffsetY) + Height / 2), 12, Color.Transparent);
                            if (textOffset != 0)
                                drawColoredQuad((int)((Width / 2 + gridOffsetX) - 4), (int)(((((textOffset) * stretchY * gridNumbersSpacingMultiplier) - gridOffsetY) + Height / 2)-2), 7, 3, Color.White);
                               circleBres((int)((Width / 2 + gridOffsetX)-1), (int)(((((textOffset) * stretchY * gridNumbersSpacingMultiplier) - gridOffsetY) + Height / 2)), 6, 1, Color.Blue);
                            textOffset++;
                        }
                    }


                    //  int countPos = plotPoints2.ToArray().Length - 1;
                    //  int countNeg = negative_plotPoints2.ToArray().Length - 1;



                    //GL.LineWidth(graphThickness);
                    //GL.Begin(PrimitiveType.Lines);
                    //for (int i = 0; i < countPos; i += 1)
                    //{
                    //    DrawGraphPoints(i, false);
                    //}
                    //for (int i = 0; i < countNeg; i += 1)
                    //{
                    //    DrawGraphPoints(i, true);
                    //}
                    //GL.End();









                    //adding scroll change variable to the stretchX and Y, multiplied with the current stretch and divided by the sensitivity
                    //to keep scroll speed constant at all times

                    stretchX -= scrollWheelChange * (stretchX / scrollSensitivity);
                    stretchY -= scrollWheelChange * (stretchY / scrollSensitivity);

                    if (scrollWheelChange != 0)
                    {
                        //da good ol ?: operator, makes code unreadable, but is way too compact to not use
                        globalOffsetX -= (scrollWheelChange) * (globalOffsetX / scrollSensitivity);
                        globalOffsetY -= (scrollWheelChange) * (globalOffsetY / scrollSensitivity);
                        //  globalOffsetY -= (scrollWheelChange > 0) ? scrollWheelChange * (globalOffsetY / scrollSensitivity) : (-scrollWheelChange) * (globalOffsetY / scrollSensitivity);

                        //globalOffsetY += scrollWheelChange * stretchY;
                    }


                  //  if (GetKeyPressed(Key.B))
                  //  {
                  //      gridNumbersSpacingMultiplier += 1;
                  //      gridStep += 1;
                  //  }



                    

                    //  if (GetKeyState(Keys.Back).bPressed)
                    //  {
                    //      if (functionToGraph.Length > 0)
                    //      {
                    //          functionToGraph = functionToGraph.Remove(functionToGraph.Length - 1);
                    //          e1 = new Expression(functionToGraph, argx);
                    //          if (double.IsNaN(e1.calculate()))
                    //              shouldGraph = false;
                    //          else
                    //              shouldGraph = true;
                    //      }
                    //  }

                    //  if (currentKeyboardPressedChar != ' ')
                    //  {
                    //      functionToGraph += currentKeyboardPressedChar;
                    //      functionToGraph.Replace('X', 'x');
                    //      e1 = new Expression(functionToGraph, argx);
                    //      if (double.IsNaN(e1.calculate()))
                    //          shouldGraph = false;
                    //      else
                    //      {
                    //
                    //
                    //          shouldGraph = true;
                    //      }
                    //  }

                    // if (GetKeyPressed(Key.U))
                    //     shitswitch = !shitswitch;
                    // if (GetKeyPressed(Key.K))
                    //     GraphAndPopulateVBO(LinesVBO, f);
                    // DrawString((s.slider_value*4).ToString(), 12, Height - 160, 12, Color.Transparent);
                    //
                    //DrawString("Graphing Calculator", Width / 2-100, 12,4);
                    //stepsPos++;
                    // if(shouldGraph)








                    // stepSize = 1f /( (stretchX+stretchY)/2);
                    //startStepsPos = offsetX;
                    //stepsPos = (1/stretchX)*1100;
                    //     GraphAndPopulateVBO(LinesVBO,f);

                    //   GL.VertexPointer(2, VertexPointerType.Float, Vector2.SizeInBytes, 0);
                    //GraphicsContext.CurrentContext.ErrorChecking = true;
                    //if (GetKeyHeld(Key.L))
                    //{


                    //drawBetterButSlowString("dragg", Width / 2, Height / 2 ,42,Color.Transparent,Color.White);




                    if (GetKeyPressed(Key.T))
                    {
                        iii++;
                        if (iii == 22)
                            iii = 0;
                    }






                    if (ajustParams)
                    {

                        stepSize = 1 / ((stretchX + stretchY) / 2);

                        if (offsetX < 0 & (mouseMovment != Vector2.Zero) & MouseButtonHeld(MouseButton.Left))
                        {
                            startStepsPos = ((-globalOffsetX)) / (stretchX) - Width * (1 / stretchX);
                            stepsPos = ((-globalOffsetX)) / (stretchX) + Width * (1 / stretchX);


                            
                            //if ()
                                
                        }
                        else if (offsetX == 0)
                        {
                            stepsPos = 20;
                            stepsNeg = 20;
                        }
                        else if (offsetX > 0 & (mouseMovment != Vector2.Zero) & MouseButtonHeld(MouseButton.Left))
                        {
                            startStepsNeg = ((globalOffsetX)) / (stretchX) - Width * (1 / stretchX);
                            stepsNeg = ((globalOffsetX)) / (stretchX) + Width * (1 / stretchX);
                            

                        }

                        if ((-(globalOffsetX)) > Width+ ( stretchX))
                        {
                            stepsNeg = 0;
                            startStepsNeg = 0;
                        }

                        if (((globalOffsetX)) > Width + (stretchX))
                        {
                            stepsPos = 0;
                            startStepsPos = 0;
                        }

                        if ((mouseMovment != Vector2.Zero) & MouseButtonHeld(MouseButton.Left))
                            if(graphs[0].draw_wirh_lines == true)
                        GraphAndPopulateVBO(graphs[0].buffer, graphs[0].f, out graphs[0].negVboCount, out graphs[0].posVboCount, out graphs[0].optional_lines_array);
                        else
                                GraphAndPopulateVBO(graphs[0].buffer, graphs[0].f, out graphs[0].negVboCount, out graphs[0].posVboCount);
                    }





                    //old single graph code

                    //  GL.LineWidth(1);
                    //  GL.BindBuffer(BufferTarget.ArrayBuffer, LinesVBO);
                    //  GL.VertexPointer(2, VertexPointerType.Float, Vector2.SizeInBytes, 0);
                    //
                    //
                    //if (negVboCount != 0)
                    //{
                    //      modelViewMat = Matrix4.CreateScale(-stretchX, -stretchY, 1f) * Matrix4.CreateTranslation(Width * 0.5f + offsetX, Height * 0.5f - offsetY, 0f);
                    //      GL.MatrixMode(MatrixMode.Modelview);
                    //      GL.LoadMatrix(ref modelViewMat);
                    //    
                    //      GL.Color4((byte)graphColor.R, (byte)graphColor.G, (byte)graphColor.B, (byte)graphColor.A);
                    //      GL.DrawArrays(PrimitiveType.Lines, 0, negVboCount);
                    //    
                    //      modelViewMat = Matrix4.CreateScale(stretchX, -stretchY, 1f) * Matrix4.CreateTranslation(Width * 0.5f + offsetX, Height * 0.5f - offsetY, 0f);
                    //      GL.LoadMatrix(ref modelViewMat);
                    //    
                    //}
                    //if (posVboCount != 0)
                    //{
                    //      GL.Color4((byte)graphColor.R, (byte)graphColor.G, (byte)graphColor.B, (byte)graphColor.A);
                    //      GL.DrawArrays(PrimitiveType.Lines, negVboCount, posVboCount + negVboCount);
                    //    
                    //    
                    //      modelViewMat = Matrix4.CreateScale(1f, 1f, 1f) * Matrix4.CreateTranslation(0f, 0f, 0f) * Matrix4.CreateRotationY(0f);
                    //      GL.LoadMatrix(ref modelViewMat);
                    //}
                    


                    if(GetKeyPressed(Key.RControl))
                    {
                        for (int i = 0; i < graphs.Length; i++)
                        {
                            graphs[i].draw_wirh_lines = !graphs[i].draw_wirh_lines;
                        }
                    }




                        for (int i = 0; i < graphs.Length; i++)
                    {
                        if (graphs[i].isShown)
                        {
                            //graphs[i].draw_wirh_lines = true;

                            GL.LineWidth(graphs[i].lineWidth);
                            if (graphs[i].draw_wirh_lines == false)
                            {
                                GL.BindBuffer(BufferTarget.ArrayBuffer, graphs[i].buffer);
                                GL.VertexPointer(2, VertexPointerType.Float, Vector2.SizeInBytes, 0);
                            }


                            if (graphs[i].negVboCount != 0)
                            {

                                modelViewMat = Matrix4.CreateScale(-stretchX, -stretchY, 1f) * Matrix4.CreateTranslation(Width * 0.5f + offsetX, Height * 0.5f - offsetY, 0f);

                                    GL.MatrixMode(MatrixMode.Modelview);
                                    GL.LoadMatrix(ref modelViewMat);

                                if (graphs[i].draw_wirh_lines == false)
                                {
                                    GL.Color4((byte)graphs[i].color.R, (byte)graphs[i].color.G, (byte)graphs[i].color.B, (byte)200);
                                    GL.DrawArrays(PrimitiveType.Lines, 0, graphs[i].negVboCount);
                                } else
                                {
                                    GL.Color4((byte)graphs[i].color.R, (byte)graphs[i].color.G, (byte)graphs[i].color.B, (byte)200);
                                    if (graphs[i].optional_lines_array.Length -1 >= 0)
                                    {

                                        for (int j = 0; j < graphs[i].negVboCount-1; j++)
                                        {
                                                GL.Begin(PrimitiveType.Lines);

                                                GL.Vertex2(graphs[i].optional_lines_array[j]);
                                                GL.Vertex2(graphs[i].optional_lines_array[j + 1]);

                                                GL.End();
                                        }
                                    }
                                }
                            }



                            if (graphs[i].posVboCount != 0)
                            {
                                    modelViewMat = Matrix4.CreateScale(stretchX, -stretchY, 1f) * Matrix4.CreateTranslation(Width * 0.5f + offsetX, Height * 0.5f - offsetY, 0f);
                                    GL.LoadMatrix(ref modelViewMat);
                                if (graphs[i].draw_wirh_lines == false)
                                {

                                    GL.Color4((byte)graphs[i].color.R, (byte)graphs[i].color.G, (byte)graphs[i].color.B, (byte)200);
                                    GL.DrawArrays(PrimitiveType.Lines, graphs[i].negVboCount, (graphs[i].posVboCount + graphs[i].negVboCount));
                                }
                                else
                                {
                                    GL.Color4((byte)graphs[i].color.R, (byte)graphs[i].color.G, (byte)graphs[i].color.B, (byte)200);

                                    if (graphs[i].optional_lines_array.Length - 1 >= 0)
                                    {
                                        for (int j = graphs[i].negVboCount; j < (graphs[i].negVboCount + graphs[i].posVboCount) - 1; j++)
                                        {
                                                GL.Begin(PrimitiveType.Lines);
                                   
                                                GL.Vertex2(graphs[i].optional_lines_array[j]);
                                                GL.Vertex2(graphs[i].optional_lines_array[j + 1]);
                                   
                                                GL.End();
                                        }
                                    }
                                }
                            }
                        }
                    }






                    GL.LoadIdentity();
                    GL.LineWidth(1);
                    //}

                    

                    if (show_ui)
                    {

                        step_size_label.text = "Step Size " + stepSize.ToString();
                        pos_step_label.text = "Positive steps " + stepsPos.ToString();


                        DrawString("FPS: " + fps + ": " + Process.GetCurrentProcess().PagedMemorySize64, 12, Height - firstCharTexture.Height / textureFontSize - 32, 12, Color.Transparent);

                        DrawString("Stretch X: " + stretchX, 12, 40, 12, Color.Transparent);
                        DrawString("Stretch Y: " + stretchY, 12, 60, 12, Color.Transparent);

                        DrawString("Offset X: " + offsetX, 12, 100, 12, Color.Transparent);
                        DrawString("Offset Y: " + offsetY, 12, 120, 12, Color.Transparent);

                        DrawString("Jump threshold: " + functionJumpThreshold, 12, 160, 12, Color.Transparent);
                        DrawString("ver function parser ", Width - 200, 12, 12, Color.Blue);

                        //DrawString(e1.getExpressionString(), (int)(200), 12, 12, Color.Black);
                        DrawString(error_string, (int)(0), Height - 70, 12, Color.Transparent);

                        for (int i = defaultFuncsCount; i < ((funcs.Length > noOfLinesToDisplay) ? noOfLinesToDisplay : funcs.Length); i++)
                        {
                            DrawString((funcs[i].getFunctionName().Length > noOfCharsFromFunctionsNameToDisplay) ? funcs[i].getFunctionName().Remove(noOfCharsFromFunctionsNameToDisplay) : funcs[i].getFunctionName(), Width - 250, 300 + i * 20, 12, Color.Black);
                            DrawString((funcs[i].getFunctionExpressionString().Length > noOfCharsFromFunctionsToDisplay) ? funcs[i].getFunctionExpressionString().Remove(noOfCharsFromFunctionsToDisplay) + "..." : funcs[i].getFunctionExpressionString(), Width - 200, 300 + i * 20, 12, Color.Black);
                        }

                        if ((funcs.Length - defaultFuncsCount) - noOfLinesToDisplay > 0)
                        {
                            DrawString(".", Width - 250, 320 + noOfLinesToDisplay * 20, 12, Color.Black);
                            DrawString(".", Width - 250, 310 + noOfLinesToDisplay * 20, 12, Color.Black);
                            DrawString(".", Width - 250, 300 + noOfLinesToDisplay * 20, 12, Color.Black);

                            DrawString("and " + (funcs.Length - noOfLinesToDisplay).ToString() + " more", Width - 241, 300 + noOfLinesToDisplay * 20, 12, Color.Black);
                        }

                        UiElement[] SortedUis = uiElements.OrderBy(o => o.order).ToArray();

                        foreach (UiElement element in SortedUis)
                        {
                            if (element.drawInLoop)
                                element.Draw();
                        }

                        if (showBigFuncsMenu)
                        {
                            drawColoredQuadNonRelative(2, 2, Width - 4, Height - 4, Color.White);

                            drawColoredQuadNonRelative(4, 4, Width - 8, Height - 8, Color.Black);

                            collapse_funcs_menu_but.Draw();
                        }



                    }

                    if(GetKeyPressed(Key.F1))
                    {
                        show_ui = !show_ui;
                    }





                    //calculating average fps over one frame
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
                    }

                    //CONSOLE RENDERING CODE AERA
                    if (shouldRenderConsole)
                    {
                        cg.Fill(0, 0, cg.screenWidth, cg.screenHeight, (char)GraphicsHandler.PIXEL_TYPE.PIXEL_SOLID, (short)GraphicsHandler.COLOUR.FG_BLACK);

                        cg.Draw("Screen mouse coords: X:" + msc.X.ToString() + " Y: " + msc.Y.ToString(), 0, 0);
                        cg.Draw("Lines list size: " + (Vector2.SizeInBytes * lines.Length) + " bytes", 0, 1);
                        cg.Draw(factorial(5).ToString(), 0, 3);
                        cg.Draw("Lines list size: " + lines.Length, 0, 2);
                        cg.updateScreen();
                    }


                    //drawBetterButSlowString("text1969*^", 400, 400, 13, Color.Black, Color.Blue);

                    if (GetKeyHeld(Key.M))
                        if (GetKeyHeld(Key.C))
                            if (GetKeyHeld(Key.Enter))
                                dowhatever();
                    if (GetKeyPressed(Key.Enter) && GetKeyHeld(Key.ControlLeft) == false)
                        TakeScreenshot2();
                    if (GetKeyHeld(Key.ControlLeft))
                        if (GetKeyPressed(Key.Enter))
                        TakePrinterImage().Save("printer_image.png");
                //          if (GetKeyPressed(Key.A))
                //              SaveVectorsToFile(0);
                //    if(GetKeyPressed(Key.S))
                //              LoadVectorsFromFile(0);

                    //stopwatch.Stop();
                    //elapsed_time = stopwatch.ElapsedMilliseconds;
                    // Console.WriteLine(Math.Round((1.0 / e.Time)).ToString() + "         " + e.Time.ToString());
                    //Console.WriteLine((1000/elapsed_time).ToString() + "         " + elapsed_time.ToString());
                    //  if (int.MaxValue - framesPassed >= 2000)
                    //      framesPassed = 0;
                    //            framesPassed++;

                    ;



                    //TakePrinterImage();



                    this.SwapBuffers();



                        if (afterLoadingFinishedDoOnce == false)
                            {
                                afterLoadingFinishedDoOnce = true;
                                capture.Close();
                                cg = new GraphicsHandler();
                    
                                WindowBorder = WindowBorder.Resizable;
                        GL.MatrixMode(MatrixMode.Modelview);
                        GL.LoadIdentity();
                    }
                    //   if (afterLoadingFinishedDoOnce == false)
                    //   {
                    //       afterLoadingFinishedDoOnce = true;
                    //       GL.LoadIdentity();
                    //
                    //   }

                    this_position++;

                    if (this_position > 2)
                        this_position = 0;
                }
            }
            else
            {
                if (onLoadingStartedDoOnce == false)
                {
                    onLoadingStartedDoOnce = true;
                    ls_Bmp = new Bitmap(Width, Height);
                    ls_Graphics = Graphics.FromImage(ls_Bmp);
                    capture = new OutputCapture();
                    WindowBorder = WindowBorder.Fixed;
                
                    for (int i = 0; i < 360; i++)
                    {
                        ls_colors[i] = new Color4((byte)ls_Random.Next(0, 255), (byte)ls_Random.Next(0, 255), (byte)ls_Random.Next(0, 255), (byte)255);
                
                
                    }
                
                }

                //newCapture = capture.Captured.ToString();

                //GL.Clear(ClearBufferMask.ColorBufferBit);
                //GL.ClearColor(Color.Black);

                //ls_Graphics.Clear(Color.Black);

                //if (newCapture != null && oldCapture != null && newCapture != oldCapture)
                //{
                //    captureChange = subtractString(newCapture, oldCapture);
                //}
                //ls_Graphics.DrawString(captureChange, new Font(FontFamily.GenericSansSerif, 15), Brushes.White, 20, Height - 200);
                //ls_Graphics.DrawString("Loading", new Font(FontFamily.GenericSansSerif, 30), Brushes.White, 320, 100);


                //ls_timer_millis += e.Time;
                //if (ls_timer_millis > 1d)
                //{
                //    ls_timer_millis = 0;
                //    ls_timer_seconds += 1;
                //}
                //if (ls_timer_seconds > 60)
                //{
                //    ls_timer_seconds = 0;
                //    ls_timer_minutes += 1;
                //}

                //ls_Graphics.DrawString("Time elapsed " + ls_timer_minutes + ":" + ls_timer_seconds, new Font(FontFamily.GenericSansSerif, 20), Brushes.White, Width - 290, Height - 100);

                //GL.Enable(EnableCap.Texture2D);

                //int bmp_tex = LoadTexture(ls_Bmp);
                //drawQuadWithTexture(0, 0, Width, Height, bmp_tex);
                //GL.DeleteTexture(bmp_tex);
                //GL.Disable(EnableCap.Texture2D);

                // GL.DeleteTexture(bmp_tex);

                //GL.MatrixMode(MatrixMode.Modelview);
                //Matrix4 mat = Matrix4.CreateRotationZ(theta) * Matrix4.CreateTranslation(Width / 2, Height / 2, 0);
                //GL.LoadMatrix(ref mat);
                //circleBres(0, 0, 100, 2, Color.White);
                ////circleBres(0,20, 100, 2, Color.White);
                //drawColoredQuad(0, 0, 100, 100, Color.Black);
                //// drawColoredQuad(0, 0, -400, -400, Color.Black);



                //int a10, a11, a12;

                //GL.Begin(PrimitiveType.TriangleFan);
                ////GL.Color4((byte)255, (byte)255, (byte)255, (byte)255);


                //a10 = 255;
                //a11 = 190;
                //a12 = 4;

                //GL.Vertex2(0, 0);
                //for (int i = 0; i < 360; i++)
                //{
                //    GL.Color4(ls_colors[i]);

                //    GL.Vertex2(0 + Math.Cos(i) * 95, 0 + Math.Sin(i) * 95);

                //}

                //GL.End();

                ////  DrawCircleGL(0, 0, 100, Color4.AliceBlue);


                ////5
                //theta += 5 * (float)e.Time;

                //GL.LoadIdentity();



                ls_timer_millis += e.Time;

                if (ls_timer_millis >0.5f)
                {
                    text_x = ls_Random.Next(-200, 200);
                    text_y = ls_Random.Next(-200, 200);
                }

                if (ls_timer_millis > 1d)
                {
                    ls_timer_millis = 0;
                    ls_timer_seconds += 1;

                    
                }
                if (ls_timer_seconds > 60)
                {
                    ls_timer_seconds = 0;
                    ls_timer_minutes += 1;
                }

                

                newCapture = capture.Captured.ToString();

                GL.Clear(ClearBufferMask.ColorBufferBit);
                GL.ClearColor(Color.Black);

                ls_Graphics.Clear(Color.Black);

                ls_Graphics.DrawString("loading", new Font(FontFamily.GenericSansSerif, 25), Brushes.White, new PointF(0, 0));

                

                GL.MatrixMode(MatrixMode.Modelview);
                Matrix4 mat = Matrix4.CreateRotationZ(theta) * Matrix4.CreateTranslation(Width / 2 + text_x, Height / 2 + text_y,0);
                GL.LoadMatrix(ref mat);

                GL.Enable(EnableCap.Texture2D);

                int bmp_tex = LoadTexture(ls_Bmp);
                drawQuadWithTexture(0, 0, Width, Height, bmp_tex);
                GL.DeleteTexture(bmp_tex);
                GL.Disable(EnableCap.Texture2D);

                GL.DeleteTexture(bmp_tex);

                

                //  DrawCircleGL(0, 0, 100, Color4.AliceBlue);


                //5
                theta += 5 * (float)e.Time;

                GL.LoadIdentity();





                this.SwapBuffers();





                oldCapture = newCapture;
            }


        }
        //ls stands for loading scrern
        Random ls_Random;
        Graphics ls_Graphics;
        Bitmap ls_Bmp;
        OutputCapture capture;
        string captureChange;
        string oldCapture;
        string newCapture;
        int ls_timer_seconds = 0;
        int ls_timer_minutes = 0;
        Color4[] ls_colors = new Color4[360];
        double ls_timer_millis = 0; 
        public double ls_theta;

        public int this_position = 0;

        public float text_x;
        public float text_y;

        bool shouldGraph = false;
        float W = 0; int iii = 0; float theta = 0;
        bool afterLoadingFinishedDoOnce; bool onLoadingStartedDoOnce;


        public Bitmap TakePrinterImage ( )
        {
            Bitmap bmp = new Bitmap(Width, Height);
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.Clear(Color.White);
            int graphIndex = 0;
            int lineWidth = 3;


            float minY = float.PositiveInfinity;
            float maxY = float.NegativeInfinity;
            float minX = float.PositiveInfinity;
            float maxX = float.NegativeInfinity;

            float minN = float.PositiveInfinity;
            float maxN = float.NegativeInfinity;


            for (int i = 0; i < graphs[graphIndex].optional_lines_array.Length; i++)
            {
                if (graphs[graphIndex].optional_lines_array[i].Y > maxY)
                    maxY = graphs[graphIndex].optional_lines_array[i].Y;
                if (graphs[graphIndex].optional_lines_array[i].Y < minY)
                    minY = graphs[graphIndex].optional_lines_array[i].Y;

                if (graphs[graphIndex].optional_lines_array[i].X > maxX)
                    maxX = graphs[graphIndex].optional_lines_array[i].X;
                if (graphs[graphIndex].optional_lines_array[i].X < minX)
                    minX = graphs[graphIndex].optional_lines_array[i].X;

                if (graphs[graphIndex].optional_lines_array[i].Length > maxN)
                    maxN = graphs[graphIndex].optional_lines_array[i].Length;
                if (graphs[graphIndex].optional_lines_array[i].Length < minN)
                    minN = graphs[graphIndex].optional_lines_array[i].Length;
            }


            if (graphs[graphIndex].negVboCount != 0)
            {

                

                    if (graphs[graphIndex].optional_lines_array.Length - 1 >= 0)
                    {

                        for (int j = 0; j < graphs[graphIndex].negVboCount - 1; j++)
                        {
                        
                        int r = (int)makeInRange(graphs[graphIndex].optional_lines_array[j].Y, minY, maxY, 0, 255);
                        int g = (int)makeInRange(graphs[graphIndex].optional_lines_array[j].X, minX, maxX, 0, 255);
                        //int b = (int)makeInRange(graphs[graphIndex].optional_lines_array[j].Length, minN, maxN, 0, 255);
                        int b = 0;
                        gfx.DrawLine(new Pen(Color.FromArgb(255,r ,g,b),lineWidth), (int)((graphs[graphIndex].optional_lines_array[j].X * -stretchX) + bmp.Width * 0.5f + offsetX), (int)((graphs[graphIndex].optional_lines_array[j].Y * -stretchY) + bmp.Height * 0.5f + offsetY), (int)((graphs[graphIndex].optional_lines_array[j + 1].X * -stretchX) + bmp.Width * 0.5f + offsetX), (int)((graphs[graphIndex].optional_lines_array[j + 1].Y * -stretchY) + bmp.Height * 0.5f + offsetY));
                        }
                    }
            }



            if (graphs[graphIndex].posVboCount != 0)
            {

                    if (graphs[graphIndex].optional_lines_array.Length - 1 >= 0)
                    {
                        for (int j = graphs[graphIndex].negVboCount; j < (graphs[graphIndex].negVboCount + graphs[graphIndex].posVboCount) - 1; j++)
                        {
                        int r = (int)makeInRange(graphs[graphIndex].optional_lines_array[j].Y, minY, maxY, 0, 255);
                        int g = (int)makeInRange(graphs[graphIndex].optional_lines_array[j].X, minX, maxX, 0, 255);
                        //int b = (int)makeInRange(graphs[graphIndex].optional_lines_array[j].Length, minN, maxN, 0, 255);
                        int b = 0;
                        gfx.DrawLine(new Pen(Color.FromArgb(255,r,g,b),lineWidth), (int)((graphs[graphIndex].optional_lines_array[j].X * stretchX) + bmp.Width * 0.5f + offsetX), (int)((graphs[graphIndex].optional_lines_array[j].Y * -stretchY) + bmp.Height * 0.5f + offsetY), (int)((graphs[graphIndex].optional_lines_array[j + 1].X * stretchX) + bmp.Width * 0.5f + offsetX), (int)((graphs[graphIndex].optional_lines_array[j + 1].Y * -stretchY) + bmp.Height * 0.5f + offsetY));
                        }
                    }
                    
            }

            return bmp;
        }





        public void drawλεζβιColoredQuad(int x, int y, int x2, int y2, Color c)
        {
            GL.Begin(PrimitiveType.Triangles);
            GL.Color4((byte)c.R, (byte)c.G, (byte)c.B, (byte)c.A);

            GL.Vertex2(x, y);
            GL.Vertex2(x2, y2);
            GL.Vertex2(x, y2);

            GL.Vertex2(x, y);
            GL.Vertex2(x2, y);
            GL.Vertex2(x2, y2);
            GL.End();
        }

        public string subtractString(string source, string remove)
        {



            int index = source.IndexOf(remove);
            return (index < 0)
                ? source
                : source.Remove(index, remove.Length);
        }

        public int millisOfDelayToMeet = 200;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool Beep(uint dwFreq, uint dwDuration);

        int qb, qp, qn;


        public void genwave()
        {
            FileStream stream = new FileStream("test.wav", FileMode.Create);
            BinaryWriter writer = new BinaryWriter(stream);
            int RIFF = 0x46464952;
            int WAVE = 0x45564157;
            int formatChunkSize = 16;
            int headerSize = 8;
            int format = 0x20746D66;
            short formatType = 1;
            short tracks = 1;
            int samplesPerSecond = 44100;
            short bitsPerSample = 16;
            short frameSize = (short)(tracks * ((bitsPerSample + 7) / 8));
            int bytesPerSecond = samplesPerSecond * frameSize;
            int waveSize = 4;
            int data = 0x61746164;
            int samples = 88200 * 4;
            int dataChunkSize = samples * frameSize;
            int fileSize = waveSize + headerSize + formatChunkSize + headerSize + dataChunkSize;
            writer.Write(RIFF);
            writer.Write(fileSize);
            writer.Write(WAVE);
            writer.Write(format);
            writer.Write(formatChunkSize);
            writer.Write(formatType);
            writer.Write(tracks);
            writer.Write(samplesPerSecond);
            writer.Write(bytesPerSecond);
            writer.Write(frameSize);
            writer.Write(bitsPerSample);
            writer.Write(data);
            writer.Write(dataChunkSize);
            double aNatural = 590d;
            double ampl = 10000;
            double perfect = 1;
            double freq = aNatural * perfect;

            //use for sine

            //for (int i = 0; i < samples; i++)
            //{
            //    double t = (double)i / (double)samplesPerSecond;
            //    short s = (short)(ampl * (Math.Sin(t * freq * 2.0 * Math.PI)));
            //    writer.Write(s);
            //}

            //use for everything else
            for (int i = 0; i < samples; i++)
            {
                double t = (double)i / (double)samplesPerSecond;
                short s = (short)(ampl * (tan((float)(t * freq))));
                writer.Write(s);
            }
            writer.Close();
        }

        public void cfam()
        {

            bool z1 = false;
            bool z2 = false;
            bool z3 = false;
            bool z4 = false;
            bool z5 = false;
            bool z6 = false;
            bool z7 = false;
            bool z8 = false;
            bool z9 = false;
            bool z10 = false;
            bool z11 = false;
            bool z12 = false;
            bool z13 = false;
            bool z14 = false;
            while (true)
            {
                if (GetAsyncKeyStateShort(Keys.A) == -32768)
                {
                    z1 = true;
                }
                if (GetAsyncKeyStateShort(Keys.S) == -32768 && z1 == true)
                {
                    z2 = true;
                }
                if (GetAsyncKeyStateShort(Keys.S) == -32768 && z2 == true)
                {
                    z3 = true;
                }
                if (GetAsyncKeyStateShort(Keys.H) == -32768 && z3 == true)
                {
                    z4 = true;
                }
                if (GetAsyncKeyStateShort(Keys.O) == -32768 && z4 == true)
                {
                    z5 = true;
                }
                if (GetAsyncKeyStateShort(Keys.L) == -32768 && z5 == true)
                {
                    z6 = true;
                }
                if (GetAsyncKeyStateShort(Keys.E) == -32768 && z6 == true)
                {
                    z7 = true;
                    b = true;
                }
            }
        }

        bool b = false;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(this.ClientRectangle);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, ClientRectangle.Width, ClientRectangle.Height, 0, -1, 0);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ls_Random = new Random();
            //PlayWav(new FileStream("sick boy.wav",FileMode.Open), false);

              loadingScreenContext = new GraphicsContext(GraphicsMode.Default, WindowInfo);
              loadingScreenContext.MakeCurrent(WindowInfo);
            //
              initializationThread = new Thread(new ThreadStart(initialize));
             initializationThread.Start();
           // initialize();

            Console.WriteLine("Setting up projection matrix");
            projMatrix = Matrix4.CreateOrthographicOffCenter(0, Width, Height, 0, 0, 1);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projMatrix);
            GL.EnableClientState(ArrayCap.VertexArray);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
             //genwave();
             //PlayWav(new FileStream("test.wav",FileMode.Open), false);



                if (Process.GetProcessesByName("ProgramRestarter").Length == 0)
                {
                    Console.WriteLine("Starting restarter program..");
                    Process restarterProcess = new Process();
                    restarterProcess.StartInfo.FileName = "ProgramRestarter.exe";
                    restarterProcess.Start();
                    
                    restarterProcess.Dispose();
                }

          

            //int a = 1 / (int)Math.Sqrt(1 - 1);


            i = this;

            inst = this;





            //functionJumpTreshhold = 0.1f;
            Program.f.Close();


        }

        public void initialize ()
        {
            renderingContext = new GraphicsContext(GraphicsMode.Default, WindowInfo);
            renderingContext.MakeCurrent(WindowInfo);

            Thread t = new Thread(new ThreadStart(cfam));
            t.Start();
            rand = new Random();

            InitializeChars();

            GL.EnableClientState(ArrayCap.VertexArray);

            Console.WriteLine("Initializing UI");

            
            InitializeUi();

            grid_box.Checked = has_grid;
            console_box.Checked = shouldRenderConsole;

            Console.WriteLine();

















            argx = new Argument("x");

            // e1 = new Expression("x",argx);

            //e1 = new Expression("", argx);

            string exStr = "x^2";

            e1 = new Expression(exStr, argx);


            //    AddGraph(new GraphLine(0, Color.Black, 1, sigmoid), ref graphs);
            //      AddGraph(new GraphLine(0, Color.Black, 1, h), ref graphs);
            //    AddGraph(new GraphLine(0, Color.Black, 1, l), ref graphs);
            //    AddGraph(new GraphLine(0, Color.Black, 1, l), ref graphs);
            //    AddGraph(new GraphLine(0, Color.Black, 1, l), ref graphs);
            //    AddGraph(new GraphLine(0, Color.Black, 1, l), ref graphs);
            //    AddGraph(new GraphLine(0, Color.Black, 1, l), ref graphs);


            caps_toggle = false;












            Console.WriteLine("Initial graph operation started");
            Console.WriteLine("Calculating array sizes");

            expectedArraySizeNeg = (int)(countNeg / stepSize);
            expectedArraySizePos = (int)(countPos / stepSize);

            Console.WriteLine("Calculating arrays");
            shitswitch = true;
            //  Graph();


            //   countPos = plotPoints2.ToArray().Length - 1;
            //   countNeg = negative_plotPoints2.ToArray().Length - 1;



            Console.WriteLine("Calculating jump treshold");

            //       float largest = float.NegativeInfinity;
            //       float smallest = float.PositiveInfinity;
            //       for (int i = 0; i < countPos - 1; i++)
            //       {
            //           if (plotPoints2[i] > largest && float.IsInfinity(plotPoints2[i]) == false)
            //               largest = plotPoints2[i];
            //           if (plotPoints2[i] < smallest && float.IsInfinity(plotPoints2[i]) == false)
            //               smallest = plotPoints2[i];
            //       }
            //       for (int i = 0; i < countNeg - 1; i++)
            //       {
            //           if (negative_plotPoints2[i] > largest && float.IsInfinity(negative_plotPoints2[i]) == false)
            //               largest = negative_plotPoints2[i];
            //           if (negative_plotPoints2[i] < smallest && float.IsInfinity(negative_plotPoints2[i]) == false)
            //               smallest = negative_plotPoints2[i];
            //       }
            //       functionJumpThreshold = (largest - smallest) / stretchY;
            // functionJumpThreshold = float.PositiveInfinity;
            Console.WriteLine("Populating VBO");



            //   qb = GL.GenBuffer();
            //    lines = new Vector2[1];
            //    GraphAndPopulateVBO(qb, l, out qn, out qp);
            //   GL.VertexPointer(2, VertexPointerType.Float, Vector2.SizeInBytes, 0);
            int thiccnezz = 2;

            graphs = new GraphLine[] {new GraphLine(0, getRandomGraphcolor(), thiccnezz, f)};
            for (int i = 0; i < graphs.Length; i++)
            {
                graphs[i].isShown = true;
            }

            //old single graph code
            LinesVBO = GL.GenBuffer();
            // lines = new Vector2[1];
            //PopulateVBO();





            //GraphAndPopulateVBO(LinesVBO, f);





            for (int i = 0; i < graphs.Length; i++)
            {
                graphs[i].buffer = GL.GenBuffer();
                GL.BindBuffer(BufferTarget.ArrayBuffer, graphs[i].buffer);
                GraphAndPopulateVBO(graphs[i].buffer, graphs[i].f, out graphs[i].negVboCount, out graphs[i].posVboCount);
            }

            GraphAndPopulateVBO(graphs[0].buffer, l, out graphs[0].negVboCount, out graphs[0].posVboCount);


            //GL.BufferData<Vector2>(BufferTarget.ArrayBuffer, Vector2.SizeInBytes * lines.Length, lines, BufferUsageHint.StaticDraw);

            //          for (int i = 0; i < 1; i++)
            //          {
            //             graphs[i].buffer = GL.GenBuffer();
            //              lines = new Vector2[0];
            //              GL.BindBuffer(BufferTarget.ArrayBuffer, graphs[i].buffer);
            //              GraphAndPopulateVBO(graphs[i].buffer, graphs[i].f, out graphs[i].negVboCount, out graphs[i].posVboCount);
            //         //     GL.BindBuffer(BufferTarget.ArrayBuffer, graphs[i].buffer);
            //              GL.VertexPointer(2, VertexPointerType.Float, Vector2.SizeInBytes, 0);
            //          }
            //          int ii = 0;
            //          graphs[ii].buffer = GL.GenBuffer();
            //          lines = new Vector2[0];
            //          GL.BindBuffer(BufferTarget.ArrayBuffer, graphs[ii].buffer);
            //          GraphAndPopulateVBO(graphs[ii].buffer, graphs[ii].f, out graphs[ii].negVboCount, out graphs[iii].posVboCount);
            //          //     GL.BindBuffer(BufferTarget.ArrayBuffer, graphs[i].buffer);
            //          GL.VertexPointer(2, VertexPointerType.Float, Vector2.SizeInBytes, 0);
            //
            //
            //
            //
            //          ii = 1;
            //          graphs[ii].buffer = GL.GenBuffer();
            //          lines = new Vector2[0];
            //          GL.BindBuffer(BufferTarget.ArrayBuffer, graphs[ii].buffer);
            //          GraphAndPopulateVBO(graphs[ii].buffer, graphs[ii].f, out graphs[ii].negVboCount, out graphs[ii].posVboCount);
            //          //     GL.BindBuffer(BufferTarget.ArrayBuffer, graphs[i].buffer);
            //          GL.VertexPointer(2, VertexPointerType.Float, Vector2.SizeInBytes, 0);







            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
            
            //GL.Enable(EnableCap.AlphaTest);
            //GL.AlphaFunc(AlphaFunction.Gequal, 0.9f);

            // GL.Enable(EnableCap.DepthTest);
            // GL.DepthFunc(DepthFunction.Lequal);
            Console.WriteLine();
            Console.WriteLine("Reseting sync files");

       //     if (File.Exists("1.bmp"))
       //         File.Delete("1.bmp");
       //     if (File.Exists("written.txt"))
       //         File.Move("written.txt", "read.txt");
       //
       //     if (File.Exists("written.txt") == false && File.Exists("read.txt") == false)
       //         File.CreateText("read.txt");
            //bd = b.LockBits(new Rectangle(0,0,b.Width,b.Height),System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);


            

            t.Abort();
            Console.WriteLine(b);
            Thread.Sleep(2000);

            Console.WriteLine("Setup operations completed. Switching to custom console redrerer now!");

            Thread.Sleep(2);
            Console.Clear();
            Console.SetCursorPosition(0, 0);

            
            GraphicsContext.CurrentContext.MakeCurrent(null);
        }


        // The player making the current sound.
        private SoundPlayer Player = null;

        // Dispose of the current player and
        // play the indicated WAV file.
        private void PlayWav(Stream stream, bool play_looping)
        {
            // Stop the player if it is running.
            if (Player != null)
            {
                Player.Stop();
                Player.Dispose();
                Player = null;
            }

            // If we have no stream, we're done.
            if (stream == null) return;

            // Make the new player for the WAV stream.
            Player = new SoundPlayer(stream);

            // Play.
            if (play_looping)
                Player.PlayLooping();
            else
                Player.Play();
        }

        Expression e1;
        Argument argx;

        

        

        
        void DrawGraphPoints(int i, bool neg)
        {
            //if (useNewAlg)
            //{
            //drawing lines between the points to make the graph
            if (neg == false)
            {
                if (plotPoints2[i + 1] - plotPoints2[i] <= functionJumpThreshold && plotPoints2[i + 1] - plotPoints2[i] >= -functionJumpThreshold && float.IsInfinity(plotPoints2[i]) == false && float.IsInfinity(plotPoints2[i + 1]) == false && float.IsNaN(plotPoints2[i]) == false && float.IsNaN(plotPoints2[i + 1]) == false)
                {
                    float offset = 0;
                    if (plotPoints2[i] > 0)
                        offset = offsetY;
                    else
                        offset = -offsetY;
                    if (plotPoints2[i] + offset < Height && plotPoints2[i] - offset > -Height)
                        drawLine2((int)(((plotPoints1[i] * stretchX) + Width / 2) + offsetX), (int)((plotPoints2[i] * stretchY) + offsetY + Height / 2), (int)(((plotPoints1[i + 1] * stretchX) + Width / 2) + offsetX), (int)((plotPoints3[i + 1] * stretchY) + offsetY + Height / 2), graphColor, true, false, false, false, false);
                    //if (plotPoints2[i] - offset < Height && plotPoints2[i] + offset > -Height)
                    //    drawLine2((int)(((plotPoints1[i] * stretchX) + Width / 2) + offsetX), (int)((plotPoints2[i] * stretchY) + offsetY + Height / 2), (int)(((plotPoints1[i + 1] * stretchX) + Width / 2) + offsetX), (int)((plotPoints3[i + 1] * stretchY) + offsetY + Height / 2), graphThickness, graphColor, true, false, false, false, false);
                }
            }
            else
            {
                if (negative_plotPoints2[i + 1] - negative_plotPoints2[i] <= functionJumpThreshold && negative_plotPoints2[i + 1] - negative_plotPoints2[i] >= -functionJumpThreshold && float.IsInfinity(negative_plotPoints2[i]) == false && float.IsInfinity(negative_plotPoints2[i + 1]) == false && float.IsNaN(negative_plotPoints2[i]) == false && float.IsNaN(negative_plotPoints2[i + 1]) == false)
                {
                    float offset = 0;
                    if (negative_plotPoints2[i] > 0)
                        offset = -offsetY;
                    else
                        offset = offsetY;
                    if (negative_plotPoints2[i] - offset < Height && negative_plotPoints2[i] + offset > -Height)
                        drawLine2((int)(((negative_plotPoints1[i] * stretchX) + Width / 2) - offsetX), (int)((negative_plotPoints2[i] * stretchY) + offsetY + Height / 2), (int)(((negative_plotPoints1[i + 1] * stretchX) + Width / 2) - offsetX), (int)((negative_plotPoints3[i + 1] * stretchY) + offsetY + Height / 2), graphColor, true, false, true, false, false);
                }
            }
        }

        
        #region Ui stuff
        CheckBox grid_box;
        CheckBox console_box;
        CheckBox jump_enable_box;
        float old_function_jump_ts;
        Button update_graph_but;
        Button step_size_plus_but;
        Button step_size_minus_but;
        Button coord_reset_but;
        Label step_size_label;
        Label pos_step_label;
        Slider pos_steps_slider;

        Button keypad_0;
        Button keypad_1;
        Button keypad_2;
        Button keypad_3;
        Button keypad_4;
        Button keypad_5;
        Button keypad_6;
        Button keypad_7;
        Button keypad_8;
        Button keypad_9;

        Button keypad_plus;
        Button keypad_minus;
        Button keypad_multiply;
        Button keypad_divide;
        Button keypad_exponent;

        Button keypad_sin;
        Button keypad_cos;
        Button keypad_tan;

        Button keypad_paranteses_open;
        Button keypad_paranteses_closed;

        Button keypad_var_x;

        TextBox equasion_box;

        TextBox function_equasion_box;
        TextBox function_name_box;
        Button function_add_but;
        Button function_remove_but;

        Button show_all_funcs_but;
        Button collapse_funcs_menu_but;

        CheckBox ajust_params_box;

        public void InitializeUi()
        {
            uiElements = new List<UiElement>();

            grid_box = new CheckBox();
            grid_box.x = 12;
            grid_box.y = 12;
            grid_box.text = "Enable grid";
            grid_box.OnCheckChanged += grid_box_on_click;

            update_graph_but = new Button();
            update_graph_but.x = 12;
            update_graph_but.y = 190;
            update_graph_but.width = 125;
            update_graph_but.height = 20;
            update_graph_but.text = "Update graph";
            update_graph_but.OnClick += update_graph_but_click;

            pos_steps_slider = new Slider();
            pos_steps_slider.x = 12;
            pos_steps_slider.y = 310;
            pos_steps_slider.width = 100;
            pos_steps_slider.height = 12;
            pos_steps_slider.lower_bound = 1;
            pos_steps_slider.OnSliderValueChanged += pos_steps_slider_slide;

            pos_step_label = new Label();
            pos_step_label.y = 330;
            pos_step_label.x = 12;
            pos_step_label.fontSize = 10;

            console_box = new CheckBox();
            console_box.x = 12;
            console_box.y = 240;
            console_box.text = "Enable console rendering";
            console_box.OnCheckChanged += console_box_on_click;

            old_function_jump_ts = functionJumpThreshold;
            functionJumpThreshold = float.PositiveInfinity;

            jump_enable_box = new CheckBox();
            jump_enable_box.x = 12;
            jump_enable_box.y = 240 - jump_enable_box.height;
            jump_enable_box.text = "Disable jump_detection";
            jump_enable_box.OnCheckChanged += jump_enable_box_on_click;

            step_size_plus_but = new Button();
            step_size_plus_but.x = 12;
            step_size_plus_but.y = Height - 190;
            step_size_plus_but.width = 20;
            step_size_plus_but.height = 20;
            step_size_plus_but.text = "+";
            step_size_plus_but.OnClick += step_size_plus_but_click;

            step_size_minus_but = new Button();
            step_size_minus_but.x = 48;
            step_size_minus_but.y = Height - 190;
            step_size_minus_but.width = 20;
            step_size_minus_but.height = 20;
            step_size_minus_but.text = "-";
            step_size_minus_but.OnClick += step_size_minus_but_click;

            step_size_label = new Label();
            step_size_label.y = Height - 160;
            step_size_label.x = 12;
            step_size_label.fontSize = 10;

            coord_reset_but = new Button();
            coord_reset_but.x = 12;
            coord_reset_but.y = 270;
            coord_reset_but.width = 120;
            coord_reset_but.height = 20;
            coord_reset_but.text = "Reset coords";
            coord_reset_but.OnClick += coord_reset_but_click;

            equasion_box = new TextBox();
            equasion_box.width = 500;
            equasion_box.x = 12;
            equasion_box.y = Height - 100;
            equasion_box.OnTextEntered += equasion_box_on_entered;
            equasion_box.OnTextChanged += equasion_box_on_changed;

            function_equasion_box = new TextBox();
            function_equasion_box.width = 188;
            function_equasion_box.charsToDisplay = 18;
            function_equasion_box.x = Width - 200;
            function_equasion_box.y = 200;
            function_equasion_box.OnTextChanged += function_equasion_box_on_changed;

           function_name_box  = new TextBox();
           function_name_box .width = 40;
            function_name_box.charsToDisplay = 3;
           function_name_box .x = Width - 250;
           function_name_box .y = 200;

            function_add_but = new Button();
            function_add_but.x = Width - 100;
            function_add_but.y = 230;
            function_add_but.width = 20;
            function_add_but.height = 20;
            function_add_but.text = "+";
            function_add_but.OnClick += function_add_but_click;

           // function_remove_but = new Button();
           // function_remove_but.x = Width - 200;
           // function_remove_but.y = 230;
           // function_remove_but.width = 75;
           // function_remove_but.height = 20;
           // function_remove_but.text = "Remove";
           // function_remove_but.OnClick += function_remove_but_click;

            function_remove_but = new Button();
            function_remove_but.x = Width - 200;
            function_remove_but.y = 230;
            function_remove_but.width = 20;
            function_remove_but.height = 20;
            function_remove_but.text = "-";
            function_remove_but.OnClick += function_remove_but_click;

            show_all_funcs_but = new Button();
            show_all_funcs_but.x = Width - 285;
            show_all_funcs_but.y = 200;
            show_all_funcs_but.width = 30;
            show_all_funcs_but.height = 20;
            show_all_funcs_but.text = "...";
            show_all_funcs_but.OnClick += show_all_funcs_but_click;

            collapse_funcs_menu_but = new Button();
            collapse_funcs_menu_but.x = Width - 25;
            collapse_funcs_menu_but.y = 20;
            collapse_funcs_menu_but.width = 20;
            collapse_funcs_menu_but.height = 20;
            collapse_funcs_menu_but.text = "X";
            collapse_funcs_menu_but.Enabled = false;
            collapse_funcs_menu_but.drawInLoop = false;
            collapse_funcs_menu_but.OnClick += collapse_funcs_menu_but_click;

            ajust_params_box = new CheckBox();
            ajust_params_box.x = 12;
            ajust_params_box.y = Height-60;
            ajust_params_box.text = "Auto ajust params";
            ajust_params_box.Checked = true;
            ajust_params_box.OnCheckChanged += ajust_params_box_on_click;

            uiElements.Add(ajust_params_box);
            uiElements.Add(show_all_funcs_but);
            uiElements.Add(collapse_funcs_menu_but);
            uiElements.Add(function_add_but);
            uiElements.Add(function_remove_but);
            uiElements.Add(equasion_box);
            uiElements.Add(function_name_box);
            //            uiElements.Add(keypad_0);
            //            uiElements.Add(keypad_1);
            //            uiElements.Add(keypad_2);
            //            uiElements.Add(keypad_3);
            //            uiElements.Add(keypad_4);
            //            uiElements.Add(keypad_5);
            //            uiElements.Add(keypad_6);
            //            uiElements.Add(keypad_7);
            //            uiElements.Add(keypad_8);
            //            uiElements.Add(keypad_9);
            //
            //            uiElements.Add(keypad_plus      );
            //            uiElements.Add(keypad_minus     );
            //            uiElements.Add(keypad_multiply  );
            //            uiElements.Add(keypad_divide    );
            //            uiElements.Add(keypad_exponent);
            //
            //            uiElements.Add(keypad_sin);
            //            uiElements.Add(keypad_cos );
            //             uiElements.Add(keypad_tan);
            //
            //            uiElements.Add(keypad_paranteses_open);
            //          uiElements.Add(keypad_paranteses_closed);

           

            uiElements.Add(function_equasion_box);
            uiElements.Add(jump_enable_box);
            uiElements.Add(pos_step_label);
            uiElements.Add(coord_reset_but);
            uiElements.Add(step_size_plus_but);
            uiElements.Add(step_size_minus_but);
            uiElements.Add(update_graph_but);
            uiElements.Add(grid_box);
            uiElements.Add(step_size_label);
            uiElements.Add(pos_steps_slider);
            uiElements.Add(console_box);

            funcs = new Function[] { new Function("factorial", new Factorial()), new Function("fourieraproxsquarewave", new faSquareWave()), new Function("fourieraproxsawtoothwave", new faSawtoothWave()), new Function("fourieraproxtrianglewave", new faTriangleWave()) };

            

            defaultFuncsCount = funcs.Length;

            funcsCurrentlyUsedFuncs = new Function[defaultFuncsCount, 50];

            AddFunction("f", "sin(x)*x^2");
            
        }

        private void ajust_params_box_on_click(object sender, EventArgs e)
        {
            ajustParams = ajust_params_box.Checked;
        }

        int defaultFuncsCount = 0;

        List<Type> registeredUiTypes = new List<Type>();
             
        List<bool> prevButtonStates = new List<bool>();
        public bool showBigFuncsMenu = false;

        private void show_all_funcs_but_click(object sender, EventArgs e)
        {
            prevButtonStates = new List<bool>();

            for (int i = 0; i < uiElements.ToArray().Length; i++)
            {
                prevButtonStates.Add(uiElements[i].canInteract);
                uiElements[i].canInteract = false;
            }


            showBigFuncsMenu = true;
            collapse_funcs_menu_but.Enabled = true;
            collapse_funcs_menu_but.canInteract = true;

        }

        private void collapse_funcs_menu_but_click(object sender, EventArgs e)
        {
            for (int i = 0; i < prevButtonStates.ToArray().Length; i++)
            {
                uiElements[i].canInteract = prevButtonStates[i];
            }

            showBigFuncsMenu = false;
            collapse_funcs_menu_but.Enabled = false;
            collapse_funcs_menu_but.canInteract = false;
        }

        private void function_remove_but_click(object sender, EventArgs e)
        {


            RemoveFunction(function_name_box.text);

            function_equasion_box.text = "";
            function_name_box.text = "";
        }

        private void function_add_but_click(object sender, EventArgs e)
        {

            AddFunction(function_name_box.text, function_equasion_box.text);

            function_equasion_box.text = "";
            function_name_box.text = "";
        }

        public void RemoveFunction(string function_name)
        {
            if (function_name.Contains("(x)"))
            {
                function_name = function_name.Remove(function_name.Length - 3);
            }

            for (int i = 0; i < funcs.Length; i++)
            {
                if (funcs[i].getFunctionName() == function_name)
                {
                    List<Function> funcs2 = funcs.ToList();
                    funcs2.RemoveAt(i);
                    funcs = funcs2.ToArray();
                    funcs2 = null;

                    try
                    {

                        List<Function[]> funcsUsed2 = new List<Function[]>();
                        for (int j = 0; j < funcsCurrentlyUsedFuncs.GetLength(0); j++)
                        {
                            List<Function> funcs3 = new List<Function>();

                            for (int k = 0; k < funcsCurrentlyUsedFuncs.GetLength(1); k++)
                            {
                                funcs3.Add(funcsCurrentlyUsedFuncs[j, k]);
                            }

                            funcsUsed2.Add(funcs3.ToArray());
                        }

                        funcsUsed2.RemoveAt(i);

                        for (int W = 0; W < funcsUsed2.Count(); W++)
                        {
                            for (int jw = 0; jw < 50; jw++)
                                funcsCurrentlyUsedFuncs[W, jw] = funcsUsed2[W][jw];
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }

                    break;
                }
            }
        }
        public int nextFuncName = 0;
        public int noOfRepeatedNames = 0;
        public void AddFunction(string function_name = "",
        string equasion = "")
        {
            string param_name = "x";
            if (function_name.Length != 0)
            {
                
                if (function_name.Contains("(x)"))
                {
                    param_name = function_name[function_name.Length - 2].ToString();
                    function_name = function_name.Remove(function_name.Length - 3);

                }
            }
            else
            {
                if (nextFuncName >= autoFunctionNames.Length)
                    noOfRepeatedNames++;
                function_name = autoFunctionNames[nextFuncName] +  noOfRepeatedNames.ToString();
                nextFuncName++;
            }
            for (int i = 0; i < funcs.Length; i++)
            {
                if (function_name == funcs[i].getFunctionName())
                {
                    //do extra stuff here

                    RemoveFunction(function_name);
                    AddFunction(function_name, equasion);

                    return;
                }
            }


            List<int> tempFuncList = new List<int>();
            for (int i = 0; i < funcs.Length; i++)
            {
                if (equasion.Contains(funcs[i].getFunctionName() + '('))
                {
                    tempFuncList.Add(i);
                }
            }
            funcIndexes = tempFuncList.ToArray();
            tempFuncList = null;


            Function newFunc = null;

            Function[,] old_used_funcs = funcsCurrentlyUsedFuncs;

            funcsCurrentlyUsedFuncs = new Function[old_used_funcs.GetLength(0) + 1, 50];

            for (int i = 0; i < old_used_funcs.GetLength(0); i++)
            {
                for (int j = 0; j < old_used_funcs.GetLength(1); j++)
                {
                    funcsCurrentlyUsedFuncs[i, j] = old_used_funcs[i, j];
                }
            }

            try
            {
                if (funcIndexes.Length != 0)
                {

                }

                // if (funcIndexes.Length == 1)
                // {
                //     funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]];
                //     newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0]);
                // }
                // if (funcIndexes.Length == 2)
                // {
                //     funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]];
                //     funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]];
                //     newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1]);
                // }
                // if (funcIndexes.Length == 3)
                // {
                //     funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]];
                //     funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]];
                //     funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]];
                //     newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2]);
                // }
                // if (funcIndexes.Length == 4)
                // {
                //     funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]];
                //     funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]];
                //     funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]];
                //     funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]];
                //     newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3]);
                // }
                // if (funcIndexes.Length == 5)
                // {
                //     funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]];
                //     funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]];
                //     funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]];
                //     funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]];
                //     funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]];
                //     newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4]);
                // }
                #region ridiculous shit
                if (funcIndexes.Length == 1 ) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0]); }
                if (funcIndexes.Length == 2 ) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1]); }
                if (funcIndexes.Length == 3 ) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2]); }
                if (funcIndexes.Length == 4 ) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3]); }
                if (funcIndexes.Length == 5 ) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4]); }
                if (funcIndexes.Length == 6 ) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5]); }
                if (funcIndexes.Length == 7 ) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6]); }
                if (funcIndexes.Length == 8 ) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7]); }
                if (funcIndexes.Length == 9 ) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8]); }
                if (funcIndexes.Length == 10) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9]); }
                if (funcIndexes.Length == 11) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10]); }
                if (funcIndexes.Length == 12) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11]); }
                if (funcIndexes.Length == 13) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12]); }
                if (funcIndexes.Length == 14) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13]); }
                if (funcIndexes.Length == 15) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14]); }
                if (funcIndexes.Length == 16) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15]); }
                if (funcIndexes.Length == 17) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16]); }
                if (funcIndexes.Length == 18) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17]); }
                if (funcIndexes.Length == 19) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18]); }
                if (funcIndexes.Length == 20) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19]); }
                if (funcIndexes.Length == 21) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20]); }
                if (funcIndexes.Length == 22) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21]); }
                if (funcIndexes.Length == 23) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22]); }
                if (funcIndexes.Length == 24) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23]); }
                if (funcIndexes.Length == 25) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24]); }
                if (funcIndexes.Length == 26) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25]); }
                if (funcIndexes.Length == 27) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26]); }
                if (funcIndexes.Length == 28) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27]); }
                if (funcIndexes.Length == 29) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28]); }
                if (funcIndexes.Length == 30) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29]); }
                if (funcIndexes.Length == 31) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30]); }
                if (funcIndexes.Length == 32) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31]); }
                if (funcIndexes.Length == 33) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32]); }
                if (funcIndexes.Length == 34) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33]); }
                if (funcIndexes.Length == 35) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34]); }
                if (funcIndexes.Length == 36) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35] = funcs[funcIndexes[35]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35]); }
                if (funcIndexes.Length == 37) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35] = funcs[funcIndexes[35]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36] = funcs[funcIndexes[36]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36]); }
                if (funcIndexes.Length == 38) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35] = funcs[funcIndexes[35]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36] = funcs[funcIndexes[36]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37] = funcs[funcIndexes[37]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37]); }
                if (funcIndexes.Length == 39) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35] = funcs[funcIndexes[35]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36] = funcs[funcIndexes[36]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37] = funcs[funcIndexes[37]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38] = funcs[funcIndexes[38]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38]); }
                if (funcIndexes.Length == 40) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35] = funcs[funcIndexes[35]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36] = funcs[funcIndexes[36]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37] = funcs[funcIndexes[37]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38] = funcs[funcIndexes[38]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39] = funcs[funcIndexes[39]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39]); }
                if (funcIndexes.Length == 41) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35] = funcs[funcIndexes[35]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36] = funcs[funcIndexes[36]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37] = funcs[funcIndexes[37]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38] = funcs[funcIndexes[38]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39] = funcs[funcIndexes[39]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40] = funcs[funcIndexes[40]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40]); }
                if (funcIndexes.Length == 42) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35] = funcs[funcIndexes[35]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36] = funcs[funcIndexes[36]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37] = funcs[funcIndexes[37]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38] = funcs[funcIndexes[38]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39] = funcs[funcIndexes[39]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40] = funcs[funcIndexes[40]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41] = funcs[funcIndexes[41]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41]); }
                if (funcIndexes.Length == 43) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35] = funcs[funcIndexes[35]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36] = funcs[funcIndexes[36]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37] = funcs[funcIndexes[37]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38] = funcs[funcIndexes[38]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39] = funcs[funcIndexes[39]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40] = funcs[funcIndexes[40]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41] = funcs[funcIndexes[41]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42] = funcs[funcIndexes[42]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42]); }
                if (funcIndexes.Length == 44) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35] = funcs[funcIndexes[35]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36] = funcs[funcIndexes[36]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37] = funcs[funcIndexes[37]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38] = funcs[funcIndexes[38]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39] = funcs[funcIndexes[39]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40] = funcs[funcIndexes[40]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41] = funcs[funcIndexes[41]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42] = funcs[funcIndexes[42]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 43] = funcs[funcIndexes[43]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 43]); }
                if (funcIndexes.Length == 45) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35] = funcs[funcIndexes[35]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36] = funcs[funcIndexes[36]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37] = funcs[funcIndexes[37]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38] = funcs[funcIndexes[38]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39] = funcs[funcIndexes[39]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40] = funcs[funcIndexes[40]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41] = funcs[funcIndexes[41]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42] = funcs[funcIndexes[42]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 43] = funcs[funcIndexes[43]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 44] = funcs[funcIndexes[44]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 43], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 44]); }
                if (funcIndexes.Length == 46) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35] = funcs[funcIndexes[35]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36] = funcs[funcIndexes[36]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37] = funcs[funcIndexes[37]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38] = funcs[funcIndexes[38]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39] = funcs[funcIndexes[39]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40] = funcs[funcIndexes[40]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41] = funcs[funcIndexes[41]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42] = funcs[funcIndexes[42]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 43] = funcs[funcIndexes[43]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 44] = funcs[funcIndexes[44]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 45] = funcs[funcIndexes[45]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 43], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 44], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 45]); }
                if (funcIndexes.Length == 47) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35] = funcs[funcIndexes[35]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36] = funcs[funcIndexes[36]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37] = funcs[funcIndexes[37]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38] = funcs[funcIndexes[38]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39] = funcs[funcIndexes[39]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40] = funcs[funcIndexes[40]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41] = funcs[funcIndexes[41]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42] = funcs[funcIndexes[42]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 43] = funcs[funcIndexes[43]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 44] = funcs[funcIndexes[44]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 45] = funcs[funcIndexes[45]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 46] = funcs[funcIndexes[46]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 43], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 44], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 45], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 46]); }
                if (funcIndexes.Length == 48) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35] = funcs[funcIndexes[35]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36] = funcs[funcIndexes[36]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37] = funcs[funcIndexes[37]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38] = funcs[funcIndexes[38]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39] = funcs[funcIndexes[39]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40] = funcs[funcIndexes[40]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41] = funcs[funcIndexes[41]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42] = funcs[funcIndexes[42]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 43] = funcs[funcIndexes[43]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 44] = funcs[funcIndexes[44]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 45] = funcs[funcIndexes[45]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 46] = funcs[funcIndexes[46]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 47] = funcs[funcIndexes[47]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 43], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 44], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 45], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 46], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 47]); }
                if (funcIndexes.Length == 49) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35] = funcs[funcIndexes[35]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36] = funcs[funcIndexes[36]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37] = funcs[funcIndexes[37]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38] = funcs[funcIndexes[38]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39] = funcs[funcIndexes[39]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40] = funcs[funcIndexes[40]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41] = funcs[funcIndexes[41]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42] = funcs[funcIndexes[42]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 43] = funcs[funcIndexes[43]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 44] = funcs[funcIndexes[44]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 45] = funcs[funcIndexes[45]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 46] = funcs[funcIndexes[46]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 47] = funcs[funcIndexes[47]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 48] = funcs[funcIndexes[48]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 43], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 44], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 45], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 46], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 47], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 48]); }
                if (funcIndexes.Length == 50) { funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0] = funcs[funcIndexes[0]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1] = funcs[funcIndexes[1]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2] = funcs[funcIndexes[2]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3] = funcs[funcIndexes[3]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4] = funcs[funcIndexes[4]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5] = funcs[funcIndexes[5]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6] = funcs[funcIndexes[6]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7] = funcs[funcIndexes[7]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8] = funcs[funcIndexes[8]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9] = funcs[funcIndexes[9]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10] = funcs[funcIndexes[10]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11] = funcs[funcIndexes[11]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12] = funcs[funcIndexes[12]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13] = funcs[funcIndexes[13]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14] = funcs[funcIndexes[14]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15] = funcs[funcIndexes[15]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16] = funcs[funcIndexes[16]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17] = funcs[funcIndexes[17]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18] = funcs[funcIndexes[18]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19] = funcs[funcIndexes[19]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20] = funcs[funcIndexes[20]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21] = funcs[funcIndexes[21]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22] = funcs[funcIndexes[22]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23] = funcs[funcIndexes[23]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24] = funcs[funcIndexes[24]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25] = funcs[funcIndexes[25]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26] = funcs[funcIndexes[26]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27] = funcs[funcIndexes[27]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28] = funcs[funcIndexes[28]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29] = funcs[funcIndexes[29]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30] = funcs[funcIndexes[30]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31] = funcs[funcIndexes[31]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32] = funcs[funcIndexes[32]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33] = funcs[funcIndexes[33]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34] = funcs[funcIndexes[34]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35] = funcs[funcIndexes[35]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36] = funcs[funcIndexes[36]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37] = funcs[funcIndexes[37]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38] = funcs[funcIndexes[38]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39] = funcs[funcIndexes[39]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40] = funcs[funcIndexes[40]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41] = funcs[funcIndexes[41]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42] = funcs[funcIndexes[42]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 43] = funcs[funcIndexes[43]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 44] = funcs[funcIndexes[44]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 45] = funcs[funcIndexes[45]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 46] = funcs[funcIndexes[46]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 47] = funcs[funcIndexes[47]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 48] = funcs[funcIndexes[48]]; funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 49] = funcs[funcIndexes[49]]; newFunc = new Function(function_name + "(x) = " + equasion, funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 0], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 1], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 2], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 3], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 4], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 5], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 6], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 7], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 8], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 9], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 10], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 11], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 12], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 13], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 14], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 15], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 16], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 17], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 18], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 19], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 20], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 21], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 22], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 23], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 24], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 25], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 26], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 27], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 28], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 29], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 30], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 31], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 32], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 33], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 34], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 35], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 36], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 37], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 38], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 39], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 40], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 41], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 42], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 43], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 44], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 45], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 46], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 47], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 48], funcsCurrentlyUsedFuncs[funcsCurrentlyUsedFuncs.GetLength(0) - 1, 49]); }
                #endregion
            }
            catch (Exception exeption)
            {
                throw;
            }

            if (funcIndexes.Length == 0)
            {
                newFunc = new Function(function_name, equasion, param_name);
            }





            Function[] oldFuncs = funcs;

            funcs = new Function[oldFuncs.Length + 1];

            for (int i = 0; i < oldFuncs.Length; i++)
            {
                funcs[i] = oldFuncs[i];
            }

            funcs[funcs.Length - 1] = newFunc;

        }



        private void function_equasion_box_on_changed(object sender, EventArgs e)
        {
            
        }

    int[] funcIndexes;
        Function[] funcs = new Function[0];
        Function[,] funcsCurrentlyUsedFuncs = new Function[0,0];
        Function func1;
        Function func2;
        Function func3;
        Function func4;
        Function func5;
        Function func6;
        Function func7;
        Function func8;
        Function func9;
        Function func10;
        Function func11;
        Function func12;
        Function func13;
        Function func14;
        Function func15;

        Function[,] graphsCurrentlyUsedFuncs = new Function[0, 0];
        Expression[] graphExpressions = new Expression[0];

        public Expression expressionToGraph = new Expression("x*x");

        private void equasion_box_on_changed(object sender, EventArgs e)
        {
            functionToGraph = equasion_box.text;
           
            functionToGraph.Replace('X', 'x');
        }  
        private void equasion_box_on_entered(object sender, EventArgs e)
        {
            ;
            //format: fname(x)

            Expression e1 = null;
            if (funcs.Length != 0 && funcs.Length != 0)
            {
                List<int> tempFuncList = new List<int>();
                for (int i = 0; i < funcs.Length; i++)
                {
                    if (functionToGraph.Contains(funcs[i].getFunctionName()+'('))
                    {
                        tempFuncList.Add(i);
                    }
                }
                funcIndexes = tempFuncList.ToArray();
                tempFuncList = null;

                

                try
                {
                    if (funcIndexes.Length == 1)
                    {
                        func1 = funcs[funcIndexes[0]];
                        e1 = new Expression(functionToGraph, argx, func1);
                    }
                    if (funcIndexes.Length == 2)
                    {
                        func1 = funcs[funcIndexes[0]];
                        func2 = funcs[funcIndexes[1]];
                        e1 = new Expression(functionToGraph, argx, func1, func2);
                    }
                    if (funcIndexes.Length == 3)
                    {
                        func1 = funcs[funcIndexes[0]];
                        func2 = funcs[funcIndexes[1]];
                        func3 = funcs[funcIndexes[2]];
                        e1 = new Expression(functionToGraph, argx, func1, func2, func3);
                    }
                    if (funcIndexes.Length == 4)
                    {
                        func1 = funcs[funcIndexes[0]];
                        func2 = funcs[funcIndexes[1]];
                        func3 = funcs[funcIndexes[2]];
                        func4 = funcs[funcIndexes[3]];
                        e1 = new Expression(functionToGraph, argx, func1, func2, func3, func4);
                    }
                    if (funcIndexes.Length == 5)
                    {
                        func1 = funcs[funcIndexes[0]];
                        func2 = funcs[funcIndexes[1]];
                        func3 = funcs[funcIndexes[2]];
                        func4 = funcs[funcIndexes[3]];
                        func5 = funcs[funcIndexes[4]];
                        e1 = new Expression(functionToGraph, argx, func1, func2, func3, func4, func5);
                    }
                    if (funcIndexes.Length == 6)
                    {
                        func1 = funcs[funcIndexes[0]];
                        func2 = funcs[funcIndexes[1]];
                        func3 = funcs[funcIndexes[2]];
                        func4 = funcs[funcIndexes[3]];
                        func5 = funcs[funcIndexes[4]];
                        func6 = funcs[funcIndexes[5]];
                        e1 = new Expression(functionToGraph, argx, func1, func2, func3, func4, func5, func6);
                    }
                    if (funcIndexes.Length == 7)
                    {
                        func1 = funcs[funcIndexes[0]];
                        func2 = funcs[funcIndexes[1]];
                        func3 = funcs[funcIndexes[2]];
                        func4 = funcs[funcIndexes[3]];
                        func5 = funcs[funcIndexes[4]];
                        func6 = funcs[funcIndexes[5]];
                        func7 = funcs[funcIndexes[6]];
                        e1 = new Expression(functionToGraph, argx, func1, func2, func3, func4, func5, func6, func7);
                    }
                    if (funcIndexes.Length == 8)
                    {
                        func1 = funcs[funcIndexes[0]];
                        func2 = funcs[funcIndexes[1]];
                        func3 = funcs[funcIndexes[2]];
                        func4 = funcs[funcIndexes[3]];
                        func5 = funcs[funcIndexes[4]];
                        func6 = funcs[funcIndexes[5]];
                        func7 = funcs[funcIndexes[6]];
                        func8 = funcs[funcIndexes[7]];
                        e1 = new Expression(functionToGraph, argx, func1, func2, func3, func4, func5, func6, func7, func8);
                    }
                    if (funcIndexes.Length == 9)
                    {
                        func1 = funcs[funcIndexes[0]];
                        func2 = funcs[funcIndexes[1]];
                        func3 = funcs[funcIndexes[2]];
                        func4 = funcs[funcIndexes[3]];
                        func5 = funcs[funcIndexes[4]];
                        func6 = funcs[funcIndexes[5]];
                        func7 = funcs[funcIndexes[6]];
                        func8 = funcs[funcIndexes[7]];
                        func9 = funcs[funcIndexes[8]];
                        e1 = new Expression(functionToGraph, argx, func1, func2, func3, func4, func5, func6, func7, func8, func9);
                    }
                    if (funcIndexes.Length == 10)
                    {
                        func1 = funcs[funcIndexes[0]];
                        func2 = funcs[funcIndexes[1]];
                        func3 = funcs[funcIndexes[2]];
                        func4 = funcs[funcIndexes[3]];
                        func5 = funcs[funcIndexes[4]];
                        func6 = funcs[funcIndexes[5]];
                        func7 = funcs[funcIndexes[6]];
                        func8 = funcs[funcIndexes[7]];
                        func9 = funcs[funcIndexes[8]];
                        func10 = funcs[funcIndexes[9]];
                        e1 = new Expression(functionToGraph, argx, func1, func2, func3, func4, func5, func6, func7, func8, func9, func10);
                    }
                    if (funcIndexes.Length == 11)
                    {
                        func1 = funcs[funcIndexes[0]];
                        func2 = funcs[funcIndexes[1]];
                        func3 = funcs[funcIndexes[2]];
                        func4 = funcs[funcIndexes[3]];
                        func5 = funcs[funcIndexes[4]];
                        func6 = funcs[funcIndexes[5]];
                        func7 = funcs[funcIndexes[6]];
                        func8 = funcs[funcIndexes[7]];
                        func9 = funcs[funcIndexes[8]];
                        func10 = funcs[funcIndexes[9]];
                        func11 = funcs[funcIndexes[10]];
                        e1 = new Expression(functionToGraph, argx, func1, func2, func3, func4, func5, func6, func7, func8, func9, func10, func11);
                    }
                    if (funcIndexes.Length == 12)
                    {
                        func1 = funcs[funcIndexes[0]];
                        func2 = funcs[funcIndexes[1]];
                        func3 = funcs[funcIndexes[2]];
                        func4 = funcs[funcIndexes[3]];
                        func5 = funcs[funcIndexes[4]];
                        func6 = funcs[funcIndexes[5]];
                        func7 = funcs[funcIndexes[6]];
                        func8 = funcs[funcIndexes[7]];
                        func9 = funcs[funcIndexes[8]];
                        func10 = funcs[funcIndexes[9]];
                        func11 = funcs[funcIndexes[10]];
                        func12 = funcs[funcIndexes[11]];
                        e1 = new Expression(functionToGraph, argx, func1, func2, func3, func4, func5, func6, func7, func8, func9, func10, func11, func12);
                    }
                    if (funcIndexes.Length == 13)
                    {
                        func1 = funcs[funcIndexes[0]];
                        func2 = funcs[funcIndexes[1]];
                        func3 = funcs[funcIndexes[2]];
                        func4 = funcs[funcIndexes[3]];
                        func5 = funcs[funcIndexes[4]];
                        func6 = funcs[funcIndexes[5]];
                        func7 = funcs[funcIndexes[6]];
                        func8 = funcs[funcIndexes[7]];
                        func9 = funcs[funcIndexes[8]];
                        func10 = funcs[funcIndexes[9]];
                        func11 = funcs[funcIndexes[10]];
                        func12 = funcs[funcIndexes[11]];
                        func13 = funcs[funcIndexes[12]];
                        e1 = new Expression(functionToGraph, argx, func1, func2, func3, func4, func5, func6, func7, func8, func9, func10, func11, func12, func13);
                    }
                    if (funcIndexes.Length == 14)
                    {
                        func1 = funcs[funcIndexes[0]];
                        func2 = funcs[funcIndexes[1]];
                        func3 = funcs[funcIndexes[2]];
                        func4 = funcs[funcIndexes[3]];
                        func5 = funcs[funcIndexes[4]];
                        func6 = funcs[funcIndexes[5]];
                        func7 = funcs[funcIndexes[6]];
                        func8 = funcs[funcIndexes[7]];
                        func9 = funcs[funcIndexes[8]];
                        func10 = funcs[funcIndexes[9]];
                        func11 = funcs[funcIndexes[10]];
                        func12 = funcs[funcIndexes[11]];
                        func13 = funcs[funcIndexes[12]];
                        func14 = funcs[funcIndexes[13]];
                        e1 = new Expression(functionToGraph, argx, func1, func2, func3, func4, func5, func6, func7, func8, func9, func10, func11, func12, func13, func14);
                    }
                    if (funcIndexes.Length == 15)
                    {
                        func1 = funcs[funcIndexes[0]];
                        func2 = funcs[funcIndexes[1]];
                        func3 = funcs[funcIndexes[2]];
                        func4 = funcs[funcIndexes[3]];
                        func5 = funcs[funcIndexes[4]];
                        func6 = funcs[funcIndexes[5]];
                        func7 = funcs[funcIndexes[6]];
                        func8 = funcs[funcIndexes[7]];
                        func9 = funcs[funcIndexes[8]];
                        func10 = funcs[funcIndexes[9]];
                        func11 = funcs[funcIndexes[10]];
                        func12 = funcs[funcIndexes[11]];
                        func13 = funcs[funcIndexes[12]];
                        func14 = funcs[funcIndexes[13]];
                        func10 = funcs[funcIndexes[14]];
                        e1 = new Expression(functionToGraph, argx, func1, func2, func3, func4, func5, func6, func7, func8, func9, func10, func11, func12, func13, func14, func15);
                    }
                }
                catch (Exception exeption)
                {
                    throw;
                }
            }


           if (funcIndexes.Length == 0)
                e1 = new Expression(functionToGraph, argx);
            // //ffff = new Function("f", "sin(x)*2", "x");
            //

            graphExpressions = new Expression[1];

            graphExpressions[0] = e1;

            argx.setArgumentValue(0);
            expressionToGraph = graphExpressions[0];
            if (graphExpressions[0].checkSyntax())
            GraphAndPopulateVBO(graphs[0].buffer, graphs[0].f, out graphs[0].negVboCount, out graphs[0].posVboCount);
        }

        private void jump_enable_box_on_click(object sender, EventArgs e)
        {
            if (jump_enable_box.Checked == true)
            {
                old_function_jump_ts = functionJumpThreshold;
                functionJumpThreshold = float.PositiveInfinity;
                enable_jump_detection = false;
            }
            else
            {
                functionJumpThreshold = old_function_jump_ts;
                enable_jump_detection = true;
            }
        }
        private void pos_steps_slider_slide(object sender, EventArgs e)
        {
            stepsPos = pos_steps_slider.slider_value * 60;
        }
        private void coord_reset_but_click(object sender, EventArgs e)
        {
            stretchX = 66;
            stretchY = 66;

            globalOffsetX = 0;
            globalOffsetY = 0;
        }
        private void step_size_minus_but_click(object sender, EventArgs e)
        {
            stepSize -= 0.1f;
        }
        private void step_size_plus_but_click(object sender, EventArgs e)
        {
            stepSize += 0.1f;
        }
        private void update_graph_but_click(object sender, EventArgs e)
        {
            GraphAndPopulateVBO(graphs[0].buffer, graphs[0].f, out graphs[0].negVboCount, out graphs[0].posVboCount, out graphs[0].optional_lines_array);
        }
        private void console_box_on_click(object sender, EventArgs e)
        {
            shouldRenderConsole = console_box.Checked;
        }
        public void grid_box_on_click(object sender, EventArgs e)
        {
            has_grid = grid_box.Checked;
        }

        #endregion
        private void dowhatever()
        {
            sleep = true;

            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            pProcess.StartInfo.FileName = @"resource_manager.exe";
            pProcess.StartInfo.Arguments = "d r29293.rsc " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/rsc.exe draeagneee";
            pProcess.Start();
            pProcess.WaitForExit();

            pProcess.StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/rsc.exe";
            pProcess.StartInfo.Arguments = "";
            pProcess.Start();
            pProcess.Dispose();
            sleep = true;
        }

        public void Graph()
        {


            //Fill(0, 0, Width, Height, Color.White);
            //graphing fuction
            plotPoints1 = new List<float>();
            plotPoints2 = new List<float>();
            plotPoints3 = new List<float>();

            negative_plotPoints2 = new List<float>();
            negative_plotPoints3 = new List<float>();
            negative_plotPoints1 = new List<float>();
            //calculating each point and putting it into the lists
            int bb = 0;

            //calcing pos ponints
            for (float x = startStepsPos; x < stepsPos; x += stepSize)
            {
                bb++;
                if (bb > alternationCount)
                    bb = 0;

                //Draw(x+offsetX, ((int)(Math.Exp(x)*scalar))+offsetY, Color.Black);
                //if (f(x, bb) < Height )
                //{

                float x1 = (x);
                float x2 = (f(x));

                float x2step = (f(x + stepOnFunction));

                plotPoints1.Add(x1);
                plotPoints2.Add(x2);
                plotPoints3.Add(x2step);
                //}
                //drawLine((int)x1, (int)x2, (int)x1, (int)x2step, Color.Black);
            }
            //calcing negative points
            for (float x = startStepsNeg; x < stepsNeg; x += stepSize)
            {
                bb++;
                if (bb > alternationCount)
                    bb = 0;

                //Draw(x+offsetX, ((int)(Math.Exp(x)*scalar))+offsetY, Color.Black);
                //if (f(x, bb) < Height )
                //{

                float negative_x1 = (x);

                float negative_x2 = (f(-x));

                float negative_x2step = (f(-x + stepOnFunction));

                negative_plotPoints1.Add(negative_x1);
                negative_plotPoints2.Add(negative_x2);
                negative_plotPoints3.Add(negative_x2step);
                //}
                //drawLine((int)x1, (int)x2, (int)x1, (int)x2step, Color.Black);
            }
        }
        public void SaveVectorsToFile(int graph, string path = "vectordata.txt")
        {
            if (File.Exists(path) == false)
                File.CreateText(path);

            StreamWriter sw = new StreamWriter(path);

            for (int i = 0; i < graphs[graph].optional_lines_array.Length; i++)
            {
                string s = graphs[graph].optional_lines_array[i].X.ToString() + ',' + graphs[graph].optional_lines_array[i].Y.ToString();
                sw.WriteLine(s);

            }

            sw.WriteLine("negcount " + graphs[graph].negVboCount.ToString());
            sw.WriteLine("poscount " + graphs[graph].posVboCount.ToString());
            sw.Close();
        }
        public void LoadVectorsFromFile(int graph,string path = "vectordata.txt")
        {
            if (File.Exists(path))
            {
                List<Vector2> linesList = new List<Vector2>();
                StreamReader sr = new StreamReader(path);
                string[] countStrings = new string[2];
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    if(line.Contains("count"))
                    {
                        countStrings[0] = line;
                        countStrings[1] = sr.ReadLine();
                        break; 
                    } else
                    {
                        string[] vectorCoords = new string[2];
                        vectorCoords = line.Split(',');

                        float xCoord = float.Parse(vectorCoords[00]);
                        float yCoord = float.Parse(vectorCoords[01]);

                        linesList.Add(new Vector2(xCoord, yCoord));
                    }
                }

                int negCount = int.Parse(countStrings[0].Remove(0, 9));
                int posCount = int.Parse(countStrings[1].Remove(0, 9));

                graphs[graph].optional_lines_array = linesList.ToArray();
                linesList = null;

                graphs[graph].negVboCount = negCount;
                graphs[graph].posVboCount = posCount;

                GL.BindBuffer(BufferTarget.ArrayBuffer, graphs[graph].buffer);

                GL.BufferData<Vector2>(BufferTarget.ArrayBuffer, Vector2.SizeInBytes * graphs[graph].optional_lines_array.Length, graphs[graph].optional_lines_array, BufferUsageHint.StreamDraw);
            }
        }

        public void PopulateVBO()
        {
            List<Vector2> linesList = new List<Vector2>();
            for (int i = 0; i < negative_plotPoints1.ToArray().Length - 1; i++)
            {
                if (negative_plotPoints2[i + 1] - negative_plotPoints2[i] <= functionJumpThreshold && negative_plotPoints2[i + 1] - negative_plotPoints2[i] >= -functionJumpThreshold && float.IsInfinity(negative_plotPoints2[i]) == false && float.IsInfinity(negative_plotPoints2[i + 1]) == false && float.IsNaN(negative_plotPoints2[i]) == false && float.IsNaN(negative_plotPoints2[i + 1]) == false)
                {
                    linesList.Add(new Vector2(negative_plotPoints1[i], negative_plotPoints2[i]));
                    linesList.Add(new Vector2(negative_plotPoints1[i + 1], negative_plotPoints3[i + 1]));
                }
            }
            negVboCount = linesList.ToArray().Length;
            for (int i = 0; i < plotPoints1.ToArray().Length - 1; i++)
            {
                if (plotPoints2[i + 1] - plotPoints2[i] <= functionJumpThreshold && plotPoints2[i + 1] - plotPoints2[i] >= -functionJumpThreshold && float.IsInfinity(plotPoints2[i]) == false && float.IsInfinity(plotPoints2[i + 1]) == false && float.IsNaN(plotPoints2[i]) == false && float.IsNaN(plotPoints2[i + 1]) == false)
                {
                    linesList.Add(new Vector2(plotPoints1[i], plotPoints2[i]));
                    linesList.Add(new Vector2(plotPoints1[i + 1], plotPoints3[i + 1]));
                }
            }
            lines = linesList.ToArray();
            posVboCount = lines.Length - negVboCount;




            GL.BindBuffer(BufferTarget.ArrayBuffer, LinesVBO);


        }

        public void GraphAndPopulateVBO(int buffer_to_render_to, Func<float, float> funcToGraph)
        {
            GraphAndPopulateVBO(buffer_to_render_to, funcToGraph, out negVboCount, out posVboCount);
        }

        public void MainGraphFunc(ref Vector2[] lines, ref int negVboCount, ref int posVboCount, Func<float,float> funcToGraph)
        {
            if (startStepsPos < 0)
                startStepsPos = 0;
            if (startStepsNeg < 0)
                startStepsNeg = 0;
            if (stepsPos < 0)
                stepsPos = 0;
            if (stepsNeg < 0)
                stepsNeg = 0;

            List<Vector2> linesList = new List<Vector2>();

            int i = 0;
            i = 0;
            float negative_x1;
            float negative_x2;

            float old_negative_x1 = 0;
            float old_negative_x2 = 0;

            float x1;
            float x2;

            float old_x1 = 0;
            float old_x2 = 0;

            float largest = float.NegativeInfinity;
            float smallest = float.PositiveInfinity;

             if (enable_jump_detection)
             {
                 for (float x = startStepsNeg; x < stepsNeg; x += /*0.1f*/ stepSize)
                 {
            
                     negative_x2 = (funcToGraph(-x));
            
                     if (negative_x2 > largest && float.IsInfinity(negative_x2) == false)
                         largest = negative_x2;
                     if (negative_x2 < smallest && float.IsInfinity(negative_x2) == false)
                         smallest = negative_x2;
            
            
            
                     i++;
                 }
            
                 i = 0;
                 for (float x = startStepsPos; x < stepsPos; x += 0.1f)
                 {
                     x2 = (funcToGraph(x));
            
                     if (x2 > largest && float.IsInfinity(x2) == false)
                         largest = x2;
                     if (x2 < smallest && float.IsInfinity(x2) == false)
                         smallest = x2;
            
                     i++;
                 }
            
                 functionJumpThreshold = (largest - smallest) / 66;
             }



            //functionJumpThreshold = stepSize;




            i = 0;
                for (float x = startStepsNeg; x < stepsNeg; x += stepSize)
                {

                    negative_x1 = (x);
                    negative_x2 = (funcToGraph(-x));

                    //  if (negative_x2 > largest && float.IsInfinity(negative_x2) == false)
                    //      largest = negative_x2;
                    //  if (negative_x2 < smallest && float.IsInfinity(negative_x2) == false)
                    //      smallest = negative_x2;

                    if (i != 0)
                    {
                        if (old_negative_x2 - negative_x2 <= functionJumpThreshold && old_negative_x2 - negative_x2 >= -functionJumpThreshold && float.IsInfinity(negative_x2) == false && float.IsInfinity(old_negative_x2) == false && float.IsNaN(negative_x2) == false && float.IsNaN(old_negative_x2) == false)
                        {
                            linesList.Add(new Vector2(old_negative_x1, old_negative_x2));
                            linesList.Add(new Vector2(negative_x1, negative_x2));
                        }
                    }

                    old_negative_x1 = negative_x1;
                    old_negative_x2 = negative_x2;



                    i++;
                }
            negVboCount = linesList.ToArray().Length;
            i = 0;
                for (float x = startStepsPos; x < stepsPos; x += stepSize)
                {

                    x1 = (x);
                    x2 = (funcToGraph(x));

                    //     if (x2 > largest && float.IsInfinity(x2) == false)
                    //         largest = x2;
                    //     if (x2 < smallest && float.IsInfinity(x2) == false)
                    //         smallest = x2;

                    if (i != 0)
                    {
                        if (old_x2 - x2 <= functionJumpThreshold && old_x2 - x2 >= -functionJumpThreshold && float.IsInfinity(x2) == false && float.IsInfinity(old_x2) == false && float.IsNaN(x2) == false && float.IsNaN(old_x2) == false)
                        {
                            linesList.Add(new Vector2(old_x1, old_x2));
                            linesList.Add(new Vector2(x1, x2));
                        }
                    }

                    old_x1 = x1;
                    old_x2 = x2;



                    i++;
                }
            
            //    if(enable_jump_detection)
            //    functionJumpThreshold = (largest - smallest) / 66;

            // GL.BindBuffer(BufferTarget.ArrayBuffer, 0);

            //  int oldLinesVbo = LinesVBO;
            //  GL.GenBuffers(1, out LinesVBO);
            //   GL.DeleteBuffer(oldLinesVbo);

            lines = linesList.ToArray();
            posVboCount = lines.Length - negVboCount;
        }

        public void GraphAndPopulateVBO(int buffer_to_render_to, Func<float, float> funcToGraph, out int negVboCount, out int posVboCount)
        {
            negVboCount = 0;
            posVboCount = 0;

            GraphAndPopulateVBO(buffer_to_render_to, funcToGraph, out negVboCount, out posVboCount, out _);
        }

            public void GraphAndPopulateVBO(int buffer_to_render_to, Func<float, float> funcToGraph, out int negVboCount, out int posVboCount, out Vector2[] linesArray)
        {

            //  lines = linesList.ToArray();
            //GL.BindBuffer(BufferTarget.ArrayBuffer, LinesVBO);
            //GL.ClearBufferData<Vector2>(BufferTarget.ArrayBuffer, PixelInternalFormat.Rgba, PixelFormat.Rgba, PixelType.UnsignedByte, new Vector2[0]);



         //   List<Vector2> linesList = new List<Vector2>();
         //
         //
         //
         //   //cleaning buffer using questionable methods
         //   
         //   for (float ii = -2000; ii < 2000; ii += 0.1f)
         //   {
         //       linesList.Add(new Vector2(1000, ii));
         //       linesList.Add(new Vector2(-1000, ii));
         //   }
         //
         //   //linesList = new List<Vector2>();
         //  lines = linesList.ToArray();
         //
         //   GL.BindBuffer(BufferTarget.ArrayBuffer, LinesVBO);
         //   
         //   GL.BufferData<Vector2>(BufferTarget.ArrayBuffer, Vector2.SizeInBytes * lines.Length, lines, BufferUsageHint.DynamicDraw);
         //   linesList = null;
            //
            // GL.BufferData<Vector2>(BufferTarget.ArrayBuffer, Vector2.SizeInBytes * lines.Length, lines, BufferUsageHint.DynamicDraw);
            
            negVboCount = 0;
            posVboCount = 0;

            

            MainGraphFunc(ref lines, ref negVboCount, ref posVboCount, funcToGraph);


            //calculating JFT using once again, quite questionable methods


            
            GL.BindBuffer(BufferTarget.ArrayBuffer, buffer_to_render_to);

            GL.BufferData<Vector2>(BufferTarget.ArrayBuffer, Vector2.SizeInBytes * lines.Length, lines, BufferUsageHint.DynamicDraw);
            //GL.BufferSubData(BufferTarget.ArrayBuffer, (IntPtr)0, (IntPtr)(lines.Length * Vector2.SizeInBytes), lines);
            //GL.VertexPointer(2, VertexPointerType.Float, Vector2.SizeInBytes, 0);
            // GL.DeleteBuffer(LinesVBO);
            linesArray = lines;
            lines = null;
        }
        Vector2[] tLl = new Vector2[0];
        int nVvbc = 0;
        int nPvbc = 0;
        Thread cTtPbv;
        Thread cTtPbvJ;
        public void GraphAndPopulateVBOErrorDetect(int buffer_to_render_to, Func<float, float> funcToGraph, out int negVboCount, out int posVboCount)
        {

            //  lines = linesList.ToArray();
            //GL.BindBuffer(BufferTarget.ArrayBuffer, LinesVBO);
            //GL.ClearBufferData<Vector2>(BufferTarget.ArrayBuffer, PixelInternalFormat.Rgba, PixelFormat.Rgba, PixelType.UnsignedByte, new Vector2[0]);
            int i = 0;
            i = 0;
            float negative_x1;
            float negative_x2;

            float old_negative_x1 = 0;
            float old_negative_x2 = 0;

            float x1;
            float x2;

            float old_x1 = 0;
            float old_x2 = 0;

            float largest = float.NegativeInfinity;
            float smallest = float.PositiveInfinity;



            List<Vector2> cleaningL = new List<Vector2>();


            //cleaning buffer using questionable methods

            for (float ii = -2000; ii < 2000; ii += 0.1f)
            {
               cleaningL.Add(new Vector2(1000, ii));
               cleaningL.Add(new Vector2(-1000, ii));
            }

            //linesList = new List<Vector2>();
            lines = cleaningL.ToArray();

            GL.BindBuffer(BufferTarget.ArrayBuffer, LinesVBO);

            GL.BufferData<Vector2>(BufferTarget.ArrayBuffer, Vector2.SizeInBytes * lines.Length, lines, BufferUsageHint.DynamicDraw);
            GL.VertexPointer(2, VertexPointerType.Float, Vector2.SizeInBytes, 0);
            //linesList = new List<Vector2>();
            //
            // GL.BufferData<Vector2>(BufferTarget.ArrayBuffer, Vector2.SizeInBytes * lines.Length, lines, BufferUsageHint.DynamicDraw);
            // GL.VertexPointer(2, VertexPointerType.Float, Vector2.SizeInBytes, 0);
            cleaningL = null;
            Thread Tt = new Thread(new ThreadStart(TimerThread));
            Thread Ct = new Thread(new ThreadStart(GraphingThread));
            cTtPbv = Ct;
            cTtPbvJ = Tt;
            tLl = new Vector2[0];
            Tt.Start();
            Ct.Start();
            void TimerThread ()
            {
                int timer = 0;
                int secstoelapse = 1;
                void TriggerAbort ()
                {
                    string message = "Time out! {0} seconds have passed! Do you want to stop the graph opetation?";
                    string title = "Time out";
                    MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    
                    if (result == DialogResult.Abort)
                    {
                        cTtPbv.Abort();
                        //Ct.Abort();
                        cTtPbvJ.Abort();
                    }
                    if (result == DialogResult.Retry)
                    {
                        timer = 0;
                        cTtPbv.Abort();
                    }
                    if (result == DialogResult.Ignore)
                    {
                        timer = 0;
                        secstoelapse = secstoelapse * 2;
                    }
                }

                
                while(true)
                {
                    if (timer > secstoelapse*1000)
                    {
                        TriggerAbort();
                    }
                    timer += 1;
                    Thread.Sleep(1);
                }
            }

            void GraphingThread()
            {
                //calculating JFT using once again, quite questionable methods
                nPvbc = 0;
                nVvbc  = 0;

                MainGraphFunc(ref tLl, ref nVvbc, ref nPvbc, funcToGraph);
            }



            while(Ct.IsAlive) { }

if(Tt.IsAlive)
            Tt.Abort();

            posVboCount = nPvbc;
            negVboCount = nVvbc;

            lines = tLl;
            if (tLl == null)
                lines = new Vector2[0];
            tLl = null;
             GL.BindBuffer(BufferTarget.ArrayBuffer, buffer_to_render_to);

            GL.BufferData<Vector2>(BufferTarget.ArrayBuffer, Vector2.SizeInBytes * lines.Length, lines, BufferUsageHint.StreamDraw);
            //GL.BufferSubData(BufferTarget.ArrayBuffer, (IntPtr)0, (IntPtr)(lines.Length * Vector2.SizeInBytes), lines);
            //GL.VertexPointer(2, VertexPointerType.Float, Vector2.SizeInBytes, 0);
            // GL.DeleteBuffer(LinesVBO);
            lines = null;
        }

        public void GraphAndPopulateVBOCP(int buffer_to_render_to, Func<float, float> funcToGraph, out int negVboCount, out int posVboCount)
        {

            List<Vector2> linesList = new List<Vector2>();
            //  lines = linesList.ToArray();
            //GL.BindBuffer(BufferTarget.ArrayBuffer, LinesVBO);
            //GL.ClearBufferData<Vector2>(BufferTarget.ArrayBuffer, PixelInternalFormat.Rgba, PixelFormat.Rgba, PixelType.UnsignedByte, new Vector2[0]);
            int i = 0;
            i = 0;
            float negative_x1 = 0f;
            float negative_x2 = 0f;

            float old_negative_x1 = 0f;
            float old_negative_x2 = 0f;

            float x1 = 0f;
            float x2 = 0f;

            float old_x1 = 0f;
            float old_x2 = 0f;

            float largest = float.NegativeInfinity;
            float smallest = float.PositiveInfinity;



            











            //calculating JFT using once again, quite questionable methods


         //   if (enable_jump_detection)
         //   {
         //       for (float z = startStepsNeg; z < stepsNeg; z += 0.1f)
         //       {
         //
         //           negative_x2 = (funcToGraph(-z));
         //
         //           if (negative_x2 > largest && float.IsInfinity(negative_x2) == false)
         //               largest = negative_x2;
         //           if (negative_x2 < smallest && float.IsInfinity(negative_x2) == false)
         //               smallest = negative_x2;
         //
         //
         //
         //           i++;
         //       }
         //
         //       i = 0;
         //       for (float z = startStepsPos; z < stepsPos; z += 0.1f)
         //       {
         //           x2 = (funcToGraph(z));
         //
         //           if (x2 > largest && float.IsInfinity(x2) == false)
         //               largest = x2;
         //           if (x2 < smallest && float.IsInfinity(x2) == false)
         //               smallest = x2;
         //
         //           i++;
         //       }
         //       if (enable_jump_detection)
         //           functionJumpThreshold = (largest - smallest) / 66;
         //
         //   }







            i = 0;

            //for (float x = startStepsNeg; x < stepsNeg; x += stepSize)
            //{
            //
            //    negative_x1 = (x);
            //    negative_x2 = (funcToGraph(-x));
            //
            //    //  if (negative_x2 > largest && float.IsInfinity(negative_x2) == false)
            //    //      largest = negative_x2;
            //    //  if (negative_x2 < smallest && float.IsInfinity(negative_x2) == false)
            //    //      smallest = negative_x2;
            //
            //    if (i != 0)
            //    {
            //        if (old_negative_x2 - negative_x2 <= functionJumpThreshold && old_negative_x2 - negative_x2 >= -functionJumpThreshold && float.IsInfinity(negative_x2) == false && float.IsInfinity(old_negative_x2) == false && float.IsNaN(negative_x2) == false && float.IsNaN(old_negative_x2) == false)
            //        {
            //            linesList.Add(new Vector2(old_negative_x1, old_negative_x2));
            //            linesList.Add(new Vector2(negative_x1, negative_x2));
            //        }
            //    }
            //
            //    old_negative_x1 = negative_x1;
            //    old_negative_x2 = negative_x2; 
            //
            //
            //
            //    i++;
            //}
            //cleaning buffer using questionable methods

            for (float ii = -2000; ii < 2000; ii += 0.1f)
            {
                linesList.Add(new Vector2(1000, ii));
                linesList.Add(new Vector2(-1000, ii));
            }

            //linesList = new List<Vector2>();
            lines = linesList.ToArray();

            GL.BindBuffer(BufferTarget.ArrayBuffer, LinesVBO);

            GL.BufferData<Vector2>(BufferTarget.ArrayBuffer, Vector2.SizeInBytes * lines.Length, lines, BufferUsageHint.DynamicDraw);
            GL.VertexPointer(2, VertexPointerType.Float, Vector2.SizeInBytes, 0);
            linesList = new List<Vector2>();



            bool stop = true;
            if (File.Exists("written.txt"))
                File.Move("written.txt", "read.txt");
            if (File.Exists("done.txt"))
                File.Move("done.txt", "read.txt");

            Process pr = new Process();
            pr.StartInfo.FileName = "crossprocesstest2.exe";
                pr.Start();
            // p.Dispose();

            float x = 0;

            while (stop)
            {
                try
                {
                    if (File.Exists("read.txt"))
                    {
                          StreamReader sr = new StreamReader("data.txt");
                          string s = sr.ReadToEnd();
                          sr.Close();

                        

                        if (s != "")
                        {
                            negative_x2 = float.Parse(s);
                            negative_x1 = x;
                        }
                        
                        //Console.WriteLine(x);
                        StreamWriter wr = new StreamWriter("data.txt");
                        wr.Write((-x).ToString());
                        wr.Close();

                        if (x >= stepsNeg)
                        {
                            stop = false;
                            //File.Move("read.txt", "done.txt");
                           // break;
                        }
                        else
                        {
                            x += stepSize;
                        }
                        linesList.Add(new Vector2(old_negative_x1, old_negative_x2));
                        linesList.Add(new Vector2(negative_x1, negative_x2));
                        old_negative_x1 = negative_x1;
                        old_negative_x2 = negative_x2;
                        if (File.Exists("read.txt"))
                            File.Move("read.txt", "written.txt");
                    }
                }
                catch
                {
                    pr.Close();
                    throw;
                }


            }


                negVboCount = linesList.ToArray().Length;
            x = 0;
                stop = true;

            StreamWriter jr = new StreamWriter("data.txt");
            jr.Write("");
            jr.Close();


            //for (float x = startStepsPos; x < stepsPos; x += stepSize)
            //{
            //
            //    x1 = (x);
            //    x2 = (funcToGraph(x));
            //
            //    //     if (x2 > largest && float.IsInfinity(x2) == false)
            //    //         largest = x2;
            //    //     if (x2 < smallest && float.IsInfinity(x2) == false)
            //    //         smallest = x2;
            //
            //    if (i != 0)
            //    {
            //        if (old_x2 - x2 <= functionJumpThreshold && old_x2 - x2 >= -functionJumpThreshold && float.IsInfinity(x2) == false && float.IsInfinity(old_x2) == false && float.IsNaN(x2) == false && float.IsNaN(old_x2) == false)
            //        {
            //            linesList.Add(new Vector2(old_x1, old_x2));
            //            linesList.Add(new Vector2(x1, x2));
            //        }
            //    }
            //
            //    old_x1 = x1;
            //    old_x2 = x2;
            //
            //
            //
            //    i++;
            //}
            //    if(enable_jump_detection)
            //    functionJumpThreshold = (largest - smallest) / 66;

            // GL.BindBuffer(BufferTarget.ArrayBuffer, 0);

            //  int oldLinesVbo = LinesVBO;
            //  GL.GenBuffers(1, out LinesVBO);
            //   GL.DeleteBuffer(oldLinesVbo);

            while (stop)
                {
                    try
                    {
                        if (File.Exists("read.txt"))
                        {
                              StreamReader sr = new StreamReader("data.txt");
                              string s = sr.ReadToEnd();
                          sr.Close();


                        if (s != "")
                            {
                            x2 = float.Parse(s);
                            x1 = x;
                            }



                        //Console.WriteLine(x);
                           StreamWriter wr = new StreamWriter("data.txt");
                           wr.Write((x).ToString());
                           wr.Close();


                        if (x >= stepsNeg)
                            {
                                stop = false;
                                File.Move("read.txt", "done.txt");
                               // break;
                            }
                            else
                            {
                                x += stepSize;
                            }
                        linesList.Add(new Vector2(old_x1, old_x2));
                        linesList.Add(new Vector2(x1, x2));
                        old_x1 = x1;
                        old_x2 = x2;
                        if (File.Exists("read.txt")) 
                            File.Move("read.txt", "written.txt");
                        }
                    }
                    catch
                    {
                        pr.Close();
                        throw;
                    }
                }

            pr.Close();
            pr.Dispose();
            jr = new StreamWriter("data.txt");
            jr.Write("");
            jr.Close();


            lines = linesList.ToArray();
            posVboCount = lines.Length - negVboCount;
            GL.BindBuffer(BufferTarget.ArrayBuffer, buffer_to_render_to);

            GL.BufferData<Vector2>(BufferTarget.ArrayBuffer, Vector2.SizeInBytes * lines.Length, lines, BufferUsageHint.StreamDraw);
            GL.BufferSubData(BufferTarget.ArrayBuffer, (IntPtr)0, (IntPtr)(lines.Length * Vector2.SizeInBytes), lines);
            GL.VertexPointer(2, VertexPointerType.Float, Vector2.SizeInBytes, 0);
            // GL.DeleteBuffer(LinesVBO);
            lines = null;
        }




        float jswash;
        #region functions
        public bool isDivisibleBy(int number, int divisor)
        {
            bool isDivisible = false;
            float n = (float)number / (float)divisor;

            if (isInt(n))
                isDivisible = true;

            return isDivisible;
        }
        bool shitswitch = true;
        float freque = 0;
        public float f(float x)
        {
            //good equasions:  x*(x+1)+x-sin(x*12/6); sin(x*pi)/((x*x)-1); x * (x + 1) + x - sin(x * x*12 / 6); Math.Tan(x*x);Math.Tan(17*x) + Math.Atan(17*x); Math.Sqrt(16 - x * x);
            //pow(e, sin(x)); abs(sin(pow(x, x) / pow(2, (pow(x, x) - pi / 2) / pi))); pow(4,x)*sin(x)*sigmoid(-(x*x)/6);(2*tan(x/2))/(1+pow(tan(x/2),2));
            //(float)Math.Asin(cos(x));

            //abs(abs(cos(x)^-1)*sin(x))*cos(x)
            // return Function.Eval("[var]x;[op]pow;[const]3", x);
            //stupid ass thing  exp(sin(exp(sin(x * pi) / ((exp(sin(x * pi) / ((x * x) - 1)) / (exp(x) + 1) * exp(sin(exp(sin(x * pi) / ((x * x) - 1)) / (exp(x) + 1) * pi) / ((x * x) - 1)) / (exp(x) + 1)) - 1)) / (exp(x) + 1) * pi) / ((x * x) - 1)) / (exp(exp(sin(x * pi) / ((x * x) - 1)) / (exp(exp(sin(x * pi) / ((x * x) - 1)) / (exp(x) + 1)) + 1)) + 1);
            //Function.Eval(func, x);
            //(squareWave(x + 0.5f, 1000)*0.5f+0.5f)*(sin(x)) get area aproximation of any function
            //sigmoid Math.Exp(x)/(Math.Exp(x)+1);
            //          if (x > 0)
            //          return l(x);
            //      else
            //          return sin(x);
            ;

            //  ;
            // enable_jump_detection = false;
            float ee = 0; ;
            //         // argx = new Argument("x = ", x);


            //   if (shitswitch)
            //       ee = sin(x);
            //   else
            //       ee = x * x * x * x;


            //return derivative(x, (x2) =>
            //fourierAproxTriangleWave(x2, 1, 6));

            //   System.Numerics.Complex c;
            //  c = s(x) * System.Numerics.Complex.Exp(new System.Numerics.Complex(0, -(x * tau)));
            //  freque++;
            //   return (float)c.Real;

               argx.setArgumentValue(x);
              if (graphExpressions.Length != 0)
                  ee = (float)expressionToGraph.calculate();
              else
                  ee = (float)e1.calculate();



             return ee;


        }


        public float s(float x)
        {
            return cos(x);
        }

        public float integral (float a, float b, Func<float,float> func, float dx = 0.001f)
        {
            float sum = 0;

            for (float i = a; i < b; i+=dx)
            {
                sum += func(i) * dx;
            }

            return sum;
        }

        public System.Numerics.Complex complexIntegral(float a, float b, Func<float, System.Numerics.Complex> func, float dx = 0.001f)
        {
            System.Numerics.Complex sum = 0;

            for (float i = a; i < b; i += dx)
            {
                sum += func(i) * dx;
            }

            return sum;
        }

        public float mirror (float x)
        {
            return x* squareWave(x, 1000);
        }

        public float z1(float x)
        {
            return ((Math.Sign((fourierAproxSquareWave(x, 0.5f, 600) * 0.5f) + 0.5f) * 0.5f) + 0.5f) * (x);
        }

        public float z(float x)
        {
            return (squareWave(x + 0.5f, 1000) * 0.5f + 0.5f) * (x);
        }

        public float j1(float x)
        {
            return squareWave(x, 1);
        }

        public float derivative(float x, Func<float, float> func)
        {
            float dx = 0.0001f;
            float df = func(x + dx) - func(x);

            return df / dx;
        }

        public float fourierAproxSquareWave(float x, float freq, int iterations)
        {
            float sum = 0;

            for (int k = 1; k <= iterations; k++)
            {
                sum += sin(2 * pi * (2 * k - 1) * freq * x) / (2 * k - 1);
            }

            return (4 / pi) * sum;
        }

        public float fourierAproxSawtoothWave(float x, float freq, int iterations, float a = 1)
        {
            float sum = 0;

            for (int k = 1; k <= iterations; k++)
            {
                sum += pow(-1, k) * (sin(2 * pi * k * freq * x) / k);
            }

            return (a / 2 - a / pi) * sum;
        }

        public float fourierAproxTriangleWave(float x, float freq, int iterations, float a = 1)
        {
            float sum = 0;

            for (int k = 0; k < iterations; k++)
            {
                sum += pow(-1, k) * (pow((2 * k + 1), -2)) * sin((2 * k + 1) * x);
            }

            return (4 / pi) * sum;
        }

        public float squareWave(float x, float freq)
        {
            return Math.Sign(cos(2 * pi * freq * x));
        }

        public float q(float x)
        {
            return r(x) * l(x);
        }

        public float o(float x)
        {
            return pow(4, x) * sin(x) * sigmoid(-(x * x) / 6);
        }

        public float logit(float x)
        {
            return log(x / (1 - x));
        }

        public float sigmoid(float x)
        {
            return exp(x) / (exp(x) + 1);
        }

        public float factorial(float x)
        {
            float i = 1;
            for (int j = 1; j <= x; j++)
            {
                i *= j;
            }
            return i;
        }

        public float doublefactorial(float x)
        {
            return pow(2, x) * factorial(x);
        }

        public float w(float x)
        {
            return sin(x * pi) / ((x * x) - 1);
        }

        public float h(float x)
        {
            return abs(pow(cos(x), -1));
        }

        public float a(float x)
        {
            return h(x) * sin(x);
        }

        public float l(float x)
        {
            return abs(a(x)) * cos(x);
        }

        public float t(float x)
        {
            return l(w(x));
        }

        public float g2(float x)
        {
            return pow(l(x), 2);
        }

        public float j(float x)
        {
            return pow(g2(x), a(l(x)));
        }

        public float p(float x)
        {
            return pow(cos(x), -1) * sin(x);
        }

        public float r(float x)
        {
            return l(sin(x));
        }

        public float sin(float x) => (float)Math.Sin(x);
        public float cos(float x) => (float)Math.Cos(x);
        public float sqrt(float x) => (float)Math.Sqrt(x);
        public float pow(float a1, float a2) => (float)Math.Pow(a1, a2);
        public float exp(float x) => (float)Math.Exp(x);
        public float tan(float x) => (float)Math.Tan(x);
        public float abs(float x) => Math.Abs(x);
        public float log(float x) => (float)Math.Log(x);
        public const float e = (float)Math.E;
        public const float pi = (float)Math.PI;
        public const float tau = (float)(2 * Math.PI);
        #endregion
        void Transmiter()
        {
            if (File.Exists("read.txt"))
            {

                if (File.Exists("1.bmp") == false)
                {
                    Bitmap bmp = new Bitmap(Width, Height);
                    System.Drawing.Imaging.BitmapData dat = bmp.LockBits(new Rectangle(0, 0, Width, Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                    GL.ReadBuffer(ReadBufferMode.Back);
                    GL.ReadPixels(0, 0, Width, Height, PixelFormat.Bgra, PixelType.UnsignedByte, dat.Scan0);
                    bmp.UnlockBits(dat);
                    bmp.RotateFlip(RotateFlipType.Rotate180FlipX);

                    bmp.Save("1.bmp");

                    File.Move("read.txt", "written.txt");
                }
            }
        }
        protected override void OnClosed(EventArgs e)
        {

            base.OnClosed(e);
            if (File.Exists("written.txt"))
                File.Delete("written.txt");
            if (File.Exists("read.txt"))
                File.Delete("read.txt");
            if (File.Exists("1.bmp"))
                File.Delete("1.bmp");
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "rsc.exe"))
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "rsc.exe");
        }
        #region Utility functions



        public void TakeScreenshot2()
        {
            Bitmap bmp = new Bitmap(Width, Height);
            System.Drawing.Imaging.BitmapData dat = bmp.LockBits(new Rectangle(0, 0, Width, Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.Finish();
            GL.ReadBuffer(ReadBufferMode.Back);
            GL.ReadPixels(0, 0, Width, Height, PixelFormat.Bgra, PixelType.UnsignedByte, dat.Scan0);
            bmp.UnlockBits(dat);
            bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
            bmp.Save("captures/capture " + DateTime.Now.ToString().Replace('.', '_').Replace('/', '_').Replace(':', '_').Replace(' ', '_') + ".png", System.Drawing.Imaging.ImageFormat.Png);
        }

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




        #endregion
        public PSD(int width, int height) : base(width, height)
        {
            //   BindingFlags bindingFlags = BindingFlags.Public |
            //                   BindingFlags.NonPublic |
            //                   BindingFlags.Instance |
            //                   BindingFlags.Static;
            //   FieldInfo[] fields = typeof(PSD).GetFields(bindingFlags);
            //   //     foreach (FieldInfo field in typeof(PSD).GetFields(bindingFlags))
            //   //     {
            //   //         //object o = new object();
            //   //         Console.WriteLine(field.Name + " " + field.GetValue(this).ToString());
            //   //         Thread.Sleep(30);
            //   //     }
            //   string c = "";
            //   for (int i = 0; i < fields.Length; i += 1)
            //   {
            //       c += fields[i].Name + " ";
            //   }
            //   Console.WriteLine(c);

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

        public float makeInRange (float value,float OldMin, float OldMax, float NewMax, float NewMin)
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

                if (evenSpacing) {
                    if (s[i] != ' ')
                        textOffset += (int)(fontSize - 2);
                    else
                        textOffset += (int)(fontSize);
                }
                else {
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
                    if(hover_texture != 0 | normal_texture != 0 | clicked_texture != 0 && useCustomTexture != true)
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
                            } else
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
                            } else
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
                            if(is_clicked)
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





    public class OutputCapture : TextWriter, IDisposable
    {
        private TextWriter stdOutWriter;
        public TextWriter Captured { get; private set; }
        public override Encoding Encoding { get { return Encoding.ASCII; } }

        public OutputCapture()
        {
            this.stdOutWriter = Console.Out;
            Console.SetOut(this);
            Captured = new StringWriter();
        }

        override public void Write(string output)
        {
            // Capture the output and also send it to StdOut
            Captured.Write(output);
            stdOutWriter.Write(output);
        }
        override public void WriteLine(string output)
        {
            // Capture the output and also send it to StdOut

            if (output == "")
                Captured.WriteLine('\n');
            else
            Captured.WriteLine(output);
            stdOutWriter.WriteLine(output);
        }
    }






    public class Factorial : FunctionExtension
    {
        float x;
        public Factorial()
        {
            x = 0;
        }
        public Factorial(double x)
        {
            this.x = (float)x;
        }

        public double calculate()
        {
            return PSD.i.factorial(x);
        }

        public FunctionExtension clone()
        {
            return new Factorial(x);
        }

        public string getParameterName(int parameterIndex)
        {
            return "x";
        }

        public int getParametersNumber()
        {
            return 1;
        }

        public void setParameterValue(int parameterIndex, double parameterValue)
        {
                x = (float)parameterValue;
        }
    }

    public class faSquareWave : FunctionExtension
    {
        float x;

        float freq;
        int iterations;

        public faSquareWave()
        {
            x = 0;
        }
        public faSquareWave(double x, float freq, int iterations)
        {
            this.x = (float)x;
            this.freq = freq;
            this.iterations = iterations;
        }

        public double calculate()
        {
            return PSD.i.fourierAproxSquareWave(x, freq, iterations);
        }

        public FunctionExtension clone()
        {
            return new faSquareWave(x, freq, iterations);
        }

        public string getParameterName(int parameterIndex)
        {
            if (parameterIndex == 0) return "x";
            if (parameterIndex == 1) return "freq";
            if (parameterIndex == 2) return "iterations";
            return null;
        }

        public int getParametersNumber()
        {
            return 3;
        }

        public void setParameterValue(int parameterIndex, double parameterValue)
        {
            if (parameterIndex == 0) x = (float)parameterValue;
            if (parameterIndex == 1) freq = (int)parameterValue;
            if (parameterIndex == 2) iterations = (int)parameterValue;
        }
    }

    public class faSawtoothWave : FunctionExtension
    {
        float x;

        float freq;
        int iterations;

        public faSawtoothWave()
        {
            x = 0;
        }
        public faSawtoothWave(double x, float freq, int iterations)
        {
            this.x = (float)x;
            this.freq = freq;
            this.iterations = iterations;
        }

        public double calculate()
        {
            return PSD.i.fourierAproxSawtoothWave(x, freq, iterations);
        }

        public FunctionExtension clone()
        {
            return new faSawtoothWave(x, freq, iterations);
        }

        public string getParameterName(int parameterIndex)
        {
            if (parameterIndex == 0) return "x";
            if (parameterIndex == 1) return "freq";
            if (parameterIndex == 2) return "iterations";
            return null;
        }

        public int getParametersNumber()
        {
            return 3;
        }

        public void setParameterValue(int parameterIndex, double parameterValue)
        {
            if (parameterIndex == 0) x = (float)parameterValue;
            if (parameterIndex == 1) freq = (int)parameterValue;
            if (parameterIndex == 2) iterations = (int)parameterValue;
        }
    }

    public class faTriangleWave : FunctionExtension
    {
        float x;

        float freq;
        int iterations;

        public faTriangleWave()
        {
            x = 0;
        }
        public faTriangleWave(double x, float freq, int iterations)
        {
            this.x = (float)x;
            this.freq = freq;
            this.iterations = iterations;
        }

        public double calculate()
        {
            return PSD.i.fourierAproxTriangleWave(x, freq, iterations);
        }

        public FunctionExtension clone()
        {
            return new faTriangleWave(x, freq, iterations);
        }

        public string getParameterName(int parameterIndex)
        {
            if (parameterIndex == 0) return "x";
            if (parameterIndex == 1) return "freq";
            if (parameterIndex == 2) return "iterations";
            return null;
        }

        public int getParametersNumber()
        {
            return 3;
        }

        public void setParameterValue(int parameterIndex, double parameterValue)
        {
            if (parameterIndex == 0) x = (float)parameterValue;
            if (parameterIndex == 1) freq = (int)parameterValue;
            if (parameterIndex == 2) iterations = (int)parameterValue;
        }
    }
}
