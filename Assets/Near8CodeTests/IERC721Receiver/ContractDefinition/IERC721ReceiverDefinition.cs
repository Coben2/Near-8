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

namespace Near8CodeTests.Contracts.IERC721Receiver.ContractDefinition
{


    public partial class IERC721ReceiverDeployment : IERC721ReceiverDeploymentBase
    {
        public IERC721ReceiverDeployment() : base(BYTECODE) { }
        public IERC721ReceiverDeployment(string byteCode) : base(byteCode) { }
    }

    public class IERC721ReceiverDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public IERC721ReceiverDeploymentBase() : base(BYTECODE) { }
        public IERC721ReceiverDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class OnERC721ReceivedFunction : OnERC721ReceivedFunctionBase { }

    [Function("onERC721Received", "bytes4")]
    public class OnERC721ReceivedFunctionBase : FunctionMessage
    {
        [Parameter("address", "operator", 1)]
        public virtual string Operator { get; set; }
        [Parameter("address", "from", 2)]
        public virtual string From { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("bytes", "data", 4)]
        public virtual byte[] Data { get; set; }
    }


}
