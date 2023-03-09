using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using Near8CodeTests.Contracts.IERC721Receiver.ContractDefinition;

namespace Near8CodeTests.Contracts.IERC721Receiver
{
    public partial class IERC721ReceiverService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, IERC721ReceiverDeployment iERC721ReceiverDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<IERC721ReceiverDeployment>().SendRequestAndWaitForReceiptAsync(iERC721ReceiverDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, IERC721ReceiverDeployment iERC721ReceiverDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<IERC721ReceiverDeployment>().SendRequestAsync(iERC721ReceiverDeployment);
        }

        public static async Task<IERC721ReceiverService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, IERC721ReceiverDeployment iERC721ReceiverDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, iERC721ReceiverDeployment, cancellationTokenSource);
            return new IERC721ReceiverService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public IERC721ReceiverService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> OnERC721ReceivedRequestAsync(OnERC721ReceivedFunction onERC721ReceivedFunction)
        {
             return ContractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(OnERC721ReceivedFunction onERC721ReceivedFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }

        public Task<string> OnERC721ReceivedRequestAsync(string @operator, string from, BigInteger tokenId, byte[] data)
        {
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.Operator = @operator;
                onERC721ReceivedFunction.From = from;
                onERC721ReceivedFunction.TokenId = tokenId;
                onERC721ReceivedFunction.Data = data;
            
             return ContractHandler.SendRequestAsync(onERC721ReceivedFunction);
        }

        public Task<TransactionReceipt> OnERC721ReceivedRequestAndWaitForReceiptAsync(string @operator, string from, BigInteger tokenId, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            var onERC721ReceivedFunction = new OnERC721ReceivedFunction();
                onERC721ReceivedFunction.Operator = @operator;
                onERC721ReceivedFunction.From = from;
                onERC721ReceivedFunction.TokenId = tokenId;
                onERC721ReceivedFunction.Data = data;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(onERC721ReceivedFunction, cancellationToken);
        }
    }
}
