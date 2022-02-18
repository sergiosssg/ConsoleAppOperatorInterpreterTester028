using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleAppOperatorInterpreterTester028
{
    class Program
    {

        static public readonly IEnumerable<TEL_VID_CONNECT> TEL_VID_CONNECTs = PrepareCollectionByPopulationOf_TEL_VID_CONNECT();


        static public readonly IDictionary<OperatorSignComparision, DelegateOperatorForComparision<TEL_VID_CONNECT>> MapComparisioOperatorToComparisionPredicate = new Dictionary<OperatorSignComparision, DelegateOperatorForComparision<TEL_VID_CONNECT>>()
        {
            { OperatorSignComparision._EQ_, (arg1, arg2, operatorComparision)=> ( operatorComparision == OperatorSignComparision._EQ_) && (( arg1.Id == arg2.Id ) || ( arg1.KodOfConnect.Equals(arg2.KodOfConnect) ) || ( arg1.Name.Equals( arg2.Name))) },
            { OperatorSignComparision._NE_, (arg1, arg2, operatorComparision)=> ( operatorComparision == OperatorSignComparision._NE_) && (( arg1.Id != arg2.Id ) && ( !arg1.KodOfConnect.Equals(arg2.KodOfConnect) ) && ( !arg1.Name.Equals( arg2.Name))) },
            { OperatorSignComparision._GT_, (arg1, arg2, operatorComparision)=> { 
                                                                 return ( operatorComparision == OperatorSignComparision._GT_) && 
                                                                              (( arg1.Id > arg2.Id ) || (string.Compare(arg1.KodOfConnect, arg2.KodOfConnect, StringComparison.OrdinalIgnoreCase) > 0) || (string.Compare(arg1.Name, arg2.Name, StringComparison.OrdinalIgnoreCase) > 0)); } },
            { OperatorSignComparision._LT_, (arg1, arg2, operatorComparision)=> { 
                                                                 return ( operatorComparision == OperatorSignComparision._LT_) &&
                                                                              (( arg1.Id < arg2.Id ) || (string.Compare(arg1.KodOfConnect, arg2.KodOfConnect, StringComparison.OrdinalIgnoreCase) < 0) || (string.Compare(arg1.Name, arg2.Name, StringComparison.OrdinalIgnoreCase) < 0)); } },
            { OperatorSignComparision._GE_, (arg1, arg2, operatorComparision)=> { 
                                                                 return ( operatorComparision == OperatorSignComparision._GE_) &&
                                                                              (( arg1.Id >= arg2.Id ) || (string.Compare(arg1.KodOfConnect, arg2.KodOfConnect, StringComparison.OrdinalIgnoreCase) >= 0) || (string.Compare(arg1.Name, arg2.Name, StringComparison.OrdinalIgnoreCase) >= 0)); } },
            { OperatorSignComparision._LE_, (arg1, arg2, operatorComparision)=> { 
                                                                 return ( operatorComparision == OperatorSignComparision._LE_) &&
                                                                              (( arg1.Id <= arg2.Id ) || (string.Compare(arg1.KodOfConnect, arg2.KodOfConnect, StringComparison.OrdinalIgnoreCase) <= 0) || (string.Compare(arg1.Name, arg2.Name, StringComparison.OrdinalIgnoreCase) <= 0)); } },
            { OperatorSignComparision._REGEX_, (arg1, arg2, operatorComparision)=> { 
                                                                 var regexTemplate = (arg2.KodOfConnect != string.Empty)? new Regex(arg2.KodOfConnect, RegexOptions.IgnoreCase) : (arg2.Name != string.Empty)? new Regex(arg2.Name, RegexOptions.IgnoreCase) : new Regex(""); 
                                                                 return ( operatorComparision == OperatorSignComparision._REGEX_) && 
                                                                              ( arg1.KodOfConnect != null  &&   !arg1.KodOfConnect.Equals(string.Empty) && regexTemplate.IsMatch(arg1.KodOfConnect) ||  
                                                                              ( arg1.Name != null  &&   !arg1.Name.Equals(string.Empty) &&  regexTemplate.IsMatch( arg1.Name))); }}
        };

        static public CriteriaOfFilter<TEL_VID_CONNECT> CriteriaOfFilterCollection = PrepareCollectionOfComparisionCriteria();


        public readonly static IDictionary<string, OperatorSignComparision> OperatorSignComparisionStrings = new Dictionary<string, OperatorSignComparision>
        {
            {  "=?=", OperatorSignComparision._REGEX_ },
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
            { "AND NOT", OperatorSignLogic._AND_NOT_},
            { "OR NOT", OperatorSignLogic._OR_NOT_}
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

        static CriteriaOfFilter<TEL_VID_CONNECT> PrepareCollectionOfComparisionCriteria()
        {
            CriteriaOfFilter<TEL_VID_CONNECT> collectionOfCriteria = new CriteriaOfFilter<TEL_VID_CONNECT>();


            /*collectionOfCriteria.Add(OperatorSignComparision._EQ_, null);
            collectionOfCriteria.Add();
            collectionOfCriteria.Add();
            collectionOfCriteria.Add();
            collectionOfCriteria.Add();
            collectionOfCriteria.Add();
            collectionOfCriteria.Add();
            collectionOfCriteria.Add();
            collectionOfCriteria.Add();
            collectionOfCriteria.Add();*/


            return collectionOfCriteria;
        }

    }
}
