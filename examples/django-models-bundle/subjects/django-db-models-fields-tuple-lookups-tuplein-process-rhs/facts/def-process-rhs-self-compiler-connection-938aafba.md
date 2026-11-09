# Fact 938aafba

Store id: 1490cfbd-71c9-4beb-a289-c8544a9c1f2c

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
- posted_at: `2026-11-09T23:32:00.6364000+00:00`

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
  "id": "1490cfbd-71c9-4beb-a289-c8544a9c1f2c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.6364000+00:00"
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
  "subject_id": "5a5c5cec-ed46-421a-ae6c-7cddee019244",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIn.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
