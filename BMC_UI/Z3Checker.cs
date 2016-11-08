using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3_BMC
{
    using System.Diagnostics;
    using System.IO;

    class Z3Command
    {
        public const String dc = "declare-const ";
        public const String assert = "assert ";
        public const String check = "check-sat ";
        public const String push = "push ";
        public const String pop = "pop ";
        public const String getmodel = "get-model ";
        public const String getValue = "get-value ";
        public const String exit = "exit ";
    }
    class Z3Checker
    {
        Process z3Process;
        StreamReader reader;
        StreamWriter writer;

        private const String exe = "\\bin\\z3.exe";
        private const String arg = "-smt2 -in";

        public Z3Checker(String path)
        {
            z3Process = new Process();
            z3Process.StartInfo.UseShellExecute = false;
            z3Process.StartInfo.RedirectStandardOutput = true;
            z3Process.StartInfo.RedirectStandardInput = true;
            z3Process.StartInfo.FileName = path + exe;
            z3Process.StartInfo.Arguments = arg;
            z3Process.Start();
            reader = z3Process.StandardOutput;
            writer = z3Process.StandardInput;
        }
        private void writeCommand(String command)
        {
            command = "(" + command + ")";

            //debug 
            //Console.WriteLine(command);
            /*
            using (StreamWriter sw = new StreamWriter(File.Open("d:\\debug_in.txt",FileMode.Append)))
            {
                sw.WriteLine(command);
            }
            */
            writer.WriteLine(command);
        }
        private String readResult()
        {
            String result = reader.ReadLine();
            /*
            using (StreamWriter sw = new StreamWriter(File.Open("d:\\debug_out.txt", FileMode.Append)))
            {
                sw.WriteLine(result);
            }
            */
            //debug
            //Console.WriteLine(z3Process.WorkingSet64);

            return result;//read result from standard output.
        }
        public void declareConst(String[] vars)
        {
            foreach (String v in vars)
            {
                writeCommand(Z3Command.dc + v);
            }

        }

        public void assert(String ass)
        {
            writeCommand(Z3Command.assert + ass);
        }
        public void declareModel(String[] models)//批量定义模型结构
        {
            foreach (String m in models)
            {
                writeCommand(Z3Command.assert + m);
            }
        }
        public String check()
        {
            writeCommand(Z3Command.check);

            String r = readResult();
       
            return r;
        }
        public String getValue(String name)
        {
            writeCommand(Z3Command.getValue + "(" + name + ")");
            return readResult();
        }
        public String[] getValue(String[] names)
        {
            String[] values = new String[names.Length];
            int cur = 0;
            foreach (var n in names)
                values[cur++] = getValue(n);
            return values;
        }

        public String getModel()
        {
            writeCommand(Z3Command.getmodel);
            return readResult();
        }
        public void exit()//结束时调用exit()方法退出Z3工具进程
        {
            Console.WriteLine(z3Process.PeakWorkingSet64);
            Console.WriteLine(z3Process.PeakVirtualMemorySize64);
            Console.WriteLine(z3Process.PeakPagedMemorySize64);
            writeCommand(Z3Command.exit);
        }
    }

}
