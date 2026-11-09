# Fact dc823e93

Store id: 0df9fe73-739f-4a5d-b247-a5371af3697b

## Text

```text
def _do_update( self, base_qs, using, pk_val, values, update_fields, forced_update, returning_fields, )
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
- posted_at: `2026-11-09T22:39:40.3415660+00:00`

## Data

```json
{
  "end_line": 1246,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 1208,
  "symbol": "Model._do_update"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1208,"selector":"L1208-L1246","symbol":"Model._do_update"}`

## Items

```json
[
  {
    "text": "Try to update the model. Return a list of updated fields if the model was updated (if an update query was done and a matching row was found in the DB).",
    "locator": {
      "line": 1218
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model._do_update](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1246,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 1208,
    "symbol": "Model._do_update"
  },
  "id": "0df9fe73-739f-4a5d-b247-a5371af3697b",
  "items": [
    {
      "locator": {
        "line": 1218
      },
      "text": "Try to update the model. Return a list of updated fields if the model was updated (if an update query was done and a matching row was found in the DB)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3415660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1208,
        "selector": "L1208-L1246",
        "symbol": "Model._do_update"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "a2d2abea-d1a7-47e7-8f8a-04885415bc57",
  "subject_name": "django/db/models/base::Model._do_update",
  "tags": [
    "entity:method"
  ],
  "text": "def _do_update( self, base_qs, using, pk_val, values, update_fields, forced_update, returning_fields, )"
}
```
