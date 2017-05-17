namespace PMSystem.Entities
{
    public class ProjectImage
    {
        public int ProjectId { get; set; }

        public byte[] ImageContent { get; set; }

        public string ImageFileName { get; set; }

        public long ImageFileLength { get; set; }

        public string ImageContentType { get; set; }

        public ProjectImage(int projectId, byte[] imageContent, string imageFileName, long imageFileLength, string imageContentType)
        {
            ProjectId = projectId;
            ImageContent = imageContent;
            ImageFileName = imageFileName;
            ImageFileLength = imageFileLength;
            ImageContentType = imageContentType;
        }
    }
}
