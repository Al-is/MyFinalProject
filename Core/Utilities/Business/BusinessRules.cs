using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {//List<IResult>
        public static IResult Run(params IResult[] logics)
        {//List<IResult> results =new List<IResult>();

            foreach (var logic in logics)
            {
                if (!logic.Success)
                {//errorresult.Add(logic);

                    return logic;
                }
            }

            //return errırResult
            return null;
        }
    }
}
