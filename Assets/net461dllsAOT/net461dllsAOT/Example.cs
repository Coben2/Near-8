// using UnityEngine;
// using System.Collections;
// using System.Collections.Generic;
// using System;
// using System.Threading.Tasks;
// using Nethereum.Contracts;
// using Nethereum.Web3;
// using Newtonsoft.Json;
// using System.IO;

// public class Example : MonoBehaviour
// {
//     private Web3 web3;
//     private Contract contract;
//     private Function getMomentFunction;
//     public void Start()
//     {
//        //await start.run

//        //GetBlockNumber();
//        ConnectToEthereum();
//        GetMomentData("5").Wait();

//        async void ConnectToEthereum()
//        {
//            string quicknodeUrl = "https://long-quick-log.matic-testnet.discover.quiknode.pro/a5aa95ffcb6a3688d8e9ec815aa6a55373c4d18d/";
//            web3 = new Web3(quicknodeUrl);

//            string contractAddress = "0x6AF1F2B400c1433f3A5469CbA4122b3Ab3c4eec1";
//            string contractAbi = File.ReadAllText(@"C:\Users\skyan\Documents\GitHub\Near-8\Assets\net461dllsAOT\net461dllsAOT\ContractABI.json");

//            contract = web3.Eth.GetContract(contractAbi, contractAddress);
//            getMomentFunction = contract.GetFunction("momentIdToMoment");
//        }

//        async Task GetMomentData(string momentId)
//        {
//            var result = await getMomentFunction.CallDeserializingToObjectAsync<Moment>(momentId);
//            Debug.Log("Moment Id: " + result.momentId);
//            Debug.Log("Owner: " + result.owner);
//            Debug.Log("Name: " + result.name);
//            // and so on...
//        }

//     }

//     class Moment
//     {
//        public string momentId;
//        public string owner;
//        public string name;
//        // and so on...
//     }

//     // static void Main(string[] args)
//     // {
//     //    GetBlockNumber().Wait();
//     // }

//     // public async Task GetBlockNumber()
//     //     {
//     //         var web3 = new Web3("https://long-quick-log.matic-testnet.discover.quiknode.pro/a5aa95ffcb6a3688d8e9ec815aa6a55373c4d18d/");
//     //         var latestBlockNumber = await web3.Eth.Blocks.GetBlockNumber.SendRequestAsync();
//     //         Debug.Log($"Latest Block Number is: {latestBlockNumber}");
//     //     }
    
// }