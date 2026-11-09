# docs/ref/class-based-views/generic-date-based

- Subject: docs/ref/class-based-views/generic-date-based (id `0ec8d4d1-d7ee-4a48-8159-d0e7cdf788a4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 21 of 178
- Conflicts: 0
- Gaps: 0

## Facts

- def get_absolute_url(self): return reverse("article-detail", kwargs={"pk": self.pk}) [a8e26dc8]
- <div> <h1>All Articles for {{ year|date:"Y" }}</h1> {% for obj in object_list %} <p> {{ obj.title }} - {{ obj.pub_date|date:"F j, Y" }} </p> {% endfor %} </div> [c546e6b8]
- <h1>Week {{ week|date:'W' }}</h1> [91e14c59]
- <h1>{{ day }}</h1> [6682ee71]
- <h1>{{ object.title }}</h1> [323cd646]
- <p> {% if previous_day %} Previous Day: {{ previous_day }} {% endif %} {% if previous_day and next_day %}--{% endif %} {% if next_day %} Next Day: {{ next_day }} {% endif %} </p> [040b12c2]
- <p> {% if previous_month %} Previous Month: {{ previous_month|date:"F Y" }} {% endif %} {% if next_month %} Next Month: {{ next_month|date:"F Y" }} {% endif %} </p> [e4431ca2]
- <p> {% if previous_week %} Previous Week: {{ previous_week|date:"W" }} of year {{ previous_week|date:"Y" }} {% endif %} {% if previous_week and next_week %}--{% endif %} {% if next_week %} Next week: {{ next_week|date:"W" }} of year {{ next_week|date:"Y" }} {% endif %} </p> [1cce69a1]
- <ul> {% for article in latest %} <li>{{ article.pub_date }}: {{ article.title }}</li> {% endfor %} </ul> [7bf6123a]
- <ul> {% for article in object_list %} <li>{{ article.pub_date|date:"F j, Y" }}: {{ article.title }}</li> {% endfor %} </ul> [02667ed2437ac74a]
- <ul> {% for date in date_list %} <li>{{ date|date }}</li> {% endfor %} </ul> [eb13a1a1]
- A boolean specifying whether to retrieve the full list of objects for this year and pass those to the template. If ``True``, the list of objects will be made available to the context. If ``False``, the ``None`` queryset will be used as the object list. By default, this is ``False``. [8bbe3439]
- Determine if an object list will be returned as part of the context. Returns :attr:`~YearArchiveView.make_object_list` by default. [e4ea6c6b]
- This view uses by default the same template as the :class:`~DayArchiveView`, which is in the previous example. If you need a different template, set the ``template_name`` attribute to be the name of the new template. [d226d2bd]
- class Article(models.Model): title = models.CharField(max_length=200) pub_date = models.DateField() [cc3c6ded]
- class ArticleDayArchiveView(DayArchiveView): queryset = Article.objects.all() date_field = "pub_date" allow_future = True [c6e0431a]
- class ArticleMonthArchiveView(MonthArchiveView): queryset = Article.objects.all() date_field = "pub_date" allow_future = True [e1638112]
- class ArticleTodayArchiveView(TodayArchiveView): queryset = Article.objects.all() date_field = "pub_date" allow_future = True [eab25bb2]
- class ArticleWeekArchiveView(WeekArchiveView): queryset = Article.objects.all() date_field = "pub_date" week_format = "%W" allow_future = True [b98cccf4]
- class ArticleYearArchiveView(YearArchiveView): queryset = Article.objects.all() date_field = "pub_date" make_object_list = True allow_future = True [f64a00d9]
- from django.urls import path [c537d1941a7e3025-8]

## Beyond the budget

117 more facts did not fit in the budget: [80b3b4640d5882cf] [9939abc0] [c4aeda84] [fdc0f10b] [1e9d6f9a] [1fa57d44] [13bcdcd4] [cc1c66bb] [862adf2a1a6d8744] [2a87bd49] [ce867c08] [7b556d36] [81f86566] [ca9bd8be] [4d7e0a8b] [057082c6] [124ca4c4] [f837efb3] [fab9723a] [d3c447e8] [55c1ad8d] [af41b500] [e61173d8] [57a2ba08] [1a63ec6c] [8675974d] [281949b6] [9dd9b076] [c41450a5] [d7a83284] [11e79e50] [77adfe8a] [947bf18f] [99031580] [c8717cd5] [e5f3a7a7] [6a30b63f] [08593460] [c4855b3d] [d55cb96d] [5eb25341] [014e8ffd] [a923d593] [140fc954] [aee5df1282977045] [7007a10b] [d99c1d86] [32590fb0e4b1f943-3] [32590fb0e4b1f943-4] [32590fb0e4b1f943-5] [32590fb0e4b1f943-6] [32590fb0e4b1f943-7] [32590fb0e4b1f943-8] [32590fb0e4b1f943-9] [ac0dd05fa9a91c22-2] [ac0dd05fa9a91c22-3] [ac0dd05fa9a91c22-4] [ac0dd05fa9a91c22-5] [ac0dd05fa9a91c22-6] [ac0dd05fa9a91c22-7] [021d50c9] [08e840a4] [dab0d559] [f6ebaff5] [e9efa674] [d816c9df9fe3d4e9] [f72889f98a2ac701] [c53bd2bbe44e70a1] [cabf9677d929dff8] [cabf9677d929dff8-2] [cabf9677d929dff8-3] [cabf9677d929dff8-4] [cabf9677d929dff8-5] [cabf9677d929dff8-6] [cabf9677d929dff8-7] [16914ab0] [00ab7a28] [923e3a8f] [6b193e4a] [82a11767] [b0c55f5a] [e5a21402] [bb5ca0ff] [b6674b05] [685d15dfb6eb2285-45] [8f4144de] [c7f21172] [5696fb46] [884ef4be] [363e3b8b] [80c85d14] [1a79cad5] [4b6b4831] [1af78a4e] [37a288572f0328d1] [1ff4ea44] [3a933089] [05724f13] [3daec3b9] [69e09964] [ea438baa] [863cb0e9] [3af56560] [ba8dd433] [9d55487c] [24e1aa32] [942ae6c11625c81c-24] [942ae6c11625c81c-25] [025c46be] [4c45ba01] [8901b945] [bc81c09e] [8305c8da] [6e9245f5] [58443353] [89ff1403] [b75b343c]
