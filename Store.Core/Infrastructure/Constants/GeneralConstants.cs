namespace Store.Core.Infrastructure.Constants
{
    public static class GeneralConstants
    {
        // String lengths
        public const int MinNameLength = 2;
        public const int MaxNameLength = 20;
        public const int MinPasswordLength = 5;
        public const int MaxPasswordLength = 30;
        public const int MinEmailLength = 4;
        public const int MaxEmaiLength = 30;
        public const int MinFileStorageNameLength = 4;
        public const int MaxFileStorageNameLength = 24;

        // Numbers validation
        public const decimal MinPrice = 0.0m;
        public const decimal MaxPrice = 1000000.0m;
        public const double MinQuantity = 0.0;
        public const double MaxQuantity = 100.0;
        public const decimal MinPricePerQuantity = 0.0m;
        public const decimal MaxPricePerQuantity = 10000m;

        //Console settings
        public const int ConsoleWindowWidth = 90;
        public const int ConsoleWindowHeight = 25;

        //Storage system settings
        public const string StorageFileExtensionName = ".txt";
        public const string DataStorageName = "FileStorage";

        // Strings for validation
        public const string StringMustBeBetweenMinAndMax = "{0} must be between {1} and {2} characters long!";
        public const string NumberMustBeBetweenMinAndMax = "{0} must be between {1} and {2}!";

        // Username pattern
        public const string UsernamePattern = "^[A-Za-z0-9]+$";
        public const string PasswordPattern = "^[A-Za-z0-9@*_-]+$";
        public const string EmailPattern = @"^(\w*)@\w*\.(com|org|bg)$";

        // User strings
        public const string InvalidSymbols = "{0} contains invalid symbols!";
        public const string UserToString = "Username: {0}, FullName: {1} {2}";
        public const string InvalidUserType = "{0} does not exist in the current context.";

        // Null strings
        public const string UserCannotBeNull = "User cannot be null!";
        public const string ProductCannotBeNull = "Product cannot be null!";
    }
}