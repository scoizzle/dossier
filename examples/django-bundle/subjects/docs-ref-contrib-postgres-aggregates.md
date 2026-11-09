# docs/ref/contrib/postgres/aggregates

- Subject: docs/ref/contrib/postgres/aggregates (id `a7d0aa81-1129-4b0c-8152-59697460abd4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 19 of 133
- Conflicts: 0
- Gaps: 0

## Facts

- ArrayAgg("a_field", order_by="-some_field") ArrayAgg("a_field", order_by=F("some_field").desc()) [c76cb1d7]
- Support for providing a ``Value`` or expression rather than a string was added. [536e3feb]
- Support for providing a string is deprecated. [4567c2bb]
- from django.db.models import F [a345df786882bc74]
- .. deprecated:: 6.0 [7904e6f98dc4b6fe]
- .. versionadded:: 6.0 [a1eb26d754a3d60c-10]
- >>> SomeModel.objects.aggregate(arr=ArrayAgg("somefield")) {'arr': [0, 1, 2]} [a5d5ffa7]
- >>> article = Article.objects.create(headline="NASA uses Python") >>> article.publications.create(title="The Python Journal") <Publication: Publication object (1)> >>> article.publications.create(title="Science News") <Publication: Publication object (2)> >>> from django.contrib.postgres.aggregates import StringAgg >>> Article.objects.annotate( ... publication_names=StringAgg( ... "publications__title", ... delimiter=", ", ... order_by="publications__title", ... ) ... ).values("headline", "publication_names") <QuerySet [{ 'headline': 'NASA uses Python', 'publication_names': 'Science News, The Python Journal' }]> [6a54da26]
- >>> from django.contrib.postgres.aggregates import JSONBAgg >>> Room.objects.annotate( ... requirements=JSONBAgg( ... "hotelreservation__requirements", ... order_by="-hotelreservation__start", ... ) ... ).filter(requirements__0__sea_view=True).values("number", "requirements") <QuerySet [{'number': 102, 'requirements': [ {'parking': False, 'sea_view': True, 'double_bed': False}, {'parking': True, 'double_bed': True} ]}]> [36ebc337]
- >>> from django.db.models import Q >>> from django.contrib.postgres.aggregates import BoolAnd >>> Comment.objects.aggregate(booland=BoolAnd("published")) {'booland': False} >>> Comment.objects.aggregate(booland=BoolAnd(Q(rank__lt=100))) {'booland': True} [1beda15b]
- >>> from django.db.models import Q >>> from django.contrib.postgres.aggregates import BoolOr >>> Comment.objects.aggregate(boolor=BoolOr("published")) {'boolor': True} >>> Comment.objects.aggregate(boolor=BoolOr(Q(rank__gt=2))) {'boolor': False} [a250e54a]
- An optional boolean argument that determines if array values will be distinct. Defaults to ``False``. [11db72846e1e83dc]
- An optional string of a field name (with an optional ``"-"`` prefix which indicates descending order) or an expression (or a tuple or list of strings and/or expressions) that specifies the ordering of the elements in the result list. [44c7afa2dda05201]
- Examples are the same as for :attr:`ArrayAgg.order_by`. [06e85ac386111403]
- Examples:: [730c225c80dac295]
- Optional. By default ``CovarPop`` returns the general population covariance. However, if ``sample=True``, the return value will be the sample population covariance. [ebd87249]
- Required argument. A string, :class:`~django.db.models.Value`, or expression representing the string for separating values. For example, ``Value(",")``. [208f4bfa]
- The PostgreSQL ``StringAgg`` class is deprecated in favor of the generally available :class:`~django.db.models.StringAgg` class. [7cb6a7a6]
- .. attribute:: sample [c04d4b5d5f04da1d]

## Beyond the budget

100 more facts did not fit in the budget: [cfacf19a790917ae] [00c173d6] [98c870b3] [7bb2dd9650992b2c] [dc519cfe] [3ced8730] [82f17d4b] [540795b5b1824d0c] [2ff14360ba3f8de3] [2ff14360ba3f8de3-2] [2ff14360ba3f8de3-3] [f8ed1fbe338e5d59] [f8ed1fbe338e5d59-2] [f8ed1fbe338e5d59-3] [eaf050be34acb41d-212] [eaf050be34acb41d-213] [eaf050be34acb41d-214] [eaf050be34acb41d-215] [eaf050be34acb41d-216] [7904e6f98dc4b6fe-2] [01aaf10861da6524-4] [01aaf10861da6524-5] [01aaf10861da6524-6] [942ae6c11625c81c-76] [ccdd8046] [b7017403] [239863f4] [0b21e591] [860edc73] [c633d263] [4e60dbd6] [509b72f8] [1d656a14] [87f330e8] [a30aeda9dc9e9627] [620b2f87] [b624cfa3] [45ad2962] [e129263dd012440b] [2f77c8f2] [23ec4a92] [a2032f1b06c0a2ba] [a2032f1b06c0a2ba-2] [a2032f1b06c0a2ba-3] [a2032f1b06c0a2ba-4] [9a3e212f] [b9a82b14] [20e12d38] [217c882cd1c0a0f1] [08f36d069ea3ce18] [d7c492ad95a6f4d8] [73b92522] [e8bcff2f] [3326c1b1] [24d4faf4] [3a629c52] [05bb80c2] [50d3f8db] [17137e80] [9089f039] [90678c15] [503d0aff] [edbfd08e] [cc3c3e70] [0ec3b24e] [be2e972c] [eaf050be34acb41d-217] [eaf050be34acb41d-218] [3a9340cd0d877339-23] [f4ef547d] [942ae6c11625c81c-77] [100846b9] [078f4b00] [8e02d0d6] [411be7c8] [01fb24cc] [07f43225] [e31dc74c] [303bea20] [19e3e28a] [9ff736a2] [fbd14360] [1a09203c] [ef354a33] [521c7b33] [d62a5806] [296b8643] [352bef9e] [647485e0] [a6c928cd] [e9c877bf] [8982486c] [b1384832] [18467453] [acaefa5e] [9fca51dd] [c9dc2f70] [261dacf4] [0fa78803] [9bb12280]
