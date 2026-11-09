# django/utils/feedgenerator

- Subject: django/utils/feedgenerator (id `1d88d3d1-7895-4999-bbdc-be97c4db221d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 15 of 71
- Conflicts: 0
- Gaps: 0

## Facts

- # Author information. if item["author_name"] and item["author_email"]: handler.addQuickElement( "author", "%s (%s)" % (item["author_email"], item["author_name"]) ) elif item["author_email"]: handler.addQuickElement("author", item["author_email"]) elif item["author_name"]: handler.addQuickElement( "dc:creator", item["author_name"], {"xmlns:dc": "http://purl.org/dc/elements/1.1/"}, ) [7fa8494d]
- # Author information. if item["author_name"] is not None: handler.startElement("author", {}) handler.addQuickElement("name", item["author_name"]) if item["author_email"] is not None: handler.addQuickElement("email", item["author_email"]) if item["author_link"] is not None: handler.addQuickElement("uri", item["author_link"]) handler.endElement("author") [19deca57]
- # Categories. for cat in item["categories"]: handler.addQuickElement("category", "", {"term": cat}) [a29b261f]
- # Enclosure. if item["enclosures"]: enclosures = list(item["enclosures"]) if len(enclosures) > 1: raise ValueError( "RSS feed items may only have one enclosure, see " "http://www.rssboard.org/rss-profile#element-channel-item-enclosure" ) enclosure = enclosures[0] handler.addQuickElement( "enclosure", "", { "url": enclosure.url, "length": enclosure.length, "type": enclosure.mime_type, }, ) [b9b9e265]
- # Enclosures. for enclosure in item["enclosures"]: handler.addQuickElement( "link", "", { "rel": "enclosure", "href": enclosure.url, "length": enclosure.length, "type": enclosure.mime_type, }, ) [d5c45748]
- # Rights. if item["item_copyright"] is not None: handler.addQuickElement("rights", item["item_copyright"]) [131c6720]
- # Summary. if item["description"] is not None: handler.addQuickElement("summary", item["description"], {"type": "html"}) [337e607b]
- # Unique ID. if item["unique_id"] is not None: unique_id = item["unique_id"] else: unique_id = get_tag_uri(item["link"], item["pubdate"]) handler.addQuickElement("id", unique_id) [210d9c7e]
- categories = categories and [str(c) for c in categories] [e62a145d]
- categories = categories and [to_str(c) for c in categories] self.items.append( { "title": to_str(title), "link": iri_to_uri(link), "description": to_str(description), "author_email": to_str(author_email), "author_name": to_str(author_name), "author_link": iri_to_uri(author_link), "pubdate": pubdate, "updateddate": updateddate, "comments": to_str(comments), "unique_id": to_str(unique_id), "unique_id_is_permalink": unique_id_is_permalink, "enclosures": enclosures or (), "categories": categories or (), "item_copyright": to_str(item_copyright), "ttl": to_str(ttl), **kwargs, } ) [7ed737f6]
- def to_str(s): return str(s) if s is not None else s [7e0f6e77]
- def to_stylesheet(s): return s if isinstance(s, Stylesheet) else Stylesheet(s) [5b5914ca]
- for item in self.items: for date_key in date_keys: item_date = item.get(date_key) if item_date: if latest_date is None or item_date > latest_date: latest_date = item_date [49f6d89c]
- if item["pubdate"] is not None: handler.addQuickElement("published", rfc3339_date(item["pubdate"])) [53730a8e]
- return latest_date or datetime.datetime.now(tz=datetime.UTC) [1e23c501]

## Beyond the budget

53 more facts did not fit in the budget: [fae73549] [d3d19134] [c19254f0] [6f173ac8] [9de9ce95] [647636c6] [fb6400cf] [a21bd5a1] [1315db36] [1c4c1d1a] [c4cf6abc] [964139fb] [e693222c] [4d7c4b70] [82f06558] [24dedb14] [84849f7cb1e07db7] [833b6242] [abbaea9e] [67496c3e] [eb52373b] [c1793cf7] [56342c0e] [8167130b] [c30b0c49] [449eedc8] [622b80e0] [eb315d2e] [9c4e5ca3] [e99c9f73] [1a1ed595] [caac78a0] [88c5c713] [56b05e57] [980e1bd1] [57ee82a0] [a1b15f6c] [0c790fe6] [4711c1fd] [447bb9a2] [d27f0ecc] [afee5a2b] [ac9131ff] [cb04207a] [6358be69] [58e8a6ee] [2ffd3abb] [215f0bbd] [635abfd7] [39eabda0] [42d78e1b] [a0ee10bb] [925bbdb2]
