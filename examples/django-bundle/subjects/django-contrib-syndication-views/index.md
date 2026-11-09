# django/contrib/syndication/views

- Subject: django/contrib/syndication/views (id `15dfe7cc-c49e-4642-af06-1cea7c88c34b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 10 of 26
- Conflicts: 0
- Gaps: 0

## Facts

- feed.add_item( title=title, link=link, description=description, unique_id=self._get_dynamic_attr("item_guid", item, link), unique_id_is_permalink=self._get_dynamic_attr( "item_guid_is_permalink", item ), enclosures=enclosures, pubdate=pubdate, updateddate=updateddate, author_name=author_name, author_email=author_email, author_link=author_link, comments=self._get_dynamic_attr("item_comments", item), categories=self._get_dynamic_attr("item_categories", item), item_copyright=self._get_dynamic_attr("item_copyright", item), **self.item_extra_kwargs(item), ) return feed [a8b99828]
- pubdate = self._get_dynamic_attr("item_pubdate", item) if pubdate and is_naive(pubdate): pubdate = make_aware(pubdate, tz) [74f43a9f]
- tz = get_default_timezone() [308500e9]
- Default implementation preserves the old behavior of using {'obj': item, 'site': current_site} as the context. """ return {"obj": kwargs.get("item"), "site": kwargs.get("site")} [bb348c3c]
- description_tmp = None if self.description_template is not None: try: description_tmp = loader.get_template(self.description_template) except TemplateDoesNotExist: pass [28005c1d]
- feed = self.feed_type( title=self._get_dynamic_attr("title", obj), subtitle=self._get_dynamic_attr("subtitle", obj), link=link, description=self._get_dynamic_attr("description", obj), language=self.language or get_language(), feed_url=add_domain( current_site.domain, self._get_dynamic_attr("feed_url", obj) or request.path, request.is_secure(), ), author_name=self._get_dynamic_attr("author_name", obj), author_link=self._get_dynamic_attr("author_link", obj), author_email=self._get_dynamic_attr("author_email", obj), categories=self._get_dynamic_attr("categories", obj), feed_copyright=self._get_dynamic_attr("feed_copyright", obj), feed_guid=self._get_dynamic_attr("feed_guid", obj), ttl=self._get_dynamic_attr("ttl", obj), stylesheets=self._get_dynamic_attr("stylesheets", obj), **self.feed_extra_kwargs(obj), ) [02ec197c]
- for item in self._get_dynamic_attr("items", obj): context = self.get_context_data( item=item, site=current_site, obj=obj, request=request ) if title_tmp is not None: title = title_tmp.render(context, request) else: title = self._get_dynamic_attr("item_title", item) if description_tmp is not None: description = description_tmp.render(context, request) else: description = self._get_dynamic_attr("item_description", item) link = add_domain( current_site.domain, self._get_dynamic_attr("item_link", item), request.is_secure(), ) enclosures = self._get_dynamic_attr("item_enclosures", item) author_name = self._get_dynamic_attr("item_author_name", item) if author_name is not None: author_email = self._get_dynamic_attr("item_author_email", item) author_link = self._get_dynamic_attr("item_author_link", item) else: author_email = author_link = None [9603aae4]
- link = self._get_dynamic_attr("link", obj) link = add_domain(current_site.domain, link, request.is_secure()) [c7fbb549]
- def feed_extra_kwargs(self, obj): """ Return an extra keyword arguments dictionary that is used when initializing the feed generator. """ return {} [9bf55dc5]
- def get_context_data(self, **kwargs): """ Return a dictionary to use as extra context if either ``self.description_template`` or ``self.item_template`` are used. [57b7efa0]

## Beyond the budget

14 more facts did not fit in the budget: [fa557dbd] [01a6bfd1] [565c315e] [3329a049] [4e31d77d] [0a53240d] [27d6d451] [9707cd86] [b0788f82] [51167614] [45ba4cd8] [fbd4262c] [3cf8daa3] [6577c64c]
