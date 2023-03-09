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

namespace Near8CodeTests.Contracts.Near8Moments.ContractDefinition
{


    public partial class Near8MomentsDeployment : Near8MomentsDeploymentBase
    {
        public Near8MomentsDeployment() : base(BYTECODE) { }
        public Near8MomentsDeployment(string byteCode) : base(byteCode) { }
    }

    public class Near8MomentsDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60806040523480156200001157600080fd5b5060046040518060400160405280600c81526020016b4e656172384d6f6d656e747360a01b815250604051806040016040528060038152602001624e384d60e81b8152508160009081620000669190620001c1565b506001620000758282620001c1565b505050620000926200008c620000c660201b60201c565b620000ca565b6007805482919060ff60a01b1916600160a01b836005811115620000ba57620000ba6200028d565b021790555050620002a3565b3390565b600780546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b634e487b7160e01b600052604160045260246000fd5b600181811c908216806200014757607f821691505b6020821081036200016857634e487b7160e01b600052602260045260246000fd5b50919050565b601f821115620001bc57600081815260208120601f850160051c81016020861015620001975750805b601f850160051c820191505b81811015620001b857828155600101620001a3565b5050505b505050565b81516001600160401b03811115620001dd57620001dd6200011c565b620001f581620001ee845462000132565b846200016e565b602080601f8311600181146200022d5760008415620002145750858301515b600019600386901b1c1916600185901b178555620001b8565b600085815260208120601f198616915b828110156200025e578886015182559484019460019091019084016200023d565b50858210156200027d5787850151600019600388901b60f8161c191681555b5050505050600190811b01905550565b634e487b7160e01b600052602160045260246000fd5b6125d680620002b36000396000f3fe608060405234801561001057600080fd5b506004361061014c5760003560e01c80638da5cb5b116100c3578063b88d4fde1161007c578063b88d4fde146102c6578063c772745a146102d9578063c7db2893146102ec578063c87b56dd146102f4578063e985e9c514610307578063f2fde38b1461031a57600080fd5b80638da5cb5b1461025657806393a0eadf1461026757806395d89b4114610290578063a22cb46514610298578063a341793b146102ab578063a9059cbb146102b357600080fd5b806323b872dd1161011557806323b872dd146101e157806342842e0e146101f4578063471b9bc0146102075780636352211e1461021a57806370a082311461022d578063715018a61461024e57600080fd5b8062f714ce1461015157806301ffc9a71461016657806306fdde031461018e578063081812fc146101a3578063095ea7b3146101ce575b600080fd5b61016461015f366004611c17565b61032d565b005b610179610174366004611c5d565b6103bb565b60405190151581526020015b60405180910390f35b6101966103cc565b6040516101859190611cca565b6101b66101b1366004611cdd565b61045e565b6040516001600160a01b039091168152602001610185565b6101646101dc366004611cf6565b610485565b6101646101ef366004611d22565b610595565b610164610202366004611d22565b6105c6565b610164610215366004611e0f565b6105e1565b6101b6610228366004611cdd565b61079a565b61024061023b366004611f4f565b6107fa565b604051908152602001610185565b610164610880565b6007546001600160a01b03166101b6565b61027a610275366004611cdd565b610894565b6040516101859a99989796959493929190611f6c565b610196610d2b565b6101646102a6366004612036565b610d3a565b610196610d49565b6101646102c1366004611cf6565b610d67565b6101646102d4366004612069565b610de9565b6101646102e73660046120e9565b610e21565b610196610ed3565b610196610302366004611cdd565b610f3a565b610179610315366004612142565b610f45565b610164610328366004611f4f565b610f73565b610335610fec565b478211156103805760405162461bcd60e51b8152602060048201526013602482015272496e73756666696369656e742046756e64732160681b60448201526064015b60405180910390fd5b6040516001600160a01b0382169083156108fc029084906000818181858888f193505050501580156103b6573d6000803e3d6000fd5b505050565b60006103c682611046565b92915050565b6060600080546103db90612170565b80601f016020809104026020016040519081016040528092919081815260200182805461040790612170565b80156104545780601f1061042957610100808354040283529160200191610454565b820191906000526020600020905b81548152906001019060200180831161043757829003601f168201915b5050505050905090565b60006104698261106b565b506000908152600460205260409020546001600160a01b031690565b60006104908261079a565b9050806001600160a01b0316836001600160a01b0316036104fd5760405162461bcd60e51b815260206004820152602160248201527f4552433732313a20617070726f76616c20746f2063757272656e74206f776e656044820152603960f91b6064820152608401610377565b336001600160a01b038216148061051957506105198133610f45565b61058b5760405162461bcd60e51b815260206004820152603e60248201527f4552433732313a20617070726f76652063616c6c6572206973206e6f7420746f60448201527f6b656e206f776e6572206e6f7220617070726f76656420666f7220616c6c00006064820152608401610377565b6103b683836110ca565b61059f3382611138565b6105bb5760405162461bcd60e51b8152600401610377906121aa565b6103b6838383611197565b6103b683838360405180602001604052806000815250610de9565b60006105ec60085490565b90506105fc600880546001019055565b60008181526009602052604090208181556001810180546001600160a01b0319163317905560020161062e8a82612246565b50600081815260096020526040902060030161064a8982612246565b5060008181526009602052604090206004016106668882612246565b5060008181526009602052604090206005016106828782612246565b50600081815260096020526040902060060161069e8682612246565b5060008181526009602052604090206007016106ba8582612246565b5060008181526009602052604090206008016106d68482612246565b5060008888888888886040516020016106f496959493929190612306565b60408051601f19818403018152918152600084815260096020819052919020919250016107218282612246565b5061072c3383611333565b610736828461134d565b8060405161074491906123b9565b604051809103902082336001600160a01b03167fb7e19d8369805e386f1d6cfb756d83d30d9ee858b67d19667619bef8b56d7313866040516107869190611cca565b60405180910390a450505050505050505050565b6000818152600260205260408120546001600160a01b0316806103c65760405162461bcd60e51b8152602060048201526018602482015277115490cdcc8c4e881a5b9d985b1a59081d1bdad95b88125160421b6044820152606401610377565b60006001600160a01b0382166108645760405162461bcd60e51b815260206004820152602960248201527f4552433732313a2061646472657373207a65726f206973206e6f7420612076616044820152683634b21037bbb732b960b91b6064820152608401610377565b506001600160a01b031660009081526003602052604090205490565b610888610fec565b61089260006113e0565b565b60096020526000908152604090208054600182015460028301805492936001600160a01b03909216926108c690612170565b80601f01602080910402602001604051908101604052809291908181526020018280546108f290612170565b801561093f5780601f106109145761010080835404028352916020019161093f565b820191906000526020600020905b81548152906001019060200180831161092257829003601f168201915b50505050509080600301805461095490612170565b80601f016020809104026020016040519081016040528092919081815260200182805461098090612170565b80156109cd5780601f106109a2576101008083540402835291602001916109cd565b820191906000526020600020905b8154815290600101906020018083116109b057829003601f168201915b5050505050908060040180546109e290612170565b80601f0160208091040260200160405190810160405280929190818152602001828054610a0e90612170565b8015610a5b5780601f10610a3057610100808354040283529160200191610a5b565b820191906000526020600020905b815481529060010190602001808311610a3e57829003601f168201915b505050505090806005018054610a7090612170565b80601f0160208091040260200160405190810160405280929190818152602001828054610a9c90612170565b8015610ae95780601f10610abe57610100808354040283529160200191610ae9565b820191906000526020600020905b815481529060010190602001808311610acc57829003601f168201915b505050505090806006018054610afe90612170565b80601f0160208091040260200160405190810160405280929190818152602001828054610b2a90612170565b8015610b775780601f10610b4c57610100808354040283529160200191610b77565b820191906000526020600020905b815481529060010190602001808311610b5a57829003601f168201915b505050505090806007018054610b8c90612170565b80601f0160208091040260200160405190810160405280929190818152602001828054610bb890612170565b8015610c055780601f10610bda57610100808354040283529160200191610c05565b820191906000526020600020905b815481529060010190602001808311610be857829003601f168201915b505050505090806008018054610c1a90612170565b80601f0160208091040260200160405190810160405280929190818152602001828054610c4690612170565b8015610c935780601f10610c6857610100808354040283529160200191610c93565b820191906000526020600020905b815481529060010190602001808311610c7657829003601f168201915b505050505090806009018054610ca890612170565b80601f0160208091040260200160405190810160405280929190818152602001828054610cd490612170565b8015610d215780601f10610cf657610100808354040283529160200191610d21565b820191906000526020600020905b815481529060010190602001808311610d0457829003601f168201915b505050505090508a565b6060600180546103db90612170565b610d45338383611432565b5050565b600754606090610d6290600160a01b900460ff16611500565b905090565b6000818152600960205260409020600101546001600160a01b03163314610d8d57600080fd5b60008181526009602052604080822060010180546001600160a01b0319166001600160a01b0386169081179091559051839233917fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef9190a45050565b610df33383611138565b610e0f5760405162461bcd60e51b8152600401610377906121aa565b610e1b8484848461168c565b50505050565b610e29610fec565b6000610e3460085490565b9050610e44600880546001019055565b600082815260096020526040902060010180546001600160a01b0319166001600160a01b038616179055610e788482611333565b610e82818461134d565b82604051610e9091906123b9565b6040519081900381209082906001600160a01b038716907faf768baa0dc8bdd34cd8971a3c3930a0849bafd83a95982cb7609b1a0129cc3e90600090a450505050565b606060405180606001604052806031815260200161257060319139600754610f1590600160a01b900460ff166005811115610f1057610f106123d5565b6116bf565b604051602001610f269291906123eb565b604051602081830303815290604052905090565b60606103c6826117c0565b6001600160a01b03918216600090815260056020908152604080832093909416825291909152205460ff1690565b610f7b610fec565b6001600160a01b038116610fe05760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610377565b610fe9816113e0565b50565b6007546001600160a01b031633146108925760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610377565b60006001600160e01b03198216630c934a3560e31b14806103c657506103c6826118c8565b6000818152600260205260409020546001600160a01b0316610fe95760405162461bcd60e51b8152602060048201526018602482015277115490cdcc8c4e881a5b9d985b1a59081d1bdad95b88125160421b6044820152606401610377565b600081815260046020526040902080546001600160a01b0319166001600160a01b03841690811790915581906110ff8261079a565b6001600160a01b03167f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b92560405160405180910390a45050565b6000806111448361079a565b9050806001600160a01b0316846001600160a01b0316148061116b575061116b8185610f45565b8061118f5750836001600160a01b03166111848461045e565b6001600160a01b0316145b949350505050565b826001600160a01b03166111aa8261079a565b6001600160a01b03161461120e5760405162461bcd60e51b815260206004820152602560248201527f4552433732313a207472616e736665722066726f6d20696e636f72726563742060448201526437bbb732b960d91b6064820152608401610377565b6001600160a01b0382166112705760405162461bcd60e51b8152602060048201526024808201527f4552433732313a207472616e7366657220746f20746865207a65726f206164646044820152637265737360e01b6064820152608401610377565b61127b6000826110ca565b6001600160a01b03831660009081526003602052604081208054600192906112a4908490612430565b90915550506001600160a01b03821660009081526003602052604081208054600192906112d2908490612443565b909155505060008181526002602052604080822080546001600160a01b0319166001600160a01b0386811691821790925591518493918716917fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef91a4505050565b610d45828260405180602001604052806000815250611918565b6000828152600260205260409020546001600160a01b03166113c85760405162461bcd60e51b815260206004820152602e60248201527f45524337323155524953746f726167653a2055524920736574206f66206e6f6e60448201526d32bc34b9ba32b73a103a37b5b2b760911b6064820152608401610377565b60008281526006602052604090206103b68282612246565b600780546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b816001600160a01b0316836001600160a01b0316036114935760405162461bcd60e51b815260206004820152601960248201527f4552433732313a20617070726f766520746f2063616c6c6572000000000000006044820152606401610377565b6001600160a01b03838116600081815260056020908152604080832094871680845294825291829020805460ff191686151590811790915591519182527f17307eab39ab6107e8899845ad3d59bd9653f200f220920489ca2b5937696c31910160405180910390a3505050565b60606006826005811115611516576115166123d5565b60ff16111561152457600080fd5b816005811115611536576115366123d5565b60000361155f5750506040805180820190915260068152655055424c494360d01b602082015290565b816005811115611571576115716123d5565b60010361159d5750506040805180820190915260098152684558434c555349564560b81b602082015290565b8160058111156115af576115af6123d5565b6002036115dc57505060408051808201909152600a81526910d3d353515490d2505360b21b602082015290565b8160058111156115ee576115ee6123d5565b600303611623575050604080518082019091526012815271434f4d4d45524349414c5f4e4f5f4841544560701b602082015290565b816005811115611635576116356123d5565b60040361166057505060408051808201909152600881526714115494d3d3905360c21b602082015290565b505060408051808201909152601081526f504552534f4e414c5f4e4f5f4841544560801b602082015290565b611697848484611197565b6116a38484848461194b565b610e1b5760405162461bcd60e51b815260040161037790612456565b6060816000036116e65750506040805180820190915260018152600360fc1b602082015290565b8160005b811561171057806116fa816124a8565b91506117099050600a836124d7565b91506116ea565b60008167ffffffffffffffff81111561172b5761172b611d63565b6040519080825280601f01601f191660200182016040528015611755576020820181803683370190505b5090505b841561118f5761176a600183612430565b9150611777600a866124eb565b611782906030612443565b60f81b818381518110611797576117976124ff565b60200101906001600160f81b031916908160001a9053506117b9600a866124d7565b9450611759565b60606117cb8261106b565b600082815260066020526040812080546117e490612170565b80601f016020809104026020016040519081016040528092919081815260200182805461181090612170565b801561185d5780601f106118325761010080835404028352916020019161185d565b820191906000526020600020905b81548152906001019060200180831161184057829003601f168201915b50505050509050600061187b60408051602081019091526000815290565b9050805160000361188d575092915050565b8151156118bf5780826040516020016118a79291906123eb565b60405160208183030381529060405292505050919050565b61118f84611a4c565b60006001600160e01b031982166380ac58cd60e01b14806118f957506001600160e01b03198216635b5e139f60e01b145b806103c657506301ffc9a760e01b6001600160e01b03198316146103c6565b6119228383611ac0565b61192f600084848461194b565b6103b65760405162461bcd60e51b815260040161037790612456565b60006001600160a01b0384163b15611a4157604051630a85bd0160e11b81526001600160a01b0385169063150b7a029061198f903390899088908890600401612515565b6020604051808303816000875af19250505080156119ca575060408051601f3d908101601f191682019092526119c791810190612552565b60015b611a27573d8080156119f8576040519150601f19603f3d011682016040523d82523d6000602084013e6119fd565b606091505b508051600003611a1f5760405162461bcd60e51b815260040161037790612456565b805181602001fd5b6001600160e01b031916630a85bd0160e11b14905061118f565b506001949350505050565b6060611a578261106b565b6000611a6e60408051602081019091526000815290565b90506000815111611a8e5760405180602001604052806000815250611ab9565b80611a98846116bf565b604051602001611aa99291906123eb565b6040516020818303038152906040525b9392505050565b6001600160a01b038216611b165760405162461bcd60e51b815260206004820181905260248201527f4552433732313a206d696e7420746f20746865207a65726f20616464726573736044820152606401610377565b6000818152600260205260409020546001600160a01b031615611b7b5760405162461bcd60e51b815260206004820152601c60248201527f4552433732313a20746f6b656e20616c7265616479206d696e746564000000006044820152606401610377565b6001600160a01b0382166000908152600360205260408120805460019290611ba4908490612443565b909155505060008181526002602052604080822080546001600160a01b0319166001600160a01b03861690811790915590518392907fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef908290a45050565b6001600160a01b0381168114610fe957600080fd5b60008060408385031215611c2a57600080fd5b823591506020830135611c3c81611c02565b809150509250929050565b6001600160e01b031981168114610fe957600080fd5b600060208284031215611c6f57600080fd5b8135611ab981611c47565b60005b83811015611c95578181015183820152602001611c7d565b50506000910152565b60008151808452611cb6816020860160208601611c7a565b601f01601f19169290920160200192915050565b602081526000611ab96020830184611c9e565b600060208284031215611cef57600080fd5b5035919050565b60008060408385031215611d0957600080fd5b8235611d1481611c02565b946020939093013593505050565b600080600060608486031215611d3757600080fd5b8335611d4281611c02565b92506020840135611d5281611c02565b929592945050506040919091013590565b634e487b7160e01b600052604160045260246000fd5b600067ffffffffffffffff80841115611d9457611d94611d63565b604051601f8501601f19908116603f01168101908282118183101715611dbc57611dbc611d63565b81604052809350858152868686011115611dd557600080fd5b858560208301376000602087830101525050509392505050565b600082601f830112611e0057600080fd5b611ab983833560208501611d79565b600080600080600080600080610100898b031215611e2c57600080fd5b883567ffffffffffffffff80821115611e4457600080fd5b611e508c838d01611def565b995060208b0135915080821115611e6657600080fd5b611e728c838d01611def565b985060408b0135915080821115611e8857600080fd5b611e948c838d01611def565b975060608b0135915080821115611eaa57600080fd5b611eb68c838d01611def565b965060808b0135915080821115611ecc57600080fd5b611ed88c838d01611def565b955060a08b0135915080821115611eee57600080fd5b611efa8c838d01611def565b945060c08b0135915080821115611f1057600080fd5b611f1c8c838d01611def565b935060e08b0135915080821115611f3257600080fd5b50611f3f8b828c01611def565b9150509295985092959890939650565b600060208284031215611f6157600080fd5b8135611ab981611c02565b8a81526001600160a01b038a16602082015261014060408201819052600090611f978382018c611c9e565b90508281036060840152611fab818b611c9e565b90508281036080840152611fbf818a611c9e565b905082810360a0840152611fd38189611c9e565b905082810360c0840152611fe78188611c9e565b905082810360e0840152611ffb8187611c9e565b90508281036101008401526120108186611c9e565b90508281036101208401526120258185611c9e565b9d9c50505050505050505050505050565b6000806040838503121561204957600080fd5b823561205481611c02565b915060208301358015158114611c3c57600080fd5b6000806000806080858703121561207f57600080fd5b843561208a81611c02565b9350602085013561209a81611c02565b925060408501359150606085013567ffffffffffffffff8111156120bd57600080fd5b8501601f810187136120ce57600080fd5b6120dd87823560208401611d79565b91505092959194509250565b6000806000606084860312156120fe57600080fd5b833561210981611c02565b9250602084013567ffffffffffffffff81111561212557600080fd5b61213186828701611def565b925050604084013590509250925092565b6000806040838503121561215557600080fd5b823561216081611c02565b91506020830135611c3c81611c02565b600181811c9082168061218457607f821691505b6020821081036121a457634e487b7160e01b600052602260045260246000fd5b50919050565b6020808252602e908201527f4552433732313a2063616c6c6572206973206e6f7420746f6b656e206f776e6560408201526d1c881b9bdc88185c1c1c9bdd995960921b606082015260800190565b601f8211156103b657600081815260208120601f850160051c8101602086101561221f5750805b601f850160051c820191505b8181101561223e5782815560010161222b565b505050505050565b815167ffffffffffffffff81111561226057612260611d63565b6122748161226e8454612170565b846121f8565b602080601f8311600181146122a957600084156122915750858301515b600019600386901b1c1916600185901b17855561223e565b600085815260208120601f198616915b828110156122d8578886015182559484019460019091019084016122b9565b50858210156122f65787850151600019600388901b60f8161c191681555b5050505050600190811b01905550565b6000875160206123198285838d01611c7a565b8184019150600f60fa1b80835289516123388160018601858e01611c7a565b6001930192830181905288516123548160028601858d01611c7a565b6002930192830181905287516123708160038601858c01611c7a565b60039301928301819052865161238c8160048601858b01611c7a565b600493019283015284516123a68160058501848901611c7a565b9091016005019998505050505050505050565b600082516123cb818460208701611c7a565b9190910192915050565b634e487b7160e01b600052602160045260246000fd5b600083516123fd818460208801611c7a565b835190830190612411818360208801611c7a565b01949350505050565b634e487b7160e01b600052601160045260246000fd5b818103818111156103c6576103c661241a565b808201808211156103c6576103c661241a565b60208082526032908201527f4552433732313a207472616e7366657220746f206e6f6e20455243373231526560408201527131b2b4bb32b91034b6b83632b6b2b73a32b960711b606082015260800190565b6000600182016124ba576124ba61241a565b5060010190565b634e487b7160e01b600052601260045260246000fd5b6000826124e6576124e66124c1565b500490565b6000826124fa576124fa6124c1565b500690565b634e487b7160e01b600052603260045260246000fd5b6001600160a01b038581168252841660208201526040810183905260806060820181905260009061254890830184611c9e565b9695505050505050565b60006020828403121561256457600080fd5b8151611ab981611c4756fe61723a2f2f7a6d63315754737049684679565938326277664149634945784c4648356c55634848554e307758673457382fa264697066735822122012172a9146cb7937d907ee0905dbad044f692e0743af9d02963cedb21cb3a21f64736f6c63430008110033";
        public Near8MomentsDeploymentBase() : base(BYTECODE) { }
        public Near8MomentsDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
    }

    public partial class CreateMomentFunction : CreateMomentFunctionBase { }

    [Function("createMoment")]
    public class CreateMomentFunctionBase : FunctionMessage
    {
        [Parameter("string", "_name", 1)]
        public virtual string Name { get; set; }
        [Parameter("string", "_coordinate", 2)]
        public virtual string Coordinate { get; set; }
        [Parameter("string", "_date", 3)]
        public virtual string Date { get; set; }
        [Parameter("string", "_time", 4)]
        public virtual string Time { get; set; }
        [Parameter("string", "_heading", 5)]
        public virtual string Heading { get; set; }
        [Parameter("string", "_height", 6)]
        public virtual string Height { get; set; }
        [Parameter("string", "_rpy", 7)]
        public virtual string Rpy { get; set; }
        [Parameter("string", "_uri", 8)]
        public virtual string Uri { get; set; }
    }

    public partial class GetApprovedFunction : GetApprovedFunctionBase { }

    [Function("getApproved", "address")]
    public class GetApprovedFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
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

    public partial class IsApprovedForAllFunction : IsApprovedForAllFunctionBase { }

    [Function("isApprovedForAll", "bool")]
    public class IsApprovedForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "operator", 2)]
        public virtual string Operator { get; set; }
    }

    public partial class MomentIdToMomentFunction : MomentIdToMomentFunctionBase { }

    [Function("momentIdToMoment", typeof(MomentIdToMomentOutputDTO))]
    public class MomentIdToMomentFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerOfFunction : OwnerOfFunctionBase { }

    [Function("ownerOf", "address")]
    public class OwnerOfFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class SafeMintFunction : SafeMintFunctionBase { }

    [Function("safeMint")]
    public class SafeMintFunctionBase : FunctionMessage
    {
        [Parameter("address", "_to", 1)]
        public virtual string To { get; set; }
        [Parameter("string", "_uri", 2)]
        public virtual string Uri { get; set; }
        [Parameter("uint256", "_momentId", 3)]
        public virtual BigInteger MomentId { get; set; }
    }

    public partial class SafeTransferFromFunction : SafeTransferFromFunctionBase { }

    [Function("safeTransferFrom")]
    public class SafeTransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class SafeTransferFrom1Function : SafeTransferFrom1FunctionBase { }

    [Function("safeTransferFrom")]
    public class SafeTransferFrom1FunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("bytes", "data", 4)]
        public virtual byte[] Data { get; set; }
    }

    public partial class SetApprovalForAllFunction : SetApprovalForAllFunctionBase { }

    [Function("setApprovalForAll")]
    public class SetApprovalForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "operator", 1)]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 2)]
        public virtual bool Approved { get; set; }
    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class SymbolFunction : SymbolFunctionBase { }

    [Function("symbol", "string")]
    public class SymbolFunctionBase : FunctionMessage
    {

    }

    public partial class TokenURIFunction : TokenURIFunctionBase { }

    [Function("tokenURI", "string")]
    public class TokenURIFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TransferFunction : TransferFunctionBase { }

    [Function("transfer")]
    public class TransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "_to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_momentId", 2)]
        public virtual BigInteger MomentId { get; set; }
    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class WithdrawFunction : WithdrawFunctionBase { }

    [Function("withdraw")]
    public class WithdrawFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "amount", 1)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("address", "ownerAddr", 2)]
        public virtual string OwnerAddr { get; set; }
    }

    public partial class ApprovalEventDTO : ApprovalEventDTOBase { }

    [Event("Approval")]
    public class ApprovalEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "approved", 2, true )]
        public virtual string Approved { get; set; }
        [Parameter("uint256", "tokenId", 3, true )]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class ApprovalForAllEventDTO : ApprovalForAllEventDTOBase { }

    [Event("ApprovalForAll")]
    public class ApprovalForAllEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "operator", 2, true )]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 3, false )]
        public virtual bool Approved { get; set; }
    }

    public partial class CreatedMomentEventDTO : CreatedMomentEventDTOBase { }

    [Event("CreatedMoment")]
    public class CreatedMomentEventDTOBase : IEventDTO
    {
        [Parameter("address", "Owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("uint256", "MomentId", 2, true )]
        public virtual BigInteger MomentId { get; set; }
        [Parameter("string", "MomentHash", 3, true )]
        public virtual string MomentHash { get; set; }
        [Parameter("string", "MomentURI", 4, false )]
        public virtual string MomentURI { get; set; }
    }

    public partial class CreatedMomentByNear8EventDTO : CreatedMomentByNear8EventDTOBase { }

    [Event("CreatedMomentByNear8")]
    public class CreatedMomentByNear8EventDTOBase : IEventDTO
    {
        [Parameter("address", "Owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("uint256", "TokenId", 2, true )]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("string", "MomentURI", 3, true )]
        public virtual string MomentURI { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class TransferEventDTO : TransferEventDTOBase { }

    [Event("Transfer")]
    public class TransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3, true )]
        public virtual BigInteger TokenId { get; set; }
    }



    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class GetApprovedOutputDTO : GetApprovedOutputDTOBase { }

    [FunctionOutput]
    public class GetApprovedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
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

    public partial class IsApprovedForAllOutputDTO : IsApprovedForAllOutputDTOBase { }

    [FunctionOutput]
    public class IsApprovedForAllOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class MomentIdToMomentOutputDTO : MomentIdToMomentOutputDTOBase { }

    [FunctionOutput]
    public class MomentIdToMomentOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "momentId", 1)]
        public virtual BigInteger MomentId { get; set; }
        [Parameter("address", "owner", 2)]
        public virtual string Owner { get; set; }
        [Parameter("string", "name", 3)]
        public virtual string Name { get; set; }
        [Parameter("string", "coordinate", 4)]
        public virtual string Coordinate { get; set; }
        [Parameter("string", "date", 5)]
        public virtual string Date { get; set; }
        [Parameter("string", "time", 6)]
        public virtual string Time { get; set; }
        [Parameter("string", "heading", 7)]
        public virtual string Heading { get; set; }
        [Parameter("string", "height", 8)]
        public virtual string Height { get; set; }
        [Parameter("string", "rpy", 9)]
        public virtual string Rpy { get; set; }
        [Parameter("string", "momentHash", 10)]
        public virtual string MomentHash { get; set; }
    }

    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnerOfOutputDTO : OwnerOfOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }











    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class SymbolOutputDTO : SymbolOutputDTOBase { }

    [FunctionOutput]
    public class SymbolOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TokenURIOutputDTO : TokenURIOutputDTOBase { }

    [FunctionOutput]
    public class TokenURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }








}
