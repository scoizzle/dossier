# Fact 168048ae

Store id: d2dd230b-dd3c-4a30-bb8e-426c8a649869

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
- posted_at: `2026-11-09T23:32:00.6247530+00:00`

## Data

```json
{
  "end_line": 313,
  "entity_kind": "method",
  "parent": "TupleIn",
  "start_line": 304,
  "symbol": "TupleIn.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":304,"selector":"L304-L313","symbol":"TupleIn.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleIn.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 313,
    "entity_kind": "method",
    "parent": "TupleIn",
    "start_line": 304,
    "symbol": "TupleIn.get_prep_lookup"
  },
  "id": "d2dd230b-dd3c-4a30-bb8e-426c8a649869",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.6247530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 304,
        "selector": "L304-L313",
        "symbol": "TupleIn.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "9f3f3820-c735-49c7-88c2-e08de0079aeb",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIn.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
