# docs/ref/class-based-views/generic-display

- Subject: docs/ref/class-based-views/generic-display (id `9e82f0ce-c6de-4376-a4f2-c5c99543e903`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1863 tokens
- Facts shown: 51 of 60
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [b9c1be4d] * :class:`django.views.generic.detail.SingleObjectMixin` * :class:`django.views.generic.base.View`
- [a0333e90] * :class:`django.views.generic.detail.SingleObjectTemplateResponseMixin` * :class:`django.views.generic.base.TemplateResponseMixin` * :class:`django.views.generic.detail.BaseDetailView` * :class:`django.views.generic.detail.SingleObjectMixin` * :class:`django.views.generic.base.View`
- [3cc560fe] * :class:`django.views.generic.list.MultipleObjectMixin` * :class:`django.views.generic.base.View`
- [03d41b39] * :class:`django.views.generic.list.MultipleObjectTemplateResponseMixin` * :class:`django.views.generic.base.TemplateResponseMixin` * :class:`django.views.generic.list.BaseListView` * :class:`django.views.generic.list.MultipleObjectMixin` * :class:`django.views.generic.base.View`
- [32590fb0e4b1f943-11] **Ancestors (MRO)**
- [32590fb0e4b1f943-12] **Ancestors (MRO)**
- [32590fb0e4b1f943-13] **Ancestors (MRO)**
- [d816c9df9fe3d4e9-2] **Example myapp/article_detail.html**:
- [c4258540] **Example myapp/article_list.html**:
- [f72889f98a2ac701-8] **Example myapp/urls.py**::
- [c53bd2bbe44e70a1-6] **Example myapp/views.py**::
- [1732ea16a7d09411-4] **Example views.py**::
- [9096df2856e2660f-4] **Method Flowchart**
- [9096df2856e2660f-5] **Method Flowchart**
- [7407ef7dca9e98ce-20] **Methods**
- [685d15dfb6eb2285-51] .. code-block:: html+django
- [3c13e900595e87cf] .. method:: get(request, *args, **kwargs)
- [3009c843] A base view for displaying a list of objects. It is not intended to be used directly, but rather as a parent class of the :class:`django.views.generic.list.ListView` or other views representing lists of objects.
- [5224ea7e] A base view for displaying a single object. It is not intended to be used directly, but rather as a parent class of the :class:`django.views.generic.detail.DetailView` or other views representing details of a single object.
- [f3fb461f] A page representing a list of objects.
- [947b5601] If you're using pagination, you can adapt the :ref:`example template from the pagination docs <paginating-a-list-view>`.
- [470bc2847d96bfb8-2] This view inherits methods and attributes from the following views:
- [292a192a] While this view is executing, ``self.object_list`` will contain the list of objects (usually, but not necessarily a queryset) that the view is operating upon.
- [bdaf81c2] While this view is executing, ``self.object`` will contain the object that the view is operating upon.
- [2c6bbb76] .. class:: django.views.generic.detail.BaseDetailView
- [e7be0586] .. class:: django.views.generic.detail.DetailView
- [779552ef] .. class:: django.views.generic.list.BaseListView
- [266bb841] .. class:: django.views.generic.list.ListView
- [a4487c6f] ===================== Generic display views =====================
- [645dac98] The two following generic class-based views are designed to display data. On many projects they are typically the most commonly used views.
- [f7b1be85] ``DetailView`` ==============
- [c552f6af] ``ListView`` ============
