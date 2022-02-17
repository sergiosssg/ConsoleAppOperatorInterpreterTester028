using System;
using System.Collections.Generic;

namespace ConsoleAppOperatorInterpreterTester028
{
    class Program
    {

        static public readonly IEnumerable<TEL_VID_CONNECT> TEL_VID_CONNECTs = PrepareCollectionByPopulationOf_TEL_VID_CONNECT();



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



        static ICollection<TEL_VID_CONNECT> PrepareCollectionByPopulationOf_TEL_VID_CONNECT()
        {
            var tel_vid_connects = new List<TEL_VID_CONNECT>();

            var firstElement = new TEL_VID_CONNECT();
            firstElement.Id = 1; firstElement.KodOfConnect = "02"; firstElement.Name = "Мобильная связь";
            tel_vid_connects.Add(firstElement);
            var secondElement = new TEL_VID_CONNECT();
            secondElement.Id = 2; secondElement.KodOfConnect = "03"; secondElement.Name = "Укрталеком";
            tel_vid_connects.Add(secondElement);
            var thirdElement = new TEL_VID_CONNECT();
            thirdElement.Id = 3; thirdElement.KodOfConnect = "04"; thirdElement.Name = "Сервис";
            tel_vid_connects.Add(thirdElement);
            var forthElement = new TEL_VID_CONNECT();
            forthElement.Id = 4; forthElement.KodOfConnect = "05"; forthElement.Name = "Телефония";
            tel_vid_connects.Add(forthElement);
            var fifthElement = new TEL_VID_CONNECT();
            fifthElement.Id = 5; fifthElement.KodOfConnect = "02"; fifthElement.Name = "Стационарная связь";
            tel_vid_connects.Add(fifthElement);
            var sixtthElement = new TEL_VID_CONNECT();
            sixtthElement.Id = 6; sixtthElement.KodOfConnect = "03"; sixtthElement.Name = "Водафон";
            tel_vid_connects.Add(sixtthElement);
            var seventhElement = new TEL_VID_CONNECT();
            seventhElement.Id = 7; seventhElement.KodOfConnect = "03"; seventhElement.Name = "Kiiv Star";
            tel_vid_connects.Add(seventhElement);
            var eightthElement = new TEL_VID_CONNECT();
            eightthElement.Id = 8; eightthElement.KodOfConnect = "08"; eightthElement.Name = "Сервис";
            tel_vid_connects.Add(eightthElement);

            return tel_vid_connects;
        }


    }
}
