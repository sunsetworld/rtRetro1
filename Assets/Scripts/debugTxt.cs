using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class debugTxt : MonoBehaviour
{
    public Transform playerCube;
    public P1Move p1Move;
    public TextMeshProUGUI locationTxt;
    public TextMeshProUGUI forwardSpeedTxt;
    public TextMeshProUGUI sidewaysSpeedTxt;
    // Start is called before the first frame update
    void Start()
    {
        UpdatePlayerLocation();
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePlayerLocation();
    }

    void UpdatePlayerLocation()
    {
        locationTxt.text = "player location: " + playerCube.transform.position;
    }

    void UpdatePlayerSpeed()
    {
        forwardSpeedTxt.text = "player forward speed: " + p1Move.ForwardForce.ToString();
        sidewaysSpeedTxt.text = "player sideways speed: " + p1Move.SidewaysForce.ToString();
    }

}
