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

namespace Near8CodeTests.Contracts.ICantBeEvil.ContractDefinition
{


    public partial class ICantBeEvilDeployment : ICantBeEvilDeploymentBase
    {
        public ICantBeEvilDeployment() : base(BYTECODE) { }
        public ICantBeEvilDeployment(string byteCode) : base(byteCode) { }
    }

    public class ICantBeEvilDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public ICantBeEvilDeploymentBase() : base(BYTECODE) { }
        public ICantBeEvilDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class GetLicenseNameFunction : GetLicenseNameFunctionBase { }

    [Function("getLicenseName", "string")]
    public class GetLicenseNameFunctionBase : FunctionMessage
    {

    }

    public partial class GetLicenseURIFunction : GetLicenseURIFunctionBase { }

    [Function("getLicenseURI", "string")]
    public class GetLicenseURIFunctionBase : FunctionMessage
    {

    }

    public partial class GetLicenseNameOutputDTO : GetLicenseNameOutputDTOBase { }

    [FunctionOutput]
    public class GetLicenseNameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetLicenseURIOutputDTO : GetLicenseURIOutputDTOBase { }

    [FunctionOutput]
    public class GetLicenseURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }
}
