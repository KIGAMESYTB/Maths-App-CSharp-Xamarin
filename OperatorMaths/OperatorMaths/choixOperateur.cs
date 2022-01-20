using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorMaths
{
    public class choixOperateur : operationMaths
    {
        public string _Operateur {get;set;}
        public choixOperateur(string operateur)
        {
            _Operateur = operateur;
        }
        public String calculOperation(string number1, string number2, string number3)
        {

            switch (_Operateur)
            {
                case "+":
                    base.Add(double.Parse(number1), double.Parse(number2));
                    break;
                case "-":
                    base.Less(double.Parse(number1), double.Parse(number2));
                    break;
                case "x":
                    base.Multiply(double.Parse(number1), double.Parse(number2));
                    break;
                case "/":
                    base.Division(double.Parse(number1), double.Parse(number2));
                    break;
                case "=":
                    base.Egal(double.Parse(number1), double.Parse(number2));
                    break;
                case "x²":
                    base.PowerSquared(double.Parse(number1));
                    break;
                case "√":
                    base.SquareRoot(double.Parse(number1));
                    break;
                case "%":
                    base.Percentage(double.Parse(number1), double.Parse(number2));
                    break;
                case "f(x)":
                    base.Function(double.Parse(number1), double.Parse(number2));
                    break;
                case "ax²+bx+c":
                    base.Function2x(double.Parse(number1), double.Parse(number2), double.Parse(number3));
                    break;
                case "x^(n)":
                    base.PowerN(double.Parse(number1), double.Parse(number2));
                    break;
                case "h>d":
                    base.HexaToDecimal(number1);
                    break;
                case "h>b":
                    base.HexaToBinaire(number1);
                    break;
                case "d>h":
                    base.DecimalToHexa(number1);
                    break;
                case "d>b":
                    base.DecimalToBinaire(number1);
                    break;
                case "b>h":
                    base.BinaireToHexa(number1);
                    break;
                case "b>d":
                    base.BinaireToDecimal(number1);
                    break;
                case "log(x)":
                    base.exponentielle(double.Parse(number1));
                    break;
                case "exp(x)":
                    base.logarithme(double.Parse(number1));
                    break;

            }
            return base.ToString();
        }

    }
}
