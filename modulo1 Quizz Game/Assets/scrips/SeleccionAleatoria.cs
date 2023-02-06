using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public int numeroPreguntas;
    public int count = 0;
    public List<int> numerosAleatorios;
    public bool stop = false;
    public GameObject[] preguntas;
    

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
    	public void PreguntaActiva()
    	{
    		preguntas[numerosAleatorios[0]].SetActive(true);
 
    	}

    




