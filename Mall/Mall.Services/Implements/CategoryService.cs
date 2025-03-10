using AutoMapper;
using Mall.DTOs.Requests;
using Mall.DTOs.Responses;
using Mall.Models.Entities;
using Mall.Repositories.Interfaces;
using Mall.Services.Interfaces;
using MayNghien.Infrastructure.Request.Base;
using MayNghien.Models.Response.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using static Maynghien.Infrastructure.Helpers.SearchHelper;

namespace Mall.Services.Implements
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public CategoryService(ICategoryRepository categoryRepository, 
            IHttpContextAccessor httpContextAccessor, IMapper mapper, 
            IProductRepository productRepository, 
            UserManager<ApplicationUser> userManager)
        {
            _categoryRepository = categoryRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _productRepository = productRepository;
            _userManager = userManager;
        }

        public async Task<AppResponse<CategoryResponse>> Create(CategoryRequest request)
        {
            var result = new AppResponse<CategoryResponse>();
            try
            {
                var user = await _userManager.FindByEmailAsync(_httpContextAccessor.HttpContext?.User.Identity?.Name!);
                if (user == null)
                    return result.BuildError("Unauthorize");

                var newCategory = _mapper.Map<Category>(request);
                newCategory.Id = Guid.NewGuid();
                newCategory.Name = request.Name;
                newCategory.Description = request.Description;
                newCategory.IsPresent = true;
                newCategory.CreatedOn = DateTime.UtcNow;
                newCategory.CreatedBy = user?.Email;
                newCategory.TenantId = user?.TenantId;
                _categoryRepository.Add(newCategory);

                var response = _mapper.Map<CategoryResponse>(newCategory);
                result.BuildResult(response, "Product created successfully");
            }
            catch (Exception ex)
            {
                result.BuildError(ex.Message + " " + ex.StackTrace);
            }
            return result;
        }

        public AppResponse<string> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public AppResponse<CategoryResponse> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public AppResponse<List<CategoryResponse>> GetByPresent()
        {
            throw new NotImplementedException();
        }

        public AppResponse<List<ProductResponse>> GetListProductByCategoryId(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public AppResponse<SearchResponse<CategoryResponse>> Search(SearchRequest request)
        {
            throw new NotImplementedException();
        }

        public AppResponse<CategoryResponse> Update(CategoryRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
