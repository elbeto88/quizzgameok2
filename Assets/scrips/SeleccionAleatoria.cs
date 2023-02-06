using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SeleccionAleatoria : MonoBehaviour
{
	

    public int numeroPreguntas;
	public int count = 0;
	public int countPreguntas = 0; 
    public List<int> numerosAleatorios;
    public bool stop = false;
	public GameObject[] preguntas;
	public int points = 0; 
	public GameObject panelFinal;
	public TextMeshProUGUI textoPuntos;

    // Start is called before the first frame update
    void Start()
    {
        while (!stop)
        {

            int temp = Random.Range(0, numeroPreguntas - 1);
            if (!numerosAleatorios.Contains(temp))
            {
                numerosAleatorios.Add(temp);
                count++;
            }
            if (count == numeroPreguntas - 1)
            {
                break;
            }
            PreguntaActiva();
        }
        
    }
	public void Opcioncorrecta(Button _boton)
	{
		StartCoroutine(OpcioncorrectaCoroutine(_boton));
	}
    
	public void OpcionIncorrecta(Button _boton)
	{
		StartCoroutine (OpcionIncorrectaCoroutine(_boton));
	}
	
	void Update()
	{
		if(preguntas.Length == countPreguntas)
		{
			panelFinal.SetActive(true);
			textoPuntos.text = points.ToString();
		}
	}
	
	
	
	public void PreguntaActiva()
    	{
    		if(countPreguntas!=0)
    		{
    		preguntas[numerosAleatorios[numeroPreguntas]].SetActive(false);
	    		countPreguntas++;
    		preguntas[numerosAleatorios[numeroPreguntas]].SetActive(true);
    		}
    		else
    		{
	    		preguntas[numerosAleatorios[numeroPreguntas]].SetActive(true);
	    		countPreguntas++;
    		}
 
    	}
	public IEnumerator OpcioncorrectaCoroutine(Button _boton)
	{
		_boton.image.color = Color.green;
		yield return new WaitForSeconds(1);
	    points++;
		PreguntaActiva();
	}
	public IEnumerator OpcionIncorrectaCoroutine(Button _boton)
	{
		_boton.image.color = Color.red;
		yield return new WaitForSeconds(1);
		PreguntaActiva();	
	}
}
    




