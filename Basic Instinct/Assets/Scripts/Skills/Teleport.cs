using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : Skill {
    // Constructor
    public Teleport() {
        name = "Teleport";
        cooldown = 5f;
        // previousUseTime = -cooldown;
    }

    protected override void use(GameObject character) {
        CharacterStats stats = character.GetComponent<CharacterStats>();
        character.transform.position = new Vector3(character.transform.position.x, character.transform.position.y, character.transform.position.z + 30);

        display(character);
    }

    private void display(GameObject character) {

    }
}