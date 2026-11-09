# Fact 99a3985f

Store id: f45e9d60-fc61-42ea-962e-d846276352f7

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
- posted_at: `2026-11-09T22:39:48.0813370+00:00`

## Data

```json
{
  "end_line": 320,
  "entity_kind": "method",
  "parent": "FieldGetDbPrepValueIterableMixin",
  "start_line": 293,
  "symbol": "FieldGetDbPrepValueIterableMixin.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":293,"selector":"L293-L320","symbol":"FieldGetDbPrepValueIterableMixin.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::FieldGetDbPrepValueIterableMixin.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 320,
    "entity_kind": "method",
    "parent": "FieldGetDbPrepValueIterableMixin",
    "start_line": 293,
    "symbol": "FieldGetDbPrepValueIterableMixin.get_prep_lookup"
  },
  "id": "f45e9d60-fc61-42ea-962e-d846276352f7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.0813370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 293,
        "selector": "L293-L320",
        "symbol": "FieldGetDbPrepValueIterableMixin.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "8a85027e-e7ba-451b-9635-b9f557a4ec23",
  "subject_name": "django/db/models/lookups::FieldGetDbPrepValueIterableMixin.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```
