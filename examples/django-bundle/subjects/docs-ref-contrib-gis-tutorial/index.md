# docs/ref/contrib/gis/tutorial

- Subject: docs/ref/contrib/gis/tutorial (id `b8423d5b-613e-4d07-ac7f-2363b669e167`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 23 of 211
- Conflicts: 0
- Gaps: 0

## Facts

- # GeoDjango-specific: a geometry field (MultiPolygonField) mpoly = models.MultiPolygonField() [cb7b9264]
- # Returns the string representation of the model. def __str__(self): return self.name [8ab7ae3a]
- >>> from django.db import connection >>> # or if you're querying a non-default database: >>> from django.db import connections >>> connection = connections["your_gis_db_alias"] >>> City.objects.raw( ... "SELECT id, name, %s as point from myapp_city" % (connection.ops.select % "point") ... ) [0f44c075]
- # Auto-generated `LayerMapping` dictionary for WorldBorder model worldborders_mapping = { "fips": "FIPS", "iso2": "ISO2", "iso3": "ISO3", "un": "UN", "name": "NAME", "area": "AREA", "pop2005": "POP2005", "region": "REGION", "subregion": "SUBREGION", "lon": "LON", "lat": "LAT", "geom": "MULTIPOLYGON", } [1863e03c]
- # This is an auto-generated Django model module created by ogrinspect. from django.contrib.gis.db import models [7d3f5fea]
- $ cd geodjango $ python manage.py startapp world [1a650992]
- $ django-admin startproject geodjango [8d2a42e8]
- $ mkdir world/data $ cd world/data $ wget https://web.archive.org/web/20231220150759/https://thematicmapping.org/downloads/TM_WORLD_BORDERS-0.3.zip $ unzip TM_WORLD_BORDERS-0.3.zip $ cd ../.. [49a53abe]
- $ ogrinfo -so world/data/TM_WORLD_BORDERS-0.3.shp TM_WORLD_BORDERS-0.3 INFO: Open of `world/data/TM_WORLD_BORDERS-0.3.shp' using driver `ESRI Shapefile' successful. [587f9c46]
- $ ogrinfo world/data/TM_WORLD_BORDERS-0.3.shp INFO: Open of `world/data/TM_WORLD_BORDERS-0.3.shp' using driver `ESRI Shapefile' successful. 1: TM_WORLD_BORDERS-0.3 (Polygon) [52d48de5]
- $ python manage.py createsuperuser [8302498608e60ebc-2]
- $ python manage.py makemigrations Migrations for 'world': world/migrations/0001_initial.py: + Create model WorldBorder [0618e939]
- $ python manage.py migrate Operations to perform: Apply all migrations: admin, auth, contenttypes, sessions, world Running migrations: ... Applying world.0001_initial... OK [41a7fcc8]
- $ python manage.py ogrinspect [options] <data_source> <model_name> [options] [c0167711]
- $ python manage.py ogrinspect world/data/TM_WORLD_BORDERS-0.3.shp WorldBorder \ --srid=4326 --mapping --multi [e39f6db2]
- $ python manage.py runserver [46c9a5006c713d0c-5]
- $ python manage.py shell [dc0da2cbf091829d-7]
- $ python manage.py sqlmigrate world 0001 [0c5b46f2]
- .. code-block:: pycon [eaf050be34acb41d-191]
- >>> [fld.__name__ for fld in lyr.field_types] ['OFTString', 'OFTString', 'OFTString', 'OFTInteger', 'OFTString', 'OFTInteger', 'OFTInteger64', 'OFTInteger', 'OFTInteger', 'OFTReal', 'OFTReal'] [d7f21e33]
- >>> feat = lyr[234] >>> print(feat.get("NAME")) San Marino [f152abdb]
- >>> for feat in lyr: ... print(feat.get("NAME"), feat.geom.num_points) ... Guernsey 18 Jersey 26 South Georgia South Sandwich Islands 338 Taiwan 363 [35e0a030]
- >>> from world import load >>> load.run() [5c650d53]

## Beyond the budget

186 more facts did not fit in the budget: [cf9d3234] [ea66971d] [b71ab154] [54eb2f20] [185c9ac1] [7bd304af] [1339cfe1] [2507d9c5] [69aad249] [67c7a5c9] [66b25f27] [06f91725] [d8ea8be8] [79ce4af6] [18bf2069] [38f71e01] [e4f9663f] [c5623b1f] [9325517e] [91755d4d] [4a94b5db] [2c40a066] [5a08b7f2] [f19f2ae7] [374ecd27] [38a95d17] [162da463] [75c1e94b] [8f1bd56a] [336d1565] [3aa91c069f17dcf2-2] [7b27d194] [bc102196f7767c3e-4] [3d315958] [cf45ac452f396db9-2] [fcd2dd7a] [0cce7252] [d0712972] [afb13aa6] [cf633ada] [62b435e6] [ac57571a] [19b1d0c4] [874261ca] [13e7483e] [e1c05448] [6499e5c1] [c671dc78] [6372a76b] [e8205029] [590cee98] [30ee56b4] [a99f0249] [eaf050be34acb41d-192] [eaf050be34acb41d-193] [eaf050be34acb41d-194] [eaf050be34acb41d-195] [eaf050be34acb41d-196] [eaf050be34acb41d-197] [eaf050be34acb41d-198] [eaf050be34acb41d-199] [eaf050be34acb41d-200] [eaf050be34acb41d-201] [eaf050be34acb41d-202] [eaf050be34acb41d-203] [eaf050be34acb41d-204] [eaf050be34acb41d-205] [eaf050be34acb41d-206] [eaf050be34acb41d-207] [eaf050be34acb41d-208] [eaf050be34acb41d-209] [eaf050be34acb41d-210] [eaf050be34acb41d-211] [0ee73173f492412a-23] [7714e199aac2701e-85] [7714e199aac2701e-86] [7714e199aac2701e-87] [7714e199aac2701e-88] [7714e199aac2701e-89] [7714e199aac2701e-90] [7714e199aac2701e-91] [7714e199aac2701e-92] [7714e199aac2701e-93] [7714e199aac2701e-94] [7714e199aac2701e-95] [7714e199aac2701e-96] [7714e199aac2701e-97] [7714e199aac2701e-98] [7714e199aac2701e-99] [942ae6c11625c81c-73] [942ae6c11625c81c-74] [942ae6c11625c81c-75] [81360ef6] [0673f1ca] [0fefb122] [bebc9da2] [8ea479fd] [05e9d5f7] [472e06d6] [f7080842] [285682d7] [67abc09b] [29ec5ea7] [08a32767] [51707a44] [c333fd85] [30ed46d8] [4c27c85b] [3814ba45] [c0828585] [984c8b52] [3e37a495] [29321779] [97ba1c1b] [605d3336] [d0f7e3a5] [18150ef4] [37edf712] [45c8d510] [45144d54] [6083d9bd] [a8525e40] [557e0bac] [fe4fcb83] [46ff0f85] [61fc096a] [f2a1d592] [bea74726] [c081888e] [2edcdce89eec848d-3] [90b18513] [c4115541] [79dbacc3] [ecc67d48] [456da36b] [5e17a42a] [8849a9ab] [b6f4a075] [d4b8c287] [440bc340] [155a6dae] [280cc7c8] [32c7c9ad] [e98c916a] [8584e6d6] [9de99b4a] [7309ee29] [9ffcfb5d] [804119e6] [d12d432c] [d75a2277] [ce358f77] [1920dce1] [05d66409] [4a37fdaa] [f98812c7] [8b6ba3d7] [bd36d397] [3a13091e] [caeb3e4b] [f68efd36] [19ddd8c6] [e1c369b6] [d56a1c82] [9d5f8ae9] [b8dbcabe] [d84d6cac] [d2e56387] [7815195c] [dea030ee] [6ecd618f] [0da8fd18] [fb19d269] [7c048d76] [94b970bf] [c86ba418] [c53e696e] [82fc7fe4] [ae3d751d] [d6b36f0a] [42fca892] [bbb5cd48] [4b53fc3e] [7d1a6ad7] [75b8b7bb] [61939a76]
