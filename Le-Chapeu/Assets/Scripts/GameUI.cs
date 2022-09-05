using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;


public class GameUI : MonoBehaviour
{
    public PlayerUIContainer[] playerContainers;
    public TextMeshProUGUI winText;

    void InitializePlayerUI()
    {
        //loop through all containers
        for(int x = 0; x < playerContainers.Length; ++x)
        {
            PlayerUIContainer container = playerContainers[x];

            // only enable an modify the UI containers we need
            if(x < PhotonNetwork.PlayerList.Length)
            {

            }
        }
    }
}

[System.Serializable]
public class PlayerUIContainer
{
    public GameObject obj;
    public TextMeshProUGUI nameText;
    public Slider hatTimeSlider;
}