# Fact 6bd6f06e

Store id: a5b08bf4-cb70-4a0a-8136-43f8c7f28f7a

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
- posted_at: `2026-11-09T22:39:48.0456340+00:00`

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
  "id": "a5b08bf4-cb70-4a0a-8136-43f8c7f28f7a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.0456340+00:00"
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
  "subject_id": "6017153b-8db5-4f51-8d9d-f487ff49255f",
  "subject_name": "django/db/models/lookups::Lookup.allowed_default",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def allowed_default(self)"
}
```
