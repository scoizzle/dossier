# Fact 6bd6f06e

Store id: 47dec0b2-3d6a-4dcb-85a8-f98ba1493ca0

## Text

```text
def allowed_default(self)
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
- posted_at: `2026-11-09T23:44:54.9093900+00:00`

## Data

```json
{
  "end_line": 208,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 206,
  "symbol": "Lookup.allowed_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":206,"selector":"L206-L208","symbol":"Lookup.allowed_default"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.allowed_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 208,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 206,
    "symbol": "Lookup.allowed_default"
  },
  "id": "47dec0b2-3d6a-4dcb-85a8-f98ba1493ca0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.9093900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 206,
        "selector": "L206-L208",
        "symbol": "Lookup.allowed_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "c4d9120b-25a4-4f14-87b0-f8854a0037e1",
  "subject_name": "django/db/models/lookups::Lookup.allowed_default",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def allowed_default(self)"
}
```
