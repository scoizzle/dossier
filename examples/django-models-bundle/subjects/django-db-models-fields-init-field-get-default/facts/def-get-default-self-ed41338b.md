# Fact ed41338b

Store id: 70cc9e27-a9fb-42c5-8ae6-59ea2b6c08f6

## Text

```text
def _get_default(self)
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
- posted_at: `2026-11-09T23:31:56.5258150+00:00`

## Data

```json
{
  "end_line": 1085,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1065,
  "symbol": "Field._get_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1065,"selector":"L1065-L1085","symbol":"Field._get_default"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._get_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1085,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1065,
    "symbol": "Field._get_default"
  },
  "id": "70cc9e27-a9fb-42c5-8ae6-59ea2b6c08f6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5258150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1065,
        "selector": "L1065-L1085",
        "symbol": "Field._get_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "3fb1e7e7-d417-4562-8604-f602454b1d83",
  "subject_name": "django/db/models/fields/__init__::Field._get_default",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def _get_default(self)"
}
```
