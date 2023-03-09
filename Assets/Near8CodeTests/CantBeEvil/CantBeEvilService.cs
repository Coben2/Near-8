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
using Near8CodeTests.Contracts.CantBeEvil.ContractDefinition;

namespace Near8CodeTests.Contracts.CantBeEvil
{
    public partial class CantBeEvilService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, CantBeEvilDeployment cantBeEvilDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<CantBeEvilDeployment>().SendRequestAndWaitForReceiptAsync(cantBeEvilDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, CantBeEvilDeployment cantBeEvilDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<CantBeEvilDeployment>().SendRequestAsync(cantBeEvilDeployment);
        }

        public static async Task<CantBeEvilService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, CantBeEvilDeployment cantBeEvilDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, cantBeEvilDeployment, cancellationTokenSource);
            return new CantBeEvilService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public CantBeEvilService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> GetLicenseNameQueryAsync(GetLicenseNameFunction getLicenseNameFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetLicenseNameFunction, string>(getLicenseNameFunction, blockParameter);
        }

        
        public Task<string> GetLicenseNameQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetLicenseNameFunction, string>(null, blockParameter);
        }

        public Task<string> GetLicenseURIQueryAsync(GetLicenseURIFunction getLicenseURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetLicenseURIFunction, string>(getLicenseURIFunction, blockParameter);
        }

        
        public Task<string> GetLicenseURIQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetLicenseURIFunction, string>(null, blockParameter);
        }

        public Task<bool> SupportsInterfaceQueryAsync(SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        
        public Task<bool> SupportsInterfaceQueryAsync(byte[] interfaceId, BlockParameter blockParameter = null)
        {
            var supportsInterfaceFunction = new SupportsInterfaceFunction();
                supportsInterfaceFunction.InterfaceId = interfaceId;
            
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }
    }
}
