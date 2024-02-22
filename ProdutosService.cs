namespace CatalogoDemoApp;

public class ProdutosService : IProdutosService
{
    private readonly List<Produto> produtos;
    public ProdutosService()
    {
        produtos = InicializarProdutos();
    }

    private List<Produto> InicializarProdutos()
    {
        return new List<Produto>
        {
            new Produto
            {
                Descricao = "Energético Monster Jm Khaos Lata - 473ml",
                CodigoBarras = "0070847022022",
                Imagens = new[] { "https://tfdfn2.vtexassets.com/arquivos/ids/218661-1200-1200?v=638168145445630000", "https://tfdfn2.vtexassets.com/arquivos/ids/218663-1200-1200?v=638168145448400000" }
            },
            new Produto
            {
                 Descricao = "Pilha Panasonic Alcalina xom 4 Unidades - AA",
                 CodigoBarras = "7896067200032",
                 Imagens = new[] { "https://cdn-cosmos.bluesoft.com.br/products/7896067200032" }
            },
             new Produto
            {
                 Descricao = "Whey Fort 3W Baunilha - 900g",
                 CodigoBarras = "7898665433720",
                 Imagens = new[] { "https://cdn-cosmos.bluesoft.com.br/products/7898665433720" }
            },
              new Produto
            {
                 Descricao = "Barra de Chocolate Talento Recheado Torta de Limão - 85g",
                 CodigoBarras = "7891008114539",
                 Imagens = new[] { "https://cdn-cosmos.bluesoft.com.br/products/7891008114539" }
            },
               new Produto
            {
                 Descricao = "Barra de Chocolate Ovomaltine - Hershey's",
                 CodigoBarras = "7899970402876",
                 Imagens = new[] { "https://cdn-cosmos.bluesoft.com.br/products/7899970402876" }
            }, new Produto
            {
                 Descricao = "Ruffles Original - 92g",
                 CodigoBarras = "7892840816728",
                 Imagens = new[] { "https://cdn-cosmos.bluesoft.com.br/products/7892840816728" }
            }, new Produto
            {
                 Descricao = "Elma Chips Ovinhos de Amendoim - 170g",
                 CodigoBarras = "7892840814779",
                 Imagens = new[] { "https://cdn-cosmos.bluesoft.com.br/products/7892840814779" }
            }, new Produto
            {
                 Descricao = "Salgadinho Torcida - Sabor Cebola 38g",
                 CodigoBarras = "7892840820275",
                 Imagens = new[] { "https://cdn-cosmos.bluesoft.com.br/products/7892840820275" }
            }, new Produto
            {
                 Descricao = "Álcool em Gel 70% Farmax - 50g",
                 CodigoBarras = "7896902205260",
                 Imagens = new[] { "https://cdn-cosmos.bluesoft.com.br/products/7896902205260" }
            }, new Produto
            {
                 Descricao = "Aparelho de Barbear Gillette Mach3 Acqua-Grip Sensitive + 1 Carga",
                 CodigoBarras = "7500435141529",
                 Imagens = new[] { "https://cdn-cosmos.bluesoft.com.br/products/7500435141529" }
            }, new Produto
            {
                 Descricao = "Fraldas Huggies Supreme Care Jumbo Tamanho Rn - 18 Uni",
                 CodigoBarras = "7896007549627",
                 Imagens = new[] { "https://cdn-cosmos.bluesoft.com.br/products/7896007549627" }
            }, new Produto
            {
                 Descricao = "Protetor Solar Nivea Sun Toque Seco FPS70 + Creme Facial Antissinais",
                 CodigoBarras = "4006000028187",
                 Imagens = new[] { "https://cdn-cosmos.bluesoft.com.br/products/4006000028187" }
            }
        };
    }

    public Produto? ObterProduto(string ean)
    {
        return produtos.FirstOrDefault(p => p.CodigoBarras.Equals(ean, StringComparison.InvariantCultureIgnoreCase));
    }
}

public interface IProdutosService
{
    public Produto? ObterProduto(string ean);
}

public class Produto
{
    public string Descricao { get; set; }
    public string CodigoBarras { get; set; }
    public string[] Imagens { get; set; }
}

