# docs/ref/contrib/gis/functions

- Subject: docs/ref/contrib/gis/functions (id `47ac1ab9-fdca-4f3a-8203-a3136465eb93`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 15 of 228
- Conflicts: 0
- Gaps: 0

## Facts

- >>> City.objects.annotate(json=AsGeoJSON("point")).get(name="Chicago").json {"type":"Point","coordinates":[-87.65018,41.85039]} [56774923]
- >>> City.objects.annotate(wkt=AsWKT("point")).get(name="Chelyabinsk").wkt 'POINT (55.137555 61.451728)' [553418c5]
- >>> bytes(City.objects.annotate(wkb=AsWKB("point")).get(name="Chelyabinsk").wkb) b'\x01\x01\x00\x00\x00]3\xf9f\x9b\x91K@\x00X\x1d9\xd2\xb9N@' [fdb5fff7]
- >>> from django.contrib.gis.db.models.functions import Distance >>> pnt = AustraliaCity.objects.get(name="Hobart").point >>> for city in AustraliaCity.objects.annotate(distance=Distance("point", pnt)): ... print(city.name, city.distance) ... Wollongong 990071.220408 m Shellharbour 972804.613941 m Thirroul 1002334.36351 m ... [59b7c166]
- >>> from django.contrib.gis.db.models.functions import Length >>> Track.objects.annotate(length=Length("line")).filter(length__gt=100) [695413bf]
- >>> qs = Zipcode.objects.annotate(gml=AsGML("poly")) >>> print(qs[0].gml) <gml:Polygon srsName="EPSG:4326"><gml:OuterBoundaryIs>-147.78711,70.245363 ... -147.78711,70.245363</gml:OuterBoundaryIs></gml:Polygon> [3c2cbbc4]
- >>> qs = Zipcode.objects.annotate(kml=AsKML("poly")) >>> print(qs[0].kml) <Polygon><outerBoundaryIs><LinearRing><coordinates>-103.04135,36.217596,0 ... -103.04135,36.217596,0</coordinates></LinearRing></outerBoundaryIs></Polygon> [7a5095df]
- Because the ``distance`` attribute is a :class:`~django.contrib.gis.measure.Distance` object, you can easily express the value in the units of your choice. For example, ``city.distance.mi`` is the distance value in miles and ``city.distance.km`` is the distance value in kilometers. See :doc:`/ref/contrib/gis/measure` for usage details and the list of :ref:`supported_units`. [2d5350f5]
- MariaDB 12.0.1+ support was added. [da6e6ec8a1a60ce4]
- SpatiaLite support was added. [7eb29854c6e4f668]
- What spatial reference system an integer SRID corresponds to may depend on the spatial database used. In other words, the SRID numbers used for Oracle are not necessarily the same as those used by PostGIS. [bc5b187f]
- *Availability*: MariaDB, `MySQL <https://dev.mysql.com/doc/refman/en/gis-format-conversion-functions.html#function_st-asbinary>`__, Oracle, `PostGIS <https://postgis.net/docs/ST_AsBinary.html>`__, SpatiaLite [23587543]
- *Availability*: MariaDB, `MySQL <https://dev.mysql.com/doc/refman/en/gis-general-property-functions.html#function_st-envelope>`__, `Oracle <https://docs.oracle.com/en/database/oracle/oracle-database/21/spatl/ spatial-operators-reference.html#GUID-ACED800F-3435-44AA-9606-D40934A23ED0>`__, `PostGIS <https://postgis.net/docs/ST_Envelope.html>`__, SpatiaLite [6959d3da]
- *Availability*: MariaDB, `MySQL <https://dev.mysql.com/doc/refman/en/gis-geometrycollection-property-functions.html#function_st-numgeometries>`__, `PostGIS <https://postgis.net/docs/ST_NumGeometries.html>`__, Oracle, SpatiaLite [be0b8562]
- *Availability*: MariaDB, `MySQL <https://dev.mysql.com/doc/refman/en/gis-linestring-property-functions.html#function_st-length>`__, Oracle, `PostGIS <https://postgis.net/docs/ST_Length.html>`__, SpatiaLite [de2c2d0a]

## Beyond the budget

206 more facts did not fit in the budget: [97429145] [9148b013] [f0ffd4ec] [e37a73f1] [09d1c626] [82a565c0] [72510923] [e968bd92] [5c1f0fb8] [7a30ff05] [a55aaa44] [ada33b87bf6f9b34] [82eebd87] [3c4fbd7d] [2e9aabfd] [ae31e61a] [d9086b6d] [e87f377f582676fb] [84eb083c] [5100c411] [71a9e9b4] [4648db9f5c6194ab] [c1013221] [ac323cf8] [78bf2408] [61b68014] [2a49d90e] [f247cfe9] [2f98437d] [5dce73c3] [4a96faca] [be6c9d4c] [eb4334ae] [e9c69c8d] [e3219db4] [47170a7a] [f84e7e65] [9dc88cba] [49279dd2] [8a4de645] [0f7d8504] [a44656d9] [c85f683a] [b64d8e94] [97a017fc] [701da78d] [44beb22b] [d7357028] [17d4b90b] [e206f172] [a68b175f] [fb5e9755] [eed4ea2e] [ecf7f324] [3159065d] [e6b30bc0] [35b5c39a] [5ea666b0] [772a613b] [fa54c996] [f644a1ad] [e36d4122] [fde3c188] [0889dda691e14c07] [54dc79a3] [968dfa3f] [788f3f30] [556d7e59] [57b1f634] [d78b2e2f] [ce24319d] [eaf050be34acb41d-41] [eaf050be34acb41d-42] [eaf050be34acb41d-43] [eaf050be34acb41d-44] [eaf050be34acb41d-45] [eaf050be34acb41d-46] [eaf050be34acb41d-47] [2780698b] [942ae6c11625c81c-45] [942ae6c11625c81c-46] [a1eb26d754a3d60c-6] [a1eb26d754a3d60c-7] [0cf180bcf4ecfab5-7] [57739e32d87f6c76-3] [57739e32d87f6c76-4] [2a966a198e13032b-6] [b3a67d6a] [1f0b6047] [2ca08cef] [af1e8759] [899dd0e1] [13a9e503] [79d0bb68] [1fdf161b] [36e2d860] [66b9f5bd] [ea4c0c9e] [e31efe91] [9948fbab] [51feafe7] [7cdd3f46] [36bb441c] [88157d1a] [2c3371cf] [5120c8f6] [2a5458b9] [ed7caa37] [4fa691a7] [d134df79] [76d224d9] [870dd58e] [57ed8ee7] [48da6cca] [271e1322] [5f093825] [f2b41e8a] [98ba58ca] [81332d9c] [67cedc65] [0df6e755] [77b39b74] [2a8c30ae] [389f9d98] [0fe333b0] [fb57e4d1] [e6445691] [74e59ebb] [fb080305] [c327687e] [515446b4] [20ed93bf2591ccc0-2] [20ed93bf2591ccc0-3] [20ed93bf2591ccc0-4] [20ed93bf2591ccc0-5] [20ed93bf2591ccc0-6] [20ed93bf2591ccc0-7] [d1b2079a] [f74a2d32] [c29eaa27] [860302bc192c8ae4-3] [0ea13715] [7530a8ca] [4d9a35b3] [ce9c2c72] [fd7c01a3] [32ee97e8] [d4cf4de7] [d6f4dada] [1b4f67ed] [4f85fd7f] [beeaf525] [a81d1367] [ae6d333c] [5d958578] [caa7fca2] [62ba577a] [afa9c0db] [80c7f9a7090bc8b5] [9394dcc6] [ed1916a3] [989ac74e] [e2ef116ba2a404b8] [ecfd9fb0] [f1b4b488] [c6241fb3] [5aebec1e] [8f9cdc0b] [3d39e698] [a9852f36] [515b5da8] [d13b4653] [cb85176a] [941d019a] [4d4bf744e1be7be5] [998d58625cf276f5] [ee886efa] [91c29096] [f3f4166f] [b9b75cdf] [ba0c53cd] [f26c98d1] [f3fbc887] [9475f68f] [d738bc6e] [c208ea1173525f96] [0e03e2d3] [48d03660] [80bfeb4b] [7d93652b] [49e54c12] [42a65324] [e8ae6d19] [4a9a9ae1] [dc1c28abb0884360] [ec319167] [d6b1cef5] [8550e146] [785fe61a] [b5586ce4] [29bc07f1] [9c8c7775] [d9e1617e] [33ca790c] [95e629b9] [2ba5405b]
