using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public List<int> enemies;
    void Start()
    {
        print(enemies.Count);
        print(enemies[0]); // ilk eleman?
    }

    
}
