# docs/ref/contrib/gis/geoquerysets

- Subject: docs/ref/contrib/gis/geoquerysets (id `0402b7dc-137f-435b-b0d4-d0338815f0df`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 29 of 336
- Conflicts: 0
- Gaps: 0

## Facts

- # A tuple lookup parameter is used to specify the geometry and # the intersection pattern (the pattern here is for 'contains'). Zipcode.objects.filter(poly__relate=(geom, "T*T***FF*")) [cdcedd92]
- <field>__<distance lookup>=(<geometry/raster>, <distance value>[, "spheroid"]) <field>__<distance lookup>=(<raster>, <band_index>, <distance value>[, "spheroid"]) <field>__<band_index>__<distance lookup>=(<raster>, <band_index>, <distance value>[, "spheroid"]) [c3ff6f78]
- >>> from django.contrib.gis.db.models import Extent, Union >>> WorldBorder.objects.aggregate(Extent("mpoly"), Union("mpoly")) [bb6069ae]
- >>> qs = City.objects.filter(name__in=("Houston", "Dallas")).aggregate(Extent("poly")) >>> print(qs["poly__extent"]) (-96.8016128540039, 29.7633724212646, -95.3631439208984, 32.782058715820) [788847cb]
- >>> qs = City.objects.filter(name__in=("Houston", "Dallas")).aggregate(MakeLine("poly")) >>> print(qs["poly__makeline"]) LINESTRING (-95.3631510000000020 29.7633739999999989, -96.8016109999999941 32.7820570000000018) [20922b41]
- >>> u = Zipcode.objects.aggregate(Union(poly)) # This may take a long time. >>> u = Zipcode.objects.filter(poly__within=bbox).aggregate( ... Union(poly) ... ) # A more sensible approach. [6f9b822a]
- If the computation time for using this method is too expensive, consider using :class:`Collect` instead. [e50a3784]
- MariaDB 12.0.1+ support was added. [da6e6ec8a1a60ce4-3]
- SELECT ... WHERE Relate(poly, geom, 'T*T***FF*') [738e6889]
- SELECT ... WHERE SDO_RELATE(poly, geom, 'anyinteract') [bc3069a6]
- SELECT ... WHERE ST_Relate(poly, ST_Polygon(rast, 1), 'T*T***FF*') SELECT ... WHERE ST_Relate(ST_Polygon(rast, 2), ST_Polygon(rast, 1), 'T*T***FF*') [a5586e60]
- SELECT ... WHERE poly &< geom [02f895ac]
- SpatiaLite support was added. [7eb29854c6e4f668-2]
- Zipcode.objects.filter(geom__num_dimensions=3) [536af564]
- Zipcode.objects.filter(poly=geom) [541d054f]
- Zipcode.objects.filter(poly__bbcontains=geom) [4ec171bd]
- Zipcode.objects.filter(poly__bboverlaps=geom) [28a813fc]
- Zipcode.objects.filter(poly__contained=geom) [b14e8a2c]
- Zipcode.objects.filter(poly__contains=geom) [47eaa816]
- Zipcode.objects.filter(poly__coveredby=geom) [0b3497a3]
- Zipcode.objects.filter(poly__covers=geom) [b67d1434]
- Zipcode.objects.filter(poly__crosses=geom) [fc1704ab]
- Zipcode.objects.filter(poly__disjoint=geom) [15ef5cd5]
- Zipcode.objects.filter(poly__distance_gt=(geom, D(m=5))) [c668c84b]
- Zipcode.objects.filter(poly__distance_gte=(geom, D(m=5))) [27ffea4e]
- Zipcode.objects.filter(poly__distance_lt=(geom, D(m=5))) [f8cb1a35]
- Zipcode.objects.filter(poly__distance_lte=(geom, D(m=5))) [a5af5896]
- Zipcode.objects.filter(poly__dwithin=(geom, D(m=5))) [60b884c7]
- .. _distance-lookups: [192946c5]

## Beyond the budget

276 more facts did not fit in the budget: [5970bae1] [dc10bbc1] [011e6842] [7dd4d15e] [275c27ba] [930694e8] [be38ed36] [4490f85e] [b5aaea49] [8fcb2d78] [c22477df] [8e993577] [5a9589cb] [b2c52108] [16ced104] [07cf3370] [59a5d665] [8e6d147f] [b06ffbc9] [3b5bc6ba] [3fc3c117] [b491599d] [42aac224] [ada33b87bf6f9b34-2] [8bbc02c0] [9fa7b243] [b650b32f] [2a461464] [d6673b84] [cd633601] [1ed35819] [6271f9c3] [11978827] [250805bc] [7e33cded] [9804582d] [e87f377f582676fb-2] [262fa4b5] [4648db9f5c6194ab-2] [010682de] [e5fe3ca8] [7240d7f5] [a6f4e454] [e635ebb2] [532e8b0c] [ab09ee01] [bf0d934a] [6eddb01b] [9a8aec7c] [366fe11b] [f36fcf39] [8d1555e3] [fc837c44] [eaf050be34acb41d-134] [eaf050be34acb41d-135] [eaf050be34acb41d-136] [eaf050be34acb41d-137] [eaf050be34acb41d-138] [0ee73173f492412a-11] [0ee73173f492412a-12] [0ee73173f492412a-13] [0ee73173f492412a-14] [0ee73173f492412a-15] [0ee73173f492412a-16] [0ee73173f492412a-17] [0ee73173f492412a-18] [0ee73173f492412a-19] [0ee73173f492412a-20] [0ee73173f492412a-21] [0ee73173f492412a-22] [3a9340cd0d877339-21] [98670c268fdc55ed-2] [30ee50aa] [5bb7ce29] [221b0f43] [2946da6e] [e8b89143] [a40ef178] [9f13c36f] [1b0f0784] [0e081486] [26bd6d66] [e7231cf4] [26882e05] [facdcc23] [f1869401] [ee298f53] [b46c8343] [8880f2ac] [533ffd3a] [13c5c1f4] [cd9671d6] [1f739c4c] [e6e7a71f] [5f16e976] [172bd9a0] [4cea74f0] [757179f0] [6d1b6249] [6465c8f0] [a340456b] [94b7df61] [5c92297a] [b6d986af] [d8ca4db9] [942ae6c11625c81c-49] [d1442067] [a1eb26d754a3d60c-8] [0cf180bcf4ecfab5-8] [57739e32d87f6c76-5] [57739e32d87f6c76-6] [57739e32d87f6c76-7] [2a966a198e13032b-7] [a38cc1a2] [3ba8aee7] [d1b02a4c] [ba41c245] [6df0898d] [1ed65890] [973db1c9] [af4a2637] [ba03bc0e] [ff75b720] [9ff2a33f] [ddab360a] [e4b1d423] [e8e56928] [b5de19ce] [e240981b] [1cb533c8] [8fc16734] [02408a5c] [59e68140] [a866c082] [f69af85ebbe61095-2] [28c5a500] [8eaec449] [b806016e] [d187c940] [20ed93bf2591ccc0-9] [20ed93bf2591ccc0-10] [20ed93bf2591ccc0-11] [20ed93bf2591ccc0-12] [20ed93bf2591ccc0-13] [acfcf117f82fd4c9-6] [acfcf117f82fd4c9-7] [acfcf117f82fd4c9-8] [acfcf117f82fd4c9-9] [acfcf117f82fd4c9-10] [acfcf117f82fd4c9-11] [acfcf117f82fd4c9-12] [acfcf117f82fd4c9-13] [acfcf117f82fd4c9-14] [acfcf117f82fd4c9-15] [acfcf117f82fd4c9-16] [acfcf117f82fd4c9-17] [acfcf117f82fd4c9-18] [acfcf117f82fd4c9-19] [acfcf117f82fd4c9-20] [acfcf117f82fd4c9-21] [acfcf117f82fd4c9-22] [acfcf117f82fd4c9-23] [acfcf117f82fd4c9-24] [acfcf117f82fd4c9-25] [acfcf117f82fd4c9-26] [acfcf117f82fd4c9-27] [acfcf117f82fd4c9-28] [acfcf117f82fd4c9-29] [acfcf117f82fd4c9-30] [acfcf117f82fd4c9-31] [acfcf117f82fd4c9-32] [acfcf117f82fd4c9-33] [acfcf117f82fd4c9-34] [acfcf117f82fd4c9-35] [acfcf117f82fd4c9-36] [acfcf117f82fd4c9-37] [bba4dad7] [24129c33] [cbc2e105] [a657f6d9] [bb779b64] [6eec7732] [00c2ab46] [43da3752] [ca1ae56f] [f0e8e82b] [c2132971] [0800a73e] [b0fa6eec] [177c83f91bdd1df5] [177c83f91bdd1df5-2] [177c83f91bdd1df5-3] [177c83f91bdd1df5-4] [177c83f91bdd1df5-5] [177c83f91bdd1df5-6] [177c83f91bdd1df5-7] [177c83f91bdd1df5-8] [1d9ec715] [95abfddb] [f0861ca3] [0de86c19] [c30780be] [af4236e7] [947614e3] [fd733cad] [5c6436fa] [f81c508c] [fe1b7970] [ccc62d7e] [4ea76185fa1bf24a-2] [fd34be91] [a900b756] [1ca3549e] [e39e0926] [2dd1acb8] [332da061] [7da0be27] [2e337a6d] [306c51f9] [79de5bb5] [44f7cf7a] [8e2c3b1e] [721c2b06] [7391d99f] [123cc1d2] [c40035e5] [0715a289] [c3a03e85] [23aeeaa1] [791ddd0e] [7985c22d] [d76cf94e] [dd63feb4] [fb72172f] [bcf78ed8] [9b2ebf42] [d19a4d00] [c70e6452] [67da449c] [d81dd7a7] [ad612b89] [5b29ed04] [1ea03ab9] [1b8775d9] [dd82bc68] [7450ab55] [543cb79c] [5b342a9c] [d581d636] [e01c1f09] [7c91e57d] [1255d592] [238666b9] [765f8e3d] [ef1eecfe] [b93b922c] [05be4f9a] [5c1d5360] [f2b0bc25] [b2df608cab3f23a8-2] [b8770bb7] [df153c8b] [7a683743] [de39a66e] [29d06a16] [4f2bd913] [b7301f74] [74f63c6d] [e8c80ab5] [aa233de3] [be7553ec] [3b1a216b] [47ed8a09] [cc6af2b9] [76254388] [84ad6283]
