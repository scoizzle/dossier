# Fact 938aafba

Store id: f25f7ff2-5333-473e-abe0-c5d0db86ce54

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
- posted_at: `2026-11-09T22:39:45.6410930+00:00`

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
  "id": "f25f7ff2-5333-473e-abe0-c5d0db86ce54",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.6410930+00:00"
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
  "subject_id": "0821184c-074f-4cef-96cc-620d6f557578",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIn.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
