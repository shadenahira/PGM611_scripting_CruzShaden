using UnityEngine;
namespace Herramientas.conectividad
{

    public partial class Herramientas
    {
        public int contador;
        public int vida;

        public int calculoPuntaje()
        {
            return contador * vida;

        }

    }
}

