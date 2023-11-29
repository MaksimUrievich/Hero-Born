using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScript : MonoBehaviour
{
    public string characterClass = "Ranger";
    // Start is called before the first frame update
    void Start()
    {
        int characterHealth = 100;
        Debug.Log(characterClass + " - HP: " + characterHealth);
    }

    void CreateCharacter()
    {
        string characterName = "Aragorn";
        Debug.Log(characterName + " - " + characterClass);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
