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

namespace Near8CodeTests.Contracts.Strings.ContractDefinition
{


    public partial class StringsDeployment : StringsDeploymentBase
    {
        public StringsDeployment() : base(BYTECODE) { }
        public StringsDeployment(string byteCode) : base(byteCode) { }
    }

    public class StringsDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60566037600b82828239805160001a607314602a57634e487b7160e01b600052600060045260246000fd5b30600052607381538281f3fe73000000000000000000000000000000000000000030146080604052600080fdfea26469706673582212206b978d3d127373be68b7a5d864e9bb168a428421ac4c15486001a756779cc12d64736f6c63430008110033";
        public StringsDeploymentBase() : base(BYTECODE) { }
        public StringsDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
