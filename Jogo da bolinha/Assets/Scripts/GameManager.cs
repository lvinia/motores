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
        HUD.text = $"Moedas restantes: {restantes}";
        
        if (restantes <= 0)
            {
                //ganhou o jogo
                MsgVitoria.text = "PARABÉNS";
    }
        }

    
    
    
    
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
