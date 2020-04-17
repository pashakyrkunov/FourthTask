using System;
using System.IO;

namespace Task4
{
   
    class Program
    {
        
        private static string appName = "fabric.sql";

        private static string extension = Path.GetExtension(appName);

        public static void Main()
        {
            Parameters param;
            if (extension == ".js")
            {
                param = new Parameters(new JSApp());
                param.Output();
            }
            else if (extension == ".cs")
            {
                param = new Parameters(new cSharpApp());
                param.Output();
            }
            else if (extension == ".sql")
            {
                param = new Parameters(new SQLApp());
                param.Output();
            }
            else
            {
                Console.WriteLine("no parameters of this type");
            }
        }
    }

    /// <summary>
    /// Abstract fabric class
    /// </summary>
    abstract class AppFactory
    {
        /// <summary>
        /// Get Color
        /// </summary>
        /// <returns>string with parameter of color</returns>
        public abstract string Color();

        /// <summary>
        /// Get Cursor
        /// </summary>
        /// <returns>string with parameter of cursor</returns>
        public abstract string Cursor();

        /// <summary>
        /// Get height
        /// </summary>
        /// <returns>string with parameter of height</returns>
        public abstract string Height();

        /// <summary>
        /// Get width
        /// </summary>
        /// <returns>string with parameter of width</returns>
        public abstract string Width();

        /// <summary>
        /// Get resolution
        /// </summary>
        /// <returns>string with parameter of resolution</returns>
        public abstract string Resolution();

        /// <summary>
        /// Get display
        /// </summary>
        /// <returns>string with parameter of Display</returns>
        public abstract string Display();

        /// <summary>
        /// Get codeInsight
        /// </summary>
        /// <returns>string with parameter of Insight of Code</returns>
        public abstract string CodeInsight();

        /// <summary>
        /// Get consoleOn
        /// </summary>
        /// <returns>string with parameter of Console</returns>
        public abstract string ConsoleOn();

        /// <summary>
        /// Get autoCorrect
        /// </summary>
        /// <returns>string with parameter of AutoCorrection</returns>
        public abstract string AutoCorrect();

        /// <summary>
        /// Get forms
        /// </summary>
        /// <returns>string with parameter of Forms</returns>
        public abstract string Forms();
    }

    /// <summary>
    /// Factory for an application of C#
    /// </summary>
    class cSharpApp : AppFactory
    {
        
        public override string Color()
        {
            return "red";
        }

        public override string Height()
        {
            return "200";
        }

        public override string Width()
        {
            return "200";
        }

        public override string Resolution()
        {
            return "2160p";
        }

        public override string Cursor()
        {
            return "no";
        }

        public override string Forms()
        {
            return "b,a,c";
        }

        public override string CodeInsight()
        {
            return "no";
        }

        public override string AutoCorrect()
        {
            return "on";
        }

        public override string ConsoleOn()
        {
            return "no";
        }

        public override string Display()
        {
            return "on";
        }
    }

    /// <summary>
    /// Factory for an application of SQL
    /// </summary>
    class SQLApp : AppFactory
    {

        public override string Color()
        {
            return "deep blue";
        }

        public override string Height()
        {
            return "4190";
        }

        public override string Width()
        {
            return "4190";
        }

        public override string Resolution()
        {
            return "8196p";
        }

        public override string Cursor()
        {
            return "on";
        }

        public override string Forms()
        {
            return "c,a,b";
        }

        public override string CodeInsight()
        {
            return "yes";
        }

        public override string AutoCorrect()
        {
            return "no";
        }

        public override string ConsoleOn()
        {
            return "yes";
        }

        public override string Display()
        {
            return "no";
        }
    }

    /// <summary>
    /// Factory for an application of HTML
    /// </summary>
    class JSApp : AppFactory
    {

        public override string Color()
        {
            return "blue";
        }

        public override string Height()
        {
            return "100";
        }

        public override string Width()
        {
            return "100";
        }

        public override string Resolution()
        {
            return "1080p";
        }

        public override string Cursor()
        {
            return "on";
        }

        public override string Forms()
        {
            return "a,b,c";
        }

        public override string CodeInsight()
        {
            return "yes";
        }

        public override string AutoCorrect()
        {
            return "on";
        }

        public override string ConsoleOn()
        {
            return "no";
        }

        public override string Display()
        {
            return "on";
        }
    }

    /// <summary>
    /// The constructor to all factories
    /// </summary>
    class Parameters
    {
        private string color;

        private string display;

        private string forms;

        private string autoCorrect;

        private string consoleOn;

        private string codeInsight;

        private string cursor;

        private string resolution;

        private string width;

        private string height;

        /// <summary>
        /// override variables
        /// </summary>
        /// <param name="factory">the element of abstract factory</param>
        public Parameters(AppFactory factory)
        {
            color = factory.Color();
            display = factory.Display();
            forms = factory.Forms();
            autoCorrect = factory.AutoCorrect();
            consoleOn = factory.ConsoleOn();
            codeInsight = factory.CodeInsight();
            cursor = factory.Cursor();
            resolution = factory.Resolution();
            width = factory.Width();
            height = factory.Height();
        }


        public void Output()
        {
            Console.WriteLine(" Color = " + color +
                              "\n Display = " + display +
                              "\n Forms = " + forms +
                              "\n AutoCorrect = " + autoCorrect +
                              "\n ConsoleOn = " + consoleOn +
                              "\n CodeInsight = " + codeInsight +
                              "\n Cursor = " + cursor +
                              "\n Resolution = " + resolution +
                              "\n Width = " + width +
                              "\n Height = " + height
            );
        }
    }
}