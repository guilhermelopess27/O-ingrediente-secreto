using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour {

    private string proximaCena;

    public void DeslocarCena(string cena)
    {
        proximaCena = cena;
		GameManager.Game.blackScreen.Escurecer();
        Invoke("MudaCena", 1f);
    }

    void MudaCena(){
        SceneManager.LoadScene(proximaCena);
    }
    
}

