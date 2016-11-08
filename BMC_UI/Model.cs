using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Z3_BMC
{

    class Model
    {
        int event_num;
        int statu_num;
        public LinkedList<String> events;
        public LinkedList<String> status;
        public LinkedList<String> others;
        public Cell[] cells;
        public Model(int en, int sn)
        {
            event_num = en;
            statu_num = sn;
                
            events = new LinkedList<String>();
            status = new LinkedList<String>();
            others = new LinkedList<String>();
        }
        public void addEvent(String v)
        {
            events.AddLast(v);
        }
        public void addStatu(String v)
        {
            status.AddLast(v);
        }
        public void addOther(String v)
        {
            others.AddLast(v);
        }
        public int getEventNum()
        {
            return event_num;
        }
        public int getStatusNum()
        {
            return statu_num;
        }
        public String[] getVarName()
        {
            String[] temp = new String[events.Count + status.Count + others.Count];
            int cur = 0;
            foreach (string v in events)
            {
                temp[cur++] = v.Split(' ')[0];
            }
            foreach (string v in status)
            {
                temp[cur++] = v.Split(' ')[0];
            }
            foreach (string v in others)
            {
                temp[cur++] = v.Split(' ')[0];
            }
            return temp;
        }
        public String[] getEventsName()
        {
            String[] temp = new String[events.Count];
            int cur = 0;
            foreach (string v in events)
            {
                temp[cur++] = v.Split(' ')[0];
            }
            return temp;

        }
        public String[] getVar(int step)
        {
            String[] temp = new String[events.Count + status.Count + others.Count];
            int cur = 0;
            foreach (string v in events)
            {
                temp[cur++] = " " + v.Split(' ')[0] + "_" + step + " " + v.Split(' ')[1];
            }
            foreach (string v in status)
            {
                temp[cur++] = " " + v.Split(' ')[0] + "_" + step + " " + v.Split(' ')[1];
            }
            foreach (string v in others)
            {
                temp[cur++] = " " + v.Split(' ')[0] + "_" + step + " " + v.Split(' ')[1];
            }
            return temp;
        }
        public String getInitVar(int step)
        {
            String temp = "(and";
            foreach (string v in events)
            {
                temp += "(= ";
                temp += v.Split(' ')[0] + "_" + step + " " + v.Split()[2];
                temp += ")";
            }
            foreach (string v in status)
            {
                temp += "(= ";
                temp += v.Split(' ')[0] + "_" + step + " " + v.Split()[2];
                temp += ")";
            }
            foreach (string v in others)
            {
                temp += "(= ";
                temp += v.Split(' ')[0] + "_" + step + " " + v.Split()[2];
                temp += ")";
            }
            return temp + ")";
        }

        public String[] getCell(int step)
        {
            if(step <= 0)
            {
                String[] initVar = new String[1];
                initVar[0] = getInitVar(0);
                return initVar;
            }
            String[] temp = new String[cells.Length];//some err.
            int tempCur = 0;
            
            foreach (Cell v in cells)
            {
                if (v != null)
                temp[tempCur++] = v.getStep(step);
            }
            return temp;
        }
    }
    class Cell
    {
        private String stat;
        private String even;
        private PS p;
        public Cell(String stat, String even)
        {
            this.stat = stat;
            this.even = even;
        }
        public void addProcess(PS p)
        {
            this.p = p;
        }
        private String getIf(int step)
        {
            String temp = "(and ";
            //smt
            temp += "(= ";
            temp += stat + "_" + step + " ";
            temp += "true";
            temp += ")";

            temp += "(= ";
            temp += even + "_" + step + " ";
            temp += "true";
            temp += ")";

            return temp + ")";
        }
        public String getStep(int step)
        {
            String temp = "(";
            temp += "=>"; //in smt mean if-then

            temp += this.getIf(step-1);//???
            temp += p.getStep(step);

            return temp + ")";
        }
    }
    class PS
    {
        LinkedList<string> processIf;
        LinkedList<string> processThen;
        LinkedList<string> processElse;
        String[] varsName;
        public PS(String[] varsName)
        {
            this.varsName = varsName;
            processIf = null;
            processThen = null;
            processElse = null;

        }
        public void addIf(String _if_)
        {
            if (processIf == null)
            {
                processIf = new LinkedList<string>();
            }
            processIf.AddLast(_if_);
        }
        public void addThen(String _then_)
        {
            if (processThen == null)
            {
                processThen = new LinkedList<string>();
            }
            processThen.AddLast(_then_);
        }
        public void addElse(String _else_)
        {
            if (processElse == null)
            {
                processElse = new LinkedList<string>();
            }
            processThen.AddLast(_else_);
        }
        private String getIf(int step)
        {
            String temp = "(and ";
            //smt
            temp += addTag(processIf, step);
            return temp + ")";
        }
        private String getThen(int step)
        {
            String temp = "(and ";
            //smt
            temp += addTag(processThen, step);
            
            return temp + ")";
        }
        private String getElse(int step)  
        {
            String temp = "(and ";
            //smt
            temp += addTag(processElse, step);
            return temp + ")";
        }
        private String addTag(LinkedList<string> process, int step)
        {
            String result = "";
            String tag_cur = "_" + step;
            String tag_pre = "_" + (step - 1);
            bool[] mark = new bool[varsName.Length];
            for (int i = 0; i < mark.Length; i++)//mark var is changed.
                mark[i] = false;
            foreach(var p in process)
            {
                String temp = p;
                for(int i = 0; i < varsName.Length; i++)
                {
                    int index = temp.IndexOf(varsName[i]);
                    while (index >= 0) {
                        if (index <= 2)
                        {
                            mark[i] = true;
                            temp = temp.Insert(index + varsName[i].Length, tag_cur);
                        }
                        else {
                            if (!mark[i])
                            {
                                temp = temp.Insert(index + varsName[i].Length, tag_pre);
                            }
                            else
                            {
                                temp = temp.Insert(index + varsName[i].Length, tag_pre);
                            }
                        }
                        index = temp.IndexOf(varsName[i], index + varsName[i].Length);
                    }
                }
                result += "(" + temp + ")";
                
            }
            for (int i = 0; i < varsName.Length; i++)
            {
                if (!mark[i])
                    result += "(= " + varsName[i] + tag_cur + " " + varsName[i] + tag_pre + ")";
            }

            return result;

        }
        public String getStep(int step)
        {
            String temp = "";
            if(processIf == null)
            {
                temp += getThen(step);
                return temp;
            }

            if (processElse == null)
            {
                temp += "(=> ";//in smt mean if-then
                temp += getIf(step);
                temp += getThen(step);
                temp += ")";
            }
            else
            {
                temp += "(ite ";//in smt mean if-then-else
                temp += getIf(step);
                temp += getThen(step);
                temp += getElse(step);
                temp += ")";
            }
            return temp;

        }
    }

}
