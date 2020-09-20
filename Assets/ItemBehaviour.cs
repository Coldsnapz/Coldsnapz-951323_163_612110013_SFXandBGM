using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    List<Vector3> _spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        _spawnPosition = new List<Vector3 >();
        _spawnPosition.Add(new Vector3(4.5f, 0.5f, 4.5f));
        _spawnPosition.Add(new Vector3(-4.5f, 0.5f, 4.5f));
        _spawnPosition.Add(new Vector3(4.5f, 0.5f, -4.5f));
        _spawnPosition.Add(new Vector3(-4.5f, 0.5f, -4.5f));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayerCollided() {
        Rigidbody rb = this.gameObject.GetComponent <Rigidbody >();
        if (rb == null)
        {
            rb = this.gameObject.AddComponent <Rigidbody >();
        }
        rb.AddForce(new Vector3(0,1,0)*10,ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SkyPlane") {
            GameObject go = Instantiate(this.gameObject,_spawnPosition[Random.Range(0, _spawnPosition.Count)],Quaternion.identity);
            
            Destroy(this.gameObject ,0.0f);
        }
    }
}
