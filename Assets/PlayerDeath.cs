using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class PlayerDeath : MonoBehaviour
=======
public class NewBehaviourScript : MonoBehaviour
>>>>>>> d5664b8ebae8d2cba4e507b3c540665b23b310ea
{
    public float fallThreshold = -10f;
    private DeathManager deathManager;

<<<<<<< HEAD
=======

>>>>>>> d5664b8ebae8d2cba4e507b3c540665b23b310ea
    void Start()
    {
        deathManager = FindObjectOfType<DeathManager>();
    }

    void Update()
    {
<<<<<<< HEAD
        if  (transform.position.y < fallThreshold)
        {
            deathManager.ShowDeathScreen();
        }

=======
        if (transform.position.y < fallThreshold)
        {
            deathManager.ShowDeathScreen();
        }
>>>>>>> d5664b8ebae8d2cba4e507b3c540665b23b310ea
    }
}
