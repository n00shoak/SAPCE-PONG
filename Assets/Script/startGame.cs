using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    [SerializeField] DATA data;
    public void startG()
    {
        data.readData();
        SceneManager.LoadScene(1);
    }
}
