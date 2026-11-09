# django/conf/global_settings

- Subject: django/conf/global_settings (id `e82065af-2cf4-4a6e-b35d-168a0014e6de`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 16 of 118
- Conflicts: 0
- Gaps: 0

## Facts

- """ Default Django settings. Override these with settings in the module pointed to by the DJANGO_SETTINGS_MODULE environment variable. """ [c61beb25]
- # A list of locations of additional static files STATICFILES_DIRS = [] [0bafde83]
- # A secret key for this particular Django installation. Used in secret-key # hashing algorithms. Set this in your settings, or Django will complain # loudly. SECRET_KEY = "" [09de91c3]
- # Absolute filesystem path to the directory that will hold user-uploaded files. # Example: "/var/www/example.com/media/" MEDIA_ROOT = "" [a56ad914]
- # Absolute path to the directory static files should be collected to. # Example: "/var/www/example.com/static/" STATIC_ROOT = None [e1fde6cd]
- # Apps that don't need to be serialized at test database creation time # (only apps with migrations are to start with) TEST_NON_SERIALIZED_APPS = [] [8f57fe47]
- # Boolean that sets whether to add thousand separator when formatting numbers USE_THOUSAND_SEPARATOR = False [c5e89bc0]
- # Cache to store session data if using the cache session backend. SESSION_CACHE_ALIAS = "default" # Cookie name. This can be whatever you want. SESSION_COOKIE_NAME = "sessionid" # Age of cookie, in seconds (default: 2 weeks). SESSION_COOKIE_AGE = 60 * 60 * 24 * 7 * 2 # A string like "example.com", or None for standard domain cookie. SESSION_COOKIE_DOMAIN = None # Whether the session cookie should be secure (https:// only). SESSION_COOKIE_SECURE = False # The path of the session cookie. SESSION_COOKIE_PATH = "/" # Whether to use the HttpOnly flag. SESSION_COOKIE_HTTPONLY = True # Whether to set the flag restricting cookie leaks on cross-site requests. # This can be 'Lax', 'Strict', 'None', or False to disable the flag. SESSION_COOKIE_SAMESITE = "Lax" # Whether to save the session data on every request. SESSION_SAVE_EVERY_REQUEST = False # Whether a user's session cookie expires when the web browser is closed. SESSION_EXPIRE_AT_BROWSER_CLOSE = False # The module to store session data SESSION_ENGINE = "django.contrib.sessions.backends.db" # Directory to store session files if using the file session module. If None, # the backend will use a sensible default. SESSION_FILE_PATH = None # class to serialize session data SESSION_SERIALIZER = "django.contrib.sessions.serializers.JSONSerializer" [df488254]
- # Class to use as messages backend MESSAGE_STORAGE = "django.contrib.messages.storage.fallback.FallbackStorage" [3b4a3bd3]
- # Classes used to implement DB routing behavior. DATABASE_ROUTERS = [] [bf34edfe]
- # Custom logging configuration. LOGGING = {} [2cf0c346]
- # Database connection info. If left empty, will default to the dummy backend. DATABASES = {} [e81ecdad]
- # Decimal separator symbol DECIMAL_SEPARATOR = "." [5a253f43]
- # Default X-Frame-Options header value X_FRAME_OPTIONS = "DENY" [9433d85e]
- # Default charset to use for all HttpResponse objects, if a MIME type isn't # manually specified. It's used to construct the Content-Type header. DEFAULT_CHARSET = "utf-8" [abf55a83]
- # Default primary key field type. DEFAULT_AUTO_FIELD = "django.db.models.BigAutoField" [9e022d62]

## Beyond the budget

97 more facts did not fit in the budget: [7f211a6b] [05bbbb3c] [2cdb3825] [e292ecef] [c0866eef] [83905d00] [e48af4e3] [ab477c11] [7c903c89] [65d79577] [5f94af0a] [9d6fd491] [c690fafb] [ece5bf3b] [a06d8ba7] [3ca95e7c] [8e3fa678] [0d4b3cfd] [99e3c4f4] [c2ee91b8] [27b787b1] [44f38af0] [c8254c77] [917db3ad] [1ecb899a] [a84ac226] [b51ef926] [f619f128] [525e234b] [451fc3af] [c1db9742] [1678b7bc] [0ef3ab0e] [968302ec] [8b9be551] [4aa4c851] [8f7ceb3e] [cc3abb58] [a8a092a4] [74010f7b] [a50e20b1] [f6567bcc] [47e3b9c0] [7671ff12] [a95a9fd7] [d27791d2] [e3d00c47] [e1eb8ae6] [0029d9c3] [2506427d] [ded0572c] [37900c04] [bdd67b4b] [c8babd51] [04850d54] [57de6da7] [1328ad46] [cb2118f7] [718ff4de] [0237c398] [d91fda35] [34129e1a] [f7700601] [f9845ccf] [5acf7e2a] [4296cfee] [8f7d00f9] [a75715fc] [d6d21054] [41c91de4] [75682321] [0e689f7b] [42aca2c8] [d95542e3] [80fad69d] [47bc1566] [7457f308] [3e796c75] [1f5b5ced] [0ffd58b9] [00217acf] [ea568c8d] [1f71ec8f] [44e2cb30] [2be9e181] [392d26d1] [baf194cc] [95b1c5af] [94c93cb0] [3cd92a84] [b03158e1] [e059606e] [d84f03a7] [50b458ca] [3a36bc8c] [197a5b3e] [e83c4b8d]
