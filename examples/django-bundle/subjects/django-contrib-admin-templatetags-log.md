# django/contrib/admin/templatetags/log

- Subject: django/contrib/admin/templatetags/log (id `e37afa55-ce38-4127-aca6-f4703b1529aa`)
- Kind: subject
- Budget: 1200 tokens
- Used: 529 tokens
- Facts shown: 11 of 11
- Conflicts: 0
- Gaps: 0

## Facts

- {% get_admin_log 10 as admin_log for_user 23 %} {% get_admin_log 10 as admin_log for_user user %} {% get_admin_log 10 as admin_log %} [44b67bd8]
- {% get_admin_log [limit] as [varname] for_user [user_id_or_varname] %} [4c4d0bbd]
- Examples:: [322709b3dcb3a0bb]
- Note that ``user_id_or_varname`` can be a hard-coded integer (user ID) or the name of a template context variable containing the user object whose ID you want. """ tokens = token.contents.split() if len(tokens) < 4: raise template.TemplateSyntaxError( "'get_admin_log' statements require two arguments" ) if not tokens[1].isdigit(): raise template.TemplateSyntaxError( "First argument to 'get_admin_log' must be an integer" ) if tokens[2] != "as": raise template.TemplateSyntaxError( "Second argument to 'get_admin_log' must be 'as'" ) if len(tokens) > 4: if tokens[4] != "for_user": raise template.TemplateSyntaxError( "Fourth argument to 'get_admin_log' must be 'for_user'" ) return AdminLogNode( limit=tokens[1], varname=tokens[3], user=(tokens[5] if len(tokens) > 5 else None), ) [29e8c859]
- Usage:: [a898892ae0cdf6fe-2]
- def __repr__(self): return "<GetAdminLog Node>" [f3b5d70f]
- def render(self, context): entries = context["log_entries"] if self.user is not None: user_id = self.user if not user_id.isdigit(): user_id = context[self.user].pk entries = entries.filter(user__pk=user_id) context[self.varname] = entries[: int(self.limit)] return "" [07ea0399]
- @register.tag def get_admin_log(parser, token): """ Populate a template variable with the admin log for the given criteria. [c619b38b]
- class AdminLogNode(template.Node): def __init__(self, limit, varname, user): self.limit = limit self.varname = varname self.user = user [de8fa1b1]
- from django import template [505fb2f6]
- register = template.Library() [8e0cd5cc07f83b92-4]
