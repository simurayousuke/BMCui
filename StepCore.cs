using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3_BMC
{
    class Context
    {
        private Model model;
        private Z3Checker checker;
        private char descriptor;
        private String attribute;

        private int maxStep { set; get; }
        private int curStep { set; get; }

        private LinkedList<String[]> pathSet;

        public Context(Model model)
        {
            this.model = model;
            this.curStep = 0;
            checker = new Z3Checker("D:\\MyDocument\\ModelCheck\\Z3\\z3-4.3.2-x64-win");
            pathSet = new LinkedList<string[]>();
        }

        public void setMaxStep(int ms)
        {
            this.maxStep = ms;
        }
        public void addChecker(String att, char S)
        {
            this.attribute = att;
            this.descriptor = S;

        }
        public void selectXEvent(int step)
        {
            String[] events = model.getEventsName();
            int randomEventNum = new Random().Next(0, events.Length);
            Console.WriteLine("select XEvent:" + events[randomEventNum]);
            String randomEvent = events[randomEventNum];//随机选取事件
            checker.assert("(= " + addTag(randomEvent, step) + " true)");
        }
        private void checkG()
        {
            while (curStep < maxStep)
            {
                String curAtt = "(" + addTag(attribute, curStep) + ")";

                if (!checkStep(curStep, curAtt))
                {
                    Console.WriteLine("find error.");
                    break;
                }

                String[] curStatus = checker.getValue(addVarTag(model.getVarName(), curStep));
                pathSet.AddLast(curStatus);
                foreach (var v in curStatus)
                {
                    Console.WriteLine(v);
                }

                String[] eventStatus = getEventStatus(curStep);
                if (!hasActivityEvent(eventStatus))
                {
                    selectXEvent(curStep);
                }
                curStep++;
            }
            if (curStep < maxStep)
                Console.WriteLine("get unsat");
            printPath();

        }
        private void checkF()
        {
            while (curStep < maxStep)
            {
                String curAtt = "(not(or";
                curAtt += " (" + addTag(attribute, curStep) + ")";
                curAtt += " false))";
                Console.WriteLine(curAtt);//

                if (!checkStep(curStep, curAtt))
                {
                    Console.WriteLine("find path.");
                    break;
                }

                String[] curStatus = checker.getValue(addVarTag(model.getVarName(), curStep));
                pathSet.AddLast(curStatus);
                foreach (var v in curStatus)
                {
                    Console.WriteLine(v);
                }

                String[] eventStatus = getEventStatus(curStep);
                if (!hasActivityEvent(eventStatus))
                {
                    //路径可能不应随机选择
                    selectXEvent(curStep);
                }
                curStep++;
            }
            if (curStep >= maxStep)
                Console.WriteLine("no this path in this step.");
            else
                printPath();
        }
        private void checkE()
        {
            while (curStep < maxStep)
            {
                String curAtt = "(not(or";
                //为何要将所有之前的状态与在一起
                for (int i = 0; i <= curStep; i++)
                    curAtt += " (" + addTag(attribute, i) + ")";
                curAtt += " false))";

                if (!checkStep(curStep, curAtt))
                {
                    Console.WriteLine("find path.");
                    break;
                }

                String[] curStatus = checker.getValue(addVarTag(model.getVarName(), curStep));
                pathSet.AddLast(curStatus);
                foreach (var v in curStatus)
                {
                    Console.WriteLine(v);
                }

                String[] eventStatus = getEventStatus(curStep);
                if (!hasActivityEvent(eventStatus))
                {
                    selectXEvent(curStep);
                }
                curStep++;
            }
            if (curStep >= maxStep)
                Console.WriteLine("no this path in this step.");
            else
            {
                printPath();
            }
        }
        private void checkNull()
        {

        }
        public void printPath()
        {
            foreach (var path in pathSet)
            {
                foreach (var v in path)
                {
                    Console.Write(v + ",");
                }
                Console.WriteLine("->");
            }
        }
        public void startCheck()
        {
            switch (descriptor)
            {
                case 'G':
                    checkG();
                    break;
                case 'F':
                    checkF();
                    break;
                case 'E':
                    checkE();
                    break;
                default:
                    checkNull();
                    break;
            }
            checker.exit();
        }

        private bool checkStep(int step, String encode_att)
        {
            checker.declareConst(
                model.getVar(curStep));//定义Step变量

            checker.declareModel(
                model.getCell(curStep));//定义Step模型关系

            checker.assert(encode_att);//定义验证Step属性

            String result = checker.check();//检测Step结果
            Console.WriteLine(result);//debug
            return result.Equals("sat");
        }

        private String addTag(String v, int step)
        {
            String tag = "_" + step;
            foreach (String name in model.getVarName())
            {
                int index = v.IndexOf(name);
                while (index >= 0)
                {
                    v = v.Insert(index + name.Length, tag);
                    index = v.IndexOf(name, index + name.Length);
                }
            }

            return v;
        }
        private String[] addVarTag(String[] vars, int step)
        {
            String[] temp = new String[vars.Length];
            int cur = 0;
            foreach (var v in vars)
            {
                temp[cur++] = v + "_" + step;
            }
            return temp;
        }

        private String[] getEventStatus(int step)
        {
            String[] eventsName = addVarTag(model.getEventsName(), step);
            return checker.getValue(eventsName);
        }
        private bool hasActivityEvent(String[] events)
        {
            foreach (var s in events)
            {
                if (s.IndexOf("true") >= 0)
                    return true;
            }
            return false;
        }
    }
}
