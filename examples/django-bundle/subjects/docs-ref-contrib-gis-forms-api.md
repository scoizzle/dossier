# docs/ref/contrib/gis/forms-api

- Subject: docs/ref/contrib/gis/forms-api (id `ceee9e8c-0e59-446e-9c39-cfa75b313c45`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 29 of 102
- Conflicts: 0
- Gaps: 0

## Facts

- SECURE_CSP = { "default-src": [CSP.SELF], "script-src": [CSP.SELF, "https://cdn.jsdelivr.net/npm/ol@x.y.z/dist/ol.js"], "style-src": [CSP.SELF, "https://cdn.jsdelivr.net/npm/ol@x.y.z/ol.css"], "img-src": [CSP.SELF, "https://*.earthdata.nasa.gov"], } [e3580fbe]
- SECURE_CSP = { # other directives "img-src": [CSP.SELF, "https://tile.openstreetmap.org"], } [b8e2ceda]
- from django.utils.csp import CSP [ac6cbe5b3e28dda2-3]
- .. versionadded:: 6.0 [a1eb26d754a3d60c-2]
- .. versionadded:: 6.0 [a1eb26d754a3d60c-3]
- For example, to allow the default NASA Worldview base layer (replace ``x.y.z`` with the actual version):: [675c7bdf]
- The ``OSMWidget`` no longer uses a custom template. Consequently, the ``gis/openlayers-osm.html`` template was removed. [7d9ff81b]
- The default center latitude and longitude are ``47`` and ``5``, respectively, which is a location in eastern France. [bfc047ae]
- The default map zoom is ``12``. [e68d5b5c]
- This widget uses OpenStreetMap tiles instead of NASA Worldview. If :ref:`security-csp` enabled, both the OpenLayers CDN resources (as required by :class:`OpenLayersWidget`) and the OpenStreetMap tile servers must be allowed:: [6947efce]
- When :class:`~django.middleware.csp.ContentSecurityPolicyMiddleware` is enabled, the default OpenLayers CDN assets (``ol.js`` and ``ol.css``) will be blocked unless explicitly allowed. This can be addressed in one of two ways: **serve assets locally** by subclassing the widget and provide local copies of the JavaScript and CSS files, or **allow the CDN in the CSP policy**. [6c30968b]
- ``3857`` [65b00d17]
- ``gis/openlayers.html``. [018373ce]
- ``nasaWorldview`` [33db564b]
- ``osm`` [fd6021c2]
- class Media: js = ["path-to-file.js"] [82749525]
- .. _FAQ answer: https://help.openstreetmap.org/questions/10920/how-to-embed-a-map-in-my-https-site [10c9a6a2]
- .. admonition:: External assets with CSP [ab2ea649]
- .. admonition:: OpenStreetMap tiles with CSP [d9de53d9]
- .. attribute:: base_layer [c0163a524e190fae]
- .. attribute:: base_layer [c0163a524e190fae-2]
- .. attribute:: default_lat .. attribute:: default_lon [5f4ab8a3]
- .. attribute:: default_zoom [d72ce360]
- .. attribute:: map_srid [24d2c79d]
- .. attribute:: template_name [47ff310de933b083-3]
- .. versionadded:: 6.0 [a1eb26d754a3d60c-4]
- .. versionchanged:: 6.0 [57739e32d87f6c76-2]
- A string that specifies the identifier for the default base map layer to be used by the corresponding JavaScript map widget. It is passed as part of the widget options when rendering, allowing the ``MapWidget`` to determine which map tile provider or base layer to initialize (default is ``None``). [444aa566]
- Increase this value (or set to ``None``) only if you must accept legitimately deep geometries, since doing so reduces protection against fatal errors. [ffb8630a]

## Beyond the budget

71 more facts did not fit in the budget: [23eb1cec] [30d16d02] [ebc5a8f7] [af8cedbc] [9d35b6df] [ea61a4dc] [f61dc2d3] [a6d6d797] [8766e121] [f04b886b] [eef3d89f] [0a46f653] [de0af066] [4c752953] [5ca82209] [9101e0bd] [af8b9418] [72da92b1] [8a42c281] [ddb01c5d] [0291039e] [714f507f] [1486c93b] [51292336] [ade53835] [7f09b5f2] [94b8e583] [d2f1f379] [e0c31a39] [9a5fd27b] [4157ceb0] [160d780b6ce6fd6c] [3983ea1ab09d5868] [977fb9b7a523e42f] [bbf614d2ad7f98a6] [05cf772aa4fe68a8] [1365f1b7479fa4fc] [898be5ab] [768213fe] [1c408a7f583703aa] [28d5de5a729e7af3] [f1e4f19a] [bf478230] [a1eb26d754a3d60c-5] [72ce2834] [ecd3d075] [2ed09fd9] [ddc97a00] [fc9bde2e] [f3abdf93] [3a943ba7] [c88f96c0] [22382d1e] [d9fde206] [7aa26517] [e01318d5] [9ebf8216] [a23433c1] [3d1cd0ed68e7ef60] [6c06d2aefdf0cb8d] [442fee6fb28555e8] [9f19b9320977b49c] [0479ce898ba8a6e9] [2538f7a50bc0b974] [b2267739] [f7f640c1] [88b43530d52f6112] [f5cb4fc6fec3fdd7] [b2df608cab3f23a8] [f2a7c32a6ae7776e] [d57521a189731a2a]
