# Fact e0b78f7d

Store id: afbd5082-34cb-4c0a-954d-379d141a2db5

## Text

```text
class RawModelIterable(BaseIterable)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:04.2452220+00:00`

## Data

```json
{
  "end_line": 258,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 202,
  "symbol": "RawModelIterable"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":202,"selector":"L202-L258","symbol":"RawModelIterable"}`

## Items

```json
[
  {
    "text": "Iterable that yields a model instance for each row from a raw queryset.",
    "locator": {
      "line": 203
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::RawModelIterable](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 258,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 202,
    "symbol": "RawModelIterable"
  },
  "id": "afbd5082-34cb-4c0a-954d-379d141a2db5",
  "items": [
    {
      "locator": {
        "line": 203
      },
      "text": "Iterable that yields a model instance for each row from a raw queryset."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.2452220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 202,
        "selector": "L202-L258",
        "symbol": "RawModelIterable"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c19ea581-0dfe-46c0-b3bb-c6424abee89a",
  "subject_name": "django/db/models/query::RawModelIterable",
  "tags": [
    "entity:class"
  ],
  "text": "class RawModelIterable(BaseIterable)"
}
```
