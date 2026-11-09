# docs/ref/contrib/gis/db-api

- Subject: docs/ref/contrib/gis/db-api (id `dc3872e9-c29a-4fc9-9df8-38681e5b2d5d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 12 of 104
- Conflicts: 0
- Gaps: 0

## Facts

- >>> dem = Elevation.objects.create( ... name="Canyon", ... rast={ ... "width": 10, ... "height": 10, ... "name": "Canyon", ... "srid": 4326, ... "scale": [0.1, -0.1], ... "bands": [{"data": range(100)}], ... }, ... ) [3804672a]
- >>> from django.contrib.gis.gdal import GDALRaster >>> rast = GDALRaster( ... { ... "width": 10, ... "height": 10, ... "name": "Canyon", ... "srid": 4326, ... "scale": [0.1, -0.1], ... "bands": [{"data": range(100)}], ... } ... ) >>> dem = Elevation(name="Canyon", rast=rast) >>> dem.save() [58e7d7d7]
- >>> from django.contrib.gis.geos import GEOSGeometry >>> from django.contrib.gis.measure import D # ``D`` is a shortcut for ``Distance`` >>> from geoapp.models import SouthTexasCity # Distances will be calculated from this point, which does not have to be projected. >>> pnt = GEOSGeometry("POINT(-96.876369 29.905320)", srid=4326) # If numeric parameter, units of field (meters in this case) are assumed. >>> qs = SouthTexasCity.objects.filter(point__distance_lte=(pnt, 7000)) # Find all Cities within 7 km, > 20 miles away, and > 100 chains away (an obscure unit) >>> qs = SouthTexasCity.objects.filter(point__distance_lte=(pnt, D(km=7))) >>> qs = SouthTexasCity.objects.filter(point__distance_gte=(pnt, D(mi=20))) >>> qs = SouthTexasCity.objects.filter(point__distance_gte=(pnt, D(chain=100))) [fe416983]
- >>> from django.contrib.gis.geos import GEOSGeometry >>> poly = GEOSGeometry("POLYGON(( 10 10, 10 20, 20 20, 20 15, 10 10))") >>> z = Zipcode(code=77096, poly=poly) >>> z.save() [2d98496b]
- >>> from elevation.models import Elevation >>> dem = Elevation(name="Volcano", rast="/path/to/raster/volcano.tif") >>> dem.save() [f8d46b15]
- >>> from zipcode.models import Zipcode >>> z = Zipcode(code=77096, poly="POLYGON(( 10 10, 10 20, 20 20, 20 15, 10 10))") >>> z.save() [d9b33d1a]
- >>> poly_3084 = GEOSGeometry( ... "POLYGON(( 10 10, 10 20, 20 20, 20 15, 10 10))", srid=3084 ... ) # SRID 3084 is 'NAD83(HARN) / Texas Centric Lambert Conformal' >>> z = Zipcode(code=78212, poly=poly_3084) >>> z.save() >>> from django.db import connection >>> print( ... connection.queries[-1]["sql"] ... ) # printing the last SQL statement executed (requires DEBUG=True) INSERT INTO "geoapp_zipcode" ("code", "poly") VALUES (78212, ST_Transform(ST_GeomFromWKB('\\001 ... ', 3084), 4326)) [b7dca396]
- >>> qs = Elevation.objects.filter(<field>__<lookup_type>=<parameter>) >>> qs = Elevation.objects.filter(<field>__<band_index>__<lookup_type>=<parameter>) >>> qs = Elevation.objects.filter(<field>__<lookup_type>=(<raster_input, <band_index>) [34a77df2]
- >>> qs = Elevation.objects.filter(rast__contains=geom) >>> qs = Elevation.objects.filter(rast__contains=rst) >>> qs = Elevation.objects.filter(rast__1__contains=geom) >>> qs = Elevation.objects.filter(rast__contains=(rst, 1)) >>> qs = Elevation.objects.filter(rast__1__contains=(rst, 1)) [9322abcc]
- >>> qs = SouthTexasCity.objects.filter(point__distance_gte=(rst, 2, D(km=7))) [7fc19423]
- >>> qs = Zipcode.objects.filter(<field>__<lookup_type>=<parameter>) >>> qs = Zipcode.objects.exclude(...) [ecd567c2]
- >>> qs = Zipcode.objects.filter(poly__contains=pnt) >>> qs = Elevation.objects.filter(poly__contains=rst) [4a2ea233]

## Beyond the budget

91 more facts did not fit in the budget: [57c70830] [93973103] [9f0cf2da] [bd6224fa] [bc102196f7767c3e] [14af26b8] [f19ef8c6] [3f4f6fe41b1b8818] [a3d4407a] [40321585] [0838f0aa] [530ab221] [1d397d0f] [d97135c2] [3a7e3164] [e9cdc334] [ec8bf653] [d1a97fd4] [767ea22d] [eaf050be34acb41d-31] [eaf050be34acb41d-32] [eaf050be34acb41d-33] [eaf050be34acb41d-34] [eaf050be34acb41d-35] [eaf050be34acb41d-36] [eaf050be34acb41d-37] [eaf050be34acb41d-38] [eaf050be34acb41d-39] [eaf050be34acb41d-40] [3a9340cd0d877339-19] [3a9340cd0d877339-20] [98670c268fdc55ed] [cd3888f0] [942ae6c11625c81c-42] [942ae6c11625c81c-43] [41fa9b43] [fcd8bb1b] [aaad67f7] [3aa59e33] [b1182b3d] [c8599bb8] [b1ae58a5] [f69af85ebbe61095] [61de5480] [07c076d0] [e1fce2be] [667a7a4a] [22840f64] [0d69e05a] [8fd7dd89] [ce4105cc] [d40f9715] [1b3a66bb] [9c000f28] [bc295f9831206ba3-5] [bc295f9831206ba3-6] [22288361] [3522eba4] [1921a534] [63ed0a91] [a3f40670] [428022df] [45010b2e] [1852d5fd] [b82ee665] [61e96b21] [5e0a812f] [2fba52d5] [9d615e37] [475ea3d2] [93fd00cb] [5d44c854] [72118714] [6170f3a4] [cd371e7e] [4ea76185fa1bf24a] [7cbbce8b] [136f7cd0] [348b15ab] [e0c0043d] [8b775010] [eba5ed6a] [2b0a658a] [7fbe88c1] [5f0689f0] [f3c55bdc] [9d286188] [1cbd1b97] [1c0c0048] [f2b2aa64] [7f054b01]
