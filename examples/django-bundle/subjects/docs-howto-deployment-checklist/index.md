# docs/howto/deployment/checklist

- Subject: docs/howto/deployment/checklist (id `b0be86ff-3e57-4fc7-819d-8ee2aa9faac9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 31 of 85
- Conflicts: 0
- Gaps: 0

## Facts

- .. _Sentry: https://docs.sentry.io/ [ae7d87bc]
- Consider using an error monitoring system such as Sentry_ before your inbox is flooded by reports. Sentry can also aggregate logs. [4a7ff611]
- SECRET_KEY = os.environ["CURRENT_SECRET_KEY"] SECRET_KEY_FALLBACKS = [ os.environ["OLD_SECRET_KEY"], ] [5ff4f35d]
- SECRET_KEY = os.environ["SECRET_KEY"] [13a024a9]
- import os [4d707266d36fc4ec]
- import os [4d707266d36fc4ec-2]
- server { listen 80 default_server; return 444; } [02b238d8]
- with open("/etc/secret_key.txt") as f: SECRET_KEY = f.read().strip() [e72beacf]
- **The secret key must be a large random value and it must be kept secret.** [d9f97e40]
- **You must never enable debug in production.** [ca02685c]
- - must be set properly for Django to provide the expected level of security; - are expected to be different in each environment; - enable optional security features; - enable performance optimizations; - provide error reporting. [7fe7b6c8]
- .. admonition:: Error reporting by email doesn't scale very well [1d892bfa]
- .. code-block:: nginx [8de1de3e]
- :setting:`ADMINS` and :setting:`MANAGERS` ----------------------------------------- [e783bc33]
- :setting:`ADMINS` will be notified of 500 errors by email. [33a67834]
- :setting:`ALLOWED_HOSTS` ------------------------ [89877fce]
- :setting:`CACHES` ----------------- [deeb80a7]
- :setting:`CONN_MAX_AGE` ----------------------- [13bebcd6]
- :setting:`CSRF_COOKIE_SECURE` ----------------------------- [a49f49a5]
- :setting:`DATABASES` -------------------- [e80553ed]
- :setting:`DEBUG` ---------------- [052e1f91]
- :setting:`LOGGING` ------------------ [e6f15cc1]
- :setting:`MAILERS` and related settings --------------------------------------- [c04f5803]
- :setting:`MANAGERS` will be notified of 404 errors. :setting:`IGNORABLE_404_URLS` can help filter out spurious reports. [ff822bac]
- :setting:`MEDIA_ROOT` and :setting:`MEDIA_URL` ---------------------------------------------- [a70092b7]
- :setting:`SECRET_KEY` --------------------- [b8614e98]
- :setting:`SESSION_COOKIE_SECURE` -------------------------------- [b4f75f05]
- :setting:`STATIC_ROOT` and :setting:`STATIC_URL` ------------------------------------------------ [5b77a6e9]
- :setting:`TEMPLATES` -------------------- [9b98b29a]
- ==================== Deployment checklist ==================== [58473edf]
- Any website which allows users to log in should enforce site-wide HTTPS to avoid transmitting access tokens in clear. In Django, access tokens include the login/password, the session cookie, and password reset tokens. (You can't do much to protect password reset tokens if you're sending them by email.) [6ef56572]

## Beyond the budget

54 more facts did not fit in the budget: [a0a47705] [eff23551] [bc1aad52] [ef7ae524] [139c83d5] [ebc5cd75] [a8d3e6cf] [f285e736] [32bce52a] [b7a99be7] [a3af3d65] [4e475576] [b7b6992b] [fac26bef] [e1ff40a6] [1cd4e6e7] [df084dac] [7e79c07b] [45bf8f0a] [a3034523] [e625b0a1] [f7fc5b67] [aaad018d] [42616a0e] [350d740c] [520a80e6] [978348fa] [8ec29c73] [07600616] [b367183f] [bf2ad430] [d6c055ad] [2627845b] [3df158ce] [4636e28c] [686f1a37] [c9d8eee2] [9312e6a6] [4664c7e23c0209b4] [e76772aa] [d623b452] [00fd1b6b] [c591c6ab] [395cd665] [ef19e7eb] [ef67f8a8] [aa41aeb3] [4de6ca9b] [06036851] [7ad24c5b] [708680dd] [fe796baf] [efcaef78] [4c716c59]
