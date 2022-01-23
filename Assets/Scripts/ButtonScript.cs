using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void Restart()
    {
        GameManager.coins = 0;
        SceneManager.LoadScene("Level1Scene");
    }
}
