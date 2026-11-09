# django/core/paginator

- Subject: django/core/paginator (id `5ceaade4-e8c0-4784-a285-3c7e9608cee4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 17 of 67
- Conflicts: 0
- Gaps: 0

## Facts

- 1, 2, …, 40, 41, 42, 43, 44, 45, 46, …, 49, 50. """ if num_pages <= (on_each_side + on_ends) * 2: yield from page_range return [9d6ad00b]
- If the page range is larger than a given size, the whole range is not provided and a compact form is returned instead, e.g. for a paginator with 50 pages, if page 43 were the current page, the output, with the default arguments, would be: [115284f5]
- This hook can be used by subclasses to use an alternative to the standard :cls:`Page` object. """ return Page(*args, **kwargs) [671b6ffd]
- This method must be awaited before AsyncPage can be treated as a sequence of self.object_list. """ if not isinstance(self.object_list, list): if hasattr(self.object_list, "__aiter__"): self.object_list = [obj async for obj in self.object_list] else: self.object_list = await sync_to_async(list)(self.object_list) return self.object_list [1ea62d09]
- if not isinstance(self.object_list, list): raise TypeError( "AsyncPage.aget_object_list() must be awaited before using indexing." ) return self.object_list[index] [72193e56]
- if number < (num_pages - on_each_side - on_ends) - 1: yield from range(number + 1, number + on_each_side + 1) yield self.ELLIPSIS yield from range(num_pages - on_ends + 1, num_pages + 1) else: yield from range(number + 1, num_pages + 1) [1db75ea5]
- return reversed(self.object_list) [a6909839]
- return self._get_page(self.object_list[bottom:top], number, self) [cf83d4b5]
- self._cache_acount = count return count [c9568d71]
- self._cache_anum_pages = num_pages return num_pages [f3ddcfc1]
- @cached_property def count(self): """Return the total number of objects, across all pages.""" c = getattr(self.object_list, "count", None) if callable(c) and not inspect.isbuiltin(c) and method_has_no_args(c): return c() return len(self.object_list) [05d8d461]
- @cached_property def num_pages(self): """Return the total number of pages.""" if self.count == 0 and not self.allow_empty_first_page: return 0 hits = max(1, self.count - self.orphans) return ceil(hits / self.per_page) [a84e846e]
- @property def page_range(self): """ Return a 1-based range of pages for iterating through within a template for loop. """ return range(1, self.num_pages + 1) [1033b54d]
- async def __aiter__(self): if hasattr(self.object_list, "__aiter__"): async for obj in self.object_list: yield obj else: for obj in self.object_list: yield obj [4f6940e1]
- async def __aiter__(self): page_range = await self.apage_range() for page_number in page_range: yield await self.apage(page_number) [203c26df]
- async def acount(self): """See Paginator.count().""" if self._cache_acount is not None: return self._cache_acount c = getattr(self.object_list, "acount", None) if ( inspect.iscoroutinefunction(c) and not inspect.isbuiltin(c) and method_has_no_args(c) ): count = await c() else: count = len(self.object_list) [7dfaee9a]
- async def aend_index(self): """See Page.end_index().""" num_pages = await self.paginator.anum_pages() if self.number == num_pages: return await self.paginator.acount() return self.number * self.paginator.per_page [92107b62]

## Beyond the budget

49 more facts did not fit in the budget: [e791c862] [4a5b3705] [b9fc6fc4] [a4951267] [a7446a66] [71a4bcc8] [05d38173] [b3d9cbc7] [7c9f7d9e] [8b715575] [f729acd3] [9be53c9f] [21540c21] [50ae2a36] [10990335] [41dae08c] [ad83a2a4] [cd3656b4] [399e47fb] [5e60f7cd] [808e93a3] [8a9030ea] [6757fbec] [cab38050] [7caa9409] [a982ae98] [6249d260] [940c4524] [0cba4a67] [da7205c6] [9c856d28] [1930b5c8] [196ca9f0] [0d00b7d9] [7a2f366f] [addb8f60] [d11364d8] [eb8c7744] [ab3865d4] [b58e2a51] [ee57357d] [8b2fb758] [f9b5dc75] [ec41ff87] [560c396d] [77d891a9] [770890ad88958a4c-10] [d40b5913] [d900c42d]
