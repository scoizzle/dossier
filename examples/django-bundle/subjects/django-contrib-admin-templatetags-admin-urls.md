# django/contrib/admin/templatetags/admin_urls

- Subject: django/contrib/admin/templatetags/admin_urls (id `15356a15-cb0e-409f-aa93-66fce1b7a920`)
- Kind: subject
- Budget: 1200 tokens
- Used: 587 tokens
- Facts shown: 16 of 16
- Conflicts: 0
- Gaps: 0

## Facts

- match_url = "/%s" % unquote(url).partition(get_script_prefix())[2] try: match = resolve(match_url) except Resolver404: pass else: current_url = "%s:%s" % (match.app_name, match.url_name) changelist_url = "admin:%s_%s_changelist" % ( opts.app_label, opts.model_name, ) if ( changelist_url == current_url and "_changelist_filters" in preserved_filters ): preserved_filters = dict( parse_qsl(preserved_filters["_changelist_filters"]) ) [4eb3c7b4]
- merged_qs.update(preserved_filters) [88ca68e2]
- merged_qs[IS_POPUP_VAR] = 1 if to_field: from django.contrib.admin.options import TO_FIELD_VAR [9ab91f9a]
- merged_qs[TO_FIELD_VAR] = to_field [db924a20]
- if opts and preserved_filters: preserved_filters = dict(parse_qsl(preserved_filters)) [59160303]
- if popup: from django.contrib.admin.options import IS_POPUP_VAR [bee08bf6]
- if preserved_qsl: merged_qs.update(preserved_qsl) [0a8fbe68]
- merged_qs.update(parsed_qs) [be1d20af]
- parsed_url = list(urlsplit(url)) parsed_qs = dict(parse_qsl(parsed_url[3])) merged_qs = {} [a522ccf5]
- parsed_url[3] = urlencode(merged_qs) return urlunsplit(parsed_url) [9701c762]
- @register.filter def admin_urlname(value, arg): return "admin:%s_%s_%s" % (value.app_label, value.model_name, arg) [8450b7f7]
- @register.filter def admin_urlquote(value): return quote(value) [bcfb458b]
- @register.simple_tag(takes_context=True) def add_preserved_filters(context, url, popup=False, to_field=None): opts = context.get("opts") preserved_filters = context.get("preserved_filters") preserved_qsl = context.get("preserved_qsl") [4b48efc6]
- from django import template from django.contrib.admin.utils import quote from django.urls import Resolver404, get_script_prefix, resolve from django.utils.http import urlencode [500f893f]
- from urllib.parse import parse_qsl, unquote, urlsplit, urlunsplit [9e22fb75]
- register = template.Library() [8e0cd5cc07f83b92-3]
