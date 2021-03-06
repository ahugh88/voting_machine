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

namespace _solidity.Contracts.Ballot.ContractDefinition
{


    public partial class BallotDeployment : BallotDeploymentBase
    {
        public BallotDeployment() : base(BYTECODE) { }
        public BallotDeployment(string byteCode) : base(byteCode) { }
    }

    public class BallotDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801561001057600080fd5b506040516108d73803806108d78339818101604052602081101561003357600080fd5b810190808051604051939291908464010000000082111561005357600080fd5b90830190602082018581111561006857600080fd5b825186602082028301116401000000008211171561008557600080fd5b82525081516020918201928201910280838360005b838110156100b257818101518382015260200161009a565b50505050919091016040908152600080546001600160a01b03191633178082556001600160a01b03168152600160208190529181209190915593505050505b8151811015610153576002604051806040016040528084848151811061011357fe5b60209081029190910181015182526000918101829052835460018181018655948352918190208351600290930201918255919091015190820155016100f1565b5050610773806101646000396000f3fe608060405234801561001057600080fd5b50600436106100885760003560e01c8063609ff1bd1161005b578063609ff1bd1461012c5780639e7b8d6114610146578063a3ec138d1461016c578063e2ba53f0146101c057610088565b80630121b93f1461008d578063013cf08b146100ac5780632e4176cf146100e25780635c19a95c14610106575b600080fd5b6100aa600480360360208110156100a357600080fd5b50356101c8565b005b6100c9600480360360208110156100c257600080fd5b50356102bc565b6040805192835260208301919091528051918290030190f35b6100ea6102e7565b604080516001600160a01b039092168252519081900360200190f35b6100aa6004803603602081101561011c57600080fd5b50356001600160a01b03166102f6565b61013461054a565b60408051918252519081900360200190f35b6100aa6004803603602081101561015c57600080fd5b50356001600160a01b03166105b1565b6101926004803603602081101561018257600080fd5b50356001600160a01b03166106ac565b6040805194855292151560208501526001600160a01b03909116838301526060830152519081900360800190f35b6101346106e0565b336000908152600160205260409020805461022a576040805162461bcd60e51b815260206004820152601a60248201527f486173206e6f20726967687420726967687420746f20766f7465000000000000604482015290519081900360640190fd5b600181015460ff1615610275576040805162461bcd60e51b815260206004820152600e60248201526d20b63932b0b23c903b37ba32b21760911b604482015290519081900360640190fd5b6001818101805460ff191690911790556002808201839055815481549091908490811061029e57fe5b60009182526020909120600160029092020101805490910190555050565b600281815481106102c957fe5b60009182526020909120600290910201805460019091015490915082565b6000546001600160a01b031681565b3360009081526001602052604090208054610358576040805162461bcd60e51b815260206004820152601960248201527f596f752068617665206e6f20726967687420746f20766f746500000000000000604482015290519081900360640190fd5b600181015460ff16156103a6576040805162461bcd60e51b8152602060048201526011602482015270165bdd48185b1c9958591e481d9bdd1959607a1b604482015290519081900360640190fd5b6001600160a01b038216331415610404576040805162461bcd60e51b815260206004820152601d60248201527f53656c662d64656c65676174696f6e20697320646973616c6c6f776564000000604482015290519081900360640190fd5b6001600160a01b0382811660009081526001602081905260409091200154610100900416156104ae576001600160a01b0391821660009081526001602081905260409091200154610100900490911690338214156104a9576040805162461bcd60e51b815260206004820152601960248201527f466f756e64206c6f6f7020696e2064656c65676174696f6e2e00000000000000604482015290519081900360640190fd5b610404565b6001600160a01b03821660009081526001602081905260409091208054909111156104d857600080fd5b6001828101805460ff19168217610100600160a81b0319166101006001600160a01b0387160217905581015460ff161561053d5781546002828101548154811061051e57fe5b6000918252602090912060016002909202010180549091019055610545565b815481540181555b505050565b600080805b6002548110156105ac57816002828154811061056757fe5b90600052602060002090600202016001015411156105a4576002818154811061058c57fe5b90600052602060002090600202016001015491508092505b60010161054f565b505090565b6000546001600160a01b031633146105fa5760405162461bcd60e51b815260040180806020018281038252603081526020018061070e6030913960400191505060405180910390fd5b6001600160a01b0381166000908152600160208190526040909120015460ff161561066c576040805162461bcd60e51b815260206004820152601860248201527f54686520766f74657220616c726561647920766f7465642e0000000000000000604482015290519081900360640190fd5b6001600160a01b0381166000908152600160205260409020541561068f57600080fd5b6001600160a01b0316600090815260016020819052604090912055565b600160208190526000918252604090912080549181015460029091015460ff82169161010090046001600160a01b03169084565b600060026106ec61054a565b815481106106f657fe5b90600052602060002090600202016000015490509056fe4f6e6c7920746865206368616972706572736f6e2063616e20676976652074686520726967687420746f20766f74652ea264697066735822122098d41f3a382efa4f58ef58a850d7a2476cf817733f53431711d1bbfeb6fc078064736f6c63430007000033";
        public BallotDeploymentBase() : base(BYTECODE) { }
        public BallotDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("bytes32[]", "proposalNames", 1)]
        public virtual List<byte[]> ProposalNames { get; set; }
    }

    public partial class ChairpersonFunction : ChairpersonFunctionBase { }

    [Function("chairperson", "address")]
    public class ChairpersonFunctionBase : FunctionMessage
    {

    }

    public partial class DelegateFunction : DelegateFunctionBase { }

    [Function("delegate")]
    public class DelegateFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
    }

    public partial class GiveRightToVoteFunction : GiveRightToVoteFunctionBase { }

    [Function("giveRightToVote")]
    public class GiveRightToVoteFunctionBase : FunctionMessage
    {
        [Parameter("address", "voter", 1)]
        public virtual string Voter { get; set; }
    }

    public partial class ProposalsFunction : ProposalsFunctionBase { }

    [Function("proposals", typeof(ProposalsOutputDTO))]
    public class ProposalsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class VoteFunction : VoteFunctionBase { }

    [Function("vote")]
    public class VoteFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "proposal", 1)]
        public virtual BigInteger Proposal { get; set; }
    }

    public partial class VotersFunction : VotersFunctionBase { }

    [Function("voters", typeof(VotersOutputDTO))]
    public class VotersFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class WinnerNameFunction : WinnerNameFunctionBase { }

    [Function("winnerName", "bytes32")]
    public class WinnerNameFunctionBase : FunctionMessage
    {

    }

    public partial class WinningProposalFunction : WinningProposalFunctionBase { }

    [Function("winningProposal", "uint256")]
    public class WinningProposalFunctionBase : FunctionMessage
    {

    }

    public partial class ChairpersonOutputDTO : ChairpersonOutputDTOBase { }

    [FunctionOutput]
    public class ChairpersonOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }





    public partial class ProposalsOutputDTO : ProposalsOutputDTOBase { }

    [FunctionOutput]
    public class ProposalsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "name", 1)]
        public virtual byte[] Name { get; set; }
        [Parameter("uint256", "voteCount", 2)]
        public virtual BigInteger VoteCount { get; set; }
    }



    public partial class VotersOutputDTO : VotersOutputDTOBase { }

    [FunctionOutput]
    public class VotersOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "weight", 1)]
        public virtual BigInteger Weight { get; set; }
        [Parameter("bool", "voted", 2)]
        public virtual bool Voted { get; set; }
        [Parameter("address", "delegate", 3)]
        public virtual string Delegate { get; set; }
        [Parameter("uint256", "vote", 4)]
        public virtual BigInteger Vote { get; set; }
    }

    public partial class WinnerNameOutputDTO : WinnerNameOutputDTOBase { }

    [FunctionOutput]
    public class WinnerNameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "winnerName_", 1)]
        public virtual byte[] WinnerName_ { get; set; }
    }

    public partial class WinningProposalOutputDTO : WinningProposalOutputDTOBase { }

    [FunctionOutput]
    public class WinningProposalOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "winningProposal_", 1)]
        public virtual BigInteger WinningProposal_ { get; set; }
    }
}
