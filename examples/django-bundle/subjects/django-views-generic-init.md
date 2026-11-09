# django/views/generic/__init__

- Subject: django/views/generic/__init__ (id `6382f8e6-0887-47e4-918f-0cf75b867c18`)
- Kind: subject
- Budget: 1200 tokens
- Used: 237 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- pass [7655780f0d17b825-56]
- __all__ = [ "View", "TemplateView", "RedirectView", "ArchiveIndexView", "YearArchiveView", "MonthArchiveView", "WeekArchiveView", "DayArchiveView", "TodayArchiveView", "DateDetailView", "DetailView", "FormView", "CreateView", "UpdateView", "DeleteView", "ListView", "GenericViewError", ] [d2505d8f]
- class GenericViewError(Exception): """A problem in a generic view.""" [0d9829db]
- from django.views.generic.base import RedirectView, TemplateView, View from django.views.generic.dates import ( ArchiveIndexView, DateDetailView, DayArchiveView, MonthArchiveView, TodayArchiveView, WeekArchiveView, YearArchiveView, ) from django.views.generic.detail import DetailView from django.views.generic.edit import CreateView, DeleteView, FormView, UpdateView from django.views.generic.list import ListView [bbfaed3f]
