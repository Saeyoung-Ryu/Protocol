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
    ManagingBoardCountExceed = 28,
    DashBoardManagerCountExceed = 29,
    AlreadyManagingDashBoard = 30,
    
    // 1. 멤버 닉네임 변경
    NoRightForManager = 31,
    NoRightForMaster = 32,
    // (DashBoardNotFound)
    MemberNotExist = 33,
    
    // 2. 멤버 삭제
    // (NoRightForManager)
    // (DashBoardNotFound)
    
    // 3. 매니저 관리
    // (DashBoardManagerCountExceed)
    // (ManagingBoardCountExceed)
    // (NotExistEmail)
    // (DashBoardNotFound)
    // (NoRightForMaster)
    EmailAlreadyManager = 34,
    
    // 3.5 매니저 삭제
    // (NoRightForMaster)
    
    // 4. 소개글 관리
    // (DashBoardNotFound)
    // (NoRightForMaster)
    
    // 5. 랭킹 초가화
    // (DashBoardNotFound)
    // (NoRightForManager)
    
    // 6. dismiss dashBoard (해산/탈퇴)
    // (DashBoardNotFound)
    
    
    Fail = 9999,
    End
}