# Fact 157e7781

Store id: b9ccf6a6-663d-45d9-8865-a792fa4891f9

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
- posted_at: `2026-11-09T23:44:52.6892450+00:00`

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
  "id": "b9ccf6a6-663d-45d9-8865-a792fa4891f9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.6892450+00:00"
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
  "subject_id": "41b61444-2a41-4074-8eda-a660008e215b",
  "subject_name": "django/db/models/fields/tuple_lookups::Tuple.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection)"
}
```
