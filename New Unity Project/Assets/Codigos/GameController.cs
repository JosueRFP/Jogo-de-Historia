using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class GameController: MonoBehaviour
{
    bool canUpgrade;
    public int[] upgradePrices;
    public TMP_Text warriorsTxt;
    public int warriorsNum;
    public int[] navegationUnities;
    public UnityEvent CanBuyShips;

    private int[] upgradeQtt;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < upgradeQtt[0]; i++)
        {
            Vector2 tempPos = new Vector2();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WarriorsNumQtt()
    {
        warriorsNum++;//Cria um guerreiro
        warriorsTxt.text = warriorsNum.ToString();//Atualiza o texto
        if(warriorsNum >= upgradePrices[0])
        {
            if (canUpgrade)
            {
                return;
            }
            CanBuyShips.Invoke();
            canUpgrade = true;
        }
        
    }
}
