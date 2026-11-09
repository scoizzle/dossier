# django/contrib/admin/decorators

- Subject: django/contrib/admin/decorators (id `9cc3e427-215c-4f0f-af12-aaf216041d4a`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 969 tokens
- Facts shown: 21 of 23
- Conflicts: 0
- Gaps: 0

## Highlights

- @admin.action( permissions=['publish'], description='Mark selected stories as published', ) def make_published(self, request, queryset): queryset.update(status='p') [48531224]
- @admin.display( boolean=True, ordering='-publish_date', description='Is Published?', ) def is_published(self, obj): return obj.publish_date is not None [dbf380ec]
- admin_site = site or default_site [381ba143]
- admin_site.register(models, admin_class=admin_class) [042f5e2b]
- def is_published(self, obj): return obj.publish_date is not None is_published.boolean = True is_published.admin_order_field = '-publish_date' is_published.short_description = 'Is Published?' """ [83db4b92]
- def make_published(self, request, queryset): queryset.update(status='p') make_published.allowed_permissions = ['publish'] make_published.short_description = 'Mark selected stories as published' """ [21b5bfb2]
- if not isinstance(admin_site, AdminSite): raise ValueError("site must subclass AdminSite") [63b415c5]
- if not issubclass(admin_class, ModelAdmin): raise ValueError("Wrapped class must subclass ModelAdmin.") [4f8868bb]
- return admin_class [579e68b0]
- @register(Author) class AuthorAdmin(admin.ModelAdmin): pass [17fa4a2d]
- The `site` kwarg is an admin site to use instead of the default admin site. """ from django.contrib.admin import ModelAdmin from django.contrib.admin.sites import AdminSite from django.contrib.admin.sites import site as default_site [8d545cf2]
- This is equivalent to setting some attributes (with the original, longer names) on the function directly:: [9593e142406d5f73]
- def _model_admin_wrapper(admin_class): if not models: raise ValueError("At least one model must be passed to register.") [a45a0279]
- def decorator(func): if boolean is not None and empty_value is not None: raise ValueError( "The boolean and empty_value arguments to the @display " "decorator are mutually exclusive." ) if boolean is not None: func.boolean = boolean if ordering is not None: func.admin_order_field = ordering if description is not None: func.short_description = description if empty_value is not None: func.empty_value_display = empty_value return func [480444b7]
- def decorator(func): if permissions is not None: func.allowed_permissions = permissions if description is not None: func.short_description = description if description_plural is not None: func.plural_description = description_plural elif description is not None: func.plural_description = description func.locations = ( [location] if isinstance(location, ActionLocation) else location ) return func [38b04f25]
- if function is None: return decorator else: return decorator(function) [e0b285362dfff970]
- return _model_admin_wrapper [79f0aecd]
- def action( function=None, *, permissions=None, description=None, description_plural=None, location=ActionLocation.CHANGE_LIST, ): """ Conveniently add attributes to an action function:: [884f1c7e]
- def register(*models, site=None): """ Register the given model(s) classes and wrapped ModelAdmin class with admin site: [0831e4e9]

## All facts

- [e91988b6] def display( function=None, *, boolean=None, ordering=None, description=None, empty_value=None ): """ Conveniently add attributes to a display function::
- [42acd4a4] from django.contrib.admin.options import ActionLocation
