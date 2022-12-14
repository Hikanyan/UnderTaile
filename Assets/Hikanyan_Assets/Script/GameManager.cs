using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingletonBehaviour<GameManager>
{
    [SerializeField, Tooltip("部屋の番号")] int _loomNum;
    [SerializeField] int _loomIntensity;


    
    void ChangeScene()
    {
        SceneManager.LoadScene(_loomIntensity);
    } 
}
