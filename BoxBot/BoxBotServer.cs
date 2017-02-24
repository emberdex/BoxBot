namespace BoxBot
{
    class BoxBotServer
    {
        private string ServerAddress;
        private short ServerPort;
        private BoxBotAuthenticator Authenticator;

        public BoxBotServer(string address, short port, BoxBotAuthenticator auth)
        {
            this.Authenticator = auth;
            this.ServerPort = port;
            this.ServerAddress = address;
        }
    }
}
