# django/contrib/admin/templatetags/admin_filters

- Subject: django/contrib/admin/templatetags/admin_filters (id `3017656b-a93d-47ba-a4f7-195bb8b879ae`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 654 tokens
- Facts shown: 16 of 16
- Conflicts: 0
- Gaps: 0

## Facts

- if should_display_item: output.append("%s<li>%s%s</li>" % (indent, escaper(item), sublist)) [fd6bbbd6]
- def escaper(x): return x [1c109dc9108f15cf]
- return "\n".join(output) [85199231]
- {{ deleted_objects|truncated_unordered_list:100 }} """ [fd438c45]
- Usage:: [a898892ae0cdf6fe]
- def list_formatter(item_list, tabs=1): nonlocal item_count indent = "\t" * tabs output = [] for item, children in _walk_items(item_list): sublist = "" item_count += 1 should_display_item = has_unlimited_items or 0 < item_count <= max_items if children: sublist = "\n%s<ul>\n%s\n%s</ul>\n%s" % ( indent, list_formatter(children, tabs + 1), indent, indent, ) [6a79716a]
- has_unlimited_items = max_items is None if not has_unlimited_items: max_items = int(max_items) if max_items <= 0: return mark_safe("") [7c26aede]
- if autoescape: escaper = conditional_escape else: [b56ea0f4]
- if not has_unlimited_items and item_count > max_items: remaining_object_count = item_count - max_items remaining_objects_message = "\n\t<li>%s</li>" % ( ngettext( "…and %(count)d more object.", "…and %(count)d more objects.", remaining_object_count, ) % {"count": remaining_object_count} ) [8a3b967d]
- item_count = 0 [4179b05a]
- rendered_object_list = list_formatter(value) remaining_objects_message = "" [1bde8a24]
- return mark_safe(rendered_object_list + remaining_objects_message) [1a357f76]
- @register.filter @stringfilter def to_object_display_value(value): return display_for_value(str(value), EMPTY_VALUE_STRING) [a042e7f1]
- @register.filter(is_safe=True, needs_autoescape=True) def truncated_unordered_list(value, max_items, autoescape=True): """ Render an unordered list, showing at most ``max_items`` items and a "...and N more objects." item at the end. [addf3867]
- from django import template from django.contrib.admin.options import EMPTY_VALUE_STRING from django.contrib.admin.utils import display_for_value from django.template.defaultfilters import _walk_items, stringfilter from django.utils.html import conditional_escape from django.utils.safestring import mark_safe from django.utils.translation import ngettext [406cab84]
- register = template.Library() [8e0cd5cc07f83b92]
