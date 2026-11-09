# docs/ref/contrib/postgres/search

- Subject: docs/ref/contrib/postgres/search (id `c2a7ecc9-bedc-4936-a180-359f7c51786f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 13 of 141
- Conflicts: 0
- Gaps: 0

## Facts

- class Meta: indexes = [GinIndex(fields=["search_vector"])] [9d6f3363]
- search_vector = models.GeneratedField( expression=SearchVector("headline", weight="A", config="english") + SearchVector("body_text", weight="B", config="english"), output_field=SearchVectorField(), db_persist=True, ) [1eae7b4c]
- :class:`Lexeme` objects were added. [e9a2f8cd]
- >>> Entry.objects.annotate( ... search=SearchVector("body_text") + SearchVector("blog__tagline"), ... ).filter(search="Cheese") <QuerySet [<Entry: Cheese on Toast recipes>, <Entry: Pizza Recipes>]> [97de5bfe]
- >>> Entry.objects.annotate(search=vector).filter( ... search=SearchQuery(Lexeme("Pizza") | Lexeme("Cheese")) ... ) <QuerySet [<Entry: Cheese on Toast recipes>, <Entry: Pizza recipes>]> >>> Entry.objects.annotate(search=vector).filter( ... search=SearchQuery(Lexeme("Pizza") | Lexeme("Cheese", weight="A")) ... ) <QuerySet [<Entry: Pizza recipes>]> >>> Entry.objects.annotate(search=vector).filter( ... search=SearchQuery(Lexeme("za", prefix=True)) ... ) <QuerySet []> [c68f6405]
- >>> Entry.objects.annotate(search=vector).filter( ... search=SearchQuery(Lexeme("fruit") & Lexeme("dessert") & ~Lexeme("banana")) ... ) <QuerySet [<Entry: Apple Crumble Recipes>]> [47b6a8b0]
- >>> Entry.objects.filter(body_text__search="Cheese") <QuerySet [<Entry: Cheese on Toast recipes>, <Entry: Pizza Recipes>]> [71ddec18]
- >>> Entry.objects.update(search_vector=SearchVector("body_text")) >>> Entry.objects.filter(search_vector="cheese") <QuerySet [<Entry: Cheese on Toast recipes>, <Entry: Pizza recipes>]> [a60d4b1b]
- >>> from django.contrib.postgres.search import SearchHeadline, SearchQuery >>> query = SearchQuery("red tomato") >>> entry = Entry.objects.annotate( ... headline=SearchHeadline( ... "body_text", ... query, ... start_sel="<span>", ... stop_sel="</span>", ... ), ... ).get() >>> print(entry.headline) Sandwich with <span>tomato</span> and <span>red</span> cheese. [d54de2f6]
- >>> from django.contrib.postgres.search import SearchQuery >>> SearchQuery("meat") & SearchQuery("cheese") # AND >>> SearchQuery("meat") | SearchQuery("cheese") # OR >>> ~SearchQuery("meat") # NOT [55e5fd51]
- >>> from django.contrib.postgres.search import SearchQuery, Lexeme >>> SearchQuery("red tomato") # two keywords >>> SearchQuery("tomato red") # same results as above >>> SearchQuery("red tomato", search_type="phrase") # a phrase >>> SearchQuery("tomato red", search_type="phrase") # a different phrase >>> SearchQuery("'tomato' & ('red' | 'green')", search_type="raw") # boolean operators >>> SearchQuery( ... "'tomato' ('red' OR 'green')", search_type="websearch" ... ) # websearch operators >>> SearchQuery(Lexeme("tomato") & (Lexeme("red") | Lexeme("green"))) # Lexeme objects [9acee413]
- >>> from django.contrib.postgres.search import SearchQuery, SearchRank, SearchVector >>> vector = SearchVector("body_text") >>> query = SearchQuery("cheese") >>> Entry.objects.annotate(rank=SearchRank(vector, query)).order_by("-rank") <QuerySet [<Entry: Cheese on Toast recipes>, <Entry: Pizza recipes>]> [f4ad5607]
- For a high-level overview of searching, see the :doc:`topic documentation </topics/db/search>`. [61cfcb44]

## Beyond the budget

124 more facts did not fit in the budget: [6b5c2c46] [23016b84] [fa7f6c8b] [7c8ec948] [2fa81440] [105477ae] [ca8b79f9] [8237b9a5] [9df6c898] [497f01ab] [0758207e] [cc3a43b3] [3fe9114b] [bd9f6eac] [ec61a36d] [97348f83] [cf377be2] [cf54b256] [e4ea84a5] [834e5a14] [0861ab1b] [eb421257] [2c360796] [d7cc0e99] [abfbb4c5] [4b9bb354] [d91af8b1] [a540c22c] [f7061c38] [c32b976c] [65a08ed9] [c01bdcd8] [eaf050be34acb41d-245] [eaf050be34acb41d-246] [eaf050be34acb41d-247] [eaf050be34acb41d-248] [eaf050be34acb41d-249] [eaf050be34acb41d-250] [eaf050be34acb41d-251] [eaf050be34acb41d-252] [eaf050be34acb41d-253] [eaf050be34acb41d-254] [eaf050be34acb41d-255] [eaf050be34acb41d-256] [eaf050be34acb41d-257] [eaf050be34acb41d-258] [eaf050be34acb41d-259] [eaf050be34acb41d-260] [eaf050be34acb41d-261] [eaf050be34acb41d-262] [eaf050be34acb41d-263] [eaf050be34acb41d-264] [77797082] [5212ed16] [6b4a5e54e001d097-19] [a1eb26d754a3d60c-20] [57739e32d87f6c76-8] [a3609f37] [fef206e6] [e35f2101] [94cfbe09] [a35f2b91] [09753ab7] [03cb0c3f] [87993a44] [0618c19a] [4fabe37f] [7424ac6d] [f85d7fa2] [1a555414] [3e92be26] [2ec6aead] [1ebca3e2] [d4cabd1f] [68f5062c] [4c1de632] [5476166e] [71982a3f] [d9980b02] [3090c23fe7b0bac4] [e7c4b51e] [d8139eaf] [ec145b2f] [dfff80dd] [30903a07] [89f725a3] [f6ed2faf] [2be941c2] [c67e37bd] [25efa7ff] [483aedf1] [18e7084f] [8cf9b1b0] [f23ba775] [9b062f9a] [26df1fe1] [3814373c] [35497d16] [fbf4d8b26aa7310d-2] [3ecdcd2d485c92ad-3] [3ecdcd2d485c92ad-4] [3ecdcd2d485c92ad-5] [3ecdcd2d485c92ad-6] [3ecdcd2d485c92ad-7] [4d77325f] [3f7a49e2] [9679c498] [ddd3c8be] [f05f7c3e] [17feee2b] [53a4c8a1] [d35b52ca] [d082f334] [a904a76c] [d1a53216] [ffe4227b] [8efa407c] [1f3fb319] [38680c7f] [b8e820e7] [ae182e5f] [1c2254a9] [9d012bdb] [88b3f8f2]
