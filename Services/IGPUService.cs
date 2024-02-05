using GPUTestAnalysisFeb4.Entity;

namespace GPUTestAnalysisFeb4.Services
{
    public interface IGPUService
    {
        Task<List<GPU>> GetAllGPUs();
    }
}
