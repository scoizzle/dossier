# Fact 97f2844a

Store id: 3ab093db-5557-41ac-80bf-327031c054e0

## Text

```text
def name(self)
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
- posted_at: `2026-11-09T22:39:45.2897590+00:00`

## Data

```json
{
  "end_line": 71,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 69,
  "symbol": "ForeignObjectRel.name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":69,"selector":"L69-L71","symbol":"ForeignObjectRel.name"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 71,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 69,
    "symbol": "ForeignObjectRel.name"
  },
  "id": "3ab093db-5557-41ac-80bf-327031c054e0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.2897590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 69,
        "selector": "L69-L71",
        "symbol": "ForeignObjectRel.name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "2365e231-9cca-4851-819f-6e7d709ffa77",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.name",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def name(self)"
}
```
