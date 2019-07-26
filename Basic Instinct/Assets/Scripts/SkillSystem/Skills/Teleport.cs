using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : Skill {
    private float distance = 100f;
//     // Constructor
//     void Start() {
//         name = "Teleport";
//         cooldown = 5f;
//         // previousUseTime = -cooldown;
//     }

//     protected override void use(GameObject character) {
//         CharacterStats stats = character.GetComponent<CharacterStats>();
//         character.transform.position = new Vector3(character.transform.position.x, character.transform.position.y, character.transform.position.z + 30);

//         display(character);
//     }

//     private void display(GameObject character) {

//     }
    protected override void initialise()
    {
        skillName = "Teleport";
        cooldown = 0f;  
    }

    protected override void use()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * distance);
    }
    
    protected override void review()
    {

    }
}