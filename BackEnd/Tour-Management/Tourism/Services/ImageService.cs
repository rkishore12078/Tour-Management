using Tourism.Interfaces;
using Tourism.Models;

namespace Tourism.Services
{
    public class ImageService:IimageService
    {
        private readonly IRepo<Image, int> _imageRepo;

        public ImageService(IRepo<Image,int> imageRepo)
        {
            _imageRepo=imageRepo;
        }
        public async Task<List<Image>?> AddImage(List<Image> images)
        {
            for (int i = 0; i < images.Count; i++)
            {
                var image = await _imageRepo.Add(images[i]);
                if (image == null)
                    return null;
            }
            return images;
        }
    }
}
