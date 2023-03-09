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
using Near8CodeTests.Contracts.ICantBeEvil.ContractDefinition;

namespace Near8CodeTests.Contracts.ICantBeEvil
{
    public partial class ICantBeEvilService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, ICantBeEvilDeployment iCantBeEvilDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<ICantBeEvilDeployment>().SendRequestAndWaitForReceiptAsync(iCantBeEvilDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, ICantBeEvilDeployment iCantBeEvilDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<ICantBeEvilDeployment>().SendRequestAsync(iCantBeEvilDeployment);
        }

        public static async Task<ICantBeEvilService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, ICantBeEvilDeployment iCantBeEvilDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, iCantBeEvilDeployment, cancellationTokenSource);
            return new ICantBeEvilService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public ICantBeEvilService(Nethereum.Web3.Web3 web3, string contractAddress)
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
    }
}
