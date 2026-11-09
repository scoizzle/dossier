# Fact e6123c41

Store id: 1c3b87cc-c5e0-43be-8356-c1fc9c5142c7

## Text

```text
def __bool__(self)
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
- posted_at: `2026-11-09T23:32:04.7374910+00:00`

## Data

```json
{
  "end_line": 2497,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2495,
  "symbol": "RawQuerySet.__bool__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2495,"selector":"L2495-L2497","symbol":"RawQuerySet.__bool__"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.__bool__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2497,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2495,
    "symbol": "RawQuerySet.__bool__"
  },
  "id": "1c3b87cc-c5e0-43be-8356-c1fc9c5142c7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7374910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2495,
        "selector": "L2495-L2497",
        "symbol": "RawQuerySet.__bool__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "a3ec8e6a-e1da-4004-acc7-9b3f5c7fca08",
  "subject_name": "django/db/models/query::RawQuerySet.__bool__",
  "tags": [
    "entity:method"
  ],
  "text": "def __bool__(self)"
}
```
