# django/core/files/images

- Subject: django/core/files/images (id `26eec7db-059a-4a24-bc47-16e404ba242a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 595 tokens
- Facts shown: 10 of 10
- Conflicts: 0
- Gaps: 0

## Facts

- @property def height(self): return self._get_image_dimensions()[1] [e796b5d0]
- @property def width(self): return self._get_image_dimensions()[0] [7d28b7cb]
- def _get_image_dimensions(self): if not hasattr(self, "_dimensions_cache"): close = self.closed self.open() self._dimensions_cache = get_image_dimensions(self, close=close) return self._dimensions_cache [e8a4e454]
- p = PillowImageFile.Parser() if hasattr(file_or_path, "read"): file = file_or_path file_pos = file.tell() file.seek(0) else: try: file = open(file_or_path, "rb") except OSError: return (None, None) close = True try: # Most of the time Pillow only needs a small chunk to parse the image # and get the dimensions, but with some TIFF files Pillow needs to # parse the whole file. chunk_size = 1024 while 1: data = file.read(chunk_size) if not data: break try: p.feed(data) except zlib.error as e: # ignore zlib complaining on truncated stream, just feed more # data to parser (ticket #19457). if e.args[0].startswith("Error -5"): pass else: raise except struct.error: # Ignore PIL failing on a too short buffer when reads return # less bytes than expected. Skip and feed more data to the # parser (ticket #24544). pass except RuntimeError: # e.g. "RuntimeError: could not create decoder object" for # WebP files. A different chunk_size may work. pass if p.image: return p.image.size chunk_size *= 2 return (None, None) finally: if close: file.close() else: file.seek(file_pos) [90baf9c9]
- """ Utility functions for handling images. [e6250680]
- Requires Pillow as you might imagine. """ [9f5c48f9]
- class ImageFile(File): """ A mixin for use alongside django.core.files.base.File, which provides additional features for dealing with images. """ [6b843b35]
- def get_image_dimensions(file_or_path, close=False): """ Return the (width, height) of an image, given an open file or a path. Set 'close' to True to close the file at the end if it is initially in an open state. """ from PIL import ImageFile as PillowImageFile [f12717f6]
- from django.core.files import File [58627e36]
- import struct import zlib [ada0015d]
