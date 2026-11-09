# Fact aa5733e2

Store id: 04025bed-f83f-471c-ad1b-8d7de87ab633

## Text

```text
def __repr__(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.5158980+00:00`

## Data

```json
{
  "end_line": 63,
  "entity_kind": "method",
  "parent": "Deferred",
  "start_line": 62,
  "symbol": "Deferred.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":62,"selector":"L62-L63","symbol":"Deferred.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Deferred.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 63,
    "entity_kind": "method",
    "parent": "Deferred",
    "start_line": 62,
    "symbol": "Deferred.__repr__"
  },
  "id": "04025bed-f83f-471c-ad1b-8d7de87ab633",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5158980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 62,
        "selector": "L62-L63",
        "symbol": "Deferred.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "791fbb91-dcb1-483a-9414-fc9e3b8b5c44",
  "subject_name": "django/db/models/base::Deferred.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
