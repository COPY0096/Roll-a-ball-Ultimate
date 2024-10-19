using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;



public class RelojController : MonoBehaviour
{

    
    public Text ContadorTexto;
    public int Minutos;
    public float Segundos = 60f;
    public Color ColorAviso;
    public float SegundosLimite;
    public bool TiempoAgotado;
    public Text textoGanar;
    
    public GameManagerController gameManager;

    private void Start()
    {
        textoGanar.text = "";
        ColorAviso = Color.red;
        ActualizarContador();
    }

    private async void Update()
    {
        if (TiempoAgotado)
        {
            
            textoGanar.text = "Perdiste";

            //coloca un paro de 3 segundos antes de llamar la siguiente funcion
            await Task.Delay(3000);
            gameManager.GameOver();
            return; 
        }

        Segundos -= Time.deltaTime;

        if (Segundos <= 0)
        {
            if (Minutos == 0) 
            {
                Accion();  
            }
            else
            {
                Segundos = 60; 
                Minutos -= 1;  
            }
        }

        ActualizarContador();

        
        if (Segundos < SegundosLimite && Minutos < 1)
        {
            ContadorTexto.color = ColorAviso;
        }
    }

    public void ActualizarContador()
    {
        if (Segundos < 9.9f)
        {
            if (Minutos < 1)
            {
                ContadorTexto.text = Minutos.ToString() + ":" + Segundos.ToString("0.00");
            }
            else
            {
                ContadorTexto.text = Minutos.ToString() + ":0" + Segundos.ToString("f0");
            }
        }
        else
        {
            ContadorTexto.text = Minutos.ToString() + ":" + Segundos.ToString("f0");
        }
    }

    public void Accion()
    {
        TiempoAgotado = true; // Marca que el tiempo se ha agotado
        Debug.Log("Tiempo Agotado."); // Verifica si se ejecuta esta función
    }
}
