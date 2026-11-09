# Fact 18395ef1

Store id: 0f657f1a-ab3f-4e0f-885c-cef55c856715

## Text

```text
def cache_name(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:52.5012290+00:00`

## Data

```json
{
  "end_line": 248,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 242,
  "symbol": "ForeignObjectRel.cache_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":242,"selector":"L242-L248","symbol":"ForeignObjectRel.cache_name"}`

## Items

```json
[
  {
    "text": "Return the name of the cache key to use for storing an instance of the forward model on the reverse model.",
    "locator": {
      "line": 244
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.cache_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 248,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 242,
    "symbol": "ForeignObjectRel.cache_name"
  },
  "id": "0f657f1a-ab3f-4e0f-885c-cef55c856715",
  "items": [
    {
      "locator": {
        "line": 244
      },
      "text": "Return the name of the cache key to use for storing an instance of the forward model on the reverse model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.5012290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 242,
        "selector": "L242-L248",
        "symbol": "ForeignObjectRel.cache_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "daec492c-a3e3-4531-964e-03b1313923d7",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.cache_name",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def cache_name(self)"
}
```
