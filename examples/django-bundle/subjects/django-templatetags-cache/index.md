# django/templatetags/cache

- Subject: django/templatetags/cache (id `f8eba4be-4cec-47a6-acc6-31289437df33`)
- Kind: subject
- Budget: 1200 tokens
- Used: 834 tokens
- Facts shown: 13 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- vary_on = [var.resolve(context) for var in self.vary_on] cache_key = make_template_fragment_key(self.fragment_name, vary_on) value = fragment_cache.get(cache_key) if value is None: value = self.nodelist.render(context) fragment_cache.set(cache_key, value, expire_time) return value [0f025fbe]
- {% cache .... using="cachename" %} [4e83ecac]
- {% load cache %} {% cache [expire_time] [fragment_name] %} .. some expensive processing .. {% endcache %} [55b7b146]
- {% load cache %} {% cache [expire_time] [fragment_name] [var1] [var2] .. %} .. some expensive processing .. {% endcache %} [8996483f]
- Each unique set of arguments will result in a unique cache entry. """ nodelist = parser.parse(("endcache",)) parser.delete_first_token() tokens = token.split_contents() if len(tokens) < 3: raise TemplateSyntaxError("'%r' tag requires at least 2 arguments." % tokens[0]) if len(tokens) > 3 and tokens[-1].startswith("using="): cache_name = parser.compile_filter(tokens[-1].removeprefix("using=")) tokens = tokens[:-1] else: cache_name = None return CacheNode( nodelist, parser.compile_filter(tokens[1]), tokens[2], # fragment_name can't be a variable. [parser.compile_filter(t) for t in tokens[3:]], cache_name, ) [986291eb]
- Optionally the cache to use may be specified thus:: [cbed084f]
- This tag also supports varying by a list of arguments:: [fd556edb]
- Usage:: [a898892ae0cdf6fe-7]
- def render(self, context): try: expire_time = self.expire_time_var.resolve(context) except VariableDoesNotExist: raise TemplateSyntaxError( '"cache" tag got an unknown variable: %r' % self.expire_time_var.var ) if expire_time is not None: try: expire_time = int(expire_time) except (ValueError, TypeError): raise TemplateSyntaxError( '"cache" tag got a non-integer timeout value: %r' % expire_time ) if self.cache_name: try: cache_name = self.cache_name.resolve(context) except VariableDoesNotExist: raise TemplateSyntaxError( '"cache" tag got an unknown variable: %r' % self.cache_name.var ) try: fragment_cache = caches[cache_name] except InvalidCacheBackendError: raise TemplateSyntaxError( "Invalid cache name specified for cache tag: %r" % cache_name ) else: try: fragment_cache = caches["template_fragments"] except InvalidCacheBackendError: fragment_cache = caches["default"] [751eefb4]
- @register.tag("cache") def do_cache(parser, token): """ This will cache the contents of a template fragment for a given amount of time. [5ec501b1]
- class CacheNode(Node): def __init__(self, nodelist, expire_time_var, fragment_name, vary_on, cache_name): self.nodelist = nodelist self.expire_time_var = expire_time_var self.fragment_name = fragment_name self.vary_on = vary_on self.cache_name = cache_name [ede84ff5]
- from django.core.cache import InvalidCacheBackendError, caches from django.core.cache.utils import make_template_fragment_key from django.template import Library, Node, TemplateSyntaxError, VariableDoesNotExist [438ebeb8]
- register = Library() [c8c0ccd629deb6b1-6]
