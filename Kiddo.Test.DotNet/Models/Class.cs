namespace Kiddo.Test.Dotnet.Models;

public class Class
{
    public int SchoolID { get; set; }
    public string SchoolName { get; set; } = string.Empty;
    public string? SchoolImage { get; set; }
    public string Price { get; set; } = string.Empty;
    public int ClassId { get; set; }
    public string ClassName { get; set; } = string.Empty;
    public string FullClassName { get; set; } = string.Empty;
    public string? ClassTypeName { get; set; }
    public string ClassLevel { get; set; } = string.Empty;
    public string SessionDuration { get; set; } = string.Empty;
    public int ChildrenID { get; set; }
    public List<string>? TimeList { get; set; }
    public string? Address { get; set; }
    public string Location { get; set; } = string.Empty;
    public int TotalCount { get; set; }
    public int? ClassTypeId { get; set; }
    public string? startTime { get; set; }
    public string? endTime { get; set; }
    public bool IsClassLevelReadMore { get; set; }
    public string days { get; set; } = string.Empty;
    public int SubsequentALBCredits { get; set; }
    public string timeSlotLeft { get; set; } = string.Empty;
    public int ReviewData { get; set; }
    public bool ExclusivePartner { get; set; }
    public bool? IsSupportSpeciaNeeds { get; set; }
    public bool? IsCompanyAccrediated { get; set; }
    public string? CompanyAccrediatedAdditionalInfo { get; set; }
    public bool? IsAllInPartner { get; set; }
    public int? minAge { get; set; }
    public int? maxAge { get; set; }
    public int? RemainDays { get; set; }
    public bool IsEduHunt { get; set; }
    public decimal EduReservationFee { get; set; }
    public string? EduHuntStatus { get; set; }
    public string? EduHuntStatusCode { get; set; }
    public int? EduHuntAvailableSeat { get; set; }
    public string? categoryStatus { get; set; }
    public string? EduHuntSavePrice { get; set; }
    public string? ProgramDescription { get; set; }
    public string? TagLevel { get; set; }
    public string? TagLevelIds { get; set; }
    public bool? IsSTEMPOSB { get; set; }
    public bool? IsArtsandCulturePOSB { get; set; }
    public bool? IsFoodandHealthPOSB { get; set; }
    public bool? IsLanguageandSpeechPOSB { get; set; }
    public bool? IsSportsandDancePOSB { get; set; }
    public bool? IsEducationResourcesPOSB { get; set; }
    public string? PriceDiscountForDisplay { get; set; }
    public string? servicestatus { get; set; }
    public string? result { get; set; }
    public string? resultmessage { get; set; }
    public string? requestURL { get; set; }
}
