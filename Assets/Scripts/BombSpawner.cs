using UnityEngine;
using UnityEngine.Tilemaps;

public class BombSpawner : MonoBehaviour

{
    
    [SerializeField]
    private GameObject bombPrefab;  //bombPrefab has the bomb sprite
    public float delay = 2f;    //this variable is used to add delay after each bombspawn so that player can drop one bomb at a time.


    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown("space"))  //bomb drop key is used space
        {
            if (delay >= 2) //checks if there's already a bomb dropped
            {
                //Instantiate is the execute function which takes 3 parameters.
                //Prefab to get sprite/animation needed to be placed
                //position of the player where the bomb is to drop
                //Quaternion.identity so that the asset is not rotated in any direction


                Instantiate(bombPrefab, this.gameObject.transform.position, Quaternion.identity);
                delay = 0;
            }
        }
        delay += Time.deltaTime;
    }
}
