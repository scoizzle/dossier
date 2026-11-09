# Fact ff3c73cb

Store id: 54696f35-c8d1-4c65-b063-a25ce8bdacd6

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
- posted_at: `2026-11-09T23:44:52.7588250+00:00`

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
  "id": "54696f35-c8d1-4c65-b063-a25ce8bdacd6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7588250+00:00"
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
  "subject_id": "74ab4039-44c7-4eec-a984-a81e5b925453",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIsNull.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
