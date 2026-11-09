# docs/ref/class-based-views/generic-display

- Subject: docs/ref/class-based-views/generic-display (id `ece55d3e-956b-421e-ba78-f486aca9f3df`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 19 of 60
- Conflicts: 0
- Gaps: 0

## Facts

- def get_context_data(self, **kwargs): context = super().get_context_data(**kwargs) context["now"] = timezone.now() return context [fafb9092cb31dbfa]
- <h1>Articles</h1> <ul> {% for article in object_list %} <li>{{ article.pub_date|date }} - {{ article.headline }}</li> {% empty %} <li>No articles yet.</li> {% endfor %} </ul> [cd76d85d]
- <h1>{{ object.headline }}</h1> <p>{{ object.content }}</p> <p>Reporter: {{ object.reporter }}</p> <p>Published: {{ object.pub_date|date }}</p> <p>Date: {{ now|date }}</p> [1bd7c92e]
- Adds ``object_list`` to the context. If :attr:`~django.views.generic.list.MultipleObjectMixin.allow_empty` is True then display an empty list. If :attr:`~django.views.generic.list.MultipleObjectMixin.allow_empty` is False then raise a 404 error. [acc4c77b]
- Adds ``object`` to the context. [e0447d2a]
- class ArticleDetailView(DetailView): model = Article [bb0951dc]
- class ArticleListView(ListView): model = Article paginate_by = 100 # if pagination is desired [0b2478a5]
- from article.views import ArticleDetailView [75a42733]
- from article.views import ArticleListView [f5395c25]
- from articles.models import Article [69dbb3213d5b379f-3]
- from django.urls import path [c537d1941a7e3025-13]
- from django.utils import timezone from django.views.generic.detail import DetailView [a2f755f3]
- from django.utils import timezone from django.views.generic.list import ListView [57b121f7]
- urlpatterns = [ path("", ArticleListView.as_view(), name="article-list"), ] [43c560bd]
- urlpatterns = [ path("<slug:slug>/", ArticleDetailView.as_view(), name="article-detail"), ] [e2c7c6d9]
- #. :meth:`~django.views.generic.base.View.setup` #. :meth:`~django.views.generic.base.View.dispatch` #. :meth:`~django.views.generic.base.View.http_method_not_allowed` #. :meth:`~django.views.generic.base.TemplateResponseMixin.get_template_names` #. :meth:`~django.views.generic.detail.SingleObjectMixin.get_slug_field` #. :meth:`~django.views.generic.detail.SingleObjectMixin.get_queryset` #. :meth:`~django.views.generic.detail.SingleObjectMixin.get_object` #. :meth:`~django.views.generic.detail.SingleObjectMixin.get_context_object_name` #. :meth:`~django.views.generic.detail.SingleObjectMixin.get_context_data` #. :meth:`~django.views.generic.detail.BaseDetailView.get` #. :meth:`~django.views.generic.base.TemplateResponseMixin.render_to_response` [dae69304]
- #. :meth:`~django.views.generic.base.View.setup` #. :meth:`~django.views.generic.base.View.dispatch` #. :meth:`~django.views.generic.base.View.http_method_not_allowed` #. :meth:`~django.views.generic.base.TemplateResponseMixin.get_template_names` #. :meth:`~django.views.generic.list.MultipleObjectMixin.get_queryset` #. :meth:`~django.views.generic.list.MultipleObjectMixin.get_context_object_name` #. :meth:`~django.views.generic.list.MultipleObjectMixin.get_context_data` #. :meth:`~django.views.generic.list.BaseListView.get` #. :meth:`~django.views.generic.base.TemplateResponseMixin.render_to_response` [532c5c4c]
- **Ancestors (MRO)** [32590fb0e4b1f943-10]
- **Methods** [7407ef7dca9e98ce-19]

## Beyond the budget

32 more facts did not fit in the budget: [b9c1be4d] [a0333e90] [3cc560fe] [03d41b39] [32590fb0e4b1f943-11] [32590fb0e4b1f943-12] [32590fb0e4b1f943-13] [d816c9df9fe3d4e9-2] [c4258540] [f72889f98a2ac701-8] [c53bd2bbe44e70a1-6] [1732ea16a7d09411-4] [9096df2856e2660f-4] [9096df2856e2660f-5] [7407ef7dca9e98ce-20] [685d15dfb6eb2285-51] [3c13e900595e87cf] [3009c843] [5224ea7e] [f3fb461f] [947b5601] [470bc2847d96bfb8-2] [292a192a] [bdaf81c2] [2c6bbb76] [e7be0586] [779552ef] [266bb841] [a4487c6f] [645dac98] [f7b1be85] [c552f6af]
