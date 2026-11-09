# docs/releases/1.2

- Subject: docs/releases/1.2 (id `420a5ac9-ac13-4369-9be4-d3389dc6b3e6`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 26 of 309
- Conflicts: 0
- Gaps: 0

## Facts

- # ... [820935f903511f30-3]
- >>> from django.db.models import get_app, get_models >>> get_models(get_app("gis")) [] [e86ca06b]
- def db_type(self): ... [c56ea807]
- def db_type(self, connection): ... [35e5915c]
- def get_db_prep_lookup(self, lookup_type, value): ... [5b8c2aee]
- def get_db_prep_lookup(self, lookup_type, value, connection, prepared=False): ... [b7556689]
- def get_db_prep_save(self, value): ... [adbc07fe]
- def get_db_prep_value(self, value, connection, prepared=False): ... [65a6163b]
- def get_prep_value(self, value): ... [b5da0118]
- sr_qs = SpatialRefSys.objects.using("my_spatialite").filter(...) gc_qs = GeometryColumns.objects.using("my_postgis").filter(...) [226497c0]
- <div {% if user.email|lower == message.recipient|lower %} class="highlight" {% endif %} >{{ message }}</div> [84b687ac]
- >>> from django.db import connections >>> SpatialRefSys = connections["my_spatialite"].ops.spatial_ref_sys() >>> GeometryColumns = connections["my_postgis"].ops.geometry_columns() [16a431b6]
- The upgrade notes have been removed in current Django docs. Please refer to the docs for Django 1.3 or older to find these instructions. [5613a52b7cbe645f]
- .. code-block:: pycon [eaf050be34acb41d-611]
- .. code-block:: pycon [eaf050be34acb41d-612]
- :ref:`1.2-js-assisted-inlines` [7630d430]
- Because the table structure of the OGC spatial metadata tables differs across spatial databases, the ``SpatialRefSys`` and ``GeometryColumns`` models can no longer be associated with the ``gis`` application name. Thus, no models will be returned when using the ``get_models`` method in the following example: [c141a73b]
- DATABASES = { "default": { "NAME": "test_db", "ENGINE": "django.db.backends.postgresql_psycopg2", "USER": "myusername", "PASSWORD": "s3krit", } } [ffb7fe57]
- DATABASE_NAME = "test_db" DATABASE_ENGINE = "postgresql_psycopg2" DATABASE_USER = "myusername" DATABASE_PASSWORD = "s3krit" [28fa457e]
- For more details, see the documentation :doc:`Django's release process </internals/release-process>` and our :doc:`deprecation timeline </internals/deprecation>`.` [e0b32535]
- PostGISAdaptor = connection.ops.Adapter [bd13bb9c]
- When using the models returned from the ``spatial_ref_sys()`` and ``geometry_columns()`` method, you'll still need to use the correct database alias when querying on the non-default connection. In other words, to ensure that the models in the example above use the correct database:: [0cced6e0]
- __members__ = property(lambda self: self.__dir__()) [03df0866]
- `Django Advent`_ covered the release of Django 1.2 with a series of articles and tutorials that cover some of the new features in depth. [906fc70e]
- class CustomModelField(models.Field): ... [cbe4cee4c4b4d041]
- class LatestEntriesByCategory(Feed): def get_object(self, request, category_id): return get_object_or_404(Category, id=category_id) [08f85161]

## Beyond the budget

263 more facts did not fit in the budget: [30408147] [8eaed4df] [4b5dbb9b] [9ee8fd3f] [1ba0605b] [088fa5fb] [1639bf88] [4c1ea5da] [53a9b68f] [70240740] [b801a824] [1143c031d2854603] [c05c3ad0030e2165-4] [30f9a70a] [4e50e643] [435e3364] [e24aec43cb74f05e] [89aade5c] [37ef7148cf6f0f4b] [ea54f5c3e43fe11a] [4467a5f4] [2883162e] [d68dd761] [5f4dfeba] [6abb4f60] [f85e9a2f] [a0b65703] [bd947c62] [8de3a17f] [8986d27b] [543047b0] [f44b21b91f62f4e2] [ac0a2085] [cb804723] [d6fa3a64] [bed24234] [b42c7cb1] [890e7bf5] [b375fcb3] [358efeab] [cfb68b67] [5856765c] [be5efe4b] [abd5689c] [dcb74992] [bbb3f00a] [c7ba76ab] [b3301da1] [fa7960ae] [8b939745] [92900704] [3f4f6fe41b1b8818-2] [c2c68002] [222e052b] [5893cedc] [e861ae42] [239ba7ee] [e062708b] [87b9b183] [cfeeedd9] [a3254e74] [3d5b052c] [9620ca3c] [e6f91c74] [9c47051d] [963f3193] [84380451] [3add9ad2] [f44b21b91f62f4e2-2] [685d15dfb6eb2285-306] [3a9340cd0d877339-30] [3a9340cd0d877339-31] [942ae6c11625c81c-155] [942ae6c11625c81c-156] [6b4a5e54e001d097-33] [6b4a5e54e001d097-34] [6b4a5e54e001d097-35] [adcb65b6] [3b8c4af9] [c4b99c3a] [03de45c4] [ca4b9767] [264a8d98] [ca41e218] [046b7bc7] [c5a50dfb] [3fd46069] [e50b61ac] [9a788ddf] [572f8802] [5c8a29b9] [a50a113d] [9f33abd3] [ff93c5d5] [ddba42bd] [ae52ccdc] [353d9e29] [f0d25639] [60ab9716] [48ab6566] [f3c02b94] [c6c5b4c6] [a32ba36c] [0e417ba0] [5469694c] [9d86f8c9] [21d76727] [a8cceee3de363b57-2] [d6903cb0] [9b954cd8] [b050760b] [0da8f4b3] [e56bb7bd] [6f269aa1] [95934479] [00069798] [49cbfb2a] [dc0710a8] [75c17c72] [43069bb0] [5d14c923] [0e2900e6] [baf1aba6] [d30d9f20] [c2722401] [952e01f2] [65b5d87d] [1fa2f918] [4cb89f91] [0036823e] [24108449] [48a0fd8b] [477f513818a1ad7d-2] [477f513818a1ad7d-3] [c907ea20] [f846ec49] [00727ddb] [5977d03a] [d9062dfa] [6200d13e] [f0284487] [4361cea4] [db415067] [797d3f14] [fcbad793] [c1e1fd90] [8774e95a] [e3f41ab3] [a71364bb] [8d264fc1] [607b81f5] [5233bbca] [dda79da8] [b444a6ee] [c3a7670e] [f528f0d5] [c0bd4d38] [d6c4f5ed] [2a45cd8b] [e35d07fb] [9ca740ef] [9e5383be] [37c8c5de] [6a13f861] [9a2f7109] [f950702f] [6c46d998] [10620d7e] [bb9c9447] [fd8063d1] [e60fb706] [de432358] [d26304ad] [75696e16fcbb84ec-11] [46986307] [90bd024e] [42aad946] [81a464b6] [fdcfb56b] [ae34cf4ae6f76a23-3] [393742b6] [40d110e3] [d672fa15] [81ff63e6] [08ef649f] [21baeb9f] [5ba55858] [961ae514] [7ea06e3e24e48e9b-2] [e1e460f4] [b48a71b9] [0ec540fb] [cad64cc1] [441a552e] [f0791722] [48625e54] [5cd9c162] [d90b7f44] [88e8506b] [307099a1] [a0a00dfa] [bd98e191] [1896df92] [07a9a0a9] [27740b69] [646384d5] [5f6a815f] [c4a7e5ff] [ac470405] [3b41747b] [25d555e4] [d0dfb513] [a90b9f18] [1e15fbd3] [64eaa99e] [e7c7d79f] [727438eb] [f10b51dc] [de48cbb7] [22d39651] [634a1d33] [aa5e8316] [ed4af888] [ae8a532c] [2e35b978] [8bb98dac] [0eeef0e1] [a96bcece] [9a81ade2] [4959f7c9] [eec07c14] [617e1f87] [939facd3] [a23bbfba] [0d3b2e16] [3f5b27f8] [fc02d391] [4c63f248] [10ce72bd] [f6cd0898] [58eb0818] [1701d1bc] [58a01539] [7cb08b0843714252-2] [f040eabe] [ce7c6331] [e71274fe] [6b496b06] [88d36ee3] [2fc6870f] [8d9fb233] [818b4d63] [3f058f3b] [c2d334eb] [f150e526] [cb74620c] [75836242] [c27a40d6] [7651a02d] [8807ce61] [05c2b0e6bc097b8e-2] [1e89a00498496058-2] [5d0a1ddf]
