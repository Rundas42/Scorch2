using UnityEngine;
using System.Collections;

public class RetryText : MonoBehaviour 
{
    public void RetryButton()
    {
        Application.LoadLevel("NetworkTests");
    }

}
