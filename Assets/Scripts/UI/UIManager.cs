using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Characters;

public class UIManager : MonoBehaviour
{
    public Button gunnerAttackButton;
    
    public Button swordmanAttackButton;
   
  
    public Spaceman swordman;
    public Spaceman gunner;
   

    private void Start()
    {
        gunnerAttackButton.onClick.AddListener(gunner.Attack);
        swordmanAttackButton.onClick.AddListener(swordman.Attack);  
    }
}
