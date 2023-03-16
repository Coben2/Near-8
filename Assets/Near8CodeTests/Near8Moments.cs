using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using Nethereum RPC
using Nethereum.JsonRpc.UnityClient;
// using contract definition
using Near8CodeTests.Contracts.Near8Moments.ContractDefinition; //
using TMPro; //

public class Near8Moments : MonoBehaviour
{
    public int momentIndex;
    public TMP_Text CoordinateText; //
  // Start is called before the first frame update
  void Start()
  {
    StartCoroutine(FetchMomentDetails());
  }

  private IEnumerator FetchMomentDetails()
  {
    // connect to polygon mumbai testnet
    string url = "https://long-quick-log.matic-testnet.discover.quiknode.pro/a5aa95ffcb6a3688d8e9ec815aa6a55373c4d18d/";
    // near8moment contract address
    string contractAddress = "0x6AF1F2B400c1433f3A5469CbA4122b3Ab3c4eec1";
    // fetch moment details
    //int momentIndex = 5;
    var queryRequest = new QueryUnityRequest<MomentIdToMomentFunction, MomentIdToMomentOutputDTOBase>(url, contractAddress);
    // call MomentIdToMomentFunctionBas with 1 param (momentIndex) to get the moment details
    yield return queryRequest.Query(new MomentIdToMomentFunction() { ReturnValue1 = momentIndex }, contractAddress);
    // print in console
    Debug.Log("Owner: " + queryRequest.Result.Owner);
    Debug.Log("Name: " + queryRequest.Result.Name);
    Debug.Log("Coordinate: " + queryRequest.Result.Coordinate);
    Debug.Log("Date: " + queryRequest.Result.Date);
    Debug.Log("Time: " + queryRequest.Result.Time);
    Debug.Log("Heading: " + queryRequest.Result.Heading);
    Debug.Log("RPY: " + queryRequest.Result.Rpy);
    Debug.Log("MomentHash: " + queryRequest.Result.MomentHash);
        CoordinateText.text = queryRequest.Result.MomentHash; //
     Destroy(gameObject);
  }
}
