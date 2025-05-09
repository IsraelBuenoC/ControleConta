using System;

namespace controleconta
{
    class Cliente
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        
        private string _cpf;
        public string CPF
        {
            get => _cpf;
            set
            {
                
                string numeros = Regex.Replace(value, @"[^\d]", "");
                
                
                if (numeros.Length != 11)
                {
                    throw new ArgumentException("CPF inválido. Deve conter exatamente 11 dígitos numéricos.");
                }

                _cpf = value;
            }
        }

        public Cliente(string nome, DateTime dataNascimento, string cpf)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            CPF = cpf;
        }

        public int Idade => DateTime.Now.Year - DataNascimento.Year;

        public string IdadeEmRomanos()
        {
            return ConverterParaRomanos(Idade);
        }

        private string ConverterParaRomanos(int numero)
        {
            string[] romanos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] valores = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string resultado = "";

            for (int i = 0; i < valores.Length; i++)
            {
                while (numero >= valores[i])
                {
                    resultado += romanos[i];
                    numero -= valores[i];
                }
            }
            return resultado;
        }
    }
}
