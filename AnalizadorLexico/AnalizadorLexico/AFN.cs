using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class AFN
    {
        public static HashSet<AFN> ConjuntoAFNs = new HashSet<AFN>();
        Estado estadoInit;
        HashSet<Estado> EstadosAFN = new HashSet<Estado>();
        HashSet<Estado> EstadosAcept = new HashSet<Estado>();
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

        public AFN crerraduraPos()
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
    }

   
}
