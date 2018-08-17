using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Colidir : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D coll){

        if (coll.gameObject.CompareTag("player"))
        {

            Destroy(coll.gameObject);
                GameManager.Game.blackScreen.Escurecer();
                Invoke("mudarCena", 1f);

        }
        
       }
    void mudarCena(){
            SceneManager.LoadScene("IntroJogo");
    }
}

