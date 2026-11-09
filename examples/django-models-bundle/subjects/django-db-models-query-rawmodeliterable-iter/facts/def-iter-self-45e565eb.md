# Fact 45e565eb

Store id: 3bf34e72-7f57-4a71-a0ff-4a42ef81d70e

## Text

```text
def __iter__(self)
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
- posted_at: `2026-11-09T23:44:55.7890130+00:00`

## Data

```json
{
  "end_line": 258,
  "entity_kind": "method",
  "parent": "RawModelIterable",
  "start_line": 207,
  "symbol": "RawModelIterable.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":207,"selector":"L207-L258","symbol":"RawModelIterable.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawModelIterable.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 258,
    "entity_kind": "method",
    "parent": "RawModelIterable",
    "start_line": 207,
    "symbol": "RawModelIterable.__iter__"
  },
  "id": "3bf34e72-7f57-4a71-a0ff-4a42ef81d70e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.7890130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 207,
        "selector": "L207-L258",
        "symbol": "RawModelIterable.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f04363c1-2b43-4cb1-a289-9b4d8e3c1f13",
  "subject_name": "django/db/models/query::RawModelIterable.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
