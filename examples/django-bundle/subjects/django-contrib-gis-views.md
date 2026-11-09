# django/contrib/gis/views

- Subject: django/contrib/gis/views (id `4aab9e6a-392d-4384-8a60-0b84c7010cf9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 200 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- instance = f() instance.feed_url = getattr(f, "feed_url", None) or request.path instance.title_template = f.title_template or ("feeds/%s_title.html" % slug) instance.description_template = f.description_template or ( "feeds/%s_description.html" % slug ) return instance(request) [5bfe68d6]
- slug = url.partition("/")[0] try: f = feed_dict[slug] except KeyError: raise Http404(_("Slug %r isn’t registered.") % slug) [05be3f2e]
- def feed(request, url, feed_dict=None): """Provided for backwards compatibility.""" if not feed_dict: raise Http404(_("No feeds are registered.")) [0c609038]
- from django.http import Http404 from django.utils.translation import gettext as _ [39da9705]
