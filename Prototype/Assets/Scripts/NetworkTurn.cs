using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NetworkTurn : NetworkBehaviour
{

    [SyncVar]
    NetworkIdentity currentPlayer = null;  //used to see whos turn it is
    [SyncVar]
    NetworkIdentity playerOne = null;      //to hold the NetworkIdentity of the FIRST  to join as Player ONE
    [SyncVar]
    NetworkIdentity playerTwo = null;      //to hold the NetworkIdentity of the SECOND to join as Player TWO

    // Use this for initialization

    
    void OnPlayerConnected()  ///When  Player Connects This happens
    {
        CmdAddPlayer(gameObject.GetComponent<NetworkIdentity>());
        CmdRandomTurn();
    }

    public void newTurn(NetworkIdentity ni) ///Set new turn based on whos turn it previously was
    {

        if (currentPlayer != ni)
        {

            if (playerOne == ni)
                Cmdnewturn(playerTwo);
            else if (playerTwo == ni)
                Cmdnewturn(playerOne);
        }

    }


    [Command]
    void Cmdnewturn(NetworkIdentity ni)  // Sets the new turn for the server
    {
        if (ni != currentPlayer)
       currentPlayer = ni;
    }
    [Command]
    void CmdAddPlayer(NetworkIdentity ni) //Adds player to the sync list
    {
        if (playerOne == null)
            playerOne = ni;
        else if (playerTwo == null)
            playerTwo = ni;
    }
    [Command]
    void CmdRandomTurn()
    {
        if (currentPlayer != null && playerOne == null && playerTwo == null)
            return;

        else
        {
            int rand = Random.Range(1, 2);

            if (rand == 1)
                currentPlayer = playerOne;
            if (rand == 2)
                currentPlayer = playerTwo;
        }


    }

    
    public bool checkTurn(NetworkIdentity ni) //Pass in a network id
    {
        if (ni == currentPlayer)  // if matches currentPlayer variable. returns true. 
            return true;
        else
            return false;
        
    }




}
