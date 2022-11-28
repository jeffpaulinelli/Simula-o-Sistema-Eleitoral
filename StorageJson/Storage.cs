using System.Text.Json;

namespace StorageJson
{
    public class Storage<T>
    {
        private static string CaminhoArquivos { get; } = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"json\";

        public bool Salvar(T obj)
        {
            try
            {
                ExistePastaJson();
                string json = JsonSerializer.Serialize(obj);
                string nomeArquivo = obj?.GetType().ToString().Split(".")[1].ToLower() + ".json";

                File.WriteAllText(Path.Combine(CaminhoArquivos + nomeArquivo), json);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<T> RecuperaJson(T obj){
            try{
                string nomeArquivo = obj?.GetType().ToString().Split(".")[1].ToLower() + ".json";
                var caminho = $"{CaminhoArquivos}{nomeArquivo}.json";
                return JsonSerializer.Deserialize<obj>(caminho);

            }catch(Exception e)
            {
                return null;
            }
        }

        private void ExistePastaJson()
        {
            if (!Directory.Exists(CaminhoArquivos))
            {
                Directory.CreateDirectory(CaminhoArquivos);
            }
        }

    }
}