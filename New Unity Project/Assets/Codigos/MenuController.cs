using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject creditsPainel;
    
    public void Teleport(string tp)
    {
        SceneManager.LoadScene(tp);
    }

    public void OpenCreditsBTN()
    {
        creditsPainel.SetActive(true);
    }
    public void CloseCreditsBTN()
    {
        creditsPainel.SetActive(false);
    }

    void Quit()
    {
        Application.Quit();
        Debug.Log("Saiu do Jogo");
    }
}
