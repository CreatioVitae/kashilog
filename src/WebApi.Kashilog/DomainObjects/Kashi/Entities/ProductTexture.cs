namespace WebApi.Kashilog.DomainObjects.Kashi {

    public class ProductTexture {
        public int ProductId { get; set; }
        public int TextureId { get; set; }

        public string TextureName { get; set; } = default!;

        public int Value { get; set; }
    }
}