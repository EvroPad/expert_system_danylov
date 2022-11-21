using System;

namespace ЭС
{

    [Serializable]
    public enum RuleWork
    {
        No,
        Signifi,    
        Unsignify   
    }

    [Serializable]
    public enum Rightly
    {
        Unknown = 1,    
        Yes,          
        No              
    }
    [Serializable]
    public enum VarType
    {
        Deducted,
        Queried,
        DeductionQueried
    }


}