
using UnityEngine;

public class Ships : MonoBehaviour
{
    public int solidersTrained;
    public float timer;
    GameController gc;
    

    private int[] upgradeQtt;
    // Start is called before the first frame update
    void Start()
    {
        gc = FindObjectOfType(typeof (GameController)) as GameController;
    }

    // Update is called once per frame
    void Update()
    {        
        timer += Time.deltaTime;//Somo o valor entre as variaveis
        if(timer >= solidersTrained)
        {
            gc.AddWarriorsNum();//Adiciona um Guerreiro
            timer = 0;
        }
    }
}
