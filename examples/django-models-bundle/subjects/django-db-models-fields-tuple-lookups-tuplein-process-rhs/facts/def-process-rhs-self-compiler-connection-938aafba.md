# Fact 938aafba

Store id: 8bc5e4b2-9336-4fd7-b386-02a286e596b3

## Text

```text
def process_rhs(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:52.7994530+00:00`

## Data

```json
{
  "end_line": 375,
  "entity_kind": "method",
  "parent": "TupleIn",
  "start_line": 341,
  "symbol": "TupleIn.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":341,"selector":"L341-L375","symbol":"TupleIn.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleIn.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 375,
    "entity_kind": "method",
    "parent": "TupleIn",
    "start_line": 341,
    "symbol": "TupleIn.process_rhs"
  },
  "id": "8bc5e4b2-9336-4fd7-b386-02a286e596b3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7994530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 341,
        "selector": "L341-L375",
        "symbol": "TupleIn.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "5091947e-4831-48bb-9b9f-4a809e56e9d5",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIn.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
