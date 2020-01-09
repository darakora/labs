using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18
{
    public class Formula
    {
        public FuncType type;
        public object value;
    }
    public enum FuncType
    {
        Max,
        Min,
        num
    }
    class Lab17_1
    {
        public static int Calc(Formula frm)
        {
            int res = 0;
            switch (frm.type)
            {
                case FuncType.Max:
                case FuncType.Min:
                    {
                        res = frm.type == FuncType.Min ? int.MaxValue : int.MinValue;
                        Stack nStack = (Stack)frm.value;
                        while (nStack.Count > 0)
                        {
                            object val = nStack.Pop();
                            int value = 0;
                            if (val.GetType() == typeof(Formula)) value = Calc((Formula)val);
                            if (val.GetType() == typeof(int)) value = (int)val;

                            if (frm.type == FuncType.Min)
                                res = value < res ? value : res;
                            else
                                res = value > res ? value : res;
                        }
                        return res;
                    }
                case FuncType.num:
                    {
                        return (int)frm.value;
                    }
                default:
                    {
                        throw new Exception("Unknown func");
                    }
            }
        }

        public static Formula Parse(string line, ref int position)
        {
            while (position < line.Length)
            {
                if (line[position].ToString().ToUpper() == "M")
                {
                    Stack param = new Stack();
                    Formula frm = new Formula() { type = line[position] == 'M' ? FuncType.Max : FuncType.Min, value = param };
                    if (line[++position] == '(')
                    {
                        while (line[position++] != ')')
                            param.Push(Parse(line, ref position));
                    }
                    else throw new Exception("Func line error at pos " + position);
                    return frm;
                }
                else
                    if (char.IsDigit(line[position]))
                {
                    string par = "";
                    while (char.IsDigit(line[position]))
                    {
                        par += line[position++];
                    }
                    Formula res = new Formula() { type = FuncType.num, value = Convert.ToInt32(par) };
                    return res;
                }
                else
                    throw new Exception("Func line error at pos " + position);

            }
            return null;
        }
    }
}
