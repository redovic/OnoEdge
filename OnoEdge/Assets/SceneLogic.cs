﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLogic : MonoBehaviour {
    private static SceneLogic instance;
    public static SceneLogic Instance {
        get {
            return instance;
        }
    }

    public bool isServer = false;

    #region unity callbacks
    void Awake() {
        instance = this;
    }
    void Start() {
        DontDestroyOnLoad(gameObject);
    }
    #endregion

    #region public
    public void GoToLobby(bool asServer) {
        if (asServer)
            isServer = true;

        SceneManager.LoadScene("lobby");
    }

    public void StartGame() {
        SceneManager.LoadScene("play");
    }

    #endregion

}
