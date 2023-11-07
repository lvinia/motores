using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI HUD, MsgVitoria;
    public int restantes;    
        
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<Moeda>().Length;

        HUD.text = $"Moedas restantes: {restantes}";

    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        
        if (restantes <= 0)
            {
                //ganhou o jogo
                msgVitoria.text = "Parabéns!";
    }
        }

    
    
    
    
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
