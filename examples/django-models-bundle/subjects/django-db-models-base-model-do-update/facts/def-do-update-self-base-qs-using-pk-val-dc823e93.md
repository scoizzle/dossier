# Fact dc823e93

Store id: 0d7bc889-57b7-426a-b990-79f2b4ddd09c

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
- posted_at: `2026-11-09T23:44:48.5355660+00:00`

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
  "id": "0d7bc889-57b7-426a-b990-79f2b4ddd09c",
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
    "posted_at": "2026-11-09T23:44:48.5355660+00:00"
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
  "subject_id": "638c7ef0-f591-4d16-b123-3c77e79cf843",
  "subject_name": "django/db/models/base::Model._do_update",
  "tags": [
    "entity:method"
  ],
  "text": "def _do_update( self, base_qs, using, pk_val, values, update_fields, forced_update, returning_fields, )"
}
```
