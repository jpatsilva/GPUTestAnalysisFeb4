using GPUTestAnalysisFeb4.Data;
using GPUTestAnalysisFeb4.Entity;
using Microsoft.EntityFrameworkCore;

namespace GPUTestAnalysisFeb4.Services
{
    public class GPUService : IGPUService
    {
        private readonly DataContext _context;

        public GPUService(DataContext context) 
        {
            _context = context;
        }
        public async Task<List<GPU>> GetAllGPUs()
        {
            var gpus = await _context.GPUs.ToListAsync();
            return gpus;
        }
    }
}
