using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidad = 5f;

    private Rigidbody2D rb;
    private float movimiento;

    public float alturaSalto = 4f;
    private bool esPiso; // true = está en el piso, false = está en el aire

    public Transform comprobadorPiso;
    public float radioComprobadorPiso = 0.1f;
    public LayerMask layerPiso;

    // Animator del personaje
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Obtener el Animator del personaje
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Movimiento horizontal
        movimiento = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(
            movimiento * velocidad,
            rb.linearVelocity.y
        );

        // Voltear al personaje según la dirección
        if (movimiento != 0)
        {
            transform.localScale = new Vector3(
                Mathf.Sign(movimiento),
                1,
                1
            );
        }

        // Salto
        if (Input.GetButtonDown("Jump") && esPiso)
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                alturaSalto
            );
        }

        // Enviar la velocidad al Animator
        animator.SetFloat("Velocidad", Mathf.Abs(movimiento));
    }

    void FixedUpdate()
    {
        // Comprobar si el personaje está tocando el piso
        esPiso = Physics2D.OverlapCircle(
            comprobadorPiso.position,
            radioComprobadorPiso,
            layerPiso
        );
    }
}