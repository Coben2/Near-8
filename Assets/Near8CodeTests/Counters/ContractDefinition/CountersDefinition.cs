using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Near8CodeTests.Contracts.Counters.ContractDefinition
{


    public partial class CountersDeployment : CountersDeploymentBase
    {
        public CountersDeployment() : base(BYTECODE) { }
        public CountersDeployment(string byteCode) : base(byteCode) { }
    }

    public class CountersDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60566037600b82828239805160001a607314602a57634e487b7160e01b600052600060045260246000fd5b30600052607381538281f3fe73000000000000000000000000000000000000000030146080604052600080fdfea26469706673582212205219268a9eca50cf8770e4f17517e49181d7bfc239c24babc955f6806126008d64736f6c63430008110033";
        public CountersDeploymentBase() : base(BYTECODE) { }
        public CountersDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
