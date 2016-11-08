using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3_BMC
{
    using System.IO;
    using System.Xml.Linq;
    class ModelLoader
    {
        public static Model getModel(String file)
        {

            //test class Model and class Z3Checker.
            Model model = new Model(2,2);
            model.addEvent("e0 Bool true");
            model.addEvent("e1 Bool false");
            model.addStatu("s0 Bool true");
            model.addStatu("s1 Bool false");
            model.addOther("v0 Int 0");
            model.addOther("v1 Int 0");
            model.addOther("v2 Int 0");

            model.cells = new Cell[4];

            Cell tempCell0 = new Cell("s0","e0");
            PS p0 = new PS(model.getVarName());
            p0.addThen("= v0 100");
            p0.addThen("= v1 0");
            p0.addThen("= v2 0");
            p0.addThen("= e0 true");
            p0.addThen("= e1 false");
            p0.addThen("= s0 false");
            p0.addThen("= s1 true");
            tempCell0.addProcess(p0);
            model.cells[0] = tempCell0;

            Cell tempCell1 = new Cell("s0","e1");
            PS p1 = new PS(model.getVarName());
            p1.addThen("= v1 (+ v1 v2)");
            p1.addThen("= v0 (- v0 v2)");
            p1.addThen("= e0 true");   
            p1.addThen("= e1 false");
            p1.addThen("= s0 false");
            p1.addThen("= s1 true");

            tempCell1.addProcess(p1);
            model.cells[1] = tempCell1;
            
            Cell tempCell2 = new Cell("s1","e0");
            PS p2 = new PS(model.getVarName());
            p2.addThen("= v1 10");
            p2.addThen("= v2 (+ v2 1)");
            p2.addThen("= v0 (- v0 v1)");
            p2.addThen("= e0 false");
            p2.addThen("= e1 true");
            p2.addThen("= s0 false");
            p2.addThen("= s1 true");
            tempCell2.addProcess(p2);
            model.cells[2] = tempCell2;

            Cell tempCell3 = new Cell("s1", "e1");
            PS p3 = new PS(model.getVarName());
            p3.addThen("= v1 (- v1 1)");
            p3.addThen("= e0 false");
            p3.addThen("= e1 true");
            p3.addThen("= s0 true");
            p3.addThen("= s1 false");
            tempCell3.addProcess(p3);
            model.cells[3] = tempCell3;



            return model;
        }
    }
    class XmlTag
    {
        public const String element_event = "event";
        public const String element_statu = "statu";
        public const String element_vars_int = "vars_int";
        public const String element_cell = "cell";
        public const String element_item = "item";
        public const String attribute_num = "num";
        public const String attribute_id = "id";
        public const String attribute_name = "name";
        public const String attribute_statu_id = "statu_id";
        public const String attribute_event_id = "event_id";
        public const String attribute_next_statu = "next_statu";
        public const String element_process = "process";
        public const String element_if = "if";
        public const String element_if_true = "if_true";
        public const String element_if_false = "if_false";
    }
    class SMTModel
    {
        private String file;

        public SMTModel(String file)
        {
            this.file = file;
        }
        
        public static String[] getVars(String modelFile)
        {
            XElement modelData = null;

            String[] allVar = null;
            String[] es = null;
            String[] ss = null;
            String[] ints = null;
            try
            {
                modelData = XElement.Load(modelFile);

                XElement events = modelData.Element(XmlTag.element_event);
                es = getEvents(events);
                XElement status = modelData.Element(XmlTag.element_statu);
                ss = getStatus(status);
                XElement vars = modelData.Element(XmlTag.element_vars_int);
                ints = getInts(vars);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetBaseException());
            }

            allVar = new String[es.Length + ss.Length + ints.Length];
            int i = 0;
            foreach (String s in es)
                allVar[i++] = s;
            foreach (String s in ss)
                allVar[i++] = s;
            foreach (String s in ints)
                allVar[i++] = s;

            return allVar;

        }
        private static String[] getEvents(XElement xe)
        {
            IEnumerable<XAttribute> items =
                xe.Elements(XmlTag.element_item).Attributes(XmlTag.attribute_name);
            int i = 0;
            String[] es = new String[Int32.Parse(xe.Attribute(XmlTag.attribute_num).Value)];//items.size()?
            foreach (XAttribute it in items)
            {
                es[i++] = it.Value + " Bool";
                //构造字符串 变量名 Bool
            }

            return es;
        }
        private static String[] getStatus(XElement xe)
        {
            IEnumerable<XAttribute> items =
                xe.Elements(XmlTag.element_item).Attributes(XmlTag.attribute_name);
            int i = 0;
            String[] ss = new String[Int32.Parse(xe.Attribute(XmlTag.attribute_num).Value)];//items.size()?
            foreach (XAttribute it in items)
            {
                ss[i++] = it.Value + " Bool";
                //构造字符串 变量名 Bool
            }
            return ss;
        }
        private static String[] getInts(XElement xe)
        {
            IEnumerable<XAttribute> items =
                xe.Elements(XmlTag.element_item).Attributes(XmlTag.attribute_name);
            int i = 0;
            String[] ints = new String[Int32.Parse(xe.Attribute(XmlTag.attribute_num).Value)];//items.size()?
            foreach (XAttribute it in items)
            {
                ints[i++] = it.Value + " Int";
                //构造字符串 变量名 Int
            }
            return ints;
        }
        public static String[] getSMTModel(String modelFile)
        {
            String[] model = null;

            return model;
        }
    }
    class CodeDOM
    {

        public static String addModel(String fwFile, String modelFile)
        {
            String modelFW = File.ReadAllText(fwFile);
            XElement modelData = null;
            try
            {
                modelData = XElement.Load(modelFile);

                XElement events = modelData.Element(XmlTag.element_event);
                modelFW = addEvent(modelFW, events);

                XElement status = modelData.Element(XmlTag.element_statu);
                modelFW = addStatus(modelFW, status);

                XElement vars_ints = modelData.Element(XmlTag.element_vars_int);
                modelFW = addVars(modelFW, vars_ints);

                IEnumerable<XElement> cells = modelData.Elements(XmlTag.element_cell);
                foreach (XElement xe in cells)
                {
                    modelFW = addCell(modelFW, xe, events);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetBaseException());
            }
            return modelFW;
        }

        private const String indexOf_event_num = "/*<event_num>*/";
        private const String indexOf_event = "/*<Event>*/";

        private const String char_enter = "\n";
        private const String char_tab = "\t";

        static String addEvent(String modelFW, XElement xe)
        {
            modelFW = modelFW.Insert(modelFW.IndexOf(indexOf_event_num), xe.Attribute(XmlTag.attribute_num).Value);

            String codeForEvents = char_enter + char_tab + "events = new Event[";
            codeForEvents += xe.Attribute(XmlTag.attribute_num).Value + "];" + char_enter;
            //产生语句 events = new Event[num];


            IEnumerable<XElement> items = xe.Elements(XmlTag.element_item);
            int i = 0;
            foreach (XElement it in items)
            {
                codeForEvents +=
                    char_tab + "events[" + i++ + "] = new Event(" +
                    it.Attribute(XmlTag.attribute_id).Value + ",\"" +
                    it.Attribute(XmlTag.attribute_name).Value + "\");" + char_enter;
                //产生语句 events[i] = new Event(id,name);
            }
            modelFW = modelFW.Insert(modelFW.IndexOf(indexOf_event) + indexOf_event.Length, codeForEvents);
            return modelFW;

        }

        private const String indexOf_statu_num = "/*<statu_num>*/";
        private const String indexOf_status = "/*<Status>*/";

        static String addStatus(String modelFW, XElement xe)
        {
            modelFW = modelFW.Insert(modelFW.IndexOf(indexOf_statu_num), xe.Attribute(XmlTag.attribute_num).Value);

            String codeForStatus = char_enter + char_tab + "status = new Status[";
            codeForStatus += xe.Attribute(XmlTag.attribute_num).Value + "];" + char_enter;
            //产生语句 status = new Status[num];

            IEnumerable<XElement> items = xe.Elements(XmlTag.element_item);
            int i = 0;
            foreach (XElement it in items)
            {
                codeForStatus +=
                    char_tab + "status[" + i++ + "]=new Status(" +
                    it.Attribute(XmlTag.attribute_id).Value + ",\"" +
                    it.Attribute(XmlTag.attribute_name).Value + "\");" + char_enter;
                //产生语句 status[i] = new Statu(id,name);
            }
            modelFW = modelFW.Insert(modelFW.IndexOf(indexOf_status) + indexOf_status.Length, codeForStatus);
            return modelFW;

        }
        private const String attribute_defultVar = "defultVar";
        private const String indexOf_vars = "/*<vars>*/";
        static String addVars(String modelFW, XElement xe)
        {
            String codeForVars = "" + char_enter;
            IEnumerable<XElement> items = xe.Elements(XmlTag.element_item);
            foreach (XElement it in items)
            {
                codeForVars +=
                    char_tab + "int " + it.Attribute(XmlTag.attribute_name).Value + " = " +
                    it.Attribute(attribute_defultVar).Value + ";" + char_enter;
                //产生语句 int name = value;
            }
            modelFW = modelFW.Insert(modelFW.IndexOf(indexOf_vars) + indexOf_vars.Length, codeForVars);
            return modelFW;

        }

        private const String indexOf_cell = "/*</Cell>*/";
    
        private const String char_dtab = "\t\t";

        static String addCell(String modelFW, XElement xe, XElement events)
        {
            String codeForCell = char_enter + char_tab + "cells[";

            codeForCell += xe.Attribute(XmlTag.attribute_statu_id).Value + "][" +
                xe.Attribute(XmlTag.attribute_event_id).Value + "]=new Cell(0);" + char_enter;
            //产生语句 cells[s][e] = new Cell(0);

            codeForCell += char_tab + "cells[" + xe.Attribute(XmlTag.attribute_statu_id).Value + "][" +
                xe.Attribute(XmlTag.attribute_event_id).Value + "].setAction(delegate (){" + char_enter;
            //产生语句 cells[s][e].setAction(delegate (){
            //          });
            // 第一行

            if (xe.Element(XmlTag.element_if).Value.Equals("true"))
            {
                XElement if_true = xe.Element(XmlTag.element_if_true);

                codeForCell += char_dtab + "cells[";
                codeForCell += xe.Attribute(XmlTag.attribute_statu_id).Value + "][" +
                    xe.Attribute(XmlTag.attribute_event_id).Value + "].nextStatus =" +
                    if_true.Attribute(XmlTag.attribute_next_statu).Value + ";" + char_enter;
                //产生语句 cells[s][e].nextStatus = next_status;

                IEnumerable<XElement> process = if_true.Elements(XmlTag.element_process);
                foreach (XElement p in process)
                {
                    int index = p.Value.IndexOf("=");
                    int event_id = -1;
                    String eventName = p.Value.Substring(0, index);
                    foreach (XElement e in events.Elements(XmlTag.element_item))
                    {
                        if (e.Attribute(XmlTag.attribute_name).Value.Equals(eventName))
                        {
                            event_id = Int32.Parse(e.Attribute(XmlTag.attribute_id).Value);
                        }
                    }
                    if (event_id >= 0)
                        codeForCell += char_dtab + "events[" + event_id + "].isActive" + p.Value.Substring(index) + ";" + char_enter;
                    //产生语句 events[e].isActive = true/false;
                    else
                        codeForCell += char_dtab + p.Value + ";" + char_enter;
                    //将原语句插入生成代码中
                }
                codeForCell += char_dtab + "}" + char_enter + char_tab + ");";
                //产生语句 cells[s][e].setAction(delegate (){
                //          });
                // 第二行
            }
            else
            {
                codeForCell += char_tab + "if(" + xe.Element(XmlTag.element_if).Value + "){" + char_enter;
                //产生语句 if(条件){
                //          }else{
                //          }
                //第一行

                XElement if_true = xe.Element(XmlTag.element_if_true);
                codeForCell += char_dtab + "cells[";
                codeForCell += xe.Attribute(XmlTag.attribute_statu_id).Value + "][" +
                    xe.Attribute(XmlTag.attribute_event_id).Value + "].nextStatus =" +
                    if_true.Attribute(XmlTag.attribute_next_statu).Value + ";" + char_enter;
                //产生语句 cells[s][e].nextStatus = next_statu;

                IEnumerable<XElement> processT = if_true.Elements(XmlTag.element_process);
                foreach (XElement p in processT)
                {
                    int index = p.Value.IndexOf("=");
                    int event_id = -1;
                    String eventName = p.Value.Substring(0, index);
                    foreach (XElement e in events.Elements(XmlTag.element_item))
                    {
                        if (e.Attribute(XmlTag.attribute_name).Value.Equals(eventName))
                        {
                            event_id = Int32.Parse(e.Attribute(XmlTag.attribute_id).Value);
                        }
                    }
                    if (event_id >= 0)
                        codeForCell += char_dtab + "events[" + event_id + "].isActive" +
                            p.Value.Substring(index) + ";" + char_enter;
                    //产生语句 events[e].isActive = true/false;
                    else
                        codeForCell += char_dtab + p.Value + ";" + char_enter;
                    //将原语句插入生成代码中
                }

                codeForCell += char_tab + "}else{" + char_enter;
                //产生语句 if(条件){
                //          }else{
                //          }
                //第二行

                XElement if_false = xe.Element(XmlTag.element_if_false);
                codeForCell += char_dtab + "cells[";
                codeForCell += xe.Attribute(XmlTag.attribute_statu_id).Value + "][" +
                    xe.Attribute(XmlTag.attribute_event_id).Value + "].nextStatus =" +
                    if_false.Attribute(XmlTag.attribute_next_statu).Value + ";" + char_enter;
                //产生语句 cells[s][e].nextStatus = next_statu;

                IEnumerable<XElement> processF = if_false.Elements(XmlTag.element_process);
                foreach (XElement p in processF)
                {
                    int index = p.Value.IndexOf("=");
                    int event_id = -1;
                    String eventName = p.Value.Substring(0, index);
                    foreach (XElement e in events.Elements(XmlTag.element_item))
                    {
                        if (e.Attribute(XmlTag.attribute_name).Value.Equals(eventName))
                        {
                            event_id = Int32.Parse(e.Attribute(XmlTag.attribute_id).Value);
                        }
                    }
                    if (event_id >= 0)
                        codeForCell += char_dtab + "events[" + event_id + "].isActive" +
                            p.Value.Substring(index) + ";" + char_enter;
                    //产生语句 events[e].isActive = true/false;
                    else
                        codeForCell += char_dtab + p.Value + ";" + char_enter;
                    //将原语句插入生成代码中
                }
                codeForCell += char_dtab + "}" + char_enter + char_tab + "});";
                //产生语句 if(条件){
                //          }else{
                //          }
                //第三行
                //产生语句 cells[s][e].setAction(delegate (){
                //          });
                // 第二行
            }
            modelFW = modelFW.Insert(modelFW.IndexOf(indexOf_cell), codeForCell);
            return modelFW;
        }
    }
}
