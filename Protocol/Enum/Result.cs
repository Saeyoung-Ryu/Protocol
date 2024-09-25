namespace Protocol.Enum;
public enum Result
{
    None = 0,
    EditNickNameFailed = 1,
    GetMatchHistoryFailed = 2,
    GetRankFailed = 3,
    LoadDataFailed = 4,
    SetRankFailed = 5,
    LoginFailed = 6,
    NotExistEmail = 7,
    WrongPassword = 8,
    EmailAlreadyExists = 9,
    FailedToSendVerificationCode = 10,
    WrongVerificationCode = 11,
    VerificationCodeExpired = 12,
    GetPlayerAttendanceFailed = 13,
    CreateDashBoardFailed = 14,
    DashBoardNameAlreadyExists = 15,
    DashBoardNotFound = 16,
    DuplicatedNickName = 17,
    DuplicatedNickNameCheckFailed = 18,
    DashBoardNewMemberAddedFailed = 19,
    DashBoardMemberNumberExceed = 20,
    DashBoardMemberAlreadyExists = 21,
    MasterNotExist = 22,
    PremiumBasicNotExist = 23,
    DashBoardNotManaged = 24,
    MatchHistoryAlreadyChecked = 25,
    MatchHistoryNotFound = 26,
    FavoriteDashBoardCountExceed = 27,
    
    // DashBoardInvite
    DashBoardInviteNotFound = 28,
    ManagingBoardCountExceed = 29,
    DashBoardManagerCountExceed = 30,
    AlreadyManagingDashBoard = 31,
    InviteCountExceed = 32,
    AlreadyInvited = 33,
    AuthMailLimitExceed = 34,
    
    // 1. 멤버 닉네임 변경
    NoRightForManager = 101,
    NoRightForMaster = 102,
    // (DashBoardNotFound)
    MemberNotExist = 103,
    
    // 2. 멤버 삭제
    // (NoRightForManager)
    // (DashBoardNotFound)
    
    // 3. 매니저 관리
    // (DashBoardManagerCountExceed)
    // (ManagingBoardCountExceed)
    // (NotExistEmail)
    // (DashBoardNotFound)
    // (NoRightForMaster)
    EmailAlreadyManager = 301,
    
    // 3.5 매니저 삭제
    // (NoRightForMaster)
    
    // 3.6 매니저 위임
    PremiumGradeIsLowerThanMaster = 311,
    
    // 4. 소개글 관리
    // (DashBoardNotFound)
    // (NoRightForMaster)
    
    // 5. 랭킹 초가화
    // (DashBoardNotFound)
    // (NoRightForManager)
    
    // 6. dismiss dashBoard (해산/탈퇴)
    // (DashBoardNotFound)
    UpdateMemberTooFast = 321,
    UpdateMemberNoChange = 322,
    
    AlreadyLinkedToDiscordServer = 331,
    
    PasswordWrongCountExceed = 401,
    
    Fail = 9999,
    End
}