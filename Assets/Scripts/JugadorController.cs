using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;


public class JugadorController : MonoBehaviour
{
    //Declaro variable tipo Rigidbody que se asosiara al Jugador
    private Rigidbody rb;

    private int contador; // Declaro variable para el contador de coleccionables

    public Text textoContador, textoGanar; // Declaro variables para los textos

    // Declaro variable para la velocidad del jugador
    public float velocidad = 10.0f; // Initialize with a default value or set it from the Inspector

    // Start is called before the first frame update
    void Start()
    { 
        //Capturo el componente Rigidbody al iniciar el juego
        rb = GetComponent<Rigidbody>();     

        contador = 0; // Inicializo el contador de coleccionables

        setTextoContador(); // Llamo a la funcion setTextoContador

        textoGanar.text = ""; // Inicializo el texto de ganar
    }

    void FixedUpdate()
    {
        //Capturo el valor de los ejes horizontal y vertical
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");

        //Creo un vector de movimiento
        Vector3 movimiento = new Vector3(movimientoH, 0.0f, movimientoV);

        //Aplico el movimiento al jugador
        rb.AddForce(movimiento * velocidad);
    }

    // se ejecuta al entrar a un objeto con la opcion IsTrigger activada
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            other.gameObject.SetActive(false);
            // Incremento el contador de coleccionables
            contador = contador + 1;

            setTextoContador(); // Llamo a la funcion setTextoContador
        }
    }

    void  setTextoContador()
    {
        textoContador.text = "Contador: " + contador.ToString();
        if (contador >= 8)
        {
            // textoGanar.text = "¡Ganaste!";
            
            // // Load the next level  
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            ganar();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private async void ganar()
    {
        textoGanar.text = "¡Ganaste!";
        await Task.Delay(3000);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
