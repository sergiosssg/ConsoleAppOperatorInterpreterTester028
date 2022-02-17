using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOperatorInterpreterTester028
{

    enum OperatorSignComparision
    {
        _EQ_, _NE_, _GT_, _LT_, _GE_, _LE_, _BETWEEN_STRICT_, _BETWEEN_STRICT_LEFT_, _BETWEEN_STRICT_RIGHT_, _BETWEEN_NO_STRICT_, _REGEX_
    }

    enum OperatorSignLogic
    {
        _AND_, _OR_, _NOT_, _NIL_
    }

    interface IOperatorPredicateForComparision<T>
    {
        public delegate bool OperatorForComparision(T arg, OperatorSignLogic operatorLogic, OperatorForComparision operatorForComparision);
    }


    interface IOperatorForComparision<T>
    {
        public bool ComparisionSimpleOperator(T arg, OperatorSignLogic operatorLogic, IOperatorPredicateForComparision<T> operatorPredicateForComparision);
    }


    interface ICriteriaOfFilterChainLink<T>
    {

    }

    class CriteriaOfFilterChainLink<T> : ICriteriaOfFilterChainLink<T>
    {
        private T _oneItemOfCriteria;
        private OperatorSignComparision _operatorSignComparision;
        private OperatorSignLogic _operatorSignLogic;

        public CriteriaOfFilterChainLink()
        {
            this._oneItemOfCriteria = default(T);
            this._operatorSignComparision = OperatorSignComparision._REGEX_;
            this._operatorSignLogic = OperatorSignLogic._NIL_;
        }

        public CriteriaOfFilterChainLink(T el)
        {
            this._oneItemOfCriteria = el;
            this._operatorSignComparision = OperatorSignComparision._REGEX_;
            this._operatorSignLogic = OperatorSignLogic._NIL_;
        }

        public CriteriaOfFilterChainLink(T el, OperatorSignComparision operatorSignComparision)
        {
            this._oneItemOfCriteria = el;
            this._operatorSignComparision = operatorSignComparision;
            this._operatorSignLogic = OperatorSignLogic._NIL_;
        }

        public CriteriaOfFilterChainLink(T el, OperatorSignComparision operatorSignComparision, OperatorSignLogic operatorSignLogic)
        {
            this._oneItemOfCriteria = el;
            this._operatorSignComparision = operatorSignComparision;
            this._operatorSignLogic = operatorSignLogic;
        }

        public T ItemOfCriteria
        {
            get
            {
                return this._oneItemOfCriteria;
            }
            set
            {
                this._oneItemOfCriteria = value;
            }
        }

        public OperatorSignComparision OperatorComparision
        {
            get
            {
                return this._operatorSignComparision;
            }
            set
            {
                this._operatorSignComparision = value;
            }
        }

        public OperatorSignLogic OperatorLogic
        {
            get
            {
                return this._operatorSignLogic;
            }
            set
            {
                this._operatorSignLogic = value;
            }
        }
    }

}
