using MessagePack;
using Protocol.Enum;

namespace Protocol
{
	public enum ProtocolId
	{
		None = 0,
		LoadData = 1,
		GetRank = 2,
		SetRank = 3,
		EditNickname = 4,
		GetMatchHistory = 5,
		Login = 6,
		SignInEmailAuthSendStep = 7,
		SignInEmailAuthVerifyStep = 8,
		SignInEmailAuthFinalStep = 9,
		CreateDashBoard = 10,
		FindDashBoard = 11,
		GetDashBoardInfo = 12,
		CheckNicknameDuplicated = 13,
		FindPasswordEmailCheck = 14,
		FindPasswordVerificationCodeCheck = 15,
		FindPasswordChangePassword = 16,
		AddDashBoardMember = 17,
		GetAddableNewMemberCount = 18,
		GetRemainingTicketCount = 19,
		InsertMatchHistory = 20,
		SetMatchHistory = 21,
		SetFavoriteBoard = 22,
		GetMySettingDashBoardInfos = 23,
		ProcessDashBoardInvite = 24,
		EditMemberNickname = 25,
		DeleteMember = 26,
		AddManager = 27,
		DeleteManager = 28,
		EditNotification = 29,
		ResetMemberRank = 30,
		DismissDashBoard = 31,
		ChangePassword = 32,
		WithdrawPlayer = 33,
		End
	}
	
	[MessagePackObject]
	[Union(0, typeof(LoadDataReq))]
	[Union(1, typeof(GetRankReq))]
	[Union(2, typeof(SetRankReq))]
	[Union(3, typeof(EditMemberNicknameReq))]
	[Union(4, typeof(GetMatchHistoryReq))]
	[Union(5, typeof(LoginReq))]
	[Union(6, typeof(SignInEmailAuthSendStepReq))]
	[Union(7, typeof(SignInEmailAuthVerifyStepReq))]
	[Union(8, typeof(SignInEmailAuthFinalStepReq))]
	[Union(9, typeof(CreateDashBoardReq))]
	[Union(10, typeof(FindDashBoardReq))]
	[Union(11, typeof(GetDashBoardInfoReq))]
	[Union(12, typeof(CheckNicknameDuplicatedReq))]
	[Union(13, typeof(FindPasswordEmailCheckReq))]
	[Union(14, typeof(FindPasswordVerificationCodeCheckReq))]
	[Union(15, typeof(FindPasswordChangePasswordReq))]
	public abstract class Protocol
	{
		[Key(0)] public ProtocolId ProtocolId { get; set; }

		public Protocol() {}
		public Protocol(ProtocolId protocolId) { ProtocolId = protocolId; }
	}
	
	[MessagePackObject]
	[Union(0, typeof(LoadDataRes))]
	[Union(1, typeof(GetRankRes))]
	[Union(2, typeof(SetRankRes))]
	[Union(3, typeof(EditMemberNicknameRes))]
	[Union(4, typeof(GetMatchHistoryRes))]
	[Union(5, typeof(LoginRes))]
	[Union(6, typeof(SignInEmailAuthSendStepRes))]
	[Union(7, typeof(SignInEmailAuthVerifyStepRes))]
	[Union(8, typeof(SignInEmailAuthFinalStepRes))]
	[Union(9, typeof(CreateDashBoardRes))]
	[Union(10, typeof(FindDashBoardRes))]
	[Union(11, typeof(GetDashBoardInfoRes))]
	[Union(12, typeof(CheckNicknameDuplicatedRes))]
	[Union(13, typeof(FindPasswordEmailCheckRes))]
	[Union(14, typeof(FindPasswordVerificationCodeCheckRes))]
	[Union(15, typeof(FindPasswordChangePasswordRes))]
	public abstract class ProtocolRes
	{
		[Key(0)] public ProtocolId ProtocolId { get; set; }
		[Key(1)] public Result Result { get; set; }

		public ProtocolRes() {}
		public ProtocolRes(ProtocolId protocolId) { ProtocolId = protocolId; }
	}
}
