using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;
    public Vector3Data nextSpawn;
    public int spawnIncrement;
    public void CreateInstance ()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }
    
    public void CreateInstanceIncrement(Vector3Data obj)
    {
        Instantiate(prefab, nextSpawn.value, Quaternion.identity);
        nextSpawn.value.z += spawnIncrement;
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        foreach (var t in obj.vector3List)
        {
            Instantiate(prefab, t.value, Quaternion.identity);
        }
    }

    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);
        num++;
        if (num == obj.vector3List.Count)
        {
            num = 0;
        }
    }

    public void CreateInstanceListRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3List.Count);
        Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);
    }
    
    public void CreateInstanceIncrementListRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3List.Count);
        Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);
        foreach (var t in obj.vector3List)
        {
            t.value.z += spawnIncrement;
        }
    }
}
