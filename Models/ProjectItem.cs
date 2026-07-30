namespace Nomade.Models
{
    public class ProjectItem
    {
        public required string Id { get; set; }
        public required string Titulo { get; set; }
        public required string Descripcion { get; set; }
        public required string Imagen { get; set; }
        public required string ImagenAlt { get; set; }
        public required string GithubUrl { get; set; }
    }
}
