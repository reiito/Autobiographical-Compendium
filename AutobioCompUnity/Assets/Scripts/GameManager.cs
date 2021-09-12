using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public enum GameState
{
    INTRO,
    MOVING,
    EXEC
}


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float videoStoreDelay;

    GameState gameState;
    public GameState GameState { get { return gameState; } set { gameState = value; } }

    private void Awake()
    {
        Instance = this;
        gameState = GameState.INTRO;
    }

    public IEnumerator RunVideoStore()
    {
        yield return new WaitForSeconds(videoStoreDelay);

        gameState = GameState.EXEC;

        AudioManager.Instance.PlayDoorSound();

        Process vsProcess = new Process();
        vsProcess.StartInfo.FileName = Application.dataPath + "/Unreal/AutobioCompUnreal.exe";
        vsProcess.Start();
    }
}
