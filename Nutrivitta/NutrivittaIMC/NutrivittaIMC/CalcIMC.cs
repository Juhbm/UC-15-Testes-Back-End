namespace NutrivittaIMC
{
    public static class CalcIMC
    {
        public static double CalculoIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        public static string ClassificarIMC(double IMC)
        {
            
            var classificacao = "";

            if (IMC < 18.5)
            {
                classificacao = "Abaixo do peso";
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                classificacao = "Peso Normal";
            }
            else if (IMC >= 25.0 && IMC <= 29.9)
            {
                classificacao = "Sobrepeso";
            }
            else if (IMC >= 30.0 && IMC <= 34.9)
            {
                classificacao = "Obesidade Grau I";
            }
            else if (IMC >= 35.0 && IMC <= 39.9)
            {
                classificacao = "Obesidade Grau II";
            }
            else
            {
                classificacao = "Obesidade Grau III";
            }

            return classificacao;
        }
    }
}