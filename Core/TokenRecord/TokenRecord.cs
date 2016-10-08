// Copyright © 2014 - Avanade Inc.

namespace Avanade.Amp.Core.TokenRecord
{
    public class TokenRecord
    {
        public string Id { get; set; }

        public byte[] CacheBits { get; set; }
        public long LastWrite { get; set; }
    }

    public interface ITokenRecordStoreExt
    {
        void UpdateTokenRecord(TokenRecord tokenRecord);
        void DeleteTokenRecord(string id);
        TokenRecord GetTokenRecord(string id);
        string CreateTokenRecord(TokenRecord tokenRecord);
    }
}