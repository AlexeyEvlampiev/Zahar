namespace Zahar.SqlClient.Mapping
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MappingReader : IMappingReader
    {
        private readonly string m_filePath;
        private readonly DiagnosticsCallbackScope m_diagnosticsCallback;

        public MappingReader(string filePath, IDiagnosticsCallback diagnosticsCallback)
        {
            m_filePath = filePath;
            m_diagnosticsCallback = new DiagnosticsCallbackScope( diagnosticsCallback);
        }

        public async Task<Mapping> ReadAsync()
        {
            if (!File.Exists(m_filePath))
                throw new MappingFileNotFoundException();

            await Task.FromResult<object>(null);
            using (var stream = new FileStream(m_filePath, FileMode.Open))
            {
                var serializer = new MappingSerializer(m_diagnosticsCallback);
                return serializer.Deserialize(stream);
            }
        }
    }
}
