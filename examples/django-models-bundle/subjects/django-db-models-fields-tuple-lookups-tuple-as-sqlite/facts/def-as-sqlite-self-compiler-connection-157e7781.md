# Fact 157e7781

Store id: a303f1cf-f5c1-44ea-a5c7-63a2afeface5

## Text

```text
def as_sqlite(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:45.5516020+00:00`

## Data

```json
{
  "end_line": 47,
  "entity_kind": "method",
  "parent": "Tuple",
  "start_line": 38,
  "symbol": "Tuple.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":38,"selector":"L38-L47","symbol":"Tuple.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::Tuple.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 47,
    "entity_kind": "method",
    "parent": "Tuple",
    "start_line": 38,
    "symbol": "Tuple.as_sqlite"
  },
  "id": "a303f1cf-f5c1-44ea-a5c7-63a2afeface5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.5516020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 38,
        "selector": "L38-L47",
        "symbol": "Tuple.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "1fe7367e-a120-42d1-9740-d19a62f65d6d",
  "subject_name": "django/db/models/fields/tuple_lookups::Tuple.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection)"
}
```
