using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzles : MonoBehaviour
{
    // referencias a escoger personaje:
    ChooseCharacter character;
    
    [Header("Puzle calderas")]
    [SerializeField] GameObject keyOne;
    [SerializeField] GameObject keyTwo;
    [SerializeField] GameObject keyThree;
    [SerializeField] GameObject keyFour;
    [SerializeField] GameObject vasoCaldera;
    [SerializeField] GameObject vasoPuzzle;
    TocarCaldera oneScript;
    TocarCaldera twoScript;
    TocarCaldera threeScript;
    TocarCaldera fourScript;
    
    // Start is called before the first frame update
    void Start()
    {
        oneScript = keyOne.GetComponent<TocarCaldera>();
        twoScript = keyTwo.GetComponent<TocarCaldera>();
        threeScript = keyThree.GetComponent<TocarCaldera>();
        fourScript = keyFour.GetComponent<TocarCaldera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        PuzleCaldera();
    }

    void PuzleCaldera()
    {
        if (oneScript.digit == oneScript.correctDigit)
        {
            if (twoScript.digit == twoScript.correctDigit)
            {
                if (threeScript.digit == threeScript.correctDigit)
                {
                    if (fourScript.digit == fourScript.correctDigit)
                    {
                        Debug.Log("correcto");
                        RecogerVaso();
                    }
                }
            }
        }
    }

    void RecogerVaso() 
    {
        vasoPuzzle.SetActive(true);
        vasoCaldera.SetActive(false);
    }
}
