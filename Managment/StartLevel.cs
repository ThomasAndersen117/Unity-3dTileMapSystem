using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class StartLevel : MonoBehaviour
{

    public GameManager level;
    private void Start()
    {
        level.GenerateLevel();
    }
}
