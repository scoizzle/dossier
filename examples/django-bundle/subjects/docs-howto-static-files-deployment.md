# docs/howto/static-files/deployment

- Subject: docs/howto/static-files/deployment (id `8c794b28-0c99-48da-b430-95a9c84c1a26`)
- Kind: subject
- Budget: 1200 tokens
- Used: 875 tokens
- Facts shown: 20 of 33
- Conflicts: 0
- Gaps: 0

## Facts

- For an introduction to the use of :mod:`django.contrib.staticfiles`, see :doc:`/howto/static-files/index`. [606a193c]
- STORAGES = { # ... "staticfiles": {"BACKEND": "myproject.storage.S3Storage"} } [ab9940ed]
- * Nginx_ * A stripped-down version of Apache_ [ac3f6c4228e684da-2]
- * Push your code up to the deployment server. * On the server, run :djadmin:`collectstatic` to copy all the static files into :setting:`STATIC_ROOT`. * Configure your web server to serve the files in :setting:`STATIC_ROOT` under the URL :setting:`STATIC_URL`. For example, here's :ref:`how to do this with Apache and mod_wsgi <serving-files>`. [ca23cc2c]
- * Push your local :setting:`STATIC_ROOT` up to the static file server into the directory that's being served. `rsync <https://rsync.samba.org/>`_ is a common choice for this step since it only needs to transfer the bits of static files that have changed. [e390fd49]
- * When your static files change, run :djadmin:`collectstatic` locally. [71512e34]
- .. _Community Ecosystem: https://www.djangoproject.com/community/ecosystem/#storage-static-files .. _Static Builders grid: https://djangopackages.org/grids/g/static-builders/ [31e6a1e5]
- .. _Nginx: https://nginx.org/en/ .. _Apache: https://httpd.apache.org/ [7334fd784939ff19-2]
- .. _staticfiles-from-cdn: [6091b118]
- .. _staticfiles-production: [e58d1aa8]
- .. seealso:: [6b4a5e54e001d097-10]
- ========================== How to deploy static files ========================== [727a1b07]
- Another common tactic is to serve static files from a cloud storage provider like Amazon's S3 and/or a CDN (content delivery network). This lets you ignore the problems of serving static files and can often make for faster-loading web pages (especially when using a CDN). [70160db8]
- As with all deployment tasks, the devil's in the details. Every production setup will be a bit different, so you'll need to adapt the basic outline to fit your needs. Below are a few common patterns that might help. [0d4892c3]
- Configuring these servers is out of scope of this document; check each server's respective documentation for instructions. [c60efa24]
- For complete details on all the settings, commands, template tags, and other pieces included in :mod:`django.contrib.staticfiles`, see :doc:`the staticfiles reference </ref/contrib/staticfiles>`. [eafca99a]
- For details on how you'd write one of these backends, see :doc:`/howto/custom-file-storage`. There are 3rd party apps available that provide storage backends for many common file storage APIs. A good starting point is the `overview at djangopackages.org <https://djangopackages.org/grids/g/storage-backends/>`_. [580dfbdb]
- For example, if you've written an S3 storage backend in ``myproject.storage.S3Storage`` you could use it with:: [10873072]
- Having your Django application serve static files ------------------------------------------------- [890eb0a9]
- Learn more ========== [e4869dfb213f62a5]

## Beyond the budget

13 more facts did not fit in the budget: [746cccbe] [7952cabd] [bc2d89fd] [9a5d36da] [d38ef976] [11e207df] [9ade9c6d] [3ad433a0] [1874bfbf] [12de101d] [32aa3a10] [ced7041b] [dec40e52]
