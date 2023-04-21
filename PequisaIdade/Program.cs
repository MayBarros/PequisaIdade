namespace Pesquisa
{
    class Idade
    {
        static void Main(string[] args)
        {
            int idade, m_idade, c_pessoas, c_mulheres, n_mulheres;
            string sexo, c_olhos, c_cabelos;
            double pessoaMesmoS;

            //inicializando as variavéis
            c_pessoas = 0; // quantidade de pessoas entrevistadas
            c_mulheres = 0;  //a quantidade de mulheres entrevistadas nas condições estabelecidas
            n_mulheres = 0;  //o número de mulheres entrevistadas
            m_idade = 0;   // a maior idade informada 

            Console.WriteLine("Informe a idade do entrevistado, -1 para sair: ");
            idade = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            //atribuimos a primeira idade informada como a maior, por ser o primeiro e unico numero informado
            
            while(idade != -1)
            {
                if (idade >= m_idade)
                {
                    m_idade = idade;
                }
                //solicitar e lê o sexo do entrevistado
                Console.WriteLine("Informe o sexo do entrevistado: ");
                sexo = Console.ReadLine();

                //verificar o total de mulhres que participaram da pesquisa
                if((sexo == "Feminino") || (sexo == "FEMININO ") || (sexo == "feminino"))
                {
                    c_mulheres = c_mulheres + 1;
                }

                //solicita e lê a cor dos olhos do entrevistado

                Console.WriteLine("Informe a cor dos olhos do entrevistado: ");
                c_olhos = Console.ReadLine();

                //solicita e lê a cor do cabelo do entrevistado

                Console.WriteLine("Informe a cor do cabelo do entrevistado: ");
                c_cabelos = Console.ReadLine();
                Console.WriteLine();

                // calcula as mulheres nesta condição
                // porcentagem de mulheres  cuja idade é 18 a 35 anos
                // e que tenham olhos verdes e cabelos louros

                if (((sexo == "FEMININO") || (sexo == "feminino") || (sexo == "Feminino") && (idade >=18) && (idade <=35)) && ((c_olhos == "Verdes") || (c_olhos == "verdes") ||
                        (c_olhos == "VERDES")) && ((c_cabelos == "Louros") || (c_cabelos == "louros") || (c_cabelos == "LOUROS")))
                {
                    n_mulheres = n_mulheres + 1;
                }

                Console.Write("\tInforme a Idade do Entrevistado, -1 para Sair: ");
                idade = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                
                // Calcula a quantidade de pessoas que participaram da pesquisa
              
                c_pessoas = c_pessoas + 1;

            }

            // Verifica a porcentagem de mulheres que estão nesta condição entre o total de mulheres entrevistadas

            if (n_mulheres > 0)
            {
                pessoaMesmoS = ((n_mulheres * 100) / c_mulheres);
                Console.WriteLine();

                Console.WriteLine("Mulheres que estão na condição especificada são: {0}", pessoaMesmoS);
            }

            //exibe a maior idade encontrada
            if(m_idade == 0)
            {
                Console.WriteLine("Não foi entrevistada nenhuma pessoa.");
            }
            else
            {
                Console.WriteLine("O total de entrevisados foi: {0}", c_pessoas);
                Console.WriteLine("O total de pessoas do sexo feminino na pesquisa foi de: {0} mulheres",c_mulheres);
                Console.WriteLine("A maior idade fornecida na pesquisa é de: {0} anos",m_idade);
              
            }
        }
    }
}
