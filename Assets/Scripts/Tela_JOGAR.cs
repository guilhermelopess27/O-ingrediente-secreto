using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tela_JOGAR : MonoBehaviour {

    [SerializeField] private string cena;
    public void Play()
    {
        SceneManager.LoadScene(cena);
        gameObject.SetActive(false);

    }
}
