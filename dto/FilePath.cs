namespace forecast.DTO
{
    public class FilepathDTO
    {
        public FilepathDTO()
        {}

        public FilepathDTO(string path)
        {
            this.path = path;
        }

        public string path { get; set; }
    }
}
