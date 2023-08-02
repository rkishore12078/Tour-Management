using Tourism.Models;

namespace Tourism.Interfaces
{
    public interface IimageService
    {
        public Task<List<Image>?> AddImage(List<Image> images);
    }
}
