using System;
using System.Collections.Generic;

namespace ConsoleAppOperatorInterpreterTester028
{
    class Program
    {

        public readonly static IDictionary<string, OperatorSignComparision> OperatorSignComparisionStrings = new Dictionary<string, OperatorSignComparision>
        {
            {  "==", OperatorSignComparision._EQ_ },
            { "!=", OperatorSignComparision._NE_},
            { ">", OperatorSignComparision._GT_},
            { "<", OperatorSignComparision._LT_},
            { ">=", OperatorSignComparision._GE_},
            { "<=", OperatorSignComparision._LE_},
            { "<= .. >=", OperatorSignComparision._BETWEEN_NO_STRICT_},
            { "< .. >", OperatorSignComparision._BETWEEN_STRICT_},
            { "< .. >=", OperatorSignComparision._BETWEEN_STRICT_LEFT_},
            { "<= .. >", OperatorSignComparision._BETWEEN_STRICT_RIGHT_}
        };



        public readonly static IDictionary<string, OperatorSignLogic> OperatorSignLogicStrings = new Dictionary<string, OperatorSignLogic>
        {
            { "AND", OperatorSignLogic._AND_ },
            { "OR", OperatorSignLogic._OR_},
            { "NOT", OperatorSignLogic._NOT_}
        };



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ;
        }
    }
}
