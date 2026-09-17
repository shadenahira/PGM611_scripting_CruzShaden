using UnityEngine;


namespace logica_de_jugador
{
    public class jugador : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

public class Enemigo
{

}
#region Mundo
namespace Herramientas
{
    namespace calculos
    {
        using logica_de_jugador;
        public class Ejemplo
        {
            public void metodoEjemplo()
            {
                jugador j;
            }
        }

    }
    namespace conectividad
    {
        public partial class Herramientas
        {

        }

    }
}

namespace Artefactos
{
    namespace actividad
    {
        using Herramientas.calculos;

        public class ControladorArtefacto
        {
            public void Ejecutar()
            {
                Ejemplo ej = new Ejemplo();
                ej.metodoEjemplo();
            }
        }
    }
}
#endregion