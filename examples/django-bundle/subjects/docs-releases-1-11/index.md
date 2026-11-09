# docs/releases/1.11

- Subject: docs/releases/1.11 (id `5f98839f-8aa7-4836-a686-5e423e46115a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 20 of 235
- Conflicts: 0
- Gaps: 0

## Facts

- @models.permalink def url(self): return ("guitarist_detail", [self.slug]) [fc0a657e]
- def url(self): return reverse("guitarist_detail", args=[self.slug]) [2f6c5913]
- TIME_ZONE = get_localzone().zone [1aa54f84]
- class MyModel(models.Model): ... [9b587d1ae68976c0]
- from django.db import models [4af926756c29efa6-41]
- from django.db import models from django.urls import reverse [80b3b4640d5882cf-3]
- from tzlocal import get_localzone [4bfbe5bd]
- .. _server-side cursors: https://www.psycopg.org/docs/usage.html#server-side-cursors [27230e91]
- If you have a middleware that modifies a response's content and appears before ``CommonMiddleware`` in the ``MIDDLEWARE`` or ``MIDDLEWARE_CLASSES`` settings, you must reorder your middleware so that responses aren't modified after ``Content-Length`` is set, or have the response modifying middleware reset the ``Content-Length`` header. [129352d7]
- * :attr:`.ModelAdmin.date_hierarchy` can now reference fields across relations. [5e5ad3c8]
- * :class:`~django.contrib.auth.forms.PasswordResetForm` supports custom user models that use an email field named something other than ``'email'``. Set :attr:`CustomUser.EMAIL_FIELD <django.contrib.auth.models.CustomUser.EMAIL_FIELD>` to the name of the field. [3a0642f9]
- * :class:`~django.core.serializers.json.DjangoJSONEncoder` now serializes :class:`~datetime.timedelta` objects (used by :class:`~django.db.models.DurationField`). [27dba868]
- * :class:`~django.db.models.FileField` now moves rather than copies the file it receives. With the default file upload settings, files larger than :setting:`FILE_UPLOAD_MAX_MEMORY_SIZE` now have the same permissions as temporary files (often ``0o600``) rather than the system's standard umask (often ``0o6644``). Set the :setting:`FILE_UPLOAD_PERMISSIONS` if you need the same permission regardless of file size. [4f7fc685]
- * :class:`~django.db.models.ImageField` now has a default :data:`~django.core.validators.validate_image_file_extension` validator. (This validator moved to the form field in :doc:`Django 1.11.2 </releases/1.11.2>`.) [c71731ae]
- * :class:`~django.middleware.common.CommonMiddleware` now sets the ``Content-Length`` response header for non-streaming responses. [6021d333]
- * :class:`~django.middleware.http.ConditionalGetMiddleware` no longer sets the ``Date`` header as web servers set that header. It also no longer sets the ``Content-Length`` header as this is now done by :class:`~django.middleware.common.CommonMiddleware`. [d14e76c1]
- * :class:`~django.middleware.http.ConditionalGetMiddleware` now adds the ``ETag`` header to responses. [25d4178e]
- * :djadmin:`inspectdb` no longer calls ``DatabaseIntrospection.get_indexes()`` which is deprecated. Custom database backends should ensure all types of indexes are returned by ``DatabaseIntrospection.get_constraints()``. [b30b38e1]
- * :func:`~django.contrib.auth.get_user_model` can now be called at import time, even in modules that define models. [aab751aa]
- *April 4, 2017* [7afc10e3cb48f02d-2]

## Beyond the budget

213 more facts did not fit in the budget: [19352101] [7a7f4edc] [790b1520] [2db91606] [63afd8ae] [69902b36] [0c68ade3] [a0dbf1cd] [22cb5a7c] [3dc5afa0] [31bda040] [b855f464] [ee43f103] [77a5dfc8] [2432a643] [bf7d01f6] [d864511e] [d15e0ffc] [9f06e742] [127941f3] [09ea0aac] [afdb980a] [07c24aff] [8cf4052f] [09d4e0c0] [ee499bfc] [cfd80da8] [fc8d253c] [02475cba] [3532f7f0] [e4e65db8] [9e01e230] [47a8bd32] [e1fe135c] [8e137de9] [e92aa195] [896d03b5] [bf168c42] [db835660] [db1695b2] [5a536607] [568ae3a7] [626fa3b0] [d83fde09] [fd457d3c] [deb6fd58] [f3a107a1] [fe625470] [b662ea05] [02b2ff72] [4bc88936] [e66d61b2] [a5790d2d] [7e7d3fbf] [4ad739a1] [4c4d9d50] [b02444c7] [1961af93] [5bbd1fdf] [1769b16f] [6a863e2e] [f9138785] [b22d675d] [38dfbcca] [15c363a3] [60e24f3b] [5559c223] [27aac33b] [3bf40ef0] [4855e194] [e20a867a] [ff205f1b] [34bc81ca] [08c133bb] [36d6aee9] [6f1f7468] [4a4e9243] [e990a4e9] [a4a7305d] [9798ca8d] [61c0d6d6] [722d08db] [ad408e43] [eb40acfd] [97edbf8c] [cdb838a3] [6c7158df] [ab25e209] [209b345c] [cfd8d4b2] [c32074bd] [bb2ca3fc] [db46094c] [b369514c] [a79fa6d9] [3885a7e5] [acd2e949] [b091c51f] [67e065bc] [b2153f09] [551e15fa] [4e5d20a6] [e6baefc2] [33fe0ba6] [3440c592] [721fa3a5] [31ee0db4] [95c2c777] [ce556322] [0faf4493] [0a4afbf2] [5b9cb3cf] [fbf54c82] [70e1eed3] [5c159e54] [cc844932] [c9ff6b88] [0e3d95ed] [507da4db] [d495f419] [b9701b97] [64697ae8] [0d9e4fb2] [ed12a5c5] [86144082] [b9510184] [4ae02d47] [4eeb89f0] [a3e5e9aa] [31980495] [fc33be45] [2bd5af6ca1e8da6e-2] [9208af79aedaac2a-2] [3bb227b6] [0d7f305806da573d-3] [796fd654b8a44e4f-2] [49bd3e4d] [e3c8fa42] [bfb8571a] [94a6259f] [4755786d40c065cc-2] [4027f94d73d6defd-2] [65aa28c6] [92a922eb] [80c94c9939092225-2] [81d18ad396e1bfe0-2] [01b169ad] [28362510] [84301039] [5cd4c584] [75d44f24] [ef13de7b] [db0e4e6ac0dada48-2] [68c5acd0] [629e2b9c] [123098bdb4f38b7b-2] [202897eb] [2ec17c77] [632d9888fdac6ff8-2] [3e0f4a6cb3ed25ec-2] [81a1cd28cbb21208-2] [32cecf2752c82bab-2] [7e0dde20fe81851d-3] [7e0dde20fe81851d-4] [a87288f0] [357763c49cce3029-2] [adf59950] [ae34cf4ae6f76a23-2] [d5bcfaee] [1dd9a2a5] [c1b0723dfb7860d4-2] [52d110a28852d7b2] [29b64ef38af97ab3-2] [0dd2c0a470c7b7f4-2] [d62e32fb] [2260fa6b] [e75f3438] [65b0b5e2] [9c64dee7] [73513b05] [980094e5817f4bed-2] [5b32493384882077-2] [8dd77c44] [021f12f7] [9a6d964b] [0b883b34] [82e8e17e] [51c67653] [6ddbeb0d] [a221cd23] [47879340] [a2488b1a] [d4ab240c] [38f88139] [2701f765] [e58a7711] [802e9d7c] [e2d2329d] [9956ca24] [f53550d5] [d27a2f4cf2a5e2ef-2] [0f8384c0] [8b47c62c] [f6b308ee] [45dd3663] [6b82d50b] [34f07a66] [6950f0e8] [dcbe8b94] [1e6dd759] [634a66a2] [b0e47814] [534c96a8]
