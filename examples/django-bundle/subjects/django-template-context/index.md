# django/template/context

- Subject: django/template/context (id `9ebfe2e0-8c59-4b8d-9de2-5ed8fcaeb544`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2404 tokens
- Facts shown: 49 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- # empty dict for any new modifications # (so that context processors don't overwrite them) self.update({}) [5de249d6]
- # placeholder for context processors output self.update({}) [1719b65a]
- context.dicts.append(self) self.context = context [358ae4e6]
- self.dicts[self._processors_index] = updates [a390bcdf]
- self.template = template # Set context processors according to the template engine's settings. processors = template.engine.template_context_processors + self._processors updates = {} for processor in processors: context = processor(self.request) try: updates.update(context) except TypeError as e: raise TypeError( f"Context processor {processor.__qualname__} didn't return a " "dictionary." ) from e [61919b36]
- try: yield finally: self.template = None # Unset context processors. self.dicts[self._processors_index] = {} [57d0b17f]
- @contextmanager def bind_template(self, template): if self.template is not None: raise RuntimeError("Context is already bound to a template") [15392bec]
- @contextmanager def bind_template(self, template): if self.template is not None: raise RuntimeError("Context is already bound to a template") self.template = template try: yield finally: self.template = None [4e91e7e0]
- @contextmanager def push_state(self, template, isolated_context=True): initial = self.template self.template = template if isolated_context: self.push() try: yield finally: self.template = initial if isolated_context: self.pop() [f369d4ca]
- RenderContext simplifies the implementation of template Nodes by providing a safe place to store state between invocations of a node's `render` method. [9b2bea51]
- The RenderContext also provides scoping rules that are more sensible for 'template local' variables. The render context stack is pushed before each template is rendered, creating a fresh scope with nothing in it. Name resolution fails if a variable is not found at the top of the RequestContext stack. Thus, variables are local to a specific template and don't affect the rendering of other templates as they would if they were stored in the normal template context. """ [5091644f]
- def __contains__(self, key): return any(key in d for d in self.dicts) [7981328c]
- def __contains__(self, key): return key in self.dicts[-1] [fcd55c65]
- def __copy__(self): duplicate = BaseContext() duplicate.__class__ = self.__class__ duplicate.__dict__ = copy(self.__dict__) duplicate.dicts = self.dicts[:] return duplicate [cba8d7d3]
- def __copy__(self): duplicate = super().__copy__() duplicate.render_context = copy(self.render_context) return duplicate [4d95bbfa]
- def __delitem__(self, key): "Delete a variable from the current context" del self.dicts[-1][key] [ee3185df]
- def __enter__(self): return self [3ef33e95d940f83e-3]
- def __eq__(self, other): """ Compare two contexts by comparing their 'dicts' attributes. """ if not isinstance(other, BaseContext): return NotImplemented # flatten dictionaries because they can be put in a different order. return self.flatten() == other.flatten() [5ff10a8b]

## All facts

- [8afde90a] def __exit__(self, *args, **kwargs): self.context.pop()
- [d5d27fad] def __getitem__(self, key): """ Get a variable's value, starting at the current context and going upward """ for d in reversed(self.dicts): if key in d: return d[key] raise KeyError(key)
- [4fcff80d] def __getitem__(self, key): return self.dicts[-1][key]
- [f1f06396] def __init__( self, request, dict_=None, processors=None, use_l10n=None, use_tz=None, autoescape=True, ): super().__init__(dict_, use_l10n=use_l10n, use_tz=use_tz, autoescape=autoescape) self.request = request self._processors = () if processors is None else tuple(processors) self._processors_index = len(self.dicts)
- [760f7a9d] def __init__(self, dict_=None, autoescape=True, use_l10n=None, use_tz=None): self.autoescape = autoescape self.use_l10n = use_l10n self.use_tz = use_tz self.template_name = "unknown" self.render_context = RenderContext() # Set to the original template -- as opposed to extended or included # templates -- during rendering, see bind_template. self.template = None super().__init__(dict_)
- [e8f93543] def __iter__(self): return reversed(self.dicts)
- [a501245a] def __iter__(self): yield from self.dicts[-1]
- [f099985c] def __repr__(self): return repr(self.dicts)
- [596b1dd1] def __setitem__(self, key, value): "Set a variable in the current context" self.dicts[-1][key] = value
- [8e3f6da0] def _reset_dicts(self, value=None): builtins = {"True": True, "False": False, "None": None} self.dicts = [builtins] if isinstance(value, BaseContext): self.dicts += value.dicts[1:] elif value is not None: self.dicts.append(value)
- [b8f57e12] def flatten(self): """ Return self.dicts as one dictionary. """ flat = {} for d in self.dicts: flat.update(d) return flat
- [cda4b6ec] def get(self, key, otherwise=None): for d in reversed(self.dicts): if key in d: return d[key] return otherwise
- [f0981052] def get(self, key, otherwise=None): return self.dicts[-1].get(key, otherwise)
- [8ee872bd] def new(self, values=None): """ Return a new context with the same properties, but with only the values given in 'values' stored. """ new_context = copy(self) new_context._reset_dicts(values) return new_context
- [767c29f0] def new(self, values=None): new_context = super().new(values) # This is for backwards-compatibility: RequestContexts created via # Context.new don't include values from context processors. if hasattr(new_context, "_processors_index"): del new_context._processors_index return new_context
- [b397344c] def pop(self): if len(self.dicts) == 1: raise ContextPopException return self.dicts.pop()
- [cfdb22b8] def push(self, *args, **kwargs): dicts = [] for d in args: if isinstance(d, BaseContext): dicts += d.dicts[1:] else: dicts.append(d) return ContextDict(self, *dicts, **kwargs)
- [fe4b5ac6] def set_upward(self, key, value): """ Set a variable in one of the higher contexts if it exists there, otherwise in the current context. """ context = self.dicts[-1] for d in reversed(self.dicts): if key in d: context = d break context[key] = value
- [1acbbe26] def setdefault(self, key, default=None): try: return self[key] except KeyError: self[key] = default return default
- [a65aa2b7] def update(self, other_dict): "Push other_dict to the stack of dictionaries in the Context" if not hasattr(other_dict, "__getitem__"): raise TypeError("other_dict must be a mapping (dictionary-like) object.") if isinstance(other_dict, BaseContext): other_dict = other_dict.dicts[1:].pop() return ContextDict(self, other_dict)
- [7655780f0d17b825-52] pass
- [b607e6cb] template = None
- [7cdeb32f] # Hard-coded processor for easier use of CSRF protection. _builtin_context_processors = ("django.template.context_processors.csrf",)
- [44e4746b] class BaseContext: def __init__(self, dict_=None): self._reset_dicts(dict_)
- [f5e9bbed] class Context(BaseContext): "A stack container for variable context"
- [481422dd] class ContextDict(dict): def __init__(self, context, *args, **kwargs): super().__init__(*args, **kwargs)
- [72f723eb] class ContextPopException(Exception): "pop() has been called more times than push()"
- [3ac22c75] class RenderContext(BaseContext): """ A stack container for storing Template state.
- [4cd4b425] class RequestContext(Context): """ This subclass of template.Context automatically populates itself using the processors defined in the engine's configuration. Additional processors can be specified as a list of callables using the "processors" keyword argument. """
- [d7e5ac84] def make_context(context, request=None, **kwargs): """ Create a suitable Context from a plain dict and optionally an HttpRequest. """ if context is not None and not isinstance(context, dict): raise TypeError( "context must be a dict rather than %s." % context.__class__.__name__ ) if request is None: context = Context(context, **kwargs) else: # The following pattern is required to ensure values from # context override those from template context processors. original_context = context context = RequestContext(request, **kwargs) if original_context: context.push(original_context) return context
- [d49103cf] from contextlib import contextmanager from copy import copy
