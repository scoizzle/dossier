# Fact 45e565eb

Store id: 70e2b251-bd47-47b4-9950-b5501c87ad3e

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
- posted_at: `2026-11-09T22:39:49.2161950+00:00`

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
  "id": "70e2b251-bd47-47b4-9950-b5501c87ad3e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.2161950+00:00"
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
  "subject_id": "07ccdfd4-bc8a-449b-a467-0b8066be9875",
  "subject_name": "django/db/models/query::RawModelIterable.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
