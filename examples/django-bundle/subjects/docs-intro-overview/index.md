# docs/intro/overview

- Subject: docs/intro/overview (id `a0272db1-5ac2-443d-b903-4bf978d35ca7`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 24 of 92
- Conflicts: 0
- Gaps: 0

## Facts

- def __str__(self): return self.full_name [357f8731]
- def __str__(self): return self.headline [da572ff3]
- # And vice versa: Reporter objects get API access to Article objects. >>> r.article_set.all() <QuerySet [<Article: Django is cool>]> [f135fe49]
- # Article objects get API access to related Reporter objects. >>> r = a.reporter >>> r.full_name 'John Smith' [74b0268d]
- # Change an object by altering its attributes and calling save(). >>> r.full_name = "Billy Goat" >>> r.save() [92c30f1d]
- # Create a new Reporter. >>> r = Reporter(full_name="John Smith") [8f489e0a]
- # Create an article. >>> from datetime import date >>> a = Article( ... pub_date=date.today(), headline="Django is cool", content="Yeah.", reporter=r ... ) >>> a.save() [fbf0ebaa]
- # Delete an object with delete(). >>> r.delete() [0591abfd]
- # Django provides a rich database lookup API. >>> Reporter.objects.get(id=1) <Reporter: John Smith> >>> Reporter.objects.get(full_name__startswith="John") <Reporter: John Smith> >>> Reporter.objects.get(full_name__contains="mith") <Reporter: John Smith> >>> Reporter.objects.get(id=2) Traceback (most recent call last): ... DoesNotExist: Reporter matching query does not exist. [887ac67a]
- # Fields are represented as attributes on the Python object. >>> r.full_name 'John Smith' [e81e3d3a]
- # Import the models we created from our "news" app >>> from news.models import Article, Reporter [e11d031d]
- # No reporters are in the system yet. >>> Reporter.objects.all() <QuerySet []> [38844daf]
- # Now it has an ID. >>> r.id 1 [6ef17923]
- # Now the article is in the database. >>> Article.objects.all() <QuerySet [<Article: Django is cool>]> [e1bf2c05]
- # Now the new reporter is in the database. >>> Reporter.objects.all() <QuerySet [<Reporter: John Smith>]> [aee48eed]
- # Save the object into the database. You have to call save() explicitly. >>> r.save() [a124860a]
- # The API follows relationships as far as you need, performing efficient # JOINs for you behind the scenes. # This finds all articles by a reporter whose name starts with "John". >>> Article.objects.filter(reporter__full_name__startswith="John") <QuerySet [<Article: Django is cool>]> [8ff7cce8]
- $ python manage.py makemigrations $ python manage.py migrate [f38f790a]
- admin.site.register(models.Article) [75b7dec4]
- class Article(models.Model): pub_date = models.DateField() headline = models.CharField(max_length=200) content = models.TextField() reporter = models.ForeignKey(Reporter, on_delete=models.CASCADE) [c9d6fc47d5d16201]
- class Reporter(models.Model): full_name = models.CharField(max_length=70) [660b44df]
- def year_archive(request, year): a_list = Article.objects.filter(pub_date__year=year) context = {"year": year, "article_list": a_list} return render(request, "news/year_archive.html", context) [7e807aec]
- from . import models [628b8592]
- from . import views [c00926fe3424edad]

## Beyond the budget

65 more facts did not fit in the budget: [f1559cb2] [13fbe7fc2a5a9c75] [4af926756c29efa6-5] [f3bb80f2b2fd7f5d-2] [c537d1941a7e3025] [5e8730b8] [7c481acd] [1ebc1c73] [0a6c70ed0cb3c3fb-5] [69d10c0e] [f9390803] [d563f3cc] [6f5e47ec] [fabbc27a] [06d6609f] [aff96a88] [402439f4] [8d3fee85] [eaf050be34acb41d-6] [b2dc06ee] [3af9e285bc17d457] [402a0e9b] [3be1659cdc78684b] [7714e199aac2701e-65] [64c7e504] [116b4a95] [0bd04867] [c01681cd] [180a0d47] [f257df38] [6b04596d] [02c09188] [59479c0d] [ae10edcf] [3a2e0913] [253dcf8b] [2d6c4f0f] [ce64428b] [a69cb078] [988590fe] [ee91d398] [8648d194] [0e0fec80] [17ec420a] [14e379b5] [8e5e38a5] [f77b7199] [d20327d7] [b8eff2e8] [3ce6db98] [a7cc207c] [86eb2219] [7bf37223] [a7dcd7a3] [bd4a80b6] [e9ba301e] [709ec45f] [7b46609a] [49e8c5de] [1d6b4fd1] [3a4d9d3c] [91d1b17f] [5d4db016] [09166433] [cf6e69c1]
