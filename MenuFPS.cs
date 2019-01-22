
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;


public class MenuFPS : MonoBehaviour
{
    public Button buttonConnect;
    public Button buttonPrivateRoom;
    public InputField privateRoomName;
    public Button buttonSelectRoom;
    public InputField selectRoomName;
    public Text status;

    public void buttonConnectClicked()
    {
        if (!PhotonNetwork.IsConnected)
        {
            PhotonNetwork.ConnectUsingSettings();
            StartCoroutine(Connecting(3));
        }
    }

    public void buttonPrivateRoomClicked()
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.CreateRoom(privateRoomName.text);
            Debug.Log("Room Name: " + PhotonNetwork.CurrentRoom);
        }
    }

    public void buttonSelectRoomClicked()
    {
        if (PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinRoom(selectRoomName.text);
        }
    }

    IEnumerator Connecting(int time)
    {
        yield return new WaitForSeconds(time);
        status.text = "Connected, create or select a room...";
    }
}

