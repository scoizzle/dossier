# docs/ref/contrib/staticfiles

- Subject: docs/ref/contrib/staticfiles (id `643a8248-9588-4694-a10f-24ec1691258f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 19 of 162
- Conflicts: 0
- Gaps: 0

## Facts

- $ django-admin runserver --insecure [5c843c8e]
- $ django-admin runserver --nostatic [0d83d7c1]
- @import url("../admin/css/base.27e20196a850.css"); [3e315f66]
- @import url("../admin/css/base.css"); [3f4eeccf]
- Clear the existing files before trying to copy or link the original file. [faa2cee1]
- Create a symbolic link to each file instead of copying. [dc265cbe]
- Do NOT prompt the user for input of any kind. [65df5824]
- Do everything except modify the filesystem. [99d8dca9]
- Don't call the :meth:`~django.contrib.staticfiles.storage.StaticFilesStorage.post_process` method of the configured ``staticfiles`` storage backend from :setting:`STORAGES`. [d149b9a3]
- Don't ignore the common private glob-style patterns ``'CVS'``, ``'.*'`` and ``'*~'``. [b1067cf1]
- For an introduction to the static files app and some usage examples, see :doc:`/howto/static-files/index`. For guidelines on deploying static files, see :doc:`/howto/static-files/deployment`. [81c08ec1]
- Ignore files, directories, or paths matching this glob-style pattern. Use multiple times to ignore more. When specifying a path, always use forward slashes, even on Windows. [83e234fc]
- That's because this view is **grossly inefficient** and probably **insecure**. This is only intended for local development, and should **never be used in production**. [4455cfc6b5776b47]
- This helper function will only work if :setting:`DEBUG` is ``True`` and your :setting:`STATIC_URL` setting is neither empty nor a full URL such as ``http://static.example.com/``. [91ae598f]
- This view will only work if :setting:`DEBUG` is ``True``. [729a497f]
- To guess the served files' content types, this view relies on the :mod:`mimetypes` module from the Python standard library, which itself relies on the underlying platform's map files. If you find that this view doesn't return proper content types for certain files, it is most likely that the platform's map files are incorrect or need to be updated. This can be achieved, for example, by installing or updating the ``mailcap`` package on a Red Hat distribution, ``mime-support`` on a Debian distribution, or by editing the keys under ``HKEY_CLASSES_ROOT`` in the Windows registry. [29d7606b]
- When using the optional ``integrity`` attribute within tags like ``<script>`` or ``<link>``, its value should be calculated based on the files as they are served, not as stored in the filesystem. This is particularly important because depending on how static files are collected, their checksum may have changed (for example when using :djadmin:`collectstatic`). At the moment, there is no out-of-the-box tooling available for this. [30550c6b]
- class MyManifestStaticFilesStorage(ManifestStaticFilesStorage): def __init__(self, *args, **kwargs): manifest_storage = StaticFilesStorage(location=settings.BASE_DIR) super().__init__(*args, manifest_storage=manifest_storage, **kwargs) [8ff8116e]
- class MyStaticFilesConfig(StaticFilesConfig): ignore_patterns = [...] # your custom ignore list [ca5da922]

## Beyond the budget

142 more facts did not fit in the budget: [a3facc85] [6c6b4ede] [a818098c] [dc843de4] [f9181c8d] [779fa30d] [50211fdc] [cc70f814] [d4eb4d27] [c39f377c] [6e2f07b3] [c3bbd304] [864d5eba] [518118d7] [7095fb33] [ea411bc3] [04149c63] [7fa23621] [f10d8c56] [f04acef9] [eda98dc7] [90d91384] [f4813e79] [077939a0] [5eda9a48] [73c2e5a1] [85755511] [bf743be1] [f71acf01] [d928d808] [376ffa95] [97d773b7] [54664957] [9a718130] [b644afdc] [37798991] [05314729] [480e6c7c] [56d98941] [c9dc84bbc3679963] [c9dc84bbc3679963-2] [7714e199aac2701e-100] [7714e199aac2701e-101] [7714e199aac2701e-102] [7714e199aac2701e-103] [7714e199aac2701e-104] [7714e199aac2701e-105] [7714e199aac2701e-106] [1fd512d0] [1c3e0d65] [3ea1159f] [1b1211d14c815058] [12ba4001] [2c9ed33f] [e298b5884c94dace] [0a04f021] [d24d32e6decd3db1] [79497040] [ada3ca76] [3906b139] [6e0b8b24] [e5198761] [a1eb6c3a] [e5e4de75] [46e2dc35] [d96d93ae] [f39ad630] [942ae6c11625c81c-87] [6b4a5e54e001d097-20] [c54b54cb0805732a-29] [c54b54cb0805732a-30] [da5e576f] [853dd05b] [601273ee] [76532eeb] [d7ca6985] [a04d71d6] [40341089] [ed99a15a] [52863399] [c53169f7] [4d31efe1] [4f4db575] [8c25e4b1cdb1282e] [8c25e4b1cdb1282e-2] [a7d83b09] [e18b72b6] [b5b5a714] [6981fbcb] [bc295f9831206ba3-9] [684cd768] [1de261d6] [bb16d8da] [1b3da331] [37893a63] [1b035ea5] [9090f28d] [75226f10] [644bff6e] [feac9070] [ef726707] [94005583b32250b8-5] [7d042663] [a4f21e28] [e2723c87] [165aa3c3] [533c22e9] [ae88b53b] [859d6cf7] [ebf5ae30] [84d6d25b] [fb2b3fe8] [81937830] [4d8c6deb] [5124d797] [37586c67] [928749a0] [5ef6dc07] [73ca5759] [d8e06ab1] [1fad38a0] [24d718c2] [5d5ed060] [a96aeac2] [6098cbba] [47bb7bb1] [68e99e7d] [4e42b6f3] [18fd072d] [364758cf] [e9033a9b] [a1f1772e] [7a320dcb] [b6fcc593] [954f211e] [49345f72] [f8b99260] [2d2d59e7] [ef476719] [d14a2ae6] [155f463dc5cb26f1] [70563b99]
