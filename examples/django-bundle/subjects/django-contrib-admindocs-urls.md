# django/contrib/admindocs/urls

- Subject: django/contrib/admindocs/urls (id `db08ff71-fecb-46f2-afbc-157ae51a5502`)
- Kind: subject
- Budget: 1200 tokens
- Used: 276 tokens
- Facts shown: 2 of 2
- Conflicts: 0
- Gaps: 0

## Facts

- from django.contrib.admindocs import views from django.urls import path, re_path [350d794f]
- urlpatterns = [ path( "", views.BaseAdminDocsView.as_view(template_name="admin_doc/index.html"), name="django-admindocs-docroot", ), path( "bookmarklets/", views.BookmarkletsView.as_view(), name="django-admindocs-bookmarklets", ), path( "tags/", views.TemplateTagIndexView.as_view(), name="django-admindocs-tags", ), path( "filters/", views.TemplateFilterIndexView.as_view(), name="django-admindocs-filters", ), path( "views/", views.ViewIndexView.as_view(), name="django-admindocs-views-index", ), path( "views/<view>/", views.ViewDetailView.as_view(), name="django-admindocs-views-detail", ), path( "models/", views.ModelIndexView.as_view(), name="django-admindocs-models-index", ), re_path( r"^models/(?P<app_label>[^.]+)\.(?P<model_name>[^/]+)/$", views.ModelDetailView.as_view(), name="django-admindocs-models-detail", ), path( "templates/<path:template>/", views.TemplateDetailView.as_view(), name="django-admindocs-templates", ), ] [61d5a511]
