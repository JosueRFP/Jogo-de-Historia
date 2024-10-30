using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class GameController: MonoBehaviour
{
    public int saveTimeRate;
    public int[] upgradePrices;
    public int warriorsNum;
    public int[] navegationUnities;
    public UnityEvent CanBuyShips;
    public GameObject[] upgrades;
    public Transform[] upgradePos;
    public TMP_Text warriorsQtdTxt;
    public Button[] upgradeBtn;

    private int[] upgradeQtt;
    float timer;
    bool canUpgrade;

    // Start is called before the first frame update
    void Start()
    {
       upgradeQtt = new int[upgrades.Length];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddWarriorsNum()
    {
        warriorsNum++;//Cria um guerreiro
        warriorsQtdTxt.text = warriorsNum.ToString();//Atualiza o texto
        if(warriorsNum >= upgradePrices[0])
        {
            if (canUpgrade)
            {
                return;
            }
            CanBuyShips.Invoke();
            canUpgrade = true;
        }
        UpgradesBTNInteractive();
        
    }

    public void UpgradesBTNInteractive()
    {
        for(int i = 0 ;i < upgradeBtn.Length; i++)
        {
            if(warriorsNum >= upgradePrices[0])// É o suficiente?
            {
                upgradeBtn[i].interactable = true;//Se tiver, interage
            }
            else
            {
                upgradeBtn[i].interactable = false;//Se não tiver, btn fica desativado
            }
        }
    }

    public void BuyShipUpgrader(int UID)
    {
        Vector2 tempPos = new Vector2(upgradePos[UID].position.x, upgradePos[UID].position.y * -(upgradeQtt[UID] - 1) * 0.5f);//Cria o upgrade 
        Instantiate(upgrades[UID], tempPos, transform.rotation);
        warriorsNum -= upgradePrices[UID];// Subtrai o numero de soldado pelo valor do upgrade
        warriorsQtdTxt.text = warriorsNum.ToString();// Sempre atualiza o texto quando o jogador fizer uma ação com os upgrades
        upgradeQtt[0]++;
        UpgradesBTNInteractive();//Verifica se tem soladados para encher os barcos
    }
}
