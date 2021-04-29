using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAddressBook.Services
{
    public interface IImageService
    {
        Task<byte[]> EncodePosterAsync(IFormFile poster);

        Task<byte[]> EncodeImageURLSync(string imageURL);

        string DecodePoster(byte[] poster, string contentType);

        string RecordContentType(IFormFile poster);
    }
}
