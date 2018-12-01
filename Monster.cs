using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Monster", menuName = "Monsters")]
public class Monster : ScriptableObject {
    public int monsterDamage; //we set
    public int goldDrop; //randomized
    public int monsterRange; //we set
    public int monsterSpeed; //we set
    public int heartDrop; // randomized


    public int calcDropedHearts() {

        int random = Random.Range(0, 5);
        if (random <= 4)
            return 0;
        else
            return 1;
    }
    public int calcDropedGold()
    {
        int random = Random.Range(0, 20);
        return random;
    }
}

