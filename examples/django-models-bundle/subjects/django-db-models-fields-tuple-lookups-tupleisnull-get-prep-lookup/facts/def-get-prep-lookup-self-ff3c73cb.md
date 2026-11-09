# Fact ff3c73cb

Store id: 8f5fbb90-4fa9-4df4-b0c4-ad704cc3012a

## Text

```text
def get_prep_lookup(self)
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
- posted_at: `2026-11-09T23:32:00.5900080+00:00`

## Data

```json
{
  "end_line": 178,
  "entity_kind": "method",
  "parent": "TupleIsNull",
  "start_line": 170,
  "symbol": "TupleIsNull.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":170,"selector":"L170-L178","symbol":"TupleIsNull.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleIsNull.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 178,
    "entity_kind": "method",
    "parent": "TupleIsNull",
    "start_line": 170,
    "symbol": "TupleIsNull.get_prep_lookup"
  },
  "id": "8f5fbb90-4fa9-4df4-b0c4-ad704cc3012a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.5900080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 170,
        "selector": "L170-L178",
        "symbol": "TupleIsNull.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "429f92a8-58f0-4098-b979-87707891a4c5",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIsNull.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
