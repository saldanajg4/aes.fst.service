using aes.fst.service.Models.METZ;

namespace aes.fst.service.Services
{
    public interface IEngAccrualService
    {
        Task<EngAccrualStatusPageModel> UpdateEngAccrual(EngAccrualStatusPageModel filter);

        Task<byte[]> GenerateMETimeSheet(EngAccrualStatusPageModel model);

        Task<List<EngAccrualStatusPageModel>> GetStatusPageList(EngAccrualFilters filters);

        Task<List<EngAccrualStatusPageModel>> GetAesProAndRfdDataToCreateTS(EngAccrualFilters filters);

        Task<string> GetSequenceValue(string sequenceName);

        Task<List<EngAccrualStatusPageModel>> GetBindersTS(EngAccrualFilters filters);

        Task<long> GetNumericSequenceValue(string sequenceName);

        Task<List<EngAccrualStatusPageModel>> GetBindersTSForAdmin(int userId);


        Task<EngAccrualStatusPageModel> GetBinderToReview(EngAccrualFilters filters);

        Task<EngAccrualStatusPageModel> CreateFst(EngAccrualFilters filters, EngAccrualHeaderInfoModel engAccrualInfo, EngAccrualStatusPageModel statusPageRow);

    }
}
