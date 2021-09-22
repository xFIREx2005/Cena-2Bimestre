using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TROCARdeCENA : MonoBehaviour
{
   public string NomeDaCena;

   public void ChangeS()
    {
        SceneManager.LoadScene(NomeDaCena);
    }
}
