using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainCoreLibrary;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AWSLambdaWithExternalLibrary
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string FunctionHandler(string input, ILambdaContext context)
        {
            double inpNum = Double.Parse(input);

            Entity newEnt = new Entity();
            newEnt.payload = inpNum;

            Entity staticEnt = new Entity();
            staticEnt.payload = 1.0;

            Result res = Utility.add(newEnt, staticEnt);

            double realRes = Utility.compute() * res.GetValue();

            LambdaLogger.Log(Utility.compute().ToString() + "\n");

            return realRes.ToString();
        }
    }
}
