using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    public class ConjIj
    {
        public int j;
        public HashSet<Estado> ConjI;
        public int[] TransicionesAFD;

        public ConjIj(int CardAlf)
        {
            j = -1;
            ConjI = new HashSet<Estado>();
            ConjI.Clear();
            TransicionesAFD = new int[257];
            for (int k = 0; k <= 256; k++)
            {
                TransicionesAFD[k] = -1;
            }
        }
    }
    class AFN
    {
        public static HashSet<AFN> ConjuntoAFNs = new HashSet<AFN>();
        Estado estadoInit;
        HashSet<Estado> EstadosAFN = new HashSet<Estado>();
        public HashSet<Estado> EstadosAcept = new HashSet<Estado>();
        HashSet<char> alfabeto = new HashSet<char>();

        bool SeAgregaAFNUnionLexico;
        public int idAFN;

        public AFN()
        {
            idAFN = 0;
            estadoInit = null;
            EstadosAFN.Clear();
            EstadosAcept.Clear();
            SeAgregaAFNUnionLexico = false;
        }

        public AFN crearAFNBasico(char s)
        {
            Transicion t;
            estadoInit = new Estado();
            Estado acept = new Estado();

            t = new Transicion(s, acept);
            alfabeto.Add(s);
            acept.EstadoAcept = true;
            estadoInit.Trans.Add(t);
            EstadosAFN.Add(estadoInit);
            EstadosAFN.Add(acept);

            EstadosAcept.Add(acept);
            SeAgregaAFNUnionLexico = false;
            return this;
        }

        public AFN crearAFNBasico(char s, char s2)
        {
            Transicion t;
            estadoInit = new Estado();
            Estado acept = new Estado();

            t = new Transicion(s, s2, acept);
            
            acept.EstadoAcept = true;
            estadoInit.Trans.Add(t);

            for(char i = s; i <= s2; i++)
            {
                alfabeto.Add(i);
            }

            EstadosAFN.Add(estadoInit);
            EstadosAFN.Add(acept);

            EstadosAcept.Add(acept);
            SeAgregaAFNUnionLexico = false;
            return this;
        }

        public AFN UnirAFN(AFN f2)
        {
            Estado e1 = new Estado();
            Estado e2 = new Estado();

            Transicion t1 = new Transicion(SimbolosEspeciales.Epsilon, this.estadoInit);
            Transicion t2 = new Transicion(SimbolosEspeciales.Epsilon, f2.estadoInit);

            e1.Trans.Add(t2);
            e1.Trans.Add(t1);

            foreach(Estado e in f2.EstadosAcept)
            {
                e.Trans.Add(new Transicion(SimbolosEspeciales.Epsilon, e2));
                e.EstadoAcept = false;
            }
            foreach (Estado e in this.EstadosAcept)
            {
                e.Trans.Add(new Transicion(SimbolosEspeciales.Epsilon, e2));
                e.EstadoAcept = false;
            }
            this.EstadosAcept.Clear();
            f2.EstadosAcept.Clear();
            this.estadoInit = e1;
            e2.EstadoAcept = true;
            this.EstadosAFN.UnionWith(f2.EstadosAFN);
            this.EstadosAFN.Add(e1);
            this.EstadosAFN.Add(e2);
            this.EstadosAcept.Add(e2);
            this.alfabeto.UnionWith(f2.alfabeto);
            return this;
        }

        public AFN ConcatenarAFN( AFN f2)
        {   
            foreach(Transicion t in f2.estadoInit.Trans)
            {
                foreach(Estado e in this.EstadosAcept)
                {
                    e.Trans.Add(t);
                    e.EstadoAcept = false;
                }
            }

            f2.EstadosAFN.Remove(f2.estadoInit);

            this.EstadosAcept = f2.EstadosAcept;
            this.EstadosAFN.UnionWith(f2.EstadosAFN);
            this.alfabeto.UnionWith(f2.alfabeto);

            return this;
        }

        public AFN cerraduraPos()
        {
            Estado e1 = new Estado();
            Estado e2 = new Estado();
            e1.Trans.Add(new Transicion(SimbolosEspeciales.Epsilon, this.estadoInit));
            foreach(Estado e in this.EstadosAcept)
            {
                e.Trans.Add(new Transicion(SimbolosEspeciales.Epsilon, e2));
                e.Trans.Add(new Transicion(SimbolosEspeciales.Epsilon, this.estadoInit));
                e.EstadoAcept = false;
            }
            this.estadoInit = e1;
            e2.EstadoAcept = true;
            this.EstadosAcept.Clear();
            this.EstadosAFN.Add(e1);
            this.EstadosAFN.Add(e2);
            this.EstadosAcept.Add(e2);

            return this;


        }

        public AFN cerraduraKleen()
        {
            Estado e1 = new Estado();
            Estado e2 = new Estado();
            e1.Trans.Add(new Transicion(SimbolosEspeciales.Epsilon, this.estadoInit));
            e1.Trans.Add(new Transicion(SimbolosEspeciales.Epsilon, e2));
            foreach (Estado e in this.EstadosAcept)
            {
                e.Trans.Add(new Transicion(SimbolosEspeciales.Epsilon, e2));
                e.Trans.Add(new Transicion(SimbolosEspeciales.Epsilon, this.estadoInit));
                e.EstadoAcept = false;
            }

            this.estadoInit = e1;
            e2.EstadoAcept = true;
            this.EstadosAcept.Clear();
            this.EstadosAFN.Add(e1);
            this.EstadosAFN.Add(e2);
            this.EstadosAcept.Add(e2);

            return this;
        }

        public AFN opcional()
        {
            Estado e1 = new Estado();
            Estado e2 = new Estado();
            e1.Trans.Add(new Transicion(SimbolosEspeciales.Epsilon, this.estadoInit));
            e1.Trans.Add(new Transicion(SimbolosEspeciales.Epsilon, e2));
            foreach (Estado e in this.EstadosAcept)
            {
                e.Trans.Add(new Transicion(SimbolosEspeciales.Epsilon, e2));
                
                e.EstadoAcept = false;
            }

            this.estadoInit = e1;
            e2.EstadoAcept = true;
            this.EstadosAcept.Clear();
            this.EstadosAFN.Add(e1);
            this.EstadosAFN.Add(e2);
            this.EstadosAcept.Add(e2);

            return this;
        }


        public HashSet<Estado> CerraduraEspsilon(Estado e)
        {
            HashSet<Estado> R = new HashSet<Estado>();
            Stack<Estado> S = new Stack<Estado>();
            Estado aux,estado;
            R.Clear();
            S.Clear();

            S.Push(e);

            while(S.Count() != 0)
            {
                aux = S.Pop();
                R.Add(aux);
                foreach(Transicion t in aux.Trans)
                {
                    if((estado = t.GetEdoTrans(SimbolosEspeciales.Epsilon)) != null)
                    {
                        if (!R.Contains(estado))
                        {
                            S.Push(estado);
                        }
                    }
                }
            }
            return R;
        }

        public HashSet<Estado> CerraduraEspsilon(HashSet<Estado> ce)
        {
            HashSet<Estado> R = new HashSet<Estado>();
            Stack<Estado> S = new Stack<Estado>();
            Estado aux, estado;
            R.Clear();
            S.Clear();
            foreach(Estado e in ce)
            {
                S.Push(e);
            }
            while (S.Count() != 0)
            {
                aux = S.Pop();
                R.Add(aux);
                foreach (Transicion t in aux.Trans)
                {
                    if ((estado = t.GetEdoTrans(SimbolosEspeciales.Epsilon)) != null)
                    {
                        if (!R.Contains(estado))
                        {
                            S.Push(estado);
                        }
                    }
                }
            }
            return R;
        }
        public HashSet<Estado> Mover(Estado edo, char s)
        {
            HashSet<Estado> C = new HashSet<Estado>();

            Estado aux;
            C.Clear();

            foreach(Transicion t in edo.Trans)
            {
                aux = t.GetEdoTrans(s);
                if (aux != null)
                {
                    C.Add(aux);
                }
            }

            return C;
        }

        public HashSet<Estado> Mover(HashSet<Estado> edos, char s)
        {
            HashSet<Estado> C = new HashSet<Estado>();

            Estado aux;
            C.Clear();

            foreach (Estado edo in edos)
            {
                foreach (Transicion t in edo.Trans)
                {
                    aux = t.GetEdoTrans(s);
                    if (aux != null)
                    {
                        C.Add(aux);
                    }
                }
            }
            return C;
        }

        public HashSet<Estado> Ir_A(HashSet<Estado> edos, char s)
        {
            HashSet<Estado> C = new HashSet<Estado>();  
            C.Clear();

            C = CerraduraEspsilon(Mover(edos, s)) ;

            return C;
        }

        public static AFN UnionLexica(int id,HashSet<AFN> afns)
        {
            Estado inicial = new Estado();
            AFN analizador = new AFN();
            analizador.idAFN = id;
            foreach(AFN afn in afns)
            {
                inicial.Trans.Add(new Transicion(SimbolosEspeciales.Epsilon,afn.estadoInit));
                analizador.EstadosAcept.UnionWith(afn.EstadosAcept);
                analizador.EstadosAFN.UnionWith(afn.EstadosAFN);
                analizador.alfabeto.UnionWith(afn.alfabeto);
            }
            analizador.estadoInit = inicial;
            _ = AFN.ConjuntoAFNs.Add(analizador);
            return analizador;
            
        }

        private int IndiceCaracter(char[] ArregloAlfabeto, char c)
        {
            int i;
            for (i = 0; i < ArregloAlfabeto.Length; i++)
            {
                if (ArregloAlfabeto[i] == c)
                {
                    return i;
                }
            }
            return -1;
        }

        public AFD ConvAFNaAFD()
        {
            int CardAlfabeto, numEdosAFD;
            int i, j, r;
            char[] ArrAlfabeto;
            ConjIj Ij, Ik;
            bool existe;

            HashSet<Estado> ConjAux = new HashSet<Estado>();
            HashSet<ConjIj> EdosAFD = new HashSet<ConjIj>();
            Queue<ConjIj> EdosSinAnalizar = new Queue<ConjIj>();

            EdosAFD.Clear();
            EdosSinAnalizar.Clear();

            CardAlfabeto = alfabeto.Count;
            ArrAlfabeto = new char[CardAlfabeto];
            i = 0;
            foreach (char c in alfabeto)
                ArrAlfabeto[i++] = c;

            j = 0;  //contador para los edos del AFD
            Ij = new ConjIj(CardAlfabeto)
            {
                ConjI = CerraduraEspsilon(this.estadoInit),
                j = j
            };
            EdosAFD.Add(Ij);
            EdosSinAnalizar.Enqueue(Ij);
            j++;
            while (EdosSinAnalizar.Count != 0)
            {
                Ij = EdosSinAnalizar.Dequeue();
                //calcular el Ir_A del Ij con c/simbolo del alfabeto
                foreach (char c in ArrAlfabeto)
                {
                    Ik = new ConjIj(CardAlfabeto)
                    {
                        ConjI = Ir_A(Ij.ConjI, c)
                    };
                    if (Ik.ConjI.Count == 0)
                        continue;

                    existe = false;
                    foreach (ConjIj I in EdosAFD)
                    {
                        if (I.ConjI.SetEquals(Ik.ConjI))
                        {
                            existe = true;

                            r = IndiceCaracter(ArrAlfabeto, c);
                            Ij.TransicionesAFD[(int)c] = I.j;
                            break;
                        }
                    }

                    if (!existe)
                    {
                        Ik.j = j;
                        r = IndiceCaracter(ArrAlfabeto, c);
                        Ij.TransicionesAFD[(int)c] = Ik.j;
                        EdosAFD.Add(Ik);
                        EdosSinAnalizar.Enqueue(Ik);
                        j++;
                    }
                }
            }
            numEdosAFD = j;

            foreach (ConjIj I in EdosAFD)
            {
                ConjAux.Clear();
                ConjAux.UnionWith(I.ConjI);
                ConjAux.IntersectWith(this.EstadosAcept);
                if (ConjAux.Count != 0)
                {
                    foreach (Estado EdoAcept in ConjAux)
                    {
                        I.TransicionesAFD[256] = EdoAcept.Token;
                        break;
                    }
                }
                else
                {
                    I.TransicionesAFD[256] = -1;
                }
            }
            AFD AutFD = new AFD
            {
                CardAlfabeto = CardAlfabeto
            };

            AutFD.TablaAFD = new int[EdosAFD.Count, 257];
            for (i = 0; i < EdosAFD.Count; i++)
            {
                for (j = 0; j < 257; j++)
                {
                    AutFD.TablaAFD[i, j] = -1;
                }
            }

            AutFD.ArrAlfabeto = new char[AutFD.CardAlfabeto];
            i = 0;
            foreach (char c in ArrAlfabeto)
                AutFD.ArrAlfabeto[i++] = c;

            AutFD.NumEstados = numEdosAFD;
            AutFD.TransicionesAFD = new int[EdosAFD.Count, CardAlfabeto + 1];

            foreach (ConjIj I in EdosAFD)
            {   

                for (int columna = 0; columna < CardAlfabeto; columna++)
                {
                    Console.WriteLine((int)AutFD.ArrAlfabeto[columna]);
                    Console.WriteLine(CardAlfabeto);
                    AutFD.TransicionesAFD[I.j, columna] = I.TransicionesAFD[AutFD.ArrAlfabeto[columna]];
                    //if (columna != CardAlfabeto)
                        AutFD.TablaAFD[I.j, AutFD.ArrAlfabeto[columna]] = I.TransicionesAFD[AutFD.ArrAlfabeto[columna]];
                    //else
                        
                }
                AutFD.TablaAFD[I.j, 256] = I.TransicionesAFD[256];
            }

            AutFD.NumEstados = EdosAFD.Count;
            return AutFD;
        }


    }

   
}
