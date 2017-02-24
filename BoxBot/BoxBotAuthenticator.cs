namespace BoxBot
{
    /// <summary>
    /// The current authentication method for an Authenticator object.
    /// </summary>
    enum BoxBotAuthenticationMethod
    {
        Password,
        PublicKey
    }

    /// <summary>
    /// The current authentication status for an Authenticator object. Use this to determine what went wrong during authentication.
    /// </summary>
    enum BoxBotAuthenticationStatus
    {
        Success,
        BadPassword,
        RejectedKey,
        InvalidKeyPassphrase
    }

    class BoxBotAuthenticator
    {
        /// <summary>
        /// The current authentication method for this Authenticator object.
        /// </summary>
        internal BoxBotAuthenticationMethod AuthenticationMethod;

        /// <summary>
        /// The current authentication status for this Authenticator object. Use this to determine what went wrong during the authentication process.
        /// </summary>
        internal BoxBotAuthenticationStatus Status;

        /// <summary>
        /// The path to the private key to be used when authenticating with the remote server. Can only be updated if this.AuthenticationMethod is equal to PublicKey.
        /// </summary>
        internal string PrivateKeyPath
        {
            set
            {
                if (this.AuthenticationMethod == BoxBotAuthenticationMethod.PublicKey)
                {
                    this.PrivateKeyPath = value;
                }
            }
        }

        /// <summary>
        /// The username to authenticate with on the remote server.
        /// </summary>
        internal string Username;

        /// <summary>
        /// The password to be used when authenticating with the remote server. Can only be updated if this.AuthenticationMethod is equal to Password.
        /// </summary>
        internal string Password
        {
            set
            {
                if (this.AuthenticationMethod == BoxBotAuthenticationMethod.Password)
                {
                    this.Password = value;
                }
            }
        }

        /// <summary>
        /// The passphrase for the private key, if any. Can only be updated if this.AuthenticationMethod is equal to PublicKey.
        /// </summary>
        internal string PrivateKeyPassphrase
        {
            set
            {
                if (this.AuthenticationMethod == BoxBotAuthenticationMethod.PublicKey)
                {
                    this.PrivateKeyPassphrase = value;
                }
            }
        }

        /// <summary>
        /// Constructor for the Authenticator class, using publickey authentication.
        /// </summary>
        /// <param name="Username">The username with which to log into the remote server.</param>
        /// <param name="PrivateKeyPath">The path to the private key.</param>
        /// <param name="PrivateKeyPassword">Optionally, the passphrase to the private key, if one is required.</param>
        public BoxBotAuthenticator(string Username, string PrivateKeyPath,
            string PrivateKeyPassword = "")
        {
            // We're using the constructor for publickey authentication, so we can set the auth method now.
            this.AuthenticationMethod = BoxBotAuthenticationMethod.PublicKey;
            this.Username = Username;
            this.PrivateKeyPassphrase = PrivateKeyPassword;
            this.PrivateKeyPath = PrivateKeyPath;
        }

        /// <summary>
        /// Constructor for the Authenticator class, using password authentication.
        /// </summary>
        /// <param name="Username">The username with which to log into the remote server.</param>
        /// <param name="Password">The password with which to authenticate.</param>
        public BoxBotAuthenticator(string Username, string Password)
        {
            // We're using the constructor for password-based auth, so we can set the auth method now.
            this.AuthenticationMethod = BoxBotAuthenticationMethod.Password;
            this.Username = Username;
            this.Password = Password;
        }
    }
}