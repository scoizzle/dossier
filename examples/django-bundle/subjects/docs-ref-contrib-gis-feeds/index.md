# docs/ref/contrib/gis/feeds

- Subject: docs/ref/contrib/gis/feeds (id `e72f5afe-7f07-480b-980c-25ee2a29f772`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 871 tokens
- Facts shown: 29 facts
- Conflicts: 0
- Gaps: 0

## Facts

- # Also a function with no arguments def geometry(self): ... [40331300]
- # And as a function with a single argument def geometry(self, obj): ... [b4494645]
- def item_geometry(self): ... [e9885865]
- def item_geometry(self, item): ... [f79ec300]
- class MyFeed(Feed): # First, as a class attribute. geometry = ... item_geometry = ... [60a5b557]
- class ZipcodeFeed(Feed): def geometry(self, obj): # Can also return: `obj.poly`, and `obj.poly.centroid`. return obj.poly.extent # tuple like: (X0, Y0, X1, Y1). [e9b95b5a]
- class ZipcodeFeed(Feed): def item_geometry(self, obj): # Returns the polygon. return obj.poly [a540c0a6]
- from django.contrib.gis.feeds import Feed [c2591457]
- .. method:: geometry(obj) [619da8bf]
- .. method:: item_geometry(item) [c0699a2e]
- In addition to methods provided by the :class:`django.contrib.syndication.views.Feed` base class, GeoDjango's ``Feed`` class provides the following overrides. Note that these overrides may be done in multiple ways:: [69bd9ba7]
- Set this to return the geometry for each *item* in the feed. This can be a ``GEOSGeometry`` instance, or a tuple that represents a point coordinate or bounding box. For example:: [a353e27b]
- Takes the object returned by ``get_object()`` and returns the *feed's* geometry. Typically this is a ``GEOSGeometry`` instance, or can be a tuple to represent a point or a box. For example:: [0b2ed691]
- `W3C Geo`_ formatted feeds only support :class:`~django.contrib.gis.db.models.PointField` geometries. [146b1643]
- .. _W3C Geo: https://www.w3.org/2003/01/geo/ [6fafa7e6]
- .. class:: Feed [b9758bcd]
- .. class:: GeoAtom1Feed [6a173b22]
- .. class:: GeoRSSFeed [72623287]
- .. class:: W3CGeoFeed [e4a31f1f]
- .. module:: django.contrib.gis.feeds :synopsis: GeoDjango's framework for generating spatial feeds. [4fe21590]
- .. note:: [942ae6c11625c81c-44]
- ================ Geographic Feeds ================ [c5090bd6]
- API Reference ============= [b230c4722728fb5b]
- Example ======= [cf1461d9a1a7899c]
- GeoDjango has its own :class:`Feed` subclass that may embed location information in RSS/Atom feeds formatted according to either the `Simple GeoRSS`__ or `W3C Geo`_ standards. Because GeoDjango's syndication API is a superset of Django's, please consult :doc:`Django's syndication documentation </ref/contrib/syndication>` for details on general usage. [3455fe61]
- The following :class:`django.utils.feedgenerator.SyndicationFeed` subclasses are available: [1b097d3f]
- __ https://www.ogc.org/standard/georss/ [14d28bf9]
- ``Feed`` Subclass ----------------- [b315d36e]
- ``SyndicationFeed`` Subclasses ------------------------------ [b56bb155]
