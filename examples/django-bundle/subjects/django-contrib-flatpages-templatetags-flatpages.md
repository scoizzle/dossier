# django/contrib/flatpages/templatetags/flatpages

- Subject: django/contrib/flatpages/templatetags/flatpages (id `40c69edd-5213-4fad-a7c3-986dc5c28691`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 16 of 16
- Conflicts: 0
- Gaps: 0

## Facts

- # If the provided user is not authenticated, or no user # was provided, filter the list to only public flatpages. if self.user: user = self.user.resolve(context) if not user.is_authenticated: flatpages = flatpages.filter(registration_required=False) else: flatpages = flatpages.filter(registration_required=False) [67777960]
- # If there are 5 or 6 bits, there is a user defined if len(bits) >= 5: if bits[-4] != "for": raise template.TemplateSyntaxError(syntax_message) user = bits[-3] else: user = None [dab4251b]
- # The very last bit must be the context name if bits[-2] != "as": raise template.TemplateSyntaxError(syntax_message) context_name = bits[-1] [f57c807d]
- context[self.context_name] = flatpages return "" [5b1be16b]
- return FlatpageNode(context_name, starts_with=prefix, user=user) else: raise template.TemplateSyntaxError(syntax_message) [1445eac3]
- {% get_flatpages ['url_starts_with'] [for user] as context_name %} [7c784f26]
- {% get_flatpages as flatpages %} {% get_flatpages for someuser as flatpages %} {% get_flatpages '/about/' as about_pages %} {% get_flatpages prefix as about_pages %} {% get_flatpages '/about/' for someuser as about_pages %} """ bits = token.split_contents() syntax_message = ( "%(tag_name)s expects a syntax of %(tag_name)s " "['url_starts_with'] [for user] as context_name" % {"tag_name": bits[0]} ) # Must have at 3-6 bits in the tag if 3 <= len(bits) <= 6: # If there's an even number of bits, there's no prefix if len(bits) % 2 == 0: prefix = bits[1] else: prefix = None [1e9955b0]
- An optional ``for`` clause controls the user whose permissions are used in determining which flatpages are visible. [08c80674]
- An optional argument, ``starts_with``, limits the returned flatpages to those beginning with a particular base URL. This argument can be a variable or a string, as it resolves from the template context. [39acd063]
- Example usage:: [0d2e22957311b784]
- Syntax:: [d8d53f73]
- def render(self, context): if "request" in context: site_pk = get_current_site(context["request"]).pk else: site_pk = settings.SITE_ID flatpages = FlatPage.objects.filter(sites__id=site_pk) # If a prefix was specified, add a filter if self.starts_with: flatpages = flatpages.filter( url__startswith=self.starts_with.resolve(context) ) [fbc27b76]
- @register.tag def get_flatpages(parser, token): """ Retrieve all flatpage objects available for the current site and visible to the specific user (or visible to all users if no user is specified). Populate the template context with them in a variable whose name is defined by the ``as`` clause. [c21a2df8]
- class FlatpageNode(template.Node): def __init__(self, context_name, starts_with=None, user=None): self.context_name = context_name if starts_with: self.starts_with = template.Variable(starts_with) else: self.starts_with = None if user: self.user = template.Variable(user) else: self.user = None [7b98dc1a]
- from django import template from django.conf import settings from django.contrib.flatpages.models import FlatPage from django.contrib.sites.shortcuts import get_current_site [3a6edb73]
- register = template.Library() [8e0cd5cc07f83b92-5]
