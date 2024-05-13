using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.AddressableAssets;

public class InventorySystemAddressable : MonoBehaviour
{
    /*public AssetReferenceGameObject[] inventoryItems;
    public Transform[] spawnPositions;
    Dictionary<int, List<GameObject>> spawnedObjects = new Dictionary<int, List<GameObject>>();
    public void SpawnItem(int itemNumber)
    {
        Debug.Log("Spawning item " + itemNumber);
        if (!spawnedObjects.ContainsKey(itemNumber))//딕셔너리에 키값이 있는지 확인
        {
            spawnedObjects.Add(itemNumber, new List<GameObject>()); // 새로운 키값을 만들어 줌
        }

        if (spawnedObjects[itemNumber].Count > 0)//해당 키 값을 가지고 있는 딕셔너리의 리스트 count가 1개이상일 때
        {
            Vector3 randomPos = new Vector3(Random.Range(-0.4f, 0.4f), Random.Range(-1.5f, 1.5f), 0); // x와 y에 랜덤을 만들어
            StartCoroutine(WaitForSpawnComplete(Addressables.InstantiateAsync(inventoryItems[itemNumber], spawnPositions[itemNumber].position + randomPos, spawnPositions[itemNumber].rotation), itemNumber));//생성할 때 포지션에 랜덤값을 더한다
        }
        else//해당 키 값의 리스트에 아무것도 들어있지 않을 때
        {
            StartCoroutine(WaitForSpawnComplete(Addressables.InstantiateAsync(inventoryItems[itemNumber], spawnPositions[itemNumber].position, spawnPositions[itemNumber].rotation), itemNumber));
        }
    }

    IEnumerator WaitForSpawnComplete(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> op, int itemNumber)
    {
        while(op.IsDone == false) // 해당 동작이 준비가 안되었다면
        {
            yield return op; //준비가 될 때 까지 양보
        }

        OnSpawnComplete(op, itemNumber);
    }

    public void DespawnItem(int itemNumber)
    {
        if (spawnedObjects.TryGetValue(itemNumber, out var value)) // 딕셔너리에 해당 키에 값(리스트)이 있는지, 있다면
        {
            foreach(var entry in value) //있는 만큼 for문들 돌린다.
            {
                Addressables.ReleaseInstance(entry); // 리스트 안에 있는 오브젝트 제거
            }
            value.Clear();//리스트 클리어 ※문제 발생 예상: 리스트 자체가 사라지는게 아니라서 메모리 할당
        }
        else// 없다면
        {
            return;//끝낸다
        }
    }

    void OnSpawnComplete(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<GameObject> handle, int itemNumber)
    {
        if (spawnedObjects.TryGetValue(itemNumber, out var value)) // 딕셔너리에 해당 키에 값(리스트)이 있는지, 있다면  
        {
            value.Add(handle.Result);//해당 키에 handle을 추가
        }
        else//없다면
        {
            spawnedObjects.Add(itemNumber, new List<GameObject>() { handle.Result });//키에 리스트를 새로 만들고 handle을 추가(사실상 실행x)
        }
    }

    public void SpawnAll(int amount)//amount = 1
    {
        for (int i = 0; i < inventoryItems.Length; i++)
        {
            for (int j = 0; j < amount; j++)
            {
                SpawnItem(i);//inventoryItems에 있는 모든 오브젝트를 amount개 생성
            }
        }
    }*/
}
