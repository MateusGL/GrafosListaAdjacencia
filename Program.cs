using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace teste
{
    // Versão Atual 2.1
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Digite o Nome do arquivo de teste em formato Txt.\nNao é preciso adicionar .txt");
            String NomeArquivo = Console.ReadLine();
            LerArquivo(NomeArquivo);
            Console.ReadKey();

        }
        public void ChamaArquivo()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Digite o Nome do arquivo de teste em formato Txt.\nNao é preciso adicionar .txt");
            String NomeArquivo = Console.ReadLine();
            LerArquivo(NomeArquivo);
            Console.ReadKey();
        }

        public static void Opcao(Grafo demo)
        {
            int op = 0;
            do
            {
                Menu();
                Console.Write("Digite opção:");
                try { op = int.Parse(Console.ReadLine()); }
                catch { Console.Write("Opção Invalida tenta novamente"); }
                switch (op)
                {
                    case 1: ChamaIsAdj(demo); break;
                    case 2: ChamaGrau(demo); break;
                    case 3: ChamaIsolado(demo); break;
                    case 4: ChamaPendente(demo); break;
                    case 5: ChamaRegular(demo); break;
                    case 6: ChamaNulo(demo); break;
                    case 7: ChamaCompleto(demo); break;
                    case 8: ChamaConexo(demo); break;
                    case 9: ChamaEuleriano(demo); break;
                    case 10: ChamaUnicursal(demo); break;
                    case 11: ChamaComplementar(demo); break;
                    case 12: ChamaGrauEntrada(demo); break;
                    case 13: ChamaGrauSaida(demo); break;
                    case 14: ChamaCiclo(demo); break;

                    //case 19: MudarGrafo(demo); break;
                    case 20: Console.WriteLine("Saindo..."); break;


                    default: Console.WriteLine("Opção inválida!"); break;
                } // switch end
            } while (op != 20);
        }

        public static void Menu()
        {
            Console.WriteLine("\n----------------------");
            Console.WriteLine("1. Vertice adj");
            Console.WriteLine("2. Grau do vertice");
            Console.WriteLine("3. Vertice Isolada");
            Console.WriteLine("4. Vertice Pendente");
            Console.WriteLine("5. Grafo Regular");
            Console.WriteLine("6. Grafo Nulo");
            Console.WriteLine("7. Grafo Completo");
            Console.WriteLine("8. Grafo Conexo");
            Console.WriteLine("9. Grafo Euleriano");
            Console.WriteLine("10. Grafo Unicursal");
            Console.WriteLine("11. Grafo Complementar");
            Console.WriteLine("----------------------");
            Console.WriteLine("12. Grau de entrada do vertice");
            Console.WriteLine("13. Grau de Saida do vertice");
            Console.WriteLine("14. Grafo tem Ciclos: ");
            Console.WriteLine("----------------------");
            Console.WriteLine("20. ----- Sair ----");
            //----
        }
        public static void ChamaCiclo(Grafo demo)
        {
            Console.Clear();
            bool aux = false;
            for (int i = 0; i < demo.GetVertices; i++)
            {
                if (demo.ChamaCiclo(i)) aux = true;
                Console.WriteLine("O Grafo no vertice " + i + " tem ciclo : " + aux);
            }
            // usando busca em profundidade verificar se algum vertice consegue voltar ao vertice inicial
            Console.WriteLine("O Grafo tem ciclo : " + aux);
        }
        public static void ChamaGrauSaida(Grafo demo)
        {
            /*Na estrutura de dados em vertice de adj o grau de um vertice e igual ao grau de saida no caso de grafos
             * direcionados
             * */
            Console.Clear();
            Console.Write("Digite o vertice: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("O grau de Saida do vertice é :" + demo.GetGrau(v1 - 1));
        }
        public static void ChamaGrauEntrada(Grafo demo)
        {
            Console.Clear();
            Console.Write("Digite o vertice: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("O grau de Entrada do vertice é :" + demo.GetgetGrauEntrada(v1 - 1));
        }
        public static void ChamaComplementar(Grafo demo)
        {
            Console.Clear();
            Console.WriteLine("Grafo Complementar:");
            demo.ImprimeGrafo(demo.getComplementar());
        }
        public static void ChamaUnicursal(Grafo demo)
        {
            Console.Clear();
            Console.WriteLine("Grafo Unicursal:" + demo.isUnicursal());
        }
        public static void ChamaEuleriano(Grafo demo)
        {
            Console.Clear();
            Console.WriteLine("Grafo Euleriano:" + demo.isEuleriano());
        }
        public static void ChamaConexo(Grafo demo)
        {
            Console.Clear();
            Console.WriteLine("Grafo Conexo:" + demo.isConexo());
        }
        public static void ChamaCompleto(Grafo demo)
        {
            Console.Clear();
            Console.WriteLine("Grafo Completo:" + demo.isCompleto());
        }
        public static void ChamaNulo(Grafo demo)
        {
            Console.Clear();
            Console.WriteLine("Grafo Nulo: " + demo.isNulo());
        }
        public static void ChamaRegular(Grafo demo)
        {
            Console.Clear();
            Console.WriteLine("Grafo Regular: " + demo.isRegular());
        }
        public static void ChamaPendente(Grafo demo)
        {
            Console.Clear();
            Console.Write("Digite o vertice: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vertice pendente:" + demo.isPendente(v1 - 1)); // erro pois demo.isIsolado(v1 - 1)
        }
        public static void ChamaIsolado(Grafo demo)
        {
            Console.Clear();
            Console.Write("Digite o vertice: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vertice isolado:" + demo.isIsolado(v1 - 1));
        }
        public static void ChamaGrau(Grafo demo)
        {
            Console.Clear();
            Console.Write("Digite o vertice: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("O grau do vertice é :" + demo.GetGrau(v1 - 1));
        }
        public static void ChamaIsAdj(Grafo demo)
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro vertice: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo vertice: ");
            int v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("São Adj: " + demo.isAdjacente(v1 - 1, v2 - 1));
        }


        public static void BateriaDeTestes(Grafo demo, List<celula>[] Complementar, List<celula>[] Lista)
        {
            Console.WriteLine("\n3 e pendente: " + demo.isPendente(2));
            Console.WriteLine("\n3 e Isolado: " + demo.isIsolado(2));
            Console.WriteLine("\nÉ Regular ? " + demo.isRegular());
            Console.WriteLine("\nÉ Nulo ? " + demo.isNulo());
            Console.WriteLine("\nO vertice 1 é Grau: " + demo.GetGrau(0));
            Console.WriteLine("\nO vertice 2 é Grau: " + demo.GetGrau(1));
            Console.WriteLine("\nO vertice 3 é Grau: " + demo.GetGrau(2));
            Console.WriteLine("\nO vertice 4 é Grau: " + demo.GetGrau(3));
            Console.WriteLine("\n1,2 e Adjacente: " + demo.isAdjacente(0, 1));
            Console.WriteLine("\n4,2 e Adjacente: " + demo.isAdjacente(3, 1));
            Console.WriteLine("\nÉ Completo: " + demo.isCompleto());
            Console.WriteLine("Grafo");
            demo.ImprimeGrafo(Lista);
            Console.WriteLine("\n2,2 e Adjacente: " + demo.isAdjacente(1, 1));
            Console.WriteLine("\n3,3 e Adjacente: " + demo.isAdjacente(2, 2));
            // ------------------------------------------------
            Complementar = demo.getComplementar();
            Console.WriteLine("Complementar");
            demo.ImprimeGrafo(Complementar);
            Console.WriteLine("\nÉ Conexo ? " + demo.isConexo());
        }

        public static Grafo IniciaGrafo(int Tamanho)
        {
            //int txt = Tamanho;
            List<celula>[] Lista = new List<celula>[Tamanho];
            List<celula>[] Complementar = new List<celula>[Tamanho]; // grafo complementar ao grafo 1
            for (int x = 0; x < Tamanho; x++)
            /*  inicializa os V elementos do vetor  */
            {
                Lista[x] = new List<celula>();
            }
            // ------------------------------------------------
            for (int x = 0; x < Tamanho; x++)
            /*  inicializa os V elementos do vetor  */

            {
                Complementar[x] = new List<celula>();
            }
            Grafo demo = new Grafo(Tamanho, Lista);
            return demo;
        }

        public static Grafo IniciaComplementar(int Tamanho)
        {
            int txt = Tamanho;
            List<celula>[] Complementar = new List<celula>[txt]; // grafo complementar ao grafo 1                
                                                                 // ------------------------------------------------                            
            for (int x = 0; x < txt; x++)
            /*  inicializa os V elementos do vetor  */

            {
                Complementar[x] = new List<celula>();
            }
            Grafo Grafo2 = new Grafo(Tamanho, Complementar);
            return Grafo2;
        }

        public static void LerArquivo(string Arquivo)
        {
            string[] dados;

            if (File.Exists(Arquivo + ".txt")) //se existe o arquivo...// Aqui se tem certeza que o arquivo existe
            {

                Stream entrada = File.Open(Arquivo + ".txt", FileMode.Open); // Abre o arquivo para leitura
                StreamReader Leitor = new StreamReader(entrada); // Abre o arquivo para leitura
                                                                 /* Le a primeira linha do arquivo, no caso o numero de vertices existente no grafo
                                                                  */
                int Tamanho = int.Parse(Leitor.ReadLine());

                Grafo demo = IniciaGrafo(Tamanho);

                while (!Leitor.EndOfStream) // Enquato nao chegar ao fim do arquivo faça...
                {
                    string Linha = Leitor.ReadLine();
                    dados = Linha.Split(';');
                    if (dados.Count() == 3)
                    {
                        demo.AdicinarAresta(int.Parse(dados[0]), int.Parse(dados[1]), int.Parse(dados[2]));
                    }
                    if (dados.Count() == 4)
                    {
                        //    int origem = int.Parse(dados[0]);
                        //    int destino = int.Parse(dados[1]);
                        //    int peso = int.Parse(dados[2]);
                        //    float direcao = float.Parse(dados[3]);
                        if (float.Parse(dados[3]) == 1)
                        {
                            demo.AdicinarArestaDirecionada(int.Parse(dados[0]), int.Parse(dados[1]), int.Parse(dados[2]));
                        }
                        else
                        {
                            demo.AdicinarArestaDirecionada(int.Parse(dados[1]), int.Parse(dados[0]), int.Parse(dados[2]));
                        }

                    }
                }
                entrada.Close();
                Leitor.Close();
                // Inicia o menu de Opções 
                Opcao(demo);
            }
            else
            {
                Console.WriteLine("Arquivo nao Encontrado");
            }
        }
    }
    class celula
    {
        int origem, destino, peso, cor;
        public celula(int v1, int v2, int v3)
        {
            this.origem = v1;
            this.destino = v2;
            this.peso = v3;
        }
        public int GetDestino
        {
            get
            {
                return this.destino;
            }
        }

        public int Getpeso
        {
            get
            {
                return this.peso;
            }
        }

        public int Getcor
        {
            get
            {
                return this.cor;
            }
            set
            {
                this.cor = value;
            }
        }
    }
    class Grafo
    {
        // número de vértices            
        int Vertices;
        List<celula>[] Lista;
        //Construtor
        public Grafo(int v, List<celula>[] Listas2)
        {
            this.Vertices = v;
            this.Lista = Listas2;
        }
        public int GetVertices
        {
            get
            {
                return this.Vertices;
            }
        }
        // separar funções add aresta direcionar e nao direcionada
        public void AdicinarAresta(int origem, int destino, int peso)
        {
            //
            celula aux = new celula(origem - 1, destino - 1, peso);
            Lista[origem - 1].Add(aux);

            //Grafo nao direcionado, função para agilizar procesos de cadastro das arestas
            celula aux2 = new celula(destino - 1, origem - 1, peso);
            Lista[destino - 1].Add(aux2);
        }

        public void AdicinarArestaDirecionada(int origem, int destino, int peso)
        {
            //
            celula aux = new celula(origem - 1, destino - 1, peso);
            Lista[origem - 1].Add(aux);
        }

        public int GetGrau(int vertice)
        {
            // Retorna o grau de um vertice
            return Lista[vertice].Count();
        }
        public int GetgetGrauEntrada(int vertice)
        {
            int count = 0;
            // Retorna o grau de entradade um vertice, as arestas que chegam nele                
            for (int y = 0; y < Vertices; y++)
                for (int x = 0; x < Lista[y].Count(); x++)
                {
                    if (Lista[y][x].GetDestino == vertice) count++;
                }
            return count;
        }

        public bool isIsolado(int v1)
        {
            // Se um vertice tiver grau 0 ele é isolado
            if (GetGrau(v1) == 0) return true;
            return false;
        }

        public bool isPendente(int v1)
        {
            // Se um vertice tiver grau 1 ele é pendente 
            if (GetGrau(v1) == 1) return true;
            return false;
        }

        public bool isRegular()
        {
            // Verifica se todos os vertices do grafo tem o mesmo grau
            for (int x = 1; x < Lista.Count(); x++) //roda o numero de vestices existente 
            {
                // Compara o grau do vertice atual com o grau do vertice anterior se for diferente retorna falso
                if (Lista[x].Count() != Lista[x - 1].Count()) return false;
            }
            // Se nao encontrou vertice com grau diferente retorna true
            return true;
        }

        public bool isNulo()
        {
            // Se todo os vertices do grafos forem isolados o grafo e nulo e retorna true
            for (int x = 0; x < Lista.Count(); x++)
            {
                // Se apenas um vertice nao for isolado o grafo nao e nulo retorna false
                if (!isIsolado(x)) return false;
            }
            return true;
        }

        public bool isAdjacente(int v1, int v2)
        {
            // Pega o tamanho na lista na posição v1 do vetor
            for (int x = 0; x < Lista[v1].Count(); x++)
            {
                if (Lista[v1][x].GetDestino == v2) { return true; }

            }
            return false;
        }

        public bool isCompleto()
        /*      Para cada vertice varrer a lista verificando se ele é adjacente a todos os outros vertices, 
         *      Se encontrar algum vertice ao qual ele nao seja adjacente pare a execução e retorne false   */
        {
            for (int y = 1; y < Vertices; y++)
            {
                // Verificação de laços verifica se um vertice e adjacente a ele mesmo
                if (isAdjacente(y, y)) return false;
                for (int x = 1; x < Vertices; x++)
                {                    
                    if (x != y) if (Arestaparalela(x, y)) return false;
                    if (x != y) if (!isAdjacente(y, x)) return false;
                    // 
                }
            }                
            return true;
        }
        public bool isEuleriano()
        {
            if (!isConexo()) return false;
            for (int x = 0; x < Vertices; x++)
            {   
                if ((GetGrau(x) % 2 != 0)) return false; // erro if ((GetGrau(x) % 2 == 0))
            }
            return true;
        }
        public bool isUnicursal()
        {
            int impar = 0;
            //Um grafo e unicursal se e somente se for conexo e possuir 2 vertices de grau impar
            if (!isConexo()) return false;
            for (int x = 0; x < Vertices; x++)
            {
                if (!(GetGrau(x) % 2 == 0))
                {
                    impar++;
                }
            }
            if (impar == 2) return true;
            return false;

        }

        public bool Arestaparalela(int v1, int v2)
        /* função auxiliar para a função de grafo completo função de aresta paralela
         * verificar se para um conjunto x,y existe mais de uma aresta adjacente
         */
        {
            int aux = 0;
            for (int x = 0; x < Lista[v1 - 1].Count(); x++)
            {
                if (Lista[v1 - 1][x].GetDestino == v2 - 1)
                {
                    aux++;
                }
            }
            if (aux > 1) return true; // existe aresta paralela
            return false;
        }
        public List<celula>[] getComplementar()
        {
            List<celula>[] Complementar = new List<celula>[Vertices];
            for (int x = 0; x < Vertices; x++)
            {
                //  inicializa os X elementos do vetor
                Complementar[x] = new List<celula>();
            }

            for (int x = 0; x < Vertices; x++)
                for (int y = 0; y < Vertices; y++)
                {
                    /*Caso nao exista adj entre um vertice x,y e x,y nao seja igual entao adiciona a aresta
                     *ao grafo complementar.
                     */
                    if (x != y && !isAdjacente(x, y))
                    {// add vertice
                        celula aux = new celula(x, y, 1);
                        Complementar[x].Add(aux);
                    }
                }
            return Complementar;
        }

        public void ImprimeGrafo(List<celula>[] Grafo)
        {
            for (int y = 0; y < Vertices; y++)
                for (int x = 0; x < Grafo[y].Count(); x++)
                {
                    Console.WriteLine("vertice: " + (y + 1) + " Destino: " + ((Grafo[y][x].GetDestino) + 1));
                }

        }

        public struct AuxBuscaP
        {
            int cor; // 1 branco 2 azul 3 vermelhor 
            int pred, tempo;
            public AuxBuscaP(int cor1, int pred1, int tempo1)
            {
                cor = cor1;
                pred = pred1;
                tempo = tempo1;
            }
            public int GetCor
            {
                get
                {
                    return this.cor;
                }
                set
                {
                    cor = value;
                }
            }
        }

        // -------------------------------------
        /* Vetor auxiliar guarda a cor do vertice (se ja foi descoberto, esta em atividade ou desativo)
         * -- retornar um vetor de booleanos pode ser util para simplificar a estrutura da solução
         * a função recebe um vertice qualquer X coloca ele em azul e marca todos os vertices adjacentes a ele tb com azul 
         * e recebe este processo em ordem crescente a partir do vertice recebido ao final retornar um vetor booleano com o tamanho do grafo e true 
         * para cada vertice que foi alcançado e false para os vertices que nao foram alcançados*/
        public bool[] ChamaBuscaProfundidade(int v1)
        {
            AuxBuscaP[] teste = new AuxBuscaP[Vertices];
            for (int x = 0; x < Vertices; x++)
            {
                teste[x] = new AuxBuscaP(1, 0, 0);
            }
            // -----------------------------
            bool[] tabela = new bool[Vertices];
            BuscaProfundidade(v1, ref teste, ref tabela);

            for (int x = 0; x < Vertices; x++)
            {
                // imprime a relação dos vertices que foram alcançados pela busca em profundidade 
                Console.WriteLine("Vertice alcançado: " + x + " " + tabela[x]);
            }
            return tabela;
        }
        public bool[] BuscaProfundidade(int v1, ref AuxBuscaP[] teste, ref bool[] tabela)
        {
            teste[v1].GetCor = 2;
            tabela[v1] = true;
            for (int x = 0; x < Lista[v1].Count; x++)
            {
                //if (teste[Lista[v1][x].GetDestino == v0) tem ciclo variavel auxiliar recebe true
                if (teste[Lista[v1][x].GetDestino].GetCor == 1) BuscaProfundidade(Lista[v1][x].GetDestino, ref teste, ref tabela);
            }
            return tabela;
        }
        public bool ChamaCiclo(int v1)
        {   
            bool[] Visitado = new bool[Vertices];
            bool[] tabela = new bool[Vertices];
            bool aux = Ciclo(v1, ref Visitado, ref tabela, v1);            
            return aux;
        }
        public bool Ciclo(int v1, ref bool[] visitado, ref bool[] tabela, int v0)
        {
            visitado[v1] = true;
            tabela[v1] = true;
            if (isAdjacente(v1, v0)) return true;
            for (int x = 0; x < Lista[v1].Count; x++)
            {                
                if (visitado[x] == false) return Ciclo(Lista[v1][x].GetDestino, ref visitado, ref tabela, v0);
            }
            return false;             
        }
        public bool isConexo()
        {
            bool[] tabela = ChamaBuscaProfundidade(0);
            for (int x = 0; x < Vertices; x++)
            {
                if (tabela[x] == false) return false;
            }
            return true;
        }

        // prin recebe um vertice verificar se o proximo vertice nao faz parte do grafo com a busca em profundidade
        // e se nao fizer o adiciona de, usa logica gulosa pra ver qual vertice deve ser add
        public int ComponentesConexos()
        {
            int y = 0;
            bool aux = false;
            int NumeroComponentes = 0;
            bool[] TabelaAuxiliar = new bool[Vertices];
            bool[] componentes = ChamaBuscaProfundidade(0);
            while (aux == false)
            {
                // Sempre que o algoritmo fizer uma nova busca significa que existe mais um componente
                NumeroComponentes++;
                /* Verifica a tabela procurando um vertice que nao tenha sido alcançado na busca em profundidade
                 * caso encontre faz uma busca a partir deste vertice
                 */
                for (int x = 0; x < Vertices; x++)
                {
                    if (TabelaAuxiliar[x] == false)
                    {
                        componentes = ChamaBuscaProfundidade(x);
                    }
                }
                /* Coloca na tabela auxiliar os vertices que foram encontrados 
                 */
                for (int x = 0; x < Vertices; x++)
                {
                    if (componentes[x] == true) TabelaAuxiliar[x] = componentes[x];
                }
                /* Se todos os vertices tiverem sido entrados termina a busca e retorna o numero de componentes 
                 * conexos
                 */
                if (TabelaAuxiliar[y] == true)
                {
                    for (y = 0; y < Vertices; y++)
                    {
                        if (TabelaAuxiliar[y] == TabelaAuxiliar[y - 1]) ;
                    }
                }
                if (y == Vertices - 1) aux = true;
                else y = 0;
            }
            return NumeroComponentes;
        }
        public int getCutVertices()
        {
            /*
             * Encontrar o numero de componenestes conexos em G = A
             * Para todo i pertencente a G testar
             * testar quantos componentes conexos G tem sem i = B 
             * Se B > A 
             * i é um componentes conexo
             * Usar buscar em profundida para encontrar numero de componenetes
             * //
             * 
             * com a tabela da busca em profundidade fazer uma busca em profundidade em cada vertice nao encontrado na 
             * primeira busca o numero de componentes conexos sera o numero de vezes q sera necessario fazer a busca
             * em profundidade para encontrar todos os vertices.
             * 
             */
            int A, B;
            A = ComponentesConexos();
            List<celula>[] ListaAuxiliar = new List<celula>[Vertices - 1];
            for (int x = 0; x < Vertices - 1; x++)
            /*  inicializa os V elementos do vetor  */
            {
                ListaAuxiliar[x] = new List<celula>();
            }
            /* Função auxiliar para deletar vertice 
             * Criar um Grafo sem o vertice X deletando qualquer aresta ligada a ele 
             * comparar o numero de componentes conexos deste novo grafo com o numero atual
             * se for menor a vertice removida dele e um cut-vertice
             */
            for (int x = 0; x < Vertices; x++)
            {
                // criasse o grafo sem o vertice X 
                for (int y = 0; y < Vertices; y++)
                {
                    if (x != y)
                    {
                        //if (Lista[x][y].GetDestino != x) ListaAuxiliar[y]
                    }

                }
            }
            return 0;
        }
    }
}
