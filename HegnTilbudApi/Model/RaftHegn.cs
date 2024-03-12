using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace HegnTilbudApi.Model
{
    public class RaftHegn
    {
        public int ID { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public int Thick { get; set; }

    }
}
