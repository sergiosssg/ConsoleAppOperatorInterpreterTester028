using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleAppOperatorInterpreterTester028
{
    class Program
    {

        static public readonly IEnumerable<TEL_VID_CONNECT> TEL_VID_CONNECTs = PrepareCollectionByPopulationOf_TEL_VID_CONNECT();


        static public readonly IDictionary<OperatorSignComparision, DelegateOperatorForComparision<TEL_VID_CONNECT>> MapComparisioOperatorToComparisionPredicate = new Dictionary<OperatorSignComparision, DelegateOperatorForComparision<TEL_VID_CONNECT>>()
        {
            { OperatorSignComparision._EQ_, (arg1, arg2, operatorComparision)=> ( operatorComparision == OperatorSignComparision._EQ_) &&
                                                                                (( arg1.Id == arg2.Id ) ||
                                                                                ( arg2.KodOfConnect != string.Empty  && arg1.KodOfConnect.Equals(arg2.KodOfConnect) ) ||
                                                                                ( arg2.Name != string.Empty && arg1.Name.Equals( arg2.Name))) },
            { OperatorSignComparision._NE_, (arg1, arg2, operatorComparision)=> ( operatorComparision == OperatorSignComparision._NE_) &&
                                                                                (( arg1.Id != arg2.Id ) &&
                                                                                ( arg2.KodOfConnect != string.Empty && !arg1.KodOfConnect.Equals(arg2.KodOfConnect) ) &&
                                                                                ( arg2.Name != string.Empty && !arg1.Name.Equals( arg2.Name))) },
            { OperatorSignComparision._GT_, (arg1, arg2, operatorComparision)=> {
                                                                 return ( operatorComparision == OperatorSignComparision._GT_) &&
                                                                              (( arg1.Id > arg2.Id ) ||
                                                                              (arg2.KodOfConnect != string.Empty &&
                                                                              string.Compare(arg1.KodOfConnect, arg2.KodOfConnect, StringComparison.OrdinalIgnoreCase) > 0) ||
                                                                              ( arg2.Name != string.Empty &&
                                                                              string.Compare(arg1.Name, arg2.Name, StringComparison.OrdinalIgnoreCase) > 0)); } },
            { OperatorSignComparision._LT_, (arg1, arg2, operatorComparision)=> {
                                                                 return ( operatorComparision == OperatorSignComparision._LT_) &&
                                                                              ( ( arg1.Id > arg2.Id ) ||
                                                                              (arg2.KodOfConnect != string.Empty &&
                                                                              string.Compare(arg1.KodOfConnect, arg2.KodOfConnect, StringComparison.OrdinalIgnoreCase) < 0) ||
                                                                              ( arg2.Name != string.Empty  &&
                                                                              string.Compare(arg1.Name, arg2.Name, StringComparison.OrdinalIgnoreCase) < 0)); } },
            { OperatorSignComparision._GE_, (arg1, arg2, operatorComparision)=> {
                                                                 return ( operatorComparision == OperatorSignComparision._GE_) &&
                                                                              (( arg1.Id >= arg2.Id ) ||
                                                                              (arg2.KodOfConnect != string.Empty &&
                                                                              string.Compare(arg1.KodOfConnect, arg2.KodOfConnect, StringComparison.OrdinalIgnoreCase) >= 0) ||
                                                                              ( arg2.Name != string.Empty &&
                                                                              string.Compare(arg1.Name, arg2.Name, StringComparison.OrdinalIgnoreCase) >= 0)); } },
            { OperatorSignComparision._LE_, (arg1, arg2, operatorComparision)=> {
                                                                 return ( operatorComparision == OperatorSignComparision._LE_) &&
                                                                              (( arg1.Id <= arg2.Id ) ||
                                                                              (arg2.KodOfConnect != string.Empty  &&
                                                                              string.Compare(arg1.KodOfConnect, arg2.KodOfConnect, StringComparison.OrdinalIgnoreCase) <= 0) ||
                                                                              ( arg2.Name != string.Empty &&
                                                                              string.Compare(arg1.Name, arg2.Name, StringComparison.OrdinalIgnoreCase) <= 0)); } },
            { OperatorSignComparision._REGEX_, (arg1, arg2, operatorComparision)=> {
                                                                 var regexTemplate = (arg2.KodOfConnect != string.Empty)? new Regex(arg2.KodOfConnect, RegexOptions.IgnoreCase) : (arg2.Name != string.Empty)? new Regex(arg2.Name, RegexOptions.IgnoreCase) : new Regex("");
                                                                 return ( operatorComparision == OperatorSignComparision._REGEX_) &&
                                                                              ( arg1.KodOfConnect != null  &&   !arg1.KodOfConnect.Equals(string.Empty) && regexTemplate.IsMatch(arg1.KodOfConnect) ||
                                                                              ( arg1.Name != null  &&   !arg1.Name.Equals(string.Empty) &&  regexTemplate.IsMatch( arg1.Name))); }}
        };



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


        static public CriteriaOfFilter<TEL_VID_CONNECT> CriteriaOfFilterCollection;



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var criteriasOfConditionList = new List<CriteriaOfFilterChainLink<TEL_VID_CONNECT>>();

            CriteriaOfFilterChainLink<TEL_VID_CONNECT> firstCtiteraOfCondition = new CriteriaOfFilterChainLink<TEL_VID_CONNECT>();
            {
                firstCtiteraOfCondition.ItemOfCriteria = new TEL_VID_CONNECT();
                firstCtiteraOfCondition.ItemOfCriteria.Id = 2;
                firstCtiteraOfCondition.OperatorComparision = OperatorSignComparision._GT_;
                firstCtiteraOfCondition.OperatorLogic = OperatorSignLogic._AND_;
            }
            criteriasOfConditionList.Add(firstCtiteraOfCondition);



            CriteriaOfFilterChainLink<TEL_VID_CONNECT> fifthCtiteraOfCondition = new CriteriaOfFilterChainLink<TEL_VID_CONNECT>();
            {
                fifthCtiteraOfCondition.ItemOfCriteria = new TEL_VID_CONNECT();
                fifthCtiteraOfCondition.ItemOfCriteria.Id = 5;
                fifthCtiteraOfCondition.OperatorComparision = OperatorSignComparision._LT_;
                fifthCtiteraOfCondition.OperatorLogic = OperatorSignLogic._AND_;
            }
            criteriasOfConditionList.Add(fifthCtiteraOfCondition);



            /*
                        CriteriaOfFilterChainLink<TEL_VID_CONNECT> secondCtiteraOfCondition = new CriteriaOfFilterChainLink<TEL_VID_CONNECT>();
                        {
                            secondCtiteraOfCondition.ItemOfCriteria = new TEL_VID_CONNECT();
                            secondCtiteraOfCondition.ItemOfCriteria.KodOfConnect = "0[5-9]";
                            secondCtiteraOfCondition.OperatorComparision = OperatorSignComparision._REGEX_;
                            secondCtiteraOfCondition.OperatorLogic = OperatorSignLogic._OR_;
                        }
                        criteriasOfConditionList.Add(secondCtiteraOfCondition);

                        CriteriaOfFilterChainLink<TEL_VID_CONNECT> thirdCtiteraOfCondition = new CriteriaOfFilterChainLink<TEL_VID_CONNECT>();
                        {
                            thirdCtiteraOfCondition.ItemOfCriteria = new TEL_VID_CONNECT();
                            thirdCtiteraOfCondition.ItemOfCriteria.Name = "kiiv.*?";
                            thirdCtiteraOfCondition.OperatorComparision = OperatorSignComparision._REGEX_;
                            thirdCtiteraOfCondition.OperatorLogic = OperatorSignLogic._OR_;
                        }
                        criteriasOfConditionList.Add(thirdCtiteraOfCondition);
            */






            /*
                        CriteriaOfFilterChainLink<TEL_VID_CONNECT> forthCtiteraOfCondition = new CriteriaOfFilterChainLink<TEL_VID_CONNECT>();
                        {
                            forthCtiteraOfCondition.ItemOfCriteria = new TEL_VID_CONNECT();
                            forthCtiteraOfCondition.ItemOfCriteria.Id = 2;
                            forthCtiteraOfCondition.OperatorComparision = OperatorSignComparision._GE_;
                            forthCtiteraOfCondition.OperatorLogic = OperatorSignLogic._AND_;
                        }
                        criteriasOfConditionList.Add(forthCtiteraOfCondition);

            */






            Program.CriteriaOfFilterCollection = PrepareCollectionOfComparisionCriteria(criteriasOfConditionList);

            var foundElOf_TEL_VID_CONNECTs = from el in Program.TEL_VID_CONNECTs where Program.CriteriaOfFilterCollection.EvalOnAllCriteria(el) orderby el.Id select el;




            IList<TEL_VID_CONNECT> arrayOf_TEL_VID_CONNECT = new List<TEL_VID_CONNECT>();

            foreach (var oneEl in Program.TEL_VID_CONNECTs)
            {
                if (Program.CriteriaOfFilterCollection.EvalOnAllCriteria(oneEl))
                {
                    arrayOf_TEL_VID_CONNECT.Add(oneEl);
                }
            }




            Console.WriteLine(" Id \t Kod \t  Name");
            foreach (var oneOfFound in foundElOf_TEL_VID_CONNECTs)
            {
                Console.WriteLine($" {oneOfFound.Id} \t {oneOfFound.KodOfConnect} \t  {oneOfFound.Name}");
            }
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

        static CriteriaOfFilter<TEL_VID_CONNECT> PrepareCollectionOfComparisionCriteria(IEnumerable<CriteriaOfFilterChainLink<TEL_VID_CONNECT>> criteriaOfFilterCollection)
        {
            CriteriaOfFilter<TEL_VID_CONNECT> collectionOfCriteria = new CriteriaOfFilter<TEL_VID_CONNECT>();


            if (criteriaOfFilterCollection != null)
            {
                foreach (var oneCriteriaOfFilter in criteriaOfFilterCollection)
                {
                    collectionOfCriteria.Add(oneCriteriaOfFilter, MapComparisioOperatorToComparisionPredicate[oneCriteriaOfFilter.OperatorComparision]);
                }
            }

            return collectionOfCriteria;
        }

    }
}
