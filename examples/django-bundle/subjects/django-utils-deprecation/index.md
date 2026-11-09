# django/utils/deprecation

- Subject: django/utils/deprecation (id `033dff22-8f47-4ee6-9c65-a52bec79d36f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 16 of 82
- Conflicts: 0
- Gaps: 0

## Facts

- # Define the new method if missing and complain about it if not new_method and old_method: warnings.warn( "`%s.%s` method should be renamed `%s`." % (class_name, old_method_name, new_method_name), deprecation_warning, 2, ) setattr(base, new_method_name, old_method) setattr(base, old_method_name, wrapper(old_method)) [e6278146]
- # Define the old method as a wrapped call to the new method. if not old_method and new_method: setattr(base, old_method_name, wrapper(new_method)) [69567d32]
- # Do the remapping. remapped_kwargs = dict( zip(remapped_names, args[num_positional_params:], strict=True) ) remaining_args = args[:num_positional_params] updated_kwargs = kwargs | remapped_kwargs [116691fe]
- # Identify which of the _potentially remappable_ params are # actually _being remapped_ in this particular call. remapped_names = remappable_names[ : num_positional_args - num_positional_params ] conflicts = set(remapped_names) & set(kwargs) if conflicts: # Report duplicate names in the original parameter order. conflicts_str = ", ".join( f"'{name}'" for name in remapped_names if name in conflicts ) raise TypeError( f"{func_name}() got both deprecated positional and keyword " f"argument values for {conflicts_str}." ) [4d0070a6]
- # Issue the deprecation warning. remapped_names_str = ", ".join(f"'{name}'" for name in remapped_names) warnings.warn( f"Passing positional argument(s) {remapped_names_str} to {func_name}() " "is deprecated. Use keyword arguments instead.", deprecation_warning, skip_file_prefixes=django_file_prefixes(), ) [5d478d52]
- @functools.wraps(func) async def wrapper(*args, **kwargs): if len(args) > num_positional_params: args, kwargs = remap_deprecated_args(args, kwargs) return await func(*args, **kwargs) [54d3505b]
- return remaining_args, updated_kwargs [dfce7419]
- @deprecate_posargs(RemovedInDjangoXXXXWarning, ["option1", "option2"]) def some_func(request, *, new_param=None, option2=True, option1): ... [79e1a977]
- @deprecate_posargs(RemovedInDjangoXXXXWarning, ["option1", "option2"]) def some_func(request, *, option1, option2=True): ... [ea824181]
- @deprecate_posargs(RemovedInDjangoXXXXWarning, ["option1", "option2"]) def some_func(request, wrong_new_param=None, *, option1, option2=True): # Broken: existing code may pass a value intended as option1 in the # wrong_new_param position. ... [327bd2a4]
- def remap_deprecated_args(args, kwargs): """ Move deprecated positional args to kwargs and issue a warning. Return updated (args, kwargs). """ if (num_positional_args := len(args)) > max_positional_args: raise TypeError( f"{func_name}() takes at most {max_positional_args} positional " f"argument(s) (including {num_remappable_args} deprecated) but " f"{num_positional_args} were given." ) [a60ee34f]
- def some_func(request, *, option1, option2=True): ... [38a0db5f]
- else: [6ad07797f4838346-16]
- for _ in range(skip_frames): frame, level = back(frame, level) [7e8afdaf]
- if iscoroutinefunction(func): [9b3c6cee9ff9a8ff]
- if num_by_kind[inspect.Parameter.VAR_POSITIONAL] > 0: raise TypeError( "@deprecate_posargs() cannot be used with variable positional `*args`." ) [7620b418]

## Beyond the budget

64 more facts did not fit in the budget: [cde67a7a] [501dcf8d] [5a1f36ae] [441b2934] [689e8a55] [0dd9ce79] [42da249d] [9ada69c78b7df1fa-4] [656124d6f08b58d6-4] [656124d6f08b58d6-5] [03dbddeb] [62d234e9] [905c1b4b] [8e0ad72c] [6534c83c] [593fde87] [1d67a7e6] [71ee18e1] [28e2fef1] [0180f9c4] [1b5dd02d] [73798212] [7a425fe4] [eb5ddf0a] [2aaf5bd6] [43ca0585] [ad6337cb] [ea871751] [52fb6bb7] [6dce0f54] [433074d7] [dc5eba0e] [5ad92513] [dbad2027] [5a1db595] [f2ca4667] [ec8f99f0] [fedb0f97] [74f5a5ab] [e73ff966] [c38b3b34] [3e711dd3] [4acc83a7] [11fb1b6d] [cca45ed2] [d99e278e] [021b5df2d691cbd2-5] [ace2e25a] [450d36e1] [da0dd61f] [8406ec55] [13ae2766] [99cc72c8] [9c9ece8e] [c8e0e5f2] [31d891ba] [bc5824e5] [2b1e9af6] [7ec37810] [e3c1f24f] [d03d59a9] [770890ad88958a4c-16] [01e5f7cd] [512f7821]
